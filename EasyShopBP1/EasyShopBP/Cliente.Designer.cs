namespace EasyShopBP
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBaseCliente = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.GridViewCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNomCl = new System.Windows.Forms.TextBox();
            this.txtApellidoCl = new System.Windows.Forms.TextBox();
            this.txtDirCl = new System.Windows.Forms.TextBox();
            this.txtTelefCl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(48, 293);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBaseCliente
            // 
            this.btnBaseCliente.Location = new System.Drawing.Point(131, 331);
            this.btnBaseCliente.Name = "btnBaseCliente";
            this.btnBaseCliente.Size = new System.Drawing.Size(106, 33);
            this.btnBaseCliente.TabIndex = 9;
            this.btnBaseCliente.Text = "&Info.Clientes";
            this.btnBaseCliente.UseVisualStyleBackColor = true;
            this.btnBaseCliente.Click += new System.EventHandler(this.btnBaseCliente_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(246, 293);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "&Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // GridViewCliente
            // 
            this.GridViewCliente.AllowUserToAddRows = false;
            this.GridViewCliente.AllowUserToDeleteRows = false;
            this.GridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCliente.Location = new System.Drawing.Point(376, 67);
            this.GridViewCliente.Name = "GridViewCliente";
            this.GridViewCliente.ReadOnly = true;
            this.GridViewCliente.Size = new System.Drawing.Size(533, 214);
            this.GridViewCliente.TabIndex = 0;
            this.GridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCliente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cédula de Identidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(159, 78);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(146, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // txtNomCl
            // 
            this.txtNomCl.Location = new System.Drawing.Point(159, 107);
            this.txtNomCl.Name = "txtNomCl";
            this.txtNomCl.Size = new System.Drawing.Size(146, 20);
            this.txtNomCl.TabIndex = 2;
            // 
            // txtApellidoCl
            // 
            this.txtApellidoCl.Location = new System.Drawing.Point(159, 142);
            this.txtApellidoCl.Name = "txtApellidoCl";
            this.txtApellidoCl.Size = new System.Drawing.Size(146, 20);
            this.txtApellidoCl.TabIndex = 3;
            // 
            // txtDirCl
            // 
            this.txtDirCl.Location = new System.Drawing.Point(159, 179);
            this.txtDirCl.Name = "txtDirCl";
            this.txtDirCl.Size = new System.Drawing.Size(146, 20);
            this.txtDirCl.TabIndex = 4;
            // 
            // txtTelefCl
            // 
            this.txtTelefCl.Location = new System.Drawing.Point(159, 216);
            this.txtTelefCl.Name = "txtTelefCl";
            this.txtTelefCl.Size = new System.Drawing.Size(146, 20);
            this.txtTelefCl.TabIndex = 5;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 429);
            this.Controls.Add(this.txtTelefCl);
            this.Controls.Add(this.txtDirCl);
            this.Controls.Add(this.txtApellidoCl);
            this.Controls.Add(this.txtNomCl);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewCliente);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBaseCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBaseCliente;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView GridViewCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNomCl;
        private System.Windows.Forms.TextBox txtApellidoCl;
        private System.Windows.Forms.TextBox txtDirCl;
        private System.Windows.Forms.TextBox txtTelefCl;
    }
}