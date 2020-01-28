namespace Autocred
{
    partial class Proveedores
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
            this.btn_Select_Prov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Select_Prov
            // 
            this.btn_Select_Prov.Location = new System.Drawing.Point(107, 212);
            this.btn_Select_Prov.Name = "btn_Select_Prov";
            this.btn_Select_Prov.Size = new System.Drawing.Size(75, 23);
            this.btn_Select_Prov.TabIndex = 0;
            this.btn_Select_Prov.Text = "Select";
            this.btn_Select_Prov.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Select_Prov);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Select_Prov;
    }
}