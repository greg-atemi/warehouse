
namespace Warehouse
{
    partial class Good_checkout_form
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
            this.description = new System.Windows.Forms.RichTextBox();
            this.client_id = new System.Windows.Forms.TextBox();
            this.cube_id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.btn_release = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.released_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.received_date = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.good_id = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(198, 272);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(227, 96);
            this.description.TabIndex = 22;
            this.description.Text = "";
            // 
            // client_id
            // 
            this.client_id.Location = new System.Drawing.Point(198, 142);
            this.client_id.Name = "client_id";
            this.client_id.ReadOnly = true;
            this.client_id.Size = new System.Drawing.Size(227, 20);
            this.client_id.TabIndex = 20;
            // 
            // cube_id
            // 
            this.cube_id.Location = new System.Drawing.Point(198, 106);
            this.cube_id.Name = "cube_id";
            this.cube_id.ReadOnly = true;
            this.cube_id.Size = new System.Drawing.Size(227, 20);
            this.cube_id.TabIndex = 19;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(198, 71);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(227, 20);
            this.name.TabIndex = 18;
            // 
            // btn_release
            // 
            this.btn_release.Location = new System.Drawing.Point(481, 272);
            this.btn_release.Name = "btn_release";
            this.btn_release.Size = new System.Drawing.Size(101, 43);
            this.btn_release.TabIndex = 17;
            this.btn_release.Text = "Release Good";
            this.btn_release.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Recieved Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Client ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cube ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // released_date
            // 
            this.released_date.Location = new System.Drawing.Point(198, 220);
            this.released_date.Name = "released_date";
            this.released_date.Size = new System.Drawing.Size(227, 20);
            this.released_date.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Released Date";
            // 
            // received_date
            // 
            this.received_date.Location = new System.Drawing.Point(198, 176);
            this.received_date.Name = "received_date";
            this.received_date.ReadOnly = true;
            this.received_date.Size = new System.Drawing.Size(227, 20);
            this.received_date.TabIndex = 25;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(481, 325);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 43);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Good ID";
            // 
            // good_id
            // 
            this.good_id.FormattingEnabled = true;
            this.good_id.Location = new System.Drawing.Point(198, 36);
            this.good_id.Name = "good_id";
            this.good_id.Size = new System.Drawing.Size(227, 21);
            this.good_id.TabIndex = 28;
            // 
            // Good_checkout_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 421);
            this.Controls.Add(this.good_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.received_date);
            this.Controls.Add(this.released_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.description);
            this.Controls.Add(this.client_id);
            this.Controls.Add(this.cube_id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btn_release);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Good_checkout_form";
            this.Text = "Good_checkout_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.TextBox client_id;
        private System.Windows.Forms.TextBox cube_id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btn_release;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker released_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox received_date;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox good_id;
    }
}