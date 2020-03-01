using Register_SCJ_WinForms.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_SCJ_WinForms
{
    public partial class Form1 : Form
    {
        private PersonaController Persona_Controller { get; set; }
        public Form1()
        {
            InitializeComponent();
            Persona_Controller = new PersonaController(this);

            Persona_Controller.GetAlumnos();
        }
    }
}
