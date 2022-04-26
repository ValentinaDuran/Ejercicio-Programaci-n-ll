
namespace TP_1_PROGRAMACIÓN
{
    partial class Calendario
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblDía = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.ErrorDia = new System.Windows.Forms.Label();
            this.ErrorMes = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDía
            // 
            this.lblDía.AutoSize = true;
            this.lblDía.Location = new System.Drawing.Point(77, 89);
            this.lblDía.Name = "lblDía";
            this.lblDía.Size = new System.Drawing.Size(25, 13);
            this.lblDía.TabIndex = 1;
            this.lblDía.Text = "Día";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(211, 89);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(371, 89);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(220, 236);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "+";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(39, 122);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 5;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(326, 122);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 7;
            // 
            // ErrorDia
            // 
            this.ErrorDia.AutoSize = true;
            this.ErrorDia.Location = new System.Drawing.Point(36, 171);
            this.ErrorDia.Name = "ErrorDia";
            this.ErrorDia.Size = new System.Drawing.Size(10, 13);
            this.ErrorDia.TabIndex = 8;
            this.ErrorDia.Text = " ";
            // 
            // ErrorMes
            // 
            this.ErrorMes.AutoSize = true;
            this.ErrorMes.Location = new System.Drawing.Point(175, 103);
            this.ErrorMes.Name = "ErrorMes";
            this.ErrorMes.Size = new System.Drawing.Size(10, 13);
            this.ErrorMes.TabIndex = 9;
            this.ErrorMes.Text = " ";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(175, 122);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 6;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorMes);
            this.Controls.Add(this.ErrorDia);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDía);
            this.Controls.Add(this.button1);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDía;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label ErrorDia;
        private System.Windows.Forms.Label ErrorMes;
        private System.Windows.Forms.TextBox txtMes;
    }
}

