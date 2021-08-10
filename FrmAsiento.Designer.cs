
namespace ReservaEntradas
{
    partial class FrmAsiento
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
            this.numericUpDownAsientos = new System.Windows.Forms.NumericUpDown();
            this.buttonAsiento = new System.Windows.Forms.Button();
            this.labelCantAsiento = new System.Windows.Forms.Label();
            this.buttonDisponibilidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAsientos
            // 
            this.numericUpDownAsientos.Location = new System.Drawing.Point(119, 107);
            this.numericUpDownAsientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownAsientos.Name = "numericUpDownAsientos";
            this.numericUpDownAsientos.Size = new System.Drawing.Size(225, 22);
            this.numericUpDownAsientos.TabIndex = 0;
            // 
            // buttonAsiento
            // 
            this.buttonAsiento.BackColor = System.Drawing.Color.DarkRed;
            this.buttonAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAsiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAsiento.Location = new System.Drawing.Point(257, 345);
            this.buttonAsiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAsiento.Name = "buttonAsiento";
            this.buttonAsiento.Size = new System.Drawing.Size(201, 39);
            this.buttonAsiento.TabIndex = 1;
            this.buttonAsiento.Text = "Continuar";
            this.buttonAsiento.UseVisualStyleBackColor = false;
            this.buttonAsiento.Click += new System.EventHandler(this.buttonAsiento_Click);
            // 
            // labelCantAsiento
            // 
            this.labelCantAsiento.AutoSize = true;
            this.labelCantAsiento.BackColor = System.Drawing.SystemColors.Info;
            this.labelCantAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCantAsiento.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCantAsiento.Location = new System.Drawing.Point(132, 63);
            this.labelCantAsiento.Name = "labelCantAsiento";
            this.labelCantAsiento.Size = new System.Drawing.Size(168, 20);
            this.labelCantAsiento.TabIndex = 2;
            this.labelCantAsiento.Text = "Cantidad de Asientos";
            // 
            // buttonDisponibilidad
            // 
            this.buttonDisponibilidad.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDisponibilidad.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonDisponibilidad.Location = new System.Drawing.Point(15, 338);
            this.buttonDisponibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisponibilidad.Name = "buttonDisponibilidad";
            this.buttonDisponibilidad.Size = new System.Drawing.Size(203, 58);
            this.buttonDisponibilidad.TabIndex = 5;
            this.buttonDisponibilidad.Text = "Ver Disponibilidad";
            this.buttonDisponibilidad.UseVisualStyleBackColor = false;
            this.buttonDisponibilidad.Click += new System.EventHandler(this.buttonDisponibilidad_Click);
            // 
            // FrmAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservaEntradas.Properties.Resources.prueba9;
            this.ClientSize = new System.Drawing.Size(483, 441);
            this.Controls.Add(this.buttonDisponibilidad);
            this.Controls.Add(this.labelCantAsiento);
            this.Controls.Add(this.buttonAsiento);
            this.Controls.Add(this.numericUpDownAsientos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAsiento";
            this.Text = "Asiento";
            this.Load += new System.EventHandler(this.FrmAsiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAsientos;
        private System.Windows.Forms.Button buttonAsiento;
        private System.Windows.Forms.Label labelCantAsiento;
        private System.Windows.Forms.Button buttonDisponibilidad;
    }
}