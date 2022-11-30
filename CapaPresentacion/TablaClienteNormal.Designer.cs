namespace CapaPresentacion
{
    partial class TablaClienteNormal
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
            this.dtwClientesCN = new System.Windows.Forms.DataGridView();
            this.Factura = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtNombree = new System.Windows.Forms.TextBox();
            this.txtApellidoo = new System.Windows.Forms.TextBox();
            this.txtIdentificaciónn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIDD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtwClientesCN)).BeginInit();
            this.SuspendLayout();
            // 
            // dtwClientesCN
            // 
            this.dtwClientesCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwClientesCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura});
            this.dtwClientesCN.Location = new System.Drawing.Point(3, 142);
            this.dtwClientesCN.Name = "dtwClientesCN";
            this.dtwClientesCN.Size = new System.Drawing.Size(630, 296);
            this.dtwClientesCN.TabIndex = 0;
            this.dtwClientesCN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwClientesCN_CellContentClick);
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtNombree
            // 
            this.txtNombree.Location = new System.Drawing.Point(74, 59);
            this.txtNombree.Name = "txtNombree";
            this.txtNombree.Size = new System.Drawing.Size(159, 20);
            this.txtNombree.TabIndex = 1;
            // 
            // txtApellidoo
            // 
            this.txtApellidoo.Location = new System.Drawing.Point(267, 59);
            this.txtApellidoo.Name = "txtApellidoo";
            this.txtApellidoo.Size = new System.Drawing.Size(159, 20);
            this.txtApellidoo.TabIndex = 2;
            // 
            // txtIdentificaciónn
            // 
            this.txtIdentificaciónn.Location = new System.Drawing.Point(459, 59);
            this.txtIdentificaciónn.Name = "txtIdentificaciónn";
            this.txtIdentificaciónn.Size = new System.Drawing.Size(159, 20);
            this.txtIdentificaciónn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificación";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(222, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 24);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(368, 100);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 24);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "PRODUCTOS PYM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "NOMBRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "APELLIDO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "IDENTIFICACIÓN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(666, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "PRODUCTO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "VALOR:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(720, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "VUELVA PRONTO... :)";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(743, 152);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "                                   ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(743, 180);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(112, 13);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "                                   ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(743, 211);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(112, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "                                   ";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(743, 240);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(112, 13);
            this.lblProducto.TabIndex = 19;
            this.lblProducto.Text = "                                   ";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(743, 269);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(112, 13);
            this.lblValor.TabIndex = 20;
            this.lblValor.Text = "                                   ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "ID:";
            // 
            // lblIDD
            // 
            this.lblIDD.AutoSize = true;
            this.lblIDD.Location = new System.Drawing.Point(100, 113);
            this.lblIDD.Name = "lblIDD";
            this.lblIDD.Size = new System.Drawing.Size(41, 17);
            this.lblIDD.TabIndex = 22;
            this.lblIDD.Text = "label12";
            this.lblIDD.UseCompatibleTextRendering = true;
            // 
            // TablaClienteNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.lblIDD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificaciónn);
            this.Controls.Add(this.txtApellidoo);
            this.Controls.Add(this.txtNombree);
            this.Controls.Add(this.dtwClientesCN);
            this.Name = "TablaClienteNormal";
            this.Text = "TablaClienteNormal";
            ((System.ComponentModel.ISupportInitialize)(this.dtwClientesCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtwClientesCN;
        private System.Windows.Forms.TextBox txtNombree;
        private System.Windows.Forms.TextBox txtApellidoo;
        private System.Windows.Forms.TextBox txtIdentificaciónn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewImageColumn Factura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIDD;
    }
}