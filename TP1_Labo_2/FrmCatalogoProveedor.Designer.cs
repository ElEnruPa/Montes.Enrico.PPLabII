namespace TP1_Labo_2
{
    partial class FrmCatalogoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalogoProveedor));
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnVerCatalogo = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numUD_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblProvedores = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(37, 108);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowTemplate.Height = 25;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(278, 174);
            this.dgvProveedores.TabIndex = 0;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(375, 73);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(596, 256);
            this.dgvInventario.TabIndex = 1;
            // 
            // btnVerCatalogo
            // 
            this.btnVerCatalogo.Location = new System.Drawing.Point(99, 330);
            this.btnVerCatalogo.Name = "btnVerCatalogo";
            this.btnVerCatalogo.Size = new System.Drawing.Size(143, 59);
            this.btnVerCatalogo.TabIndex = 2;
            this.btnVerCatalogo.Text = "Ver Catalogo";
            this.btnVerCatalogo.UseVisualStyleBackColor = true;
            this.btnVerCatalogo.Click += new System.EventHandler(this.btnVerCatalogo_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(498, 374);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numUD_Cantidad
            // 
            this.numUD_Cantidad.Location = new System.Drawing.Point(498, 392);
            this.numUD_Cantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Cantidad.Name = "numUD_Cantidad";
            this.numUD_Cantidad.Size = new System.Drawing.Size(120, 23);
            this.numUD_Cantidad.TabIndex = 19;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(678, 373);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(143, 57);
            this.btnComprar.TabIndex = 21;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblProvedores
            // 
            this.lblProvedores.AutoSize = true;
            this.lblProvedores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProvedores.Location = new System.Drawing.Point(37, 80);
            this.lblProvedores.Name = "lblProvedores";
            this.lblProvedores.Size = new System.Drawing.Size(119, 25);
            this.lblProvedores.TabIndex = 22;
            this.lblProvedores.Text = "Provedores:";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInventario.Location = new System.Drawing.Point(375, 45);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(109, 25);
            this.lblInventario.TabIndex = 23;
            this.lblInventario.Text = "Inventario:";
            // 
            // FrmCatalogoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1029, 454);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblProvedores);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numUD_Cantidad);
            this.Controls.Add(this.btnVerCatalogo);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.dgvProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCatalogoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProveedores;
        private DataGridView dgvInventario;
        private Button btnVerCatalogo;
        private Label lblCantidad;
        private NumericUpDown numUD_Cantidad;
        private Button btnComprar;
        private Label lblProvedores;
        private Label lblInventario;
    }
}