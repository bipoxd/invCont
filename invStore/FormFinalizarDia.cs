using Npgsql;
using System;
using System.Windows.Forms;

namespace invStore
{
    public partial class FormFinalizarDia : Form
    {
        private decimal montoInicialCaja;
        private decimal totalEfectivo;
        private decimal totalDebito;  // Declarado a nivel de clase
        private decimal totalCredito; // Declarado a nivel de clase

        public FormFinalizarDia()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CalcularTotales(DateTime.Now.Date); // Pasar la fecha actual o cualquier fecha específica

            // Asignar el evento TextChanged a txtEfectivoRetirado
            txtEfectivoRetirado.TextChanged += TxtEfectivoRetirado_TextChanged;
        }

        private void CalcularTotales(DateTime fechaSeleccionada)
        {
            totalEfectivo = 0;
            totalDebito = 0;
            totalCredito = 0;

            string connectionString = "Host=autorack.proxy.rlwy.net;Port=21434;Username=postgres;Password=YeRYuiLMrmWePLNVhDrDLCUlCazYKmjO;Database=railway;Ssl Mode=Require;";

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener el monto inicial de la caja para la fecha seleccionada
                    string queryMontoInicial = "SELECT aper_montoinicial " +
                                               "FROM apertura " +
                                               "WHERE aper_fecha = @fecha";

                    using (var commandMontoInicial = new NpgsqlCommand(queryMontoInicial, connection))
                    {
                        commandMontoInicial.Parameters.AddWithValue("@fecha", fechaSeleccionada);
                        var result = commandMontoInicial.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out montoInicialCaja))
                        {
                            // El monto inicial de la caja se ha obtenido correctamente
                        }
                        else
                        {
                            montoInicialCaja = 0; // Valor predeterminado si no se encuentra el monto
                        }
                    }

                    // Obtener los totales de ventas
                    string queryVentas = "SELECT vent_mediopago, COALESCE(SUM(vent_total), 0) AS TotalVentas " +
                                         "FROM ventafinalizada " +
                                         "WHERE vent_fecha::date = @fecha " +
                                         "GROUP BY vent_mediopago";

                    using (var commandVentas = new NpgsqlCommand(queryVentas, connection))
                    {
                        commandVentas.Parameters.AddWithValue("@fecha", fechaSeleccionada);
                        using (var reader = commandVentas.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string medioPago = reader.GetString(0).ToLower();
                                decimal total = reader.GetDecimal(1);

                                switch (medioPago)
                                {
                                    case "efectivo":
                                        totalEfectivo = total;
                                        break;
                                    case "debito":
                                        totalDebito = total;
                                        break;
                                    case "credito":
                                        totalCredito = total;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular totales: {ex.Message}");
            }

            // Mostrar los totales en los TextBoxes con separador de miles y signo de peso
            lblEfectivo.Text = $"${totalEfectivo:N0}";
            lblDebito.Text = $"${totalDebito:N0}";
            lblCredito.Text = $"${totalCredito:N0}";

            // Mostrar el monto inicial de la caja
            lblMontoInicial.Text = $"${montoInicialCaja:N0}";

            // Calcular el total del efectivo en la caja
            decimal totalEfectivoCaja = totalEfectivo + montoInicialCaja;
            lblTotalEfectivoCaja.Text = $"${totalEfectivoCaja:N0}";

            // Calcular el total de ventas del día
            decimal totalVentasDelDia = totalEfectivo + totalDebito + totalCredito;
            lblTotalVentas.Text = $"${totalVentasDelDia:N0}";

            // Inicializar el campo de retiro y monto en caja
            txtEfectivoRetirado.Text = "0";
            lblMonto.Text = "$" + totalEfectivoCaja.ToString("N0");
        }

        private void TxtEfectivoRetirado_TextChanged(object sender, EventArgs e)
        {
            // Validar y actualizar el monto de la caja
            decimal retiroEfectivo;
            decimal montoEnCaja = totalEfectivo + montoInicialCaja;

            if (decimal.TryParse(txtEfectivoRetirado.Text, out retiroEfectivo))
            {
                if (retiroEfectivo > montoEnCaja)
                {
                    MessageBox.Show("El monto de retiro no puede ser mayor al total disponible.");
                    txtEfectivoRetirado.Text = montoEnCaja.ToString("N0");
                    return;
                }

                // Calcular el monto restante en caja
                decimal montoRestanteCaja = montoEnCaja - retiroEfectivo;
                lblMonto.Text = "$" + montoRestanteCaja.ToString("N0");
            }
            else
            {
                lblMonto.Text = "$" + montoEnCaja.ToString("N0");
            }
        }

        private void btnRegistrarCierre_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=autorack.proxy.rlwy.net;Port=21434;Username=postgres;Password=YeRYuiLMrmWePLNVhDrDLCUlCazYKmjO;Database=railway;Ssl Mode=Require;";

            // Datos que serán guardados en la tabla cierres
            decimal retiroEfectivo = decimal.Parse(txtEfectivoRetirado.Text);  // Retiro de efectivo
            decimal totalVentasDelDia = totalEfectivo + totalDebito + totalCredito;  // Total de ventas
            string operador = "TEST OPERATOR";  // Suponiendo que hay un campo para el operador
            DateTime fechaCierre = DateTime.Now;

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Validar si ya se ha registrado un cierre para el día
                    string validarCierreQuery = "SELECT COUNT(*) FROM cierres WHERE cie_fecha = @fecha";
                    using (var commandValidacion = new NpgsqlCommand(validarCierreQuery, connection))
                    {
                        commandValidacion.Parameters.AddWithValue("@fecha", fechaCierre.Date);
                        long count = (long)commandValidacion.ExecuteScalar(); // Usar long en lugar de int
                        if (count > 0)
                        {
                            MessageBox.Show("Ya se ha registrado un cierre para el día de hoy.");
                            return;
                        }
                    }

                    // Query de inserción en la tabla cierres
                    string insertCierreQuery = @"INSERT INTO cierres (cie_totalefectivo, cie_totaldebito, cie_totalcredito, cie_total, cie_retiroefectivo, cie_operador, cie_fecha) 
                                         VALUES (@totalEfectivo, @totalDebito, @totalCredito, @totalVentas, @retiroEfectivo, @operador, @fechaCierre)";

                    using (var command = new NpgsqlCommand(insertCierreQuery, connection))
                    {
                        // Asignar parámetros a la consulta
                        command.Parameters.AddWithValue("@totalEfectivo", totalEfectivo);
                        command.Parameters.AddWithValue("@totalDebito", totalDebito);
                        command.Parameters.AddWithValue("@totalCredito", totalCredito);
                        command.Parameters.AddWithValue("@totalVentas", totalVentasDelDia);
                        command.Parameters.AddWithValue("@retiroEfectivo", retiroEfectivo);
                        command.Parameters.AddWithValue("@operador", operador);  // Usar el operador definido
                        command.Parameters.AddWithValue("@fechaCierre", fechaCierre);

                        // Ejecutar la inserción
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos del cierre registrados correctamente.");

                    // Redirigir al formulario de resumen del cierre
                    FormResumenCierre resumenCierre = new FormResumenCierre(totalEfectivo, totalDebito, totalCredito, totalVentasDelDia, retiroEfectivo, operador, fechaCierre);
                    resumenCierre.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el cierre: {ex.Message}");
            }
        }
    }
}
