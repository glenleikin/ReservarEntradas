
namespace ReservaEntradas
{
    partial class FrmVolver
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
            this.lblVolver = new System.Windows.Forms.Label();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVolver.Location = new System.Drawing.Point(17, 23);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(271, 20);
            this.lblVolver.TabIndex = 0;
            this.lblVolver.Text = "¡Compra exitosa! ¿Qué desea hacer?";
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNuevaCompra.Location = new System.Drawing.Point(21, 204);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(104, 32);
            this.btnNuevaCompra.TabIndex = 1;
            this.btnNuevaCompra.Text = "Nueva compra";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(184, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 32);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmVolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservaEntradas.Properties.Resources.proyy;
            this.ClientSize = new System.Drawing.Size(300, 274);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevaCompra);
            this.Controls.Add(this.lblVolver);
            this.Name = "FrmVolver";
            this.Text = "FrmVolver";
            this.Load += new System.EventHandler(this.FrmVolver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnSalir;
    }
}