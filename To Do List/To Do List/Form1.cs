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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //Aqui se validan los datos para el inicio de secion
        public void ValidarDatos(User u, List<string> datos)
        {
            List<User> usuarios = new List<User>();
            foreach (var item in datos)
            {
                string[] info = item.Split(',');
                usuarios.Add(new User { Name = info[0], Username = info[1], Password = info[2] });
            }
            foreach (var us in usuarios)
            {
                if (u.Username == us.Username && u.Password == us.Password)
                {

                    Ingresar_Datos i = new Ingresar_Datos();
                    i.Show();
                    this.Hide();
                }
            }
            
        }
        //Este es el boton que nos lleva a registrar el usuario en caso de que no exista alguno.
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Registro d = new Registro();
            
                d.Show();
                this.Hide();
            
        }
        //Este es el boton para iniciar secion
        private void LogInbtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            Registro r = new Registro();
            string ruta = "Archivo.txt";
            List<string> datos = r.ObtenerLineas(ruta);
            user.Username = Usertxt.Text;
            user.Password = Passwordtxt.Text;
            ValidarDatos(user,datos);
            
            
        }
    }
}
