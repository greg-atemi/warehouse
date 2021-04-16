
namespace Warehouse
{
    partial class Delete_Cube
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
            this.label1 = new System.Windows.Forms.Label();
            this.cube_id = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cube_ID";
            // 
            // cube_id
            // 
            this.cube_id.Location = new System.Drawing.Point(259, 138);
            this.cube_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cube_id.Name = "cube_id";
            this.cube_id.Size = new System.Drawing.Size(131, 20);
            this.cube_id.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(137, 242);
            this.delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 34);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(420, 242);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Delete_Cube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 419);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cube_id);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Delete_Cube";
            this.Text = "Delete_Cube";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cube_id;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button btnBack;
    }
}