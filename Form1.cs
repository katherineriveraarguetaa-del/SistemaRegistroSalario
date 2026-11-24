using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasRegistrosSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            using (var cn = conexion.Conectar())
            {
                try
                {
                    cn.Open();
                    MessageBox.Show("¡Conexión exitosa con SQL Server!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        
        }
           
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        



            //PROYECTO: SISTEMAS DE RESGISTRO DE SALARIO 

            //escribir abajo de esta fila el Array


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variables 
            string nombreEmpleado = txt_Nombre.Text;
            decimal salarioBruto = Convert.ToDecimal(txt_salarioB.Text);
            decimal porcentajeAFP =0.0725m; //Descuento de AFP (725% = 0.0725)
            porcentajeAFP = Convert.ToDecimal(txt_PAFP.Text);
            decimal AFP;

            //primera operacion multiplicacion
            AFP = (salarioBruto * porcentajeAFP);

            txt_AFP.Text = AFP.ToString("N2");

            decimal salarioNeto;

            //segunda operacion resta

            salarioNeto = (salarioBruto - AFP);

            txt_salarioN.Text = salarioNeto.ToString("N2");

            


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
