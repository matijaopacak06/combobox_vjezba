﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "odabrana stavka:" + comboBox1.SelectedItem.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                textBox1.Text = "odabrana stavka:" + comboBox1.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show("odaberi stavku iz ComboBox-a", "informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
