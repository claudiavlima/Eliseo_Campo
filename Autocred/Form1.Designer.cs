namespace Autocred
{
    partial class Form_Princ
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Art = new System.Windows.Forms.Button();
            this.btn_Req = new System.Windows.Forms.Button();
            this.btn_Orden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que deseas Hacer?";
            // 
            // btn_Art
            // 
            this.btn_Art.Location = new System.Drawing.Point(412, 104);
            this.btn_Art.Name = "btn_Art";
            this.btn_Art.Size = new System.Drawing.Size(75, 23);
            this.btn_Art.TabIndex = 1;
            this.btn_Art.Text = "Ver Articulos";
            this.btn_Art.UseVisualStyleBackColor = true;
            this.btn_Art.Click += new System.EventHandler(this.btn_Art_Click);
            // 
            // btn_Req
            // 
            this.btn_Req.Location = new System.Drawing.Point(239, 104);
            this.btn_Req.Name = "btn_Req";
            this.btn_Req.Size = new System.Drawing.Size(115, 23);
            this.btn_Req.TabIndex = 2;
            this.btn_Req.Text = "Requerimientos";
            this.btn_Req.UseVisualStyleBackColor = true;
            this.btn_Req.Click += new System.EventHandler(this.btn_Req_Click);
            // 
            // btn_Orden
            // 
            this.btn_Orden.Location = new System.Drawing.Point(63, 104);
            this.btn_Orden.Name = "btn_Orden";
            this.btn_Orden.Size = new System.Drawing.Size(130, 23);
            this.btn_Orden.TabIndex = 3;
            this.btn_Orden.Text = "Ordenes de compra";
            this.btn_Orden.UseVisualStyleBackColor = true;
            this.btn_Orden.Click += new System.EventHandler(this.btn_Orden_Click);
            // 
            // Form_Princ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 207);
            this.Controls.Add(this.btn_Orden);
            this.Controls.Add(this.btn_Req);
            this.Controls.Add(this.btn_Art);
            this.Controls.Add(this.label1);
            this.Name = "Form_Princ";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Princ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Art;
        private System.Windows.Forms.Button btn_Req;
        private System.Windows.Forms.Button btn_Orden;
    }
}

