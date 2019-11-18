using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace To_Do_List
{
    public partial class Ingresar_Datos : Form
    {
        int poc;
        public Ingresar_Datos()
        {
            InitializeComponent();
            Limpiar();
        }
        //Este metodo sirve para limpiar los datos de los textbox
        void Limpiar()
        {
            Modificarbtn.Enabled = false;
            Eliminarbtn.Enabled = false;
            Nametxt.Text = "";
            Tareatxt.Text = "";
            Horatxt.Text = "";
            Datetxt.Text = "";
            Statustxt.Text = "";
        }
        //En este metodo captura los datos de las text box
        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            Tarea t = new Tarea();
            t.Name = Nametxt.Text;
            t.Tareas = Tareatxt.Text;
            t.Hora = Horatxt.Text;
            t.Fecha = Datetxt.Text;
            t.Status = Statustxt.Text;
            dataGridView1.Rows.Add(Nametxt.Text, Tareatxt.Text, Horatxt.Text, Datetxt.Text, Statustxt.Text);
            Limpiar();
            
        }
        //Este es boton que nos permite modificar los datos del data grid
        private void Siguientebtn_Click(object sender, EventArgs e)
        {
            dataGridView1[0, poc].Value = Nametxt.Text;
            dataGridView1[1, poc].Value = Tareatxt.Text;
            dataGridView1[2, poc].Value = Horatxt.Text;
            dataGridView1[3, poc].Value = Datetxt.Text;
            dataGridView1[4, poc].Value = Statustxt.Text;
        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }
        //Aqui se agregan los datos al data grid
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridView1.CurrentRow.Index;
            Nametxt.Text = dataGridView1[0, poc].Value.ToString();
            Tareatxt.Text = dataGridView1[1, poc].Value.ToString();
            Horatxt.Text = dataGridView1[2, poc].Value.ToString();
            Datetxt.Text = dataGridView1[3, poc].Value.ToString();
            Statustxt.Text = dataGridView1[4,poc].Value.ToString();
            Agregarbtn.Enabled = false;
            Modificarbtn.Enabled = true;
            Eliminarbtn.Enabled = true;
        }

        private void Limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
            Agregarbtn.Enabled = true;
        }
        //Este es el boton que nos permite borrar un campo
        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(poc);

        }
    }
}
