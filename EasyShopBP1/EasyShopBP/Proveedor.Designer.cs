namespace EasyShopBP
{
    partial class Proveedor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardarProv = new System.Windows.Forms.Button();
            this.btnEliminarProv = new System.Windows.Forms.Button();
            this.btnUpdateProv = new System.Windows.Forms.Button();
            this.btnBaseProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDProv = new System.Windows.Forms.TextBox();
            this.txtNombreProv = new System.Windows.Forms.TextBox();
            this.txtTelefonoProv = new System.Windows.Forms.TextBox();
            this.txtDireccionProv = new System.Windows.Forms.TextBox();
            this.GridViewProveedor = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarProv
            // 
            this.btnGuardarProv.Location = new System.Drawing.Point(22, 317);
            this.btnGuardarProv.Name = "btnGuardarProv";
            this.btnGuardarProv.Size = new System.Drawing.Size(83, 31);
            this.btnGuardarProv.TabIndex = 0;
            this.btnGuardarProv.Text = "Guardar";
            this.btnGuardarProv.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.Location = new System.Drawing.Point(134, 317);
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.Size = new System.Drawing.Size(83, 31);
            this.btnEliminarProv.TabIndex = 1;
            this.btnEliminarProv.Text = "Eliminar";
            this.btnEliminarProv.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProv
            // 
            this.btnUpdateProv.Location = new System.Drawing.Point(249, 317);
            this.btnUpdateProv.Name = "btnUpdateProv";
            this.btnUpdateProv.Size = new System.Drawing.Size(83, 31);
            this.btnUpdateProv.TabIndex = 2;
            this.btnUpdateProv.Text = "Actualizar";
            this.btnUpdateProv.UseVisualStyleBackColor = true;
            // 
            // btnBaseProveedor
            // 
            this.btnBaseProveedor.Location = new System.Drawing.Point(120, 368);
            this.btnBaseProveedor.Name = "btnBaseProveedor";
            this.btnBaseProveedor.Size = new System.Drawing.Size(107, 42);
            this.btnBaseProveedor.TabIndex = 3;
            this.btnBaseProveedor.Text = "Info. Proveedores";
            this.btnBaseProveedor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID del Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono del Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion del Proveedor";
            // 
            // txtIDProv
            // 
            this.txtIDProv.Location = new System.Drawing.Point(160, 69);
            this.txtIDProv.Name = "txtIDProv";
            this.txtIDProv.Size = new System.Drawing.Size(172, 20);
            this.txtIDProv.TabIndex = 8;
            // 
            // txtNombreProv
            // 
            this.txtNombreProv.Location = new System.Drawing.Point(160, 115);
            this.txtNombreProv.Name = "txtNombreProv";
            this.txtNombreProv.Size = new System.Drawing.Size(172, 20);
            this.txtNombreProv.TabIndex = 9;
            // 
            // txtTelefonoProv
            // 
            this.txtTelefonoProv.Location = new System.Drawing.Point(160, 169);
            this.txtTelefonoProv.Name = "txtTelefonoProv";
            this.txtTelefonoProv.Size = new System.Drawing.Size(172, 20);
            this.txtTelefonoProv.TabIndex = 10;
            // 
            // txtDireccionProv
            // 
            this.txtDireccionProv.Location = new System.Drawing.Point(160, 225);
            this.txtDireccionProv.Name = "txtDireccionProv";
            this.txtDireccionProv.Size = new System.Drawing.Size(172, 20);
            this.txtDireccionProv.TabIndex = 11;
            // 
            // GridViewProveedor
            // 
            this.GridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewProveedor.Location = new System.Drawing.Point(416, 69);
            this.GridViewProveedor.Name = "GridViewProveedor";
            this.GridViewProveedor.Size = new System.Drawing.Size(620, 279);
            this.GridViewProveedor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lista de Proveedores";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GridViewProveedor);
            this.Controls.Add(this.txtDireccionProv);
            this.Controls.Add(this.txtTelefonoProv);
            this.Controls.Add(this.txtNombreProv);
            this.Controls.Add(this.txtIDProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaseProveedor);
            this.Controls.Add(this.btnUpdateProv);
            this.Controls.Add(this.btnEliminarProv);
            this.Controls.Add(this.btnGuardarProv);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarProv;
        private System.Windows.Forms.Button btnEliminarProv;
        private System.Windows.Forms.Button btnUpdateProv;
        private System.Windows.Forms.Button btnBaseProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDProv;
        private System.Windows.Forms.TextBox txtNombreProv;
        private System.Windows.Forms.TextBox txtTelefonoProv;
        private System.Windows.Forms.TextBox txtDireccionProv;
        private System.Windows.Forms.DataGridView GridViewProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}