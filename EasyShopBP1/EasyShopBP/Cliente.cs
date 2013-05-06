using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseDatos;

namespace EasyShopBP
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

       
        private void LimpiarCampos()
        {
            this.txtCedula.Clear();
            this.txtNomCl.Clear();
            this.txtApellidoCl.Clear();
            this.txtDirCl.Clear();
            this.txtTelefCl.Clear();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if (txtCedula.Text == "")
            {
                MessageBox.Show("ingrese Cedula");
                txtCedula.Focus();
                return;
            }

            else if (txtNomCl.Text == "")
            {
                MessageBox.Show("ingrese Nombre");
                txtNomCl.Focus();
                return;
            }
            else if (txtApellidoCl.Text == "")
            {
                MessageBox.Show("ingrese Apellido");
                txtApellidoCl.Focus();
                return;
            }
            else if (txtDirCl.Text == "")
            {
                MessageBox.Show("ingrese Direccion");
                txtDirCl.Focus();
                return;     
            }
            else if (txtTelefCl.Text =="")
            {
                MessageBox.Show("ingrese Teléfono");
                txtTelefCl.Focus();
                return;
            }

            ClasesTipos objImpresion = new ClasesTipos();

            objImpresion.CrearCliente(txtCedula.Text , txtNomCl.Text, txtApellidoCl.Text, txtDirCl.Text, txtTelefCl.Text);
            MessageBox.Show("El Cliente "+txtNomCl.Text+" ha sido Ingresado");

            this.LimpiarCampos();
            btnBaseCliente_Click(sender, e);
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
                if (!(txtCedula.Text == "" || txtNomCl.Text == "" ||  txtApellidoCl.Text == "" || txtDirCl.Text == "" || txtTelefCl.Text == ""))
                {
                    ClasesTipos objClasesEnumeradas = new ClasesTipos();
                    objClasesEnumeradas.EliminarCliente(txtCedula.Text);
                }

                else
                {
                    MessageBox.Show("Campos Incompletos");
                    return;
                }

                MessageBox.Show("Eliminado Exitosamente");
                btnBaseCliente_Click(sender ,e);
                this.LimpiarCampos();
                

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                MessageBox.Show("ingrese Cedula");
                txtCedula.Focus();
                return;
            }

            else if (txtNomCl.Text == "")
            {
                MessageBox.Show("ingrese Nombre");
                txtNomCl.Focus();
                return;
            }
            else if (txtApellidoCl.Text == "")
            {
                MessageBox.Show("ingrese Apellido");
                txtApellidoCl.Focus();
                return;
            }
            else if (txtDirCl.Text == "")
            {
                MessageBox.Show("ingrese Direccion");
                txtDirCl.Focus();
                return;
            }
            else if (txtTelefCl.Text == "")
            {
                MessageBox.Show("ingrese Teléfono");
                txtTelefCl.Focus();
                return;
            }
         
            ClasesTipos objImpresion = new ClasesTipos();

            objImpresion.ActualizarCliente(txtCedula.Text, txtNomCl.Text, txtApellidoCl.Text, txtDirCl.Text, txtTelefCl.Text);
            MessageBox.Show("Cliente actualizado");

            btnBaseCliente_Click(sender, e);
            this.LimpiarCampos();
        }

        private void btnBaseCliente_Click(object sender, EventArgs e)
        {
            ClasesTipos objProducto = new ClasesTipos();

            DataTable objDato = new DataTable();

            objDato = objProducto.ConsultarCliente();


            GridViewCliente.DataSource = objDato;
        }

        private void GridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = GridViewCliente.Rows[GridViewCliente.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtNomCl.Text = GridViewCliente.Rows[GridViewCliente.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtApellidoCl.Text = GridViewCliente.Rows[GridViewCliente.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtDirCl.Text = GridViewCliente.Rows[GridViewCliente.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtTelefCl.Text = GridViewCliente.Rows[GridViewCliente.CurrentCell.RowIndex].Cells[4].Value.ToString();

            txtCedula.Enabled = false;
        }
        }
    }

