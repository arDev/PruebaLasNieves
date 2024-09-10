namespace ProyectoDesdeCero
{
    partial class FrmPrincipal
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.bntCambiarLeyenda = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(309, 80);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(75, 23);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSaludar_MouseClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(83, 83);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(97, 13);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Ingrese su nombre:";
            // 
            // bntCambiarLeyenda
            // 
            this.bntCambiarLeyenda.Location = new System.Drawing.Point(74, 184);
            this.bntCambiarLeyenda.Name = "bntCambiarLeyenda";
            this.bntCambiarLeyenda.Size = new System.Drawing.Size(161, 23);
            this.bntCambiarLeyenda.TabIndex = 3;
            this.bntCambiarLeyenda.Text = "Cambiar el Text del Label";
            this.bntCambiarLeyenda.UseVisualStyleBackColor = true;
            this.bntCambiarLeyenda.Click += new System.EventHandler(this.bntCambiarLeyenda_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(366, 265);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar Producto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 558);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.bntCambiarLeyenda);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSaludar);
            this.Name = "FrmPrincipal";
            this.Text = "Mi primer App";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Click += new System.EventHandler(this.FrmPrincipal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button bntCambiarLeyenda;
        private System.Windows.Forms.Button btnEditar;
    }
}

