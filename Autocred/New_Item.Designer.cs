namespace Autocred
{
    partial class New_Item
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
            this.btn_AddReq = new System.Windows.Forms.Button();
            this.btn_SaveItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_Desc = new System.Windows.Forms.TextBox();
            this.textBox_Cant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_AddReq
            // 
            this.btn_AddReq.Location = new System.Drawing.Point(234, 38);
            this.btn_AddReq.Name = "btn_AddReq";
            this.btn_AddReq.Size = new System.Drawing.Size(38, 20);
            this.btn_AddReq.TabIndex = 8;
            this.btn_AddReq.Text = "Q";
            this.btn_AddReq.UseVisualStyleBackColor = true;
            this.btn_AddReq.Click += new System.EventHandler(this.btn_AddReq_Click);
            // 
            // btn_SaveItem
            // 
            this.btn_SaveItem.Location = new System.Drawing.Point(162, 117);
            this.btn_SaveItem.Name = "btn_SaveItem";
            this.btn_SaveItem.Size = new System.Drawing.Size(49, 20);
            this.btn_SaveItem.TabIndex = 12;
            this.btn_SaveItem.Text = "Save";
            this.btn_SaveItem.UseVisualStyleBackColor = true;
            this.btn_SaveItem.Click += new System.EventHandler(this.btn_SaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cant_Solic";
            // 
            // textbox_Desc
            // 
            this.textbox_Desc.Location = new System.Drawing.Point(111, 39);
            this.textbox_Desc.Name = "textbox_Desc";
            this.textbox_Desc.Size = new System.Drawing.Size(100, 20);
            this.textbox_Desc.TabIndex = 15;
            // 
            // textBox_Cant
            // 
            this.textBox_Cant.Location = new System.Drawing.Point(111, 77);
            this.textBox_Cant.Name = "textBox_Cant";
            this.textBox_Cant.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cant.TabIndex = 16;
            // 
            // New_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.textBox_Cant);
            this.Controls.Add(this.textbox_Desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SaveItem);
            this.Controls.Add(this.btn_AddReq);
            this.Name = "New_Item";
            this.Text = "New_Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddReq;
        private System.Windows.Forms.Button btn_SaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_Desc;
        private System.Windows.Forms.TextBox textBox_Cant;
    }
}