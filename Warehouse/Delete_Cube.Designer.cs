
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cube_id = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cube_ID";
            // 
            // cube_id
            // 
            this.cube_id.Location = new System.Drawing.Point(388, 212);
            this.cube_id.Name = "cube_id";
            this.cube_id.Size = new System.Drawing.Size(194, 26);
            this.cube_id.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(206, 372);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(183, 52);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(630, 372);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(183, 52);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // Delete_Cube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 645);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cube_id);
            this.Controls.Add(this.label1);
            this.Name = "Delete_Cube";
            this.Text = "Delete_Cube";
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cube_id;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider Err;
    }
}