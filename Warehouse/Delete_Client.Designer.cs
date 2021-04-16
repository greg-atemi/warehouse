
namespace Warehouse
{
    partial class Delete_Client
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
            this.client_id = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client_ID";
            // 
            // client_id
            // 
            this.client_id.Location = new System.Drawing.Point(281, 128);
            this.client_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.client_id.Name = "client_id";
            this.client_id.Size = new System.Drawing.Size(191, 20);
            this.client_id.TabIndex = 1;
            this.client_id.TextChanged += new System.EventHandler(this.client_id_TextChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(183, 216);
            this.delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(97, 25);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(411, 216);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 25);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // Delete_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 422);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.client_id);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Delete_Client";
            this.Text = "Delete_Client";
            ((System.ComponentModel.ISupportInitialize) (this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox client_id;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider Err;
    }
}