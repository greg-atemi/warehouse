
namespace Warehouse
{
    partial class Update_Cube
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
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.get_name = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cube_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Cube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(161, 100);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(133, 20);
            this.name.TabIndex = 2;
            // 
            // btnUpdate
            // 
<<<<<<< HEAD
            this.btnUpdate.Location = new System.Drawing.Point(230, 416);
=======
            this.btnUpdate.Location = new System.Drawing.Point(161, 205);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 17b7412435d5a0b17aa350eebdd613877a544ddc
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 29);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
<<<<<<< HEAD
            this.btnBack.Location = new System.Drawing.Point(642, 416);
=======
            this.btnBack.Location = new System.Drawing.Point(427, 205);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 17b7412435d5a0b17aa350eebdd613877a544ddc
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 29);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // get_name
            // 
<<<<<<< HEAD
            this.get_name.Location = new System.Drawing.Point(494, 196);
=======
            this.get_name.Location = new System.Drawing.Point(329, 100);
            this.get_name.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 17b7412435d5a0b17aa350eebdd613877a544ddc
            this.get_name.Name = "get_name";
            this.get_name.Size = new System.Drawing.Size(105, 23);
            this.get_name.TabIndex = 5;
            this.get_name.Text = "Fetch";
            this.get_name.UseVisualStyleBackColor = true;
            this.get_name.Click += new System.EventHandler(this.get_name_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cube ID";
            // 
            // cube_id
            // 
            this.cube_id.Location = new System.Drawing.Point(241, 244);
            this.cube_id.Name = "cube_id";
            this.cube_id.Size = new System.Drawing.Size(197, 26);
            this.cube_id.TabIndex = 7;
            // 
            // Update_Cube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1437, 674);
            this.Controls.Add(this.cube_id);
            this.Controls.Add(this.label3);
=======
            this.ClientSize = new System.Drawing.Size(913, 438);
>>>>>>> 17b7412435d5a0b17aa350eebdd613877a544ddc
            this.Controls.Add(this.get_name);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Update_Cube";
            this.Text = "Update_Cube";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button get_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cube_id;
    }
}