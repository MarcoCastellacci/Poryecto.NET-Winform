using Codigo_Comun.Datos;
using Codigo_Comun.Entity;
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
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
            CargarStocks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCargaStock formCarga = new FormCargaStock();
            formCarga.Show();
        }

        private void CargarStocks()
        {
            List<Stock> stocks = new List<Stock>();
            StockRepository repository = new StockRepository();
            stocks = repository.GetStocks();

            dgvStock.DataSource = stocks;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idStockAModificar = Convert.ToInt32(txtID.Text);

            FormCargaStock formCargaStock = new FormCargaStock(idStockAModificar);   
            formCargaStock.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdParaEliminar = Convert.ToInt32(this.txtID.Text);
            StockRepository stockParaEliminar = new StockRepository();
            int r = stockParaEliminar.EliminarStock(IdParaEliminar);

            if (r == 1)
            {
                MessageBox.Show("Stock Eliminado");
            }
            else
            {
                MessageBox.Show("No se ha podido completar la accion");
            }
        }
    }
}
