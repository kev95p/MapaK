using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Principal : Form
    {
        private int Nvariables = 0;
        public Principal()
        {
            InitializeComponent();
            
        }

        private void generarColumnas()
        {
            Nvariables = Convert.ToInt32(txtNumeroVariables.Text);
            int codigoletra = 65;

            dgvTabla.ColumnCount = Nvariables + 1;
            for(int i = 0; i < Nvariables; i++)
            {
                dgvTabla.Columns[i].Name = ((char)codigoletra).ToString();
                dgvTabla.Columns[i].Width = 30;
                codigoletra++;
            }
            dgvTabla.Columns[Nvariables].Name = "X";
            dgvTabla.Columns[Nvariables].Width = 30;
        }

        private void generarFilas()
        {
            int numeroFilas = Convert.ToInt32(Math.Pow(2, Nvariables));
            dgvTabla.Rows.Add(numeroFilas);
            int potencia = Nvariables - 1;

            for (int i = 0; i < dgvTabla.ColumnCount-1; i++)
            {
                int contador = 0;
                for(int j = 0; j < numeroFilas;j++)
                {
                    if (contador == Convert.ToInt32(Math.Pow(2, potencia)) * 2)
                    {
                        contador = 0;
                    }
                    if (contador < Convert.ToInt32(Math.Pow(2, potencia)))
                    {
                        dgvTabla.Rows[j].Cells[i].Value = 0;
                    }
                    else
                    {
                        dgvTabla.Rows[j].Cells[i].Value = 1;
                        dgvTabla.Rows[j].Cells[i].Style.BackColor = Color.LightBlue;

                    }

                        contador++;
                    
                }
                potencia--;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            dgvTabla.RowCount = 0;
            generarColumnas();
            generarFilas();
        }
    }
}
