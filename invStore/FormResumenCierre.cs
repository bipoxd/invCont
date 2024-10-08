using System;
using System.Windows.Forms;

namespace invStore
{
    public partial class FormResumenCierre : Form
    {
        private decimal totalEfectivo;
        private decimal totalDebito;
        private decimal totalCredito;
        private decimal totalVentas;
        private decimal retiroEfectivo;
        private string operador;
        private DateTime fechaCierre;
        private decimal montoApertura;

        // Constructor que recibe los datos del cierre
        public FormResumenCierre(decimal totalEfectivo, decimal totalDebito, decimal totalCredito, decimal totalVentas, decimal retiroEfectivo, string operador, DateTime fechaCierre)
        {
            InitializeComponent();

            // Asignar los valores a las variables de la clase
            this.totalEfectivo = totalEfectivo;
            this.totalDebito = totalDebito;
            this.totalCredito = totalCredito;
            this.totalVentas = totalVentas;
            this.retiroEfectivo = retiroEfectivo;
            this.operador = operador;
            this.fechaCierre = fechaCierre;

            // Mostrar los valores en las etiquetas (labels)
            MostrarResumen();
        }

        // Método para mostrar los datos en el formulario
        private void MostrarResumen()
        {
            lblEfectivo.Text = $"Total Efectivo: ${totalEfectivo:N0}";
            lblDebito.Text = $"Total Débito: ${totalDebito:N0}";
            lblCredito.Text = $"Total Crédito: ${totalCredito:N0}";
            lblTotalVentas.Text = $"Total Ventas: ${totalVentas:N0}";
          //  lblRetiroEfectivo.Text = $"Retiro de Efectivo: ${retiroEfectivo:N0}";
           // lblOperador.Text = $"Operador: {operador}";
            lblFecha.Text = $"Fecha del Cierre: {fechaCierre.ToString("dd/MM/yyyy")}";
        }
    }
}
