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
    public partial class FormCargaStock : Form
    {

        public bool StockModificable { get; set; }
        private StockRepository repository = new StockRepository();
        private StockServices stockServicies = new StockServices();

        public FormCargaStock(int idStcokAModificar)
        {
            StockModificable = true;
            InitializeComponent();
            CargaStock();
            StockAModificarDatos(idStcokAModificar);
        }

        public FormCargaStock()
        {
            StockModificable = false;
            InitializeComponent();
            CargaStock();
        }

        private void StockAModificarDatos(int IdStockParaActualizar)
        {
            Stock stockEnBD = repository.GetStockById(IdStockParaActualizar);

            //cargo datos en pantalla
            //cbArticulos.DisplayMember = stockEnBD.IdArticuloNavigation.Nombre;
            //cbDepositos.DisplayMember = stockEnBD.IdDepositoNavigation.Nombre;
            capacidadNum.Value = (decimal)stockEnBD.Cantidad;
            txtId.Text = stockEnBD.Id.ToString();

        }

        private void ModificarStock()
        {

            StockDTO stcokModificado = new StockDTO();
            var depoSelected = cbDepositos.SelectedItem;
            var artSelected = cbArticulos.SelectedItem;
            var artAux = (Articulo)artSelected;
            var depoAux = (Deposito)depoSelected;
            
                stcokModificado.IdDeposito = depoAux.Id;
                stcokModificado.IdArticulo = artAux.Id;
                stcokModificado.Cantidad = capacidadNum.Value;
                stcokModificado.Id = Convert.ToInt32(txtId.Text);


            stcokModificado = stockServicies.ModificarStock(stcokModificado);

            if (stcokModificado.Error == false)
            {
                MessageBox.Show("Stock modificado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show($"{stcokModificado.Mensaje}");
            }
        }

        public void CargaStock()
        {
            List<Deposito> depositos = new List<Deposito>();
            List<Articulo> articulo = new List<Articulo>();

            DepositoServices depoAux = new DepositoServices();
            ArticuloServices artAux = new ArticuloServices();
            depositos = depoAux.ObtenerTodosDepositos();
            articulo = artAux.GetArticulos();

            cbDepositos.DataSource = new BindingSource(depositos, null);
            cbDepositos.DisplayMember = "Nombre";
            cbDepositos.ValueMember = "Id";

            cbArticulos.DataSource = new BindingSource(articulo, null);
            cbArticulos.DisplayMember = "Nombre";
            cbArticulos.ValueMember = "Id";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StockModificable == true)
            {
                ModificarStock();
            }
            else
            {
                AgregarStock();
            }
        }

        private void AgregarStock()
        {
            var depoSelected = cbDepositos.SelectedItem;
            var artSelected = cbArticulos.SelectedItem;
            var artAux = (Articulo)artSelected;
            var depoAux = (Deposito)depoSelected;

            StockDTO stockAAgregar = new StockDTO();
            {
                //    stockAAgregar.IdArticuloNavigation = (Articulo)artSelected;
                //    stockAAgregar.IdDepositoNavigation = (Deposito)depoSelected;
                stockAAgregar.IdDeposito = depoAux.Id;
                stockAAgregar.IdArticulo = artAux.Id;
                stockAAgregar.Cantidad = capacidadNum.Value;
            }

            stockAAgregar = stockServicies.AgregarStock(stockAAgregar);

            if (stockAAgregar.Error == false)
            {
                MessageBox.Show("Agrego en la DB");
            }
            else
            {
                MessageBox.Show($"{stockAAgregar.Mensaje}");
                return;
            }
        }
    }
}
