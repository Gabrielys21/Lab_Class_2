namespace App_Lab
{
    partial class Form1
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
            this.label1Nom = new System.Windows.Forms.Label();
            this.labelCarne = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelnm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1Nom
            // 
            this.label1Nom.AutoSize = true;
            this.label1Nom.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Nom.Location = new System.Drawing.Point(12, 29);
            this.label1Nom.Name = "label1Nom";
            this.label1Nom.Size = new System.Drawing.Size(568, 40);
            this.label1Nom.TabIndex = 0;
            this.label1Nom.Text = "Angel Gabriel Chavarría Yanes";
            // 
            // labelCarne
            // 
            this.labelCarne.AutoSize = true;
            this.labelCarne.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarne.Location = new System.Drawing.Point(586, 29);
            this.labelCarne.Name = "labelCarne";
            this.labelCarne.Size = new System.Drawing.Size(245, 40);
            this.labelCarne.TabIndex = 1;
            this.labelCarne.Text = "0905-23-3809";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // labelnm
            // 
            this.labelnm.AutoSize = true;
            this.labelnm.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnm.Location = new System.Drawing.Point(12, 105);
            this.labelnm.Name = "labelnm";
            this.labelnm.Size = new System.Drawing.Size(644, 40);
            this.labelnm.TabIndex = 3;
            this.labelnm.Text = "Jostyn Manrrique Godoy Chinchilla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "0905-23-2991";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnm);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelCarne);
            this.Controls.Add(this.label1Nom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Nom;
        private System.Windows.Forms.Label labelCarne;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelnm;
        private System.Windows.Forms.Label label1;
    }
}

