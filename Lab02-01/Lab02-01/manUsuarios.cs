﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuarios : Form
    {
        public manUsuarios()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = textNombre.Text;
            string tele = textTelefono.Text;
            string dire = textDireccion.Text;
            string fecha = date.Text;
            string ape = textApellido.Text;
            string email = textEmail.Text;
            dataGridView1.Rows.Add(dni, nombre, tele, dire, fecha, ape, email);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
