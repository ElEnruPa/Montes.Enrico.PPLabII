namespace TP1_Labo_2
{
    partial class FrmMenuDueño
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
            this.lblDueño = new System.Windows.Forms.Label();
            this.btnAdministradorInventario = new System.Windows.Forms.Button();
            this.btnAdministracionVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDueño.Location = new System.Drawing.Point(120, 70);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(261, 30);
            this.lblDueño.TabIndex = 0;
            this.lblDueño.Text = "Elija a que quiere acceder";
            // 
            // btnAdministradorInventario
            // 
            this.btnAdministradorInventario.Location = new System.Drawing.Point(84, 145);
            this.btnAdministradorInventario.Name = "btnAdministradorInventario";
            this.btnAdministradorInventario.Size = new System.Drawing.Size(126, 65);
            this.btnAdministradorInventario.TabIndex = 1;
            this.btnAdministradorInventario.Text = "Administracion de Inventario";
            this.btnAdministradorInventario.UseVisualStyleBackColor = true;
            this.btnAdministradorInventario.Click += new System.EventHandler(this.btnAdministradorInventario_Click);
            // 
            // btnAdministracionVenta
            // 
            this.btnAdministracionVenta.Location = new System.Drawing.Point(286, 145);
            this.btnAdministracionVenta.Name = "btnAdministracionVenta";
            this.btnAdministracionVenta.Size = new System.Drawing.Size(126, 65);
            this.btnAdministracionVenta.TabIndex = 2;
            this.btnAdministracionVenta.Text = "Administracion de Venta";
            this.btnAdministracionVenta.UseVisualStyleBackColor = true;
            this.btnAdministracionVenta.Click += new System.EventHandler(this.btnAdministracionVenta_Click);
            // 
            // FrmMenuDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 293);
            this.Controls.Add(this.btnAdministracionVenta);
            this.Controls.Add(this.btnAdministradorInventario);
            this.Controls.Add(this.lblDueño);
            this.Name = "FrmMenuDueño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Dueño";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDueño;
        private Button btnAdministradorInventario;
        private Button btnAdministracionVenta;
    }
}