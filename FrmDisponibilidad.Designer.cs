
namespace ReservaEntradas
{
    partial class FrmDisponibilidad
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
            this.listBoxCantAsientos = new System.Windows.Forms.ListBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCantAsientos
            // 
            this.listBoxCantAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCantAsientos.FormattingEnabled = true;
            this.listBoxCantAsientos.ItemHeight = 16;
            this.listBoxCantAsientos.Location = new System.Drawing.Point(102, 45);
            this.listBoxCantAsientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCantAsientos.Name = "listBoxCantAsientos";
            this.listBoxCantAsientos.Size = new System.Drawing.Size(277, 36);
            this.listBoxCantAsientos.TabIndex = 0;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSalir.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSalir.Location = new System.Drawing.Point(173, 335);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(153, 59);
            this.buttonSalir.TabIndex = 1;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FrmDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservaEntradas.Properties.Resources.proy5;
            this.ClientSize = new System.Drawing.Size(500, 426);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.listBoxCantAsientos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDisponibilidad";
            this.Text = "Disponibilidad";
            this.Load += new System.EventHandler(this.FrmDisponibilidad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCantAsientos;
        private System.Windows.Forms.Button buttonSalir;
    }
}