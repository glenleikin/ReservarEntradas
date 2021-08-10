
namespace ReservaEntradas
{
    partial class formPersona
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombrePersona = new System.Windows.Forms.TextBox();
            this.labelNombrePersona = new System.Windows.Forms.Label();
            this.labelEdadPersona = new System.Windows.Forms.Label();
            this.buttonPersona = new System.Windows.Forms.Button();
            this.numericUpDownPersona = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrePersona
            // 
            this.nombrePersona.Location = new System.Drawing.Point(124, 98);
            this.nombrePersona.Margin = new System.Windows.Forms.Padding(2);
            this.nombrePersona.Name = "nombrePersona";
            this.nombrePersona.Size = new System.Drawing.Size(180, 20);
            this.nombrePersona.TabIndex = 0;
            // 
            // labelNombrePersona
            // 
            this.labelNombrePersona.AutoSize = true;
            this.labelNombrePersona.BackColor = System.Drawing.Color.DarkRed;
            this.labelNombrePersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNombrePersona.ForeColor = System.Drawing.SystemColors.Info;
            this.labelNombrePersona.Location = new System.Drawing.Point(145, 58);
            this.labelNombrePersona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombrePersona.Name = "labelNombrePersona";
            this.labelNombrePersona.Size = new System.Drawing.Size(126, 17);
            this.labelNombrePersona.TabIndex = 1;
            this.labelNombrePersona.Text = "Ingrese su nombre";
            // 
            // labelEdadPersona
            // 
            this.labelEdadPersona.AutoSize = true;
            this.labelEdadPersona.BackColor = System.Drawing.Color.DarkRed;
            this.labelEdadPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEdadPersona.ForeColor = System.Drawing.SystemColors.Info;
            this.labelEdadPersona.Location = new System.Drawing.Point(153, 145);
            this.labelEdadPersona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEdadPersona.Name = "labelEdadPersona";
            this.labelEdadPersona.Size = new System.Drawing.Size(110, 17);
            this.labelEdadPersona.TabIndex = 3;
            this.labelEdadPersona.Text = "Ingrese su edad";
            // 
            // buttonPersona
            // 
            this.buttonPersona.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPersona.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonPersona.Location = new System.Drawing.Point(140, 242);
            this.buttonPersona.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPersona.Name = "buttonPersona";
            this.buttonPersona.Size = new System.Drawing.Size(145, 41);
            this.buttonPersona.TabIndex = 4;
            this.buttonPersona.Text = "Continuar";
            this.buttonPersona.UseVisualStyleBackColor = false;
            this.buttonPersona.Click += new System.EventHandler(this.buttonPersona_Click);
            // 
            // numericUpDownPersona
            // 
            this.numericUpDownPersona.Location = new System.Drawing.Point(126, 184);
            this.numericUpDownPersona.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPersona.Name = "numericUpDownPersona";
            this.numericUpDownPersona.Size = new System.Drawing.Size(178, 20);
            this.numericUpDownPersona.TabIndex = 5;
            // 
            // formPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservaEntradas.Properties.Resources.proy12;
            this.ClientSize = new System.Drawing.Size(473, 381);
            this.Controls.Add(this.numericUpDownPersona);
            this.Controls.Add(this.buttonPersona);
            this.Controls.Add(this.labelEdadPersona);
            this.Controls.Add(this.labelNombrePersona);
            this.Controls.Add(this.nombrePersona);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formPersona";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.formPersona_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombrePersona;
        private System.Windows.Forms.Label labelNombrePersona;
        private System.Windows.Forms.Label labelEdadPersona;
        private System.Windows.Forms.Button buttonPersona;
        private System.Windows.Forms.NumericUpDown numericUpDownPersona;
    }
}

