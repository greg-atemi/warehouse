
namespace Warehouse
{
    partial class Main_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.update_client = new System.Windows.Forms.Button();
            this.delete_client = new System.Windows.Forms.Button();
            this.register_client = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete_good = new System.Windows.Forms.Button();
            this.update_good = new System.Windows.Forms.Button();
            this.Checkout_good = new System.Windows.Forms.Button();
            this.store_good = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete_cube = new System.Windows.Forms.Button();
            this.update_cube = new System.Windows.Forms.Button();
            this.create_cube = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN MENU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.update_client);
            this.groupBox1.Controls.Add(this.delete_client);
            this.groupBox1.Controls.Add(this.register_client);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // update_client
            // 
            this.update_client.Location = new System.Drawing.Point(439, 71);
            this.update_client.Name = "update_client";
            this.update_client.Size = new System.Drawing.Size(125, 49);
            this.update_client.TabIndex = 3;
            this.update_client.Text = "Update Client";
            this.update_client.UseVisualStyleBackColor = true;
            this.update_client.Click += new System.EventHandler(this.update_client_Click);
            // 
            // delete_client
            // 
            this.delete_client.Location = new System.Drawing.Point(837, 71);
            this.delete_client.Name = "delete_client";
            this.delete_client.Size = new System.Drawing.Size(127, 49);
            this.delete_client.TabIndex = 2;
            this.delete_client.Text = "Delete Client";
            this.delete_client.UseVisualStyleBackColor = true;
            this.delete_client.Click += new System.EventHandler(this.delete);
            // 
            // register_client
            // 
            this.register_client.Location = new System.Drawing.Point(43, 71);
            this.register_client.Name = "register_client";
            this.register_client.Size = new System.Drawing.Size(135, 49);
            this.register_client.TabIndex = 1;
            this.register_client.Text = "Register Client";
            this.register_client.UseVisualStyleBackColor = true;
            this.register_client.Click += new System.EventHandler(this.register);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Center";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete_good);
            this.groupBox2.Controls.Add(this.update_good);
            this.groupBox2.Controls.Add(this.Checkout_good);
            this.groupBox2.Controls.Add(this.store_good);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(52, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 190);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // delete_good
            // 
            this.delete_good.Location = new System.Drawing.Point(884, 78);
            this.delete_good.Name = "delete_good";
            this.delete_good.Size = new System.Drawing.Size(136, 50);
            this.delete_good.TabIndex = 4;
            this.delete_good.Text = "Delete Good";
            this.delete_good.UseVisualStyleBackColor = true;
            this.delete_good.Click += new System.EventHandler(this.delete_good_Click);
            // 
            // update_good
            // 
            this.update_good.Location = new System.Drawing.Point(607, 78);
            this.update_good.Name = "update_good";
            this.update_good.Size = new System.Drawing.Size(136, 50);
            this.update_good.TabIndex = 3;
            this.update_good.Text = "Update Good";
            this.update_good.UseVisualStyleBackColor = true;
            this.update_good.Click += new System.EventHandler(this.update_good_Click);
            // 
            // Checkout_good
            // 
            this.Checkout_good.Location = new System.Drawing.Point(317, 78);
            this.Checkout_good.Name = "Checkout_good";
            this.Checkout_good.Size = new System.Drawing.Size(136, 50);
            this.Checkout_good.TabIndex = 2;
            this.Checkout_good.Text = "Checkout Good";
            this.Checkout_good.UseVisualStyleBackColor = true;
            this.Checkout_good.Click += new System.EventHandler(this.Checkout_good_Click);
            // 
            // store_good
            // 
            this.store_good.Location = new System.Drawing.Point(42, 78);
            this.store_good.Name = "store_good";
            this.store_good.Size = new System.Drawing.Size(136, 50);
            this.store_good.TabIndex = 1;
            this.store_good.Text = "Store Good";
            this.store_good.UseVisualStyleBackColor = true;
            this.store_good.Click += new System.EventHandler(this.store_good_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gooods Center";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delete_cube);
            this.groupBox3.Controls.Add(this.update_cube);
            this.groupBox3.Controls.Add(this.create_cube);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(52, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1077, 159);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // delete_cube
            // 
            this.delete_cube.Location = new System.Drawing.Point(837, 73);
            this.delete_cube.Name = "delete_cube";
            this.delete_cube.Size = new System.Drawing.Size(129, 38);
            this.delete_cube.TabIndex = 3;
            this.delete_cube.Text = "Delete Cube";
            this.delete_cube.UseVisualStyleBackColor = true;
            this.delete_cube.Click += new System.EventHandler(this.delete_cube_Click);
            // 
            // update_cube
            // 
            this.update_cube.Location = new System.Drawing.Point(439, 73);
            this.update_cube.Name = "update_cube";
            this.update_cube.Size = new System.Drawing.Size(129, 38);
            this.update_cube.TabIndex = 2;
            this.update_cube.Text = "Update Cube";
            this.update_cube.UseVisualStyleBackColor = true;
            this.update_cube.Click += new System.EventHandler(this.update_cube_Click);
            // 
            // create_cube
            // 
            this.create_cube.Location = new System.Drawing.Point(42, 73);
            this.create_cube.Name = "create_cube";
            this.create_cube.Size = new System.Drawing.Size(129, 38);
            this.create_cube.TabIndex = 1;
            this.create_cube.Text = "Create Cube";
            this.create_cube.UseVisualStyleBackColor = true;
            this.create_cube.Click += new System.EventHandler(this.create_cube_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cube Center";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(839, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 61);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 666);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update_client;
        private System.Windows.Forms.Button delete_client;
        private System.Windows.Forms.Button register_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delete_good;
        private System.Windows.Forms.Button update_good;
        private System.Windows.Forms.Button Checkout_good;
        private System.Windows.Forms.Button store_good;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delete_cube;
        private System.Windows.Forms.Button update_cube;
        private System.Windows.Forms.Button create_cube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
    }
}