﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleTrocaOleo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((textBox1.Text =="tais") &&
                 (textBox2.Text== "123456"))
                {
                Form1 form = new Form1();
                form.Show();
                this.Visible = false;
                }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
                
        }
    }
}
