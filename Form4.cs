using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTER_FINAL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Form1 f1)
        {
            InitializeComponent();
            f4 = f1;

        }

        Form1 f4 = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            //ACCEPT VIKOR
            f4.label25.Visible = true;
            f4.label25.Text = "VIKOR Method";
            f4.dataGridView2.Visible = true;
            f4.dataGridView3.Visible = true;
            f4.label27.Visible = true;
            f4.label28.Visible = true;


            //INHABILITAR LAS CELDAS VACIAS C1
            /*
            foreach (DataGridViewRow col_one in this.f4.dataGridView1.Rows)
            {
                for (int i = 0; i < col_one.Cells.Count; i++)
                {
                    if (col_one.Cells[1].Value == null)
                    {
                        //col_one.ReadOnly = true;
                        col_one.Cells[1].ReadOnly = true;


                    }
                }
            }
            */

            

            //C1 +
            if (f4.textBox2.Text == "+")
            {
               
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[1].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[51].Value = DIR;
                
                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[1].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();

                double wor = cworst.Min();

                
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[52].Value = wor;
                
                
                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[53].Value = f4.dataGridView4[1, 0].Value;
                
                //BORRAR LO SIGUIENTE
                /*
                double[] pe1 = (from DataGridViewRow row in f4.dataGridView4.Rows
                                   where row.Cells[1].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();
                
                double pe1_one = pe1.Max();
                */

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[54].Value = Convert.ToDouble(row.Cells[53].Value) * ((Convert.ToDouble(row.Cells[51].Value) - Convert.ToDouble(row.Cells[1].Value)) / (Convert.ToDouble(row.Cells[51].Value) - Convert.ToDouble(row.Cells[52].Value)));
                    //row.Cells[54].Value = pe1_one * (DIR - Convert.ToDouble(row.Cells[1].Value)) / ((DIR) - (wor));
                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[54].Value);

            }

            //C1 -
            if (f4.textBox2.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[1].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[51].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[1].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[52].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[53].Value = f4.dataGridView4[1, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[54].Value = Convert.ToDouble(row.Cells[53].Value) * ((Convert.ToDouble(row.Cells[51].Value) - Convert.ToDouble(row.Cells[1].Value)) / (Convert.ToDouble(row.Cells[51].Value) - Convert.ToDouble(row.Cells[52].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[54].Value);
            }

            //C2 +

            if (f4.textBox3.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[56].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[2].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[2].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[57].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[58].Value = f4.dataGridView4[2, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[59].Value = Convert.ToDouble(row.Cells[58].Value) * ((Convert.ToDouble(row.Cells[56].Value) - Convert.ToDouble(row.Cells[2].Value)) / (Convert.ToDouble(row.Cells[56].Value) - Convert.ToDouble(row.Cells[57].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[59].Value);
                
                this.f4.dataGridView2.Columns.Add("RTWO", "C2");

                f4.dataGridView2[1, 0].Value = f4.dataGridView1[59, 0].Value;
                f4.dataGridView2[1, 1].Value = f4.dataGridView1[59, 1].Value;
                f4.dataGridView2[1, 2].Value = f4.dataGridView1[59, 2].Value;
                f4.dataGridView2[1, 3].Value = f4.dataGridView1[59, 3].Value;
                f4.dataGridView2[1, 4].Value = f4.dataGridView1[59, 4].Value;
                f4.dataGridView2[1, 5].Value = f4.dataGridView1[59, 5].Value;
                f4.dataGridView2[1, 6].Value = f4.dataGridView1[59, 6].Value;
                f4.dataGridView2[1, 7].Value = f4.dataGridView1[59, 7].Value;
                f4.dataGridView2[1, 8].Value = f4.dataGridView1[59, 8].Value;
                f4.dataGridView2[1, 9].Value = f4.dataGridView1[59, 9].Value;
                f4.dataGridView2[1, 10].Value = f4.dataGridView1[59, 10].Value;
                f4.dataGridView2[1, 11].Value = f4.dataGridView1[59, 11].Value;
                f4.dataGridView2[1, 12].Value = f4.dataGridView1[59, 12].Value;
                f4.dataGridView2[1, 13].Value = f4.dataGridView1[59, 13].Value;
                f4.dataGridView2[1, 14].Value = f4.dataGridView1[59, 14].Value;
                f4.dataGridView2[1, 15].Value = f4.dataGridView1[59, 15].Value;
                f4.dataGridView2[1, 16].Value = f4.dataGridView1[59, 16].Value;

            }

            //C2 -

            if (f4.textBox3.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[56].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[2].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[2].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[57].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[58].Value = f4.dataGridView4[2, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[59].Value = Convert.ToDouble(row.Cells[58].Value) * ((Convert.ToDouble(row.Cells[56].Value) - Convert.ToDouble(row.Cells[2].Value)) / (Convert.ToDouble(row.Cells[56].Value) - Convert.ToDouble(row.Cells[57].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[59].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C2");

                f4.dataGridView2[1, 0].Value = f4.dataGridView1[59, 0].Value;
                f4.dataGridView2[1, 1].Value = f4.dataGridView1[59, 1].Value;
                f4.dataGridView2[1, 2].Value = f4.dataGridView1[59, 2].Value;
                f4.dataGridView2[1, 3].Value = f4.dataGridView1[59, 3].Value;
                f4.dataGridView2[1, 4].Value = f4.dataGridView1[59, 4].Value;
                f4.dataGridView2[1, 5].Value = f4.dataGridView1[59, 5].Value;
                f4.dataGridView2[1, 6].Value = f4.dataGridView1[59, 6].Value;
                f4.dataGridView2[1, 7].Value = f4.dataGridView1[59, 7].Value;
                f4.dataGridView2[1, 8].Value = f4.dataGridView1[59, 8].Value;
                f4.dataGridView2[1, 9].Value = f4.dataGridView1[59, 9].Value;
                f4.dataGridView2[1, 10].Value = f4.dataGridView1[59, 10].Value;
                f4.dataGridView2[1, 11].Value = f4.dataGridView1[59, 11].Value;
                f4.dataGridView2[1, 12].Value = f4.dataGridView1[59, 12].Value;
                f4.dataGridView2[1, 13].Value = f4.dataGridView1[59, 13].Value;
                f4.dataGridView2[1, 14].Value = f4.dataGridView1[59, 14].Value;
                f4.dataGridView2[1, 15].Value = f4.dataGridView1[59, 15].Value;
                f4.dataGridView2[1, 16].Value = f4.dataGridView1[59, 16].Value;

            }
            //C3 +

            if (f4.textBox4.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[61].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[62].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[63].Value = f4.dataGridView4[3, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[64].Value = Convert.ToDouble(row.Cells[63].Value) * ((Convert.ToDouble(row.Cells[61].Value) - Convert.ToDouble(row.Cells[3].Value)) / (Convert.ToDouble(row.Cells[61].Value) - Convert.ToDouble(row.Cells[62].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[64].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C3");

                f4.dataGridView2[2, 0].Value = f4.dataGridView1[64, 0].Value;
                f4.dataGridView2[2, 1].Value = f4.dataGridView1[64, 1].Value;
                f4.dataGridView2[2, 2].Value = f4.dataGridView1[64, 2].Value;
                f4.dataGridView2[2, 3].Value = f4.dataGridView1[64, 3].Value;
                f4.dataGridView2[2, 4].Value = f4.dataGridView1[64, 4].Value;
                f4.dataGridView2[2, 5].Value = f4.dataGridView1[64, 5].Value;
                f4.dataGridView2[2, 6].Value = f4.dataGridView1[64, 6].Value;
                f4.dataGridView2[2, 7].Value = f4.dataGridView1[64, 7].Value;
                f4.dataGridView2[2, 8].Value = f4.dataGridView1[64, 8].Value;
                f4.dataGridView2[2, 9].Value = f4.dataGridView1[64, 9].Value;
                f4.dataGridView2[2, 10].Value = f4.dataGridView1[64, 10].Value;
                f4.dataGridView2[2, 11].Value = f4.dataGridView1[64, 11].Value;
                f4.dataGridView2[2, 12].Value = f4.dataGridView1[64, 12].Value;
                f4.dataGridView2[2, 13].Value = f4.dataGridView1[64, 13].Value;
                f4.dataGridView2[2, 14].Value = f4.dataGridView1[64, 14].Value;
                f4.dataGridView2[2, 15].Value = f4.dataGridView1[64, 15].Value;
                f4.dataGridView2[2, 16].Value = f4.dataGridView1[64, 16].Value;

            }

            //C3 -

            if (f4.textBox4.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[61].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[62].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[63].Value = f4.dataGridView4[3, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[64].Value = Convert.ToDouble(row.Cells[63].Value) * ((Convert.ToDouble(row.Cells[61].Value) - Convert.ToDouble(row.Cells[3].Value)) / (Convert.ToDouble(row.Cells[61].Value) - Convert.ToDouble(row.Cells[62].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[64].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C3");

                f4.dataGridView2[2, 0].Value = f4.dataGridView1[64, 0].Value;
                f4.dataGridView2[2, 1].Value = f4.dataGridView1[64, 1].Value;
                f4.dataGridView2[2, 2].Value = f4.dataGridView1[64, 2].Value;
                f4.dataGridView2[2, 3].Value = f4.dataGridView1[64, 3].Value;
                f4.dataGridView2[2, 4].Value = f4.dataGridView1[64, 4].Value;
                f4.dataGridView2[2, 5].Value = f4.dataGridView1[64, 5].Value;
                f4.dataGridView2[2, 6].Value = f4.dataGridView1[64, 6].Value;
                f4.dataGridView2[2, 7].Value = f4.dataGridView1[64, 7].Value;
                f4.dataGridView2[2, 8].Value = f4.dataGridView1[64, 8].Value;
                f4.dataGridView2[2, 9].Value = f4.dataGridView1[64, 9].Value;
                f4.dataGridView2[2, 10].Value = f4.dataGridView1[64, 10].Value;
                f4.dataGridView2[2, 11].Value = f4.dataGridView1[64, 11].Value;
                f4.dataGridView2[2, 12].Value = f4.dataGridView1[64, 12].Value;
                f4.dataGridView2[2, 13].Value = f4.dataGridView1[64, 13].Value;
                f4.dataGridView2[2, 14].Value = f4.dataGridView1[64, 14].Value;
                f4.dataGridView2[2, 15].Value = f4.dataGridView1[64, 15].Value;
                f4.dataGridView2[2, 16].Value = f4.dataGridView1[64, 16].Value;

            }
            //C4 +
            if (f4.textBox5.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[4].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[66].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[67].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[68].Value = f4.dataGridView4[4, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[69].Value = Convert.ToDouble(row.Cells[68].Value) * ((Convert.ToDouble(row.Cells[66].Value) - Convert.ToDouble(row.Cells[4].Value)) / (Convert.ToDouble(row.Cells[66].Value) - Convert.ToDouble(row.Cells[67].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[69].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C4");

                f4.dataGridView2[3, 0].Value = f4.dataGridView1[69, 0].Value;
                f4.dataGridView2[3, 1].Value = f4.dataGridView1[69, 1].Value;
                f4.dataGridView2[3, 2].Value = f4.dataGridView1[69, 2].Value;
                f4.dataGridView2[3, 3].Value = f4.dataGridView1[69, 3].Value;
                f4.dataGridView2[3, 4].Value = f4.dataGridView1[69, 4].Value;
                f4.dataGridView2[3, 5].Value = f4.dataGridView1[69, 5].Value;
                f4.dataGridView2[3, 6].Value = f4.dataGridView1[69, 6].Value;
                f4.dataGridView2[3, 7].Value = f4.dataGridView1[69, 7].Value;
                f4.dataGridView2[3, 8].Value = f4.dataGridView1[69, 8].Value;
                f4.dataGridView2[3, 9].Value = f4.dataGridView1[69, 9].Value;
                f4.dataGridView2[3, 10].Value = f4.dataGridView1[69, 10].Value;
                f4.dataGridView2[3, 11].Value = f4.dataGridView1[69, 11].Value;
                f4.dataGridView2[3, 12].Value = f4.dataGridView1[69, 12].Value;
                f4.dataGridView2[3, 13].Value = f4.dataGridView1[69, 13].Value;
                f4.dataGridView2[3, 14].Value = f4.dataGridView1[69, 14].Value;
                f4.dataGridView2[3, 15].Value = f4.dataGridView1[69, 15].Value;
                f4.dataGridView2[3, 16].Value = f4.dataGridView1[69, 16].Value;

            }
            //C4-

            if (f4.textBox5.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[4].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[66].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[67].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[68].Value = f4.dataGridView4[4, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[69].Value = Convert.ToDouble(row.Cells[68].Value) * ((Convert.ToDouble(row.Cells[66].Value) - Convert.ToDouble(row.Cells[4].Value)) / (Convert.ToDouble(row.Cells[66].Value) - Convert.ToDouble(row.Cells[67].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[69].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C4");

                f4.dataGridView2[3, 0].Value = f4.dataGridView1[69, 0].Value;
                f4.dataGridView2[3, 1].Value = f4.dataGridView1[69, 1].Value;
                f4.dataGridView2[3, 2].Value = f4.dataGridView1[69, 2].Value;
                f4.dataGridView2[3, 3].Value = f4.dataGridView1[69, 3].Value;
                f4.dataGridView2[3, 4].Value = f4.dataGridView1[69, 4].Value;
                f4.dataGridView2[3, 5].Value = f4.dataGridView1[69, 5].Value;
                f4.dataGridView2[3, 6].Value = f4.dataGridView1[69, 6].Value;
                f4.dataGridView2[3, 7].Value = f4.dataGridView1[69, 7].Value;
                f4.dataGridView2[3, 8].Value = f4.dataGridView1[69, 8].Value;
                f4.dataGridView2[3, 9].Value = f4.dataGridView1[69, 9].Value;
                f4.dataGridView2[3, 10].Value = f4.dataGridView1[69, 10].Value;
                f4.dataGridView2[3, 11].Value = f4.dataGridView1[69, 11].Value;
                f4.dataGridView2[3, 12].Value = f4.dataGridView1[69, 12].Value;
                f4.dataGridView2[3, 13].Value = f4.dataGridView1[69, 13].Value;
                f4.dataGridView2[3, 14].Value = f4.dataGridView1[69, 14].Value;
                f4.dataGridView2[3, 15].Value = f4.dataGridView1[69, 15].Value;
                f4.dataGridView2[3, 16].Value = f4.dataGridView1[69, 16].Value;

            }
            //C5+

            if (f4.textBox6.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[71].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[5].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[72].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[73].Value = f4.dataGridView4[4, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[74].Value = Convert.ToDouble(row.Cells[73].Value) * ((Convert.ToDouble(row.Cells[71].Value) - Convert.ToDouble(row.Cells[5].Value)) / (Convert.ToDouble(row.Cells[71].Value) - Convert.ToDouble(row.Cells[72].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[74].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C5");

                f4.dataGridView2[4, 0].Value = f4.dataGridView1[74, 0].Value;
                f4.dataGridView2[4, 1].Value = f4.dataGridView1[74, 1].Value;
                f4.dataGridView2[4, 2].Value = f4.dataGridView1[74, 2].Value;
                f4.dataGridView2[4, 3].Value = f4.dataGridView1[74, 3].Value;
                f4.dataGridView2[4, 4].Value = f4.dataGridView1[74, 4].Value;
                f4.dataGridView2[4, 5].Value = f4.dataGridView1[74, 5].Value;
                f4.dataGridView2[4, 6].Value = f4.dataGridView1[74, 6].Value;
                f4.dataGridView2[4, 7].Value = f4.dataGridView1[74, 7].Value;
                f4.dataGridView2[4, 8].Value = f4.dataGridView1[74, 8].Value;
                f4.dataGridView2[4, 9].Value = f4.dataGridView1[74, 9].Value;
                f4.dataGridView2[4, 10].Value = f4.dataGridView1[74, 10].Value;
                f4.dataGridView2[4, 11].Value = f4.dataGridView1[74, 11].Value;
                f4.dataGridView2[4, 12].Value = f4.dataGridView1[74, 12].Value;
                f4.dataGridView2[4, 13].Value = f4.dataGridView1[74, 13].Value;
                f4.dataGridView2[4, 14].Value = f4.dataGridView1[74, 14].Value;
                f4.dataGridView2[4, 15].Value = f4.dataGridView1[74, 15].Value;
                f4.dataGridView2[4, 16].Value = f4.dataGridView1[74, 16].Value;

            }
            //C5 -

            if (f4.textBox6.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[71].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[5].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[72].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[73].Value = f4.dataGridView4[4, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[74].Value = Convert.ToDouble(row.Cells[73].Value) * ((Convert.ToDouble(row.Cells[71].Value) - Convert.ToDouble(row.Cells[5].Value)) / (Convert.ToDouble(row.Cells[71].Value) - Convert.ToDouble(row.Cells[72].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[74].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C5");

                f4.dataGridView2[4, 0].Value = f4.dataGridView1[74, 0].Value;
                f4.dataGridView2[4, 1].Value = f4.dataGridView1[74, 1].Value;
                f4.dataGridView2[4, 2].Value = f4.dataGridView1[74, 2].Value;
                f4.dataGridView2[4, 3].Value = f4.dataGridView1[74, 3].Value;
                f4.dataGridView2[4, 4].Value = f4.dataGridView1[74, 4].Value;
                f4.dataGridView2[4, 5].Value = f4.dataGridView1[74, 5].Value;
                f4.dataGridView2[4, 6].Value = f4.dataGridView1[74, 6].Value;
                f4.dataGridView2[4, 7].Value = f4.dataGridView1[74, 7].Value;
                f4.dataGridView2[4, 8].Value = f4.dataGridView1[74, 8].Value;
                f4.dataGridView2[4, 9].Value = f4.dataGridView1[74, 9].Value;
                f4.dataGridView2[4, 10].Value = f4.dataGridView1[74, 10].Value;
                f4.dataGridView2[4, 11].Value = f4.dataGridView1[74, 11].Value;
                f4.dataGridView2[4, 12].Value = f4.dataGridView1[74, 12].Value;
                f4.dataGridView2[4, 13].Value = f4.dataGridView1[74, 13].Value;
                f4.dataGridView2[4, 14].Value = f4.dataGridView1[74, 14].Value;
                f4.dataGridView2[4, 15].Value = f4.dataGridView1[74, 15].Value;
                f4.dataGridView2[4, 16].Value = f4.dataGridView1[74, 16].Value;

            }
            //C6 +

            if (f4.textBox7.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[76].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[6].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[77].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[78].Value = f4.dataGridView4[5, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[79].Value = Convert.ToDouble(row.Cells[78].Value) * ((Convert.ToDouble(row.Cells[76].Value) - Convert.ToDouble(row.Cells[6].Value)) / (Convert.ToDouble(row.Cells[76].Value) - Convert.ToDouble(row.Cells[77].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[79].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C6");

                f4.dataGridView2[5, 0].Value = f4.dataGridView1[79, 0].Value;
                f4.dataGridView2[5, 1].Value = f4.dataGridView1[79, 1].Value;
                f4.dataGridView2[5, 2].Value = f4.dataGridView1[79, 2].Value;
                f4.dataGridView2[5, 3].Value = f4.dataGridView1[79, 3].Value;
                f4.dataGridView2[5, 4].Value = f4.dataGridView1[79, 4].Value;
                f4.dataGridView2[5, 5].Value = f4.dataGridView1[79, 5].Value;
                f4.dataGridView2[5, 6].Value = f4.dataGridView1[79, 6].Value;
                f4.dataGridView2[5, 7].Value = f4.dataGridView1[79, 7].Value;
                f4.dataGridView2[5, 8].Value = f4.dataGridView1[79, 8].Value;
                f4.dataGridView2[5, 9].Value = f4.dataGridView1[79, 9].Value;
                f4.dataGridView2[5, 10].Value = f4.dataGridView1[79, 10].Value;
                f4.dataGridView2[5, 11].Value = f4.dataGridView1[79, 11].Value;
                f4.dataGridView2[5, 12].Value = f4.dataGridView1[79, 12].Value;
                f4.dataGridView2[5, 13].Value = f4.dataGridView1[79, 13].Value;
                f4.dataGridView2[5, 14].Value = f4.dataGridView1[79, 14].Value;
                f4.dataGridView2[5, 15].Value = f4.dataGridView1[79, 15].Value;
                f4.dataGridView2[5, 16].Value = f4.dataGridView1[79, 16].Value;

            }
            //C6 -
            if (f4.textBox7.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[76].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[6].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[77].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[78].Value = f4.dataGridView4[5, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[79].Value = Convert.ToDouble(row.Cells[78].Value) * ((Convert.ToDouble(row.Cells[76].Value) - Convert.ToDouble(row.Cells[6].Value)) / (Convert.ToDouble(row.Cells[76].Value) - Convert.ToDouble(row.Cells[77].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[79].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C6");

                f4.dataGridView2[5, 0].Value = f4.dataGridView1[79, 0].Value;
                f4.dataGridView2[5, 1].Value = f4.dataGridView1[79, 1].Value;
                f4.dataGridView2[5, 2].Value = f4.dataGridView1[79, 2].Value;
                f4.dataGridView2[5, 3].Value = f4.dataGridView1[79, 3].Value;
                f4.dataGridView2[5, 4].Value = f4.dataGridView1[79, 4].Value;
                f4.dataGridView2[5, 5].Value = f4.dataGridView1[79, 5].Value;
                f4.dataGridView2[5, 6].Value = f4.dataGridView1[79, 6].Value;
                f4.dataGridView2[5, 7].Value = f4.dataGridView1[79, 7].Value;
                f4.dataGridView2[5, 8].Value = f4.dataGridView1[79, 8].Value;
                f4.dataGridView2[5, 9].Value = f4.dataGridView1[79, 9].Value;
                f4.dataGridView2[5, 10].Value = f4.dataGridView1[79, 10].Value;
                f4.dataGridView2[5, 11].Value = f4.dataGridView1[79, 11].Value;
                f4.dataGridView2[5, 12].Value = f4.dataGridView1[79, 12].Value;
                f4.dataGridView2[5, 13].Value = f4.dataGridView1[79, 13].Value;
                f4.dataGridView2[5, 14].Value = f4.dataGridView1[79, 14].Value;
                f4.dataGridView2[5, 15].Value = f4.dataGridView1[79, 15].Value;
                f4.dataGridView2[5, 16].Value = f4.dataGridView1[79, 16].Value;

            }
            //C7 +

            if (f4.textBox8.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[7].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[81].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[82].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[83].Value = f4.dataGridView4[6, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[84].Value = Convert.ToDouble(row.Cells[83].Value) * ((Convert.ToDouble(row.Cells[81].Value) - Convert.ToDouble(row.Cells[7].Value)) / (Convert.ToDouble(row.Cells[81].Value) - Convert.ToDouble(row.Cells[82].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[84].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C7");

                f4.dataGridView2[6, 0].Value = f4.dataGridView1[84, 0].Value;
                f4.dataGridView2[6, 1].Value = f4.dataGridView1[84, 1].Value;
                f4.dataGridView2[6, 2].Value = f4.dataGridView1[84, 2].Value;
                f4.dataGridView2[6, 3].Value = f4.dataGridView1[84, 3].Value;
                f4.dataGridView2[6, 4].Value = f4.dataGridView1[84, 4].Value;
                f4.dataGridView2[6, 5].Value = f4.dataGridView1[84, 5].Value;
                f4.dataGridView2[6, 6].Value = f4.dataGridView1[84, 6].Value;
                f4.dataGridView2[6, 7].Value = f4.dataGridView1[84, 7].Value;
                f4.dataGridView2[6, 8].Value = f4.dataGridView1[84, 8].Value;
                f4.dataGridView2[6, 9].Value = f4.dataGridView1[84, 9].Value;
                f4.dataGridView2[6, 10].Value = f4.dataGridView1[84, 10].Value;
                f4.dataGridView2[6, 11].Value = f4.dataGridView1[84, 11].Value;
                f4.dataGridView2[6, 12].Value = f4.dataGridView1[84, 12].Value;
                f4.dataGridView2[6, 13].Value = f4.dataGridView1[84, 13].Value;
                f4.dataGridView2[6, 14].Value = f4.dataGridView1[84, 14].Value;
                f4.dataGridView2[6, 15].Value = f4.dataGridView1[84, 15].Value;
                f4.dataGridView2[6, 16].Value = f4.dataGridView1[84, 16].Value;

            }
            //C7 - 

            if (f4.textBox8.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[7].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[81].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[82].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[83].Value = f4.dataGridView4[6, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[84].Value = Convert.ToDouble(row.Cells[83].Value) * ((Convert.ToDouble(row.Cells[81].Value) - Convert.ToDouble(row.Cells[7].Value)) / (Convert.ToDouble(row.Cells[81].Value) - Convert.ToDouble(row.Cells[82].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[84].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C7");

                f4.dataGridView2[6, 0].Value = f4.dataGridView1[84, 0].Value;
                f4.dataGridView2[6, 1].Value = f4.dataGridView1[84, 1].Value;
                f4.dataGridView2[6, 2].Value = f4.dataGridView1[84, 2].Value;
                f4.dataGridView2[6, 3].Value = f4.dataGridView1[84, 3].Value;
                f4.dataGridView2[6, 4].Value = f4.dataGridView1[84, 4].Value;
                f4.dataGridView2[6, 5].Value = f4.dataGridView1[84, 5].Value;
                f4.dataGridView2[6, 6].Value = f4.dataGridView1[84, 6].Value;
                f4.dataGridView2[6, 7].Value = f4.dataGridView1[84, 7].Value;
                f4.dataGridView2[6, 8].Value = f4.dataGridView1[84, 8].Value;
                f4.dataGridView2[6, 9].Value = f4.dataGridView1[84, 9].Value;
                f4.dataGridView2[6, 10].Value = f4.dataGridView1[84, 10].Value;
                f4.dataGridView2[6, 11].Value = f4.dataGridView1[84, 11].Value;
                f4.dataGridView2[6, 12].Value = f4.dataGridView1[84, 12].Value;
                f4.dataGridView2[6, 13].Value = f4.dataGridView1[84, 13].Value;
                f4.dataGridView2[6, 14].Value = f4.dataGridView1[84, 14].Value;
                f4.dataGridView2[6, 15].Value = f4.dataGridView1[84, 15].Value;
                f4.dataGridView2[6, 16].Value = f4.dataGridView1[84, 16].Value;

            }
            //C8 +
            if (f4.textBox9.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[8].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[8].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[86].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[8].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[8].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[87].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[88].Value = f4.dataGridView4[7, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[89].Value = Convert.ToDouble(row.Cells[88].Value) * ((Convert.ToDouble(row.Cells[86].Value) - Convert.ToDouble(row.Cells[8].Value)) / (Convert.ToDouble(row.Cells[86].Value) - Convert.ToDouble(row.Cells[87].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[89].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C8");

                f4.dataGridView2[7, 0].Value = f4.dataGridView1[89, 0].Value;
                f4.dataGridView2[7, 1].Value = f4.dataGridView1[89, 1].Value;
                f4.dataGridView2[7, 2].Value = f4.dataGridView1[89, 2].Value;
                f4.dataGridView2[7, 3].Value = f4.dataGridView1[89, 3].Value;
                f4.dataGridView2[7, 4].Value = f4.dataGridView1[89, 4].Value;
                f4.dataGridView2[7, 5].Value = f4.dataGridView1[89, 5].Value;
                f4.dataGridView2[7, 6].Value = f4.dataGridView1[89, 6].Value;
                f4.dataGridView2[7, 7].Value = f4.dataGridView1[89, 7].Value;
                f4.dataGridView2[7, 8].Value = f4.dataGridView1[89, 8].Value;
                f4.dataGridView2[7, 9].Value = f4.dataGridView1[89, 9].Value;
                f4.dataGridView2[7, 10].Value = f4.dataGridView1[89, 10].Value;
                f4.dataGridView2[7, 11].Value = f4.dataGridView1[89, 11].Value;
                f4.dataGridView2[7, 12].Value = f4.dataGridView1[89, 12].Value;
                f4.dataGridView2[7, 13].Value = f4.dataGridView1[89, 13].Value;
                f4.dataGridView2[7, 14].Value = f4.dataGridView1[89, 14].Value;
                f4.dataGridView2[7, 15].Value = f4.dataGridView1[89, 15].Value;
                f4.dataGridView2[7, 16].Value = f4.dataGridView1[89, 16].Value;

            }
            //C8 -
            
            if (f4.textBox9.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[8].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[8].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[86].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[8].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[8].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[87].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[88].Value = f4.dataGridView4[7, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[89].Value = Convert.ToDouble(row.Cells[88].Value) * ((Convert.ToDouble(row.Cells[86].Value) - Convert.ToDouble(row.Cells[8].Value)) / (Convert.ToDouble(row.Cells[86].Value) - Convert.ToDouble(row.Cells[87].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[89].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C8");

                f4.dataGridView2[7, 0].Value = f4.dataGridView1[89, 0].Value;
                f4.dataGridView2[7, 1].Value = f4.dataGridView1[89, 1].Value;
                f4.dataGridView2[7, 2].Value = f4.dataGridView1[89, 2].Value;
                f4.dataGridView2[7, 3].Value = f4.dataGridView1[89, 3].Value;
                f4.dataGridView2[7, 4].Value = f4.dataGridView1[89, 4].Value;
                f4.dataGridView2[7, 5].Value = f4.dataGridView1[89, 5].Value;
                f4.dataGridView2[7, 6].Value = f4.dataGridView1[89, 6].Value;
                f4.dataGridView2[7, 7].Value = f4.dataGridView1[89, 7].Value;
                f4.dataGridView2[7, 8].Value = f4.dataGridView1[89, 8].Value;
                f4.dataGridView2[7, 9].Value = f4.dataGridView1[89, 9].Value;
                f4.dataGridView2[7, 10].Value = f4.dataGridView1[89, 10].Value;
                f4.dataGridView2[7, 11].Value = f4.dataGridView1[89, 11].Value;
                f4.dataGridView2[7, 12].Value = f4.dataGridView1[89, 12].Value;
                f4.dataGridView2[7, 13].Value = f4.dataGridView1[89, 13].Value;
                f4.dataGridView2[7, 14].Value = f4.dataGridView1[89, 14].Value;
                f4.dataGridView2[7, 15].Value = f4.dataGridView1[89, 15].Value;
                f4.dataGridView2[7, 16].Value = f4.dataGridView1[89, 16].Value;

            }
            //C9 +
            if (f4.textBox10.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[9].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[91].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[9].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[92].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[93].Value = f4.dataGridView4[8, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[94].Value = Convert.ToDouble(row.Cells[93].Value) * ((Convert.ToDouble(row.Cells[91].Value) - Convert.ToDouble(row.Cells[9].Value)) / (Convert.ToDouble(row.Cells[91].Value) - Convert.ToDouble(row.Cells[92].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[94].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C9");

                f4.dataGridView2[8, 0].Value = f4.dataGridView1[94, 0].Value;
                f4.dataGridView2[8, 1].Value = f4.dataGridView1[94, 1].Value;
                f4.dataGridView2[8, 2].Value = f4.dataGridView1[94, 2].Value;
                f4.dataGridView2[8, 3].Value = f4.dataGridView1[94, 3].Value;
                f4.dataGridView2[8, 4].Value = f4.dataGridView1[94, 4].Value;
                f4.dataGridView2[8, 5].Value = f4.dataGridView1[94, 5].Value;
                f4.dataGridView2[8, 6].Value = f4.dataGridView1[94, 6].Value;
                f4.dataGridView2[8, 7].Value = f4.dataGridView1[94, 7].Value;
                f4.dataGridView2[8, 8].Value = f4.dataGridView1[94, 8].Value;
                f4.dataGridView2[8, 9].Value = f4.dataGridView1[94, 9].Value;
                f4.dataGridView2[8, 10].Value = f4.dataGridView1[94, 10].Value;
                f4.dataGridView2[8, 11].Value = f4.dataGridView1[94, 11].Value;
                f4.dataGridView2[8, 12].Value = f4.dataGridView1[94, 12].Value;
                f4.dataGridView2[8, 13].Value = f4.dataGridView1[94, 13].Value;
                f4.dataGridView2[8, 14].Value = f4.dataGridView1[94, 14].Value;
                f4.dataGridView2[8, 15].Value = f4.dataGridView1[94, 15].Value;
                f4.dataGridView2[8, 16].Value = f4.dataGridView1[94, 16].Value;

            }
            //C9 -

            if (f4.textBox10.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[9].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[91].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[9].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[92].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[93].Value = f4.dataGridView4[8, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[94].Value = Convert.ToDouble(row.Cells[93].Value) * ((Convert.ToDouble(row.Cells[91].Value) - Convert.ToDouble(row.Cells[9].Value)) / (Convert.ToDouble(row.Cells[91].Value) - Convert.ToDouble(row.Cells[92].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[94].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C9");

                f4.dataGridView2[8, 0].Value = f4.dataGridView1[94, 0].Value;
                f4.dataGridView2[8, 1].Value = f4.dataGridView1[94, 1].Value;
                f4.dataGridView2[8, 2].Value = f4.dataGridView1[94, 2].Value;
                f4.dataGridView2[8, 3].Value = f4.dataGridView1[94, 3].Value;
                f4.dataGridView2[8, 4].Value = f4.dataGridView1[94, 4].Value;
                f4.dataGridView2[8, 5].Value = f4.dataGridView1[94, 5].Value;
                f4.dataGridView2[8, 6].Value = f4.dataGridView1[94, 6].Value;
                f4.dataGridView2[8, 7].Value = f4.dataGridView1[94, 7].Value;
                f4.dataGridView2[8, 8].Value = f4.dataGridView1[94, 8].Value;
                f4.dataGridView2[8, 9].Value = f4.dataGridView1[94, 9].Value;
                f4.dataGridView2[8, 10].Value = f4.dataGridView1[94, 10].Value;
                f4.dataGridView2[8, 11].Value = f4.dataGridView1[94, 11].Value;
                f4.dataGridView2[8, 12].Value = f4.dataGridView1[94, 12].Value;
                f4.dataGridView2[8, 13].Value = f4.dataGridView1[94, 13].Value;
                f4.dataGridView2[8, 14].Value = f4.dataGridView1[94, 14].Value;
                f4.dataGridView2[8, 15].Value = f4.dataGridView1[94, 15].Value;
                f4.dataGridView2[8, 16].Value = f4.dataGridView1[94, 16].Value;

            }
            //C10 +

            if (f4.textBox11.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[10].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[96].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[10].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[97].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[98].Value = f4.dataGridView4[9, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[99].Value = Convert.ToDouble(row.Cells[98].Value) * ((Convert.ToDouble(row.Cells[96].Value) - Convert.ToDouble(row.Cells[10].Value)) / (Convert.ToDouble(row.Cells[96].Value) - Convert.ToDouble(row.Cells[97].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[99].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C10");

                f4.dataGridView2[9, 0].Value = f4.dataGridView1[99, 0].Value;
                f4.dataGridView2[9, 1].Value = f4.dataGridView1[99, 1].Value;
                f4.dataGridView2[9, 2].Value = f4.dataGridView1[99, 2].Value;
                f4.dataGridView2[9, 3].Value = f4.dataGridView1[99, 3].Value;
                f4.dataGridView2[9, 4].Value = f4.dataGridView1[99, 4].Value;
                f4.dataGridView2[9, 5].Value = f4.dataGridView1[99, 5].Value;
                f4.dataGridView2[9, 6].Value = f4.dataGridView1[99, 6].Value;
                f4.dataGridView2[9, 7].Value = f4.dataGridView1[99, 7].Value;
                f4.dataGridView2[9, 8].Value = f4.dataGridView1[99, 8].Value;
                f4.dataGridView2[9, 9].Value = f4.dataGridView1[99, 9].Value;
                f4.dataGridView2[9, 10].Value = f4.dataGridView1[99, 10].Value;
                f4.dataGridView2[9, 11].Value = f4.dataGridView1[99, 11].Value;
                f4.dataGridView2[9, 12].Value = f4.dataGridView1[99, 12].Value;
                f4.dataGridView2[9, 13].Value = f4.dataGridView1[99, 13].Value;
                f4.dataGridView2[9, 14].Value = f4.dataGridView1[99, 14].Value;
                f4.dataGridView2[9, 15].Value = f4.dataGridView1[99, 15].Value;
                f4.dataGridView2[9, 16].Value = f4.dataGridView1[99, 16].Value;

            }
            //C10 -

            if (f4.textBox11.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[10].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[96].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[10].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[97].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[98].Value = f4.dataGridView4[9, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[99].Value = Convert.ToDouble(row.Cells[98].Value) * ((Convert.ToDouble(row.Cells[96].Value) - Convert.ToDouble(row.Cells[10].Value)) / (Convert.ToDouble(row.Cells[96].Value) - Convert.ToDouble(row.Cells[97].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[99].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C10");

                f4.dataGridView2[9, 0].Value = f4.dataGridView1[99, 0].Value;
                f4.dataGridView2[9, 1].Value = f4.dataGridView1[99, 1].Value;
                f4.dataGridView2[9, 2].Value = f4.dataGridView1[99, 2].Value;
                f4.dataGridView2[9, 3].Value = f4.dataGridView1[99, 3].Value;
                f4.dataGridView2[9, 4].Value = f4.dataGridView1[99, 4].Value;
                f4.dataGridView2[9, 5].Value = f4.dataGridView1[99, 5].Value;
                f4.dataGridView2[9, 6].Value = f4.dataGridView1[99, 6].Value;
                f4.dataGridView2[9, 7].Value = f4.dataGridView1[99, 7].Value;
                f4.dataGridView2[9, 8].Value = f4.dataGridView1[99, 8].Value;
                f4.dataGridView2[9, 9].Value = f4.dataGridView1[99, 9].Value;
                f4.dataGridView2[9, 10].Value = f4.dataGridView1[99, 10].Value;
                f4.dataGridView2[9, 11].Value = f4.dataGridView1[99, 11].Value;
                f4.dataGridView2[9, 12].Value = f4.dataGridView1[99, 12].Value;
                f4.dataGridView2[9, 13].Value = f4.dataGridView1[99, 13].Value;
                f4.dataGridView2[9, 14].Value = f4.dataGridView1[99, 14].Value;
                f4.dataGridView2[9, 15].Value = f4.dataGridView1[99, 15].Value;
                f4.dataGridView2[9, 16].Value = f4.dataGridView1[99, 16].Value;

            }
            //C11 +

            if (f4.textBox12.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[11].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[11].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[101].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[11].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[11].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[102].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[103].Value = f4.dataGridView4[10, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[104].Value = Convert.ToDouble(row.Cells[103].Value) * ((Convert.ToDouble(row.Cells[101].Value) - Convert.ToDouble(row.Cells[11].Value)) / (Convert.ToDouble(row.Cells[101].Value) - Convert.ToDouble(row.Cells[102].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[104].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C11");

                f4.dataGridView2[10, 0].Value = f4.dataGridView1[104, 0].Value;
                f4.dataGridView2[10, 1].Value = f4.dataGridView1[104, 1].Value;
                f4.dataGridView2[10, 2].Value = f4.dataGridView1[104, 2].Value;
                f4.dataGridView2[10, 3].Value = f4.dataGridView1[104, 3].Value;
                f4.dataGridView2[10, 4].Value = f4.dataGridView1[104, 4].Value;
                f4.dataGridView2[10, 5].Value = f4.dataGridView1[104, 5].Value;
                f4.dataGridView2[10, 6].Value = f4.dataGridView1[104, 6].Value;
                f4.dataGridView2[10, 7].Value = f4.dataGridView1[104, 7].Value;
                f4.dataGridView2[10, 8].Value = f4.dataGridView1[104, 8].Value;
                f4.dataGridView2[10, 9].Value = f4.dataGridView1[104, 9].Value;
                f4.dataGridView2[10, 10].Value = f4.dataGridView1[104, 10].Value;
                f4.dataGridView2[10, 11].Value = f4.dataGridView1[104, 11].Value;
                f4.dataGridView2[10, 12].Value = f4.dataGridView1[104, 12].Value;
                f4.dataGridView2[10, 13].Value = f4.dataGridView1[104, 13].Value;
                f4.dataGridView2[10, 14].Value = f4.dataGridView1[104, 14].Value;
                f4.dataGridView2[10, 15].Value = f4.dataGridView1[104, 15].Value;
                f4.dataGridView2[10, 16].Value = f4.dataGridView1[104, 16].Value;

            }
            //C11 -
            if (f4.textBox12.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[11].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[11].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[101].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[11].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[11].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[102].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[103].Value = f4.dataGridView4[10, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[104].Value = Convert.ToDouble(row.Cells[103].Value) * ((Convert.ToDouble(row.Cells[101].Value) - Convert.ToDouble(row.Cells[11].Value)) / (Convert.ToDouble(row.Cells[101].Value) - Convert.ToDouble(row.Cells[102].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[104].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C11");

                f4.dataGridView2[10, 0].Value = f4.dataGridView1[104, 0].Value;
                f4.dataGridView2[10, 1].Value = f4.dataGridView1[104, 1].Value;
                f4.dataGridView2[10, 2].Value = f4.dataGridView1[104, 2].Value;
                f4.dataGridView2[10, 3].Value = f4.dataGridView1[104, 3].Value;
                f4.dataGridView2[10, 4].Value = f4.dataGridView1[104, 4].Value;
                f4.dataGridView2[10, 5].Value = f4.dataGridView1[104, 5].Value;
                f4.dataGridView2[10, 6].Value = f4.dataGridView1[104, 6].Value;
                f4.dataGridView2[10, 7].Value = f4.dataGridView1[104, 7].Value;
                f4.dataGridView2[10, 8].Value = f4.dataGridView1[104, 8].Value;
                f4.dataGridView2[10, 9].Value = f4.dataGridView1[104, 9].Value;
                f4.dataGridView2[10, 10].Value = f4.dataGridView1[104, 10].Value;
                f4.dataGridView2[10, 11].Value = f4.dataGridView1[104, 11].Value;
                f4.dataGridView2[10, 12].Value = f4.dataGridView1[104, 12].Value;
                f4.dataGridView2[10, 13].Value = f4.dataGridView1[104, 13].Value;
                f4.dataGridView2[10, 14].Value = f4.dataGridView1[104, 14].Value;
                f4.dataGridView2[10, 15].Value = f4.dataGridView1[104, 15].Value;
                f4.dataGridView2[10, 16].Value = f4.dataGridView1[104, 16].Value;

            }
            //C12 +

            if (f4.textBox13.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[12].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[12].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[106].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[12].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[12].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[107].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[108].Value = f4.dataGridView4[11, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[109].Value = Convert.ToDouble(row.Cells[108].Value) * ((Convert.ToDouble(row.Cells[106].Value) - Convert.ToDouble(row.Cells[12].Value)) / (Convert.ToDouble(row.Cells[106].Value) - Convert.ToDouble(row.Cells[107].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[109].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C12");

                f4.dataGridView2[11, 0].Value = f4.dataGridView1[109, 0].Value;
                f4.dataGridView2[11, 1].Value = f4.dataGridView1[109, 1].Value;
                f4.dataGridView2[11, 2].Value = f4.dataGridView1[109, 2].Value;
                f4.dataGridView2[11, 3].Value = f4.dataGridView1[109, 3].Value;
                f4.dataGridView2[11, 4].Value = f4.dataGridView1[109, 4].Value;
                f4.dataGridView2[11, 5].Value = f4.dataGridView1[109, 5].Value;
                f4.dataGridView2[11, 6].Value = f4.dataGridView1[109, 6].Value;
                f4.dataGridView2[11, 7].Value = f4.dataGridView1[109, 7].Value;
                f4.dataGridView2[11, 8].Value = f4.dataGridView1[109, 8].Value;
                f4.dataGridView2[11, 9].Value = f4.dataGridView1[109, 9].Value;
                f4.dataGridView2[11, 10].Value = f4.dataGridView1[109, 10].Value;
                f4.dataGridView2[11, 11].Value = f4.dataGridView1[109, 11].Value;
                f4.dataGridView2[11, 12].Value = f4.dataGridView1[109, 12].Value;
                f4.dataGridView2[11, 13].Value = f4.dataGridView1[109, 13].Value;
                f4.dataGridView2[11, 14].Value = f4.dataGridView1[109, 14].Value;
                f4.dataGridView2[11, 15].Value = f4.dataGridView1[109, 15].Value;
                f4.dataGridView2[11, 16].Value = f4.dataGridView1[109, 16].Value;

            }
            //C12 -
            if (f4.textBox13.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[12].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[12].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[106].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[12].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[12].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[107].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[108].Value = f4.dataGridView4[11, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[109].Value = Convert.ToDouble(row.Cells[108].Value) * ((Convert.ToDouble(row.Cells[106].Value) - Convert.ToDouble(row.Cells[12].Value)) / (Convert.ToDouble(row.Cells[106].Value) - Convert.ToDouble(row.Cells[107].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[109].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C12");

                f4.dataGridView2[11, 0].Value = f4.dataGridView1[109, 0].Value;
                f4.dataGridView2[11, 1].Value = f4.dataGridView1[109, 1].Value;
                f4.dataGridView2[11, 2].Value = f4.dataGridView1[109, 2].Value;
                f4.dataGridView2[11, 3].Value = f4.dataGridView1[109, 3].Value;
                f4.dataGridView2[11, 4].Value = f4.dataGridView1[109, 4].Value;
                f4.dataGridView2[11, 5].Value = f4.dataGridView1[109, 5].Value;
                f4.dataGridView2[11, 6].Value = f4.dataGridView1[109, 6].Value;
                f4.dataGridView2[11, 7].Value = f4.dataGridView1[109, 7].Value;
                f4.dataGridView2[11, 8].Value = f4.dataGridView1[109, 8].Value;
                f4.dataGridView2[11, 9].Value = f4.dataGridView1[109, 9].Value;
                f4.dataGridView2[11, 10].Value = f4.dataGridView1[109, 10].Value;
                f4.dataGridView2[11, 11].Value = f4.dataGridView1[109, 11].Value;
                f4.dataGridView2[11, 12].Value = f4.dataGridView1[109, 12].Value;
                f4.dataGridView2[11, 13].Value = f4.dataGridView1[109, 13].Value;
                f4.dataGridView2[11, 14].Value = f4.dataGridView1[109, 14].Value;
                f4.dataGridView2[11, 15].Value = f4.dataGridView1[109, 15].Value;
                f4.dataGridView2[11, 16].Value = f4.dataGridView1[109, 16].Value;

            }

            //C13 +

            if (f4.textBox14.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[13].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[13].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[111].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[13].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[13].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[112].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[113].Value = f4.dataGridView4[12, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[114].Value = Convert.ToDouble(row.Cells[113].Value) * ((Convert.ToDouble(row.Cells[111].Value) - Convert.ToDouble(row.Cells[13].Value)) / (Convert.ToDouble(row.Cells[111].Value) - Convert.ToDouble(row.Cells[112].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[114].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C13");

                f4.dataGridView2[12, 0].Value = f4.dataGridView1[114, 0].Value;
                f4.dataGridView2[12, 1].Value = f4.dataGridView1[114, 1].Value;
                f4.dataGridView2[12, 2].Value = f4.dataGridView1[114, 2].Value;
                f4.dataGridView2[12, 3].Value = f4.dataGridView1[114, 3].Value;
                f4.dataGridView2[12, 4].Value = f4.dataGridView1[114, 4].Value;
                f4.dataGridView2[12, 5].Value = f4.dataGridView1[114, 5].Value;
                f4.dataGridView2[12, 6].Value = f4.dataGridView1[114, 6].Value;
                f4.dataGridView2[12, 7].Value = f4.dataGridView1[114, 7].Value;
                f4.dataGridView2[12, 8].Value = f4.dataGridView1[114, 8].Value;
                f4.dataGridView2[12, 9].Value = f4.dataGridView1[114, 9].Value;
                f4.dataGridView2[12, 10].Value = f4.dataGridView1[114, 10].Value;
                f4.dataGridView2[12, 11].Value = f4.dataGridView1[114, 11].Value;
                f4.dataGridView2[12, 12].Value = f4.dataGridView1[114, 12].Value;
                f4.dataGridView2[12, 13].Value = f4.dataGridView1[114, 13].Value;
                f4.dataGridView2[12, 14].Value = f4.dataGridView1[114, 14].Value;
                f4.dataGridView2[12, 15].Value = f4.dataGridView1[114, 15].Value;
                f4.dataGridView2[12, 16].Value = f4.dataGridView1[114, 16].Value;

            }
            //C13 -
            if (f4.textBox14.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[13].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[13].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[111].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[13].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[13].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[112].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[113].Value = f4.dataGridView4[12, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[114].Value = Convert.ToDouble(row.Cells[113].Value) * ((Convert.ToDouble(row.Cells[111].Value) - Convert.ToDouble(row.Cells[13].Value)) / (Convert.ToDouble(row.Cells[111].Value) - Convert.ToDouble(row.Cells[112].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[114].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C13");

                f4.dataGridView2[12, 0].Value = f4.dataGridView1[114, 0].Value;
                f4.dataGridView2[12, 1].Value = f4.dataGridView1[114, 1].Value;
                f4.dataGridView2[12, 2].Value = f4.dataGridView1[114, 2].Value;
                f4.dataGridView2[12, 3].Value = f4.dataGridView1[114, 3].Value;
                f4.dataGridView2[12, 4].Value = f4.dataGridView1[114, 4].Value;
                f4.dataGridView2[12, 5].Value = f4.dataGridView1[114, 5].Value;
                f4.dataGridView2[12, 6].Value = f4.dataGridView1[114, 6].Value;
                f4.dataGridView2[12, 7].Value = f4.dataGridView1[114, 7].Value;
                f4.dataGridView2[12, 8].Value = f4.dataGridView1[114, 8].Value;
                f4.dataGridView2[12, 9].Value = f4.dataGridView1[114, 9].Value;
                f4.dataGridView2[12, 10].Value = f4.dataGridView1[114, 10].Value;
                f4.dataGridView2[12, 11].Value = f4.dataGridView1[114, 11].Value;
                f4.dataGridView2[12, 12].Value = f4.dataGridView1[114, 12].Value;
                f4.dataGridView2[12, 13].Value = f4.dataGridView1[114, 13].Value;
                f4.dataGridView2[12, 14].Value = f4.dataGridView1[114, 14].Value;
                f4.dataGridView2[12, 15].Value = f4.dataGridView1[114, 15].Value;
                f4.dataGridView2[12, 16].Value = f4.dataGridView1[114, 16].Value;

            }
            //C14 +
            if (f4.textBox15.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[14].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[14].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[116].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[14].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[14].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[117].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[118].Value = f4.dataGridView4[13, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[119].Value = Convert.ToDouble(row.Cells[118].Value) * ((Convert.ToDouble(row.Cells[116].Value) - Convert.ToDouble(row.Cells[14].Value)) / (Convert.ToDouble(row.Cells[116].Value) - Convert.ToDouble(row.Cells[117].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[119].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C14");

                f4.dataGridView2[13, 0].Value = f4.dataGridView1[119, 0].Value;
                f4.dataGridView2[13, 1].Value = f4.dataGridView1[119, 1].Value;
                f4.dataGridView2[13, 2].Value = f4.dataGridView1[119, 2].Value;
                f4.dataGridView2[13, 3].Value = f4.dataGridView1[119, 3].Value;
                f4.dataGridView2[13, 4].Value = f4.dataGridView1[119, 4].Value;
                f4.dataGridView2[13, 5].Value = f4.dataGridView1[119, 5].Value;
                f4.dataGridView2[13, 6].Value = f4.dataGridView1[119, 6].Value;
                f4.dataGridView2[13, 7].Value = f4.dataGridView1[119, 7].Value;
                f4.dataGridView2[13, 8].Value = f4.dataGridView1[119, 8].Value;
                f4.dataGridView2[13, 9].Value = f4.dataGridView1[119, 9].Value;
                f4.dataGridView2[13, 10].Value = f4.dataGridView1[119, 10].Value;
                f4.dataGridView2[13, 11].Value = f4.dataGridView1[119, 11].Value;
                f4.dataGridView2[13, 12].Value = f4.dataGridView1[119, 12].Value;
                f4.dataGridView2[13, 13].Value = f4.dataGridView1[119, 13].Value;
                f4.dataGridView2[13, 14].Value = f4.dataGridView1[119, 14].Value;
                f4.dataGridView2[13, 15].Value = f4.dataGridView1[119, 15].Value;
                f4.dataGridView2[13, 16].Value = f4.dataGridView1[119, 16].Value;

            }
            //C14 -
            if (f4.textBox15.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[14].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[14].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[116].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[14].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[14].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[117].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[118].Value = f4.dataGridView4[13, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[119].Value = Convert.ToDouble(row.Cells[118].Value) * ((Convert.ToDouble(row.Cells[116].Value) - Convert.ToDouble(row.Cells[14].Value)) / (Convert.ToDouble(row.Cells[116].Value) - Convert.ToDouble(row.Cells[117].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[119].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C14");

                f4.dataGridView2[13, 0].Value = f4.dataGridView1[119, 0].Value;
                f4.dataGridView2[13, 1].Value = f4.dataGridView1[119, 1].Value;
                f4.dataGridView2[13, 2].Value = f4.dataGridView1[119, 2].Value;
                f4.dataGridView2[13, 3].Value = f4.dataGridView1[119, 3].Value;
                f4.dataGridView2[13, 4].Value = f4.dataGridView1[119, 4].Value;
                f4.dataGridView2[13, 5].Value = f4.dataGridView1[119, 5].Value;
                f4.dataGridView2[13, 6].Value = f4.dataGridView1[119, 6].Value;
                f4.dataGridView2[13, 7].Value = f4.dataGridView1[119, 7].Value;
                f4.dataGridView2[13, 8].Value = f4.dataGridView1[119, 8].Value;
                f4.dataGridView2[13, 9].Value = f4.dataGridView1[119, 9].Value;
                f4.dataGridView2[13, 10].Value = f4.dataGridView1[119, 10].Value;
                f4.dataGridView2[13, 11].Value = f4.dataGridView1[119, 11].Value;
                f4.dataGridView2[13, 12].Value = f4.dataGridView1[119, 12].Value;
                f4.dataGridView2[13, 13].Value = f4.dataGridView1[119, 13].Value;
                f4.dataGridView2[13, 14].Value = f4.dataGridView1[119, 14].Value;
                f4.dataGridView2[13, 15].Value = f4.dataGridView1[119, 15].Value;
                f4.dataGridView2[13, 16].Value = f4.dataGridView1[119, 16].Value;

            }
            //C15 +
            if (f4.textBox16.Text == "+")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[15].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[15].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[121].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[15].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[15].FormattedValue)).ToArray();

                double wor = cworst.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[122].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[123].Value = f4.dataGridView4[14, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[124].Value = Convert.ToDouble(row.Cells[123].Value) * ((Convert.ToDouble(row.Cells[121].Value) - Convert.ToDouble(row.Cells[15].Value)) / (Convert.ToDouble(row.Cells[121].Value) - Convert.ToDouble(row.Cells[122].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[124].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C15");

                f4.dataGridView2[14, 0].Value = f4.dataGridView1[124, 0].Value;
                f4.dataGridView2[14, 1].Value = f4.dataGridView1[124, 1].Value;
                f4.dataGridView2[14, 2].Value = f4.dataGridView1[124, 2].Value;
                f4.dataGridView2[14, 3].Value = f4.dataGridView1[124, 3].Value;
                f4.dataGridView2[14, 4].Value = f4.dataGridView1[124, 4].Value;
                f4.dataGridView2[14, 5].Value = f4.dataGridView1[124, 5].Value;
                f4.dataGridView2[14, 6].Value = f4.dataGridView1[124, 6].Value;
                f4.dataGridView2[14, 7].Value = f4.dataGridView1[124, 7].Value;
                f4.dataGridView2[14, 8].Value = f4.dataGridView1[124, 8].Value;
                f4.dataGridView2[14, 9].Value = f4.dataGridView1[124, 9].Value;
                f4.dataGridView2[14, 10].Value = f4.dataGridView1[124, 10].Value;
                f4.dataGridView2[14, 11].Value = f4.dataGridView1[124, 11].Value;
                f4.dataGridView2[14, 12].Value = f4.dataGridView1[124, 12].Value;
                f4.dataGridView2[14, 13].Value = f4.dataGridView1[124, 13].Value;
                f4.dataGridView2[14, 14].Value = f4.dataGridView1[124, 14].Value;
                f4.dataGridView2[14, 15].Value = f4.dataGridView1[124, 15].Value;
                f4.dataGridView2[14, 16].Value = f4.dataGridView1[124, 16].Value;

            }
            //C15 -
            if (f4.textBox16.Text == "-")
            {
                //Best Value
                double[] columnData = (from DataGridViewRow row in f4.dataGridView1.Rows
                                       where row.Cells[15].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[15].FormattedValue)).ToArray();

                double DIR = columnData.Min();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[121].Value = DIR;

                //WORST VALUE
                double[] cworst = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[15].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[15].FormattedValue)).ToArray();

                double wor = cworst.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[122].Value = wor;

                //PESOS ASIGNADOS A COLUMNA 53
                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[123].Value = f4.dataGridView4[14, 0].Value;

                foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                    row.Cells[124].Value = Convert.ToDouble(row.Cells[123].Value) * ((Convert.ToDouble(row.Cells[121].Value) - Convert.ToDouble(row.Cells[15].Value)) / (Convert.ToDouble(row.Cells[121].Value) - Convert.ToDouble(row.Cells[122].Value)));

                foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f4.dataGridView2.Rows.Add(row.Cells[124].Value);

                this.f4.dataGridView2.Columns.Add("RTWO", "C15");

                f4.dataGridView2[14, 0].Value = f4.dataGridView1[124, 0].Value;
                f4.dataGridView2[14, 1].Value = f4.dataGridView1[124, 1].Value;
                f4.dataGridView2[14, 2].Value = f4.dataGridView1[124, 2].Value;
                f4.dataGridView2[14, 3].Value = f4.dataGridView1[124, 3].Value;
                f4.dataGridView2[14, 4].Value = f4.dataGridView1[124, 4].Value;
                f4.dataGridView2[14, 5].Value = f4.dataGridView1[124, 5].Value;
                f4.dataGridView2[14, 6].Value = f4.dataGridView1[124, 6].Value;
                f4.dataGridView2[14, 7].Value = f4.dataGridView1[124, 7].Value;
                f4.dataGridView2[14, 8].Value = f4.dataGridView1[124, 8].Value;
                f4.dataGridView2[14, 9].Value = f4.dataGridView1[124, 9].Value;
                f4.dataGridView2[14, 10].Value = f4.dataGridView1[124, 10].Value;
                f4.dataGridView2[14, 11].Value = f4.dataGridView1[124, 11].Value;
                f4.dataGridView2[14, 12].Value = f4.dataGridView1[124, 12].Value;
                f4.dataGridView2[14, 13].Value = f4.dataGridView1[124, 13].Value;
                f4.dataGridView2[14, 14].Value = f4.dataGridView1[124, 14].Value;
                f4.dataGridView2[14, 15].Value = f4.dataGridView1[124, 15].Value;
                f4.dataGridView2[14, 16].Value = f4.dataGridView1[124, 16].Value;

            }
            //SI
            foreach (DataGridViewRow row in f4.dataGridView1.Rows)
                row.Cells[200].Value = Convert.ToDouble(row.Cells[54].Value) + Convert.ToDouble(row.Cells[59].Value) + Convert.ToDouble(row.Cells[64].Value) + Convert.ToDouble(row.Cells[69].Value) + Convert.ToDouble(row.Cells[74].Value) + Convert.ToDouble(row.Cells[79].Value) + Convert.ToDouble(row.Cells[84].Value) + Convert.ToDouble(row.Cells[89].Value) + Convert.ToDouble(row.Cells[94].Value) + Convert.ToDouble(row.Cells[99].Value) + Convert.ToDouble(row.Cells[104].Value) + Convert.ToDouble(row.Cells[109].Value) + Convert.ToDouble(row.Cells[114].Value) + Convert.ToDouble(row.Cells[119].Value) + Convert.ToDouble(row.Cells[124].Value);

            //DESACTIVAR 200, 5 EN ADELANTE HASTA 50
            if (f4.dataGridView1[1, 5].Value == null)
            {
                f4.dataGridView1[200, 5].Value = null;
                f4.dataGridView1[200, 6].Value = null;
                f4.dataGridView1[200, 7].Value = null;
                f4.dataGridView1[200, 8].Value = null;
                f4.dataGridView1[200, 9].Value = null;
                f4.dataGridView1[200, 10].Value = null;
                f4.dataGridView1[200, 11].Value = null;
                f4.dataGridView1[200, 12].Value = null;
                f4.dataGridView1[200, 13].Value = null;
                f4.dataGridView1[200, 14].Value = null;
                f4.dataGridView1[200, 15].Value = null;
                f4.dataGridView1[200, 16].Value = null;
                f4.dataGridView1[200, 17].Value = null;
                f4.dataGridView1[200, 18].Value = null;
                f4.dataGridView1[200, 19].Value = null;
                f4.dataGridView1[200, 20].Value = null;
                f4.dataGridView1[200, 21].Value = null;
                f4.dataGridView1[200, 22].Value = null;
                f4.dataGridView1[200, 23].Value = null;
                f4.dataGridView1[200, 24].Value = null;
                f4.dataGridView1[200, 25].Value = null;
                f4.dataGridView1[200, 26].Value = null;
                f4.dataGridView1[200, 27].Value = null;
                f4.dataGridView1[200, 28].Value = null;
                f4.dataGridView1[200, 29].Value = null;
                f4.dataGridView1[200, 30].Value = null;
                f4.dataGridView1[200, 31].Value = null;
                f4.dataGridView1[200, 32].Value = null;
                f4.dataGridView1[200, 33].Value = null;
                f4.dataGridView1[200, 34].Value = null;
                f4.dataGridView1[200, 35].Value = null;
                f4.dataGridView1[200, 36].Value = null;
                f4.dataGridView1[200, 37].Value = null;
                f4.dataGridView1[200, 38].Value = null;
                f4.dataGridView1[200, 39].Value = null;
                f4.dataGridView1[200, 40].Value = null;
                f4.dataGridView1[200, 41].Value = null;
                f4.dataGridView1[200, 42].Value = null;
                f4.dataGridView1[200, 43].Value = null;
                f4.dataGridView1[200, 44].Value = null;
                f4.dataGridView1[200, 45].Value = null;
                f4.dataGridView1[200, 46].Value = null;
                f4.dataGridView1[200, 47].Value = null;
                f4.dataGridView1[200, 48].Value = null;
                f4.dataGridView1[200, 49].Value = null;
                f4.dataGridView1[200, 50].Value = null;

                
            }

            //DESACTIVAR 200, 4 EN ADELANTE HASTA 50
            if (f4.dataGridView1[1, 4].Value == null)
            {
                f4.dataGridView1[200, 4].Value = null;
                f4.dataGridView1[200, 5].Value = null;
                f4.dataGridView1[200, 6].Value = null;
                f4.dataGridView1[200, 7].Value = null;
                f4.dataGridView1[200, 8].Value = null;
                f4.dataGridView1[200, 9].Value = null;
                f4.dataGridView1[200, 10].Value = null;
                f4.dataGridView1[200, 11].Value = null;
                f4.dataGridView1[200, 12].Value = null;
                f4.dataGridView1[200, 13].Value = null;
                f4.dataGridView1[200, 14].Value = null;
                f4.dataGridView1[200, 15].Value = null;
                f4.dataGridView1[200, 16].Value = null;
                f4.dataGridView1[200, 17].Value = null;
                f4.dataGridView1[200, 18].Value = null;
                f4.dataGridView1[200, 19].Value = null;
                f4.dataGridView1[200, 20].Value = null;
                f4.dataGridView1[200, 21].Value = null;
                f4.dataGridView1[200, 22].Value = null;
                f4.dataGridView1[200, 23].Value = null;
                f4.dataGridView1[200, 24].Value = null;
                f4.dataGridView1[200, 25].Value = null;
                f4.dataGridView1[200, 26].Value = null;
                f4.dataGridView1[200, 27].Value = null;
                f4.dataGridView1[200, 28].Value = null;
                f4.dataGridView1[200, 29].Value = null;
                f4.dataGridView1[200, 30].Value = null;
                f4.dataGridView1[200, 31].Value = null;
                f4.dataGridView1[200, 32].Value = null;
                f4.dataGridView1[200, 33].Value = null;
                f4.dataGridView1[200, 34].Value = null;
                f4.dataGridView1[200, 35].Value = null;
                f4.dataGridView1[200, 36].Value = null;
                f4.dataGridView1[200, 37].Value = null;
                f4.dataGridView1[200, 38].Value = null;
                f4.dataGridView1[200, 39].Value = null;
                f4.dataGridView1[200, 40].Value = null;
                f4.dataGridView1[200, 41].Value = null;
                f4.dataGridView1[200, 42].Value = null;
                f4.dataGridView1[200, 43].Value = null;
                f4.dataGridView1[200, 44].Value = null;
                f4.dataGridView1[200, 45].Value = null;
                f4.dataGridView1[200, 46].Value = null;
                f4.dataGridView1[200, 47].Value = null;
                f4.dataGridView1[200, 48].Value = null;
                f4.dataGridView1[200, 49].Value = null;
                f4.dataGridView1[200, 50].Value = null;


            }

            //DESACTIVAR 200, 3 EN ADELANTE HASTA 50
            if (f4.dataGridView1[1, 3].Value == null)
            {
                f4.dataGridView1[200, 3].Value = null;
                f4.dataGridView1[200, 4].Value = null;
                f4.dataGridView1[200, 5].Value = null;
                f4.dataGridView1[200, 6].Value = null;
                f4.dataGridView1[200, 7].Value = null;
                f4.dataGridView1[200, 8].Value = null;
                f4.dataGridView1[200, 9].Value = null;
                f4.dataGridView1[200, 10].Value = null;
                f4.dataGridView1[200, 11].Value = null;
                f4.dataGridView1[200, 12].Value = null;
                f4.dataGridView1[200, 13].Value = null;
                f4.dataGridView1[200, 14].Value = null;
                f4.dataGridView1[200, 15].Value = null;
                f4.dataGridView1[200, 16].Value = null;
                f4.dataGridView1[200, 17].Value = null;
                f4.dataGridView1[200, 18].Value = null;
                f4.dataGridView1[200, 19].Value = null;
                f4.dataGridView1[200, 20].Value = null;
                f4.dataGridView1[200, 21].Value = null;
                f4.dataGridView1[200, 22].Value = null;
                f4.dataGridView1[200, 23].Value = null;
                f4.dataGridView1[200, 24].Value = null;
                f4.dataGridView1[200, 25].Value = null;
                f4.dataGridView1[200, 26].Value = null;
                f4.dataGridView1[200, 27].Value = null;
                f4.dataGridView1[200, 28].Value = null;
                f4.dataGridView1[200, 29].Value = null;
                f4.dataGridView1[200, 30].Value = null;
                f4.dataGridView1[200, 31].Value = null;
                f4.dataGridView1[200, 32].Value = null;
                f4.dataGridView1[200, 33].Value = null;
                f4.dataGridView1[200, 34].Value = null;
                f4.dataGridView1[200, 35].Value = null;
                f4.dataGridView1[200, 36].Value = null;
                f4.dataGridView1[200, 37].Value = null;
                f4.dataGridView1[200, 38].Value = null;
                f4.dataGridView1[200, 39].Value = null;
                f4.dataGridView1[200, 40].Value = null;
                f4.dataGridView1[200, 41].Value = null;
                f4.dataGridView1[200, 42].Value = null;
                f4.dataGridView1[200, 43].Value = null;
                f4.dataGridView1[200, 44].Value = null;
                f4.dataGridView1[200, 45].Value = null;
                f4.dataGridView1[200, 46].Value = null;
                f4.dataGridView1[200, 47].Value = null;
                f4.dataGridView1[200, 48].Value = null;
                f4.dataGridView1[200, 49].Value = null;
                f4.dataGridView1[200, 50].Value = null;


            }

            //DESACTIVAR 200, 2 EN ADELANTE HASTA 50
            if (f4.dataGridView1[1, 2].Value == null)
            {
                f4.dataGridView1[200, 2].Value = null;
                f4.dataGridView1[200, 3].Value = null;
                f4.dataGridView1[200, 4].Value = null;
                f4.dataGridView1[200, 5].Value = null;
                f4.dataGridView1[200, 6].Value = null;
                f4.dataGridView1[200, 7].Value = null;
                f4.dataGridView1[200, 8].Value = null;
                f4.dataGridView1[200, 9].Value = null;
                f4.dataGridView1[200, 10].Value = null;
                f4.dataGridView1[200, 11].Value = null;
                f4.dataGridView1[200, 12].Value = null;
                f4.dataGridView1[200, 13].Value = null;
                f4.dataGridView1[200, 14].Value = null;
                f4.dataGridView1[200, 15].Value = null;
                f4.dataGridView1[200, 16].Value = null;
                f4.dataGridView1[200, 17].Value = null;
                f4.dataGridView1[200, 18].Value = null;
                f4.dataGridView1[200, 19].Value = null;
                f4.dataGridView1[200, 20].Value = null;
                f4.dataGridView1[200, 21].Value = null;
                f4.dataGridView1[200, 22].Value = null;
                f4.dataGridView1[200, 23].Value = null;
                f4.dataGridView1[200, 24].Value = null;
                f4.dataGridView1[200, 25].Value = null;
                f4.dataGridView1[200, 26].Value = null;
                f4.dataGridView1[200, 27].Value = null;
                f4.dataGridView1[200, 28].Value = null;
                f4.dataGridView1[200, 29].Value = null;
                f4.dataGridView1[200, 30].Value = null;
                f4.dataGridView1[200, 31].Value = null;
                f4.dataGridView1[200, 32].Value = null;
                f4.dataGridView1[200, 33].Value = null;
                f4.dataGridView1[200, 34].Value = null;
                f4.dataGridView1[200, 35].Value = null;
                f4.dataGridView1[200, 36].Value = null;
                f4.dataGridView1[200, 37].Value = null;
                f4.dataGridView1[200, 38].Value = null;
                f4.dataGridView1[200, 39].Value = null;
                f4.dataGridView1[200, 40].Value = null;
                f4.dataGridView1[200, 41].Value = null;
                f4.dataGridView1[200, 42].Value = null;
                f4.dataGridView1[200, 43].Value = null;
                f4.dataGridView1[200, 44].Value = null;
                f4.dataGridView1[200, 45].Value = null;
                f4.dataGridView1[200, 46].Value = null;
                f4.dataGridView1[200, 47].Value = null;
                f4.dataGridView1[200, 48].Value = null;
                f4.dataGridView1[200, 49].Value = null;
                f4.dataGridView1[200, 50].Value = null;


            }


            /*
            foreach (DataGridViewRow col_one in this.f4.dataGridView1.Rows)
            {
                for (int i = 0; i < col_one.Cells.Count; i++)
                {
                    if (col_one.Cells[1].Value == null)
                    {
                        //col_one.ReadOnly = true;
                        col_one.Cells[1].ReadOnly = true;


                    }
                }
            }
            */


            //RI (corregir): hacer la prueba con 0,0 - 0, 1 en dgv3,tambien revisar topsis
            //this.f4.dataGridView3.Columns.Add("RTWO", "RI");

            f4.dataGridView1[201, 0].Value = f4.dataGridView1[54, 0].Value;
            f4.dataGridView1[201, 1].Value = f4.dataGridView1[59, 0].Value;
            f4.dataGridView1[201, 2].Value = f4.dataGridView1[64, 0].Value;
            f4.dataGridView1[201, 3].Value = f4.dataGridView1[69, 0].Value;
            f4.dataGridView1[201, 4].Value = f4.dataGridView1[74, 0].Value;
            f4.dataGridView1[201, 5].Value = f4.dataGridView1[79, 0].Value;
            f4.dataGridView1[201, 6].Value = f4.dataGridView1[84, 0].Value;
            f4.dataGridView1[201, 7].Value = f4.dataGridView1[89, 0].Value;
            f4.dataGridView1[201, 8].Value = f4.dataGridView1[94, 0].Value;
            f4.dataGridView1[201, 9].Value = f4.dataGridView1[99, 0].Value;
            f4.dataGridView1[201, 10].Value = f4.dataGridView1[104, 0].Value;
            f4.dataGridView1[201, 10].Value = f4.dataGridView1[109, 0].Value;
            f4.dataGridView1[201, 10].Value = f4.dataGridView1[114, 0].Value;
            f4.dataGridView1[201, 10].Value = f4.dataGridView1[119, 0].Value;
            f4.dataGridView1[201, 10].Value = f4.dataGridView1[124, 0].Value;

            //RI, A2, 202

            f4.dataGridView1[202, 0].Value = f4.dataGridView1[54, 1].Value;
            f4.dataGridView1[202, 1].Value = f4.dataGridView1[59, 1].Value;
            f4.dataGridView1[202, 2].Value = f4.dataGridView1[64, 1].Value;
            f4.dataGridView1[202, 3].Value = f4.dataGridView1[69, 1].Value;
            f4.dataGridView1[202, 4].Value = f4.dataGridView1[74, 1].Value;
            f4.dataGridView1[202, 5].Value = f4.dataGridView1[79, 1].Value;
            f4.dataGridView1[202, 6].Value = f4.dataGridView1[84, 1].Value;
            f4.dataGridView1[202, 7].Value = f4.dataGridView1[89, 1].Value;
            f4.dataGridView1[202, 8].Value = f4.dataGridView1[94, 1].Value;
            f4.dataGridView1[202, 9].Value = f4.dataGridView1[99, 1].Value;
            f4.dataGridView1[202, 10].Value = f4.dataGridView1[104, 1].Value;
            f4.dataGridView1[202, 10].Value = f4.dataGridView1[109, 1].Value;
            f4.dataGridView1[202, 10].Value = f4.dataGridView1[114, 1].Value;
            f4.dataGridView1[202, 10].Value = f4.dataGridView1[119, 1].Value;
            f4.dataGridView1[202, 10].Value = f4.dataGridView1[124, 1].Value;

            //RI, A3, 203

            f4.dataGridView1[203, 0].Value = f4.dataGridView1[54, 2].Value;
            f4.dataGridView1[203, 1].Value = f4.dataGridView1[59, 2].Value;
            f4.dataGridView1[203, 2].Value = f4.dataGridView1[64, 2].Value;
            f4.dataGridView1[203, 3].Value = f4.dataGridView1[69, 2].Value;
            f4.dataGridView1[203, 4].Value = f4.dataGridView1[74, 2].Value;
            f4.dataGridView1[203, 5].Value = f4.dataGridView1[79, 2].Value;
            f4.dataGridView1[203, 6].Value = f4.dataGridView1[84, 2].Value;
            f4.dataGridView1[203, 7].Value = f4.dataGridView1[89, 2].Value;
            f4.dataGridView1[203, 8].Value = f4.dataGridView1[94, 2].Value;
            f4.dataGridView1[203, 9].Value = f4.dataGridView1[99, 2].Value;
            f4.dataGridView1[203, 10].Value = f4.dataGridView1[104, 2].Value;
            f4.dataGridView1[203, 10].Value = f4.dataGridView1[109, 2].Value;
            f4.dataGridView1[203, 10].Value = f4.dataGridView1[114, 2].Value;
            f4.dataGridView1[203, 10].Value = f4.dataGridView1[119, 2].Value;
            f4.dataGridView1[203, 10].Value = f4.dataGridView1[124, 2].Value;

            //RI, A4, 204

            f4.dataGridView1[204, 0].Value = f4.dataGridView1[54, 3].Value;
            f4.dataGridView1[204, 1].Value = f4.dataGridView1[59, 3].Value;
            f4.dataGridView1[204, 2].Value = f4.dataGridView1[64, 3].Value;
            f4.dataGridView1[204, 3].Value = f4.dataGridView1[69, 3].Value;
            f4.dataGridView1[204, 4].Value = f4.dataGridView1[74, 3].Value;
            f4.dataGridView1[204, 5].Value = f4.dataGridView1[79, 3].Value;
            f4.dataGridView1[204, 6].Value = f4.dataGridView1[84, 3].Value;
            f4.dataGridView1[204, 7].Value = f4.dataGridView1[89, 3].Value;
            f4.dataGridView1[204, 8].Value = f4.dataGridView1[94, 3].Value;
            f4.dataGridView1[204, 9].Value = f4.dataGridView1[99, 3].Value;
            f4.dataGridView1[204, 10].Value = f4.dataGridView1[104, 3].Value;
            f4.dataGridView1[204, 10].Value = f4.dataGridView1[109, 3].Value;
            f4.dataGridView1[204, 10].Value = f4.dataGridView1[114, 3].Value;
            f4.dataGridView1[204, 10].Value = f4.dataGridView1[119, 3].Value;
            f4.dataGridView1[204, 10].Value = f4.dataGridView1[124, 3].Value;

            //RI, A5, 205

            f4.dataGridView1[205, 0].Value = f4.dataGridView1[54, 4].Value;
            f4.dataGridView1[205, 1].Value = f4.dataGridView1[59, 4].Value;
            f4.dataGridView1[205, 2].Value = f4.dataGridView1[64, 4].Value;
            f4.dataGridView1[205, 3].Value = f4.dataGridView1[69, 4].Value;
            f4.dataGridView1[205, 4].Value = f4.dataGridView1[74, 4].Value;
            f4.dataGridView1[205, 5].Value = f4.dataGridView1[79, 4].Value;
            f4.dataGridView1[205, 6].Value = f4.dataGridView1[84, 4].Value;
            f4.dataGridView1[205, 7].Value = f4.dataGridView1[89, 4].Value;
            f4.dataGridView1[205, 8].Value = f4.dataGridView1[94, 4].Value;
            f4.dataGridView1[205, 9].Value = f4.dataGridView1[99, 4].Value;
            f4.dataGridView1[205, 10].Value = f4.dataGridView1[104, 4].Value;
            f4.dataGridView1[205, 10].Value = f4.dataGridView1[109, 4].Value;
            f4.dataGridView1[205, 10].Value = f4.dataGridView1[114, 4].Value;
            f4.dataGridView1[205, 10].Value = f4.dataGridView1[119, 4].Value;
            f4.dataGridView1[205, 10].Value = f4.dataGridView1[124, 4].Value;

            //RI, A6, 206
            f4.dataGridView1[206, 0].Value = f4.dataGridView1[54, 5].Value;
            f4.dataGridView1[206, 1].Value = f4.dataGridView1[59, 5].Value;
            f4.dataGridView1[206, 2].Value = f4.dataGridView1[64, 5].Value;
            f4.dataGridView1[206, 3].Value = f4.dataGridView1[69, 5].Value;
            f4.dataGridView1[206, 4].Value = f4.dataGridView1[74, 5].Value;
            f4.dataGridView1[206, 5].Value = f4.dataGridView1[79, 5].Value;
            f4.dataGridView1[206, 6].Value = f4.dataGridView1[84, 5].Value;
            f4.dataGridView1[206, 7].Value = f4.dataGridView1[89, 5].Value;
            f4.dataGridView1[206, 8].Value = f4.dataGridView1[94, 5].Value;
            f4.dataGridView1[206, 9].Value = f4.dataGridView1[99, 5].Value;
            f4.dataGridView1[206, 10].Value = f4.dataGridView1[104, 5].Value;
            f4.dataGridView1[206, 10].Value = f4.dataGridView1[109, 5].Value;
            f4.dataGridView1[206, 10].Value = f4.dataGridView1[114, 5].Value;
            f4.dataGridView1[206, 10].Value = f4.dataGridView1[119, 5].Value;
            f4.dataGridView1[206, 10].Value = f4.dataGridView1[124, 5].Value;

            //RI, A7, 207
            f4.dataGridView1[207, 0].Value = f4.dataGridView1[54, 6].Value;
            f4.dataGridView1[207, 1].Value = f4.dataGridView1[59, 6].Value;
            f4.dataGridView1[207, 2].Value = f4.dataGridView1[64, 6].Value;
            f4.dataGridView1[207, 3].Value = f4.dataGridView1[69, 6].Value;
            f4.dataGridView1[207, 4].Value = f4.dataGridView1[74, 6].Value;
            f4.dataGridView1[207, 5].Value = f4.dataGridView1[79, 6].Value;
            f4.dataGridView1[207, 6].Value = f4.dataGridView1[84, 6].Value;
            f4.dataGridView1[207, 7].Value = f4.dataGridView1[89, 6].Value;
            f4.dataGridView1[207, 8].Value = f4.dataGridView1[94, 6].Value;
            f4.dataGridView1[207, 9].Value = f4.dataGridView1[99, 6].Value;
            f4.dataGridView1[207, 10].Value = f4.dataGridView1[104, 6].Value;
            f4.dataGridView1[207, 10].Value = f4.dataGridView1[109, 6].Value;
            f4.dataGridView1[207, 10].Value = f4.dataGridView1[114, 6].Value;
            f4.dataGridView1[207, 10].Value = f4.dataGridView1[119, 6].Value;
            f4.dataGridView1[207, 10].Value = f4.dataGridView1[124, 6].Value;

            //RI, A8, 208
            f4.dataGridView1[208, 0].Value = f4.dataGridView1[54, 7].Value;
            f4.dataGridView1[208, 1].Value = f4.dataGridView1[59, 7].Value;
            f4.dataGridView1[208, 2].Value = f4.dataGridView1[64, 7].Value;
            f4.dataGridView1[208, 3].Value = f4.dataGridView1[69, 7].Value;
            f4.dataGridView1[208, 4].Value = f4.dataGridView1[74, 7].Value;
            f4.dataGridView1[208, 5].Value = f4.dataGridView1[79, 7].Value;
            f4.dataGridView1[208, 6].Value = f4.dataGridView1[84, 7].Value;
            f4.dataGridView1[208, 7].Value = f4.dataGridView1[89, 7].Value;
            f4.dataGridView1[208, 8].Value = f4.dataGridView1[94, 7].Value;
            f4.dataGridView1[208, 9].Value = f4.dataGridView1[99, 7].Value;
            f4.dataGridView1[208, 10].Value = f4.dataGridView1[104, 7].Value;
            f4.dataGridView1[208, 10].Value = f4.dataGridView1[109, 7].Value;
            f4.dataGridView1[208, 10].Value = f4.dataGridView1[114, 7].Value;
            f4.dataGridView1[208, 10].Value = f4.dataGridView1[119, 7].Value;
            f4.dataGridView1[208, 10].Value = f4.dataGridView1[124, 7].Value;

            //RI, A9, 209
            f4.dataGridView1[209, 0].Value = f4.dataGridView1[54, 8].Value;
            f4.dataGridView1[209, 1].Value = f4.dataGridView1[59, 8].Value;
            f4.dataGridView1[209, 2].Value = f4.dataGridView1[64, 8].Value;
            f4.dataGridView1[209, 3].Value = f4.dataGridView1[69, 8].Value;
            f4.dataGridView1[209, 4].Value = f4.dataGridView1[74, 8].Value;
            f4.dataGridView1[209, 5].Value = f4.dataGridView1[79, 8].Value;
            f4.dataGridView1[209, 6].Value = f4.dataGridView1[84, 8].Value;
            f4.dataGridView1[209, 7].Value = f4.dataGridView1[89, 8].Value;
            f4.dataGridView1[209, 8].Value = f4.dataGridView1[94, 8].Value;
            f4.dataGridView1[209, 9].Value = f4.dataGridView1[99, 8].Value;
            f4.dataGridView1[209, 10].Value = f4.dataGridView1[104, 8].Value;
            f4.dataGridView1[209, 10].Value = f4.dataGridView1[109, 8].Value;
            f4.dataGridView1[209, 10].Value = f4.dataGridView1[114, 8].Value;
            f4.dataGridView1[209, 10].Value = f4.dataGridView1[119, 8].Value;
            f4.dataGridView1[209, 10].Value = f4.dataGridView1[124, 8].Value;

            //RI, A10, 210
            f4.dataGridView1[210, 0].Value = f4.dataGridView1[54, 9].Value;
            f4.dataGridView1[210, 1].Value = f4.dataGridView1[59, 9].Value;
            f4.dataGridView1[210, 2].Value = f4.dataGridView1[64, 9].Value;
            f4.dataGridView1[210, 3].Value = f4.dataGridView1[69, 9].Value;
            f4.dataGridView1[210, 4].Value = f4.dataGridView1[74, 9].Value;
            f4.dataGridView1[210, 5].Value = f4.dataGridView1[79, 9].Value;
            f4.dataGridView1[210, 6].Value = f4.dataGridView1[84, 9].Value;
            f4.dataGridView1[210, 7].Value = f4.dataGridView1[89, 9].Value;
            f4.dataGridView1[210, 8].Value = f4.dataGridView1[94, 9].Value;
            f4.dataGridView1[210, 9].Value = f4.dataGridView1[99, 9].Value;
            f4.dataGridView1[210, 10].Value = f4.dataGridView1[104, 9].Value;
            f4.dataGridView1[210, 10].Value = f4.dataGridView1[109, 9].Value;
            f4.dataGridView1[210, 10].Value = f4.dataGridView1[114, 9].Value;
            f4.dataGridView1[210, 10].Value = f4.dataGridView1[119, 9].Value;
            f4.dataGridView1[210, 10].Value = f4.dataGridView1[124, 9].Value;

            //RI, A11, 211

            f4.dataGridView1[211, 0].Value = f4.dataGridView1[54, 10].Value;
            f4.dataGridView1[211, 1].Value = f4.dataGridView1[59, 10].Value;
            f4.dataGridView1[211, 2].Value = f4.dataGridView1[64, 10].Value;
            f4.dataGridView1[211, 3].Value = f4.dataGridView1[69, 10].Value;
            f4.dataGridView1[211, 4].Value = f4.dataGridView1[74, 10].Value;
            f4.dataGridView1[211, 5].Value = f4.dataGridView1[79, 10].Value;
            f4.dataGridView1[211, 6].Value = f4.dataGridView1[84, 10].Value;
            f4.dataGridView1[211, 7].Value = f4.dataGridView1[89, 10].Value;
            f4.dataGridView1[211, 8].Value = f4.dataGridView1[94, 10].Value;
            f4.dataGridView1[211, 9].Value = f4.dataGridView1[99, 10].Value;
            f4.dataGridView1[211, 10].Value = f4.dataGridView1[104, 10].Value;
            f4.dataGridView1[211, 10].Value = f4.dataGridView1[109, 10].Value;
            f4.dataGridView1[211, 10].Value = f4.dataGridView1[114, 10].Value;
            f4.dataGridView1[211, 10].Value = f4.dataGridView1[119, 10].Value;
            f4.dataGridView1[211, 10].Value = f4.dataGridView1[124, 10].Value;

            //RI, A12, 212

            f4.dataGridView1[212, 0].Value = f4.dataGridView1[54, 11].Value;
            f4.dataGridView1[212, 1].Value = f4.dataGridView1[59, 11].Value;
            f4.dataGridView1[212, 2].Value = f4.dataGridView1[64, 11].Value;
            f4.dataGridView1[212, 3].Value = f4.dataGridView1[69, 11].Value;
            f4.dataGridView1[212, 4].Value = f4.dataGridView1[74, 11].Value;
            f4.dataGridView1[212, 5].Value = f4.dataGridView1[79, 11].Value;
            f4.dataGridView1[212, 6].Value = f4.dataGridView1[84, 11].Value;
            f4.dataGridView1[212, 7].Value = f4.dataGridView1[89, 11].Value;
            f4.dataGridView1[212, 8].Value = f4.dataGridView1[94, 11].Value;
            f4.dataGridView1[212, 9].Value = f4.dataGridView1[99, 11].Value;
            f4.dataGridView1[212, 10].Value = f4.dataGridView1[104, 11].Value;
            f4.dataGridView1[212, 10].Value = f4.dataGridView1[109, 11].Value;
            f4.dataGridView1[212, 10].Value = f4.dataGridView1[114, 11].Value;
            f4.dataGridView1[212, 10].Value = f4.dataGridView1[119, 11].Value;
            f4.dataGridView1[212, 10].Value = f4.dataGridView1[124, 11].Value;

            //R1, A13, 213
            f4.dataGridView1[213, 0].Value = f4.dataGridView1[54, 12].Value;
            f4.dataGridView1[213, 1].Value = f4.dataGridView1[59, 12].Value;
            f4.dataGridView1[213, 2].Value = f4.dataGridView1[64, 12].Value;
            f4.dataGridView1[213, 3].Value = f4.dataGridView1[69, 12].Value;
            f4.dataGridView1[213, 4].Value = f4.dataGridView1[74, 12].Value;
            f4.dataGridView1[213, 5].Value = f4.dataGridView1[79, 12].Value;
            f4.dataGridView1[213, 6].Value = f4.dataGridView1[84, 12].Value;
            f4.dataGridView1[213, 7].Value = f4.dataGridView1[89, 12].Value;
            f4.dataGridView1[213, 8].Value = f4.dataGridView1[94, 12].Value;
            f4.dataGridView1[213, 9].Value = f4.dataGridView1[99, 12].Value;
            f4.dataGridView1[213, 10].Value = f4.dataGridView1[104, 12].Value;
            f4.dataGridView1[213, 10].Value = f4.dataGridView1[109, 12].Value;
            f4.dataGridView1[213, 10].Value = f4.dataGridView1[114, 12].Value;
            f4.dataGridView1[213, 10].Value = f4.dataGridView1[119, 12].Value;
            f4.dataGridView1[213, 10].Value = f4.dataGridView1[124, 12].Value;

            //R1, A14, 214

            f4.dataGridView1[214, 0].Value = f4.dataGridView1[54, 13].Value;
            f4.dataGridView1[214, 1].Value = f4.dataGridView1[59, 13].Value;
            f4.dataGridView1[214, 2].Value = f4.dataGridView1[64, 13].Value;
            f4.dataGridView1[214, 3].Value = f4.dataGridView1[69, 13].Value;
            f4.dataGridView1[214, 4].Value = f4.dataGridView1[74, 13].Value;
            f4.dataGridView1[214, 5].Value = f4.dataGridView1[79, 13].Value;
            f4.dataGridView1[214, 6].Value = f4.dataGridView1[84, 13].Value;
            f4.dataGridView1[214, 7].Value = f4.dataGridView1[89, 13].Value;
            f4.dataGridView1[214, 8].Value = f4.dataGridView1[94, 13].Value;
            f4.dataGridView1[214, 9].Value = f4.dataGridView1[99, 13].Value;
            f4.dataGridView1[214, 10].Value = f4.dataGridView1[104, 13].Value;
            f4.dataGridView1[214, 10].Value = f4.dataGridView1[109, 13].Value;
            f4.dataGridView1[214, 10].Value = f4.dataGridView1[114, 13].Value;
            f4.dataGridView1[214, 10].Value = f4.dataGridView1[119, 13].Value;
            f4.dataGridView1[214, 10].Value = f4.dataGridView1[124, 13].Value;

            //RI, A15, 215
            f4.dataGridView1[215, 0].Value = f4.dataGridView1[54, 14].Value;
            f4.dataGridView1[215, 1].Value = f4.dataGridView1[59, 14].Value;
            f4.dataGridView1[215, 2].Value = f4.dataGridView1[64, 14].Value;
            f4.dataGridView1[215, 3].Value = f4.dataGridView1[69, 14].Value;
            f4.dataGridView1[215, 4].Value = f4.dataGridView1[74, 14].Value;
            f4.dataGridView1[215, 5].Value = f4.dataGridView1[79, 14].Value;
            f4.dataGridView1[215, 6].Value = f4.dataGridView1[84, 14].Value;
            f4.dataGridView1[215, 7].Value = f4.dataGridView1[89, 14].Value;
            f4.dataGridView1[215, 8].Value = f4.dataGridView1[94, 14].Value;
            f4.dataGridView1[215, 9].Value = f4.dataGridView1[99, 14].Value;
            f4.dataGridView1[215, 10].Value = f4.dataGridView1[104, 14].Value;
            f4.dataGridView1[215, 10].Value = f4.dataGridView1[109, 14].Value;
            f4.dataGridView1[215, 10].Value = f4.dataGridView1[114, 14].Value;
            f4.dataGridView1[215, 10].Value = f4.dataGridView1[119, 14].Value;
            f4.dataGridView1[215, 10].Value = f4.dataGridView1[124, 14].Value;

            //A1 FINAL
            double[] a_1 = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[201].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[201].FormattedValue)).ToArray();

            double alt_1 = a_1.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 0].Value = alt_1;

            //A2 FINAL
            double[] a_2 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[202].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[202].FormattedValue)).ToArray();

            double alt_2 = a_2.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 1].Value = alt_2;

            //A3 FINAL

            double[] a_3 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[203].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[203].FormattedValue)).ToArray();

            double alt_3 = a_3.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 2].Value = alt_3;

            //A4 FINAL
            double[] a_4 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[204].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[204].FormattedValue)).ToArray();

            double alt_4 = a_4.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 3].Value = alt_4;

            //A5 FINAL
            double[] a_5 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[205].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[205].FormattedValue)).ToArray();

            double alt_5 = a_5.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 4].Value = alt_5;

            //A6 FINAL
            double[] a_6 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[206].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[206].FormattedValue)).ToArray();

            double alt_6 = a_6.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 5].Value = alt_6;

            //A7 FINAL
            double[] a_7 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[207].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[207].FormattedValue)).ToArray();

            double alt_7 = a_7.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 6].Value = alt_7;

            //A8 FINAL
            double[] a_8 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[208].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[208].FormattedValue)).ToArray();

            double alt_8 = a_8.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 7].Value = alt_8;

            //A9 FINAL
            double[] a_9 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[209].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[209].FormattedValue)).ToArray();

            double alt_9 = a_9.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 8].Value = alt_9;

            //A10 FINAL
            double[] a_10 = (from DataGridViewRow row in f4.dataGridView1.Rows
                            where row.Cells[210].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[210].FormattedValue)).ToArray();

            double alt_10 = a_10.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 9].Value = alt_10;

            //A11 FINAL
            double[] a_11 = (from DataGridViewRow row in f4.dataGridView1.Rows
                             where row.Cells[211].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[211].FormattedValue)).ToArray();

            double alt_11 = a_11.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 10].Value = alt_11;

            //A12 FINAL
            double[] a_12 = (from DataGridViewRow row in f4.dataGridView1.Rows
                             where row.Cells[212].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[212].FormattedValue)).ToArray();

            double alt_12 = a_12.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 11].Value = alt_12;

            //A13 FINAL
            double[] a_13 = (from DataGridViewRow row in f4.dataGridView1.Rows
                             where row.Cells[213].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[213].FormattedValue)).ToArray();

            double alt_13 = a_13.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 12].Value = alt_13;

            //A14 FINAL
            double[] a_14 = (from DataGridViewRow row in f4.dataGridView1.Rows
                             where row.Cells[214].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[214].FormattedValue)).ToArray();

            double alt_14 = a_14.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 13].Value = alt_14;

            //A15 FINAL
            double[] a_15 = (from DataGridViewRow row in f4.dataGridView1.Rows
                             where row.Cells[215].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[215].FormattedValue)).ToArray();

            double alt_15 = a_15.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)

            f4.dataGridView1[231, 14].Value = alt_15;

            //DESACTIVAR 231, 5 EN ADELANTE HASTA 15
            if (f4.dataGridView1[1, 5].Value == null)
            {
                f4.dataGridView1[231, 5].Value = null;
                f4.dataGridView1[231, 6].Value = null;
                f4.dataGridView1[231, 7].Value = null;
                f4.dataGridView1[231, 8].Value = null;
                f4.dataGridView1[231, 9].Value = null;
                f4.dataGridView1[231, 10].Value = null;
                f4.dataGridView1[231, 11].Value = null;
                f4.dataGridView1[231, 12].Value = null;
                f4.dataGridView1[231, 13].Value = null;
                f4.dataGridView1[231, 14].Value = null;
                f4.dataGridView1[231, 15].Value = null;
            }

            //DESACTIVAR 231, 4 EN ADELANTE HASTA 15
            if (f4.dataGridView1[1, 4].Value == null)
            {
                f4.dataGridView1[231, 4].Value = null;
                f4.dataGridView1[231, 5].Value = null;
                f4.dataGridView1[231, 6].Value = null;
                f4.dataGridView1[231, 7].Value = null;
                f4.dataGridView1[231, 8].Value = null;
                f4.dataGridView1[231, 9].Value = null;
                f4.dataGridView1[231, 10].Value = null;
                f4.dataGridView1[231, 11].Value = null;
                f4.dataGridView1[231, 12].Value = null;
                f4.dataGridView1[231, 13].Value = null;
                f4.dataGridView1[231, 14].Value = null;
                f4.dataGridView1[231, 15].Value = null;
            }

            //DESACTIVAR 231, 3 EN ADELANTE HASTA 15
            if (f4.dataGridView1[1, 3].Value == null)
            {
                f4.dataGridView1[231, 3].Value = null;
                f4.dataGridView1[231, 4].Value = null;
                f4.dataGridView1[231, 5].Value = null;
                f4.dataGridView1[231, 6].Value = null;
                f4.dataGridView1[231, 7].Value = null;
                f4.dataGridView1[231, 8].Value = null;
                f4.dataGridView1[231, 9].Value = null;
                f4.dataGridView1[231, 10].Value = null;
                f4.dataGridView1[231, 11].Value = null;
                f4.dataGridView1[231, 12].Value = null;
                f4.dataGridView1[231, 13].Value = null;
                f4.dataGridView1[231, 14].Value = null;
                f4.dataGridView1[231, 15].Value = null;
            }

            //DESACTIVAR 231, 2 EN ADELANTE HASTA 15
            if (f4.dataGridView1[1, 2].Value == null)
            {
                f4.dataGridView1[231, 2].Value = null;
                f4.dataGridView1[231, 3].Value = null;
                f4.dataGridView1[231, 4].Value = null;
                f4.dataGridView1[231, 5].Value = null;
                f4.dataGridView1[231, 6].Value = null;
                f4.dataGridView1[231, 7].Value = null;
                f4.dataGridView1[231, 8].Value = null;
                f4.dataGridView1[231, 9].Value = null;
                f4.dataGridView1[231, 10].Value = null;
                f4.dataGridView1[231, 11].Value = null;
                f4.dataGridView1[231, 12].Value = null;
                f4.dataGridView1[231, 13].Value = null;
                f4.dataGridView1[231, 14].Value = null;
                f4.dataGridView1[231, 15].Value = null;
            }



            //RI MIN = 233
            double[] RI_MIN = (from DataGridViewRow row in f4.dataGridView1.Rows
                                   where row.Cells[231].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[231].FormattedValue)).ToArray();

            double rimin = RI_MIN.Min();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


            foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                row.Cells[233].Value = rimin;

            //RI MAX = 233
            double[] RI_MAX = (from DataGridViewRow row in f4.dataGridView1.Rows
                               where row.Cells[231].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(row.Cells[231].FormattedValue)).ToArray();

            double rimax = RI_MAX.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


            foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                row.Cells[234].Value = rimax;


            //SI MIN = 200
            double[] SI_MIN = (from DataGridViewRow row in f4.dataGridView1.Rows
                               where row.Cells[200].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(row.Cells[200].FormattedValue)).ToArray();

            double simin = SI_MIN.Min();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


            foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                row.Cells[235].Value = simin;


            //SI MAX = 200
            double[] SI_MAX = (from DataGridViewRow row in f4.dataGridView1.Rows
                               where row.Cells[200].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(row.Cells[200].FormattedValue)).ToArray();

            double simax = SI_MAX.Max();
            //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


            foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                row.Cells[236].Value = simax;

            

            //declarar double la textbox
            double value_vikor = Convert.ToDouble(textBox1.Text);

            //SACAR EL VALOR DE QI (C238)

            foreach (DataGridViewRow row in f4.dataGridView1.Rows)

                //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                row.Cells[238].Value = value_vikor * ((Convert.ToDouble(row.Cells[200].Value) - Convert.ToDouble(row.Cells[235].Value)) / (Convert.ToDouble(row.Cells[236].Value) - Convert.ToDouble(row.Cells[235].Value))) + (1 - value_vikor) * ((Convert.ToDouble(row.Cells[231].Value) - Convert.ToDouble(row.Cells[233].Value)) / (Convert.ToDouble(row.Cells[234].Value) - Convert.ToDouble(row.Cells[233].Value)));

            //BORRAR VALORES QUE NO SIRVEN DE QI

            //DESACTIVAR 200, 5 EN ADELANTE HASTA 50
            if (f4.dataGridView1[1, 5].Value == null)
            {
                f4.dataGridView1[238, 5].Value = null;
                f4.dataGridView1[238, 6].Value = null;
                f4.dataGridView1[238, 7].Value = null;
                f4.dataGridView1[238, 8].Value = null;
                f4.dataGridView1[238, 9].Value = null;
                f4.dataGridView1[238, 10].Value = null;
                f4.dataGridView1[238, 11].Value = null;
                f4.dataGridView1[238, 12].Value = null;
                f4.dataGridView1[238, 13].Value = null;
                f4.dataGridView1[238, 14].Value = null;
                f4.dataGridView1[238, 15].Value = null;
                f4.dataGridView1[238, 16].Value = null;
                f4.dataGridView1[238, 17].Value = null;
                f4.dataGridView1[238, 18].Value = null;
                f4.dataGridView1[238, 19].Value = null;
                f4.dataGridView1[238, 20].Value = null;
                f4.dataGridView1[238, 21].Value = null;
                f4.dataGridView1[238, 22].Value = null;
                f4.dataGridView1[238, 23].Value = null;
                f4.dataGridView1[238, 24].Value = null;
                f4.dataGridView1[238, 25].Value = null;
                f4.dataGridView1[238, 26].Value = null;
                f4.dataGridView1[238, 27].Value = null;
                f4.dataGridView1[238, 28].Value = null;
                f4.dataGridView1[238, 29].Value = null;
                f4.dataGridView1[238, 30].Value = null;
                f4.dataGridView1[238, 31].Value = null;
                f4.dataGridView1[238, 32].Value = null;
                f4.dataGridView1[238, 33].Value = null;
                f4.dataGridView1[238, 34].Value = null;
                f4.dataGridView1[238, 35].Value = null;
                f4.dataGridView1[238, 36].Value = null;
                f4.dataGridView1[238, 37].Value = null;
                f4.dataGridView1[238, 38].Value = null;
                f4.dataGridView1[238, 39].Value = null;
                f4.dataGridView1[238, 40].Value = null;
                f4.dataGridView1[238, 41].Value = null;
                f4.dataGridView1[238, 42].Value = null;
                f4.dataGridView1[238, 43].Value = null;
                f4.dataGridView1[238, 44].Value = null;
                f4.dataGridView1[238, 45].Value = null;
                f4.dataGridView1[238, 46].Value = null;
                f4.dataGridView1[238, 47].Value = null;
                f4.dataGridView1[238, 48].Value = null;
                f4.dataGridView1[238, 49].Value = null;
                f4.dataGridView1[238, 50].Value = null;


            }

            //DESACTIVAR 238, 4 EN ADELANTE HASTA 50
            if (f4.dataGridView1[1, 4].Value == null)
            {
                f4.dataGridView1[238, 4].Value = null;
                f4.dataGridView1[238, 5].Value = null;
                f4.dataGridView1[238, 6].Value = null;
                f4.dataGridView1[238, 7].Value = null;
                f4.dataGridView1[238, 8].Value = null;
                f4.dataGridView1[238, 9].Value = null;
                f4.dataGridView1[238, 10].Value = null;
                f4.dataGridView1[238, 11].Value = null;
                f4.dataGridView1[238, 12].Value = null;
                f4.dataGridView1[238, 13].Value = null;
                f4.dataGridView1[238, 14].Value = null;
                f4.dataGridView1[238, 15].Value = null;
                f4.dataGridView1[238, 16].Value = null;
                f4.dataGridView1[238, 17].Value = null;
                f4.dataGridView1[238, 18].Value = null;
                f4.dataGridView1[238, 19].Value = null;
                f4.dataGridView1[238, 20].Value = null;
                f4.dataGridView1[238, 21].Value = null;
                f4.dataGridView1[238, 22].Value = null;
                f4.dataGridView1[238, 23].Value = null;
                f4.dataGridView1[238, 24].Value = null;
                f4.dataGridView1[238, 25].Value = null;
                f4.dataGridView1[238, 26].Value = null;
                f4.dataGridView1[238, 27].Value = null;
                f4.dataGridView1[238, 28].Value = null;
                f4.dataGridView1[238, 29].Value = null;
                f4.dataGridView1[238, 30].Value = null;
                f4.dataGridView1[238, 31].Value = null;
                f4.dataGridView1[238, 32].Value = null;
                f4.dataGridView1[238, 33].Value = null;
                f4.dataGridView1[238, 34].Value = null;
                f4.dataGridView1[238, 35].Value = null;
                f4.dataGridView1[238, 36].Value = null;
                f4.dataGridView1[238, 37].Value = null;
                f4.dataGridView1[238, 38].Value = null;
                f4.dataGridView1[238, 39].Value = null;
                f4.dataGridView1[238, 40].Value = null;
                f4.dataGridView1[238, 41].Value = null;
                f4.dataGridView1[238, 42].Value = null;
                f4.dataGridView1[238, 43].Value = null;
                f4.dataGridView1[238, 44].Value = null;
                f4.dataGridView1[238, 45].Value = null;
                f4.dataGridView1[238, 46].Value = null;
                f4.dataGridView1[238, 47].Value = null;
                f4.dataGridView1[238, 48].Value = null;
                f4.dataGridView1[238, 49].Value = null;
                f4.dataGridView1[238, 50].Value = null;


            }

            //DESACTIVAR 238, 3 EN ADELANTE HASTA 50
            if (f4.dataGridView1[1, 3].Value == null)
            {
                f4.dataGridView1[238, 3].Value = null;
                f4.dataGridView1[238, 4].Value = null;
                f4.dataGridView1[238, 5].Value = null;
                f4.dataGridView1[238, 6].Value = null;
                f4.dataGridView1[238, 7].Value = null;
                f4.dataGridView1[238, 8].Value = null;
                f4.dataGridView1[238, 9].Value = null;
                f4.dataGridView1[238, 10].Value = null;
                f4.dataGridView1[238, 11].Value = null;
                f4.dataGridView1[238, 12].Value = null;
                f4.dataGridView1[238, 13].Value = null;
                f4.dataGridView1[238, 14].Value = null;
                f4.dataGridView1[238, 15].Value = null;
                f4.dataGridView1[238, 16].Value = null;
                f4.dataGridView1[238, 17].Value = null;
                f4.dataGridView1[238, 18].Value = null;
                f4.dataGridView1[238, 19].Value = null;
                f4.dataGridView1[238, 20].Value = null;
                f4.dataGridView1[238, 21].Value = null;
                f4.dataGridView1[238, 22].Value = null;
                f4.dataGridView1[238, 23].Value = null;
                f4.dataGridView1[238, 24].Value = null;
                f4.dataGridView1[238, 25].Value = null;
                f4.dataGridView1[238, 26].Value = null;
                f4.dataGridView1[238, 27].Value = null;
                f4.dataGridView1[238, 28].Value = null;
                f4.dataGridView1[238, 29].Value = null;
                f4.dataGridView1[238, 30].Value = null;
                f4.dataGridView1[238, 31].Value = null;
                f4.dataGridView1[238, 32].Value = null;
                f4.dataGridView1[238, 33].Value = null;
                f4.dataGridView1[238, 34].Value = null;
                f4.dataGridView1[238, 35].Value = null;
                f4.dataGridView1[238, 36].Value = null;
                f4.dataGridView1[238, 37].Value = null;
                f4.dataGridView1[238, 38].Value = null;
                f4.dataGridView1[238, 39].Value = null;
                f4.dataGridView1[238, 40].Value = null;
                f4.dataGridView1[238, 41].Value = null;
                f4.dataGridView1[238, 42].Value = null;
                f4.dataGridView1[238, 43].Value = null;
                f4.dataGridView1[238, 44].Value = null;
                f4.dataGridView1[238, 45].Value = null;
                f4.dataGridView1[238, 46].Value = null;
                f4.dataGridView1[238, 47].Value = null;
                f4.dataGridView1[238, 48].Value = null;
                f4.dataGridView1[238, 49].Value = null;
                f4.dataGridView1[238, 50].Value = null;


            }

            //DESACTIVAR 238, 2 EN ADELANTE HASTA 50
            if (f4.dataGridView1[1, 2].Value == null)
            {
                f4.dataGridView1[238, 2].Value = null;
                f4.dataGridView1[238, 3].Value = null;
                f4.dataGridView1[238, 4].Value = null;
                f4.dataGridView1[238, 5].Value = null;
                f4.dataGridView1[238, 6].Value = null;
                f4.dataGridView1[238, 7].Value = null;
                f4.dataGridView1[238, 8].Value = null;
                f4.dataGridView1[238, 9].Value = null;
                f4.dataGridView1[238, 10].Value = null;
                f4.dataGridView1[238, 11].Value = null;
                f4.dataGridView1[238, 12].Value = null;
                f4.dataGridView1[238, 13].Value = null;
                f4.dataGridView1[238, 14].Value = null;
                f4.dataGridView1[238, 15].Value = null;
                f4.dataGridView1[238, 16].Value = null;
                f4.dataGridView1[238, 17].Value = null;
                f4.dataGridView1[238, 18].Value = null;
                f4.dataGridView1[238, 19].Value = null;
                f4.dataGridView1[238, 20].Value = null;
                f4.dataGridView1[238, 21].Value = null;
                f4.dataGridView1[238, 22].Value = null;
                f4.dataGridView1[238, 23].Value = null;
                f4.dataGridView1[238, 24].Value = null;
                f4.dataGridView1[238, 25].Value = null;
                f4.dataGridView1[238, 26].Value = null;
                f4.dataGridView1[238, 27].Value = null;
                f4.dataGridView1[238, 28].Value = null;
                f4.dataGridView1[238, 29].Value = null;
                f4.dataGridView1[238, 30].Value = null;
                f4.dataGridView1[238, 31].Value = null;
                f4.dataGridView1[238, 32].Value = null;
                f4.dataGridView1[238, 33].Value = null;
                f4.dataGridView1[238, 34].Value = null;
                f4.dataGridView1[238, 35].Value = null;
                f4.dataGridView1[238, 36].Value = null;
                f4.dataGridView1[238, 37].Value = null;
                f4.dataGridView1[238, 38].Value = null;
                f4.dataGridView1[238, 39].Value = null;
                f4.dataGridView1[238, 40].Value = null;
                f4.dataGridView1[238, 41].Value = null;
                f4.dataGridView1[238, 42].Value = null;
                f4.dataGridView1[238, 43].Value = null;
                f4.dataGridView1[238, 44].Value = null;
                f4.dataGridView1[238, 45].Value = null;
                f4.dataGridView1[238, 46].Value = null;
                f4.dataGridView1[238, 47].Value = null;
                f4.dataGridView1[238, 48].Value = null;
                f4.dataGridView1[238, 49].Value = null;
                f4.dataGridView1[238, 50].Value = null;


            }

            //PASAR VALORES A LA SIGUIENTE MATRIZ DE SALIDA
            ////////////////////////////////////////////////
            f4.dataGridView3.Columns[0].HeaderText = "SI";
            foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                f4.dataGridView3.Rows.Add(row.Cells[200].Value);


            foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                f4.dataGridView3.Rows.Add(row.Cells[231].Value);



            this.f4.dataGridView3.Columns.Add("RTWO", "RI");

            f4.dataGridView3[1, 0].Value = f4.dataGridView1[231, 0].Value;
            f4.dataGridView3[1, 1].Value = f4.dataGridView1[231, 1].Value;
            f4.dataGridView3[1, 2].Value = f4.dataGridView1[231, 2].Value;
            f4.dataGridView3[1, 3].Value = f4.dataGridView1[231, 3].Value;
            f4.dataGridView3[1, 4].Value = f4.dataGridView1[231, 4].Value;
            f4.dataGridView3[1, 5].Value = f4.dataGridView1[231, 5].Value;
            f4.dataGridView3[1, 6].Value = f4.dataGridView1[231, 6].Value;
            f4.dataGridView3[1, 7].Value = f4.dataGridView1[231, 7].Value;
            f4.dataGridView3[1, 8].Value = f4.dataGridView1[231, 8].Value;
            f4.dataGridView3[1, 9].Value = f4.dataGridView1[231, 9].Value;
            f4.dataGridView3[1, 10].Value = f4.dataGridView1[231, 10].Value;
            f4.dataGridView3[1, 11].Value = f4.dataGridView1[231, 11].Value;
            f4.dataGridView3[1, 12].Value = f4.dataGridView1[231, 12].Value;
            f4.dataGridView3[1, 13].Value = f4.dataGridView1[231, 13].Value;
            f4.dataGridView3[1, 14].Value = f4.dataGridView1[231, 14].Value;
            f4.dataGridView3[1, 15].Value = f4.dataGridView1[231, 15].Value;
            f4.dataGridView3[1, 16].Value = f4.dataGridView1[231, 16].Value;


            foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                f4.dataGridView3.Rows.Add(row.Cells[238].Value);



            this.f4.dataGridView3.Columns.Add("RTWO", "QI");

            f4.dataGridView3[2, 0].Value = f4.dataGridView1[238, 0].Value;
            f4.dataGridView3[2, 1].Value = f4.dataGridView1[238, 1].Value;
            f4.dataGridView3[2, 2].Value = f4.dataGridView1[238, 2].Value;
            f4.dataGridView3[2, 3].Value = f4.dataGridView1[238, 3].Value;
            f4.dataGridView3[2, 4].Value = f4.dataGridView1[238, 4].Value;
            f4.dataGridView3[2, 5].Value = f4.dataGridView1[238, 5].Value;
            f4.dataGridView3[2, 6].Value = f4.dataGridView1[238, 6].Value;
            f4.dataGridView3[2, 7].Value = f4.dataGridView1[238, 7].Value;
            f4.dataGridView3[2, 8].Value = f4.dataGridView1[238, 8].Value;
            f4.dataGridView3[2, 9].Value = f4.dataGridView1[238, 9].Value;
            f4.dataGridView3[2, 10].Value = f4.dataGridView1[238, 10].Value;
            f4.dataGridView3[2, 11].Value = f4.dataGridView1[238, 11].Value;
            f4.dataGridView3[2, 12].Value = f4.dataGridView1[238, 12].Value;
            f4.dataGridView3[2, 13].Value = f4.dataGridView1[238, 13].Value;
            f4.dataGridView3[2, 14].Value = f4.dataGridView1[238, 14].Value;
            f4.dataGridView3[2, 15].Value = f4.dataGridView1[238, 15].Value;
            f4.dataGridView3[2, 16].Value = f4.dataGridView1[238, 16].Value;



            foreach (DataGridViewRow row in f4.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                f4.dataGridView5.Rows.Add(row.Cells[238].Value);

            f4.label29.Visible = true;
            f4.label29.Text = "Final Results";
            f4.dataGridView5.Visible = true;
            f4.dataGridView5.Columns[0].HeaderText = "VIKOR Final Results";


            this.f4.dataGridView5.Columns.Add("RTWO", "ALTERNATIVES");//revisar bien

            f4.dataGridView5[1, 0].Value = "A1";
            f4.dataGridView5[1, 1].Value = "A2";
            f4.dataGridView5[1, 2].Value = "A3";
            f4.dataGridView5[1, 3].Value = "A4";
            f4.dataGridView5[1, 4].Value = "A5";
            f4.dataGridView5[1, 5].Value = "A6";
            f4.dataGridView5[1, 6].Value = "A7";
            f4.dataGridView5[1, 7].Value = "A8";
            f4.dataGridView5[1, 8].Value = "A9";
            f4.dataGridView5[1, 9].Value = "A10";
            f4.dataGridView5[1, 10].Value = "A11";
            f4.dataGridView5[1, 11].Value = "A12";
            f4.dataGridView5[1, 12].Value = "A13";
            f4.dataGridView5[1, 13].Value = "A14";
            f4.dataGridView5[1, 14].Value = "A15";


            //Mejor decision en dataGridview5
            double[] wpmBD = (from DataGridViewRow row in f4.dataGridView5.Rows
                              where row.Cells[0].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[0].FormattedValue)).ToArray();

            double WPMT = wpmBD.Max();

            foreach (DataGridViewRow ku in this.f4.dataGridView5.Rows)
            {
                for (int i = 0; i < ku.Cells.Count; i++)
                {
                    if (Convert.ToDouble(ku.Cells[0].Value) == WPMT)
                    {
                        //rpz.Cells[152].Value = null;
                        //rpz.DefaultCellStyle.BackColor = Color.Red;
                        ku.Cells[0].Style.BackColor = Color.AliceBlue;
                    }
                }
            }

            //VIKOR EN UNIFICADA
            f4.dataGridView10[6, 0].Value = f4.dataGridView1[238, 0].Value;
            f4.dataGridView10[6, 1].Value = f4.dataGridView1[238, 1].Value;
            f4.dataGridView10[6, 2].Value = f4.dataGridView1[238, 2].Value;
            f4.dataGridView10[6, 3].Value = f4.dataGridView1[238, 3].Value;
            f4.dataGridView10[6, 4].Value = f4.dataGridView1[238, 4].Value;
            f4.dataGridView10[6, 5].Value = f4.dataGridView1[238, 5].Value;
            f4.dataGridView10[6, 6].Value = f4.dataGridView1[238, 6].Value;
            f4.dataGridView10[6, 7].Value = f4.dataGridView1[238, 7].Value;
            f4.dataGridView10[6, 8].Value = f4.dataGridView1[238, 8].Value;
            f4.dataGridView10[6, 9].Value = f4.dataGridView1[238, 9].Value;
            f4.dataGridView10[6, 10].Value = f4.dataGridView1[238, 10].Value;
            f4.dataGridView10[6, 11].Value = f4.dataGridView1[238, 11].Value;
            f4.dataGridView10[6, 12].Value = f4.dataGridView1[238, 12].Value;
            f4.dataGridView10[6, 13].Value = f4.dataGridView1[238, 13].Value;
            f4.dataGridView10[6, 14].Value = f4.dataGridView1[238, 14].Value;
            f4.dataGridView10[6, 15].Value = f4.dataGridView1[238, 15].Value;
            f4.dataGridView10[6, 16].Value = f4.dataGridView1[238, 16].Value;


            //ELIMINAR DE DATAGRIDVIEW5 LOS 0 y NaN y los infinito
            foreach (DataGridViewRow rw in this.f4.dataGridView10.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    double infinity = double.PositiveInfinity;
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value.ToString() == "0" || rw.Cells[i].Value.ToString() == "NaN" || rw.Cells[i].Value.ToString() == "0.0000" || Convert.ToDouble(rw.Cells[i].Value) == infinity)
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }

            f4.dataGridView2.DefaultCellStyle.Format = "F4";
            f4.dataGridView3.DefaultCellStyle.Format = "F4";
            f4.dataGridView5.DefaultCellStyle.Format = "F4";
            f4.dataGridView6.DefaultCellStyle.Format = "F4";
            f4.dataGridView7.DefaultCellStyle.Format = "F4";
            f4.dataGridView8.DefaultCellStyle.Format = "F4";
            f4.dataGridView9.DefaultCellStyle.Format = "F4";
            f4.dataGridView10.DefaultCellStyle.Format = "F4";

            if (f4.dataGridView2.Visible == true)
            {
                f4.button7.Visible = true;
            }
            else
            {
                f4.button7.Visible = false;
            }

            if (f4.dataGridView3.Visible == true)
            {
                f4.button8.Visible = true;
            }
            else
            {
                f4.button8.Visible = false;
            }

            if (f4.dataGridView5.Visible == true)
            {
                f4.button9.Visible = true;
            }
            else
            {
                f4.button9.Visible = false;
            }

            if (f4.dataGridView6.Visible == true)
            {
                f4.button16.Visible = true;
            }
            else
            {
                f4.button16.Visible = false;
            }


            if (f4.dataGridView7.Visible == true)
            {
                f4.button18.Visible = true;
            }
            else
            {
                f4.button18.Visible = false;
            }


            if (f4.dataGridView8.Visible == true)
            {
                f4.button19.Visible = true;
            }
            else
            {
                f4.button19.Visible = false;
            }

            if (f4.dataGridView9.Visible == true)
            {
                f4.button20.Visible = true;
            }
            else
            {
                f4.button20.Visible = false;
            }

            if (f4.dataGridView10.Visible == true)
            {
                f4.button21.Visible = true;
            }
            else
            {
                f4.button21.Visible = false;
            }

        }

            



                        

            
    }
}
