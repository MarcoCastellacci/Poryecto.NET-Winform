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
    public partial class App_Stock : Form
    {
        public App_Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulos articuloApp = new Articulos();
            articuloApp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Depositos depositoApp = new Depositos();
            depositoApp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stocks stockApp = new Stocks();
            stockApp.Show();
        }
    }
}
