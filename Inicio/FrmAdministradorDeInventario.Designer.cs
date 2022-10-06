namespace Forms
{
    partial class FrmAdministradorDeInventario
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
            this.btnFiltrarVer = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.cbxTag = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrarVer
            // 
            this.btnFiltrarVer.Location = new System.Drawing.Point(58, 157);
            this.btnFiltrarVer.Name = "btnFiltrarVer";
            this.btnFiltrarVer.Size = new System.Drawing.Size(112, 46);
            this.btnFiltrarVer.TabIndex = 1;
            this.btnFiltrarVer.Text = "Filtrar y Ver";
            this.btnFiltrarVer.UseVisualStyleBackColor = true;
            this.btnFiltrarVer.Click += new System.EventHandler(this.btnFiltrarVer_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(58, 227);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(112, 46);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir Producto";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(248, 25);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(504, 248);
            this.dgvInventario.TabIndex = 3;
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
            this.cbxTag.Location = new System.Drawing.Point(37, 43);
            this.cbxTag.Name = "cbxTag";
            this.cbxTag.Size = new System.Drawing.Size(165, 23);
            this.cbxTag.TabIndex = 4;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(37, 101);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(165, 23);
            this.txtProducto.TabIndex = 5;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(37, 25);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(25, 15);
            this.lblTag.TabIndex = 6;
            this.lblTag.Text = "Tag";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(37, 83);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 7;
            this.lblProducto.Text = "Producto";
            // 
            // FrmAdministradorDeInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 300);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.cbxTag);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnFiltrarVer);
            this.Name = "FrmAdministradorDeInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Administrador De Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnFiltrarVer;
        private Button btnAñadir;
        private DataGridView dgvInventario;
        private ComboBox cbxTag;
        private TextBox txtProducto;
        private Label lblTag;
        private Label lblProducto;
    }
}