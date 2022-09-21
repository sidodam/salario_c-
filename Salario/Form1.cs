using System;

namespace Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             try {


                String nombre = campoNombre.Text.ToString();


                
                    Double salario = double.Parse(campoSalario.Text);
                          salario = Math.Abs(salario);
                          campoSalario.Text = Math.Abs(double.Parse(campoSalario.Text)).ToString() ;




                if (radioButton1.Checked)
                {
                    result.Text = "nombre: " + nombre +
                     "\r\n" +
                      "el salario antiguo: " + (salario).ToString() + "\r\n" +
                     "el salario nuevo: " + (salario * 0.8).ToString() + "\r\n" +
                     "tipo de empleado:" + radioButton1.Text + "\r\n" +
                     "cantidad de descuento: " + (salario * 0.2).ToString();

  ;
                }

                    else if (radioButton2.Checked)
                    {

                    result.Text = "nombre: " + nombre +
                "\r\n" +
                 "el salario antiguo: " + (salario).ToString() + "\r\n" +
                "el salario nuevo: " + (salario * 0.85).ToString() + "\r\n" +
                "tipo de empleado:" + radioButton1.Text + "\r\n" +
                "cantidad de descuento: " + (salario * 0.15).ToString();

                }

                else if (radioButton3.Checked)
                    {

                    result.Text = "nombre: " + nombre +
                  "\r\n" +
                   "el salario antiguo: " + (salario).ToString() + "\r\n" +
                  "el salario nuevo: " + (salario * 0.95).ToString() + "\r\n" +
                  "tipo de empleado:" + radioButton1.Text + "\r\n" +
                  "cantidad de descuento: " + (salario * 0.05).ToString();

                }









            }
            catch  {
                   MessageBox.Show("el salario es invalido" ,"error" ,  MessageBoxButtons.OK ,
                            MessageBoxIcon.Error);


    
            }


           
             
                      
                
            
        }

        private void salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}