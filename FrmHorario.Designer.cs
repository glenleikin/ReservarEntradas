
namespace ReservaEntradas
{
    partial class FrmHorario
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
            this.buttonHorario = new System.Windows.Forms.Button();
            this.comboBoxHorario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHorario
            // 
            this.buttonHorario.BackColor = System.Drawing.Color.DarkRed;
            this.buttonHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonHorario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHorario.Location = new System.Drawing.Point(15, 250);
            this.buttonHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHorario.Name = "buttonHorario";
            this.buttonHorario.Size = new System.Drawing.Size(211, 54);
            this.buttonHorario.TabIndex = 1;
            this.buttonHorario.Text = "Continuar";
            this.buttonHorario.UseVisualStyleBackColor = false;
            this.buttonHorario.Click += new System.EventHandler(this.buttonHorario_Click);
            // 
            // comboBoxHorario
            // 
            this.comboBoxHorario.FormattingEnabled = true;
            this.comboBoxHorario.Location = new System.Drawing.Point(15, 91);
            this.comboBoxHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHorario.Name = "comboBoxHorario";
            this.comboBoxHorario.Size = new System.Drawing.Size(296, 24);
            this.comboBoxHorario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(65, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione un horario";
            // 
            // FrmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservaEntradas.Properties.Resources.proy3;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxHorario);
            this.Controls.Add(this.buttonHorario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHorario";
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.FrmHorario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHorario;
        private System.Windows.Forms.ComboBox comboBoxHorario;
        private System.Windows.Forms.Label label1;
    }
}