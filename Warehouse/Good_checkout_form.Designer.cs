
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
            this.components = new System.ComponentModel.Container();
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
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(297, 418);
            this.description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(338, 146);
            this.description.TabIndex = 22;
            this.description.Text = "";
            // 
            // client_id
            // 
            this.client_id.Location = new System.Drawing.Point(297, 218);
            this.client_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.client_id.Name = "client_id";
            this.client_id.ReadOnly = true;
            this.client_id.Size = new System.Drawing.Size(338, 26);
            this.client_id.TabIndex = 20;
            // 
            // cube_id
            // 
            this.cube_id.Location = new System.Drawing.Point(297, 163);
            this.cube_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cube_id.Name = "cube_id";
            this.cube_id.ReadOnly = true;
            this.cube_id.Size = new System.Drawing.Size(338, 26);
            this.cube_id.TabIndex = 19;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(297, 109);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(338, 26);
            this.name.TabIndex = 18;
            // 
            // btn_release
            // 
            this.btn_release.Location = new System.Drawing.Point(722, 418);
            this.btn_release.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_release.Name = "btn_release";
            this.btn_release.Size = new System.Drawing.Size(152, 66);
            this.btn_release.TabIndex = 17;
            this.btn_release.Text = "Release Good";
            this.btn_release.UseVisualStyleBackColor = true;
            this.btn_release.Click += new System.EventHandler(this.btn_release_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Recieved Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Client ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cube ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Good Name";
            // 
            // released_date
            // 
            this.released_date.Location = new System.Drawing.Point(297, 338);
            this.released_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.released_date.Name = "released_date";
            this.released_date.Size = new System.Drawing.Size(338, 26);
            this.released_date.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Released Date";
            // 
            // received_date
            // 
            this.received_date.Location = new System.Drawing.Point(297, 271);
            this.received_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.received_date.Name = "received_date";
            this.received_date.ReadOnly = true;
            this.received_date.Size = new System.Drawing.Size(338, 26);
            this.received_date.TabIndex = 25;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(722, 500);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(152, 66);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Good ID";
            // 
            // good_id
            // 
            this.good_id.FormattingEnabled = true;
            this.good_id.Location = new System.Drawing.Point(297, 55);
            this.good_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.good_id.Name = "good_id";
            this.good_id.Size = new System.Drawing.Size(338, 28);
            this.good_id.TabIndex = 28;
            this.good_id.SelectedIndexChanged += new System.EventHandler(this.good_id_SelectedIndexChanged);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // Good_checkout_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 648);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Good_checkout_form";
            this.Text = "Good_checkout_form";
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.Load += new System.EventHandler(this.Good_checkout_form_Load);
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
        private System.Windows.Forms.ErrorProvider Err;
    }
}