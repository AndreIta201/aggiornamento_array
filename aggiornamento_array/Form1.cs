using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aggiornamento_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string[] arrayOriginale = txt_n2.Text.Split(',');
            string[] arrayElimina = txt_n1.Text.Split(',');
            string[] array = new string[arrayOriginale.Length];
            int indiceNuovo = 0;

            for (int i = 0; i < arrayElimina.Length; i++)
            {
                arrayOriginale = arrayOriginale.Where(val => val != arrayElimina[i]).ToArray();
            }
            lbl_risultato.Text = string.Join(", ", arrayOriginale);
        }
    }
    }

        