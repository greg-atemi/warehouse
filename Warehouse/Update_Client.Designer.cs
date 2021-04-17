
namespace Warehouse
{
    partial class Update_Client
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.get_email = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(254, 168);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(223, 26);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(254, 302);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(223, 26);
            this.phone_number.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(254, 228);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(223, 26);
            this.email.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 48);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // get_email
            // 
            this.get_email.Location = new System.Drawing.Point(516, 215);
            this.get_email.Name = "get_email";
            this.get_email.Size = new System.Drawing.Size(170, 48);
            this.get_email.TabIndex = 8;
            this.get_email.Text = "Fetch";
            this.get_email.UseVisualStyleBackColor = true;
            this.get_email.Click += new System.EventHandler(this.get_email_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(609, 425);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 48);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // Update_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 652);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.get_email);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update_Client";
            this.Text = "Update_Client";
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button get_email;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider Err;
    }
}