namespace TP1_Labo_2
{
    partial class FrmAdministracionDeVentas
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.cbxTag = new System.Windows.Forms.ComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gbxPago = new System.Windows.Forms.GroupBox();
            this.rbdEfectivo = new System.Windows.Forms.RadioButton();
            this.rbdCredito = new System.Windows.Forms.RadioButton();
            this.rbdDebito = new System.Windows.Forms.RadioButton();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVentasHechas = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numUD_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lblDinero = new System.Windows.Forms.Label();
            this.numUD_DineroCliente = new System.Windows.Forms.NumericUpDown();
            this.lblInventario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.gbxPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_DineroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(316, 60);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(596, 256);
            this.dgvInventario.TabIndex = 5;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(74, 144);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(74, 162);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(162, 23);
            this.txtProducto.TabIndex = 10;
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
            this.cbxTag.Location = new System.Drawing.Point(74, 100);
            this.cbxTag.Name = "cbxTag";
            this.cbxTag.Size = new System.Drawing.Size(162, 23);
            this.cbxTag.TabIndex = 9;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(74, 82);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(25, 15);
            this.lblTag.TabIndex = 8;
            this.lblTag.Text = "Tag";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(97, 217);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 44);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // gbxPago
            // 
            this.gbxPago.BackColor = System.Drawing.SystemColors.Control;
            this.gbxPago.Controls.Add(this.rbdEfectivo);
            this.gbxPago.Controls.Add(this.rbdCredito);
            this.gbxPago.Controls.Add(this.rbdDebito);
            this.gbxPago.Location = new System.Drawing.Point(377, 359);
            this.gbxPago.Name = "gbxPago";
            this.gbxPago.Size = new System.Drawing.Size(186, 150);
            this.gbxPago.TabIndex = 13;
            this.gbxPago.TabStop = false;
            this.gbxPago.Text = "Metodo de Pago";
            // 
            // rbdEfectivo
            // 
            this.rbdEfectivo.AutoSize = true;
            this.rbdEfectivo.Location = new System.Drawing.Point(15, 111);
            this.rbdEfectivo.Name = "rbdEfectivo";
            this.rbdEfectivo.Size = new System.Drawing.Size(67, 19);
            this.rbdEfectivo.TabIndex = 2;
            this.rbdEfectivo.TabStop = true;
            this.rbdEfectivo.Text = "Efectivo";
            this.rbdEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbdCredito
            // 
            this.rbdCredito.AutoSize = true;
            this.rbdCredito.Location = new System.Drawing.Point(15, 72);
            this.rbdCredito.Name = "rbdCredito";
            this.rbdCredito.Size = new System.Drawing.Size(158, 19);
            this.rbdCredito.TabIndex = 1;
            this.rbdCredito.TabStop = true;
            this.rbdCredito.Text = "Tarjeta de Credito (+10%)";
            this.rbdCredito.UseVisualStyleBackColor = true;
            // 
            // rbdDebito
            // 
            this.rbdDebito.AutoSize = true;
            this.rbdDebito.Location = new System.Drawing.Point(15, 34);
            this.rbdDebito.Name = "rbdDebito";
            this.rbdDebito.Size = new System.Drawing.Size(113, 19);
            this.rbdDebito.TabIndex = 0;
            this.rbdDebito.TabStop = true;
            this.rbdDebito.Text = "Tarjeta de Debito";
            this.rbdDebito.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(612, 359);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(117, 56);
            this.btnVender.TabIndex = 14;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVentasHechas
            // 
            this.btnVentasHechas.Location = new System.Drawing.Point(612, 451);
            this.btnVentasHechas.Name = "btnVentasHechas";
            this.btnVentasHechas.Size = new System.Drawing.Size(117, 56);
            this.btnVentasHechas.TabIndex = 15;
            this.btnVentasHechas.Text = "Mostrar Ventas";
            this.btnVentasHechas.UseVisualStyleBackColor = true;
            this.btnVentasHechas.Click += new System.EventHandler(this.btnVentasHechas_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(200, 433);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numUD_Cantidad
            // 
            this.numUD_Cantidad.Location = new System.Drawing.Point(200, 451);
            this.numUD_Cantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Cantidad.Name = "numUD_Cantidad";
            this.numUD_Cantidad.Size = new System.Drawing.Size(120, 23);
            this.numUD_Cantidad.TabIndex = 17;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(200, 371);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(101, 15);
            this.lblDinero.TabIndex = 20;
            this.lblDinero.Text = "Dinero del Cliente";
            // 
            // numUD_DineroCliente
            // 
            this.numUD_DineroCliente.Location = new System.Drawing.Point(200, 389);
            this.numUD_DineroCliente.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numUD_DineroCliente.Name = "numUD_DineroCliente";
            this.numUD_DineroCliente.Size = new System.Drawing.Size(120, 23);
            this.numUD_DineroCliente.TabIndex = 19;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInventario.Location = new System.Drawing.Point(316, 32);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(109, 25);
            this.lblInventario.TabIndex = 21;
            this.lblInventario.Text = "Inventario:";
            // 
            // FrmAdministracionDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 542);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.numUD_DineroCliente);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numUD_Cantidad);
            this.Controls.Add(this.btnVentasHechas);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.gbxPago);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.cbxTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.dgvInventario);
            this.Name = "FrmAdministracionDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion De Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.gbxPago.ResumeLayout(false);
            this.gbxPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_DineroCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvInventario;
        private Label lblProducto;
        private TextBox txtProducto;
        private ComboBox cbxTag;
        private Label lblTag;
        private Button btnFiltrar;
        private GroupBox gbxPago;
        private RadioButton rbdEfectivo;
        private RadioButton rbdCredito;
        private RadioButton rbdDebito;
        private Button btnVender;
        private Button btnVentasHechas;
        private Label lblCantidad;
        private NumericUpDown numUD_Cantidad;
        private Label lblDinero;
        private NumericUpDown numUD_DineroCliente;
        private Label lblInventario;
    }
}