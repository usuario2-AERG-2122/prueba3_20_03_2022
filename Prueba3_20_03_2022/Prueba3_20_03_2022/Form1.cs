﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba3_20_03_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, suma;

            a = int.Parse(tNumero1.Text);
            b = int.Parse(tNumero2.Text);

            suma = a + b;

            tResultado.Text = suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b,resta;
            a = int.Parse(tNumero1.Text);
            b = int.Parse(tNumero2.Text);

            resta = a - b;

            tResultado.Text = resta.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b,producto;
            a = int.Parse(tNumero1.Text);
            b = int.Parse(tNumero2.Text);

            producto = a * b;

            tResultado.Text = producto.ToString();
        }
    }
    
}
