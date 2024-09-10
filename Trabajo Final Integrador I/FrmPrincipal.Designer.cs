namespace Trabajo_Final_Integrador_I
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChau = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.btnConsumirAPIEjemplo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProducto1 = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChau
            // 
            this.btnChau.Location = new System.Drawing.Point(343, 284);
            this.btnChau.Name = "btnChau";
            this.btnChau.Size = new System.Drawing.Size(194, 76);
            this.btnChau.TabIndex = 3;
            this.btnChau.Text = "Chau";
            this.btnChau.UseVisualStyleBackColor = true;
            this.btnChau.Click += new System.EventHandler(this.btnChau_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(210, 229);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(357, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(144, 232);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            // 
            // btnConsumirAPIEjemplo
            // 
            this.btnConsumirAPIEjemplo.Location = new System.Drawing.Point(54, 134);
            this.btnConsumirAPIEjemplo.Name = "btnConsumirAPIEjemplo";
            this.btnConsumirAPIEjemplo.Size = new System.Drawing.Size(197, 27);
            this.btnConsumirAPIEjemplo.TabIndex = 4;
            this.btnConsumirAPIEjemplo.Text = "API Ejemplo";
            this.btnConsumirAPIEjemplo.UseVisualStyleBackColor = true;
            this.btnConsumirAPIEjemplo.Click += new System.EventHandler(this.btnConsumirAPIEjemplo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(573, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(514, 156);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnProducto1
            // 
            this.btnProducto1.Location = new System.Drawing.Point(29, 128);
            this.btnProducto1.Name = "btnProducto1";
            this.btnProducto1.Size = new System.Drawing.Size(75, 23);
            this.btnProducto1.TabIndex = 6;
            this.btnProducto1.Text = "Traer";
            this.btnProducto1.UseVisualStyleBackColor = true;
            this.btnProducto1.Click += new System.EventHandler(this.btnProducto1_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(29, 55);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(263, 20);
            this.tbTitle.TabIndex = 7;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(29, 29);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(50, 20);
            this.tbId.TabIndex = 7;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(29, 81);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(115, 20);
            this.tbPrice.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.btnProducto1);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Location = new System.Drawing.Point(166, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 177);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(153, 128);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(31, 443);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Nueva Ventana";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 630);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsumirAPIEjemplo);
            this.Controls.Add(this.btnChau);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.button1);
            this.Name = "FrmPrincipal";
            this.Text = "TFI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button btnChau;
        private System.Windows.Forms.Button btnConsumirAPIEjemplo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProducto1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

