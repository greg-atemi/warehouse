using System.ComponentModel;

namespace Warehouse
{
    partial class Good_update_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.client_email = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.recieved_date = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.good_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cube_id_transfer_to = new System.Windows.Forms.ComboBox();
            this.cube_id_current = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // client_email
            // 
            this.client_email.FormattingEnabled = true;
            this.client_email.Location = new System.Drawing.Point(161, 154);
            this.client_email.Margin = new System.Windows.Forms.Padding(2);
            this.client_email.Name = "client_email";
            this.client_email.Size = new System.Drawing.Size(171, 21);
            this.client_email.TabIndex = 38;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(161, 233);
            this.description.Margin = new System.Windows.Forms.Padding(2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(171, 74);
            this.description.TabIndex = 36;
            this.description.Text = "";
            // 
            // recieved_date
            // 
            this.recieved_date.CustomFormat = "";
            this.recieved_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.recieved_date.Location = new System.Drawing.Point(161, 190);
            this.recieved_date.Margin = new System.Windows.Forms.Padding(2);
            this.recieved_date.Name = "recieved_date";
            this.recieved_date.Size = new System.Drawing.Size(171, 20);
            this.recieved_date.TabIndex = 35;
            this.recieved_date.Value = new System.DateTime(2021, 4, 15, 16, 10, 20, 0);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(161, 55);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(171, 20);
            this.name.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Recieved Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Client Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Currently in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Good Name";
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(46, 322);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(76, 33);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(256, 322);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 33);
            this.btn_update.TabIndex = 40;
            this.btn_update.Text = "Update Good";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(372, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // good_id
            // 
            this.good_id.Location = new System.Drawing.Point(161, 24);
            this.good_id.Margin = new System.Windows.Forms.Padding(2);
            this.good_id.Name = "good_id";
            this.good_id.Size = new System.Drawing.Size(171, 20);
            this.good_id.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Good ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Transfer to:";
            // 
            // cube_id_transfer_to
            // 
            this.cube_id_transfer_to.FormattingEnabled = true;
            this.cube_id_transfer_to.Location = new System.Drawing.Point(161, 124);
            this.cube_id_transfer_to.Margin = new System.Windows.Forms.Padding(2);
            this.cube_id_transfer_to.Name = "cube_id_transfer_to";
            this.cube_id_transfer_to.Size = new System.Drawing.Size(171, 21);
            this.cube_id_transfer_to.Sorted = true;
            this.cube_id_transfer_to.TabIndex = 46;
            // 
            // cube_id_current
            // 
            this.cube_id_current.Location = new System.Drawing.Point(161, 90);
            this.cube_id_current.Margin = new System.Windows.Forms.Padding(2);
            this.cube_id_current.Name = "cube_id_current";
            this.cube_id_current.Size = new System.Drawing.Size(171, 20);
            this.cube_id_current.TabIndex = 47;
            // 
            // Good_update_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 383);
            this.Controls.Add(this.cube_id_current);
            this.Controls.Add(this.cube_id_transfer_to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.good_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.client_email);
            this.Controls.Add(this.description);
            this.Controls.Add(this.recieved_date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Good_update_form";
            this.Text = "Good Update Form";
            ((System.ComponentModel.ISupportInitialize) (this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox cube_id_current;

        private System.Windows.Forms.ComboBox cube_id_transfer_to;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox good_id;

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox client_email;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker recieved_date;

        #endregion
    }
}