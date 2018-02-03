namespace AgregarDatos
{
    partial class AgregarDatos
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
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.LblNum = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(104, 62);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(175, 20);
            this.TxtNum.TabIndex = 0;
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.BackColor = System.Drawing.Color.Gray;
            this.LblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum.Location = new System.Drawing.Point(-2, 9);
            this.LblNum.MinimumSize = new System.Drawing.Size(400, 0);
            this.LblNum.Name = "LblNum";
            this.LblNum.Padding = new System.Windows.Forms.Padding(5);
            this.LblNum.Size = new System.Drawing.Size(400, 34);
            this.LblNum.TabIndex = 1;
            this.LblNum.Text = "Ingrese el Número 1";
            this.LblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(65, 139);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 42);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(211, 139);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(123, 42);
            this.BtnRegresar.TabIndex = 3;
            this.BtnRegresar.Text = "Regresar a menú";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // AgregarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(392, 208);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblNum);
            this.Controls.Add(this.TxtNum);
            this.Name = "AgregarDatos";
            this.Text = "Agregar Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnRegresar;
    }
}

