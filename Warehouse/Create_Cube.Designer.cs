
namespace Warehouse
{
    partial class Create_Cube
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
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.createcube = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE CUBE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(237, 168);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(236, 26);
            this.name.TabIndex = 2;
            // 
            // createcube
            // 
            this.createcube.Location = new System.Drawing.Point(154, 329);
            this.createcube.Name = "createcube";
            this.createcube.Size = new System.Drawing.Size(188, 52);
            this.createcube.TabIndex = 3;
            this.createcube.Text = "Create";
            this.createcube.UseVisualStyleBackColor = true;
            this.createcube.Click += new System.EventHandler(this.createcube_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(572, 329);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 52);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // Create_Cube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 625);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.createcube);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_Cube";
            this.Text = "Create_Cube";
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button createcube;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider Err;
    }
}