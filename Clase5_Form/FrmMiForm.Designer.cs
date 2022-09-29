namespace Clase5_Form
{
    partial class FrmMiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btmSaludarForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaludar.Location = new System.Drawing.Point(79, 117);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(190, 86);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar desde un MessageBox";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(139, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Ingrese su nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(311, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // btmSaludarForm
            // 
            this.btmSaludarForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btmSaludarForm.Location = new System.Drawing.Point(333, 117);
            this.btmSaludarForm.Name = "btmSaludarForm";
            this.btmSaludarForm.Size = new System.Drawing.Size(190, 86);
            this.btmSaludarForm.TabIndex = 3;
            this.btmSaludarForm.Text = "Saludar desde otro Form";
            this.btmSaludarForm.UseVisualStyleBackColor = true;
            this.btmSaludarForm.Click += new System.EventHandler(this.btmSaludarForm_Click);
            // 
            // FrmMiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(618, 378);
            this.Controls.Add(this.btmSaludarForm);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSaludar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmMiForm";
            this.Text = "PrimerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSaludar;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btmSaludarForm;
    }
}