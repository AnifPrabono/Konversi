﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TerbilangLibrary;

namespace KonversiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
         
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(inputNominal.Text);
            Terbilang terbilang = new Terbilang ();


            hasilKonversi.Items.Clear();
            hasilKonversi.Items.Add(terbilang.TerbilangIndonesia(nominal));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
