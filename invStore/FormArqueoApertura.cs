using System;
using System.Windows.Forms;
using Npgsql; // Asegúrate de incluir esta librería para PostgreSQL

namespace invStore
{
    public partial class FormArqueoApertura : Form
    {
        public FormArqueoApertura()
        {
            InitializeComponent();
        }

        private void FormArqueoApertura_Load(object sender, EventArgs e)
        {
            lblFechaApertura.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraApertura.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar y convertir caja inicial
            int cajaInicial;
            if (!int.TryParse(txtCajaInicial.Text, out cajaInicial))
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido para el monto inicial.");
                return; // Si no es un número válido, salir del método
            }

            // Otros datos
            string operador = txtOperador.Text;
            DateTime fechaApertura = DateTime.Now.Date; // Fecha actual sin la hora
            DateTime horaApertura = DateTime.Now; // Hora completa en formato DateTime (almacenará la misma fecha que fechaApertura)

            // Tu cadena de conexión para PostgreSQL
            string connectionString = "Host=autorack.proxy.rlwy.net;Port=21434;Username=postgres;Password=YeRYuiLMrmWePLNVhDrDLCUlCazYKmjO;Database=railway;Ssl Mode=Require;";

            // Consulta SQL
            string query = "INSERT INTO apertura (aper_montoinicial, aper_operador, aper_fecha, aper_hora) " +
                           "VALUES (@montoInicial, @operador, @fechaApertura, @horaApertura)";

            // Ejecutar la inserción usando Npgsql
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Añadir parámetros
                    command.Parameters.AddWithValue("@montoInicial", cajaInicial); // Ya convertido a int
                    command.Parameters.AddWithValue("@operador", operador);
                    command.Parameters.AddWithValue("@fechaApertura", fechaApertura); // Tipo DateTime, se almacena solo la fecha
                    command.Parameters.AddWithValue("@horaApertura", horaApertura);  // También es DateTime, PostgreSQL truncará los detalles innecesarios

                    try
                    {
                        // Abrir conexión e insertar datos
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Datos guardados correctamente");
                        this.Hide();
                        // Abrir el formulario de ventas
                        FormVenta venta = new FormVenta();
                        venta.ShowDialog();
                        this.Hide();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los datos: " + ex.Message);
                    }
                }
            }
        }
    }
}
