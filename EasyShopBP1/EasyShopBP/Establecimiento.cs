using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopBP
{
    public partial class Establecimiento : Form
    {
        public Establecimiento()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            this.txtIDEst.Clear();
            this.txtNombreEst.Clear();
            this.txtTelefonoEst.Clear();
            this.txtDireccionEst.Clear();

        }

        private void btnGuardarProv_Click(object sender, EventArgs e)
        {

            if (txtIDEst.Text == "")
            {
                MessageBox.Show("ingrese ID");
                txtIDEst.Focus();
                return;
            }

            else if (txtNombreEst.Text == "")
            {
                MessageBox.Show("ingrese Nombre");
                txtNombreEst.Focus();
                return;
            }

            else if (txtTelefonoEst.Text == "")
            {
                MessageBox.Show("ingrese Teléfono");
                txtTelefonoEst.Focus();
                return;
            }

            else if (txtDireccionEst.Text == "")
            {
                MessageBox.Show("ingrese Direccion");
                txtDireccionEst.Focus();
                return;
            }


            ClasesTipos objImpresion = new ClasesTipos();

            objImpresion.CrearProveedor(txtIDEst.Text, txtNombreEst.Text, txtTelefonoEst.Text, txtDireccionEst.Text);
            MessageBox.Show("El Establecimiento" + txtNombreEst.Text + " se ha registrado");

            this.LimpiarCampos();
            btnBaseEstablecimientos_Click(sender, e);

        }

        private void btnEliminarEst_Click(object sender, EventArgs e)
        {

            if (!(txtIDEst.Text == "" || txtNombreEst.Text == "" || txtTelefonoEst.Text == "" || txtDireccionEst.Text == ""))
            {
                ClasesTipos objClasesEnumeradas = new ClasesTipos();
                objClasesEnumeradas.EliminarCliente(txtIDEst.Text);
            }

            else
            {
                MessageBox.Show("Campos Incompletos");
                return;
            }

            MessageBox.Show("Eliminado Exitosamente");
            btnBaseEstablecimientos_Click(sender, e);
            this.LimpiarCampos();


        }

        private void btnUpdateEst_Click(object sender, EventArgs e)
        {
            if (txtIDEst.Text == "")
            {
                MessageBox.Show("ingrese ID");
                txtIDEst.Focus();
                return;
            }

            else if (txtNombreEst.Text == "")
            {
                MessageBox.Show("ingrese Nombre");
                txtNombreEst.Focus();
                return;
            }

            else if (txtTelefonoEst.Text == "")
            {
                MessageBox.Show("ingrese Teléfono");
                txtTelefonoEst.Focus();
                return;
            }

            else if (txtDireccionEst.Text == "")
            {
                MessageBox.Show("ingrese Direccion");
                txtDireccionEst.Focus();
                return;
            }

            ClasesTipos objImpresion = new ClasesTipos();

            objImpresion.ActualizarProveedor(txtIDEst.Text, txtNombreEst.Text, txtTelefonoEst.Text, txtDireccionEst.Text);
            MessageBox.Show("Establecimiento actualizado (Registro)");

            btnBaseEstablecimientos_Click(sender, e);
            this.LimpiarCampos();
        }

        private void btnBaseEstablecimientos_Click(object sender, EventArgs e)
        {
            ClasesTipos objProducto = new ClasesTipos();

            DataTable objDato = new DataTable();

            objDato = objProducto.ConsultarEstablecimiento();


            GridViewEstablecimiento.DataSource = objDato;
        }

        private void GridViewEstablecimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDEst.Text = GridViewEstablecimiento.Rows[GridViewEstablecimiento.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtNombreEst.Text = GridViewEstablecimiento.Rows[GridViewEstablecimiento.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtTelefonoEst.Text = GridViewEstablecimiento.Rows[GridViewEstablecimiento.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtDireccionEst.Text = GridViewEstablecimiento.Rows[GridViewEstablecimiento.CurrentCell.RowIndex].Cells[3].Value.ToString();

            txtIDEst.Enabled = false;
        }
    }
}
