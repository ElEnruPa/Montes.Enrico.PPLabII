namespace Forms
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
            this.btnAI = new System.Windows.Forms.Button();
            this.btnAV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDueño.Location = new System.Drawing.Point(104, 79);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(261, 30);
            this.lblDueño.TabIndex = 0;
            this.lblDueño.Text = "Elija a que quiere acceder";
            // 
            // btnAI
            // 
            this.btnAI.Location = new System.Drawing.Point(54, 164);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(130, 68);
            this.btnAI.TabIndex = 1;
            this.btnAI.Text = "Administracion De Inventario";
            this.btnAI.UseVisualStyleBackColor = true;
            this.btnAI.Click += new System.EventHandler(this.btnAI_Click);
            // 
            // btnAV
            // 
            this.btnAV.Location = new System.Drawing.Point(286, 164);
            this.btnAV.Name = "btnAV";
            this.btnAV.Size = new System.Drawing.Size(130, 68);
            this.btnAV.TabIndex = 2;
            this.btnAV.Text = "Administracion De Venta";
            this.btnAV.UseVisualStyleBackColor = true;
            this.btnAV.Click += new System.EventHandler(this.btnAV_Click);
            // 
            // FrmMenuDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 313);
            this.Controls.Add(this.btnAV);
            this.Controls.Add(this.btnAI);
            this.Controls.Add(this.lblDueño);
            this.Name = "FrmMenuDueño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuDueño";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDueño;
        private Button btnAI;
        private Button btnAV;
    }
}