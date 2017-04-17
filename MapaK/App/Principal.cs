﻿using System;
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
            dgvTabla.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvMapa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

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
                dgvTabla.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                codigoletra++;
            }
            dgvTabla.Columns[Nvariables].Name = "X";
            dgvTabla.Columns[Nvariables].Width = 30;
            dgvTabla.Columns[Nvariables].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void generarFilas()
        {
            int numeroFilas = Convert.ToInt32(Math.Pow(2, Nvariables));
            dgvTabla.Rows.Add(numeroFilas);
            int potencia = Nvariables - 1;

            for (int i = 0; i < numeroFilas; i++)
            {
                dgvTabla.Rows[i].HeaderCell.Value = i.ToString();
            }

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

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTabla.Columns[e.ColumnIndex].Name == "X")
                {
                    DataGridViewCell cell = dgvTabla.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvTabla.CurrentCell = cell;
                    dgvTabla.BeginEdit(true);
                }
            }
            catch
            {
                return;
            }
        }

        private void dgvTabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewCell cell = dgvTabla.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if(cell.Value == null)
            {
                return;
            }
            string valor = (string)cell.Value;

            if (!valor.Equals("1"))
            {
                if (!valor.Equals("0"))
                {
                    MessageBox.Show("No es 0 o 1");
                    cell.Value = "";
                    dgvTabla.CurrentCell = cell;
                }
                
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dgvTabla.RowCount = 0;
            generarColumnas();
            generarFilas();
        }

        private void GenerarLabels()
        {
            int numeroHorizontal;
            int numeroVertical;
            pnlHorizontal.Controls.Clear();
            pnlVertical.Controls.Clear();

            if (Nvariables % 2 == 0)
            {
                numeroHorizontal = Nvariables / 2;
                numeroVertical = Nvariables / 2;
            }
            else
            {
                int resto = (Nvariables / 2) + 1;
                numeroVertical = resto;
                numeroHorizontal = Nvariables - resto;

            }
            int contador = 0;
            int i = 0;
            pnlHorizontal.Visible = true;
            pnlVertical.Visible = true;

            while (contador < numeroVertical)
            {
                Label nuevo = new Label();
                nuevo.Text = dgvTabla.Columns[i].Name;
                nuevo.Width = 10;
                pnlVertical.Controls.Add(nuevo);
                contador++;
                i++;
            }
            contador = 0;
            while (contador < numeroHorizontal)
            {
                Label nuevo = new Label();
                nuevo.Text = dgvTabla.Columns[i].Name;
                nuevo.Width = 10;
                pnlHorizontal.Controls.Add(nuevo);
                contador++;
                i++;
            }


            pnlHorizontal.Update();
            pnlVertical.Update();

        }

        private void GenerarCeldas()
        {
            int numeroHorizontal = pnlHorizontal.Controls.Count;
            int numeroVertical = pnlVertical.Controls.Count;

            
            dgvMapa.ColumnCount = Convert.ToInt32(Math.Pow(2,numeroHorizontal));
            foreach (DataGridViewColumn item in dgvMapa.Columns)
            {
                item.Width = 30;
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvMapa.RowCount = Convert.ToInt32(Math.Pow(2, numeroVertical));

        }

        private void CodigoGray()
        {
            int numeroHorizontal = pnlHorizontal.Controls.Count;
            int numeroVertical = pnlVertical.Controls.Count;
            int contador = 0;
            int c = 0;
            int potencia = 0;
            bool flag = false;

            //genera codigo gray para filas 
            while (contador < numeroVertical)
            {
                c = 0;
                flag = false;
                for (int i = 0; i < Convert.ToInt32(Math.Pow(2, numeroVertical)); i++)
                {
                    String anterior;
                    if (dgvMapa.Rows[i].HeaderCell.Value != null)
                    {
                        anterior = dgvMapa.Rows[i].HeaderCell.Value.ToString();
                    }
                    else
                    {
                        anterior = String.Empty;
                    }
                    if (c == Convert.ToInt32(Math.Pow(2, potencia)*2)){
                        c = 0;
                        flag = !flag;
                    }
                    if(c< Convert.ToInt32(Math.Pow(2, potencia)))
                    {
                        if (flag)
                        {
                            dgvMapa.Rows[i].HeaderCell.Value = "1" + anterior;
                        }
                        else
                        {
                            dgvMapa.Rows[i].HeaderCell.Value = "0" + anterior;
                        }
                        
                    }
                    else
                    {
                        if (flag)
                        {
                            dgvMapa.Rows[i].HeaderCell.Value = "0" + anterior;
                        }
                        else
                        {
                            dgvMapa.Rows[i].HeaderCell.Value = "1" + anterior;
                        }
                        
                    }
                    c++;
                    
                }
                contador++;
                potencia++;
            }
        }
        private void btnGenerarMapa_Click(object sender, EventArgs e)
        {
            LimpiarCabecerasFilas();
            GenerarLabels();
            GenerarCeldas();
            CodigoGray();
        }

        private void LimpiarCabecerasFilas()
        {
            for (int i = 0; i < dgvMapa.RowCount; i++)
            {
                dgvMapa.Rows[i].HeaderCell.Value = String.Empty;
            }
        }
    }
}
