using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Forms;
using Register_SCJ_WinForms.Models;

namespace Register_SCJ_WinForms.Controllers
{
    public class PersonaController
    {
        public dAlumno AlumnoDB { get; set; }
        public Form1 AlumnoView { get; set; }
        public PersonaController(Form1 View)
        {
            AlumnoDB = new dAlumno();
            AlumnoView = View;
            AlumnoView.TextBox_BuscarNombre.TextChanged += new EventHandler(Buscar);
            AlumnoView.TextBox_BuscarApellido.TextChanged += new EventHandler(Buscar);
            AlumnoView.TextBox_BuscarDNI.TextChanged += new EventHandler(Buscar);
            AlumnoView.Button_Registrar.Click += new EventHandler(Registrar_Alumno);
        }

        public void GetAlumnos()
        {
            AlumnoView.DataGrid_Alumnos.DataSource = AlumnoDB.GetAlumnos().ToList();
        }

        public void Registrar_Alumno(object sender, EventArgs e)
        {
            if (AlumnoView.TextBox_Nombres.Text.Equals("") || AlumnoView.TextBox_Apellidos.Text.Equals(""))
            {
                MessageBox.Show("Completar los campos Nombres y Apellidos");
            }
            else
            {
                Alumno new_Alumno = new Alumno(AlumnoView.TextBox_Nombres.Text, AlumnoView.TextBox_Apellidos.Text, AlumnoView.Textbox_DNI.Text);
                if (AlumnoView.CheckBox_Confirmacion.Checked)
                {
                    MessageBoxResult result = MessageBox.Show(string.Format($"Se ingresará el alumno {new_Alumno.ToString()} al sistema"), "Confirmacion de registro", MessageBoxButton.YesNoCancel);
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            string message;
                            if (AlumnoDB.Insert(new_Alumno, out message))
                            {
                                AlumnoView.DataGrid_Alumnos.DataSource = AlumnoDB.GetAlumnos().ToList();
                                MessageBox.Show("Alumno Registrado", "Registro completo");
                            }
                            else
                            {
                                MessageBox.Show("Algo salio mal.\nIntentalo nuevamente.\n" + message, "Confirmacion de registro");
                            }

                            break;
                        case MessageBoxResult.No:

                            break;
                        case MessageBoxResult.Cancel:
                            MessageBox.Show("Registro Cancelado", "Confirmacion de registro");
                            break;
                    }
                }
                else
                {
                    string message;
                    if (AlumnoDB.Insert(new_Alumno, out message))
                    {
                        AlumnoView.DataGrid_Alumnos.DataSource = AlumnoDB.GetAlumnos().ToList();
                        MessageBox.Show("Alumno Registrado", "Registro completo");
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal.\nIntentalo nuevamente.\n" + message, "Confirmacion de registro");
                    }
                }
            }
        }

        public void Buscar(object sender, EventArgs e)
        {//1: Nombre, 2: Apellido, 3: DNI
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox.Name.Contains("Nombre"))
            {
                AlumnoView.DataGrid_Alumnos.DataSource = AlumnoDB.GetAlumnos(textBox.Text, 1);
                AlumnoView.TextBox_BuscarApellido.Clear();
                AlumnoView.TextBox_BuscarDNI.Clear();
            }
            else if (textBox.Name.Contains("Apellido"))
            {
                AlumnoView.DataGrid_Alumnos.DataSource = AlumnoDB.GetAlumnos(textBox.Text, 2).ToList();
                AlumnoView.TextBox_BuscarNombre.Clear();
                AlumnoView.TextBox_BuscarDNI.Clear();
            }
            else if (textBox.Name.Contains("DNI"))
            {
                AlumnoView.DataGrid_Alumnos.DataSource = AlumnoDB.GetAlumnos(textBox.Text, 3).ToList();
                AlumnoView.TextBox_BuscarNombre.Clear();
                AlumnoView.TextBox_BuscarApellido.Clear();
            }
        }
    }
}
