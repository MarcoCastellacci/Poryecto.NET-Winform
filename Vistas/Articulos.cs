using Codigo_Comun.Entity;
using App_Stock.Vistas;
using Codigo_Comun.Datos;
using Codigo_Comun.Negocio;
using Codigo_Comun.Modelos;

namespace App_Stock
{
    public partial class Articulos : Form
    {

        public Articulos()
        {
            InitializeComponent();
            CargarArticulos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarArticuloForm cargarArticuloForm = new CargarArticuloForm();
            cargarArticuloForm.Show();
        }

        private void CargarArticulos()
        {
            List<Articulo> articulosEnStock = new List<Articulo>();
            ArticuloRepository articuloAMostrar = new ArticuloRepository();
            articulosEnStock = articuloAMostrar.GetArticulosCompletos();

            dsArticulo.DataSource = articulosEnStock;
        }

        private void dsArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int IdArticuloParaModificar = Convert.ToInt32(txtID.Text);

            CargarArticuloForm formularioModificar = new CargarArticuloForm(IdArticuloParaModificar);
            formularioModificar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdParaEliminar = Convert.ToInt32(this.txtID.Text);
            ArticuloServices articuloAEliminar = new ArticuloServices();
            string mensaje = articuloAEliminar.EliminarArticulo(IdParaEliminar);

            if (mensaje == "Articulo Eliminado de la Base de Dato")
            {
                MessageBox.Show("Articulo Eliminado");
            }
            else
            {
                MessageBox.Show($"{mensaje}");
            }
        }
    }
}