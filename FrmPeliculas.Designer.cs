
namespace ReservaEntradas
{
    partial class FrmPeliculas
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
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.comboBoxPeliculas = new System.Windows.Forms.ComboBox();
            this.lblSelecPeli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.BackColor = System.Drawing.Color.DarkRed;
            this.buttonPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPeliculas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPeliculas.Location = new System.Drawing.Point(141, 258);
            this.buttonPeliculas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(144, 62);
            this.buttonPeliculas.TabIndex = 1;
            this.buttonPeliculas.Text = "Continuar";
            this.buttonPeliculas.UseVisualStyleBackColor = false;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // comboBoxPeliculas
            // 
            this.comboBoxPeliculas.FormattingEnabled = true;
            this.comboBoxPeliculas.Location = new System.Drawing.Point(99, 86);
            this.comboBoxPeliculas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPeliculas.Name = "comboBoxPeliculas";
            this.comboBoxPeliculas.Size = new System.Drawing.Size(216, 21);
            this.comboBoxPeliculas.TabIndex = 2;
            // 
            // lblSelecPeli
            // 
            this.lblSelecPeli.AutoSize = true;
            this.lblSelecPeli.BackColor = System.Drawing.Color.DarkRed;
            this.lblSelecPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelecPeli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelecPeli.Location = new System.Drawing.Point(128, 55);
            this.lblSelecPeli.Name = "lblSelecPeli";
            this.lblSelecPeli.Size = new System.Drawing.Size(157, 17);
            this.lblSelecPeli.TabIndex = 3;
            this.lblSelecPeli.Text = "Seleccione una película";
            // 
            // FrmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservaEntradas.Properties.Resources.proy2;
            this.ClientSize = new System.Drawing.Size(431, 369);
            this.Controls.Add(this.lblSelecPeli);
            this.Controls.Add(this.comboBoxPeliculas);
            this.Controls.Add(this.buttonPeliculas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPeliculas";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.FrmPeliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.ComboBox comboBoxPeliculas;
        private System.Windows.Forms.Label lblSelecPeli;
    }
}