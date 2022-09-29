namespace Clase5_Ej2
{
    partial class FrmIngresante
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
            this.gBoxUsuario = new System.Windows.Forms.GroupBox();
            this.nunudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gBoxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnNoBinario = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.gBoxCursos = new System.Windows.Forms.GroupBox();
            this.cboxJavaScript = new System.Windows.Forms.CheckBox();
            this.cboxCMasMas = new System.Windows.Forms.CheckBox();
            this.cboxCSharp = new System.Windows.Forms.CheckBox();
            this.lboxPais = new System.Windows.Forms.ListBox();
            this.llblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gBoxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunudEdad)).BeginInit();
            this.gBoxGenero.SuspendLayout();
            this.gBoxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxUsuario
            // 
            this.gBoxUsuario.Controls.Add(this.nunudEdad);
            this.gBoxUsuario.Controls.Add(this.txtDireccion);
            this.gBoxUsuario.Controls.Add(this.txtNombre);
            this.gBoxUsuario.Controls.Add(this.lblEdad);
            this.gBoxUsuario.Controls.Add(this.lblDireccion);
            this.gBoxUsuario.Controls.Add(this.lblNombre);
            this.gBoxUsuario.Location = new System.Drawing.Point(37, 29);
            this.gBoxUsuario.Name = "gBoxUsuario";
            this.gBoxUsuario.Size = new System.Drawing.Size(260, 197);
            this.gBoxUsuario.TabIndex = 0;
            this.gBoxUsuario.TabStop = false;
            this.gBoxUsuario.Text = "Detalles del usuario";
            // 
            // nunudEdad
            // 
            this.nunudEdad.Location = new System.Drawing.Point(71, 143);
            this.nunudEdad.Name = "nunudEdad";
            this.nunudEdad.Size = new System.Drawing.Size(120, 23);
            this.nunudEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(95, 95);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(26, 145);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(39, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(26, 98);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // gBoxGenero
            // 
            this.gBoxGenero.Controls.Add(this.rbtnNoBinario);
            this.gBoxGenero.Controls.Add(this.rbtnFemenino);
            this.gBoxGenero.Controls.Add(this.rbtnMasculino);
            this.gBoxGenero.Location = new System.Drawing.Point(323, 29);
            this.gBoxGenero.Name = "gBoxGenero";
            this.gBoxGenero.Size = new System.Drawing.Size(142, 154);
            this.gBoxGenero.TabIndex = 1;
            this.gBoxGenero.TabStop = false;
            this.gBoxGenero.Text = "Genero";
            // 
            // rbtnNoBinario
            // 
            this.rbtnNoBinario.AutoSize = true;
            this.rbtnNoBinario.Location = new System.Drawing.Point(26, 109);
            this.rbtnNoBinario.Name = "rbtnNoBinario";
            this.rbtnNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbtnNoBinario.TabIndex = 2;
            this.rbtnNoBinario.TabStop = true;
            this.rbtnNoBinario.Text = "No binario";
            this.rbtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(26, 75);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtnFemenino.TabIndex = 1;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(26, 37);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // gBoxCursos
            // 
            this.gBoxCursos.Controls.Add(this.cboxJavaScript);
            this.gBoxCursos.Controls.Add(this.cboxCMasMas);
            this.gBoxCursos.Controls.Add(this.cboxCSharp);
            this.gBoxCursos.Location = new System.Drawing.Point(323, 200);
            this.gBoxCursos.Name = "gBoxCursos";
            this.gBoxCursos.Size = new System.Drawing.Size(142, 138);
            this.gBoxCursos.TabIndex = 2;
            this.gBoxCursos.TabStop = false;
            this.gBoxCursos.Text = "Cursos";
            // 
            // cboxJavaScript
            // 
            this.cboxJavaScript.AutoSize = true;
            this.cboxJavaScript.Location = new System.Drawing.Point(26, 100);
            this.cboxJavaScript.Name = "cboxJavaScript";
            this.cboxJavaScript.Size = new System.Drawing.Size(78, 19);
            this.cboxJavaScript.TabIndex = 2;
            this.cboxJavaScript.Text = "JavaScript";
            this.cboxJavaScript.UseVisualStyleBackColor = true;
            // 
            // cboxCMasMas
            // 
            this.cboxCMasMas.AutoSize = true;
            this.cboxCMasMas.Location = new System.Drawing.Point(26, 66);
            this.cboxCMasMas.Name = "cboxCMasMas";
            this.cboxCMasMas.Size = new System.Drawing.Size(50, 19);
            this.cboxCMasMas.TabIndex = 1;
            this.cboxCMasMas.Text = "C++";
            this.cboxCMasMas.UseVisualStyleBackColor = true;
            // 
            // cboxCSharp
            // 
            this.cboxCSharp.AutoSize = true;
            this.cboxCSharp.Location = new System.Drawing.Point(26, 32);
            this.cboxCSharp.Name = "cboxCSharp";
            this.cboxCSharp.Size = new System.Drawing.Size(41, 19);
            this.cboxCSharp.TabIndex = 0;
            this.cboxCSharp.Text = "C#";
            this.cboxCSharp.UseVisualStyleBackColor = true;
            // 
            // lboxPais
            // 
            this.lboxPais.FormattingEnabled = true;
            this.lboxPais.ItemHeight = 15;
            this.lboxPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lboxPais.Location = new System.Drawing.Point(37, 291);
            this.lboxPais.Name = "lboxPais";
            this.lboxPais.Size = new System.Drawing.Size(260, 94);
            this.lboxPais.TabIndex = 3;
            // 
            // llblPais
            // 
            this.llblPais.AutoSize = true;
            this.llblPais.Location = new System.Drawing.Point(37, 273);
            this.llblPais.Name = "llblPais";
            this.llblPais.Size = new System.Drawing.Size(28, 15);
            this.llblPais.TabIndex = 4;
            this.llblPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(349, 356);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(81, 29);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmIngresante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 424);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.llblPais);
            this.Controls.Add(this.lboxPais);
            this.Controls.Add(this.gBoxCursos);
            this.Controls.Add(this.gBoxGenero);
            this.Controls.Add(this.gBoxUsuario);
            this.Name = "FrmIngresante";
            this.Text = "Registro";
            this.gBoxUsuario.ResumeLayout(false);
            this.gBoxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunudEdad)).EndInit();
            this.gBoxGenero.ResumeLayout(false);
            this.gBoxGenero.PerformLayout();
            this.gBoxCursos.ResumeLayout(false);
            this.gBoxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gBoxUsuario;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblDireccion;
        private Label lblNombre;
        private NumericUpDown nunudEdad;
        private GroupBox gBoxGenero;
        private RadioButton rbtnNoBinario;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private GroupBox gBoxCursos;
        private CheckBox cboxJavaScript;
        private CheckBox cboxCMasMas;
        private CheckBox cboxCSharp;
        private ListBox lboxPais;
        private Label llblPais;
        private Button btnIngresar;
    }
}