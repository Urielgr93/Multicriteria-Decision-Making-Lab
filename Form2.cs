using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TESTER_FINAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f1)
        {
            InitializeComponent();
            f2 = f1;

        }

        Form1 f2 = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            f2.label25.Visible = true;
            f2.label25.Text = "WASPAS Method";
            f2.dataGridView2.Visible = true;
            f2.dataGridView3.Visible = true;
            f2.dataGridView5.Visible = true;
            f2.dataGridView6.Visible = true;
            f2.dataGridView8.Visible = true;
            f2.dataGridView9.Visible = true;

            //Boton aceptar WASPAS
            //f2.textBox2.Text = textBox1.Text; //Por lo pronto se pasan los datos del textbox1 del formulario2 al textbox2 del formulario1
            //La conversion a double de textbox2 creo que se hace en el f1 (en este caso seria convertir a double los DGV)

            //Se puede utilizar la misma estructura del WSM pero cambiar de lugar la de WPM
            //Se escribiria igual el codigo 

            //SIMULACION EMPEZANDO CON WSM

            //COLUMNA 1 CRITERIO DIRECTO WSM
            //CRITERIO DIRECTO COLUMNA 1
            if (f2.textBox2.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[1].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[51].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //de DGV1 copiar la 1era columna a la 533 (misma dgv)

                    row.Cells[53].Value = Convert.ToDouble(row.Cells[1].Value) / DIR;

                //LO SIGUIENTE SI SE COMENTA ES PARA NO REFLEJAR LOS RESULTADOS EN DGV2
                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[53].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[52, 0].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 1].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 2].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 3].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 4].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 5].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 6].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 7].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 8].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 9].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 10].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 11].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 12].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 13].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 14].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 15].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 16].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 17].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 18].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 19].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 20].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 21].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 22].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 23].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 24].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 25].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 26].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 27].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 28].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 29].Value = f2.dataGridView4[1, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO (PENDIENTE PERO CODIGO CORRECTO) Se deberia empezar 30 columnas despues
                //Multiplicar c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[54].Value = Convert.ToDouble(row.Cells[52].Value) * Convert.ToDouble(row.Cells[53].Value);

                //LO SIGUIENTE SI SE COMENTA ES PARA NO REFLEJAR LOS RESULTADOS EN DGV3
                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[54].Value);


            }

            //CRITERIO INVERSO 1ERA COLUMNA

            if (f2.textBox2.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[1].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();

                double DIR = columnData.Min();


                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    row.Cells[51].Value = DIR; //copia el valor MINIMO en la columna 51

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //de DGV1 copiar la 1era columna a la 533 (misma dgv)

                    row.Cells[53].Value = DIR / Convert.ToDouble(row.Cells[1].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[53].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[52, 0].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 1].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 2].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 3].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 4].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 5].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 6].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 7].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 8].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 9].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 10].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 11].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 12].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 13].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 14].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 15].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 16].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 17].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 18].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 19].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 20].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 21].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 22].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 23].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 24].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 25].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 26].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 27].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 28].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[52, 29].Value = f2.dataGridView4[1, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO INVERSO
                //Multiplicar c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[54].Value = Convert.ToDouble(row.Cells[52].Value) * Convert.ToDouble(row.Cells[53].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[54].Value);

            }

            //CRITERIO DIRECTO 2DA COLUMNA
            if (f2.textBox3.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[57].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[59].Value = Convert.ToDouble(row.Cells[2].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[59].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[58, 0].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 1].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 2].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 3].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 4].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 5].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 6].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 7].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 8].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 9].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 10].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 11].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 12].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 13].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 14].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 15].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 16].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 17].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 18].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 19].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 20].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 21].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 22].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 23].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 24].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 25].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 26].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 27].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 28].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 29].Value = f2.dataGridView4[2, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[60].Value = Convert.ToDouble(row.Cells[58].Value) * Convert.ToDouble(row.Cells[59].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[60].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C2");//revisar bien

                f2.dataGridView3[1, 0].Value = f2.dataGridView1[60, 0].Value;
                f2.dataGridView3[1, 1].Value = f2.dataGridView1[60, 1].Value;
                f2.dataGridView3[1, 2].Value = f2.dataGridView1[60, 2].Value;
                f2.dataGridView3[1, 3].Value = f2.dataGridView1[60, 3].Value;
                f2.dataGridView3[1, 4].Value = f2.dataGridView1[60, 4].Value;
                f2.dataGridView3[1, 5].Value = f2.dataGridView1[60, 5].Value;
                f2.dataGridView3[1, 6].Value = f2.dataGridView1[60, 6].Value;
                f2.dataGridView3[1, 7].Value = f2.dataGridView1[60, 7].Value;
                f2.dataGridView3[1, 8].Value = f2.dataGridView1[60, 8].Value;
                f2.dataGridView3[1, 9].Value = f2.dataGridView1[60, 9].Value;
                f2.dataGridView3[1, 10].Value = f2.dataGridView1[60, 10].Value;
                f2.dataGridView3[1, 11].Value = f2.dataGridView1[60, 11].Value;
                f2.dataGridView3[1, 12].Value = f2.dataGridView1[60, 12].Value;
                f2.dataGridView3[1, 13].Value = f2.dataGridView1[60, 13].Value;
                f2.dataGridView3[1, 14].Value = f2.dataGridView1[60, 14].Value;
                f2.dataGridView3[1, 15].Value = f2.dataGridView1[60, 15].Value;
                f2.dataGridView3[1, 16].Value = f2.dataGridView1[60, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C2");

                f2.dataGridView2[1, 0].Value = f2.dataGridView1[59, 0].Value;
                f2.dataGridView2[1, 1].Value = f2.dataGridView1[59, 1].Value;
                f2.dataGridView2[1, 2].Value = f2.dataGridView1[59, 2].Value;
                f2.dataGridView2[1, 3].Value = f2.dataGridView1[59, 3].Value;
                f2.dataGridView2[1, 4].Value = f2.dataGridView1[59, 4].Value;
                f2.dataGridView2[1, 5].Value = f2.dataGridView1[59, 5].Value;
                f2.dataGridView2[1, 6].Value = f2.dataGridView1[59, 6].Value;
                f2.dataGridView2[1, 7].Value = f2.dataGridView1[59, 7].Value;
                f2.dataGridView2[1, 8].Value = f2.dataGridView1[59, 8].Value;
                f2.dataGridView2[1, 9].Value = f2.dataGridView1[59, 9].Value;
                f2.dataGridView2[1, 10].Value = f2.dataGridView1[59, 10].Value;
                f2.dataGridView2[1, 11].Value = f2.dataGridView1[59, 11].Value;
                f2.dataGridView2[1, 12].Value = f2.dataGridView1[59, 12].Value;
                f2.dataGridView2[1, 13].Value = f2.dataGridView1[59, 13].Value;
                f2.dataGridView2[1, 14].Value = f2.dataGridView1[59, 14].Value;
                f2.dataGridView2[1, 15].Value = f2.dataGridView1[59, 15].Value;
                f2.dataGridView2[1, 16].Value = f2.dataGridView1[59, 16].Value;


            }

            //CRITERIO INVERSO 2DA COLUMNA
            if (f2.textBox3.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[57].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[59].Value = DIR / Convert.ToDouble(row.Cells[2].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[59].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[58, 0].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 1].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 2].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 3].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 4].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 5].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 6].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 7].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 8].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 9].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 10].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 11].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 12].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 13].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 14].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 15].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 16].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 17].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 18].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 19].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 20].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 21].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 22].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 23].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 24].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 25].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 26].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 27].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 28].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[58, 29].Value = f2.dataGridView4[2, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[60].Value = Convert.ToDouble(row.Cells[58].Value) * Convert.ToDouble(row.Cells[59].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[60].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C2");//revisar bien

                f2.dataGridView3[1, 0].Value = f2.dataGridView1[60, 0].Value;
                f2.dataGridView3[1, 1].Value = f2.dataGridView1[60, 1].Value;
                f2.dataGridView3[1, 2].Value = f2.dataGridView1[60, 2].Value;
                f2.dataGridView3[1, 3].Value = f2.dataGridView1[60, 3].Value;
                f2.dataGridView3[1, 4].Value = f2.dataGridView1[60, 4].Value;
                f2.dataGridView3[1, 5].Value = f2.dataGridView1[60, 5].Value;
                f2.dataGridView3[1, 6].Value = f2.dataGridView1[60, 6].Value;
                f2.dataGridView3[1, 7].Value = f2.dataGridView1[60, 7].Value;
                f2.dataGridView3[1, 8].Value = f2.dataGridView1[60, 8].Value;
                f2.dataGridView3[1, 9].Value = f2.dataGridView1[60, 9].Value;
                f2.dataGridView3[1, 10].Value = f2.dataGridView1[60, 10].Value;
                f2.dataGridView3[1, 11].Value = f2.dataGridView1[60, 11].Value;
                f2.dataGridView3[1, 12].Value = f2.dataGridView1[60, 12].Value;
                f2.dataGridView3[1, 13].Value = f2.dataGridView1[60, 13].Value;
                f2.dataGridView3[1, 14].Value = f2.dataGridView1[60, 14].Value;
                f2.dataGridView3[1, 15].Value = f2.dataGridView1[60, 15].Value;
                f2.dataGridView3[1, 16].Value = f2.dataGridView1[60, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C2");

                f2.dataGridView2[1, 0].Value = f2.dataGridView1[59, 0].Value;
                f2.dataGridView2[1, 1].Value = f2.dataGridView1[59, 1].Value;
                f2.dataGridView2[1, 2].Value = f2.dataGridView1[59, 2].Value;
                f2.dataGridView2[1, 3].Value = f2.dataGridView1[59, 3].Value;
                f2.dataGridView2[1, 4].Value = f2.dataGridView1[59, 4].Value;
                f2.dataGridView2[1, 5].Value = f2.dataGridView1[59, 5].Value;
                f2.dataGridView2[1, 6].Value = f2.dataGridView1[59, 6].Value;
                f2.dataGridView2[1, 7].Value = f2.dataGridView1[59, 7].Value;
                f2.dataGridView2[1, 8].Value = f2.dataGridView1[59, 8].Value;
                f2.dataGridView2[1, 9].Value = f2.dataGridView1[59, 9].Value;
                f2.dataGridView2[1, 10].Value = f2.dataGridView1[59, 10].Value;
                f2.dataGridView2[1, 11].Value = f2.dataGridView1[59, 11].Value;
                f2.dataGridView2[1, 12].Value = f2.dataGridView1[59, 12].Value;
                f2.dataGridView2[1, 13].Value = f2.dataGridView1[59, 13].Value;
                f2.dataGridView2[1, 14].Value = f2.dataGridView1[59, 14].Value;
                f2.dataGridView2[1, 15].Value = f2.dataGridView1[59, 15].Value;
                f2.dataGridView2[1, 16].Value = f2.dataGridView1[59, 16].Value;


            }

            //C3 CRITERIO DIRECTO

            if (f2.textBox4.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[62].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[64].Value = Convert.ToDouble(row.Cells[3].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[64].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[63, 0].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 1].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 2].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 3].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 4].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 5].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 6].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 7].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 8].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 9].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 10].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 11].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 12].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 13].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 14].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 15].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 16].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 17].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 18].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 19].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 20].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 21].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 22].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 23].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 24].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 25].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 26].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 27].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 28].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 29].Value = f2.dataGridView4[3, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C3
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[65].Value = Convert.ToDouble(row.Cells[63].Value) * Convert.ToDouble(row.Cells[64].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[65].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C3");//revisar bien

                f2.dataGridView3[2, 0].Value = f2.dataGridView1[65, 0].Value;
                f2.dataGridView3[2, 1].Value = f2.dataGridView1[65, 1].Value;
                f2.dataGridView3[2, 2].Value = f2.dataGridView1[65, 2].Value;
                f2.dataGridView3[2, 3].Value = f2.dataGridView1[65, 3].Value;
                f2.dataGridView3[2, 4].Value = f2.dataGridView1[65, 4].Value;
                f2.dataGridView3[2, 5].Value = f2.dataGridView1[65, 5].Value;
                f2.dataGridView3[2, 6].Value = f2.dataGridView1[65, 6].Value;
                f2.dataGridView3[2, 7].Value = f2.dataGridView1[65, 7].Value;
                f2.dataGridView3[2, 8].Value = f2.dataGridView1[65, 8].Value;
                f2.dataGridView3[2, 9].Value = f2.dataGridView1[65, 9].Value;
                f2.dataGridView3[2, 10].Value = f2.dataGridView1[65, 10].Value;
                f2.dataGridView3[2, 11].Value = f2.dataGridView1[65, 11].Value;
                f2.dataGridView3[2, 12].Value = f2.dataGridView1[65, 12].Value;
                f2.dataGridView3[2, 13].Value = f2.dataGridView1[65, 13].Value;
                f2.dataGridView3[2, 14].Value = f2.dataGridView1[65, 14].Value;
                f2.dataGridView3[2, 15].Value = f2.dataGridView1[65, 15].Value;
                f2.dataGridView3[2, 16].Value = f2.dataGridView1[65, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C3");

                f2.dataGridView2[2, 0].Value = f2.dataGridView1[64, 0].Value;
                f2.dataGridView2[2, 1].Value = f2.dataGridView1[64, 1].Value;
                f2.dataGridView2[2, 2].Value = f2.dataGridView1[64, 2].Value;
                f2.dataGridView2[2, 3].Value = f2.dataGridView1[64, 3].Value;
                f2.dataGridView2[2, 4].Value = f2.dataGridView1[64, 4].Value;
                f2.dataGridView2[2, 5].Value = f2.dataGridView1[64, 5].Value;
                f2.dataGridView2[2, 6].Value = f2.dataGridView1[64, 6].Value;
                f2.dataGridView2[2, 7].Value = f2.dataGridView1[64, 7].Value;
                f2.dataGridView2[2, 8].Value = f2.dataGridView1[64, 8].Value;
                f2.dataGridView2[2, 9].Value = f2.dataGridView1[64, 9].Value;
                f2.dataGridView2[2, 10].Value = f2.dataGridView1[64, 10].Value;
                f2.dataGridView2[2, 11].Value = f2.dataGridView1[64, 11].Value;
                f2.dataGridView2[2, 12].Value = f2.dataGridView1[64, 12].Value;
                f2.dataGridView2[2, 13].Value = f2.dataGridView1[64, 13].Value;
                f2.dataGridView2[2, 14].Value = f2.dataGridView1[64, 14].Value;
                f2.dataGridView2[2, 15].Value = f2.dataGridView1[64, 15].Value;
                f2.dataGridView2[2, 16].Value = f2.dataGridView1[64, 16].Value;


            }

            //C3 CRITERIO INVERSO

            if (f2.textBox4.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[62].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[64].Value = DIR / Convert.ToDouble(row.Cells[3].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[64].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[63, 0].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 1].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 2].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 3].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 4].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 5].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 6].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 7].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 8].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 9].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 10].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 11].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 12].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 13].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 14].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 15].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 16].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 17].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 18].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 19].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 20].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 21].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 22].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 23].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 24].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 25].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 26].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 27].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 28].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[63, 29].Value = f2.dataGridView4[3, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C3
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[65].Value = Convert.ToDouble(row.Cells[63].Value) * Convert.ToDouble(row.Cells[64].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[65].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C3");//revisar bien

                f2.dataGridView3[2, 0].Value = f2.dataGridView1[65, 0].Value;
                f2.dataGridView3[2, 1].Value = f2.dataGridView1[65, 1].Value;
                f2.dataGridView3[2, 2].Value = f2.dataGridView1[65, 2].Value;
                f2.dataGridView3[2, 3].Value = f2.dataGridView1[65, 3].Value;
                f2.dataGridView3[2, 4].Value = f2.dataGridView1[65, 4].Value;
                f2.dataGridView3[2, 5].Value = f2.dataGridView1[65, 5].Value;
                f2.dataGridView3[2, 6].Value = f2.dataGridView1[65, 6].Value;
                f2.dataGridView3[2, 7].Value = f2.dataGridView1[65, 7].Value;
                f2.dataGridView3[2, 8].Value = f2.dataGridView1[65, 8].Value;
                f2.dataGridView3[2, 9].Value = f2.dataGridView1[65, 9].Value;
                f2.dataGridView3[2, 10].Value = f2.dataGridView1[65, 10].Value;
                f2.dataGridView3[2, 11].Value = f2.dataGridView1[65, 11].Value;
                f2.dataGridView3[2, 12].Value = f2.dataGridView1[65, 12].Value;
                f2.dataGridView3[2, 13].Value = f2.dataGridView1[65, 13].Value;
                f2.dataGridView3[2, 14].Value = f2.dataGridView1[65, 14].Value;
                f2.dataGridView3[2, 15].Value = f2.dataGridView1[65, 15].Value;
                f2.dataGridView3[2, 16].Value = f2.dataGridView1[65, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C3");

                f2.dataGridView2[2, 0].Value = f2.dataGridView1[64, 0].Value;
                f2.dataGridView2[2, 1].Value = f2.dataGridView1[64, 1].Value;
                f2.dataGridView2[2, 2].Value = f2.dataGridView1[64, 2].Value;
                f2.dataGridView2[2, 3].Value = f2.dataGridView1[64, 3].Value;
                f2.dataGridView2[2, 4].Value = f2.dataGridView1[64, 4].Value;
                f2.dataGridView2[2, 5].Value = f2.dataGridView1[64, 5].Value;
                f2.dataGridView2[2, 6].Value = f2.dataGridView1[64, 6].Value;
                f2.dataGridView2[2, 7].Value = f2.dataGridView1[64, 7].Value;
                f2.dataGridView2[2, 8].Value = f2.dataGridView1[64, 8].Value;
                f2.dataGridView2[2, 9].Value = f2.dataGridView1[64, 9].Value;
                f2.dataGridView2[2, 10].Value = f2.dataGridView1[64, 10].Value;
                f2.dataGridView2[2, 11].Value = f2.dataGridView1[64, 11].Value;
                f2.dataGridView2[2, 12].Value = f2.dataGridView1[64, 12].Value;
                f2.dataGridView2[2, 13].Value = f2.dataGridView1[64, 13].Value;
                f2.dataGridView2[2, 14].Value = f2.dataGridView1[64, 14].Value;
                f2.dataGridView2[2, 15].Value = f2.dataGridView1[64, 15].Value;
                f2.dataGridView2[2, 16].Value = f2.dataGridView1[64, 16].Value;


            }

            //C4 CRITERIO DIRECTO

            if (f2.textBox5.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[4].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[67].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[69].Value = Convert.ToDouble(row.Cells[4].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[69].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[68, 0].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 1].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 2].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 3].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 4].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 5].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 6].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 7].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 8].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 9].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 10].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 11].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 12].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 13].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 14].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 15].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 16].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 17].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 18].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 19].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 20].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 21].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 22].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 23].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 24].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 25].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 26].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 27].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 28].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 29].Value = f2.dataGridView4[4, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[70].Value = Convert.ToDouble(row.Cells[68].Value) * Convert.ToDouble(row.Cells[69].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[70].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C4");//revisar bien

                f2.dataGridView3[3, 0].Value = f2.dataGridView1[70, 0].Value;
                f2.dataGridView3[3, 1].Value = f2.dataGridView1[70, 1].Value;
                f2.dataGridView3[3, 2].Value = f2.dataGridView1[70, 2].Value;
                f2.dataGridView3[3, 3].Value = f2.dataGridView1[70, 3].Value;
                f2.dataGridView3[3, 4].Value = f2.dataGridView1[70, 4].Value;
                f2.dataGridView3[3, 5].Value = f2.dataGridView1[70, 5].Value;
                f2.dataGridView3[3, 6].Value = f2.dataGridView1[70, 6].Value;
                f2.dataGridView3[3, 7].Value = f2.dataGridView1[70, 7].Value;
                f2.dataGridView3[3, 8].Value = f2.dataGridView1[70, 8].Value;
                f2.dataGridView3[3, 9].Value = f2.dataGridView1[70, 9].Value;
                f2.dataGridView3[3, 10].Value = f2.dataGridView1[70, 10].Value;
                f2.dataGridView3[3, 11].Value = f2.dataGridView1[70, 11].Value;
                f2.dataGridView3[3, 12].Value = f2.dataGridView1[70, 12].Value;
                f2.dataGridView3[3, 13].Value = f2.dataGridView1[70, 13].Value;
                f2.dataGridView3[3, 14].Value = f2.dataGridView1[70, 14].Value;
                f2.dataGridView3[3, 15].Value = f2.dataGridView1[70, 15].Value;
                f2.dataGridView3[3, 16].Value = f2.dataGridView1[70, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C4");

                f2.dataGridView2[3, 0].Value = f2.dataGridView1[69, 0].Value;
                f2.dataGridView2[3, 1].Value = f2.dataGridView1[69, 1].Value;
                f2.dataGridView2[3, 2].Value = f2.dataGridView1[69, 2].Value;
                f2.dataGridView2[3, 3].Value = f2.dataGridView1[69, 3].Value;
                f2.dataGridView2[3, 4].Value = f2.dataGridView1[69, 4].Value;
                f2.dataGridView2[3, 5].Value = f2.dataGridView1[69, 5].Value;
                f2.dataGridView2[3, 6].Value = f2.dataGridView1[69, 6].Value;
                f2.dataGridView2[3, 7].Value = f2.dataGridView1[69, 7].Value;
                f2.dataGridView2[3, 8].Value = f2.dataGridView1[69, 8].Value;
                f2.dataGridView2[3, 9].Value = f2.dataGridView1[69, 9].Value;
                f2.dataGridView2[3, 10].Value = f2.dataGridView1[69, 10].Value;
                f2.dataGridView2[3, 11].Value = f2.dataGridView1[69, 11].Value;
                f2.dataGridView2[3, 12].Value = f2.dataGridView1[69, 12].Value;
                f2.dataGridView2[3, 13].Value = f2.dataGridView1[69, 13].Value;
                f2.dataGridView2[3, 14].Value = f2.dataGridView1[69, 14].Value;
                f2.dataGridView2[3, 15].Value = f2.dataGridView1[69, 15].Value;
                f2.dataGridView2[3, 16].Value = f2.dataGridView1[69, 16].Value;


            }

            //C4 CRITERIO INVERSO

            if (f2.textBox5.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[4].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[67].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[69].Value = DIR / Convert.ToDouble(row.Cells[4].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[69].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[68, 0].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 1].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 2].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 3].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 4].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 5].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 6].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 7].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 8].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 9].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 10].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 11].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 12].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 13].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 14].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 15].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 16].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 17].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 18].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 19].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 20].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 21].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 22].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 23].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 24].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 25].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 26].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 27].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 28].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[68, 29].Value = f2.dataGridView4[4, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[70].Value = Convert.ToDouble(row.Cells[68].Value) * Convert.ToDouble(row.Cells[69].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[70].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C4");//revisar bien

                f2.dataGridView3[3, 0].Value = f2.dataGridView1[70, 0].Value;
                f2.dataGridView3[3, 1].Value = f2.dataGridView1[70, 1].Value;
                f2.dataGridView3[3, 2].Value = f2.dataGridView1[70, 2].Value;
                f2.dataGridView3[3, 3].Value = f2.dataGridView1[70, 3].Value;
                f2.dataGridView3[3, 4].Value = f2.dataGridView1[70, 4].Value;
                f2.dataGridView3[3, 5].Value = f2.dataGridView1[70, 5].Value;
                f2.dataGridView3[3, 6].Value = f2.dataGridView1[70, 6].Value;
                f2.dataGridView3[3, 7].Value = f2.dataGridView1[70, 7].Value;
                f2.dataGridView3[3, 8].Value = f2.dataGridView1[70, 8].Value;
                f2.dataGridView3[3, 9].Value = f2.dataGridView1[70, 9].Value;
                f2.dataGridView3[3, 10].Value = f2.dataGridView1[70, 10].Value;
                f2.dataGridView3[3, 11].Value = f2.dataGridView1[70, 11].Value;
                f2.dataGridView3[3, 12].Value = f2.dataGridView1[70, 12].Value;
                f2.dataGridView3[3, 13].Value = f2.dataGridView1[70, 13].Value;
                f2.dataGridView3[3, 14].Value = f2.dataGridView1[70, 14].Value;
                f2.dataGridView3[3, 15].Value = f2.dataGridView1[70, 15].Value;
                f2.dataGridView3[3, 16].Value = f2.dataGridView1[70, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C4");

                f2.dataGridView2[3, 0].Value = f2.dataGridView1[69, 0].Value;
                f2.dataGridView2[3, 1].Value = f2.dataGridView1[69, 1].Value;
                f2.dataGridView2[3, 2].Value = f2.dataGridView1[69, 2].Value;
                f2.dataGridView2[3, 3].Value = f2.dataGridView1[69, 3].Value;
                f2.dataGridView2[3, 4].Value = f2.dataGridView1[69, 4].Value;
                f2.dataGridView2[3, 5].Value = f2.dataGridView1[69, 5].Value;
                f2.dataGridView2[3, 6].Value = f2.dataGridView1[69, 6].Value;
                f2.dataGridView2[3, 7].Value = f2.dataGridView1[69, 7].Value;
                f2.dataGridView2[3, 8].Value = f2.dataGridView1[69, 8].Value;
                f2.dataGridView2[3, 9].Value = f2.dataGridView1[69, 9].Value;
                f2.dataGridView2[3, 10].Value = f2.dataGridView1[69, 10].Value;
                f2.dataGridView2[3, 11].Value = f2.dataGridView1[69, 11].Value;
                f2.dataGridView2[3, 12].Value = f2.dataGridView1[69, 12].Value;
                f2.dataGridView2[3, 13].Value = f2.dataGridView1[69, 13].Value;
                f2.dataGridView2[3, 14].Value = f2.dataGridView1[69, 14].Value;
                f2.dataGridView2[3, 15].Value = f2.dataGridView1[69, 15].Value;
                f2.dataGridView2[3, 16].Value = f2.dataGridView1[69, 16].Value;


            }

            //C5 CRITERIO DIRECTO

            if (f2.textBox6.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[72].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[74].Value = Convert.ToDouble(row.Cells[5].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[74].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[73, 0].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 1].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 2].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 3].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 4].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 5].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 6].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 7].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 8].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 9].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 10].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 11].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 12].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 13].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 14].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 15].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 16].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 17].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 18].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 19].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 20].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 21].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 22].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 23].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 24].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 25].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 26].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 27].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 28].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 29].Value = f2.dataGridView4[5, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C5
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[75].Value = Convert.ToDouble(row.Cells[73].Value) * Convert.ToDouble(row.Cells[74].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[75].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C5");//revisar bien

                f2.dataGridView3[4, 0].Value = f2.dataGridView1[75, 0].Value;
                f2.dataGridView3[4, 1].Value = f2.dataGridView1[75, 1].Value;
                f2.dataGridView3[4, 2].Value = f2.dataGridView1[75, 2].Value;
                f2.dataGridView3[4, 3].Value = f2.dataGridView1[75, 3].Value;
                f2.dataGridView3[4, 4].Value = f2.dataGridView1[75, 4].Value;
                f2.dataGridView3[4, 5].Value = f2.dataGridView1[75, 5].Value;
                f2.dataGridView3[4, 6].Value = f2.dataGridView1[75, 6].Value;
                f2.dataGridView3[4, 7].Value = f2.dataGridView1[75, 7].Value;
                f2.dataGridView3[4, 8].Value = f2.dataGridView1[75, 8].Value;
                f2.dataGridView3[4, 9].Value = f2.dataGridView1[75, 9].Value;
                f2.dataGridView3[4, 10].Value = f2.dataGridView1[75, 10].Value;
                f2.dataGridView3[4, 11].Value = f2.dataGridView1[75, 11].Value;
                f2.dataGridView3[4, 12].Value = f2.dataGridView1[75, 12].Value;
                f2.dataGridView3[4, 13].Value = f2.dataGridView1[75, 13].Value;
                f2.dataGridView3[4, 14].Value = f2.dataGridView1[75, 14].Value;
                f2.dataGridView3[4, 15].Value = f2.dataGridView1[75, 15].Value;
                f2.dataGridView3[4, 16].Value = f2.dataGridView1[75, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C5");

                f2.dataGridView2[4, 0].Value = f2.dataGridView1[74, 0].Value;
                f2.dataGridView2[4, 1].Value = f2.dataGridView1[74, 1].Value;
                f2.dataGridView2[4, 2].Value = f2.dataGridView1[74, 2].Value;
                f2.dataGridView2[4, 3].Value = f2.dataGridView1[74, 3].Value;
                f2.dataGridView2[4, 4].Value = f2.dataGridView1[74, 4].Value;
                f2.dataGridView2[4, 5].Value = f2.dataGridView1[74, 5].Value;
                f2.dataGridView2[4, 6].Value = f2.dataGridView1[74, 6].Value;
                f2.dataGridView2[4, 7].Value = f2.dataGridView1[74, 7].Value;
                f2.dataGridView2[4, 8].Value = f2.dataGridView1[74, 8].Value;
                f2.dataGridView2[4, 9].Value = f2.dataGridView1[74, 9].Value;
                f2.dataGridView2[4, 10].Value = f2.dataGridView1[74, 10].Value;
                f2.dataGridView2[4, 11].Value = f2.dataGridView1[74, 11].Value;
                f2.dataGridView2[4, 12].Value = f2.dataGridView1[74, 12].Value;
                f2.dataGridView2[4, 13].Value = f2.dataGridView1[74, 13].Value;
                f2.dataGridView2[4, 14].Value = f2.dataGridView1[74, 14].Value;
                f2.dataGridView2[4, 15].Value = f2.dataGridView1[74, 15].Value;
                f2.dataGridView2[4, 16].Value = f2.dataGridView1[74, 16].Value;


            }

            //C5 CRITERIO INVERSO

            if (f2.textBox6.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[72].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[74].Value = DIR / Convert.ToDouble(row.Cells[5].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[74].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[73, 0].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 1].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 2].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 3].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 4].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 5].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 6].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 7].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 8].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 9].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 10].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 11].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 12].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 13].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 14].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 15].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 16].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 17].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 18].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 19].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 20].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 21].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 22].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 23].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 24].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 25].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 26].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 27].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 28].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[73, 29].Value = f2.dataGridView4[5, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C5
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[75].Value = Convert.ToDouble(row.Cells[73].Value) * Convert.ToDouble(row.Cells[74].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[75].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C5");//revisar bien

                f2.dataGridView3[4, 0].Value = f2.dataGridView1[75, 0].Value;
                f2.dataGridView3[4, 1].Value = f2.dataGridView1[75, 1].Value;
                f2.dataGridView3[4, 2].Value = f2.dataGridView1[75, 2].Value;
                f2.dataGridView3[4, 3].Value = f2.dataGridView1[75, 3].Value;
                f2.dataGridView3[4, 4].Value = f2.dataGridView1[75, 4].Value;
                f2.dataGridView3[4, 5].Value = f2.dataGridView1[75, 5].Value;
                f2.dataGridView3[4, 6].Value = f2.dataGridView1[75, 6].Value;
                f2.dataGridView3[4, 7].Value = f2.dataGridView1[75, 7].Value;
                f2.dataGridView3[4, 8].Value = f2.dataGridView1[75, 8].Value;
                f2.dataGridView3[4, 9].Value = f2.dataGridView1[75, 9].Value;
                f2.dataGridView3[4, 10].Value = f2.dataGridView1[75, 10].Value;
                f2.dataGridView3[4, 11].Value = f2.dataGridView1[75, 11].Value;
                f2.dataGridView3[4, 12].Value = f2.dataGridView1[75, 12].Value;
                f2.dataGridView3[4, 13].Value = f2.dataGridView1[75, 13].Value;
                f2.dataGridView3[4, 14].Value = f2.dataGridView1[75, 14].Value;
                f2.dataGridView3[4, 15].Value = f2.dataGridView1[75, 15].Value;
                f2.dataGridView3[4, 16].Value = f2.dataGridView1[75, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C5");

                f2.dataGridView2[4, 0].Value = f2.dataGridView1[74, 0].Value;
                f2.dataGridView2[4, 1].Value = f2.dataGridView1[74, 1].Value;
                f2.dataGridView2[4, 2].Value = f2.dataGridView1[74, 2].Value;
                f2.dataGridView2[4, 3].Value = f2.dataGridView1[74, 3].Value;
                f2.dataGridView2[4, 4].Value = f2.dataGridView1[74, 4].Value;
                f2.dataGridView2[4, 5].Value = f2.dataGridView1[74, 5].Value;
                f2.dataGridView2[4, 6].Value = f2.dataGridView1[74, 6].Value;
                f2.dataGridView2[4, 7].Value = f2.dataGridView1[74, 7].Value;
                f2.dataGridView2[4, 8].Value = f2.dataGridView1[74, 8].Value;
                f2.dataGridView2[4, 9].Value = f2.dataGridView1[74, 9].Value;
                f2.dataGridView2[4, 10].Value = f2.dataGridView1[74, 10].Value;
                f2.dataGridView2[4, 11].Value = f2.dataGridView1[74, 11].Value;
                f2.dataGridView2[4, 12].Value = f2.dataGridView1[74, 12].Value;
                f2.dataGridView2[4, 13].Value = f2.dataGridView1[74, 13].Value;
                f2.dataGridView2[4, 14].Value = f2.dataGridView1[74, 14].Value;
                f2.dataGridView2[4, 15].Value = f2.dataGridView1[74, 15].Value;
                f2.dataGridView2[4, 16].Value = f2.dataGridView1[74, 16].Value;


            }

            //C6 CRITERIO DIRECTO

            if (f2.textBox7.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[77].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[79].Value = Convert.ToDouble(row.Cells[6].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[79].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[78, 0].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 1].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 2].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 3].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 4].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 5].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 6].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 7].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 8].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 9].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 10].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 11].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 12].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 13].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 14].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 15].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 16].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 17].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 18].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 19].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 20].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 21].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 22].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 23].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 24].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 25].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 26].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 27].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 28].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 29].Value = f2.dataGridView4[6, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C6
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[80].Value = Convert.ToDouble(row.Cells[78].Value) * Convert.ToDouble(row.Cells[79].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[80].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C6");//revisar bien

                f2.dataGridView3[5, 0].Value = f2.dataGridView1[80, 0].Value;
                f2.dataGridView3[5, 1].Value = f2.dataGridView1[80, 1].Value;
                f2.dataGridView3[5, 2].Value = f2.dataGridView1[80, 2].Value;
                f2.dataGridView3[5, 3].Value = f2.dataGridView1[80, 3].Value;
                f2.dataGridView3[5, 4].Value = f2.dataGridView1[80, 4].Value;
                f2.dataGridView3[5, 5].Value = f2.dataGridView1[80, 5].Value;
                f2.dataGridView3[5, 6].Value = f2.dataGridView1[80, 6].Value;
                f2.dataGridView3[5, 7].Value = f2.dataGridView1[80, 7].Value;
                f2.dataGridView3[5, 8].Value = f2.dataGridView1[80, 8].Value;
                f2.dataGridView3[5, 9].Value = f2.dataGridView1[80, 9].Value;
                f2.dataGridView3[5, 10].Value = f2.dataGridView1[80, 10].Value;
                f2.dataGridView3[5, 11].Value = f2.dataGridView1[80, 11].Value;
                f2.dataGridView3[5, 12].Value = f2.dataGridView1[80, 12].Value;
                f2.dataGridView3[5, 13].Value = f2.dataGridView1[80, 13].Value;
                f2.dataGridView3[5, 14].Value = f2.dataGridView1[80, 14].Value;
                f2.dataGridView3[5, 15].Value = f2.dataGridView1[80, 15].Value;
                f2.dataGridView3[5, 16].Value = f2.dataGridView1[80, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C6");

                f2.dataGridView2[5, 0].Value = f2.dataGridView1[79, 0].Value;
                f2.dataGridView2[5, 1].Value = f2.dataGridView1[79, 1].Value;
                f2.dataGridView2[5, 2].Value = f2.dataGridView1[79, 2].Value;
                f2.dataGridView2[5, 3].Value = f2.dataGridView1[79, 3].Value;
                f2.dataGridView2[5, 4].Value = f2.dataGridView1[79, 4].Value;
                f2.dataGridView2[5, 5].Value = f2.dataGridView1[79, 5].Value;
                f2.dataGridView2[5, 6].Value = f2.dataGridView1[79, 6].Value;
                f2.dataGridView2[5, 7].Value = f2.dataGridView1[79, 7].Value;
                f2.dataGridView2[5, 8].Value = f2.dataGridView1[79, 8].Value;
                f2.dataGridView2[5, 9].Value = f2.dataGridView1[79, 9].Value;
                f2.dataGridView2[5, 10].Value = f2.dataGridView1[79, 10].Value;
                f2.dataGridView2[5, 11].Value = f2.dataGridView1[79, 11].Value;
                f2.dataGridView2[5, 12].Value = f2.dataGridView1[79, 12].Value;
                f2.dataGridView2[5, 13].Value = f2.dataGridView1[79, 13].Value;
                f2.dataGridView2[5, 14].Value = f2.dataGridView1[79, 14].Value;
                f2.dataGridView2[5, 15].Value = f2.dataGridView1[79, 15].Value;
                f2.dataGridView2[5, 16].Value = f2.dataGridView1[79, 16].Value;


            }

            //C6 CRITERIO INVERSO

            if (f2.textBox7.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[77].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[79].Value = DIR / Convert.ToDouble(row.Cells[6].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[79].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[78, 0].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 1].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 2].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 3].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 4].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 5].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 6].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 7].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 8].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 9].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 10].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 11].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 12].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 13].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 14].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 15].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 16].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 17].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 18].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 19].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 20].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 21].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 22].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 23].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 24].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 25].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 26].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 27].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 28].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[78, 29].Value = f2.dataGridView4[6, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C6
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[80].Value = Convert.ToDouble(row.Cells[78].Value) * Convert.ToDouble(row.Cells[79].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[80].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C6");//revisar bien

                f2.dataGridView3[5, 0].Value = f2.dataGridView1[80, 0].Value;
                f2.dataGridView3[5, 1].Value = f2.dataGridView1[80, 1].Value;
                f2.dataGridView3[5, 2].Value = f2.dataGridView1[80, 2].Value;
                f2.dataGridView3[5, 3].Value = f2.dataGridView1[80, 3].Value;
                f2.dataGridView3[5, 4].Value = f2.dataGridView1[80, 4].Value;
                f2.dataGridView3[5, 5].Value = f2.dataGridView1[80, 5].Value;
                f2.dataGridView3[5, 6].Value = f2.dataGridView1[80, 6].Value;
                f2.dataGridView3[5, 7].Value = f2.dataGridView1[80, 7].Value;
                f2.dataGridView3[5, 8].Value = f2.dataGridView1[80, 8].Value;
                f2.dataGridView3[5, 9].Value = f2.dataGridView1[80, 9].Value;
                f2.dataGridView3[5, 10].Value = f2.dataGridView1[80, 10].Value;
                f2.dataGridView3[5, 11].Value = f2.dataGridView1[80, 11].Value;
                f2.dataGridView3[5, 12].Value = f2.dataGridView1[80, 12].Value;
                f2.dataGridView3[5, 13].Value = f2.dataGridView1[80, 13].Value;
                f2.dataGridView3[5, 14].Value = f2.dataGridView1[80, 14].Value;
                f2.dataGridView3[5, 15].Value = f2.dataGridView1[80, 15].Value;
                f2.dataGridView3[5, 16].Value = f2.dataGridView1[80, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C6");

                f2.dataGridView2[5, 0].Value = f2.dataGridView1[79, 0].Value;
                f2.dataGridView2[5, 1].Value = f2.dataGridView1[79, 1].Value;
                f2.dataGridView2[5, 2].Value = f2.dataGridView1[79, 2].Value;
                f2.dataGridView2[5, 3].Value = f2.dataGridView1[79, 3].Value;
                f2.dataGridView2[5, 4].Value = f2.dataGridView1[79, 4].Value;
                f2.dataGridView2[5, 5].Value = f2.dataGridView1[79, 5].Value;
                f2.dataGridView2[5, 6].Value = f2.dataGridView1[79, 6].Value;
                f2.dataGridView2[5, 7].Value = f2.dataGridView1[79, 7].Value;
                f2.dataGridView2[5, 8].Value = f2.dataGridView1[79, 8].Value;
                f2.dataGridView2[5, 9].Value = f2.dataGridView1[79, 9].Value;
                f2.dataGridView2[5, 10].Value = f2.dataGridView1[79, 10].Value;
                f2.dataGridView2[5, 11].Value = f2.dataGridView1[79, 11].Value;
                f2.dataGridView2[5, 12].Value = f2.dataGridView1[79, 12].Value;
                f2.dataGridView2[5, 13].Value = f2.dataGridView1[79, 13].Value;
                f2.dataGridView2[5, 14].Value = f2.dataGridView1[79, 14].Value;
                f2.dataGridView2[5, 15].Value = f2.dataGridView1[79, 15].Value;
                f2.dataGridView2[5, 16].Value = f2.dataGridView1[79, 16].Value;


            }

            //C7 CRITERIO DIRECTO

            if (f2.textBox8.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[7].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[82].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[84].Value = Convert.ToDouble(row.Cells[7].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[84].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[83, 0].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 1].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 2].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 3].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 4].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 5].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 6].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 7].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 8].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 9].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 10].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 11].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 12].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 13].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 14].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 15].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 16].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 17].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 18].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 19].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 20].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 21].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 22].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 23].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 24].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 25].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 26].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 27].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 28].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 29].Value = f2.dataGridView4[7, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C7
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[85].Value = Convert.ToDouble(row.Cells[83].Value) * Convert.ToDouble(row.Cells[84].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[85].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C7");//revisar bien

                f2.dataGridView3[6, 0].Value = f2.dataGridView1[85, 0].Value;
                f2.dataGridView3[6, 1].Value = f2.dataGridView1[85, 1].Value;
                f2.dataGridView3[6, 2].Value = f2.dataGridView1[85, 2].Value;
                f2.dataGridView3[6, 3].Value = f2.dataGridView1[85, 3].Value;
                f2.dataGridView3[6, 4].Value = f2.dataGridView1[85, 4].Value;
                f2.dataGridView3[6, 5].Value = f2.dataGridView1[85, 5].Value;
                f2.dataGridView3[6, 6].Value = f2.dataGridView1[85, 6].Value;
                f2.dataGridView3[6, 7].Value = f2.dataGridView1[85, 7].Value;
                f2.dataGridView3[6, 8].Value = f2.dataGridView1[85, 8].Value;
                f2.dataGridView3[6, 9].Value = f2.dataGridView1[85, 9].Value;
                f2.dataGridView3[6, 10].Value = f2.dataGridView1[85, 10].Value;
                f2.dataGridView3[6, 11].Value = f2.dataGridView1[85, 11].Value;
                f2.dataGridView3[6, 12].Value = f2.dataGridView1[85, 12].Value;
                f2.dataGridView3[6, 13].Value = f2.dataGridView1[85, 13].Value;
                f2.dataGridView3[6, 14].Value = f2.dataGridView1[85, 14].Value;
                f2.dataGridView3[6, 15].Value = f2.dataGridView1[85, 15].Value;
                f2.dataGridView3[6, 16].Value = f2.dataGridView1[85, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C7");

                f2.dataGridView2[6, 0].Value = f2.dataGridView1[84, 0].Value;
                f2.dataGridView2[6, 1].Value = f2.dataGridView1[84, 1].Value;
                f2.dataGridView2[6, 2].Value = f2.dataGridView1[84, 2].Value;
                f2.dataGridView2[6, 3].Value = f2.dataGridView1[84, 3].Value;
                f2.dataGridView2[6, 4].Value = f2.dataGridView1[84, 4].Value;
                f2.dataGridView2[6, 5].Value = f2.dataGridView1[84, 5].Value;
                f2.dataGridView2[6, 6].Value = f2.dataGridView1[84, 6].Value;
                f2.dataGridView2[6, 7].Value = f2.dataGridView1[84, 7].Value;
                f2.dataGridView2[6, 8].Value = f2.dataGridView1[84, 8].Value;
                f2.dataGridView2[6, 9].Value = f2.dataGridView1[84, 9].Value;
                f2.dataGridView2[6, 10].Value = f2.dataGridView1[84, 10].Value;
                f2.dataGridView2[6, 11].Value = f2.dataGridView1[84, 11].Value;
                f2.dataGridView2[6, 12].Value = f2.dataGridView1[84, 12].Value;
                f2.dataGridView2[6, 13].Value = f2.dataGridView1[84, 13].Value;
                f2.dataGridView2[6, 14].Value = f2.dataGridView1[84, 14].Value;
                f2.dataGridView2[6, 15].Value = f2.dataGridView1[84, 15].Value;
                f2.dataGridView2[6, 16].Value = f2.dataGridView1[84, 16].Value;


            }

            //C7 CRITERIO INVERSO

            if (f2.textBox8.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[7].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[82].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[84].Value = DIR / Convert.ToDouble(row.Cells[7].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[84].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[83, 0].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 1].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 2].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 3].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 4].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 5].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 6].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 7].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 8].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 9].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 10].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 11].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 12].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 13].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 14].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 15].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 16].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 17].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 18].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 19].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 20].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 21].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 22].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 23].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 24].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 25].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 26].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 27].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 28].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[83, 29].Value = f2.dataGridView4[7, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C7
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[85].Value = Convert.ToDouble(row.Cells[83].Value) * Convert.ToDouble(row.Cells[84].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[85].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C7");//revisar bien

                f2.dataGridView3[6, 0].Value = f2.dataGridView1[85, 0].Value;
                f2.dataGridView3[6, 1].Value = f2.dataGridView1[85, 1].Value;
                f2.dataGridView3[6, 2].Value = f2.dataGridView1[85, 2].Value;
                f2.dataGridView3[6, 3].Value = f2.dataGridView1[85, 3].Value;
                f2.dataGridView3[6, 4].Value = f2.dataGridView1[85, 4].Value;
                f2.dataGridView3[6, 5].Value = f2.dataGridView1[85, 5].Value;
                f2.dataGridView3[6, 6].Value = f2.dataGridView1[85, 6].Value;
                f2.dataGridView3[6, 7].Value = f2.dataGridView1[85, 7].Value;
                f2.dataGridView3[6, 8].Value = f2.dataGridView1[85, 8].Value;
                f2.dataGridView3[6, 9].Value = f2.dataGridView1[85, 9].Value;
                f2.dataGridView3[6, 10].Value = f2.dataGridView1[85, 10].Value;
                f2.dataGridView3[6, 11].Value = f2.dataGridView1[85, 11].Value;
                f2.dataGridView3[6, 12].Value = f2.dataGridView1[85, 12].Value;
                f2.dataGridView3[6, 13].Value = f2.dataGridView1[85, 13].Value;
                f2.dataGridView3[6, 14].Value = f2.dataGridView1[85, 14].Value;
                f2.dataGridView3[6, 15].Value = f2.dataGridView1[85, 15].Value;
                f2.dataGridView3[6, 16].Value = f2.dataGridView1[85, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C7");

                f2.dataGridView2[6, 0].Value = f2.dataGridView1[84, 0].Value;
                f2.dataGridView2[6, 1].Value = f2.dataGridView1[84, 1].Value;
                f2.dataGridView2[6, 2].Value = f2.dataGridView1[84, 2].Value;
                f2.dataGridView2[6, 3].Value = f2.dataGridView1[84, 3].Value;
                f2.dataGridView2[6, 4].Value = f2.dataGridView1[84, 4].Value;
                f2.dataGridView2[6, 5].Value = f2.dataGridView1[84, 5].Value;
                f2.dataGridView2[6, 6].Value = f2.dataGridView1[84, 6].Value;
                f2.dataGridView2[6, 7].Value = f2.dataGridView1[84, 7].Value;
                f2.dataGridView2[6, 8].Value = f2.dataGridView1[84, 8].Value;
                f2.dataGridView2[6, 9].Value = f2.dataGridView1[84, 9].Value;
                f2.dataGridView2[6, 10].Value = f2.dataGridView1[84, 10].Value;
                f2.dataGridView2[6, 11].Value = f2.dataGridView1[84, 11].Value;
                f2.dataGridView2[6, 12].Value = f2.dataGridView1[84, 12].Value;
                f2.dataGridView2[6, 13].Value = f2.dataGridView1[84, 13].Value;
                f2.dataGridView2[6, 14].Value = f2.dataGridView1[84, 14].Value;
                f2.dataGridView2[6, 15].Value = f2.dataGridView1[84, 15].Value;
                f2.dataGridView2[6, 16].Value = f2.dataGridView1[84, 16].Value;


            }

            //C8 CRITERIO DIRECTO

            if (f2.textBox9.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[8].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[8].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[87].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[89].Value = Convert.ToDouble(row.Cells[8].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[89].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[88, 0].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 1].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 2].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 3].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 4].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 5].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 6].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 7].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 8].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 9].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 10].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 11].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 12].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 13].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 14].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 15].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 16].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 17].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 18].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 19].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 20].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 21].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 22].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 23].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 24].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 25].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 26].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 27].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 28].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 29].Value = f2.dataGridView4[8, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C8
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[90].Value = Convert.ToDouble(row.Cells[88].Value) * Convert.ToDouble(row.Cells[89].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[90].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C8");//revisar bien

                f2.dataGridView3[7, 0].Value = f2.dataGridView1[90, 0].Value;
                f2.dataGridView3[7, 1].Value = f2.dataGridView1[90, 1].Value;
                f2.dataGridView3[7, 2].Value = f2.dataGridView1[90, 2].Value;
                f2.dataGridView3[7, 3].Value = f2.dataGridView1[90, 3].Value;
                f2.dataGridView3[7, 4].Value = f2.dataGridView1[90, 4].Value;
                f2.dataGridView3[7, 5].Value = f2.dataGridView1[90, 5].Value;
                f2.dataGridView3[7, 6].Value = f2.dataGridView1[90, 6].Value;
                f2.dataGridView3[7, 7].Value = f2.dataGridView1[90, 7].Value;
                f2.dataGridView3[7, 8].Value = f2.dataGridView1[90, 8].Value;
                f2.dataGridView3[7, 9].Value = f2.dataGridView1[90, 9].Value;
                f2.dataGridView3[7, 10].Value = f2.dataGridView1[90, 10].Value;
                f2.dataGridView3[7, 11].Value = f2.dataGridView1[90, 11].Value;
                f2.dataGridView3[7, 12].Value = f2.dataGridView1[90, 12].Value;
                f2.dataGridView3[7, 13].Value = f2.dataGridView1[90, 13].Value;
                f2.dataGridView3[7, 14].Value = f2.dataGridView1[90, 14].Value;
                f2.dataGridView3[7, 15].Value = f2.dataGridView1[90, 15].Value;
                f2.dataGridView3[7, 16].Value = f2.dataGridView1[90, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C8");

                f2.dataGridView2[7, 0].Value = f2.dataGridView1[89, 0].Value;
                f2.dataGridView2[7, 1].Value = f2.dataGridView1[89, 1].Value;
                f2.dataGridView2[7, 2].Value = f2.dataGridView1[89, 2].Value;
                f2.dataGridView2[7, 3].Value = f2.dataGridView1[89, 3].Value;
                f2.dataGridView2[7, 4].Value = f2.dataGridView1[89, 4].Value;
                f2.dataGridView2[7, 5].Value = f2.dataGridView1[89, 5].Value;
                f2.dataGridView2[7, 6].Value = f2.dataGridView1[89, 6].Value;
                f2.dataGridView2[7, 7].Value = f2.dataGridView1[89, 7].Value;
                f2.dataGridView2[7, 8].Value = f2.dataGridView1[89, 8].Value;
                f2.dataGridView2[7, 9].Value = f2.dataGridView1[89, 9].Value;
                f2.dataGridView2[7, 10].Value = f2.dataGridView1[89, 10].Value;
                f2.dataGridView2[7, 11].Value = f2.dataGridView1[89, 11].Value;
                f2.dataGridView2[7, 12].Value = f2.dataGridView1[89, 12].Value;
                f2.dataGridView2[7, 13].Value = f2.dataGridView1[89, 13].Value;
                f2.dataGridView2[7, 14].Value = f2.dataGridView1[89, 14].Value;
                f2.dataGridView2[7, 15].Value = f2.dataGridView1[89, 15].Value;
                f2.dataGridView2[7, 16].Value = f2.dataGridView1[89, 16].Value;


            }

            //C8 CRITERIO INVERSO

            if (f2.textBox9.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[8].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[8].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[87].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[89].Value = DIR / Convert.ToDouble(row.Cells[8].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[89].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[88, 0].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 1].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 2].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 3].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 4].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 5].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 6].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 7].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 8].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 9].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 10].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 11].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 12].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 13].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 14].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 15].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 16].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 17].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 18].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 19].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 20].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 21].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 22].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 23].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 24].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 25].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 26].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 27].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 28].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[88, 29].Value = f2.dataGridView4[8, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C8
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[90].Value = Convert.ToDouble(row.Cells[88].Value) * Convert.ToDouble(row.Cells[89].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[90].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C8");//revisar bien

                f2.dataGridView3[7, 0].Value = f2.dataGridView1[90, 0].Value;
                f2.dataGridView3[7, 1].Value = f2.dataGridView1[90, 1].Value;
                f2.dataGridView3[7, 2].Value = f2.dataGridView1[90, 2].Value;
                f2.dataGridView3[7, 3].Value = f2.dataGridView1[90, 3].Value;
                f2.dataGridView3[7, 4].Value = f2.dataGridView1[90, 4].Value;
                f2.dataGridView3[7, 5].Value = f2.dataGridView1[90, 5].Value;
                f2.dataGridView3[7, 6].Value = f2.dataGridView1[90, 6].Value;
                f2.dataGridView3[7, 7].Value = f2.dataGridView1[90, 7].Value;
                f2.dataGridView3[7, 8].Value = f2.dataGridView1[90, 8].Value;
                f2.dataGridView3[7, 9].Value = f2.dataGridView1[90, 9].Value;
                f2.dataGridView3[7, 10].Value = f2.dataGridView1[90, 10].Value;
                f2.dataGridView3[7, 11].Value = f2.dataGridView1[90, 11].Value;
                f2.dataGridView3[7, 12].Value = f2.dataGridView1[90, 12].Value;
                f2.dataGridView3[7, 13].Value = f2.dataGridView1[90, 13].Value;
                f2.dataGridView3[7, 14].Value = f2.dataGridView1[90, 14].Value;
                f2.dataGridView3[7, 15].Value = f2.dataGridView1[90, 15].Value;
                f2.dataGridView3[7, 16].Value = f2.dataGridView1[90, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C8");

                f2.dataGridView2[7, 0].Value = f2.dataGridView1[89, 0].Value;
                f2.dataGridView2[7, 1].Value = f2.dataGridView1[89, 1].Value;
                f2.dataGridView2[7, 2].Value = f2.dataGridView1[89, 2].Value;
                f2.dataGridView2[7, 3].Value = f2.dataGridView1[89, 3].Value;
                f2.dataGridView2[7, 4].Value = f2.dataGridView1[89, 4].Value;
                f2.dataGridView2[7, 5].Value = f2.dataGridView1[89, 5].Value;
                f2.dataGridView2[7, 6].Value = f2.dataGridView1[89, 6].Value;
                f2.dataGridView2[7, 7].Value = f2.dataGridView1[89, 7].Value;
                f2.dataGridView2[7, 8].Value = f2.dataGridView1[89, 8].Value;
                f2.dataGridView2[7, 9].Value = f2.dataGridView1[89, 9].Value;
                f2.dataGridView2[7, 10].Value = f2.dataGridView1[89, 10].Value;
                f2.dataGridView2[7, 11].Value = f2.dataGridView1[89, 11].Value;
                f2.dataGridView2[7, 12].Value = f2.dataGridView1[89, 12].Value;
                f2.dataGridView2[7, 13].Value = f2.dataGridView1[89, 13].Value;
                f2.dataGridView2[7, 14].Value = f2.dataGridView1[89, 14].Value;
                f2.dataGridView2[7, 15].Value = f2.dataGridView1[89, 15].Value;
                f2.dataGridView2[7, 16].Value = f2.dataGridView1[89, 16].Value;


            }

            //C9 CRITERIO DIRECTO

            if (f2.textBox10.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[9].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[92].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[94].Value = Convert.ToDouble(row.Cells[9].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[94].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[93, 0].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 1].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 2].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 3].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 4].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 5].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 6].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 7].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 8].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 9].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 10].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 11].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 12].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 13].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 14].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 15].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 16].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 17].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 18].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 19].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 20].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 21].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 22].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 23].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 24].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 25].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 26].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 27].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 28].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 29].Value = f2.dataGridView4[9, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C9
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[95].Value = Convert.ToDouble(row.Cells[93].Value) * Convert.ToDouble(row.Cells[94].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[95].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C9");//revisar bien

                f2.dataGridView3[8, 0].Value = f2.dataGridView1[95, 0].Value;
                f2.dataGridView3[8, 1].Value = f2.dataGridView1[95, 1].Value;
                f2.dataGridView3[8, 2].Value = f2.dataGridView1[95, 2].Value;
                f2.dataGridView3[8, 3].Value = f2.dataGridView1[95, 3].Value;
                f2.dataGridView3[8, 4].Value = f2.dataGridView1[95, 4].Value;
                f2.dataGridView3[8, 5].Value = f2.dataGridView1[95, 5].Value;
                f2.dataGridView3[8, 6].Value = f2.dataGridView1[95, 6].Value;
                f2.dataGridView3[8, 7].Value = f2.dataGridView1[95, 7].Value;
                f2.dataGridView3[8, 8].Value = f2.dataGridView1[95, 8].Value;
                f2.dataGridView3[8, 9].Value = f2.dataGridView1[95, 9].Value;
                f2.dataGridView3[8, 10].Value = f2.dataGridView1[95, 10].Value;
                f2.dataGridView3[8, 11].Value = f2.dataGridView1[95, 11].Value;
                f2.dataGridView3[8, 12].Value = f2.dataGridView1[95, 12].Value;
                f2.dataGridView3[8, 13].Value = f2.dataGridView1[95, 13].Value;
                f2.dataGridView3[8, 14].Value = f2.dataGridView1[95, 14].Value;
                f2.dataGridView3[8, 15].Value = f2.dataGridView1[95, 15].Value;
                f2.dataGridView3[8, 16].Value = f2.dataGridView1[95, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C9");

                f2.dataGridView2[8, 0].Value = f2.dataGridView1[94, 0].Value;
                f2.dataGridView2[8, 1].Value = f2.dataGridView1[94, 1].Value;
                f2.dataGridView2[8, 2].Value = f2.dataGridView1[94, 2].Value;
                f2.dataGridView2[8, 3].Value = f2.dataGridView1[94, 3].Value;
                f2.dataGridView2[8, 4].Value = f2.dataGridView1[94, 4].Value;
                f2.dataGridView2[8, 5].Value = f2.dataGridView1[94, 5].Value;
                f2.dataGridView2[8, 6].Value = f2.dataGridView1[94, 6].Value;
                f2.dataGridView2[8, 7].Value = f2.dataGridView1[94, 7].Value;
                f2.dataGridView2[8, 8].Value = f2.dataGridView1[94, 8].Value;
                f2.dataGridView2[8, 9].Value = f2.dataGridView1[94, 9].Value;
                f2.dataGridView2[8, 10].Value = f2.dataGridView1[94, 10].Value;
                f2.dataGridView2[8, 11].Value = f2.dataGridView1[94, 11].Value;
                f2.dataGridView2[8, 12].Value = f2.dataGridView1[94, 12].Value;
                f2.dataGridView2[8, 13].Value = f2.dataGridView1[94, 13].Value;
                f2.dataGridView2[8, 14].Value = f2.dataGridView1[94, 14].Value;
                f2.dataGridView2[8, 15].Value = f2.dataGridView1[94, 15].Value;
                f2.dataGridView2[8, 16].Value = f2.dataGridView1[94, 16].Value;


            }

            //C9 CRITERIO INVERSO

            if (f2.textBox10.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[9].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[92].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[94].Value = DIR / Convert.ToDouble(row.Cells[9].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[94].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[93, 0].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 1].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 2].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 3].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 4].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 5].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 6].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 7].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 8].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 9].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 10].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 11].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 12].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 13].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 14].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 15].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 16].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 17].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 18].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 19].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 20].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 21].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 22].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 23].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 24].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 25].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 26].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 27].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 28].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[93, 29].Value = f2.dataGridView4[9, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C9
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[95].Value = Convert.ToDouble(row.Cells[93].Value) * Convert.ToDouble(row.Cells[94].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[95].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C9");//revisar bien

                f2.dataGridView3[8, 0].Value = f2.dataGridView1[95, 0].Value;
                f2.dataGridView3[8, 1].Value = f2.dataGridView1[95, 1].Value;
                f2.dataGridView3[8, 2].Value = f2.dataGridView1[95, 2].Value;
                f2.dataGridView3[8, 3].Value = f2.dataGridView1[95, 3].Value;
                f2.dataGridView3[8, 4].Value = f2.dataGridView1[95, 4].Value;
                f2.dataGridView3[8, 5].Value = f2.dataGridView1[95, 5].Value;
                f2.dataGridView3[8, 6].Value = f2.dataGridView1[95, 6].Value;
                f2.dataGridView3[8, 7].Value = f2.dataGridView1[95, 7].Value;
                f2.dataGridView3[8, 8].Value = f2.dataGridView1[95, 8].Value;
                f2.dataGridView3[8, 9].Value = f2.dataGridView1[95, 9].Value;
                f2.dataGridView3[8, 10].Value = f2.dataGridView1[95, 10].Value;
                f2.dataGridView3[8, 11].Value = f2.dataGridView1[95, 11].Value;
                f2.dataGridView3[8, 12].Value = f2.dataGridView1[95, 12].Value;
                f2.dataGridView3[8, 13].Value = f2.dataGridView1[95, 13].Value;
                f2.dataGridView3[8, 14].Value = f2.dataGridView1[95, 14].Value;
                f2.dataGridView3[8, 15].Value = f2.dataGridView1[95, 15].Value;
                f2.dataGridView3[8, 16].Value = f2.dataGridView1[95, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C9");

                f2.dataGridView2[8, 0].Value = f2.dataGridView1[94, 0].Value;
                f2.dataGridView2[8, 1].Value = f2.dataGridView1[94, 1].Value;
                f2.dataGridView2[8, 2].Value = f2.dataGridView1[94, 2].Value;
                f2.dataGridView2[8, 3].Value = f2.dataGridView1[94, 3].Value;
                f2.dataGridView2[8, 4].Value = f2.dataGridView1[94, 4].Value;
                f2.dataGridView2[8, 5].Value = f2.dataGridView1[94, 5].Value;
                f2.dataGridView2[8, 6].Value = f2.dataGridView1[94, 6].Value;
                f2.dataGridView2[8, 7].Value = f2.dataGridView1[94, 7].Value;
                f2.dataGridView2[8, 8].Value = f2.dataGridView1[94, 8].Value;
                f2.dataGridView2[8, 9].Value = f2.dataGridView1[94, 9].Value;
                f2.dataGridView2[8, 10].Value = f2.dataGridView1[94, 10].Value;
                f2.dataGridView2[8, 11].Value = f2.dataGridView1[94, 11].Value;
                f2.dataGridView2[8, 12].Value = f2.dataGridView1[94, 12].Value;
                f2.dataGridView2[8, 13].Value = f2.dataGridView1[94, 13].Value;
                f2.dataGridView2[8, 14].Value = f2.dataGridView1[94, 14].Value;
                f2.dataGridView2[8, 15].Value = f2.dataGridView1[94, 15].Value;
                f2.dataGridView2[8, 16].Value = f2.dataGridView1[94, 16].Value;


            }


            //C10 CRITERIO DIRECTO

            if (f2.textBox11.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[10].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[97].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[99].Value = Convert.ToDouble(row.Cells[10].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[99].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[98, 0].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 1].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 2].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 3].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 4].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 5].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 6].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 7].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 8].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 9].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 10].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 11].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 12].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 13].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 14].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 15].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 16].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 17].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 18].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 19].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 20].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 21].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 22].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 23].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 24].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 25].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 26].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 27].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 28].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 29].Value = f2.dataGridView4[10, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C10
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[100].Value = Convert.ToDouble(row.Cells[98].Value) * Convert.ToDouble(row.Cells[99].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[100].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C10");//revisar bien

                f2.dataGridView3[9, 0].Value = f2.dataGridView1[100, 0].Value;
                f2.dataGridView3[9, 1].Value = f2.dataGridView1[100, 1].Value;
                f2.dataGridView3[9, 2].Value = f2.dataGridView1[100, 2].Value;
                f2.dataGridView3[9, 3].Value = f2.dataGridView1[100, 3].Value;
                f2.dataGridView3[9, 4].Value = f2.dataGridView1[100, 4].Value;
                f2.dataGridView3[9, 5].Value = f2.dataGridView1[100, 5].Value;
                f2.dataGridView3[9, 6].Value = f2.dataGridView1[100, 6].Value;
                f2.dataGridView3[9, 7].Value = f2.dataGridView1[100, 7].Value;
                f2.dataGridView3[9, 8].Value = f2.dataGridView1[100, 8].Value;
                f2.dataGridView3[9, 9].Value = f2.dataGridView1[100, 9].Value;
                f2.dataGridView3[9, 10].Value = f2.dataGridView1[100, 10].Value;
                f2.dataGridView3[9, 11].Value = f2.dataGridView1[100, 11].Value;
                f2.dataGridView3[9, 12].Value = f2.dataGridView1[100, 12].Value;
                f2.dataGridView3[9, 13].Value = f2.dataGridView1[100, 13].Value;
                f2.dataGridView3[9, 14].Value = f2.dataGridView1[100, 14].Value;
                f2.dataGridView3[9, 15].Value = f2.dataGridView1[100, 15].Value;
                f2.dataGridView3[9, 16].Value = f2.dataGridView1[100, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C10");

                f2.dataGridView2[9, 0].Value = f2.dataGridView1[99, 0].Value;
                f2.dataGridView2[9, 1].Value = f2.dataGridView1[99, 1].Value;
                f2.dataGridView2[9, 2].Value = f2.dataGridView1[99, 2].Value;
                f2.dataGridView2[9, 3].Value = f2.dataGridView1[99, 3].Value;
                f2.dataGridView2[9, 4].Value = f2.dataGridView1[99, 4].Value;
                f2.dataGridView2[9, 5].Value = f2.dataGridView1[99, 5].Value;
                f2.dataGridView2[9, 6].Value = f2.dataGridView1[99, 6].Value;
                f2.dataGridView2[9, 7].Value = f2.dataGridView1[99, 7].Value;
                f2.dataGridView2[9, 8].Value = f2.dataGridView1[99, 8].Value;
                f2.dataGridView2[9, 9].Value = f2.dataGridView1[99, 9].Value;
                f2.dataGridView2[9, 10].Value = f2.dataGridView1[99, 10].Value;
                f2.dataGridView2[9, 11].Value = f2.dataGridView1[99, 11].Value;
                f2.dataGridView2[9, 12].Value = f2.dataGridView1[99, 12].Value;
                f2.dataGridView2[9, 13].Value = f2.dataGridView1[99, 13].Value;
                f2.dataGridView2[9, 14].Value = f2.dataGridView1[99, 14].Value;
                f2.dataGridView2[9, 15].Value = f2.dataGridView1[99, 15].Value;
                f2.dataGridView2[9, 16].Value = f2.dataGridView1[99, 16].Value;


            }

            //C10 CRITERIO INVERSO

            if (f2.textBox11.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[10].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[97].Value = DIR; //copia el valor maximo en la columna 51
                                               //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[99].Value = DIR / Convert.ToDouble(row.Cells[10].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[99].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[98, 0].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 1].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 2].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 3].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 4].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 5].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 6].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 7].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 8].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 9].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 10].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 11].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 12].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 13].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 14].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 15].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 16].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 17].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 18].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 19].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 20].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 21].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 22].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 23].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 24].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 25].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 26].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 27].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 28].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[98, 29].Value = f2.dataGridView4[10, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C10
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[100].Value = Convert.ToDouble(row.Cells[98].Value) * Convert.ToDouble(row.Cells[99].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[100].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C10");//revisar bien

                f2.dataGridView3[9, 0].Value = f2.dataGridView1[100, 0].Value;
                f2.dataGridView3[9, 1].Value = f2.dataGridView1[100, 1].Value;
                f2.dataGridView3[9, 2].Value = f2.dataGridView1[100, 2].Value;
                f2.dataGridView3[9, 3].Value = f2.dataGridView1[100, 3].Value;
                f2.dataGridView3[9, 4].Value = f2.dataGridView1[100, 4].Value;
                f2.dataGridView3[9, 5].Value = f2.dataGridView1[100, 5].Value;
                f2.dataGridView3[9, 6].Value = f2.dataGridView1[100, 6].Value;
                f2.dataGridView3[9, 7].Value = f2.dataGridView1[100, 7].Value;
                f2.dataGridView3[9, 8].Value = f2.dataGridView1[100, 8].Value;
                f2.dataGridView3[9, 9].Value = f2.dataGridView1[100, 9].Value;
                f2.dataGridView3[9, 10].Value = f2.dataGridView1[100, 10].Value;
                f2.dataGridView3[9, 11].Value = f2.dataGridView1[100, 11].Value;
                f2.dataGridView3[9, 12].Value = f2.dataGridView1[100, 12].Value;
                f2.dataGridView3[9, 13].Value = f2.dataGridView1[100, 13].Value;
                f2.dataGridView3[9, 14].Value = f2.dataGridView1[100, 14].Value;
                f2.dataGridView3[9, 15].Value = f2.dataGridView1[100, 15].Value;
                f2.dataGridView3[9, 16].Value = f2.dataGridView1[100, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C10");

                f2.dataGridView2[9, 0].Value = f2.dataGridView1[99, 0].Value;
                f2.dataGridView2[9, 1].Value = f2.dataGridView1[99, 1].Value;
                f2.dataGridView2[9, 2].Value = f2.dataGridView1[99, 2].Value;
                f2.dataGridView2[9, 3].Value = f2.dataGridView1[99, 3].Value;
                f2.dataGridView2[9, 4].Value = f2.dataGridView1[99, 4].Value;
                f2.dataGridView2[9, 5].Value = f2.dataGridView1[99, 5].Value;
                f2.dataGridView2[9, 6].Value = f2.dataGridView1[99, 6].Value;
                f2.dataGridView2[9, 7].Value = f2.dataGridView1[99, 7].Value;
                f2.dataGridView2[9, 8].Value = f2.dataGridView1[99, 8].Value;
                f2.dataGridView2[9, 9].Value = f2.dataGridView1[99, 9].Value;
                f2.dataGridView2[9, 10].Value = f2.dataGridView1[99, 10].Value;
                f2.dataGridView2[9, 11].Value = f2.dataGridView1[99, 11].Value;
                f2.dataGridView2[9, 12].Value = f2.dataGridView1[99, 12].Value;
                f2.dataGridView2[9, 13].Value = f2.dataGridView1[99, 13].Value;
                f2.dataGridView2[9, 14].Value = f2.dataGridView1[99, 14].Value;
                f2.dataGridView2[9, 15].Value = f2.dataGridView1[99, 15].Value;
                f2.dataGridView2[9, 16].Value = f2.dataGridView1[99, 16].Value;


            }

            //voy en textbox12
            //C11 CRITERIO DIRECTO

            if (f2.textBox12.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[11].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[11].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[102].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[104].Value = Convert.ToDouble(row.Cells[11].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[104].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[103, 0].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 1].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 2].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 3].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 4].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 5].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 6].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 7].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 8].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 9].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 10].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 11].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 12].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 13].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 14].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 15].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 16].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 17].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 18].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 19].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 20].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 21].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 22].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 23].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 24].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 25].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 26].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 27].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 28].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 29].Value = f2.dataGridView4[11, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C11
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[105].Value = Convert.ToDouble(row.Cells[103].Value) * Convert.ToDouble(row.Cells[104].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[105].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C11");//revisar bien

                f2.dataGridView3[10, 0].Value = f2.dataGridView1[105, 0].Value;
                f2.dataGridView3[10, 1].Value = f2.dataGridView1[105, 1].Value;
                f2.dataGridView3[10, 2].Value = f2.dataGridView1[105, 2].Value;
                f2.dataGridView3[10, 3].Value = f2.dataGridView1[105, 3].Value;
                f2.dataGridView3[10, 4].Value = f2.dataGridView1[105, 4].Value;
                f2.dataGridView3[10, 5].Value = f2.dataGridView1[105, 5].Value;
                f2.dataGridView3[10, 6].Value = f2.dataGridView1[105, 6].Value;
                f2.dataGridView3[10, 7].Value = f2.dataGridView1[105, 7].Value;
                f2.dataGridView3[10, 8].Value = f2.dataGridView1[105, 8].Value;
                f2.dataGridView3[10, 9].Value = f2.dataGridView1[105, 9].Value;
                f2.dataGridView3[10, 10].Value = f2.dataGridView1[105, 10].Value;
                f2.dataGridView3[10, 11].Value = f2.dataGridView1[105, 11].Value;
                f2.dataGridView3[10, 12].Value = f2.dataGridView1[105, 12].Value;
                f2.dataGridView3[10, 13].Value = f2.dataGridView1[105, 13].Value;
                f2.dataGridView3[10, 14].Value = f2.dataGridView1[105, 14].Value;
                f2.dataGridView3[10, 15].Value = f2.dataGridView1[105, 15].Value;
                f2.dataGridView3[10, 16].Value = f2.dataGridView1[105, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C11");

                f2.dataGridView2[10, 0].Value = f2.dataGridView1[104, 0].Value;
                f2.dataGridView2[10, 1].Value = f2.dataGridView1[104, 1].Value;
                f2.dataGridView2[10, 2].Value = f2.dataGridView1[104, 2].Value;
                f2.dataGridView2[10, 3].Value = f2.dataGridView1[104, 3].Value;
                f2.dataGridView2[10, 4].Value = f2.dataGridView1[104, 4].Value;
                f2.dataGridView2[10, 5].Value = f2.dataGridView1[104, 5].Value;
                f2.dataGridView2[10, 6].Value = f2.dataGridView1[104, 6].Value;
                f2.dataGridView2[10, 7].Value = f2.dataGridView1[104, 7].Value;
                f2.dataGridView2[10, 8].Value = f2.dataGridView1[104, 8].Value;
                f2.dataGridView2[10, 9].Value = f2.dataGridView1[104, 9].Value;
                f2.dataGridView2[10, 10].Value = f2.dataGridView1[104, 10].Value;
                f2.dataGridView2[10, 11].Value = f2.dataGridView1[104, 11].Value;
                f2.dataGridView2[10, 12].Value = f2.dataGridView1[104, 12].Value;
                f2.dataGridView2[10, 13].Value = f2.dataGridView1[104, 13].Value;
                f2.dataGridView2[10, 14].Value = f2.dataGridView1[104, 14].Value;
                f2.dataGridView2[10, 15].Value = f2.dataGridView1[104, 15].Value;
                f2.dataGridView2[10, 16].Value = f2.dataGridView1[104, 16].Value;


            }

            //C11 CRITERIO INVERSO

            if (f2.textBox12.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[11].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[11].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[102].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[104].Value = DIR / Convert.ToDouble(row.Cells[11].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[104].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[103, 0].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 1].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 2].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 3].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 4].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 5].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 6].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 7].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 8].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 9].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 10].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 11].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 12].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 13].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 14].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 15].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 16].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 17].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 18].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 19].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 20].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 21].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 22].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 23].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 24].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 25].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 26].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 27].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 28].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[103, 29].Value = f2.dataGridView4[11, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C11
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[105].Value = Convert.ToDouble(row.Cells[103].Value) * Convert.ToDouble(row.Cells[104].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[105].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C11");//revisar bien

                f2.dataGridView3[10, 0].Value = f2.dataGridView1[105, 0].Value;
                f2.dataGridView3[10, 1].Value = f2.dataGridView1[105, 1].Value;
                f2.dataGridView3[10, 2].Value = f2.dataGridView1[105, 2].Value;
                f2.dataGridView3[10, 3].Value = f2.dataGridView1[105, 3].Value;
                f2.dataGridView3[10, 4].Value = f2.dataGridView1[105, 4].Value;
                f2.dataGridView3[10, 5].Value = f2.dataGridView1[105, 5].Value;
                f2.dataGridView3[10, 6].Value = f2.dataGridView1[105, 6].Value;
                f2.dataGridView3[10, 7].Value = f2.dataGridView1[105, 7].Value;
                f2.dataGridView3[10, 8].Value = f2.dataGridView1[105, 8].Value;
                f2.dataGridView3[10, 9].Value = f2.dataGridView1[105, 9].Value;
                f2.dataGridView3[10, 10].Value = f2.dataGridView1[105, 10].Value;
                f2.dataGridView3[10, 11].Value = f2.dataGridView1[105, 11].Value;
                f2.dataGridView3[10, 12].Value = f2.dataGridView1[105, 12].Value;
                f2.dataGridView3[10, 13].Value = f2.dataGridView1[105, 13].Value;
                f2.dataGridView3[10, 14].Value = f2.dataGridView1[105, 14].Value;
                f2.dataGridView3[10, 15].Value = f2.dataGridView1[105, 15].Value;
                f2.dataGridView3[10, 16].Value = f2.dataGridView1[105, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C11");

                f2.dataGridView2[10, 0].Value = f2.dataGridView1[104, 0].Value;
                f2.dataGridView2[10, 1].Value = f2.dataGridView1[104, 1].Value;
                f2.dataGridView2[10, 2].Value = f2.dataGridView1[104, 2].Value;
                f2.dataGridView2[10, 3].Value = f2.dataGridView1[104, 3].Value;
                f2.dataGridView2[10, 4].Value = f2.dataGridView1[104, 4].Value;
                f2.dataGridView2[10, 5].Value = f2.dataGridView1[104, 5].Value;
                f2.dataGridView2[10, 6].Value = f2.dataGridView1[104, 6].Value;
                f2.dataGridView2[10, 7].Value = f2.dataGridView1[104, 7].Value;
                f2.dataGridView2[10, 8].Value = f2.dataGridView1[104, 8].Value;
                f2.dataGridView2[10, 9].Value = f2.dataGridView1[104, 9].Value;
                f2.dataGridView2[10, 10].Value = f2.dataGridView1[104, 10].Value;
                f2.dataGridView2[10, 11].Value = f2.dataGridView1[104, 11].Value;
                f2.dataGridView2[10, 12].Value = f2.dataGridView1[104, 12].Value;
                f2.dataGridView2[10, 13].Value = f2.dataGridView1[104, 13].Value;
                f2.dataGridView2[10, 14].Value = f2.dataGridView1[104, 14].Value;
                f2.dataGridView2[10, 15].Value = f2.dataGridView1[104, 15].Value;
                f2.dataGridView2[10, 16].Value = f2.dataGridView1[104, 16].Value;


            }

            //voy en textbox13
            //C12 CRITERIO DIRECTO

            if (f2.textBox13.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[12].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[12].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[107].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[109].Value = Convert.ToDouble(row.Cells[12].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[109].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[108, 0].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 1].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 2].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 3].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 4].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 5].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 6].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 7].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 8].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 9].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 10].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 11].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 12].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 13].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 14].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 15].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 16].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 17].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 18].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 19].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 20].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 21].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 22].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 23].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 24].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 25].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 26].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 27].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 28].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 29].Value = f2.dataGridView4[12, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C12
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[110].Value = Convert.ToDouble(row.Cells[108].Value) * Convert.ToDouble(row.Cells[109].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[110].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C12");//revisar bien

                f2.dataGridView3[11, 0].Value = f2.dataGridView1[110, 0].Value;
                f2.dataGridView3[11, 1].Value = f2.dataGridView1[110, 1].Value;
                f2.dataGridView3[11, 2].Value = f2.dataGridView1[110, 2].Value;
                f2.dataGridView3[11, 3].Value = f2.dataGridView1[110, 3].Value;
                f2.dataGridView3[11, 4].Value = f2.dataGridView1[110, 4].Value;
                f2.dataGridView3[11, 5].Value = f2.dataGridView1[110, 5].Value;
                f2.dataGridView3[11, 6].Value = f2.dataGridView1[110, 6].Value;
                f2.dataGridView3[11, 7].Value = f2.dataGridView1[110, 7].Value;
                f2.dataGridView3[11, 8].Value = f2.dataGridView1[110, 8].Value;
                f2.dataGridView3[11, 9].Value = f2.dataGridView1[110, 9].Value;
                f2.dataGridView3[11, 10].Value = f2.dataGridView1[110, 10].Value;
                f2.dataGridView3[11, 11].Value = f2.dataGridView1[110, 11].Value;
                f2.dataGridView3[11, 12].Value = f2.dataGridView1[110, 12].Value;
                f2.dataGridView3[11, 13].Value = f2.dataGridView1[110, 13].Value;
                f2.dataGridView3[11, 14].Value = f2.dataGridView1[110, 14].Value;
                f2.dataGridView3[11, 15].Value = f2.dataGridView1[110, 15].Value;
                f2.dataGridView3[11, 16].Value = f2.dataGridView1[110, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C12");

                f2.dataGridView2[11, 0].Value = f2.dataGridView1[109, 0].Value;
                f2.dataGridView2[11, 1].Value = f2.dataGridView1[109, 1].Value;
                f2.dataGridView2[11, 2].Value = f2.dataGridView1[109, 2].Value;
                f2.dataGridView2[11, 3].Value = f2.dataGridView1[109, 3].Value;
                f2.dataGridView2[11, 4].Value = f2.dataGridView1[109, 4].Value;
                f2.dataGridView2[11, 5].Value = f2.dataGridView1[109, 5].Value;
                f2.dataGridView2[11, 6].Value = f2.dataGridView1[109, 6].Value;
                f2.dataGridView2[11, 7].Value = f2.dataGridView1[109, 7].Value;
                f2.dataGridView2[11, 8].Value = f2.dataGridView1[109, 8].Value;
                f2.dataGridView2[11, 9].Value = f2.dataGridView1[109, 9].Value;
                f2.dataGridView2[11, 10].Value = f2.dataGridView1[109, 10].Value;
                f2.dataGridView2[11, 11].Value = f2.dataGridView1[109, 11].Value;
                f2.dataGridView2[11, 12].Value = f2.dataGridView1[109, 12].Value;
                f2.dataGridView2[11, 13].Value = f2.dataGridView1[109, 13].Value;
                f2.dataGridView2[11, 14].Value = f2.dataGridView1[109, 14].Value;
                f2.dataGridView2[11, 15].Value = f2.dataGridView1[109, 15].Value;
                f2.dataGridView2[11, 16].Value = f2.dataGridView1[109, 16].Value;


            }

            //C12 CRITERIO INVERSO

            if (f2.textBox13.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[12].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[12].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[107].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[109].Value = DIR / Convert.ToDouble(row.Cells[12].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[109].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[108, 0].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 1].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 2].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 3].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 4].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 5].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 6].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 7].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 8].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 9].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 10].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 11].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 12].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 13].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 14].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 15].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 16].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 17].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 18].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 19].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 20].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 21].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 22].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 23].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 24].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 25].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 26].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 27].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 28].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[108, 29].Value = f2.dataGridView4[12, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C12
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[110].Value = Convert.ToDouble(row.Cells[108].Value) * Convert.ToDouble(row.Cells[109].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[110].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C12");//revisar bien

                f2.dataGridView3[11, 0].Value = f2.dataGridView1[110, 0].Value;
                f2.dataGridView3[11, 1].Value = f2.dataGridView1[110, 1].Value;
                f2.dataGridView3[11, 2].Value = f2.dataGridView1[110, 2].Value;
                f2.dataGridView3[11, 3].Value = f2.dataGridView1[110, 3].Value;
                f2.dataGridView3[11, 4].Value = f2.dataGridView1[110, 4].Value;
                f2.dataGridView3[11, 5].Value = f2.dataGridView1[110, 5].Value;
                f2.dataGridView3[11, 6].Value = f2.dataGridView1[110, 6].Value;
                f2.dataGridView3[11, 7].Value = f2.dataGridView1[110, 7].Value;
                f2.dataGridView3[11, 8].Value = f2.dataGridView1[110, 8].Value;
                f2.dataGridView3[11, 9].Value = f2.dataGridView1[110, 9].Value;
                f2.dataGridView3[11, 10].Value = f2.dataGridView1[110, 10].Value;
                f2.dataGridView3[11, 11].Value = f2.dataGridView1[110, 11].Value;
                f2.dataGridView3[11, 12].Value = f2.dataGridView1[110, 12].Value;
                f2.dataGridView3[11, 13].Value = f2.dataGridView1[110, 13].Value;
                f2.dataGridView3[11, 14].Value = f2.dataGridView1[110, 14].Value;
                f2.dataGridView3[11, 15].Value = f2.dataGridView1[110, 15].Value;
                f2.dataGridView3[11, 16].Value = f2.dataGridView1[110, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C12");

                f2.dataGridView2[11, 0].Value = f2.dataGridView1[109, 0].Value;
                f2.dataGridView2[11, 1].Value = f2.dataGridView1[109, 1].Value;
                f2.dataGridView2[11, 2].Value = f2.dataGridView1[109, 2].Value;
                f2.dataGridView2[11, 3].Value = f2.dataGridView1[109, 3].Value;
                f2.dataGridView2[11, 4].Value = f2.dataGridView1[109, 4].Value;
                f2.dataGridView2[11, 5].Value = f2.dataGridView1[109, 5].Value;
                f2.dataGridView2[11, 6].Value = f2.dataGridView1[109, 6].Value;
                f2.dataGridView2[11, 7].Value = f2.dataGridView1[109, 7].Value;
                f2.dataGridView2[11, 8].Value = f2.dataGridView1[109, 8].Value;
                f2.dataGridView2[11, 9].Value = f2.dataGridView1[109, 9].Value;
                f2.dataGridView2[11, 10].Value = f2.dataGridView1[109, 10].Value;
                f2.dataGridView2[11, 11].Value = f2.dataGridView1[109, 11].Value;
                f2.dataGridView2[11, 12].Value = f2.dataGridView1[109, 12].Value;
                f2.dataGridView2[11, 13].Value = f2.dataGridView1[109, 13].Value;
                f2.dataGridView2[11, 14].Value = f2.dataGridView1[109, 14].Value;
                f2.dataGridView2[11, 15].Value = f2.dataGridView1[109, 15].Value;
                f2.dataGridView2[11, 16].Value = f2.dataGridView1[109, 16].Value;


            }

            //voy en textbox14
            //C13 CRITERIO DIRECTO

            if (f2.textBox14.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[13].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[13].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[112].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[114].Value = Convert.ToDouble(row.Cells[13].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[114].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[113, 0].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 1].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 2].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 3].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 4].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 5].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 6].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 7].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 8].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 9].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 10].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 11].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 12].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 13].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 14].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 15].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 16].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 17].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 18].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 19].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 20].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 21].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 22].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 23].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 24].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 25].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 26].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 27].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 28].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 29].Value = f2.dataGridView4[13, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C13
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[115].Value = Convert.ToDouble(row.Cells[113].Value) * Convert.ToDouble(row.Cells[114].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[115].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C13");//revisar bien

                f2.dataGridView3[12, 0].Value = f2.dataGridView1[115, 0].Value;
                f2.dataGridView3[12, 1].Value = f2.dataGridView1[115, 1].Value;
                f2.dataGridView3[12, 2].Value = f2.dataGridView1[115, 2].Value;
                f2.dataGridView3[12, 3].Value = f2.dataGridView1[115, 3].Value;
                f2.dataGridView3[12, 4].Value = f2.dataGridView1[115, 4].Value;
                f2.dataGridView3[12, 5].Value = f2.dataGridView1[115, 5].Value;
                f2.dataGridView3[12, 6].Value = f2.dataGridView1[115, 6].Value;
                f2.dataGridView3[12, 7].Value = f2.dataGridView1[115, 7].Value;
                f2.dataGridView3[12, 8].Value = f2.dataGridView1[115, 8].Value;
                f2.dataGridView3[12, 9].Value = f2.dataGridView1[115, 9].Value;
                f2.dataGridView3[12, 10].Value = f2.dataGridView1[115, 10].Value;
                f2.dataGridView3[12, 11].Value = f2.dataGridView1[115, 11].Value;
                f2.dataGridView3[12, 12].Value = f2.dataGridView1[115, 12].Value;
                f2.dataGridView3[12, 13].Value = f2.dataGridView1[115, 13].Value;
                f2.dataGridView3[12, 14].Value = f2.dataGridView1[115, 14].Value;
                f2.dataGridView3[12, 15].Value = f2.dataGridView1[115, 15].Value;
                f2.dataGridView3[12, 16].Value = f2.dataGridView1[115, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C13");

                f2.dataGridView2[12, 0].Value = f2.dataGridView1[114, 0].Value;
                f2.dataGridView2[12, 1].Value = f2.dataGridView1[114, 1].Value;
                f2.dataGridView2[12, 2].Value = f2.dataGridView1[114, 2].Value;
                f2.dataGridView2[12, 3].Value = f2.dataGridView1[114, 3].Value;
                f2.dataGridView2[12, 4].Value = f2.dataGridView1[114, 4].Value;
                f2.dataGridView2[12, 5].Value = f2.dataGridView1[114, 5].Value;
                f2.dataGridView2[12, 6].Value = f2.dataGridView1[114, 6].Value;
                f2.dataGridView2[12, 7].Value = f2.dataGridView1[114, 7].Value;
                f2.dataGridView2[12, 8].Value = f2.dataGridView1[114, 8].Value;
                f2.dataGridView2[12, 9].Value = f2.dataGridView1[114, 9].Value;
                f2.dataGridView2[12, 10].Value = f2.dataGridView1[114, 10].Value;
                f2.dataGridView2[12, 11].Value = f2.dataGridView1[114, 11].Value;
                f2.dataGridView2[12, 12].Value = f2.dataGridView1[114, 12].Value;
                f2.dataGridView2[12, 13].Value = f2.dataGridView1[114, 13].Value;
                f2.dataGridView2[12, 14].Value = f2.dataGridView1[114, 14].Value;
                f2.dataGridView2[12, 15].Value = f2.dataGridView1[114, 15].Value;
                f2.dataGridView2[12, 16].Value = f2.dataGridView1[114, 16].Value;


            }

            //C13 CRITERIO INVERSO

            if (f2.textBox14.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[13].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[13].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[112].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[114].Value = DIR / Convert.ToDouble(row.Cells[13].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[114].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[113, 0].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 1].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 2].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 3].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 4].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 5].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 6].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 7].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 8].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 9].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 10].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 11].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 12].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 13].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 14].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 15].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 16].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 17].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 18].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 19].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 20].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 21].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 22].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 23].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 24].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 25].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 26].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 27].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 28].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[113, 29].Value = f2.dataGridView4[13, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C13
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[115].Value = Convert.ToDouble(row.Cells[113].Value) * Convert.ToDouble(row.Cells[114].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[115].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C13");//revisar bien

                f2.dataGridView3[12, 0].Value = f2.dataGridView1[115, 0].Value;
                f2.dataGridView3[12, 1].Value = f2.dataGridView1[115, 1].Value;
                f2.dataGridView3[12, 2].Value = f2.dataGridView1[115, 2].Value;
                f2.dataGridView3[12, 3].Value = f2.dataGridView1[115, 3].Value;
                f2.dataGridView3[12, 4].Value = f2.dataGridView1[115, 4].Value;
                f2.dataGridView3[12, 5].Value = f2.dataGridView1[115, 5].Value;
                f2.dataGridView3[12, 6].Value = f2.dataGridView1[115, 6].Value;
                f2.dataGridView3[12, 7].Value = f2.dataGridView1[115, 7].Value;
                f2.dataGridView3[12, 8].Value = f2.dataGridView1[115, 8].Value;
                f2.dataGridView3[12, 9].Value = f2.dataGridView1[115, 9].Value;
                f2.dataGridView3[12, 10].Value = f2.dataGridView1[115, 10].Value;
                f2.dataGridView3[12, 11].Value = f2.dataGridView1[115, 11].Value;
                f2.dataGridView3[12, 12].Value = f2.dataGridView1[115, 12].Value;
                f2.dataGridView3[12, 13].Value = f2.dataGridView1[115, 13].Value;
                f2.dataGridView3[12, 14].Value = f2.dataGridView1[115, 14].Value;
                f2.dataGridView3[12, 15].Value = f2.dataGridView1[115, 15].Value;
                f2.dataGridView3[12, 16].Value = f2.dataGridView1[115, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C13");

                f2.dataGridView2[12, 0].Value = f2.dataGridView1[114, 0].Value;
                f2.dataGridView2[12, 1].Value = f2.dataGridView1[114, 1].Value;
                f2.dataGridView2[12, 2].Value = f2.dataGridView1[114, 2].Value;
                f2.dataGridView2[12, 3].Value = f2.dataGridView1[114, 3].Value;
                f2.dataGridView2[12, 4].Value = f2.dataGridView1[114, 4].Value;
                f2.dataGridView2[12, 5].Value = f2.dataGridView1[114, 5].Value;
                f2.dataGridView2[12, 6].Value = f2.dataGridView1[114, 6].Value;
                f2.dataGridView2[12, 7].Value = f2.dataGridView1[114, 7].Value;
                f2.dataGridView2[12, 8].Value = f2.dataGridView1[114, 8].Value;
                f2.dataGridView2[12, 9].Value = f2.dataGridView1[114, 9].Value;
                f2.dataGridView2[12, 10].Value = f2.dataGridView1[114, 10].Value;
                f2.dataGridView2[12, 11].Value = f2.dataGridView1[114, 11].Value;
                f2.dataGridView2[12, 12].Value = f2.dataGridView1[114, 12].Value;
                f2.dataGridView2[12, 13].Value = f2.dataGridView1[114, 13].Value;
                f2.dataGridView2[12, 14].Value = f2.dataGridView1[114, 14].Value;
                f2.dataGridView2[12, 15].Value = f2.dataGridView1[114, 15].Value;
                f2.dataGridView2[12, 16].Value = f2.dataGridView1[114, 16].Value;


            }

            //voy en textbox15
            //C14 CRITERIO DIRECTO

            if (f2.textBox15.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[14].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[14].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[117].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[119].Value = Convert.ToDouble(row.Cells[14].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[119].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[118, 0].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 1].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 2].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 3].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 4].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 5].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 6].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 7].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 8].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 9].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 10].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 11].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 12].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 13].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 14].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 15].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 16].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 17].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 18].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 19].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 20].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 21].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 22].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 23].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 24].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 25].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 26].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 27].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 28].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 29].Value = f2.dataGridView4[14, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C14
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[120].Value = Convert.ToDouble(row.Cells[118].Value) * Convert.ToDouble(row.Cells[119].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[120].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C14");//revisar bien

                f2.dataGridView3[13, 0].Value = f2.dataGridView1[120, 0].Value;
                f2.dataGridView3[13, 1].Value = f2.dataGridView1[120, 1].Value;
                f2.dataGridView3[13, 2].Value = f2.dataGridView1[120, 2].Value;
                f2.dataGridView3[13, 3].Value = f2.dataGridView1[120, 3].Value;
                f2.dataGridView3[13, 4].Value = f2.dataGridView1[120, 4].Value;
                f2.dataGridView3[13, 5].Value = f2.dataGridView1[120, 5].Value;
                f2.dataGridView3[13, 6].Value = f2.dataGridView1[120, 6].Value;
                f2.dataGridView3[13, 7].Value = f2.dataGridView1[120, 7].Value;
                f2.dataGridView3[13, 8].Value = f2.dataGridView1[120, 8].Value;
                f2.dataGridView3[13, 9].Value = f2.dataGridView1[120, 9].Value;
                f2.dataGridView3[13, 10].Value = f2.dataGridView1[120, 10].Value;
                f2.dataGridView3[13, 11].Value = f2.dataGridView1[120, 11].Value;
                f2.dataGridView3[13, 12].Value = f2.dataGridView1[120, 12].Value;
                f2.dataGridView3[13, 13].Value = f2.dataGridView1[120, 13].Value;
                f2.dataGridView3[13, 14].Value = f2.dataGridView1[120, 14].Value;
                f2.dataGridView3[13, 15].Value = f2.dataGridView1[120, 15].Value;
                f2.dataGridView3[13, 16].Value = f2.dataGridView1[120, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C14");

                f2.dataGridView2[13, 0].Value = f2.dataGridView1[119, 0].Value;
                f2.dataGridView2[13, 1].Value = f2.dataGridView1[119, 1].Value;
                f2.dataGridView2[13, 2].Value = f2.dataGridView1[119, 2].Value;
                f2.dataGridView2[13, 3].Value = f2.dataGridView1[119, 3].Value;
                f2.dataGridView2[13, 4].Value = f2.dataGridView1[119, 4].Value;
                f2.dataGridView2[13, 5].Value = f2.dataGridView1[119, 5].Value;
                f2.dataGridView2[13, 6].Value = f2.dataGridView1[119, 6].Value;
                f2.dataGridView2[13, 7].Value = f2.dataGridView1[119, 7].Value;
                f2.dataGridView2[13, 8].Value = f2.dataGridView1[119, 8].Value;
                f2.dataGridView2[13, 9].Value = f2.dataGridView1[119, 9].Value;
                f2.dataGridView2[13, 10].Value = f2.dataGridView1[119, 10].Value;
                f2.dataGridView2[13, 11].Value = f2.dataGridView1[119, 11].Value;
                f2.dataGridView2[13, 12].Value = f2.dataGridView1[119, 12].Value;
                f2.dataGridView2[13, 13].Value = f2.dataGridView1[119, 13].Value;
                f2.dataGridView2[13, 14].Value = f2.dataGridView1[119, 14].Value;
                f2.dataGridView2[13, 15].Value = f2.dataGridView1[119, 15].Value;
                f2.dataGridView2[13, 16].Value = f2.dataGridView1[119, 16].Value;


            }

            //C14 CRITERIO INVERSO

            if (f2.textBox15.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[14].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[14].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[117].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[119].Value = DIR / Convert.ToDouble(row.Cells[14].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[119].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[118, 0].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 1].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 2].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 3].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 4].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 5].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 6].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 7].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 8].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 9].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 10].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 11].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 12].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 13].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 14].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 15].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 16].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 17].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 18].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 19].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 20].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 21].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 22].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 23].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 24].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 25].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 26].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 27].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 28].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[118, 29].Value = f2.dataGridView4[14, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C14
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[120].Value = Convert.ToDouble(row.Cells[118].Value) * Convert.ToDouble(row.Cells[119].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[120].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C14");//revisar bien

                f2.dataGridView3[13, 0].Value = f2.dataGridView1[120, 0].Value;
                f2.dataGridView3[13, 1].Value = f2.dataGridView1[120, 1].Value;
                f2.dataGridView3[13, 2].Value = f2.dataGridView1[120, 2].Value;
                f2.dataGridView3[13, 3].Value = f2.dataGridView1[120, 3].Value;
                f2.dataGridView3[13, 4].Value = f2.dataGridView1[120, 4].Value;
                f2.dataGridView3[13, 5].Value = f2.dataGridView1[120, 5].Value;
                f2.dataGridView3[13, 6].Value = f2.dataGridView1[120, 6].Value;
                f2.dataGridView3[13, 7].Value = f2.dataGridView1[120, 7].Value;
                f2.dataGridView3[13, 8].Value = f2.dataGridView1[120, 8].Value;
                f2.dataGridView3[13, 9].Value = f2.dataGridView1[120, 9].Value;
                f2.dataGridView3[13, 10].Value = f2.dataGridView1[120, 10].Value;
                f2.dataGridView3[13, 11].Value = f2.dataGridView1[120, 11].Value;
                f2.dataGridView3[13, 12].Value = f2.dataGridView1[120, 12].Value;
                f2.dataGridView3[13, 13].Value = f2.dataGridView1[120, 13].Value;
                f2.dataGridView3[13, 14].Value = f2.dataGridView1[120, 14].Value;
                f2.dataGridView3[13, 15].Value = f2.dataGridView1[120, 15].Value;
                f2.dataGridView3[13, 16].Value = f2.dataGridView1[120, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C14");

                f2.dataGridView2[13, 0].Value = f2.dataGridView1[119, 0].Value;
                f2.dataGridView2[13, 1].Value = f2.dataGridView1[119, 1].Value;
                f2.dataGridView2[13, 2].Value = f2.dataGridView1[119, 2].Value;
                f2.dataGridView2[13, 3].Value = f2.dataGridView1[119, 3].Value;
                f2.dataGridView2[13, 4].Value = f2.dataGridView1[119, 4].Value;
                f2.dataGridView2[13, 5].Value = f2.dataGridView1[119, 5].Value;
                f2.dataGridView2[13, 6].Value = f2.dataGridView1[119, 6].Value;
                f2.dataGridView2[13, 7].Value = f2.dataGridView1[119, 7].Value;
                f2.dataGridView2[13, 8].Value = f2.dataGridView1[119, 8].Value;
                f2.dataGridView2[13, 9].Value = f2.dataGridView1[119, 9].Value;
                f2.dataGridView2[13, 10].Value = f2.dataGridView1[119, 10].Value;
                f2.dataGridView2[13, 11].Value = f2.dataGridView1[119, 11].Value;
                f2.dataGridView2[13, 12].Value = f2.dataGridView1[119, 12].Value;
                f2.dataGridView2[13, 13].Value = f2.dataGridView1[119, 13].Value;
                f2.dataGridView2[13, 14].Value = f2.dataGridView1[119, 14].Value;
                f2.dataGridView2[13, 15].Value = f2.dataGridView1[119, 15].Value;
                f2.dataGridView2[13, 16].Value = f2.dataGridView1[119, 16].Value;


            }

            //voy en textbox16
            //C15 CRITERIO DIRECTO

            if (f2.textBox16.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[15].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[15].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[122].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[124].Value = Convert.ToDouble(row.Cells[15].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[124].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[123, 0].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 1].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 2].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 3].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 4].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 5].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 6].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 7].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 8].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 9].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 10].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 11].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 12].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 13].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 14].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 15].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 16].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 17].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 18].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 19].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 20].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 21].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 22].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 23].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 24].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 25].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 26].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 27].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 28].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 29].Value = f2.dataGridView4[15, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C15
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[125].Value = Convert.ToDouble(row.Cells[123].Value) * Convert.ToDouble(row.Cells[124].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[125].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C15");//revisar bien

                f2.dataGridView3[14, 0].Value = f2.dataGridView1[125, 0].Value;
                f2.dataGridView3[14, 1].Value = f2.dataGridView1[125, 1].Value;
                f2.dataGridView3[14, 2].Value = f2.dataGridView1[125, 2].Value;
                f2.dataGridView3[14, 3].Value = f2.dataGridView1[125, 3].Value;
                f2.dataGridView3[14, 4].Value = f2.dataGridView1[125, 4].Value;
                f2.dataGridView3[14, 5].Value = f2.dataGridView1[125, 5].Value;
                f2.dataGridView3[14, 6].Value = f2.dataGridView1[125, 6].Value;
                f2.dataGridView3[14, 7].Value = f2.dataGridView1[125, 7].Value;
                f2.dataGridView3[14, 8].Value = f2.dataGridView1[125, 8].Value;
                f2.dataGridView3[14, 9].Value = f2.dataGridView1[125, 9].Value;
                f2.dataGridView3[14, 10].Value = f2.dataGridView1[125, 10].Value;
                f2.dataGridView3[14, 11].Value = f2.dataGridView1[125, 11].Value;
                f2.dataGridView3[14, 12].Value = f2.dataGridView1[125, 12].Value;
                f2.dataGridView3[14, 13].Value = f2.dataGridView1[125, 13].Value;
                f2.dataGridView3[14, 14].Value = f2.dataGridView1[125, 14].Value;
                f2.dataGridView3[14, 15].Value = f2.dataGridView1[125, 15].Value;
                f2.dataGridView3[14, 16].Value = f2.dataGridView1[125, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C15");

                f2.dataGridView2[14, 0].Value = f2.dataGridView1[124, 0].Value;
                f2.dataGridView2[14, 1].Value = f2.dataGridView1[124, 1].Value;
                f2.dataGridView2[14, 2].Value = f2.dataGridView1[124, 2].Value;
                f2.dataGridView2[14, 3].Value = f2.dataGridView1[124, 3].Value;
                f2.dataGridView2[14, 4].Value = f2.dataGridView1[124, 4].Value;
                f2.dataGridView2[14, 5].Value = f2.dataGridView1[124, 5].Value;
                f2.dataGridView2[14, 6].Value = f2.dataGridView1[124, 6].Value;
                f2.dataGridView2[14, 7].Value = f2.dataGridView1[124, 7].Value;
                f2.dataGridView2[14, 8].Value = f2.dataGridView1[124, 8].Value;
                f2.dataGridView2[14, 9].Value = f2.dataGridView1[124, 9].Value;
                f2.dataGridView2[14, 10].Value = f2.dataGridView1[124, 10].Value;
                f2.dataGridView2[14, 11].Value = f2.dataGridView1[124, 11].Value;
                f2.dataGridView2[14, 12].Value = f2.dataGridView1[124, 12].Value;
                f2.dataGridView2[14, 13].Value = f2.dataGridView1[124, 13].Value;
                f2.dataGridView2[14, 14].Value = f2.dataGridView1[124, 14].Value;
                f2.dataGridView2[14, 15].Value = f2.dataGridView1[124, 15].Value;
                f2.dataGridView2[14, 16].Value = f2.dataGridView1[124, 16].Value;


            }

            //C15 CRITERIO INVERSO

            if (f2.textBox16.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[15].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[15].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[122].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[124].Value = DIR / Convert.ToDouble(row.Cells[15].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView2.Rows.Add(row.Cells[124].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[123, 0].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 1].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 2].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 3].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 4].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 5].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 6].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 7].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 8].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 9].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 10].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 11].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 12].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 13].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 14].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 15].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 16].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 17].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 18].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 19].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 20].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 21].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 22].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 23].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 24].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 25].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 26].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 27].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 28].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[123, 29].Value = f2.dataGridView4[15, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C15
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[125].Value = Convert.ToDouble(row.Cells[123].Value) * Convert.ToDouble(row.Cells[124].Value);

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView3.Rows.Add(row.Cells[125].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView3.Columns.Add("RTWO", "C15");//revisar bien

                f2.dataGridView3[14, 0].Value = f2.dataGridView1[125, 0].Value;
                f2.dataGridView3[14, 1].Value = f2.dataGridView1[125, 1].Value;
                f2.dataGridView3[14, 2].Value = f2.dataGridView1[125, 2].Value;
                f2.dataGridView3[14, 3].Value = f2.dataGridView1[125, 3].Value;
                f2.dataGridView3[14, 4].Value = f2.dataGridView1[125, 4].Value;
                f2.dataGridView3[14, 5].Value = f2.dataGridView1[125, 5].Value;
                f2.dataGridView3[14, 6].Value = f2.dataGridView1[125, 6].Value;
                f2.dataGridView3[14, 7].Value = f2.dataGridView1[125, 7].Value;
                f2.dataGridView3[14, 8].Value = f2.dataGridView1[125, 8].Value;
                f2.dataGridView3[14, 9].Value = f2.dataGridView1[125, 9].Value;
                f2.dataGridView3[14, 10].Value = f2.dataGridView1[125, 10].Value;
                f2.dataGridView3[14, 11].Value = f2.dataGridView1[125, 11].Value;
                f2.dataGridView3[14, 12].Value = f2.dataGridView1[125, 12].Value;
                f2.dataGridView3[14, 13].Value = f2.dataGridView1[125, 13].Value;
                f2.dataGridView3[14, 14].Value = f2.dataGridView1[125, 14].Value;
                f2.dataGridView3[14, 15].Value = f2.dataGridView1[125, 15].Value;
                f2.dataGridView3[14, 16].Value = f2.dataGridView1[125, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView2.Columns.Add("RTWO", "C15");

                f2.dataGridView2[14, 0].Value = f2.dataGridView1[124, 0].Value;
                f2.dataGridView2[14, 1].Value = f2.dataGridView1[124, 1].Value;
                f2.dataGridView2[14, 2].Value = f2.dataGridView1[124, 2].Value;
                f2.dataGridView2[14, 3].Value = f2.dataGridView1[124, 3].Value;
                f2.dataGridView2[14, 4].Value = f2.dataGridView1[124, 4].Value;
                f2.dataGridView2[14, 5].Value = f2.dataGridView1[124, 5].Value;
                f2.dataGridView2[14, 6].Value = f2.dataGridView1[124, 6].Value;
                f2.dataGridView2[14, 7].Value = f2.dataGridView1[124, 7].Value;
                f2.dataGridView2[14, 8].Value = f2.dataGridView1[124, 8].Value;
                f2.dataGridView2[14, 9].Value = f2.dataGridView1[124, 9].Value;
                f2.dataGridView2[14, 10].Value = f2.dataGridView1[124, 10].Value;
                f2.dataGridView2[14, 11].Value = f2.dataGridView1[124, 11].Value;
                f2.dataGridView2[14, 12].Value = f2.dataGridView1[124, 12].Value;
                f2.dataGridView2[14, 13].Value = f2.dataGridView1[124, 13].Value;
                f2.dataGridView2[14, 14].Value = f2.dataGridView1[124, 14].Value;
                f2.dataGridView2[14, 15].Value = f2.dataGridView1[124, 15].Value;
                f2.dataGridView2[14, 16].Value = f2.dataGridView1[124, 16].Value;


            }

            //WPM CRITERIO DIRECTO (WASPAS)
            //C1 
            //DGV5 Y DGV6

            if (f2.textBox2.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[1].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();

                double DIR = columnData.Max();
                //textBox1.Text = DIR.ToString();//HABILITAR (es otra opcion para copiar el valor MAX)


                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[202].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //de DGV1 copiar la 1era columna a la 533 (misma dgv)

                    row.Cells[204].Value = Convert.ToDouble(row.Cells[1].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[204].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[203, 0].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 1].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 2].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 3].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 4].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 5].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 6].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 7].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 8].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 9].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 10].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 11].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 12].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 13].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 14].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 15].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 16].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 17].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 18].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 19].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 20].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 21].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 22].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 23].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 24].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 25].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 26].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 27].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 28].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 29].Value = f2.dataGridView4[1, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO (PENDIENTE PERO CODIGO CORRECTO) Se deberia empezar 30 columnas despues
                //Multiplicar c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    //row.Cells[54].Value = Convert.ToDouble(row.Cells[52].Value) * Convert.ToDouble(row.Cells[53].Value);
                    row.Cells[205].Value = Math.Pow(Convert.ToDouble(row.Cells[204].Value), Convert.ToDouble(row.Cells[203].Value));
                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[205].Value);

            }

            //CRITERIO INVERSO 1ERA COLUMNA (C1) WPM

            if (f2.textBox2.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[1].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[1].FormattedValue)).ToArray();

                double DIR = columnData.Min();


                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    row.Cells[202].Value = DIR; //copia el valor MINIMO en la columna 51

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //de DGV1 copiar la 1era columna a la 533 (misma dgv)

                    row.Cells[204].Value = DIR / Convert.ToDouble(row.Cells[1].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[204].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[203, 0].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 1].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 2].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 3].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 4].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 5].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 6].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 7].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 8].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 9].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 10].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 11].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 12].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 13].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 14].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 15].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 16].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 17].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 18].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 19].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 20].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 21].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 22].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 23].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 24].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 25].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 26].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 27].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 28].Value = f2.dataGridView4[1, 0].Value;
                f2.dataGridView1[203, 29].Value = f2.dataGridView4[1, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO INVERSO
                //Multiplicar c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[205].Value = Math.Pow(Convert.ToDouble(row.Cells[204].Value), Convert.ToDouble(row.Cells[203].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[205].Value);

            }
            ///////////////////
            //CRITERIO DIRECTO 2DA COLUMNA WPM WASPAS
            if (f2.textBox3.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[207].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[209].Value = Convert.ToDouble(row.Cells[2].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[209].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[208, 0].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 1].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 2].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 3].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 4].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 5].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 6].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 7].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 8].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 9].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 10].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 11].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 12].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 13].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 14].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 15].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 16].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 17].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 18].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 19].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 20].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 21].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 22].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 23].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 24].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 25].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 26].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 27].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 28].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 29].Value = f2.dataGridView4[2, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[210].Value = Math.Pow(Convert.ToDouble(row.Cells[209].Value), Convert.ToDouble(row.Cells[208].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[210].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C2");//revisar bien

                f2.dataGridView6[1, 0].Value = f2.dataGridView1[210, 0].Value;
                f2.dataGridView6[1, 1].Value = f2.dataGridView1[210, 1].Value;
                f2.dataGridView6[1, 2].Value = f2.dataGridView1[210, 2].Value;
                f2.dataGridView6[1, 3].Value = f2.dataGridView1[210, 3].Value;
                f2.dataGridView6[1, 4].Value = f2.dataGridView1[210, 4].Value;
                f2.dataGridView6[1, 5].Value = f2.dataGridView1[210, 5].Value;
                f2.dataGridView6[1, 6].Value = f2.dataGridView1[210, 6].Value;
                f2.dataGridView6[1, 7].Value = f2.dataGridView1[210, 7].Value;
                f2.dataGridView6[1, 8].Value = f2.dataGridView1[210, 8].Value;
                f2.dataGridView6[1, 9].Value = f2.dataGridView1[210, 9].Value;
                f2.dataGridView6[1, 10].Value = f2.dataGridView1[210, 10].Value;
                f2.dataGridView6[1, 11].Value = f2.dataGridView1[210, 11].Value;
                f2.dataGridView6[1, 12].Value = f2.dataGridView1[210, 12].Value;
                f2.dataGridView6[1, 13].Value = f2.dataGridView1[210, 13].Value;
                f2.dataGridView6[1, 14].Value = f2.dataGridView1[210, 14].Value;
                f2.dataGridView6[1, 15].Value = f2.dataGridView1[210, 15].Value;
                f2.dataGridView6[1, 16].Value = f2.dataGridView1[210, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C2");

                f2.dataGridView5[1, 0].Value = f2.dataGridView1[209, 0].Value;
                f2.dataGridView5[1, 1].Value = f2.dataGridView1[209, 1].Value;
                f2.dataGridView5[1, 2].Value = f2.dataGridView1[209, 2].Value;
                f2.dataGridView5[1, 3].Value = f2.dataGridView1[209, 3].Value;
                f2.dataGridView5[1, 4].Value = f2.dataGridView1[209, 4].Value;
                f2.dataGridView5[1, 5].Value = f2.dataGridView1[209, 5].Value;
                f2.dataGridView5[1, 6].Value = f2.dataGridView1[209, 6].Value;
                f2.dataGridView5[1, 7].Value = f2.dataGridView1[209, 7].Value;
                f2.dataGridView5[1, 8].Value = f2.dataGridView1[209, 8].Value;
                f2.dataGridView5[1, 9].Value = f2.dataGridView1[209, 9].Value;
                f2.dataGridView5[1, 10].Value = f2.dataGridView1[209, 10].Value;
                f2.dataGridView5[1, 11].Value = f2.dataGridView1[209, 11].Value;
                f2.dataGridView5[1, 12].Value = f2.dataGridView1[209, 12].Value;
                f2.dataGridView5[1, 13].Value = f2.dataGridView1[209, 13].Value;
                f2.dataGridView5[1, 14].Value = f2.dataGridView1[209, 14].Value;
                f2.dataGridView5[1, 15].Value = f2.dataGridView1[209, 15].Value;
                f2.dataGridView5[1, 16].Value = f2.dataGridView1[209, 16].Value;


            }

            //CRITERIO INVERSO 2DA COLUMNA WPM WASPAS
            if (f2.textBox3.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[207].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[209].Value = DIR / Convert.ToDouble(row.Cells[2].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[209].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[208, 0].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 1].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 2].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 3].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 4].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 5].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 6].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 7].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 8].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 9].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 10].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 11].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 12].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 13].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 14].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 15].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 16].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 17].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 18].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 19].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 20].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 21].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 22].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 23].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 24].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 25].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 26].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 27].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 28].Value = f2.dataGridView4[2, 0].Value;
                f2.dataGridView1[208, 29].Value = f2.dataGridView4[2, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[210].Value = Math.Pow(Convert.ToDouble(row.Cells[209].Value), Convert.ToDouble(row.Cells[208].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[210].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C2");//revisar bien

                f2.dataGridView6[1, 0].Value = f2.dataGridView1[210, 0].Value;
                f2.dataGridView6[1, 1].Value = f2.dataGridView1[210, 1].Value;
                f2.dataGridView6[1, 2].Value = f2.dataGridView1[210, 2].Value;
                f2.dataGridView6[1, 3].Value = f2.dataGridView1[210, 3].Value;
                f2.dataGridView6[1, 4].Value = f2.dataGridView1[210, 4].Value;
                f2.dataGridView6[1, 5].Value = f2.dataGridView1[210, 5].Value;
                f2.dataGridView6[1, 6].Value = f2.dataGridView1[210, 6].Value;
                f2.dataGridView6[1, 7].Value = f2.dataGridView1[210, 7].Value;
                f2.dataGridView6[1, 8].Value = f2.dataGridView1[210, 8].Value;
                f2.dataGridView6[1, 9].Value = f2.dataGridView1[210, 9].Value;
                f2.dataGridView6[1, 10].Value = f2.dataGridView1[210, 10].Value;
                f2.dataGridView6[1, 11].Value = f2.dataGridView1[210, 11].Value;
                f2.dataGridView6[1, 12].Value = f2.dataGridView1[210, 12].Value;
                f2.dataGridView6[1, 13].Value = f2.dataGridView1[210, 13].Value;
                f2.dataGridView6[1, 14].Value = f2.dataGridView1[210, 14].Value;
                f2.dataGridView6[1, 15].Value = f2.dataGridView1[210, 15].Value;
                f2.dataGridView6[1, 16].Value = f2.dataGridView1[210, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C2");

                f2.dataGridView5[1, 0].Value = f2.dataGridView1[209, 0].Value;
                f2.dataGridView5[1, 1].Value = f2.dataGridView1[209, 1].Value;
                f2.dataGridView5[1, 2].Value = f2.dataGridView1[209, 2].Value;
                f2.dataGridView5[1, 3].Value = f2.dataGridView1[209, 3].Value;
                f2.dataGridView5[1, 4].Value = f2.dataGridView1[209, 4].Value;
                f2.dataGridView5[1, 5].Value = f2.dataGridView1[209, 5].Value;
                f2.dataGridView5[1, 6].Value = f2.dataGridView1[209, 6].Value;
                f2.dataGridView5[1, 7].Value = f2.dataGridView1[209, 7].Value;
                f2.dataGridView5[1, 8].Value = f2.dataGridView1[209, 8].Value;
                f2.dataGridView5[1, 9].Value = f2.dataGridView1[209, 9].Value;
                f2.dataGridView5[1, 10].Value = f2.dataGridView1[209, 10].Value;
                f2.dataGridView5[1, 11].Value = f2.dataGridView1[209, 11].Value;
                f2.dataGridView5[1, 12].Value = f2.dataGridView1[209, 12].Value;
                f2.dataGridView5[1, 13].Value = f2.dataGridView1[209, 13].Value;
                f2.dataGridView5[1, 14].Value = f2.dataGridView1[209, 14].Value;
                f2.dataGridView5[1, 15].Value = f2.dataGridView1[209, 15].Value;
                f2.dataGridView5[1, 16].Value = f2.dataGridView1[209, 16].Value;


            }

            //sigue C3 WPM WASPAS (212-215)

            if (f2.textBox4.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[212].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[214].Value = Convert.ToDouble(row.Cells[3].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[214].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[213, 0].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 1].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 2].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 3].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 4].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 5].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 6].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 7].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 8].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 9].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 10].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 11].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 12].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 13].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 14].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 15].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 16].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 17].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 18].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 19].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 20].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 21].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 22].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 23].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 24].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 25].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 26].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 27].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 28].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 29].Value = f2.dataGridView4[3, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[215].Value = Math.Pow(Convert.ToDouble(row.Cells[214].Value), Convert.ToDouble(row.Cells[213].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[215].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C3");//revisar bien

                f2.dataGridView6[2, 0].Value = f2.dataGridView1[215, 0].Value;
                f2.dataGridView6[2, 1].Value = f2.dataGridView1[215, 1].Value;
                f2.dataGridView6[2, 2].Value = f2.dataGridView1[215, 2].Value;
                f2.dataGridView6[2, 3].Value = f2.dataGridView1[215, 3].Value;
                f2.dataGridView6[2, 4].Value = f2.dataGridView1[215, 4].Value;
                f2.dataGridView6[2, 5].Value = f2.dataGridView1[215, 5].Value;
                f2.dataGridView6[2, 6].Value = f2.dataGridView1[215, 6].Value;
                f2.dataGridView6[2, 7].Value = f2.dataGridView1[215, 7].Value;
                f2.dataGridView6[2, 8].Value = f2.dataGridView1[215, 8].Value;
                f2.dataGridView6[2, 9].Value = f2.dataGridView1[215, 9].Value;
                f2.dataGridView6[2, 10].Value = f2.dataGridView1[215, 10].Value;
                f2.dataGridView6[2, 11].Value = f2.dataGridView1[215, 11].Value;
                f2.dataGridView6[2, 12].Value = f2.dataGridView1[215, 12].Value;
                f2.dataGridView6[2, 13].Value = f2.dataGridView1[215, 13].Value;
                f2.dataGridView6[2, 14].Value = f2.dataGridView1[215, 14].Value;
                f2.dataGridView6[2, 15].Value = f2.dataGridView1[215, 15].Value;
                f2.dataGridView6[2, 16].Value = f2.dataGridView1[215, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C3");

                f2.dataGridView5[2, 0].Value = f2.dataGridView1[214, 0].Value;
                f2.dataGridView5[2, 1].Value = f2.dataGridView1[214, 1].Value;
                f2.dataGridView5[2, 2].Value = f2.dataGridView1[214, 2].Value;
                f2.dataGridView5[2, 3].Value = f2.dataGridView1[214, 3].Value;
                f2.dataGridView5[2, 4].Value = f2.dataGridView1[214, 4].Value;
                f2.dataGridView5[2, 5].Value = f2.dataGridView1[214, 5].Value;
                f2.dataGridView5[2, 6].Value = f2.dataGridView1[214, 6].Value;
                f2.dataGridView5[2, 7].Value = f2.dataGridView1[214, 7].Value;
                f2.dataGridView5[2, 8].Value = f2.dataGridView1[214, 8].Value;
                f2.dataGridView5[2, 9].Value = f2.dataGridView1[214, 9].Value;
                f2.dataGridView5[2, 10].Value = f2.dataGridView1[214, 10].Value;
                f2.dataGridView5[2, 11].Value = f2.dataGridView1[214, 11].Value;
                f2.dataGridView5[2, 12].Value = f2.dataGridView1[214, 12].Value;
                f2.dataGridView5[2, 13].Value = f2.dataGridView1[214, 13].Value;
                f2.dataGridView5[2, 14].Value = f2.dataGridView1[214, 14].Value;
                f2.dataGridView5[2, 15].Value = f2.dataGridView1[214, 15].Value;
                f2.dataGridView5[2, 16].Value = f2.dataGridView1[214, 16].Value;


            }

            //CRITERIO INVERSO C3 WPM WASPAS
            if (f2.textBox4.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[212].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[214].Value = DIR / Convert.ToDouble(row.Cells[3].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[214].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido


                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[213, 0].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 1].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 2].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 3].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 4].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 5].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 6].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 7].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 8].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 9].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 10].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 11].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 12].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 13].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 14].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 15].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 16].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 17].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 18].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 19].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 20].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 21].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 22].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 23].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 24].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 25].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 26].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 27].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 28].Value = f2.dataGridView4[3, 0].Value;
                f2.dataGridView1[213, 29].Value = f2.dataGridView4[3, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[215].Value = Math.Pow(Convert.ToDouble(row.Cells[214].Value), Convert.ToDouble(row.Cells[213].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[215].Value);


                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C3");//revisar bien

                f2.dataGridView6[2, 0].Value = f2.dataGridView1[215, 0].Value;
                f2.dataGridView6[2, 1].Value = f2.dataGridView1[215, 1].Value;
                f2.dataGridView6[2, 2].Value = f2.dataGridView1[215, 2].Value;
                f2.dataGridView6[2, 3].Value = f2.dataGridView1[215, 3].Value;
                f2.dataGridView6[2, 4].Value = f2.dataGridView1[215, 4].Value;
                f2.dataGridView6[2, 5].Value = f2.dataGridView1[215, 5].Value;
                f2.dataGridView6[2, 6].Value = f2.dataGridView1[215, 6].Value;
                f2.dataGridView6[2, 7].Value = f2.dataGridView1[215, 7].Value;
                f2.dataGridView6[2, 8].Value = f2.dataGridView1[215, 8].Value;
                f2.dataGridView6[2, 9].Value = f2.dataGridView1[215, 9].Value;
                f2.dataGridView6[2, 10].Value = f2.dataGridView1[215, 10].Value;
                f2.dataGridView6[2, 11].Value = f2.dataGridView1[215, 11].Value;
                f2.dataGridView6[2, 12].Value = f2.dataGridView1[215, 12].Value;
                f2.dataGridView6[2, 13].Value = f2.dataGridView1[215, 13].Value;
                f2.dataGridView6[2, 14].Value = f2.dataGridView1[215, 14].Value;
                f2.dataGridView6[2, 15].Value = f2.dataGridView1[215, 15].Value;
                f2.dataGridView6[2, 16].Value = f2.dataGridView1[215, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C3");

                f2.dataGridView5[2, 0].Value = f2.dataGridView1[214, 0].Value;
                f2.dataGridView5[2, 1].Value = f2.dataGridView1[214, 1].Value;
                f2.dataGridView5[2, 2].Value = f2.dataGridView1[214, 2].Value;
                f2.dataGridView5[2, 3].Value = f2.dataGridView1[214, 3].Value;
                f2.dataGridView5[2, 4].Value = f2.dataGridView1[214, 4].Value;
                f2.dataGridView5[2, 5].Value = f2.dataGridView1[214, 5].Value;
                f2.dataGridView5[2, 6].Value = f2.dataGridView1[214, 6].Value;
                f2.dataGridView5[2, 7].Value = f2.dataGridView1[214, 7].Value;
                f2.dataGridView5[2, 8].Value = f2.dataGridView1[214, 8].Value;
                f2.dataGridView5[2, 9].Value = f2.dataGridView1[214, 9].Value;
                f2.dataGridView5[2, 10].Value = f2.dataGridView1[214, 10].Value;
                f2.dataGridView5[2, 11].Value = f2.dataGridView1[214, 11].Value;
                f2.dataGridView5[2, 12].Value = f2.dataGridView1[214, 12].Value;
                f2.dataGridView5[2, 13].Value = f2.dataGridView1[214, 13].Value;
                f2.dataGridView5[2, 14].Value = f2.dataGridView1[214, 14].Value;
                f2.dataGridView5[2, 15].Value = f2.dataGridView1[214, 15].Value;
                f2.dataGridView5[2, 16].Value = f2.dataGridView1[214, 16].Value;


            }

            //C4 CRITERIO DIRECTO WPM WASPAS

            if (f2.textBox5.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[4].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[217].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[219].Value = Convert.ToDouble(row.Cells[4].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[219].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[218, 0].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 1].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 2].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 3].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 4].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 5].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 6].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 7].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 8].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 9].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 10].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 11].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 12].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 13].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 14].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 15].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 16].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 17].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 18].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 19].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 20].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 21].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 22].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 23].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 24].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 25].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 26].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 27].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 28].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 29].Value = f2.dataGridView4[4, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[220].Value = Math.Pow(Convert.ToDouble(row.Cells[219].Value), Convert.ToDouble(row.Cells[218].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[220].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C4");//revisar bien

                f2.dataGridView6[3, 0].Value = f2.dataGridView1[220, 0].Value;
                f2.dataGridView6[3, 1].Value = f2.dataGridView1[220, 1].Value;
                f2.dataGridView6[3, 2].Value = f2.dataGridView1[220, 2].Value;
                f2.dataGridView6[3, 3].Value = f2.dataGridView1[220, 3].Value;
                f2.dataGridView6[3, 4].Value = f2.dataGridView1[220, 4].Value;
                f2.dataGridView6[3, 5].Value = f2.dataGridView1[220, 5].Value;
                f2.dataGridView6[3, 6].Value = f2.dataGridView1[220, 6].Value;
                f2.dataGridView6[3, 7].Value = f2.dataGridView1[220, 7].Value;
                f2.dataGridView6[3, 8].Value = f2.dataGridView1[220, 8].Value;
                f2.dataGridView6[3, 9].Value = f2.dataGridView1[220, 9].Value;
                f2.dataGridView6[3, 10].Value = f2.dataGridView1[220, 10].Value;
                f2.dataGridView6[3, 11].Value = f2.dataGridView1[220, 11].Value;
                f2.dataGridView6[3, 12].Value = f2.dataGridView1[220, 12].Value;
                f2.dataGridView6[3, 13].Value = f2.dataGridView1[220, 13].Value;
                f2.dataGridView6[3, 14].Value = f2.dataGridView1[220, 14].Value;
                f2.dataGridView6[3, 15].Value = f2.dataGridView1[220, 15].Value;
                f2.dataGridView6[3, 16].Value = f2.dataGridView1[220, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C4");

                f2.dataGridView5[3, 0].Value = f2.dataGridView1[219, 0].Value;
                f2.dataGridView5[3, 1].Value = f2.dataGridView1[219, 1].Value;
                f2.dataGridView5[3, 2].Value = f2.dataGridView1[219, 2].Value;
                f2.dataGridView5[3, 3].Value = f2.dataGridView1[219, 3].Value;
                f2.dataGridView5[3, 4].Value = f2.dataGridView1[219, 4].Value;
                f2.dataGridView5[3, 5].Value = f2.dataGridView1[219, 5].Value;
                f2.dataGridView5[3, 6].Value = f2.dataGridView1[219, 6].Value;
                f2.dataGridView5[3, 7].Value = f2.dataGridView1[219, 7].Value;
                f2.dataGridView5[3, 8].Value = f2.dataGridView1[219, 8].Value;
                f2.dataGridView5[3, 9].Value = f2.dataGridView1[219, 9].Value;
                f2.dataGridView5[3, 10].Value = f2.dataGridView1[219, 10].Value;
                f2.dataGridView5[3, 11].Value = f2.dataGridView1[219, 11].Value;
                f2.dataGridView5[3, 12].Value = f2.dataGridView1[219, 12].Value;
                f2.dataGridView5[3, 13].Value = f2.dataGridView1[219, 13].Value;
                f2.dataGridView5[3, 14].Value = f2.dataGridView1[219, 14].Value;
                f2.dataGridView5[3, 15].Value = f2.dataGridView1[219, 15].Value;
                f2.dataGridView5[3, 16].Value = f2.dataGridView1[219, 16].Value;


            }

            //CRITERIO INVERSO C4 WPM WASPAS
            if (f2.textBox5.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[4].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[217].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[219].Value = DIR / Convert.ToDouble(row.Cells[4].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[219].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido


                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[218, 0].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 1].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 2].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 3].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 4].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 5].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 6].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 7].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 8].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 9].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 10].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 11].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 12].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 13].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 14].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 15].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 16].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 17].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 18].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 19].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 20].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 21].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 22].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 23].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 24].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 25].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 26].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 27].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 28].Value = f2.dataGridView4[4, 0].Value;
                f2.dataGridView1[218, 29].Value = f2.dataGridView4[4, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[220].Value = Math.Pow(Convert.ToDouble(row.Cells[219].Value), Convert.ToDouble(row.Cells[218].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[220].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C4");//revisar bien

                f2.dataGridView6[3, 0].Value = f2.dataGridView1[220, 0].Value;
                f2.dataGridView6[3, 1].Value = f2.dataGridView1[220, 1].Value;
                f2.dataGridView6[3, 2].Value = f2.dataGridView1[220, 2].Value;
                f2.dataGridView6[3, 3].Value = f2.dataGridView1[220, 3].Value;
                f2.dataGridView6[3, 4].Value = f2.dataGridView1[220, 4].Value;
                f2.dataGridView6[3, 5].Value = f2.dataGridView1[220, 5].Value;
                f2.dataGridView6[3, 6].Value = f2.dataGridView1[220, 6].Value;
                f2.dataGridView6[3, 7].Value = f2.dataGridView1[220, 7].Value;
                f2.dataGridView6[3, 8].Value = f2.dataGridView1[220, 8].Value;
                f2.dataGridView6[3, 9].Value = f2.dataGridView1[220, 9].Value;
                f2.dataGridView6[3, 10].Value = f2.dataGridView1[220, 10].Value;
                f2.dataGridView6[3, 11].Value = f2.dataGridView1[220, 11].Value;
                f2.dataGridView6[3, 12].Value = f2.dataGridView1[220, 12].Value;
                f2.dataGridView6[3, 13].Value = f2.dataGridView1[220, 13].Value;
                f2.dataGridView6[3, 14].Value = f2.dataGridView1[220, 14].Value;
                f2.dataGridView6[3, 15].Value = f2.dataGridView1[220, 15].Value;
                f2.dataGridView6[3, 16].Value = f2.dataGridView1[220, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C4");

                f2.dataGridView5[3, 0].Value = f2.dataGridView1[219, 0].Value;
                f2.dataGridView5[3, 1].Value = f2.dataGridView1[219, 1].Value;
                f2.dataGridView5[3, 2].Value = f2.dataGridView1[219, 2].Value;
                f2.dataGridView5[3, 3].Value = f2.dataGridView1[219, 3].Value;
                f2.dataGridView5[3, 4].Value = f2.dataGridView1[219, 4].Value;
                f2.dataGridView5[3, 5].Value = f2.dataGridView1[219, 5].Value;
                f2.dataGridView5[3, 6].Value = f2.dataGridView1[219, 6].Value;
                f2.dataGridView5[3, 7].Value = f2.dataGridView1[219, 7].Value;
                f2.dataGridView5[3, 8].Value = f2.dataGridView1[219, 8].Value;
                f2.dataGridView5[3, 9].Value = f2.dataGridView1[219, 9].Value;
                f2.dataGridView5[3, 10].Value = f2.dataGridView1[219, 10].Value;
                f2.dataGridView5[3, 11].Value = f2.dataGridView1[219, 11].Value;
                f2.dataGridView5[3, 12].Value = f2.dataGridView1[219, 12].Value;
                f2.dataGridView5[3, 13].Value = f2.dataGridView1[219, 13].Value;
                f2.dataGridView5[3, 14].Value = f2.dataGridView1[219, 14].Value;
                f2.dataGridView5[3, 15].Value = f2.dataGridView1[219, 15].Value;
                f2.dataGridView5[3, 16].Value = f2.dataGridView1[219, 16].Value;

            }

            //SIGUE C5 WPM WASPAS
            //textbox6

            if (f2.textBox6.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[222].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[224].Value = Convert.ToDouble(row.Cells[5].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[224].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[223, 0].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 1].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 2].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 3].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 4].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 5].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 6].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 7].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 8].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 9].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 10].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 11].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 12].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 13].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 14].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 15].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 16].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 17].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 18].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 19].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 20].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 21].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 22].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 23].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 24].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 25].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 26].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 27].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 28].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 29].Value = f2.dataGridView4[5, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[225].Value = Math.Pow(Convert.ToDouble(row.Cells[224].Value), Convert.ToDouble(row.Cells[223].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[225].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C5");//revisar bien

                f2.dataGridView6[4, 0].Value = f2.dataGridView1[225, 0].Value;
                f2.dataGridView6[4, 1].Value = f2.dataGridView1[225, 1].Value;
                f2.dataGridView6[4, 2].Value = f2.dataGridView1[225, 2].Value;
                f2.dataGridView6[4, 3].Value = f2.dataGridView1[225, 3].Value;
                f2.dataGridView6[4, 4].Value = f2.dataGridView1[225, 4].Value;
                f2.dataGridView6[4, 5].Value = f2.dataGridView1[225, 5].Value;
                f2.dataGridView6[4, 6].Value = f2.dataGridView1[225, 6].Value;
                f2.dataGridView6[4, 7].Value = f2.dataGridView1[225, 7].Value;
                f2.dataGridView6[4, 8].Value = f2.dataGridView1[225, 8].Value;
                f2.dataGridView6[4, 9].Value = f2.dataGridView1[225, 9].Value;
                f2.dataGridView6[4, 10].Value = f2.dataGridView1[225, 10].Value;
                f2.dataGridView6[4, 11].Value = f2.dataGridView1[225, 11].Value;
                f2.dataGridView6[4, 12].Value = f2.dataGridView1[225, 12].Value;
                f2.dataGridView6[4, 13].Value = f2.dataGridView1[225, 13].Value;
                f2.dataGridView6[4, 14].Value = f2.dataGridView1[225, 14].Value;
                f2.dataGridView6[4, 15].Value = f2.dataGridView1[225, 15].Value;
                f2.dataGridView6[4, 16].Value = f2.dataGridView1[225, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C5");

                f2.dataGridView5[4, 0].Value = f2.dataGridView1[224, 0].Value;
                f2.dataGridView5[4, 1].Value = f2.dataGridView1[224, 1].Value;
                f2.dataGridView5[4, 2].Value = f2.dataGridView1[224, 2].Value;
                f2.dataGridView5[4, 3].Value = f2.dataGridView1[224, 3].Value;
                f2.dataGridView5[4, 4].Value = f2.dataGridView1[224, 4].Value;
                f2.dataGridView5[4, 5].Value = f2.dataGridView1[224, 5].Value;
                f2.dataGridView5[4, 6].Value = f2.dataGridView1[224, 6].Value;
                f2.dataGridView5[4, 7].Value = f2.dataGridView1[224, 7].Value;
                f2.dataGridView5[4, 8].Value = f2.dataGridView1[224, 8].Value;
                f2.dataGridView5[4, 9].Value = f2.dataGridView1[224, 9].Value;
                f2.dataGridView5[4, 10].Value = f2.dataGridView1[224, 10].Value;
                f2.dataGridView5[4, 11].Value = f2.dataGridView1[224, 11].Value;
                f2.dataGridView5[4, 12].Value = f2.dataGridView1[224, 12].Value;
                f2.dataGridView5[4, 13].Value = f2.dataGridView1[224, 13].Value;
                f2.dataGridView5[4, 14].Value = f2.dataGridView1[224, 14].Value;
                f2.dataGridView5[4, 15].Value = f2.dataGridView1[224, 15].Value;
                f2.dataGridView5[4, 16].Value = f2.dataGridView1[224, 16].Value;


            }

            //CRITERIO INVERSO C5 WPM WASPAS
            if (f2.textBox6.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[5].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[222].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[224].Value = DIR / Convert.ToDouble(row.Cells[5].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[224].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[223, 0].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 1].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 2].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 3].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 4].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 5].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 6].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 7].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 8].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 9].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 10].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 11].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 12].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 13].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 14].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 15].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 16].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 17].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 18].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 19].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 20].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 21].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 22].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 23].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 24].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 25].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 26].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 27].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 28].Value = f2.dataGridView4[5, 0].Value;
                f2.dataGridView1[223, 29].Value = f2.dataGridView4[5, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[225].Value = Math.Pow(Convert.ToDouble(row.Cells[224].Value), Convert.ToDouble(row.Cells[223].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[225].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C5");//revisar bien

                f2.dataGridView6[4, 0].Value = f2.dataGridView1[225, 0].Value;
                f2.dataGridView6[4, 1].Value = f2.dataGridView1[225, 1].Value;
                f2.dataGridView6[4, 2].Value = f2.dataGridView1[225, 2].Value;
                f2.dataGridView6[4, 3].Value = f2.dataGridView1[225, 3].Value;
                f2.dataGridView6[4, 4].Value = f2.dataGridView1[225, 4].Value;
                f2.dataGridView6[4, 5].Value = f2.dataGridView1[225, 5].Value;
                f2.dataGridView6[4, 6].Value = f2.dataGridView1[225, 6].Value;
                f2.dataGridView6[4, 7].Value = f2.dataGridView1[225, 7].Value;
                f2.dataGridView6[4, 8].Value = f2.dataGridView1[225, 8].Value;
                f2.dataGridView6[4, 9].Value = f2.dataGridView1[225, 9].Value;
                f2.dataGridView6[4, 10].Value = f2.dataGridView1[225, 10].Value;
                f2.dataGridView6[4, 11].Value = f2.dataGridView1[225, 11].Value;
                f2.dataGridView6[4, 12].Value = f2.dataGridView1[225, 12].Value;
                f2.dataGridView6[4, 13].Value = f2.dataGridView1[225, 13].Value;
                f2.dataGridView6[4, 14].Value = f2.dataGridView1[225, 14].Value;
                f2.dataGridView6[4, 15].Value = f2.dataGridView1[225, 15].Value;
                f2.dataGridView6[4, 16].Value = f2.dataGridView1[225, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C5");

                f2.dataGridView5[4, 0].Value = f2.dataGridView1[224, 0].Value;
                f2.dataGridView5[4, 1].Value = f2.dataGridView1[224, 1].Value;
                f2.dataGridView5[4, 2].Value = f2.dataGridView1[224, 2].Value;
                f2.dataGridView5[4, 3].Value = f2.dataGridView1[224, 3].Value;
                f2.dataGridView5[4, 4].Value = f2.dataGridView1[224, 4].Value;
                f2.dataGridView5[4, 5].Value = f2.dataGridView1[224, 5].Value;
                f2.dataGridView5[4, 6].Value = f2.dataGridView1[224, 6].Value;
                f2.dataGridView5[4, 7].Value = f2.dataGridView1[224, 7].Value;
                f2.dataGridView5[4, 8].Value = f2.dataGridView1[224, 8].Value;
                f2.dataGridView5[4, 9].Value = f2.dataGridView1[224, 9].Value;
                f2.dataGridView5[4, 10].Value = f2.dataGridView1[224, 10].Value;
                f2.dataGridView5[4, 11].Value = f2.dataGridView1[224, 11].Value;
                f2.dataGridView5[4, 12].Value = f2.dataGridView1[224, 12].Value;
                f2.dataGridView5[4, 13].Value = f2.dataGridView1[224, 13].Value;
                f2.dataGridView5[4, 14].Value = f2.dataGridView1[224, 14].Value;
                f2.dataGridView5[4, 15].Value = f2.dataGridView1[224, 15].Value;
                f2.dataGridView5[4, 16].Value = f2.dataGridView1[224, 16].Value;

            }

            //C6 WPM WASPAS, 227 - 230

            if (f2.textBox7.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[227].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[229].Value = Convert.ToDouble(row.Cells[6].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[229].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[228, 0].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 1].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 2].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 3].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 4].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 5].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 6].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 7].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 8].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 9].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 10].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 11].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 12].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 13].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 14].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 15].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 16].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 17].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 18].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 19].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 20].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 21].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 22].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 23].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 24].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 25].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 26].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 27].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 28].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 29].Value = f2.dataGridView4[6, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[230].Value = Math.Pow(Convert.ToDouble(row.Cells[229].Value), Convert.ToDouble(row.Cells[228].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[230].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C6");//revisar bien

                f2.dataGridView6[5, 0].Value = f2.dataGridView1[230, 0].Value;
                f2.dataGridView6[5, 1].Value = f2.dataGridView1[230, 1].Value;
                f2.dataGridView6[5, 2].Value = f2.dataGridView1[230, 2].Value;
                f2.dataGridView6[5, 3].Value = f2.dataGridView1[230, 3].Value;
                f2.dataGridView6[5, 4].Value = f2.dataGridView1[230, 4].Value;
                f2.dataGridView6[5, 5].Value = f2.dataGridView1[230, 5].Value;
                f2.dataGridView6[5, 6].Value = f2.dataGridView1[230, 6].Value;
                f2.dataGridView6[5, 7].Value = f2.dataGridView1[230, 7].Value;
                f2.dataGridView6[5, 8].Value = f2.dataGridView1[230, 8].Value;
                f2.dataGridView6[5, 9].Value = f2.dataGridView1[230, 9].Value;
                f2.dataGridView6[5, 10].Value = f2.dataGridView1[230, 10].Value;
                f2.dataGridView6[5, 11].Value = f2.dataGridView1[230, 11].Value;
                f2.dataGridView6[5, 12].Value = f2.dataGridView1[230, 12].Value;
                f2.dataGridView6[5, 13].Value = f2.dataGridView1[230, 13].Value;
                f2.dataGridView6[5, 14].Value = f2.dataGridView1[230, 14].Value;
                f2.dataGridView6[5, 15].Value = f2.dataGridView1[230, 15].Value;
                f2.dataGridView6[5, 16].Value = f2.dataGridView1[230, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C6");

                f2.dataGridView5[5, 0].Value = f2.dataGridView1[229, 0].Value;
                f2.dataGridView5[5, 1].Value = f2.dataGridView1[229, 1].Value;
                f2.dataGridView5[5, 2].Value = f2.dataGridView1[229, 2].Value;
                f2.dataGridView5[5, 3].Value = f2.dataGridView1[229, 3].Value;
                f2.dataGridView5[5, 4].Value = f2.dataGridView1[229, 4].Value;
                f2.dataGridView5[5, 5].Value = f2.dataGridView1[229, 5].Value;
                f2.dataGridView5[5, 6].Value = f2.dataGridView1[229, 6].Value;
                f2.dataGridView5[5, 7].Value = f2.dataGridView1[229, 7].Value;
                f2.dataGridView5[5, 8].Value = f2.dataGridView1[229, 8].Value;
                f2.dataGridView5[5, 9].Value = f2.dataGridView1[229, 9].Value;
                f2.dataGridView5[5, 10].Value = f2.dataGridView1[229, 10].Value;
                f2.dataGridView5[5, 11].Value = f2.dataGridView1[229, 11].Value;
                f2.dataGridView5[5, 12].Value = f2.dataGridView1[229, 12].Value;
                f2.dataGridView5[5, 13].Value = f2.dataGridView1[229, 13].Value;
                f2.dataGridView5[5, 14].Value = f2.dataGridView1[229, 14].Value;
                f2.dataGridView5[5, 15].Value = f2.dataGridView1[229, 15].Value;
                f2.dataGridView5[5, 16].Value = f2.dataGridView1[229, 16].Value;


            }

            //CRITERIO INVERSO C6 WPM WASPAS
            if (f2.textBox7.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[227].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[229].Value = DIR / Convert.ToDouble(row.Cells[6].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[229].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[228, 0].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 1].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 2].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 3].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 4].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 5].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 6].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 7].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 8].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 9].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 10].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 11].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 12].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 13].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 14].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 15].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 16].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 17].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 18].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 19].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 20].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 21].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 22].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 23].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 24].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 25].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 26].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 27].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 28].Value = f2.dataGridView4[6, 0].Value;
                f2.dataGridView1[228, 29].Value = f2.dataGridView4[6, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[230].Value = Math.Pow(Convert.ToDouble(row.Cells[229].Value), Convert.ToDouble(row.Cells[228].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[230].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C6");//revisar bien

                f2.dataGridView6[5, 0].Value = f2.dataGridView1[230, 0].Value;
                f2.dataGridView6[5, 1].Value = f2.dataGridView1[230, 1].Value;
                f2.dataGridView6[5, 2].Value = f2.dataGridView1[230, 2].Value;
                f2.dataGridView6[5, 3].Value = f2.dataGridView1[230, 3].Value;
                f2.dataGridView6[5, 4].Value = f2.dataGridView1[230, 4].Value;
                f2.dataGridView6[5, 5].Value = f2.dataGridView1[230, 5].Value;
                f2.dataGridView6[5, 6].Value = f2.dataGridView1[230, 6].Value;
                f2.dataGridView6[5, 7].Value = f2.dataGridView1[230, 7].Value;
                f2.dataGridView6[5, 8].Value = f2.dataGridView1[230, 8].Value;
                f2.dataGridView6[5, 9].Value = f2.dataGridView1[230, 9].Value;
                f2.dataGridView6[5, 10].Value = f2.dataGridView1[230, 10].Value;
                f2.dataGridView6[5, 11].Value = f2.dataGridView1[230, 11].Value;
                f2.dataGridView6[5, 12].Value = f2.dataGridView1[230, 12].Value;
                f2.dataGridView6[5, 13].Value = f2.dataGridView1[230, 13].Value;
                f2.dataGridView6[5, 14].Value = f2.dataGridView1[230, 14].Value;
                f2.dataGridView6[5, 15].Value = f2.dataGridView1[230, 15].Value;
                f2.dataGridView6[5, 16].Value = f2.dataGridView1[230, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C6");

                f2.dataGridView5[5, 0].Value = f2.dataGridView1[229, 0].Value;
                f2.dataGridView5[5, 1].Value = f2.dataGridView1[229, 1].Value;
                f2.dataGridView5[5, 2].Value = f2.dataGridView1[229, 2].Value;
                f2.dataGridView5[5, 3].Value = f2.dataGridView1[229, 3].Value;
                f2.dataGridView5[5, 4].Value = f2.dataGridView1[229, 4].Value;
                f2.dataGridView5[5, 5].Value = f2.dataGridView1[229, 5].Value;
                f2.dataGridView5[5, 6].Value = f2.dataGridView1[229, 6].Value;
                f2.dataGridView5[5, 7].Value = f2.dataGridView1[229, 7].Value;
                f2.dataGridView5[5, 8].Value = f2.dataGridView1[229, 8].Value;
                f2.dataGridView5[5, 9].Value = f2.dataGridView1[229, 9].Value;
                f2.dataGridView5[5, 10].Value = f2.dataGridView1[229, 10].Value;
                f2.dataGridView5[5, 11].Value = f2.dataGridView1[229, 11].Value;
                f2.dataGridView5[5, 12].Value = f2.dataGridView1[229, 12].Value;
                f2.dataGridView5[5, 13].Value = f2.dataGridView1[229, 13].Value;
                f2.dataGridView5[5, 14].Value = f2.dataGridView1[229, 14].Value;
                f2.dataGridView5[5, 15].Value = f2.dataGridView1[229, 15].Value;
                f2.dataGridView5[5, 16].Value = f2.dataGridView1[229, 16].Value;

            }

            //C7 WPM WASPAS / 232 - 235
            //txtbox8

            if (f2.textBox8.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[7].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[232].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[234].Value = Convert.ToDouble(row.Cells[7].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[234].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[233, 0].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 1].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 2].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 3].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 4].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 5].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 6].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 7].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 8].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 9].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 10].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 11].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 12].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 13].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 14].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 15].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 16].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 17].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 18].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 19].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 20].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 21].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 22].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 23].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 24].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 25].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 26].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 27].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 28].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 29].Value = f2.dataGridView4[7, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[235].Value = Math.Pow(Convert.ToDouble(row.Cells[234].Value), Convert.ToDouble(row.Cells[233].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[235].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C7");//revisar bien

                f2.dataGridView6[6, 0].Value = f2.dataGridView1[235, 0].Value;
                f2.dataGridView6[6, 1].Value = f2.dataGridView1[235, 1].Value;
                f2.dataGridView6[6, 2].Value = f2.dataGridView1[235, 2].Value;
                f2.dataGridView6[6, 3].Value = f2.dataGridView1[235, 3].Value;
                f2.dataGridView6[6, 4].Value = f2.dataGridView1[235, 4].Value;
                f2.dataGridView6[6, 5].Value = f2.dataGridView1[235, 5].Value;
                f2.dataGridView6[6, 6].Value = f2.dataGridView1[235, 6].Value;
                f2.dataGridView6[6, 7].Value = f2.dataGridView1[235, 7].Value;
                f2.dataGridView6[6, 8].Value = f2.dataGridView1[235, 8].Value;
                f2.dataGridView6[6, 9].Value = f2.dataGridView1[235, 9].Value;
                f2.dataGridView6[6, 10].Value = f2.dataGridView1[235, 10].Value;
                f2.dataGridView6[6, 11].Value = f2.dataGridView1[235, 11].Value;
                f2.dataGridView6[6, 12].Value = f2.dataGridView1[235, 12].Value;
                f2.dataGridView6[6, 13].Value = f2.dataGridView1[235, 13].Value;
                f2.dataGridView6[6, 14].Value = f2.dataGridView1[235, 14].Value;
                f2.dataGridView6[6, 15].Value = f2.dataGridView1[235, 15].Value;
                f2.dataGridView6[6, 16].Value = f2.dataGridView1[235, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C7");

                f2.dataGridView5[6, 0].Value = f2.dataGridView1[234, 0].Value;
                f2.dataGridView5[6, 1].Value = f2.dataGridView1[234, 1].Value;
                f2.dataGridView5[6, 2].Value = f2.dataGridView1[234, 2].Value;
                f2.dataGridView5[6, 3].Value = f2.dataGridView1[234, 3].Value;
                f2.dataGridView5[6, 4].Value = f2.dataGridView1[234, 4].Value;
                f2.dataGridView5[6, 5].Value = f2.dataGridView1[234, 5].Value;
                f2.dataGridView5[6, 6].Value = f2.dataGridView1[234, 6].Value;
                f2.dataGridView5[6, 7].Value = f2.dataGridView1[234, 7].Value;
                f2.dataGridView5[6, 8].Value = f2.dataGridView1[234, 8].Value;
                f2.dataGridView5[6, 9].Value = f2.dataGridView1[234, 9].Value;
                f2.dataGridView5[6, 10].Value = f2.dataGridView1[234, 10].Value;
                f2.dataGridView5[6, 11].Value = f2.dataGridView1[234, 11].Value;
                f2.dataGridView5[6, 12].Value = f2.dataGridView1[234, 12].Value;
                f2.dataGridView5[6, 13].Value = f2.dataGridView1[234, 13].Value;
                f2.dataGridView5[6, 14].Value = f2.dataGridView1[234, 14].Value;
                f2.dataGridView5[6, 15].Value = f2.dataGridView1[234, 15].Value;
                f2.dataGridView5[6, 16].Value = f2.dataGridView1[234, 16].Value;


            }

            //CRITERIO INVERSO C7 WPM WASPAS
            if (f2.textBox8.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[7].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[232].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[234].Value = DIR / Convert.ToDouble(row.Cells[7].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[234].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[233, 0].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 1].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 2].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 3].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 4].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 5].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 6].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 7].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 8].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 9].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 10].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 11].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 12].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 13].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 14].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 15].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 16].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 17].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 18].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 19].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 20].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 21].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 22].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 23].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 24].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 25].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 26].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 27].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 28].Value = f2.dataGridView4[7, 0].Value;
                f2.dataGridView1[233, 29].Value = f2.dataGridView4[7, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[235].Value = Math.Pow(Convert.ToDouble(row.Cells[234].Value), Convert.ToDouble(row.Cells[233].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[235].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C7");//revisar bien

                f2.dataGridView6[6, 0].Value = f2.dataGridView1[235, 0].Value;
                f2.dataGridView6[6, 1].Value = f2.dataGridView1[235, 1].Value;
                f2.dataGridView6[6, 2].Value = f2.dataGridView1[235, 2].Value;
                f2.dataGridView6[6, 3].Value = f2.dataGridView1[235, 3].Value;
                f2.dataGridView6[6, 4].Value = f2.dataGridView1[235, 4].Value;
                f2.dataGridView6[6, 5].Value = f2.dataGridView1[235, 5].Value;
                f2.dataGridView6[6, 6].Value = f2.dataGridView1[235, 6].Value;
                f2.dataGridView6[6, 7].Value = f2.dataGridView1[235, 7].Value;
                f2.dataGridView6[6, 8].Value = f2.dataGridView1[235, 8].Value;
                f2.dataGridView6[6, 9].Value = f2.dataGridView1[235, 9].Value;
                f2.dataGridView6[6, 10].Value = f2.dataGridView1[235, 10].Value;
                f2.dataGridView6[6, 11].Value = f2.dataGridView1[235, 11].Value;
                f2.dataGridView6[6, 12].Value = f2.dataGridView1[235, 12].Value;
                f2.dataGridView6[6, 13].Value = f2.dataGridView1[235, 13].Value;
                f2.dataGridView6[6, 14].Value = f2.dataGridView1[235, 14].Value;
                f2.dataGridView6[6, 15].Value = f2.dataGridView1[235, 15].Value;
                f2.dataGridView6[6, 16].Value = f2.dataGridView1[235, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C7");

                f2.dataGridView5[6, 0].Value = f2.dataGridView1[234, 0].Value;
                f2.dataGridView5[6, 1].Value = f2.dataGridView1[234, 1].Value;
                f2.dataGridView5[6, 2].Value = f2.dataGridView1[234, 2].Value;
                f2.dataGridView5[6, 3].Value = f2.dataGridView1[234, 3].Value;
                f2.dataGridView5[6, 4].Value = f2.dataGridView1[234, 4].Value;
                f2.dataGridView5[6, 5].Value = f2.dataGridView1[234, 5].Value;
                f2.dataGridView5[6, 6].Value = f2.dataGridView1[234, 6].Value;
                f2.dataGridView5[6, 7].Value = f2.dataGridView1[234, 7].Value;
                f2.dataGridView5[6, 8].Value = f2.dataGridView1[234, 8].Value;
                f2.dataGridView5[6, 9].Value = f2.dataGridView1[234, 9].Value;
                f2.dataGridView5[6, 10].Value = f2.dataGridView1[234, 10].Value;
                f2.dataGridView5[6, 11].Value = f2.dataGridView1[234, 11].Value;
                f2.dataGridView5[6, 12].Value = f2.dataGridView1[234, 12].Value;
                f2.dataGridView5[6, 13].Value = f2.dataGridView1[234, 13].Value;
                f2.dataGridView5[6, 14].Value = f2.dataGridView1[234, 14].Value;
                f2.dataGridView5[6, 15].Value = f2.dataGridView1[234, 15].Value;
                f2.dataGridView5[6, 16].Value = f2.dataGridView1[234, 16].Value;

            }

            //C8: 237 - 240 / WPM WASPAS / txtbox 9

            if (f2.textBox9.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[8].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[8].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[237].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[239].Value = Convert.ToDouble(row.Cells[8].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[239].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[238, 0].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 1].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 2].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 3].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 4].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 5].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 6].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 7].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 8].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 9].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 10].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 11].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 12].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 13].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 14].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 15].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 16].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 17].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 18].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 19].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 20].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 21].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 22].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 23].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 24].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 25].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 26].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 27].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 28].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 29].Value = f2.dataGridView4[8, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[240].Value = Math.Pow(Convert.ToDouble(row.Cells[239].Value), Convert.ToDouble(row.Cells[238].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[240].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C8");//revisar bien

                f2.dataGridView6[7, 0].Value = f2.dataGridView1[240, 0].Value;
                f2.dataGridView6[7, 1].Value = f2.dataGridView1[240, 1].Value;
                f2.dataGridView6[7, 2].Value = f2.dataGridView1[240, 2].Value;
                f2.dataGridView6[7, 3].Value = f2.dataGridView1[240, 3].Value;
                f2.dataGridView6[7, 4].Value = f2.dataGridView1[240, 4].Value;
                f2.dataGridView6[7, 5].Value = f2.dataGridView1[240, 5].Value;
                f2.dataGridView6[7, 6].Value = f2.dataGridView1[240, 6].Value;
                f2.dataGridView6[7, 7].Value = f2.dataGridView1[240, 7].Value;
                f2.dataGridView6[7, 8].Value = f2.dataGridView1[240, 8].Value;
                f2.dataGridView6[7, 9].Value = f2.dataGridView1[240, 9].Value;
                f2.dataGridView6[7, 10].Value = f2.dataGridView1[240, 10].Value;
                f2.dataGridView6[7, 11].Value = f2.dataGridView1[240, 11].Value;
                f2.dataGridView6[7, 12].Value = f2.dataGridView1[240, 12].Value;
                f2.dataGridView6[7, 13].Value = f2.dataGridView1[240, 13].Value;
                f2.dataGridView6[7, 14].Value = f2.dataGridView1[240, 14].Value;
                f2.dataGridView6[7, 15].Value = f2.dataGridView1[240, 15].Value;
                f2.dataGridView6[7, 16].Value = f2.dataGridView1[240, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C8");

                f2.dataGridView5[7, 0].Value = f2.dataGridView1[239, 0].Value;
                f2.dataGridView5[7, 1].Value = f2.dataGridView1[239, 1].Value;
                f2.dataGridView5[7, 2].Value = f2.dataGridView1[239, 2].Value;
                f2.dataGridView5[7, 3].Value = f2.dataGridView1[239, 3].Value;
                f2.dataGridView5[7, 4].Value = f2.dataGridView1[239, 4].Value;
                f2.dataGridView5[7, 5].Value = f2.dataGridView1[239, 5].Value;
                f2.dataGridView5[7, 6].Value = f2.dataGridView1[239, 6].Value;
                f2.dataGridView5[7, 7].Value = f2.dataGridView1[239, 7].Value;
                f2.dataGridView5[7, 8].Value = f2.dataGridView1[239, 8].Value;
                f2.dataGridView5[7, 9].Value = f2.dataGridView1[239, 9].Value;
                f2.dataGridView5[7, 10].Value = f2.dataGridView1[239, 10].Value;
                f2.dataGridView5[7, 11].Value = f2.dataGridView1[239, 11].Value;
                f2.dataGridView5[7, 12].Value = f2.dataGridView1[239, 12].Value;
                f2.dataGridView5[7, 13].Value = f2.dataGridView1[239, 13].Value;
                f2.dataGridView5[7, 14].Value = f2.dataGridView1[239, 14].Value;
                f2.dataGridView5[7, 15].Value = f2.dataGridView1[239, 15].Value;
                f2.dataGridView5[7, 16].Value = f2.dataGridView1[239, 16].Value;


            }

            //CRITERIO INVERSO C8 WPM WASPAS
            if (f2.textBox9.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[8].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[8].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[237].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[239].Value = DIR / Convert.ToDouble(row.Cells[8].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[239].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[238, 0].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 1].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 2].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 3].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 4].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 5].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 6].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 7].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 8].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 9].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 10].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 11].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 12].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 13].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 14].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 15].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 16].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 17].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 18].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 19].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 20].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 21].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 22].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 23].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 24].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 25].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 26].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 27].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 28].Value = f2.dataGridView4[8, 0].Value;
                f2.dataGridView1[238, 29].Value = f2.dataGridView4[8, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[240].Value = Math.Pow(Convert.ToDouble(row.Cells[239].Value), Convert.ToDouble(row.Cells[238].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[240].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C8");//revisar bien

                f2.dataGridView6[7, 0].Value = f2.dataGridView1[240, 0].Value;
                f2.dataGridView6[7, 1].Value = f2.dataGridView1[240, 1].Value;
                f2.dataGridView6[7, 2].Value = f2.dataGridView1[240, 2].Value;
                f2.dataGridView6[7, 3].Value = f2.dataGridView1[240, 3].Value;
                f2.dataGridView6[7, 4].Value = f2.dataGridView1[240, 4].Value;
                f2.dataGridView6[7, 5].Value = f2.dataGridView1[240, 5].Value;
                f2.dataGridView6[7, 6].Value = f2.dataGridView1[240, 6].Value;
                f2.dataGridView6[7, 7].Value = f2.dataGridView1[240, 7].Value;
                f2.dataGridView6[7, 8].Value = f2.dataGridView1[240, 8].Value;
                f2.dataGridView6[7, 9].Value = f2.dataGridView1[240, 9].Value;
                f2.dataGridView6[7, 10].Value = f2.dataGridView1[240, 10].Value;
                f2.dataGridView6[7, 11].Value = f2.dataGridView1[240, 11].Value;
                f2.dataGridView6[7, 12].Value = f2.dataGridView1[240, 12].Value;
                f2.dataGridView6[7, 13].Value = f2.dataGridView1[240, 13].Value;
                f2.dataGridView6[7, 14].Value = f2.dataGridView1[240, 14].Value;
                f2.dataGridView6[7, 15].Value = f2.dataGridView1[240, 15].Value;
                f2.dataGridView6[7, 16].Value = f2.dataGridView1[240, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C8");

                f2.dataGridView5[7, 0].Value = f2.dataGridView1[239, 0].Value;
                f2.dataGridView5[7, 1].Value = f2.dataGridView1[239, 1].Value;
                f2.dataGridView5[7, 2].Value = f2.dataGridView1[239, 2].Value;
                f2.dataGridView5[7, 3].Value = f2.dataGridView1[239, 3].Value;
                f2.dataGridView5[7, 4].Value = f2.dataGridView1[239, 4].Value;
                f2.dataGridView5[7, 5].Value = f2.dataGridView1[239, 5].Value;
                f2.dataGridView5[7, 6].Value = f2.dataGridView1[239, 6].Value;
                f2.dataGridView5[7, 7].Value = f2.dataGridView1[239, 7].Value;
                f2.dataGridView5[7, 8].Value = f2.dataGridView1[239, 8].Value;
                f2.dataGridView5[7, 9].Value = f2.dataGridView1[239, 9].Value;
                f2.dataGridView5[7, 10].Value = f2.dataGridView1[239, 10].Value;
                f2.dataGridView5[7, 11].Value = f2.dataGridView1[239, 11].Value;
                f2.dataGridView5[7, 12].Value = f2.dataGridView1[239, 12].Value;
                f2.dataGridView5[7, 13].Value = f2.dataGridView1[239, 13].Value;
                f2.dataGridView5[7, 14].Value = f2.dataGridView1[239, 14].Value;
                f2.dataGridView5[7, 15].Value = f2.dataGridView1[239, 15].Value;
                f2.dataGridView5[7, 16].Value = f2.dataGridView1[239, 16].Value;

            }

            //C9: 242 - 245 / WPM WASPAS / txtbox10

            if (f2.textBox10.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[9].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[242].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[244].Value = Convert.ToDouble(row.Cells[9].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[244].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[243, 0].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 1].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 2].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 3].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 4].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 5].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 6].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 7].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 8].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 9].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 10].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 11].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 12].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 13].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 14].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 15].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 16].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 17].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 18].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 19].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 20].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 21].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 22].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 23].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 24].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 25].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 26].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 27].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 28].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 29].Value = f2.dataGridView4[9, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[245].Value = Math.Pow(Convert.ToDouble(row.Cells[244].Value), Convert.ToDouble(row.Cells[243].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[245].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C9");//revisar bien

                f2.dataGridView6[8, 0].Value = f2.dataGridView1[245, 0].Value;
                f2.dataGridView6[8, 1].Value = f2.dataGridView1[245, 1].Value;
                f2.dataGridView6[8, 2].Value = f2.dataGridView1[245, 2].Value;
                f2.dataGridView6[8, 3].Value = f2.dataGridView1[245, 3].Value;
                f2.dataGridView6[8, 4].Value = f2.dataGridView1[245, 4].Value;
                f2.dataGridView6[8, 5].Value = f2.dataGridView1[245, 5].Value;
                f2.dataGridView6[8, 6].Value = f2.dataGridView1[245, 6].Value;
                f2.dataGridView6[8, 7].Value = f2.dataGridView1[245, 7].Value;
                f2.dataGridView6[8, 8].Value = f2.dataGridView1[245, 8].Value;
                f2.dataGridView6[8, 9].Value = f2.dataGridView1[245, 9].Value;
                f2.dataGridView6[8, 10].Value = f2.dataGridView1[245, 10].Value;
                f2.dataGridView6[8, 11].Value = f2.dataGridView1[245, 11].Value;
                f2.dataGridView6[8, 12].Value = f2.dataGridView1[245, 12].Value;
                f2.dataGridView6[8, 13].Value = f2.dataGridView1[245, 13].Value;
                f2.dataGridView6[8, 14].Value = f2.dataGridView1[245, 14].Value;
                f2.dataGridView6[8, 15].Value = f2.dataGridView1[245, 15].Value;
                f2.dataGridView6[8, 16].Value = f2.dataGridView1[245, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C9");

                f2.dataGridView5[8, 0].Value = f2.dataGridView1[244, 0].Value;
                f2.dataGridView5[8, 1].Value = f2.dataGridView1[244, 1].Value;
                f2.dataGridView5[8, 2].Value = f2.dataGridView1[244, 2].Value;
                f2.dataGridView5[8, 3].Value = f2.dataGridView1[244, 3].Value;
                f2.dataGridView5[8, 4].Value = f2.dataGridView1[244, 4].Value;
                f2.dataGridView5[8, 5].Value = f2.dataGridView1[244, 5].Value;
                f2.dataGridView5[8, 6].Value = f2.dataGridView1[244, 6].Value;
                f2.dataGridView5[8, 7].Value = f2.dataGridView1[244, 7].Value;
                f2.dataGridView5[8, 8].Value = f2.dataGridView1[244, 8].Value;
                f2.dataGridView5[8, 9].Value = f2.dataGridView1[244, 9].Value;
                f2.dataGridView5[8, 10].Value = f2.dataGridView1[244, 10].Value;
                f2.dataGridView5[8, 11].Value = f2.dataGridView1[244, 11].Value;
                f2.dataGridView5[8, 12].Value = f2.dataGridView1[244, 12].Value;
                f2.dataGridView5[8, 13].Value = f2.dataGridView1[244, 13].Value;
                f2.dataGridView5[8, 14].Value = f2.dataGridView1[244, 14].Value;
                f2.dataGridView5[8, 15].Value = f2.dataGridView1[244, 15].Value;
                f2.dataGridView5[8, 16].Value = f2.dataGridView1[244, 16].Value;


            }

            //CRITERIO INVERSO C9 WPM WASPAS
            if (f2.textBox10.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[9].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[242].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[244].Value = DIR / Convert.ToDouble(row.Cells[9].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[244].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[243, 0].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 1].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 2].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 3].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 4].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 5].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 6].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 7].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 8].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 9].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 10].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 11].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 12].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 13].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 14].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 15].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 16].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 17].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 18].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 19].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 20].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 21].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 22].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 23].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 24].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 25].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 26].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 27].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 28].Value = f2.dataGridView4[9, 0].Value;
                f2.dataGridView1[243, 29].Value = f2.dataGridView4[9, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[245].Value = Math.Pow(Convert.ToDouble(row.Cells[244].Value), Convert.ToDouble(row.Cells[243].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[245].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C9");//revisar bien

                f2.dataGridView6[8, 0].Value = f2.dataGridView1[245, 0].Value;
                f2.dataGridView6[8, 1].Value = f2.dataGridView1[245, 1].Value;
                f2.dataGridView6[8, 2].Value = f2.dataGridView1[245, 2].Value;
                f2.dataGridView6[8, 3].Value = f2.dataGridView1[245, 3].Value;
                f2.dataGridView6[8, 4].Value = f2.dataGridView1[245, 4].Value;
                f2.dataGridView6[8, 5].Value = f2.dataGridView1[245, 5].Value;
                f2.dataGridView6[8, 6].Value = f2.dataGridView1[245, 6].Value;
                f2.dataGridView6[8, 7].Value = f2.dataGridView1[245, 7].Value;
                f2.dataGridView6[8, 8].Value = f2.dataGridView1[245, 8].Value;
                f2.dataGridView6[8, 9].Value = f2.dataGridView1[245, 9].Value;
                f2.dataGridView6[8, 10].Value = f2.dataGridView1[245, 10].Value;
                f2.dataGridView6[8, 11].Value = f2.dataGridView1[245, 11].Value;
                f2.dataGridView6[8, 12].Value = f2.dataGridView1[245, 12].Value;
                f2.dataGridView6[8, 13].Value = f2.dataGridView1[245, 13].Value;
                f2.dataGridView6[8, 14].Value = f2.dataGridView1[245, 14].Value;
                f2.dataGridView6[8, 15].Value = f2.dataGridView1[245, 15].Value;
                f2.dataGridView6[8, 16].Value = f2.dataGridView1[245, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C9");

                f2.dataGridView5[8, 0].Value = f2.dataGridView1[244, 0].Value;
                f2.dataGridView5[8, 1].Value = f2.dataGridView1[244, 1].Value;
                f2.dataGridView5[8, 2].Value = f2.dataGridView1[244, 2].Value;
                f2.dataGridView5[8, 3].Value = f2.dataGridView1[244, 3].Value;
                f2.dataGridView5[8, 4].Value = f2.dataGridView1[244, 4].Value;
                f2.dataGridView5[8, 5].Value = f2.dataGridView1[244, 5].Value;
                f2.dataGridView5[8, 6].Value = f2.dataGridView1[244, 6].Value;
                f2.dataGridView5[8, 7].Value = f2.dataGridView1[244, 7].Value;
                f2.dataGridView5[8, 8].Value = f2.dataGridView1[244, 8].Value;
                f2.dataGridView5[8, 9].Value = f2.dataGridView1[244, 9].Value;
                f2.dataGridView5[8, 10].Value = f2.dataGridView1[244, 10].Value;
                f2.dataGridView5[8, 11].Value = f2.dataGridView1[244, 11].Value;
                f2.dataGridView5[8, 12].Value = f2.dataGridView1[244, 12].Value;
                f2.dataGridView5[8, 13].Value = f2.dataGridView1[244, 13].Value;
                f2.dataGridView5[8, 14].Value = f2.dataGridView1[244, 14].Value;
                f2.dataGridView5[8, 15].Value = f2.dataGridView1[244, 15].Value;
                f2.dataGridView5[8, 16].Value = f2.dataGridView1[244, 16].Value;

            }

            //C10: 247 - 250 / WPM WASPAS / txtbox11

            if (f2.textBox11.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[10].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[247].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[249].Value = Convert.ToDouble(row.Cells[10].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[249].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[248, 0].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 1].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 2].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 3].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 4].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 5].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 6].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 7].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 8].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 9].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 10].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 11].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 12].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 13].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 14].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 15].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 16].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 17].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 18].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 19].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 20].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 21].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 22].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 23].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 24].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 25].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 26].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 27].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 28].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 29].Value = f2.dataGridView4[10, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[250].Value = Math.Pow(Convert.ToDouble(row.Cells[249].Value), Convert.ToDouble(row.Cells[248].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[250].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C10");//revisar bien

                f2.dataGridView6[9, 0].Value = f2.dataGridView1[250, 0].Value;
                f2.dataGridView6[9, 1].Value = f2.dataGridView1[250, 1].Value;
                f2.dataGridView6[9, 2].Value = f2.dataGridView1[250, 2].Value;
                f2.dataGridView6[9, 3].Value = f2.dataGridView1[250, 3].Value;
                f2.dataGridView6[9, 4].Value = f2.dataGridView1[250, 4].Value;
                f2.dataGridView6[9, 5].Value = f2.dataGridView1[250, 5].Value;
                f2.dataGridView6[9, 6].Value = f2.dataGridView1[250, 6].Value;
                f2.dataGridView6[9, 7].Value = f2.dataGridView1[250, 7].Value;
                f2.dataGridView6[9, 8].Value = f2.dataGridView1[250, 8].Value;
                f2.dataGridView6[9, 9].Value = f2.dataGridView1[250, 9].Value;
                f2.dataGridView6[9, 10].Value = f2.dataGridView1[250, 10].Value;
                f2.dataGridView6[9, 11].Value = f2.dataGridView1[250, 11].Value;
                f2.dataGridView6[9, 12].Value = f2.dataGridView1[250, 12].Value;
                f2.dataGridView6[9, 13].Value = f2.dataGridView1[250, 13].Value;
                f2.dataGridView6[9, 14].Value = f2.dataGridView1[250, 14].Value;
                f2.dataGridView6[9, 15].Value = f2.dataGridView1[250, 15].Value;
                f2.dataGridView6[9, 16].Value = f2.dataGridView1[250, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C10");

                f2.dataGridView5[9, 0].Value = f2.dataGridView1[249, 0].Value;
                f2.dataGridView5[9, 1].Value = f2.dataGridView1[249, 1].Value;
                f2.dataGridView5[9, 2].Value = f2.dataGridView1[249, 2].Value;
                f2.dataGridView5[9, 3].Value = f2.dataGridView1[249, 3].Value;
                f2.dataGridView5[9, 4].Value = f2.dataGridView1[249, 4].Value;
                f2.dataGridView5[9, 5].Value = f2.dataGridView1[249, 5].Value;
                f2.dataGridView5[9, 6].Value = f2.dataGridView1[249, 6].Value;
                f2.dataGridView5[9, 7].Value = f2.dataGridView1[249, 7].Value;
                f2.dataGridView5[9, 8].Value = f2.dataGridView1[249, 8].Value;
                f2.dataGridView5[9, 9].Value = f2.dataGridView1[249, 9].Value;
                f2.dataGridView5[9, 10].Value = f2.dataGridView1[249, 10].Value;
                f2.dataGridView5[9, 11].Value = f2.dataGridView1[249, 11].Value;
                f2.dataGridView5[9, 12].Value = f2.dataGridView1[249, 12].Value;
                f2.dataGridView5[9, 13].Value = f2.dataGridView1[249, 13].Value;
                f2.dataGridView5[9, 14].Value = f2.dataGridView1[249, 14].Value;
                f2.dataGridView5[9, 15].Value = f2.dataGridView1[249, 15].Value;
                f2.dataGridView5[9, 16].Value = f2.dataGridView1[249, 16].Value;


            }

            //CRITERIO INVERSO C10 WPM WASPAS
            if (f2.textBox11.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[10].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[247].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[249].Value = DIR / Convert.ToDouble(row.Cells[10].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[249].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[248, 0].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 1].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 2].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 3].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 4].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 5].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 6].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 7].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 8].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 9].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 10].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 11].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 12].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 13].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 14].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 15].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 16].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 17].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 18].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 19].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 20].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 21].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 22].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 23].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 24].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 25].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 26].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 27].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 28].Value = f2.dataGridView4[10, 0].Value;
                f2.dataGridView1[248, 29].Value = f2.dataGridView4[10, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[250].Value = Math.Pow(Convert.ToDouble(row.Cells[249].Value), Convert.ToDouble(row.Cells[248].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[250].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C10");//revisar bien

                f2.dataGridView6[9, 0].Value = f2.dataGridView1[250, 0].Value;
                f2.dataGridView6[9, 1].Value = f2.dataGridView1[250, 1].Value;
                f2.dataGridView6[9, 2].Value = f2.dataGridView1[250, 2].Value;
                f2.dataGridView6[9, 3].Value = f2.dataGridView1[250, 3].Value;
                f2.dataGridView6[9, 4].Value = f2.dataGridView1[250, 4].Value;
                f2.dataGridView6[9, 5].Value = f2.dataGridView1[250, 5].Value;
                f2.dataGridView6[9, 6].Value = f2.dataGridView1[250, 6].Value;
                f2.dataGridView6[9, 7].Value = f2.dataGridView1[250, 7].Value;
                f2.dataGridView6[9, 8].Value = f2.dataGridView1[250, 8].Value;
                f2.dataGridView6[9, 9].Value = f2.dataGridView1[250, 9].Value;
                f2.dataGridView6[9, 10].Value = f2.dataGridView1[250, 10].Value;
                f2.dataGridView6[9, 11].Value = f2.dataGridView1[250, 11].Value;
                f2.dataGridView6[9, 12].Value = f2.dataGridView1[250, 12].Value;
                f2.dataGridView6[9, 13].Value = f2.dataGridView1[250, 13].Value;
                f2.dataGridView6[9, 14].Value = f2.dataGridView1[250, 14].Value;
                f2.dataGridView6[9, 15].Value = f2.dataGridView1[250, 15].Value;
                f2.dataGridView6[9, 16].Value = f2.dataGridView1[250, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C10");

                f2.dataGridView5[9, 0].Value = f2.dataGridView1[249, 0].Value;
                f2.dataGridView5[9, 1].Value = f2.dataGridView1[249, 1].Value;
                f2.dataGridView5[9, 2].Value = f2.dataGridView1[249, 2].Value;
                f2.dataGridView5[9, 3].Value = f2.dataGridView1[249, 3].Value;
                f2.dataGridView5[9, 4].Value = f2.dataGridView1[249, 4].Value;
                f2.dataGridView5[9, 5].Value = f2.dataGridView1[249, 5].Value;
                f2.dataGridView5[9, 6].Value = f2.dataGridView1[249, 6].Value;
                f2.dataGridView5[9, 7].Value = f2.dataGridView1[249, 7].Value;
                f2.dataGridView5[9, 8].Value = f2.dataGridView1[249, 8].Value;
                f2.dataGridView5[9, 9].Value = f2.dataGridView1[249, 9].Value;
                f2.dataGridView5[9, 10].Value = f2.dataGridView1[249, 10].Value;
                f2.dataGridView5[9, 11].Value = f2.dataGridView1[249, 11].Value;
                f2.dataGridView5[9, 12].Value = f2.dataGridView1[249, 12].Value;
                f2.dataGridView5[9, 13].Value = f2.dataGridView1[249, 13].Value;
                f2.dataGridView5[9, 14].Value = f2.dataGridView1[249, 14].Value;
                f2.dataGridView5[9, 15].Value = f2.dataGridView1[249, 15].Value;
                f2.dataGridView5[9, 16].Value = f2.dataGridView1[249, 16].Value;

            }

            //C11: 252-255 txtbox 12 / WPM WASPAS

            if (f2.textBox12.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[11].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[11].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[252].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[254].Value = Convert.ToDouble(row.Cells[11].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[254].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[253, 0].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 1].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 2].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 3].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 4].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 5].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 6].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 7].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 8].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 9].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 10].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 11].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 12].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 13].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 14].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 15].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 16].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 17].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 18].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 19].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 20].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 21].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 22].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 23].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 24].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 25].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 26].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 27].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 28].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 29].Value = f2.dataGridView4[11, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[255].Value = Math.Pow(Convert.ToDouble(row.Cells[254].Value), Convert.ToDouble(row.Cells[253].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[255].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C11");//revisar bien

                f2.dataGridView6[10, 0].Value = f2.dataGridView1[255, 0].Value;
                f2.dataGridView6[10, 1].Value = f2.dataGridView1[255, 1].Value;
                f2.dataGridView6[10, 2].Value = f2.dataGridView1[255, 2].Value;
                f2.dataGridView6[10, 3].Value = f2.dataGridView1[255, 3].Value;
                f2.dataGridView6[10, 4].Value = f2.dataGridView1[255, 4].Value;
                f2.dataGridView6[10, 5].Value = f2.dataGridView1[255, 5].Value;
                f2.dataGridView6[10, 6].Value = f2.dataGridView1[255, 6].Value;
                f2.dataGridView6[10, 7].Value = f2.dataGridView1[255, 7].Value;
                f2.dataGridView6[10, 8].Value = f2.dataGridView1[255, 8].Value;
                f2.dataGridView6[10, 9].Value = f2.dataGridView1[255, 9].Value;
                f2.dataGridView6[10, 10].Value = f2.dataGridView1[255, 10].Value;
                f2.dataGridView6[10, 11].Value = f2.dataGridView1[255, 11].Value;
                f2.dataGridView6[10, 12].Value = f2.dataGridView1[255, 12].Value;
                f2.dataGridView6[10, 13].Value = f2.dataGridView1[255, 13].Value;
                f2.dataGridView6[10, 14].Value = f2.dataGridView1[255, 14].Value;
                f2.dataGridView6[10, 15].Value = f2.dataGridView1[255, 15].Value;
                f2.dataGridView6[10, 16].Value = f2.dataGridView1[255, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C11");

                f2.dataGridView5[10, 0].Value = f2.dataGridView1[254, 0].Value;
                f2.dataGridView5[10, 1].Value = f2.dataGridView1[254, 1].Value;
                f2.dataGridView5[10, 2].Value = f2.dataGridView1[254, 2].Value;
                f2.dataGridView5[10, 3].Value = f2.dataGridView1[254, 3].Value;
                f2.dataGridView5[10, 4].Value = f2.dataGridView1[254, 4].Value;
                f2.dataGridView5[10, 5].Value = f2.dataGridView1[254, 5].Value;
                f2.dataGridView5[10, 6].Value = f2.dataGridView1[254, 6].Value;
                f2.dataGridView5[10, 7].Value = f2.dataGridView1[254, 7].Value;
                f2.dataGridView5[10, 8].Value = f2.dataGridView1[254, 8].Value;
                f2.dataGridView5[10, 9].Value = f2.dataGridView1[254, 9].Value;
                f2.dataGridView5[10, 10].Value = f2.dataGridView1[254, 10].Value;
                f2.dataGridView5[10, 11].Value = f2.dataGridView1[254, 11].Value;
                f2.dataGridView5[10, 12].Value = f2.dataGridView1[254, 12].Value;
                f2.dataGridView5[10, 13].Value = f2.dataGridView1[254, 13].Value;
                f2.dataGridView5[10, 14].Value = f2.dataGridView1[254, 14].Value;
                f2.dataGridView5[10, 15].Value = f2.dataGridView1[254, 15].Value;
                f2.dataGridView5[10, 16].Value = f2.dataGridView1[254, 16].Value;


            }

            //CRITERIO INVERSO C11 WPM WASPAS
            if (f2.textBox12.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[11].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[11].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[252].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[254].Value = DIR / Convert.ToDouble(row.Cells[11].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[254].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[253, 0].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 1].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 2].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 3].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 4].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 5].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 6].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 7].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 8].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 9].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 10].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 11].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 12].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 13].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 14].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 15].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 16].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 17].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 18].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 19].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 20].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 21].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 22].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 23].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 24].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 25].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 26].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 27].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 28].Value = f2.dataGridView4[11, 0].Value;
                f2.dataGridView1[253, 29].Value = f2.dataGridView4[11, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[255].Value = Math.Pow(Convert.ToDouble(row.Cells[254].Value), Convert.ToDouble(row.Cells[253].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[255].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C11");//revisar bien

                f2.dataGridView6[10, 0].Value = f2.dataGridView1[255, 0].Value;
                f2.dataGridView6[10, 1].Value = f2.dataGridView1[255, 1].Value;
                f2.dataGridView6[10, 2].Value = f2.dataGridView1[255, 2].Value;
                f2.dataGridView6[10, 3].Value = f2.dataGridView1[255, 3].Value;
                f2.dataGridView6[10, 4].Value = f2.dataGridView1[255, 4].Value;
                f2.dataGridView6[10, 5].Value = f2.dataGridView1[255, 5].Value;
                f2.dataGridView6[10, 6].Value = f2.dataGridView1[255, 6].Value;
                f2.dataGridView6[10, 7].Value = f2.dataGridView1[255, 7].Value;
                f2.dataGridView6[10, 8].Value = f2.dataGridView1[255, 8].Value;
                f2.dataGridView6[10, 9].Value = f2.dataGridView1[255, 9].Value;
                f2.dataGridView6[10, 10].Value = f2.dataGridView1[255, 10].Value;
                f2.dataGridView6[10, 11].Value = f2.dataGridView1[255, 11].Value;
                f2.dataGridView6[10, 12].Value = f2.dataGridView1[255, 12].Value;
                f2.dataGridView6[10, 13].Value = f2.dataGridView1[255, 13].Value;
                f2.dataGridView6[10, 14].Value = f2.dataGridView1[255, 14].Value;
                f2.dataGridView6[10, 15].Value = f2.dataGridView1[255, 15].Value;
                f2.dataGridView6[10, 16].Value = f2.dataGridView1[255, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C11");

                f2.dataGridView5[10, 0].Value = f2.dataGridView1[254, 0].Value;
                f2.dataGridView5[10, 1].Value = f2.dataGridView1[254, 1].Value;
                f2.dataGridView5[10, 2].Value = f2.dataGridView1[254, 2].Value;
                f2.dataGridView5[10, 3].Value = f2.dataGridView1[254, 3].Value;
                f2.dataGridView5[10, 4].Value = f2.dataGridView1[254, 4].Value;
                f2.dataGridView5[10, 5].Value = f2.dataGridView1[254, 5].Value;
                f2.dataGridView5[10, 6].Value = f2.dataGridView1[254, 6].Value;
                f2.dataGridView5[10, 7].Value = f2.dataGridView1[254, 7].Value;
                f2.dataGridView5[10, 8].Value = f2.dataGridView1[254, 8].Value;
                f2.dataGridView5[10, 9].Value = f2.dataGridView1[254, 9].Value;
                f2.dataGridView5[10, 10].Value = f2.dataGridView1[254, 10].Value;
                f2.dataGridView5[10, 11].Value = f2.dataGridView1[254, 11].Value;
                f2.dataGridView5[10, 12].Value = f2.dataGridView1[254, 12].Value;
                f2.dataGridView5[10, 13].Value = f2.dataGridView1[254, 13].Value;
                f2.dataGridView5[10, 14].Value = f2.dataGridView1[254, 14].Value;
                f2.dataGridView5[10, 15].Value = f2.dataGridView1[254, 15].Value;
                f2.dataGridView5[10, 16].Value = f2.dataGridView1[254, 16].Value;

            }

            //C12: 257 - 260 / WASPAS WPM / TXTBOX13

            if (f2.textBox13.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[12].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[12].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[257].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[259].Value = Convert.ToDouble(row.Cells[12].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[259].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[258, 0].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 1].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 2].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 3].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 4].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 5].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 6].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 7].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 8].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 9].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 10].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 11].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 12].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 13].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 14].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 15].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 16].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 17].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 18].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 19].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 20].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 21].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 22].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 23].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 24].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 25].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 26].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 27].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 28].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 29].Value = f2.dataGridView4[12, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[260].Value = Math.Pow(Convert.ToDouble(row.Cells[259].Value), Convert.ToDouble(row.Cells[258].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[260].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C12");//revisar bien

                f2.dataGridView6[11, 0].Value = f2.dataGridView1[260, 0].Value;
                f2.dataGridView6[11, 1].Value = f2.dataGridView1[260, 1].Value;
                f2.dataGridView6[11, 2].Value = f2.dataGridView1[260, 2].Value;
                f2.dataGridView6[11, 3].Value = f2.dataGridView1[260, 3].Value;
                f2.dataGridView6[11, 4].Value = f2.dataGridView1[260, 4].Value;
                f2.dataGridView6[11, 5].Value = f2.dataGridView1[260, 5].Value;
                f2.dataGridView6[11, 6].Value = f2.dataGridView1[260, 6].Value;
                f2.dataGridView6[11, 7].Value = f2.dataGridView1[260, 7].Value;
                f2.dataGridView6[11, 8].Value = f2.dataGridView1[260, 8].Value;
                f2.dataGridView6[11, 9].Value = f2.dataGridView1[260, 9].Value;
                f2.dataGridView6[11, 10].Value = f2.dataGridView1[260, 10].Value;
                f2.dataGridView6[11, 11].Value = f2.dataGridView1[260, 11].Value;
                f2.dataGridView6[11, 12].Value = f2.dataGridView1[260, 12].Value;
                f2.dataGridView6[11, 13].Value = f2.dataGridView1[260, 13].Value;
                f2.dataGridView6[11, 14].Value = f2.dataGridView1[260, 14].Value;
                f2.dataGridView6[11, 15].Value = f2.dataGridView1[260, 15].Value;
                f2.dataGridView6[11, 16].Value = f2.dataGridView1[260, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C12");

                f2.dataGridView5[11, 0].Value = f2.dataGridView1[259, 0].Value;
                f2.dataGridView5[11, 1].Value = f2.dataGridView1[259, 1].Value;
                f2.dataGridView5[11, 2].Value = f2.dataGridView1[259, 2].Value;
                f2.dataGridView5[11, 3].Value = f2.dataGridView1[259, 3].Value;
                f2.dataGridView5[11, 4].Value = f2.dataGridView1[259, 4].Value;
                f2.dataGridView5[11, 5].Value = f2.dataGridView1[259, 5].Value;
                f2.dataGridView5[11, 6].Value = f2.dataGridView1[259, 6].Value;
                f2.dataGridView5[11, 7].Value = f2.dataGridView1[259, 7].Value;
                f2.dataGridView5[11, 8].Value = f2.dataGridView1[259, 8].Value;
                f2.dataGridView5[11, 9].Value = f2.dataGridView1[259, 9].Value;
                f2.dataGridView5[11, 10].Value = f2.dataGridView1[259, 10].Value;
                f2.dataGridView5[11, 11].Value = f2.dataGridView1[259, 11].Value;
                f2.dataGridView5[11, 12].Value = f2.dataGridView1[259, 12].Value;
                f2.dataGridView5[11, 13].Value = f2.dataGridView1[259, 13].Value;
                f2.dataGridView5[11, 14].Value = f2.dataGridView1[259, 14].Value;
                f2.dataGridView5[11, 15].Value = f2.dataGridView1[259, 15].Value;
                f2.dataGridView5[11, 16].Value = f2.dataGridView1[259, 16].Value;


            }

            //CRITERIO INVERSO C12 WPM WASPAS
            if (f2.textBox13.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[12].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[12].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[257].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[259].Value = DIR / Convert.ToDouble(row.Cells[12].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[259].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[258, 0].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 1].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 2].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 3].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 4].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 5].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 6].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 7].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 8].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 9].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 10].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 11].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 12].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 13].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 14].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 15].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 16].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 17].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 18].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 19].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 20].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 21].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 22].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 23].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 24].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 25].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 26].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 27].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 28].Value = f2.dataGridView4[12, 0].Value;
                f2.dataGridView1[258, 29].Value = f2.dataGridView4[12, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[260].Value = Math.Pow(Convert.ToDouble(row.Cells[259].Value), Convert.ToDouble(row.Cells[258].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[260].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C12");//revisar bien

                f2.dataGridView6[11, 0].Value = f2.dataGridView1[260, 0].Value;
                f2.dataGridView6[11, 1].Value = f2.dataGridView1[260, 1].Value;
                f2.dataGridView6[11, 2].Value = f2.dataGridView1[260, 2].Value;
                f2.dataGridView6[11, 3].Value = f2.dataGridView1[260, 3].Value;
                f2.dataGridView6[11, 4].Value = f2.dataGridView1[260, 4].Value;
                f2.dataGridView6[11, 5].Value = f2.dataGridView1[260, 5].Value;
                f2.dataGridView6[11, 6].Value = f2.dataGridView1[260, 6].Value;
                f2.dataGridView6[11, 7].Value = f2.dataGridView1[260, 7].Value;
                f2.dataGridView6[11, 8].Value = f2.dataGridView1[260, 8].Value;
                f2.dataGridView6[11, 9].Value = f2.dataGridView1[260, 9].Value;
                f2.dataGridView6[11, 10].Value = f2.dataGridView1[260, 10].Value;
                f2.dataGridView6[11, 11].Value = f2.dataGridView1[260, 11].Value;
                f2.dataGridView6[11, 12].Value = f2.dataGridView1[260, 12].Value;
                f2.dataGridView6[11, 13].Value = f2.dataGridView1[260, 13].Value;
                f2.dataGridView6[11, 14].Value = f2.dataGridView1[260, 14].Value;
                f2.dataGridView6[11, 15].Value = f2.dataGridView1[260, 15].Value;
                f2.dataGridView6[11, 16].Value = f2.dataGridView1[260, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C12");

                f2.dataGridView5[11, 0].Value = f2.dataGridView1[259, 0].Value;
                f2.dataGridView5[11, 1].Value = f2.dataGridView1[259, 1].Value;
                f2.dataGridView5[11, 2].Value = f2.dataGridView1[259, 2].Value;
                f2.dataGridView5[11, 3].Value = f2.dataGridView1[259, 3].Value;
                f2.dataGridView5[11, 4].Value = f2.dataGridView1[259, 4].Value;
                f2.dataGridView5[11, 5].Value = f2.dataGridView1[259, 5].Value;
                f2.dataGridView5[11, 6].Value = f2.dataGridView1[259, 6].Value;
                f2.dataGridView5[11, 7].Value = f2.dataGridView1[259, 7].Value;
                f2.dataGridView5[11, 8].Value = f2.dataGridView1[259, 8].Value;
                f2.dataGridView5[11, 9].Value = f2.dataGridView1[259, 9].Value;
                f2.dataGridView5[11, 10].Value = f2.dataGridView1[259, 10].Value;
                f2.dataGridView5[11, 11].Value = f2.dataGridView1[259, 11].Value;
                f2.dataGridView5[11, 12].Value = f2.dataGridView1[259, 12].Value;
                f2.dataGridView5[11, 13].Value = f2.dataGridView1[259, 13].Value;
                f2.dataGridView5[11, 14].Value = f2.dataGridView1[259, 14].Value;
                f2.dataGridView5[11, 15].Value = f2.dataGridView1[259, 15].Value;
                f2.dataGridView5[11, 16].Value = f2.dataGridView1[259, 16].Value;

            }

            //C13: 262 - 265 / WPM WASPAS/ TXTBOX14

            if (f2.textBox14.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[13].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[13].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[262].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[264].Value = Convert.ToDouble(row.Cells[13].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[264].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[263, 0].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 1].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 2].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 3].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 4].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 5].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 6].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 7].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 8].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 9].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 10].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 11].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 12].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 13].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 14].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 15].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 16].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 17].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 18].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 19].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 20].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 21].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 22].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 23].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 24].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 25].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 26].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 27].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 28].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 29].Value = f2.dataGridView4[13, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[265].Value = Math.Pow(Convert.ToDouble(row.Cells[264].Value), Convert.ToDouble(row.Cells[263].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[265].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C13");//revisar bien

                f2.dataGridView6[12, 0].Value = f2.dataGridView1[265, 0].Value;
                f2.dataGridView6[12, 1].Value = f2.dataGridView1[265, 1].Value;
                f2.dataGridView6[12, 2].Value = f2.dataGridView1[265, 2].Value;
                f2.dataGridView6[12, 3].Value = f2.dataGridView1[265, 3].Value;
                f2.dataGridView6[12, 4].Value = f2.dataGridView1[265, 4].Value;
                f2.dataGridView6[12, 5].Value = f2.dataGridView1[265, 5].Value;
                f2.dataGridView6[12, 6].Value = f2.dataGridView1[265, 6].Value;
                f2.dataGridView6[12, 7].Value = f2.dataGridView1[265, 7].Value;
                f2.dataGridView6[12, 8].Value = f2.dataGridView1[265, 8].Value;
                f2.dataGridView6[12, 9].Value = f2.dataGridView1[265, 9].Value;
                f2.dataGridView6[12, 10].Value = f2.dataGridView1[265, 10].Value;
                f2.dataGridView6[12, 11].Value = f2.dataGridView1[265, 11].Value;
                f2.dataGridView6[12, 12].Value = f2.dataGridView1[265, 12].Value;
                f2.dataGridView6[12, 13].Value = f2.dataGridView1[265, 13].Value;
                f2.dataGridView6[12, 14].Value = f2.dataGridView1[265, 14].Value;
                f2.dataGridView6[12, 15].Value = f2.dataGridView1[265, 15].Value;
                f2.dataGridView6[12, 16].Value = f2.dataGridView1[265, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C13");

                f2.dataGridView5[12, 0].Value = f2.dataGridView1[264, 0].Value;
                f2.dataGridView5[12, 1].Value = f2.dataGridView1[264, 1].Value;
                f2.dataGridView5[12, 2].Value = f2.dataGridView1[264, 2].Value;
                f2.dataGridView5[12, 3].Value = f2.dataGridView1[264, 3].Value;
                f2.dataGridView5[12, 4].Value = f2.dataGridView1[264, 4].Value;
                f2.dataGridView5[12, 5].Value = f2.dataGridView1[264, 5].Value;
                f2.dataGridView5[12, 6].Value = f2.dataGridView1[264, 6].Value;
                f2.dataGridView5[12, 7].Value = f2.dataGridView1[264, 7].Value;
                f2.dataGridView5[12, 8].Value = f2.dataGridView1[264, 8].Value;
                f2.dataGridView5[12, 9].Value = f2.dataGridView1[264, 9].Value;
                f2.dataGridView5[12, 10].Value = f2.dataGridView1[264, 10].Value;
                f2.dataGridView5[12, 11].Value = f2.dataGridView1[264, 11].Value;
                f2.dataGridView5[12, 12].Value = f2.dataGridView1[264, 12].Value;
                f2.dataGridView5[12, 13].Value = f2.dataGridView1[264, 13].Value;
                f2.dataGridView5[12, 14].Value = f2.dataGridView1[264, 14].Value;
                f2.dataGridView5[12, 15].Value = f2.dataGridView1[264, 15].Value;
                f2.dataGridView5[12, 16].Value = f2.dataGridView1[264, 16].Value;


            }

            //CRITERIO INVERSO C13 WPM WASPAS
            if (f2.textBox14.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[13].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[13].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[262].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[264].Value = DIR / Convert.ToDouble(row.Cells[13].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[264].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[263, 0].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 1].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 2].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 3].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 4].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 5].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 6].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 7].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 8].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 9].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 10].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 11].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 12].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 13].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 14].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 15].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 16].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 17].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 18].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 19].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 20].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 21].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 22].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 23].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 24].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 25].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 26].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 27].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 28].Value = f2.dataGridView4[13, 0].Value;
                f2.dataGridView1[263, 29].Value = f2.dataGridView4[13, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[265].Value = Math.Pow(Convert.ToDouble(row.Cells[264].Value), Convert.ToDouble(row.Cells[263].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[265].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C13");//revisar bien

                f2.dataGridView6[12, 0].Value = f2.dataGridView1[265, 0].Value;
                f2.dataGridView6[12, 1].Value = f2.dataGridView1[265, 1].Value;
                f2.dataGridView6[12, 2].Value = f2.dataGridView1[265, 2].Value;
                f2.dataGridView6[12, 3].Value = f2.dataGridView1[265, 3].Value;
                f2.dataGridView6[12, 4].Value = f2.dataGridView1[265, 4].Value;
                f2.dataGridView6[12, 5].Value = f2.dataGridView1[265, 5].Value;
                f2.dataGridView6[12, 6].Value = f2.dataGridView1[265, 6].Value;
                f2.dataGridView6[12, 7].Value = f2.dataGridView1[265, 7].Value;
                f2.dataGridView6[12, 8].Value = f2.dataGridView1[265, 8].Value;
                f2.dataGridView6[12, 9].Value = f2.dataGridView1[265, 9].Value;
                f2.dataGridView6[12, 10].Value = f2.dataGridView1[265, 10].Value;
                f2.dataGridView6[12, 11].Value = f2.dataGridView1[265, 11].Value;
                f2.dataGridView6[12, 12].Value = f2.dataGridView1[265, 12].Value;
                f2.dataGridView6[12, 13].Value = f2.dataGridView1[265, 13].Value;
                f2.dataGridView6[12, 14].Value = f2.dataGridView1[265, 14].Value;
                f2.dataGridView6[12, 15].Value = f2.dataGridView1[265, 15].Value;
                f2.dataGridView6[12, 16].Value = f2.dataGridView1[265, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C13");

                f2.dataGridView5[12, 0].Value = f2.dataGridView1[264, 0].Value;
                f2.dataGridView5[12, 1].Value = f2.dataGridView1[264, 1].Value;
                f2.dataGridView5[12, 2].Value = f2.dataGridView1[264, 2].Value;
                f2.dataGridView5[12, 3].Value = f2.dataGridView1[264, 3].Value;
                f2.dataGridView5[12, 4].Value = f2.dataGridView1[264, 4].Value;
                f2.dataGridView5[12, 5].Value = f2.dataGridView1[264, 5].Value;
                f2.dataGridView5[12, 6].Value = f2.dataGridView1[264, 6].Value;
                f2.dataGridView5[12, 7].Value = f2.dataGridView1[264, 7].Value;
                f2.dataGridView5[12, 8].Value = f2.dataGridView1[264, 8].Value;
                f2.dataGridView5[12, 9].Value = f2.dataGridView1[264, 9].Value;
                f2.dataGridView5[12, 10].Value = f2.dataGridView1[264, 10].Value;
                f2.dataGridView5[12, 11].Value = f2.dataGridView1[264, 11].Value;
                f2.dataGridView5[12, 12].Value = f2.dataGridView1[264, 12].Value;
                f2.dataGridView5[12, 13].Value = f2.dataGridView1[264, 13].Value;
                f2.dataGridView5[12, 14].Value = f2.dataGridView1[264, 14].Value;
                f2.dataGridView5[12, 15].Value = f2.dataGridView1[264, 15].Value;
                f2.dataGridView5[12, 16].Value = f2.dataGridView1[264, 16].Value;

            }

            //C14: 267 - 270 / WASPAS WPM / TXTBOX15

            if (f2.textBox15.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[14].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[14].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[267].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[269].Value = Convert.ToDouble(row.Cells[14].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[269].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[268, 0].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 1].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 2].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 3].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 4].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 5].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 6].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 7].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 8].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 9].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 10].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 11].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 12].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 13].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 14].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 15].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 16].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 17].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 18].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 19].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 20].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 21].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 22].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 23].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 24].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 25].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 26].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 27].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 28].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 29].Value = f2.dataGridView4[14, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[270].Value = Math.Pow(Convert.ToDouble(row.Cells[269].Value), Convert.ToDouble(row.Cells[268].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[270].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C14");//revisar bien

                f2.dataGridView6[13, 0].Value = f2.dataGridView1[270, 0].Value;
                f2.dataGridView6[13, 1].Value = f2.dataGridView1[270, 1].Value;
                f2.dataGridView6[13, 2].Value = f2.dataGridView1[270, 2].Value;
                f2.dataGridView6[13, 3].Value = f2.dataGridView1[270, 3].Value;
                f2.dataGridView6[13, 4].Value = f2.dataGridView1[270, 4].Value;
                f2.dataGridView6[13, 5].Value = f2.dataGridView1[270, 5].Value;
                f2.dataGridView6[13, 6].Value = f2.dataGridView1[270, 6].Value;
                f2.dataGridView6[13, 7].Value = f2.dataGridView1[270, 7].Value;
                f2.dataGridView6[13, 8].Value = f2.dataGridView1[270, 8].Value;
                f2.dataGridView6[13, 9].Value = f2.dataGridView1[270, 9].Value;
                f2.dataGridView6[13, 10].Value = f2.dataGridView1[270, 10].Value;
                f2.dataGridView6[13, 11].Value = f2.dataGridView1[270, 11].Value;
                f2.dataGridView6[13, 12].Value = f2.dataGridView1[270, 12].Value;
                f2.dataGridView6[13, 13].Value = f2.dataGridView1[270, 13].Value;
                f2.dataGridView6[13, 14].Value = f2.dataGridView1[270, 14].Value;
                f2.dataGridView6[13, 15].Value = f2.dataGridView1[270, 15].Value;
                f2.dataGridView6[13, 16].Value = f2.dataGridView1[270, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C14");

                f2.dataGridView5[13, 0].Value = f2.dataGridView1[269, 0].Value;
                f2.dataGridView5[13, 1].Value = f2.dataGridView1[269, 1].Value;
                f2.dataGridView5[13, 2].Value = f2.dataGridView1[269, 2].Value;
                f2.dataGridView5[13, 3].Value = f2.dataGridView1[269, 3].Value;
                f2.dataGridView5[13, 4].Value = f2.dataGridView1[269, 4].Value;
                f2.dataGridView5[13, 5].Value = f2.dataGridView1[269, 5].Value;
                f2.dataGridView5[13, 6].Value = f2.dataGridView1[269, 6].Value;
                f2.dataGridView5[13, 7].Value = f2.dataGridView1[269, 7].Value;
                f2.dataGridView5[13, 8].Value = f2.dataGridView1[269, 8].Value;
                f2.dataGridView5[13, 9].Value = f2.dataGridView1[269, 9].Value;
                f2.dataGridView5[13, 10].Value = f2.dataGridView1[269, 10].Value;
                f2.dataGridView5[13, 11].Value = f2.dataGridView1[269, 11].Value;
                f2.dataGridView5[13, 12].Value = f2.dataGridView1[269, 12].Value;
                f2.dataGridView5[13, 13].Value = f2.dataGridView1[269, 13].Value;
                f2.dataGridView5[13, 14].Value = f2.dataGridView1[269, 14].Value;
                f2.dataGridView5[13, 15].Value = f2.dataGridView1[269, 15].Value;
                f2.dataGridView5[13, 16].Value = f2.dataGridView1[269, 16].Value;


            }

            //CRITERIO INVERSO C14 WPM WASPAS
            if (f2.textBox15.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[14].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[14].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[267].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[269].Value = DIR / Convert.ToDouble(row.Cells[14].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[269].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[268, 0].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 1].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 2].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 3].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 4].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 5].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 6].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 7].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 8].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 9].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 10].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 11].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 12].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 13].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 14].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 15].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 16].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 17].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 18].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 19].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 20].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 21].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 22].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 23].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 24].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 25].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 26].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 27].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 28].Value = f2.dataGridView4[14, 0].Value;
                f2.dataGridView1[268, 29].Value = f2.dataGridView4[14, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[270].Value = Math.Pow(Convert.ToDouble(row.Cells[269].Value), Convert.ToDouble(row.Cells[268].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[270].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C14");//revisar bien

                f2.dataGridView6[13, 0].Value = f2.dataGridView1[270, 0].Value;
                f2.dataGridView6[13, 1].Value = f2.dataGridView1[270, 1].Value;
                f2.dataGridView6[13, 2].Value = f2.dataGridView1[270, 2].Value;
                f2.dataGridView6[13, 3].Value = f2.dataGridView1[270, 3].Value;
                f2.dataGridView6[13, 4].Value = f2.dataGridView1[270, 4].Value;
                f2.dataGridView6[13, 5].Value = f2.dataGridView1[270, 5].Value;
                f2.dataGridView6[13, 6].Value = f2.dataGridView1[270, 6].Value;
                f2.dataGridView6[13, 7].Value = f2.dataGridView1[270, 7].Value;
                f2.dataGridView6[13, 8].Value = f2.dataGridView1[270, 8].Value;
                f2.dataGridView6[13, 9].Value = f2.dataGridView1[270, 9].Value;
                f2.dataGridView6[13, 10].Value = f2.dataGridView1[270, 10].Value;
                f2.dataGridView6[13, 11].Value = f2.dataGridView1[270, 11].Value;
                f2.dataGridView6[13, 12].Value = f2.dataGridView1[270, 12].Value;
                f2.dataGridView6[13, 13].Value = f2.dataGridView1[270, 13].Value;
                f2.dataGridView6[13, 14].Value = f2.dataGridView1[270, 14].Value;
                f2.dataGridView6[13, 15].Value = f2.dataGridView1[270, 15].Value;
                f2.dataGridView6[13, 16].Value = f2.dataGridView1[270, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C14");

                f2.dataGridView5[13, 0].Value = f2.dataGridView1[269, 0].Value;
                f2.dataGridView5[13, 1].Value = f2.dataGridView1[269, 1].Value;
                f2.dataGridView5[13, 2].Value = f2.dataGridView1[269, 2].Value;
                f2.dataGridView5[13, 3].Value = f2.dataGridView1[269, 3].Value;
                f2.dataGridView5[13, 4].Value = f2.dataGridView1[269, 4].Value;
                f2.dataGridView5[13, 5].Value = f2.dataGridView1[269, 5].Value;
                f2.dataGridView5[13, 6].Value = f2.dataGridView1[269, 6].Value;
                f2.dataGridView5[13, 7].Value = f2.dataGridView1[269, 7].Value;
                f2.dataGridView5[13, 8].Value = f2.dataGridView1[269, 8].Value;
                f2.dataGridView5[13, 9].Value = f2.dataGridView1[269, 9].Value;
                f2.dataGridView5[13, 10].Value = f2.dataGridView1[269, 10].Value;
                f2.dataGridView5[13, 11].Value = f2.dataGridView1[269, 11].Value;
                f2.dataGridView5[13, 12].Value = f2.dataGridView1[269, 12].Value;
                f2.dataGridView5[13, 13].Value = f2.dataGridView1[269, 13].Value;
                f2.dataGridView5[13, 14].Value = f2.dataGridView1[269, 14].Value;
                f2.dataGridView5[13, 15].Value = f2.dataGridView1[269, 15].Value;
                f2.dataGridView5[13, 16].Value = f2.dataGridView1[269, 16].Value;

            }

            //C15: 272 - 275 / WASPAS WPM / TXTBOX16

            if (f2.textBox16.Text == "+")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[15].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[15].FormattedValue)).ToArray();

                double DIR = columnData.Max();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[272].Value = DIR; //copia el valor maximo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[274].Value = Convert.ToDouble(row.Cells[15].Value) / DIR;


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[274].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[273, 0].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 1].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 2].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 3].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 4].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 5].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 6].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 7].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 8].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 9].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 10].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 11].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 12].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 13].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 14].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 15].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 16].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 17].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 18].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 19].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 20].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 21].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 22].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 23].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 24].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 25].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 26].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 27].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 28].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 29].Value = f2.dataGridView4[15, 0].Value;

                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C2
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[275].Value = Math.Pow(Convert.ToDouble(row.Cells[274].Value), Convert.ToDouble(row.Cells[273].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[275].Value);

                //Generar 2da columna en matriz normalizada ponderada
                this.f2.dataGridView6.Columns.Add("RTWO", "C15");//revisar bien

                f2.dataGridView6[14, 0].Value = f2.dataGridView1[275, 0].Value;
                f2.dataGridView6[14, 1].Value = f2.dataGridView1[275, 1].Value;
                f2.dataGridView6[14, 2].Value = f2.dataGridView1[275, 2].Value;
                f2.dataGridView6[14, 3].Value = f2.dataGridView1[275, 3].Value;
                f2.dataGridView6[14, 4].Value = f2.dataGridView1[275, 4].Value;
                f2.dataGridView6[14, 5].Value = f2.dataGridView1[275, 5].Value;
                f2.dataGridView6[14, 6].Value = f2.dataGridView1[275, 6].Value;
                f2.dataGridView6[14, 7].Value = f2.dataGridView1[275, 7].Value;
                f2.dataGridView6[14, 8].Value = f2.dataGridView1[275, 8].Value;
                f2.dataGridView6[14, 9].Value = f2.dataGridView1[275, 9].Value;
                f2.dataGridView6[14, 10].Value = f2.dataGridView1[275, 10].Value;
                f2.dataGridView6[14, 11].Value = f2.dataGridView1[275, 11].Value;
                f2.dataGridView6[14, 12].Value = f2.dataGridView1[275, 12].Value;
                f2.dataGridView6[14, 13].Value = f2.dataGridView1[275, 13].Value;
                f2.dataGridView6[14, 14].Value = f2.dataGridView1[275, 14].Value;
                f2.dataGridView6[14, 15].Value = f2.dataGridView1[275, 15].Value;
                f2.dataGridView6[14, 16].Value = f2.dataGridView1[275, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C15");

                f2.dataGridView5[14, 0].Value = f2.dataGridView1[274, 0].Value;
                f2.dataGridView5[14, 1].Value = f2.dataGridView1[274, 1].Value;
                f2.dataGridView5[14, 2].Value = f2.dataGridView1[274, 2].Value;
                f2.dataGridView5[14, 3].Value = f2.dataGridView1[274, 3].Value;
                f2.dataGridView5[14, 4].Value = f2.dataGridView1[274, 4].Value;
                f2.dataGridView5[14, 5].Value = f2.dataGridView1[274, 5].Value;
                f2.dataGridView5[14, 6].Value = f2.dataGridView1[274, 6].Value;
                f2.dataGridView5[14, 7].Value = f2.dataGridView1[274, 7].Value;
                f2.dataGridView5[14, 8].Value = f2.dataGridView1[274, 8].Value;
                f2.dataGridView5[14, 9].Value = f2.dataGridView1[274, 9].Value;
                f2.dataGridView5[14, 10].Value = f2.dataGridView1[274, 10].Value;
                f2.dataGridView5[14, 11].Value = f2.dataGridView1[274, 11].Value;
                f2.dataGridView5[14, 12].Value = f2.dataGridView1[274, 12].Value;
                f2.dataGridView5[14, 13].Value = f2.dataGridView1[274, 13].Value;
                f2.dataGridView5[14, 14].Value = f2.dataGridView1[274, 14].Value;
                f2.dataGridView5[14, 15].Value = f2.dataGridView1[274, 15].Value;
                f2.dataGridView5[14, 16].Value = f2.dataGridView1[274, 16].Value;


            }

            //CRITERIO INVERSO C15 WPM WASPAS
            if (f2.textBox16.Text == "-")
            {
                double[] columnData = (from DataGridViewRow row in f2.dataGridView1.Rows
                                       where row.Cells[15].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[15].FormattedValue)).ToArray();

                double DIR = columnData.Min();

                foreach (DataGridViewRow row in f2.dataGridView1.Rows)

                    //row.Cells["Column3"].Value = Convert.ToDouble(row.Cells["Column2"].Value);
                    row.Cells[272].Value = DIR; //copia el valor minimo en la columna 51
                                                //Ahora dividir el valor individual sobre el valor maximo de la celda, probar en columna 2 DGV1

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar el resultado de la division de CDir de C2 a C59

                    row.Cells[274].Value = DIR / Convert.ToDouble(row.Cells[15].Value);


                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la segunda matriz (a DGV2)

                    f2.dataGridView5.Rows.Add(row.Cells[274].Value);

                //del textbox1 (o de otra columna en dado caso) pasar a datagridview1 el peso introducido

                f2.dataGridView1.Rows.Add();


                f2.dataGridView1[273, 0].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 1].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 2].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 3].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 4].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 5].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 6].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 7].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 8].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 9].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 10].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 11].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 12].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 13].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 14].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 15].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 16].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 17].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 18].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 19].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 20].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 21].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 22].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 23].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 24].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 25].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 26].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 27].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 28].Value = f2.dataGridView4[15, 0].Value;
                f2.dataGridView1[273, 29].Value = f2.dataGridView4[15, 0].Value;


                //MATRIZ NORMALIZADA PONDERADA DE CRITERIO DIRECTO C4
                //Multiplicar los pesos c52 por c53 y mostrarlo en c54
                foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                    row.Cells[275].Value = Math.Pow(Convert.ToDouble(row.Cells[274].Value), Convert.ToDouble(row.Cells[273].Value));

                foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                    f2.dataGridView6.Rows.Add(row.Cells[275].Value);

                //generar matriz normalizada ponderada wpm
                this.f2.dataGridView6.Columns.Add("RTWO", "C15");//revisar bien

                f2.dataGridView6[14, 0].Value = f2.dataGridView1[275, 0].Value;
                f2.dataGridView6[14, 1].Value = f2.dataGridView1[275, 1].Value;
                f2.dataGridView6[14, 2].Value = f2.dataGridView1[275, 2].Value;
                f2.dataGridView6[14, 3].Value = f2.dataGridView1[275, 3].Value;
                f2.dataGridView6[14, 4].Value = f2.dataGridView1[275, 4].Value;
                f2.dataGridView6[14, 5].Value = f2.dataGridView1[275, 5].Value;
                f2.dataGridView6[14, 6].Value = f2.dataGridView1[275, 6].Value;
                f2.dataGridView6[14, 7].Value = f2.dataGridView1[275, 7].Value;
                f2.dataGridView6[14, 8].Value = f2.dataGridView1[275, 8].Value;
                f2.dataGridView6[14, 9].Value = f2.dataGridView1[275, 9].Value;
                f2.dataGridView6[14, 10].Value = f2.dataGridView1[275, 10].Value;
                f2.dataGridView6[14, 11].Value = f2.dataGridView1[275, 11].Value;
                f2.dataGridView6[14, 12].Value = f2.dataGridView1[275, 12].Value;
                f2.dataGridView6[14, 13].Value = f2.dataGridView1[275, 13].Value;
                f2.dataGridView6[14, 14].Value = f2.dataGridView1[275, 14].Value;
                f2.dataGridView6[14, 15].Value = f2.dataGridView1[275, 15].Value;
                f2.dataGridView6[14, 16].Value = f2.dataGridView1[275, 16].Value;


                //Faltan agregar los primeros datos de la C2 a la primer matriz DGV2

                this.f2.dataGridView5.Columns.Add("RTWO", "C15");

                f2.dataGridView5[14, 0].Value = f2.dataGridView1[274, 0].Value;
                f2.dataGridView5[14, 1].Value = f2.dataGridView1[274, 1].Value;
                f2.dataGridView5[14, 2].Value = f2.dataGridView1[274, 2].Value;
                f2.dataGridView5[14, 3].Value = f2.dataGridView1[274, 3].Value;
                f2.dataGridView5[14, 4].Value = f2.dataGridView1[274, 4].Value;
                f2.dataGridView5[14, 5].Value = f2.dataGridView1[274, 5].Value;
                f2.dataGridView5[14, 6].Value = f2.dataGridView1[274, 6].Value;
                f2.dataGridView5[14, 7].Value = f2.dataGridView1[274, 7].Value;
                f2.dataGridView5[14, 8].Value = f2.dataGridView1[274, 8].Value;
                f2.dataGridView5[14, 9].Value = f2.dataGridView1[274, 9].Value;
                f2.dataGridView5[14, 10].Value = f2.dataGridView1[274, 10].Value;
                f2.dataGridView5[14, 11].Value = f2.dataGridView1[274, 11].Value;
                f2.dataGridView5[14, 12].Value = f2.dataGridView1[274, 12].Value;
                f2.dataGridView5[14, 13].Value = f2.dataGridView1[274, 13].Value;
                f2.dataGridView5[14, 14].Value = f2.dataGridView1[274, 14].Value;
                f2.dataGridView5[14, 15].Value = f2.dataGridView1[274, 15].Value;
                f2.dataGridView5[14, 16].Value = f2.dataGridView1[274, 16].Value;

            }

            //RESULTADOS WSM

            //Sigue que en DGV5 ponga la sumatoria total del DGV3 (weighted normalized decision matrix)
            //Si voy a sumar columnas se supone que me puede servir esto:
            f2.dataGridView7.Visible = true;
            foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                row.Cells[201].Value = Convert.ToDouble(row.Cells[54].Value) + Convert.ToDouble(row.Cells[60].Value) + Convert.ToDouble(row.Cells[65].Value) + Convert.ToDouble(row.Cells[70].Value) + Convert.ToDouble(row.Cells[75].Value) + Convert.ToDouble(row.Cells[80].Value) + Convert.ToDouble(row.Cells[85].Value) + Convert.ToDouble(row.Cells[90].Value) + Convert.ToDouble(row.Cells[95].Value) + Convert.ToDouble(row.Cells[100].Value) + Convert.ToDouble(row.Cells[105].Value) + Convert.ToDouble(row.Cells[110].Value) + Convert.ToDouble(row.Cells[115].Value) + Convert.ToDouble(row.Cells[120].Value) + Convert.ToDouble(row.Cells[125].Value) + Convert.ToDouble(row.Cells[130].Value) + Convert.ToDouble(row.Cells[135].Value) + Convert.ToDouble(row.Cells[140].Value) + Convert.ToDouble(row.Cells[145].Value) + Convert.ToDouble(row.Cells[150].Value) + Convert.ToDouble(row.Cells[155].Value) + Convert.ToDouble(row.Cells[160].Value) + Convert.ToDouble(row.Cells[165].Value) + Convert.ToDouble(row.Cells[170].Value) + Convert.ToDouble(row.Cells[175].Value) + Convert.ToDouble(row.Cells[180].Value) + Convert.ToDouble(row.Cells[185].Value) + Convert.ToDouble(row.Cells[190].Value) + Convert.ToDouble(row.Cells[195].Value) + Convert.ToDouble(row.Cells[200].Value);

            foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                f2.dataGridView7.Rows.Add(row.Cells[201].Value);



            //RESULTADOS WPM

            foreach (DataGridViewRow rw in this.f2.dataGridView1.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null)
                    {
                        rw.Cells[i].Value = 1;

                    }
                }
            }

            foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                row.Cells[351].Value = Convert.ToDouble(row.Cells[205].Value) * Convert.ToDouble(row.Cells[210].Value) * Convert.ToDouble(row.Cells[215].Value) * Convert.ToDouble(row.Cells[220].Value) * Convert.ToDouble(row.Cells[225].Value) * Convert.ToDouble(row.Cells[230].Value) * Convert.ToDouble(row.Cells[235].Value) * Convert.ToDouble(row.Cells[240].Value) * Convert.ToDouble(row.Cells[245].Value) * Convert.ToDouble(row.Cells[250].Value) * Convert.ToDouble(row.Cells[255].Value) * Convert.ToDouble(row.Cells[260].Value) * Convert.ToDouble(row.Cells[265].Value) * Convert.ToDouble(row.Cells[270].Value) * Convert.ToDouble(row.Cells[275].Value) * Convert.ToDouble(row.Cells[280].Value) * Convert.ToDouble(row.Cells[285].Value) * Convert.ToDouble(row.Cells[290].Value) * Convert.ToDouble(row.Cells[295].Value) * Convert.ToDouble(row.Cells[300].Value) * Convert.ToDouble(row.Cells[305].Value) * Convert.ToDouble(row.Cells[310].Value) * Convert.ToDouble(row.Cells[315].Value) * Convert.ToDouble(row.Cells[320].Value) * Convert.ToDouble(row.Cells[325].Value) * Convert.ToDouble(row.Cells[330].Value) * Convert.ToDouble(row.Cells[335].Value) * Convert.ToDouble(row.Cells[340].Value) * Convert.ToDouble(row.Cells[345].Value) * Convert.ToDouble(row.Cells[350].Value);

            foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                f2.dataGridView8.Rows.Add(row.Cells[351].Value);

            f2.dataGridView8.Columns[0].HeaderText = "WPM RESULTS";

            //SIGUE LAMBDA

            double lambda = Convert.ToDouble(textBox1.Text);
            //EL PROCESO DE LA MULTIPLICACION DE LAMBDA SE HACE DGV1
            //Y SE REFLEJA EN C352

            foreach (DataGridViewRow row in f2.dataGridView1.Rows)
                row.Cells[352].Value = lambda * Convert.ToDouble(row.Cells[201].Value) + lambda * Convert.ToDouble(row.Cells[351].Value);

            //PASAR LOS RESULTADOS A DGV9

            foreach (DataGridViewRow row in f2.dataGridView1.Rows) //Copiar de la primera (DGV1) a la tercera matriz (a DGV3)

                f2.dataGridView9.Rows.Add(row.Cells[352].Value);



            foreach (DataGridViewRow rw in this.f2.dataGridView1.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value.ToString() == "1")
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }


            foreach (DataGridViewRow rw in this.f2.dataGridView2.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    double infinity = double.PositiveInfinity;
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value.ToString() == "0" || rw.Cells[i].Value.ToString() == "NaN" || Convert.ToDouble(rw.Cells[i].Value) == infinity)
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }

            foreach (DataGridViewRow rw in this.f2.dataGridView3.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    double infinity = double.PositiveInfinity;
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value.ToString() == "0" || rw.Cells[i].Value.ToString() == "NaN" || Convert.ToDouble(rw.Cells[i].Value) == infinity)
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }

            foreach (DataGridViewRow rw in this.f2.dataGridView5.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    double infinity = double.PositiveInfinity;
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value.ToString() == "0" || rw.Cells[i].Value.ToString() == "NaN" || Convert.ToDouble(rw.Cells[i].Value) == infinity)
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }

            foreach (DataGridViewRow rw in this.f2.dataGridView6.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    double infinity = double.PositiveInfinity;
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value.ToString() == "0" || rw.Cells[i].Value.ToString() == "NaN" || Convert.ToDouble(rw.Cells[i].Value) == infinity)
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }

            foreach (DataGridViewRow rw in this.f2.dataGridView7.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    double infinity = double.PositiveInfinity;
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value.ToString() == "0" || rw.Cells[i].Value.ToString() == "NaN" || Convert.ToDouble(rw.Cells[i].Value) == infinity)
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }

            foreach (DataGridViewRow rw in this.f2.dataGridView8.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    double infinity = double.PositiveInfinity;
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value.ToString() == "0" || rw.Cells[i].Value.ToString() == "NaN" || Convert.ToDouble(rw.Cells[i].Value) == infinity)
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }

            foreach (DataGridViewRow rw in this.f2.dataGridView9.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    double infinity = double.PositiveInfinity;
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value.ToString() == "0" || rw.Cells[i].Value.ToString() == "NaN" || Convert.ToDouble(rw.Cells[i].Value) == infinity)
                    {
                        rw.Cells[i].Value = null;

                    }
                }
            }


            this.f2.dataGridView9.Columns.Add("RTWO", "ALTERNATIVES");//revisar bien

            f2.dataGridView9[1, 0].Value = "A1";
            f2.dataGridView9[1, 1].Value = "A2";
            f2.dataGridView9[1, 2].Value = "A3";
            f2.dataGridView9[1, 3].Value = "A4";
            f2.dataGridView9[1, 4].Value = "A5";
            f2.dataGridView9[1, 5].Value = "A6";
            f2.dataGridView9[1, 6].Value = "A7";
            f2.dataGridView9[1, 7].Value = "A8";
            f2.dataGridView9[1, 8].Value = "A9";
            f2.dataGridView9[1, 9].Value = "A10";
            f2.dataGridView9[1, 10].Value = "A11";
            f2.dataGridView9[1, 11].Value = "A12";
            f2.dataGridView9[1, 12].Value = "A13";
            f2.dataGridView9[1, 13].Value = "A14";
            f2.dataGridView9[1, 14].Value = "A15";


            //Mejor decision en dataGridview5
            double[] wpmBD = (from DataGridViewRow row in f2.dataGridView9.Rows
                              where row.Cells[0].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[0].FormattedValue)).ToArray();

            double WPMT = wpmBD.Max();

            foreach (DataGridViewRow ku in this.f2.dataGridView9.Rows)
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

            f2.dataGridView10[3, 0].Value = f2.dataGridView1[352, 0].Value;
            f2.dataGridView10[3, 1].Value = f2.dataGridView1[352, 1].Value;
            f2.dataGridView10[3, 2].Value = f2.dataGridView1[352, 2].Value;
            f2.dataGridView10[3, 3].Value = f2.dataGridView1[352, 3].Value;
            f2.dataGridView10[3, 4].Value = f2.dataGridView1[352, 4].Value;
            f2.dataGridView10[3, 5].Value = f2.dataGridView1[352, 5].Value;
            f2.dataGridView10[3, 6].Value = f2.dataGridView1[352, 6].Value;
            f2.dataGridView10[3, 7].Value = f2.dataGridView1[352, 7].Value;
            f2.dataGridView10[3, 8].Value = f2.dataGridView1[352, 8].Value;
            f2.dataGridView10[3, 9].Value = f2.dataGridView1[352, 9].Value;
            f2.dataGridView10[3, 10].Value = f2.dataGridView1[352, 10].Value;
            f2.dataGridView10[3, 11].Value = f2.dataGridView1[352, 11].Value;
            f2.dataGridView10[3, 12].Value = f2.dataGridView1[352, 12].Value;
            f2.dataGridView10[3, 13].Value = f2.dataGridView1[352, 13].Value;
            f2.dataGridView10[3, 14].Value = f2.dataGridView1[352, 14].Value;
            f2.dataGridView10[3, 15].Value = f2.dataGridView1[352, 15].Value;
            f2.dataGridView10[3, 16].Value = f2.dataGridView1[352, 16].Value;


            //ELIMINAR DE DATAGRIDVIEW5 LOS 0 y NaN y los infinito
            foreach (DataGridViewRow rw in this.f2.dataGridView10.Rows)//En valores nulos agregar los 1 para evitar errores de multiplicacion
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

            f2.label27.Visible = true;
            f2.label27.Text = "WSM Method";

            f2.label32.Visible = true;
            f2.label32.Text = "WPM Method";

            f2.dataGridView2.DefaultCellStyle.Format = "F4";
            f2.dataGridView3.DefaultCellStyle.Format = "F4";
            f2.dataGridView5.DefaultCellStyle.Format = "F4";
            f2.dataGridView6.DefaultCellStyle.Format = "F4";
            f2.dataGridView7.DefaultCellStyle.Format = "F4";
            f2.dataGridView8.DefaultCellStyle.Format = "F4";
            f2.dataGridView9.DefaultCellStyle.Format = "F4";
            f2.dataGridView10.DefaultCellStyle.Format = "F4";

            if (f2.dataGridView2.Visible == true)
            {
                f2.button7.Visible = true;
            }
            else
            {
                f2.button7.Visible = false;
            }

            if (f2.dataGridView3.Visible == true)
            {
                f2.button8.Visible = true;
            }
            else
            {
                f2.button8.Visible = false;
            }

            if (f2.dataGridView5.Visible == true)
            {
                f2.button9.Visible = true;
            }
            else
            {
                f2.button9.Visible = false;
            }

            if (f2.dataGridView6.Visible == true)
            {
                f2.button16.Visible = true;
            }
            else
            {
                f2.button16.Visible = false;
            }


            if (f2.dataGridView7.Visible == true)
            {
                f2.button18.Visible = true;
            }
            else
            {
                f2.button18.Visible = false;
            }


            if (f2.dataGridView8.Visible == true)
            {
                f2.button19.Visible = true;
            }
            else
            {
                f2.button19.Visible = false;
            }

            if (f2.dataGridView9.Visible == true)
            {
                f2.button20.Visible = true;
            }
            else
            {
                f2.button20.Visible = false;
            }

            if (f2.dataGridView10.Visible == true)
            {
                f2.button21.Visible = true;
            }
            else
            {
                f2.button21.Visible = false;
            }

        }
    }
}
