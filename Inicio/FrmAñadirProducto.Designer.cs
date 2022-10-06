namespace Forms
{
    partial class FrmAñadirProducto
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
            this.lblTag = new System.Windows.Forms.Label();
            this.cbxTag = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.numUD_Precio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numUD_Stock = new System.Windows.Forms.NumericUpDown();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(48, 51);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(25, 15);
            this.lblTag.TabIndex = 0;
            this.lblTag.Text = "Tag";
            // 
            // cbxTag
            // 
            this.cbxTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTag.FormattingEnabled = true;
            this.cbxTag.Items.AddRange(new object[] {
            "Computadora Escritorio",
            "Notebook",
            "Monitor",
            "Perifericos",
            "Silla",
            "Otros"});
            this.cbxTag.Location = new System.Drawing.Point(48, 69);
            this.cbxTag.Name = "cbxTag";
            this.cbxTag.Size = new System.Drawing.Size(168, 23);
            this.cbxTag.TabIndex = 3;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(48, 137);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(168, 23);
            this.txtProducto.TabIndex = 4;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(48, 119);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto";
            // 
            // numUD_Precio
            // 
            this.numUD_Precio.Location = new System.Drawing.Point(48, 197);
            this.numUD_Precio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUD_Precio.Name = "numUD_Precio";
            this.numUD_Precio.Size = new System.Drawing.Size(120, 23);
            this.numUD_Precio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(48, 179);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(48, 250);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(89, 15);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Cantidad/Stock";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 36);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numUD_Stock
            // 
            this.numUD_Stock.Location = new System.Drawing.Point(48, 268);
            this.numUD_Stock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Stock.Name = "numUD_Stock";
            this.numUD_Stock.Size = new System.Drawing.Size(120, 23);
            this.numUD_Stock.TabIndex = 12;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(281, 69);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(599, 278);
            this.dgvInventario.TabIndex = 13;
            // 
            // FrmAñadirProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 413);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.numUD_Stock);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.numUD_Precio);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.cbxTag);
            this.Controls.Add(this.lblTag);
            this.Name = "FrmAñadirProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Producto";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTag;
        private ComboBox cbxTag;
        private TextBox txtProducto;
        private Label lblProducto;
        private NumericUpDown numUD_Precio;
        private Label lblPrecio;
        private Label lblStock;
        private Button btnAgregar;
        private NumericUpDown numUD_Stock;
        private DataGridView dgvInventario;
    }
}