using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_Buttom_Click(object sender, EventArgs e)
        {
            ErrorProvider ep = new ErrorProvider();
            if (Matricula.Text == "")
            {
                ep.SetError(Matricula, "No ha ingresado matricula");
            }
            else if (Nombre.Text == "")
            {
                ep.SetError(Nombre, "No ha ingresado nombre");
            }
            else if (Semestre.Text == "")
            {
                ep.SetError(Semestre, "No ha ingresado el semestre");
            }
            else if(Carrera.Text == "")
            {
                ep.SetError(Carrera, "No ha ingresado la carrera");
            }
            else if(Telefono.Text == "")
            {
                ep.SetError(Telefono, "No ha ingresado el telefono");
            }
            try
            {
                Alumno alumno = new Alumno();
                alumno.Matricula = Convert.ToInt32(Matricula.Text);
                alumno.Nombre = Nombre.Text;
                alumno.Semestre = Convert.ToInt32(Semestre.Text);
                alumno.Carrera = Carrera.Text;
                alumno.Telefono = Convert.ToInt32(Telefono.Text);
                throw new Specia_Exception("Su alumno se creo exitosamente");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Falla al registrar alumno"+ ex.Message);
            }
            catch (Specia_Exception espEx)
            {
                MessageBox.Show(espEx.Message);
            }
            finally
            {
                ep.Clear();
            }
        }

        private void Caltxt_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int cal = Convert.ToInt32(Caltxt.Text);
                if(cal < 1 || cal > 10)
                {
                    MessageBox.Show("Ingrese una calificacion del 1 - 10", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de calificacion", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                
            }
        }
    }
}
