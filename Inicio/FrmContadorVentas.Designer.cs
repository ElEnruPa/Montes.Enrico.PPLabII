namespace Forms
{
    partial class FrmContadorVentas
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
            this.dgvContadorVentas = new System.Windows.Forms.DataGridView();
            this.lblVentas = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxVer = new System.Windows.Forms.GroupBox();
            this.rbdGananciaTotal = new System.Windows.Forms.RadioButton();
            this.rbdPromedioGanancias = new System.Windows.Forms.RadioButton();
            this.rbdProductoMasVendidoPorTag = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContadorVentas)).BeginInit();
            this.gbxVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContadorVentas
            // 
            this.dgvContadorVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContadorVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContadorVentas.Location = new System.Drawing.Point(300, 49);
            this.dgvContadorVentas.Name = "dgvContadorVentas";
            this.dgvContadorVentas.RowTemplate.Height = 25;
            this.dgvContadorVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContadorVentas.Size = new System.Drawing.Size(502, 249);
            this.dgvContadorVentas.TabIndex = 0;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVentas.Location = new System.Drawing.Point(300, 21);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(144, 25);
            this.lblVentas.TabIndex = 1;
            this.lblVentas.Text = "Ventas Hechas:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(67, 253);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 37);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbxVer
            // 
            this.gbxVer.Controls.Add(this.rbdGananciaTotal);
            this.gbxVer.Controls.Add(this.rbdPromedioGanancias);
            this.gbxVer.Controls.Add(this.rbdProductoMasVendidoPorTag);
            this.gbxVer.Location = new System.Drawing.Point(12, 49);
            this.gbxVer.Name = "gbxVer";
            this.gbxVer.Size = new System.Drawing.Size(234, 187);
            this.gbxVer.TabIndex = 3;
            this.gbxVer.TabStop = false;
            this.gbxVer.Text = "Elija que quiere ver:";
            // 
            // rbdGananciaTotal
            // 
            this.rbdGananciaTotal.AutoSize = true;
            this.rbdGananciaTotal.Location = new System.Drawing.Point(30, 138);
            this.rbdGananciaTotal.Name = "rbdGananciaTotal";
            this.rbdGananciaTotal.Size = new System.Drawing.Size(102, 19);
            this.rbdGananciaTotal.TabIndex = 2;
            this.rbdGananciaTotal.TabStop = true;
            this.rbdGananciaTotal.Text = "Ganancia Total";
            this.rbdGananciaTotal.UseVisualStyleBackColor = true;
            // 
            // rbdPromedioGanancias
            // 
            this.rbdPromedioGanancias.AutoSize = true;
            this.rbdPromedioGanancias.Location = new System.Drawing.Point(30, 93);
            this.rbdPromedioGanancias.Name = "rbdPromedioGanancias";
            this.rbdPromedioGanancias.Size = new System.Drawing.Size(192, 19);
            this.rbdPromedioGanancias.TabIndex = 1;
            this.rbdPromedioGanancias.TabStop = true;
            this.rbdPromedioGanancias.Text = "Promedio de Ganancias Por Tag";
            this.rbdPromedioGanancias.UseVisualStyleBackColor = true;
            // 
            // rbdProductoMasVendidoPorTag
            // 
            this.rbdProductoMasVendidoPorTag.AutoSize = true;
            this.rbdProductoMasVendidoPorTag.Location = new System.Drawing.Point(30, 44);
            this.rbdProductoMasVendidoPorTag.Name = "rbdProductoMasVendidoPorTag";
            this.rbdProductoMasVendidoPorTag.Size = new System.Drawing.Size(187, 19);
            this.rbdProductoMasVendidoPorTag.TabIndex = 0;
            this.rbdProductoMasVendidoPorTag.TabStop = true;
            this.rbdProductoMasVendidoPorTag.Text = "Producto Mas Vendido Por Tag";
            this.rbdProductoMasVendidoPorTag.UseVisualStyleBackColor = true;
            // 
            // FrmContadorVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 335);
            this.Controls.Add(this.gbxVer);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.dgvContadorVentas);
            this.Name = "FrmContadorVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador De Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContadorVentas)).EndInit();
            this.gbxVer.ResumeLayout(false);
            this.gbxVer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvContadorVentas;
        private Label lblVentas;
        private Button btnAceptar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gbxVer;
        private RadioButton rbdGananciaTotal;
        private RadioButton rbdPromedioGanancias;
        private RadioButton rbdProductoMasVendidoPorTag;
    }
}