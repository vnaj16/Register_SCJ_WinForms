using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_SCJ_WinForms.Models
{
    public class dAlumno : DataBase
    {
        public dAlumno()
        {

        }

        public bool Insert(Alumno obj, out string message)
        {
            try
            {
                Conexion.Open();
                string INSERT = string.Format($"INSERT INTO ALUMNO(Nombres,Apellidos,DNI) VALUES('{obj.Nombre}','{obj.Apellidos}','{obj.DNI}')");
                SqlCommand Comando = new SqlCommand(INSERT, Conexion);
                Comando.ExecuteNonQuery();

                message = "Alumno Registrado";
                return true;
            }
            catch (Exception e) { message = e.Message; return false; }
            finally { Conexion.Close(); }
        }

        public IEnumerable<Alumno> GetAlumnos()
        {
            try
            {
                List<Alumno> Lista_Alumnos = new List<Alumno>();


                Conexion.Open();
                string SELECT = string.Format("SELECT * FROM ALUMNO");
                SqlCommand Comando = new SqlCommand(SELECT, Conexion);
                SqlDataReader Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    Alumno aux = new Alumno();
                    aux.ID = Convert.ToInt32(Reader["ID"]);
                    aux.Nombre = Convert.ToString(Reader["Nombres"]);
                    aux.Apellidos = Convert.ToString(Reader["Apellidos"]);
                    aux.DNI = Convert.ToString(Reader["DNI"]);

                    Lista_Alumnos.Add(aux);
                }


                Reader.Close();
                return Lista_Alumnos.AsEnumerable<Alumno>();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Conexion.Close();
            }
        }

        public IEnumerable<Alumno> GetAlumnos(string Filter,int Tipo)//Aca agregar el filtro y el tipo
        {//1: Nombre, 2: Apellido, 3: DNI
            try
            {
                List<Alumno> Lista_Alumnos = new List<Alumno>();


                Conexion.Open();
                string Condicion;
                switch (Tipo)
                {
                    case 1:
                        Condicion = "Nombres";
                        break;
                    case 2:
                        Condicion = "Apellidos";
                        break;
                    case 3:
                        Condicion = "DNI";
                        break;
                    default:
                        Condicion = "";
                        break;
                }
                Condicion += " LIKE @Filter + '%'";

                string SELECT = string.Format($"SELECT * FROM ALUMNO WHERE " + Condicion);
                SqlCommand Comando = new SqlCommand(SELECT, Conexion);
                Comando.Parameters.AddWithValue("@Filter", Filter);
                SqlDataReader Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    Alumno aux = new Alumno();
                    aux.ID = Convert.ToInt32(Reader["ID"]);
                    aux.Nombre = Convert.ToString(Reader["Nombres"]);
                    aux.Apellidos = Convert.ToString(Reader["Apellidos"]);
                    aux.DNI = Convert.ToString(Reader["DNI"]);

                    Lista_Alumnos.Add(aux);
                }


                Reader.Close();
                return Lista_Alumnos.AsEnumerable<Alumno>();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Conexion.Close();
            }
        }


    }
}
