namespace Forms
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
            this.dgvMostradorVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostradorVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostradorVentas
            // 
            this.dgvMostradorVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostradorVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostradorVentas.Location = new System.Drawing.Point(53, 41);
            this.dgvMostradorVentas.Name = "dgvMostradorVentas";
            this.dgvMostradorVentas.RowTemplate.Height = 25;
            this.dgvMostradorVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostradorVentas.Size = new System.Drawing.Size(495, 270);
            this.dgvMostradorVentas.TabIndex = 0;
            // 
            // FrmMostradorVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 360);
            this.Controls.Add(this.dgvMostradorVentas);
            this.Name = "FrmMostradorVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grilla de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostradorVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvMostradorVentas;
    }
}