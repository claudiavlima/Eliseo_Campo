namespace Autocred
{
    partial class Lista_Ordenes
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
            this.btn_Add_Orden = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grilla_Ordenes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add_Orden
            // 
            this.btn_Add_Orden.Location = new System.Drawing.Point(291, 53);
            this.btn_Add_Orden.Name = "btn_Add_Orden";
            this.btn_Add_Orden.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Orden.TabIndex = 0;
            this.btn_Add_Orden.Text = "Add";
            this.btn_Add_Orden.UseVisualStyleBackColor = true;
            this.btn_Add_Orden.Click += new System.EventHandler(this.btn_Add_Orden_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(291, 101);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Grilla_Ordenes
            // 
            this.Grilla_Ordenes.AutoSize = true;
            this.Grilla_Ordenes.Location = new System.Drawing.Point(125, 25);
            this.Grilla_Ordenes.Name = "Grilla_Ordenes";
            this.Grilla_Ordenes.Size = new System.Drawing.Size(73, 13);
            this.Grilla_Ordenes.TabIndex = 3;
            this.Grilla_Ordenes.Text = "Grilla Ordenes";
            // 
            // Lista_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 195);
            this.Controls.Add(this.Grilla_Ordenes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add_Orden);
            this.Name = "Lista_Ordenes";
            this.Text = "Lista_Ordenes";
            this.Load += new System.EventHandler(this.Lista_Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Orden;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Grilla_Ordenes;
    }
}