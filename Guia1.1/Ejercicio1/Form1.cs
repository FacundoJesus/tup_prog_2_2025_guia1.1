using Ejercicio1.Models;
namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            //Creo objeto de la ventana de dialogo
            Form2 ventanaModal = new Form2();

            //Almaceno los datos en variables
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nudModelo.Value);
            double valorFabricacion = Convert.ToDouble(tbValorFabricacion.Text);

            double tasaDepreciacion = Convert.ToDouble(tbTasaDepreciacion.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);
            int a�oACalcular = Convert.ToInt32(nudA�oACalcular.Value);

            //Creo el 1� objeto "moto"
            Moto moto = new Moto(marca, modelo, valorFabricacion);
            //Calculo las depreciaciones anual y lineal.
            double valorLineal = moto.CalcularDepreciacionLineal(a�oACalcular, vidaUtil);
            double valorAnual = moto.CalcularDepreciacionAnual(a�oACalcular, tasaDepreciacion);

            //Cargo los resultados en el ListBoxs de la ventana modal
            ventanaModal.lsbResultado.Items.Add(moto.VerDescripcion());
            ventanaModal.lsbResultado.Items.Add($"Depreciacion Lineal: {valorLineal:c2}");
            ventanaModal.lsbResultado.Items.Add($"Depreciaci�n Anual : {valorAnual:c2}");

            //Muestro la ventana
            ventanaModal.ShowDialog();

            tbMarca.Clear();
            nudModelo.Value = 0;
            tbValorFabricacion.Clear();
            tbTasaDepreciacion.Clear();
            tbVidaUtil.Clear();
            nudA�oACalcular.Value = 0;
            //Libero Recursos
            ventanaModal.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
