namespace TP1_Labo_2
{
    partial class FrmMostradorVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostradorVentas));
            this.gbxVer = new System.Windows.Forms.GroupBox();
            this.rbdGananciaTotal = new System.Windows.Forms.RadioButton();
            this.rbdPromedioGanancia = new System.Windows.Forms.RadioButton();
            this.rbdProductoMasVendidoPorTag = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.gbxVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxVer
            // 
            this.gbxVer.BackColor = System.Drawing.SystemColors.Control;
            this.gbxVer.Controls.Add(this.rbdGananciaTotal);
            this.gbxVer.Controls.Add(this.rbdPromedioGanancia);
            this.gbxVer.Controls.Add(this.rbdProductoMasVendidoPorTag);
            this.gbxVer.Location = new System.Drawing.Point(31, 75);
            this.gbxVer.Name = "gbxVer";
            this.gbxVer.Size = new System.Drawing.Size(234, 187);
            this.gbxVer.TabIndex = 7;
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
            // rbdPromedioGanancia
            // 
            this.rbdPromedioGanancia.AutoSize = true;
            this.rbdPromedioGanancia.Location = new System.Drawing.Point(30, 93);
            this.rbdPromedioGanancia.Name = "rbdPromedioGanancia";
            this.rbdPromedioGanancia.Size = new System.Drawing.Size(192, 19);
            this.rbdPromedioGanancia.TabIndex = 1;
            this.rbdPromedioGanancia.TabStop = true;
            this.rbdPromedioGanancia.Text = "Promedio de Ganancias Por Tag";
            this.rbdPromedioGanancia.UseVisualStyleBackColor = true;
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
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(86, 279);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 37);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVentas.Location = new System.Drawing.Point(319, 47);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(144, 25);
            this.lblVentas.TabIndex = 5;
            this.lblVentas.Text = "Ventas Hechas:";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(319, 75);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(596, 256);
            this.dgvInventario.TabIndex = 8;
            // 
            // FrmMostradorVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(943, 364);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.gbxVer);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostradorVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrador de Ventas";
            this.gbxVer.ResumeLayout(false);
            this.gbxVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbxVer;
        private RadioButton rbdGananciaTotal;
        private RadioButton rbdPromedioGanancia;
        private RadioButton rbdProductoMasVendidoPorTag;
        private Button btnAceptar;
        private Label lblVentas;
        private DataGridView dgvInventario;
    }
}