namespace CapaPresentacion
{
    partial class Form2
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
            this.btnSNormal = new System.Windows.Forms.Button();
            this.btnSEspecial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSNormal
            // 
            this.btnSNormal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSNormal.Location = new System.Drawing.Point(174, 99);
            this.btnSNormal.Name = "btnSNormal";
            this.btnSNormal.Size = new System.Drawing.Size(175, 198);
            this.btnSNormal.TabIndex = 0;
            this.btnSNormal.Text = "Productos Comunes";
            this.btnSNormal.UseVisualStyleBackColor = true;
            this.btnSNormal.Click += new System.EventHandler(this.btnSNormal_Click);
            // 
            // btnSEspecial
            // 
            this.btnSEspecial.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEspecial.Location = new System.Drawing.Point(385, 99);
            this.btnSEspecial.Name = "btnSEspecial";
            this.btnSEspecial.Size = new System.Drawing.Size(184, 198);
            this.btnSEspecial.TabIndex = 1;
            this.btnSEspecial.Text = "Productos Especiales";
            this.btnSEspecial.UseVisualStyleBackColor = true;
            this.btnSEspecial.Click += new System.EventHandler(this.btnSEspecial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escoja el servicio que quiere";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSEspecial);
            this.Controls.Add(this.btnSNormal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSNormal;
        private System.Windows.Forms.Button btnSEspecial;
        private System.Windows.Forms.Label label1;
    }
}