using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana09
{
    public partial class FrmAlumnos : Form
    {
        ListaAlumnos lista = Globales._lista;
        //private ListaAlumnos listaAlumno;

        //internal ListaAlumnos ListaAlumno
        //{
        //    get
        //    {
        //        return listaAlumno;
        //    }

        //    set
        //    {
        //        listaAlumno = value;
        //    }
        //}

        public FrmAlumnos()
        {
            InitializeComponent();
        }

       

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            lista.imprimir(dgvLista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.registrar(new Alumno("600", "C", "C", "C", "1234"));
        }
    }
}
