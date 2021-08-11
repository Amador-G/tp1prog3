
namespace TP_Nº1
{
    partial class Ej3
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
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.groupES = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.btnMostrarSeleccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clbProfesion = new System.Windows.Forms.CheckedListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbSexo.SuspendLayout();
            this.groupES.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(69, 51);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbSexo.Size = new System.Drawing.Size(215, 109);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(35, 68);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(82, 19);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(35, 31);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(81, 19);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // groupES
            // 
            this.groupES.Controls.Add(this.rbSoltero);
            this.groupES.Controls.Add(this.rbCasado);
            this.groupES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupES.Location = new System.Drawing.Point(471, 51);
            this.groupES.Name = "groupES";
            this.groupES.Size = new System.Drawing.Size(215, 113);
            this.groupES.TabIndex = 1;
            this.groupES.TabStop = false;
            this.groupES.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(46, 68);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(64, 19);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(46, 31);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(67, 19);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSeleccion
            // 
            this.btnMostrarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSeleccion.Location = new System.Drawing.Point(244, 310);
            this.btnMostrarSeleccion.Name = "btnMostrarSeleccion";
            this.btnMostrarSeleccion.Size = new System.Drawing.Size(256, 33);
            this.btnMostrarSeleccion.TabIndex = 8;
            this.btnMostrarSeleccion.Text = "Mostrar lo que selecciono";
            this.btnMostrarSeleccion.UseVisualStyleBackColor = true;
            this.btnMostrarSeleccion.Click += new System.EventHandler(this.btnMostrarSeleccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usted selecciono los siguientes elementos:";
            // 
            // clbProfesion
            // 
            this.clbProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbProfesion.FormattingEnabled = true;
            this.clbProfesion.Items.AddRange(new object[] {
            "Data entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbProfesion.Location = new System.Drawing.Point(285, 175);
            this.clbProfesion.Name = "clbProfesion";
            this.clbProfesion.Size = new System.Drawing.Size(187, 109);
            this.clbProfesion.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(554, 383);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 11;
            // 
            // Ej3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 619);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.clbProfesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarSeleccion);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.groupES);
            this.Name = "Ej3";
            this.Text = "Ej3";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.groupES.ResumeLayout(false);
            this.groupES.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.GroupBox groupES;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.Button btnMostrarSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbProfesion;
        private System.Windows.Forms.Label lblResultado;
    }
}