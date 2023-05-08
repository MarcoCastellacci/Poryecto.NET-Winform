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
    public partial class Depositos : Form
    {
        public Depositos()
        {
            InitializeComponent();
            CargarDepositos();
        }

        public void CargarDepositos()
        {

            List<Deposito> depositos = new List<Deposito>();
            DepositoRepository DepositosEnLista = new DepositoRepository();
            depositos = DepositosEnLista.GetDepositos();

            dsDepositos.DataSource = depositos;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            FormCargaDepo formCargaDepo = new FormCargaDepo();
            formCargaDepo.Show();
        }

        // Boton de eliminar
        private void button1_Click(object sender, EventArgs e)
        {
            int IdParaEliminar = Convert.ToInt32(this.txtID.Text);
            DepositoServices DepositoParaEliminar = new DepositoServices();
            string mensaje = DepositoParaEliminar.EliminarDeposito(IdParaEliminar);

            if (mensaje == "Deposito Eliminado de la Base de Dato")
            {
                MessageBox.Show("Deposito Eliminado");
            }
            else
            {
                MessageBox.Show($"{mensaje}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdDepositoParaModificar = Convert.ToInt32(txtID.Text);

            FormCargaDepo formularioModificar = new FormCargaDepo(IdDepositoParaModificar);
            formularioModificar.Show();
        }

        private void dsDepositos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
