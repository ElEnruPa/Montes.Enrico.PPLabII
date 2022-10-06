namespace Forms
{
    partial class FrmAdministradorDeVentas
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
            this.numUD_DineroCliente = new System.Windows.Forms.NumericUpDown();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.numUD_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.gbxPago = new System.Windows.Forms.GroupBox();
            this.rbdEfectivo = new System.Windows.Forms.RadioButton();
            this.rbdCredito = new System.Windows.Forms.RadioButton();
            this.rbdDebito = new System.Windows.Forms.RadioButton();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblTag = new System.Windows.Forms.Label();
            this.cbxTag = new System.Windows.Forms.ComboBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnMostrarVentas = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_DineroCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Cantidad)).BeginInit();
            this.gbxPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // numUD_DineroCliente
            // 
            this.numUD_DineroCliente.Location = new System.Drawing.Point(42, 61);
            this.numUD_DineroCliente.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numUD_DineroCliente.Name = "numUD_DineroCliente";
            this.numUD_DineroCliente.Size = new System.Drawing.Size(120, 23);
            this.numUD_DineroCliente.TabIndex = 0;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(42, 43);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(101, 15);
            this.lblDinero.TabIndex = 1;
            this.lblDinero.Text = "Dinero del Cliente";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(41, 171);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // numUD_Cantidad
            // 
            this.numUD_Cantidad.Location = new System.Drawing.Point(42, 252);
            this.numUD_Cantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Cantidad.Name = "numUD_Cantidad";
            this.numUD_Cantidad.Size = new System.Drawing.Size(120, 23);
            this.numUD_Cantidad.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(42, 234);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // gbxPago
            // 
            this.gbxPago.BackColor = System.Drawing.SystemColors.Control;
            this.gbxPago.Controls.Add(this.rbdEfectivo);
            this.gbxPago.Controls.Add(this.rbdCredito);
            this.gbxPago.Controls.Add(this.rbdDebito);
            this.gbxPago.Location = new System.Drawing.Point(42, 304);
            this.gbxPago.Name = "gbxPago";
            this.gbxPago.Size = new System.Drawing.Size(194, 180);
            this.gbxPago.TabIndex = 7;
            this.gbxPago.TabStop = false;
            this.gbxPago.Text = "Metodo de Pago";
            // 
            // rbdEfectivo
            // 
            this.rbdEfectivo.AutoSize = true;
            this.rbdEfectivo.Location = new System.Drawing.Point(27, 121);
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
            this.rbdCredito.Location = new System.Drawing.Point(27, 82);
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
            this.rbdDebito.Location = new System.Drawing.Point(27, 44);
            this.rbdDebito.Name = "rbdDebito";
            this.rbdDebito.Size = new System.Drawing.Size(113, 19);
            this.rbdDebito.TabIndex = 0;
            this.rbdDebito.TabStop = true;
            this.rbdDebito.Text = "Tarjeta de Debito";
            this.rbdDebito.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(359, 399);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(148, 70);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(41, 109);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(25, 15);
            this.lblTag.TabIndex = 10;
            this.lblTag.Text = "Tag";
            // 
            // cbxTag
            // 
            this.cbxTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTag.FormattingEnabled = true;
            this.cbxTag.Items.AddRange(new object[] {
            "Computadora Escritorio",
            "Notebook",
            "Monitor\t",
            "Perifericos",
            "Silla",
            "Otros"});
            this.cbxTag.Location = new System.Drawing.Point(42, 127);
            this.cbxTag.Name = "cbxTag";
            this.cbxTag.Size = new System.Drawing.Size(161, 23);
            this.cbxTag.TabIndex = 11;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(284, 43);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(630, 324);
            this.dgvInventario.TabIndex = 12;
            // 
            // btnMostrarVentas
            // 
            this.btnMostrarVentas.Location = new System.Drawing.Point(687, 399);
            this.btnMostrarVentas.Name = "btnMostrarVentas";
            this.btnMostrarVentas.Size = new System.Drawing.Size(148, 70);
            this.btnMostrarVentas.TabIndex = 13;
            this.btnMostrarVentas.Text = "Mostrar Ventas";
            this.btnMostrarVentas.UseVisualStyleBackColor = true;
            this.btnMostrarVentas.Click += new System.EventHandler(this.btnMostrarVentas_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(41, 189);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(162, 23);
            this.txtProducto.TabIndex = 14;
            // 
            // FrmAdministradorDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(971, 507);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnMostrarVentas);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.cbxTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.gbxPago);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numUD_Cantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.numUD_DineroCliente);
            this.Name = "FrmAdministradorDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador De Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_DineroCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Cantidad)).EndInit();
            this.gbxPago.ResumeLayout(false);
            this.gbxPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numUD_DineroCliente;
        private Label lblDinero;
        private Label lblProducto;
        private NumericUpDown numUD_Cantidad;
        private Label lblCantidad;
        private GroupBox gbxPago;
        private RadioButton rbdEfectivo;
        private RadioButton rbdCredito;
        private RadioButton rbdDebito;
        private Button btnVender;
        private Label lblTag;
        private ComboBox cbxTag;
        private DataGridView dgvInventario;
        private Button btnMostrarVentas;
        private TextBox txtProducto;
    }
}