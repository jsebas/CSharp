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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            this.txtIDProv.Clear();
            this.txtNombreProv.Clear();
            this.txtTelefonoProv.Clear();
            this.txtDireccionProv.Clear();

        }

        private void btnGuardarProv_Click(object sender, EventArgs e)
        {

            if (txtIDProv.Text == "")
            {
                MessageBox.Show("ingrese ID");
                txtIDProv.Focus();
                return;
            }

            else if (txtNombreProv.Text == "")
            {
                MessageBox.Show("ingrese Nombre");
                txtNombreProv.Focus();
                return;
            }

            else if (txtTelefonoProv.Text == "")
            {
                MessageBox.Show("ingrese Teléfono");
                txtTelefonoProv.Focus();
                return;
            }

            else if (txtDireccionProv.Text == "")
            {
                MessageBox.Show("ingrese Direccion");
                txtDireccionProv.Focus();
                return;
            }
            

            ClasesTipos objImpresion = new ClasesTipos();

            objImpresion.CrearProveedor(txtIDProv.Text, txtNombreProv.Text, txtTelefonoProv.Text, txtDireccionProv.Text);
            MessageBox.Show("El Empleado" + txtNombreProv.Text + " se ha registrado");

            this.LimpiarCampos();
            btnBaseProveedor_Click(sender, e);

        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {

            if (!(txtIDProv.Text == "" || txtNombreProv.Text == "" || txtTelefonoProv.Text == "" || txtDireccionProv.Text == ""))
            {
                ClasesTipos objClasesEnumeradas = new ClasesTipos();
                objClasesEnumeradas.EliminarCliente(txtIDProv.Text);
            }

            else
            {
                MessageBox.Show("Campos Incompletos");
                return;
            }

            MessageBox.Show("Eliminado Exitosamente");
            btnBaseProveedor_Click(sender, e);
            this.LimpiarCampos();


        }

        private void btnUpdateProv_Click(object sender, EventArgs e)
        {
            if (txtIDProv.Text == "")
            {
                MessageBox.Show("ingrese ID");
                txtIDProv.Focus();
                return;
            }

            else if (txtNombreProv.Text == "")
            {
                MessageBox.Show("ingrese Nombre");
                txtNombreProv.Focus();
                return;
            }

            else if (txtTelefonoProv.Text == "")
            {
                MessageBox.Show("ingrese Teléfono");
                txtTelefonoProv.Focus();
                return;
            }

            else if (txtDireccionProv.Text == "")
            {
                MessageBox.Show("ingrese Direccion");
                txtDireccionProv.Focus();
                return;
            }

            ClasesTipos objImpresion = new ClasesTipos();

            objImpresion.ActualizarProveedor(txtIDProv.Text, txtNombreProv.Text, txtTelefonoProv.Text, txtDireccionProv.Text);
            MessageBox.Show("Empleado actualizado (Registro)");

            btnBaseProveedor_Click(sender, e);
            this.LimpiarCampos();
        }

        private void btnBaseProveedor_Click(object sender, EventArgs e)
        {
            ClasesTipos objProducto = new ClasesTipos();

            DataTable objDato = new DataTable();

            objDato = objProducto.ConsultarProveedor();


            GridViewProveedor.DataSource = objDato;
        }

        private void GridViewProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDProv.Text = GridViewProveedor.Rows[GridViewProveedor.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtNombreProv.Text = GridViewProveedor.Rows[GridViewProveedor.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtTelefonoProv.Text = GridViewProveedor.Rows[GridViewProveedor.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtDireccionProv.Text = GridViewProveedor.Rows[GridViewProveedor.CurrentCell.RowIndex].Cells[3].Value.ToString();

            txtIDProv.Enabled = false;
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

    }
}
