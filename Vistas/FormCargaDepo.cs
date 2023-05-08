using Codigo_Comun.Datos;
using Codigo_Comun.Entity;
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
    public partial class FormCargaDepo : Form
    {
        public bool DepositoAModificar { set; get; }

        public FormCargaDepo()
        {
            DepositoAModificar = false;
            InitializeComponent();
        }

        public FormCargaDepo(int IdDepositoAModificar)
        {
            InitializeComponent();
            DepositoAModificar = true;
            DepositoAModificarDatos(IdDepositoAModificar);

        }

        private void DepositoAModificarDatos(int IdDepositoAModificar)
        {
            DepositoRepository articuloParaModificar = new DepositoRepository();

            Deposito depositoEnBD = articuloParaModificar.GetDepositoById(IdDepositoAModificar);

            //cargo datos en pantalla
            txtNombre.Text = depositoEnBD.Nombre;
            txtDireccion.Text = depositoEnBD.Direccion;
            txtHorario.Text = depositoEnBD.Horario;
            txtTelefono.Text = depositoEnBD.Telefono;
            capacidadNum.Value = (decimal)depositoEnBD.Capacidad;
            txtId.Text = depositoEnBD.Id.ToString();

        }

        private void ModificarDeposito()
        {

            DepositoDTO depositoModificado = new DepositoDTO();
            depositoModificado.Nombre = txtNombre.Text;
            depositoModificado.Direccion = txtDireccion.Text;
            depositoModificado.Horario = txtHorario.Text;
            depositoModificado.Telefono = txtTelefono.Text;
            depositoModificado.Capacidad = capacidadNum.Value;
            depositoModificado.Id = Convert.ToInt32(txtId.Text);

            DepositoServices depositoMod = new DepositoServices();
            depositoModificado = depositoMod.Modificardeposito(depositoModificado);

            if (depositoModificado.Error == false)
            {
                MessageBox.Show("Deposito modificado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show($"{depositoModificado.Mensaje}");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (DepositoAModificar == true)
            {
                ModificarDeposito();
            }
            else
            {
                AgregarDeposito();
            }
           
        }

        private void AgregarDeposito()
        {
            DepositoDTO deposito = new DepositoDTO();
            {
                deposito.Nombre = txtNombre.Text;
                deposito.Direccion = txtDireccion.Text;
                deposito.Telefono = txtTelefono.Text;
                deposito.Horario = txtHorario.Text;
                deposito.Capacidad = Convert.ToDecimal(capacidadNum.Value);
            }

            DepositoServices depoTemp = new DepositoServices();
            deposito = depoTemp.AddDeposito(deposito);
            //Console.WriteLine(mensaje);

            if (deposito.Error == false)
            {
                MessageBox.Show($"Se ha agregado el Deposito {deposito.Nombre}");
            }
            else
            {
                MessageBox.Show($"{deposito.Mensaje}");
                return;
            }
        }
        private void lsArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
