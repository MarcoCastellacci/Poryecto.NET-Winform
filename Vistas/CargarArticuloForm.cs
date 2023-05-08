using Codigo_Comun.Datos;
using Codigo_Comun.Entity;
using Codigo_Comun.Modelos;
using Codigo_Comun.Modelos.DTO;
using Codigo_Comun.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Stock.Vistas
{
    public partial class CargarArticuloForm : Form
    {
        public bool ArticuloAModificar { set; get; }

        public CargarArticuloForm()
        {
            ArticuloAModificar = false;
            InitializeComponent();
        }

        public CargarArticuloForm(int IdArticuloParaModificar)
        {
            InitializeComponent();
            ArticuloAModificar = true;
            ArticuloAModificarDatos(IdArticuloParaModificar);
        }

        private void ArticuloAModificarDatos(int idArituculoParaModificar)
        {
            ArticuloRepository articuloParaModificar = new ArticuloRepository();

            Articulo articuloEnBaseDeDatos = articuloParaModificar.GetArticuloPorId(idArituculoParaModificar);

            //cargo datos en pantalla
            txtNombre.Text = articuloEnBaseDeDatos.Nombre;
            txtMarca.Text = articuloEnBaseDeDatos.Marca;
            txtTipo.Text = articuloEnBaseDeDatos.Tipo;
            txtProveedor.Text = articuloEnBaseDeDatos.Proveedor;
            minStockNum.Value = (decimal)articuloEnBaseDeDatos.MinStock;
            costoNum.Value = (decimal)articuloEnBaseDeDatos.Costo;
            margenNum.Value = (decimal)articuloEnBaseDeDatos.Margen;
            txtId.Text = articuloEnBaseDeDatos.Id.ToString();
            txtCodigo.Text = articuloEnBaseDeDatos.Codigo;

        }

        private void ModificarArticulo()
        {

            ArticuloDTO articuloModificado = new ArticuloDTO();
            articuloModificado.Nombre = txtNombre.Text;
            articuloModificado.Marca = txtMarca.Text;
            articuloModificado.Tipo = txtTipo.Text;
            articuloModificado.Proveedor = txtProveedor.Text;
            articuloModificado.MinStock = minStockNum.Value;
            articuloModificado.Costo = costoNum.Value;
            articuloModificado.Margen = margenNum.Value;
            articuloModificado.Codigo = txtCodigo.Text;
            articuloModificado.Id = Convert.ToInt32(txtId.Text);

            ArticuloServices articuloMod = new ArticuloServices();
            articuloModificado = articuloMod.ModificarArticulo(articuloModificado);

            if (articuloModificado.Error == false)
            {
                MessageBox.Show("Articulo modificado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show($"{articuloModificado.Mensaje}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ArticuloAModificar == true)
            {
                ModificarArticulo();
            }
            else
            {
                AgregarArticulo();
            }
        }

        private void AgregarArticulo()
        {
            ArticuloDTO articulo = new ArticuloDTO();
            {
                articulo.Nombre = txtNombre.Text;
                articulo.Marca = txtMarca.Text;
                articulo.Tipo = txtTipo.Text;
                articulo.Proveedor = txtProveedor.Text;
                articulo.Costo = Convert.ToDecimal(costoNum.Value);
                articulo.MinStock = Convert.ToDecimal(minStockNum.Value);
                articulo.Margen = Convert.ToDecimal(margenNum.Value);
                articulo.Codigo = txtCodigo.Text;
            }

            ArticuloServices articuloServices = new ArticuloServices();
            articulo = articuloServices.AgregarArticuloBD(articulo);
            //int resultado = articulo.AgregarArticulo();
            //Console.WriteLine(resultado);
            if (articulo.Error == false)
            {
                MessageBox.Show("Artiuclo agregado en la Base");
            }
            else
            {
                MessageBox.Show(articulo.Mensaje);
                return;
            }
        }
    }
}
