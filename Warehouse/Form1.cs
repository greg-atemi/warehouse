﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Good_record_form : Form
    {
        public Good_record_form()
        {
            InitializeComponent();
            btn_back.Click += new EventHandler(this.back);
        }

        private void Good_record_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            // code to save a good to the database
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }
        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Hide();
            form.Show();
        }
    }
}
