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
    public partial class EasyShop : Form
    {
        public EasyShop()
        {
            InitializeComponent();
        }
        
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.MdiParent = this;
            obj.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor obj = new Proveedor();
            obj.MdiParent = this;
            obj.Show();

        }

        private void establecimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Establecimiento obj = new Establecimiento();
            obj.MdiParent = this;
            obj.Show();
        }

    }
}
