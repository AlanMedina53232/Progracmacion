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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        //Aqui verificamos si el archivo donde se guardaran los datos de usuario existe de lo contrario creara uno nuevo
        List<string> datos = new List<string>();
        public List<string> ObtenerLineas(string ruta)
        {
            string[] data = null;
            if (File.Exists(ruta))
            {
                data = File.ReadAllLines(ruta);
            }
            else
            {
                MessageBox.Show("No existe el archivo");
            }
            foreach (var item in data)
            {
                datos.Add(item);
            }
            return datos;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            //Aqui se guardan los datos en el archivo ya creado
            void Registrar_Usuario(User us, string path)
            {
                string data = us.Name + "," + us.Username + "," + us.Password;
                var dato = ObtenerLineas(path);
                if (dato != null)
                {
                    dato.Add(data);
                    File.WriteAllLines(path, dato);
                    MessageBox.Show("El registro se realizo exitosamente");
                }
                else
                {
                    File.WriteAllText(path, data);
                }
            }
            //Aqui capturamos los datos de las text box
            User u = new User();
            u.Name = Nametxt.Text;
            u.Username = Usernametxt.Text;
            u.Password = Passwordtxt.Text;
            Registrar_Usuario(u, "Archivo.txt");
        }
        //Este boton nos regresa a la pantalla de inicio de secion
        private void Regresarbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
