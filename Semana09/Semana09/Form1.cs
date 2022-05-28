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

namespace Semana09
{
    public partial class Form1 : Form
    {
        ListaAlumnos lista = Globales._lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            if (ofdCargaMasiva.ShowDialog() == DialogResult.OK)
            {
                lista.cargaMasiva(ofdCargaMasiva.FileName);
                lista.imprimir(dgvLista);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmAlumnos frm = new FrmAlumnos();
            //frm.ListaAlumno = lista;
            frm.ShowDialog();
        }

        private void btnCargaMasivaLocal_Click(object sender, EventArgs e)
        {
            //txtNombres.Text= Environment.CurrentDirectory;
            string ruta = Path.GetFullPath("../../archivos/carga_masiva_18829.txt");
            lista.cargaMasiva(ruta);
            lista.imprimir(dgvLista);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lista.imprimir(dgvLista);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string ruta = Path.GetFullPath("../../archivos/carga_masiva_18829.txt");
            lista = new ListaAlumnos();
            lista.guardar(new Alumno(
                txtCodigo.Text,
                txtNombres.Text,
                txtApaterno.Text,
                txtAmaterno.Text,
                txtTelefono.Text
                ), ruta);
            lista.cargaMasiva(ruta);
            lista.imprimir(dgvLista);
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            int fila = dgvLista.SelectedRows[0].Index;

            if (fila >= 0) {
                txtCodigo.Text = dgvLista.Rows[fila].Cells[0].Value.ToString();
                txtNombres.Text = dgvLista.Rows[fila].Cells[1].Value.ToString();
                txtApaterno.Text = dgvLista.Rows[fila].Cells[2].Value.ToString();
                txtAmaterno.Text = dgvLista.Rows[fila].Cells[3].Value.ToString();
                txtTelefono.Text = dgvLista.Rows[fila].Cells[4].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string ruta = Path.GetFullPath("../../archivos/carga_masiva_18829.txt");
            lista = new ListaAlumnos();
            lista.modificar(new Alumno(
                txtCodigo.Text,
                txtNombres.Text,
                txtApaterno.Text,
                txtAmaterno.Text,
                txtTelefono.Text
                ), ruta);
            lista.cargaMasiva(ruta);
            lista.imprimir(dgvLista);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ruta = Path.GetFullPath("../../archivos/carga_masiva_18829.txt");
            lista = new ListaAlumnos();
            lista.eliminar(txtCodigo.Text, ruta);
            lista.cargaMasiva(ruta);
            lista.imprimir(dgvLista);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string ruta = Path.GetFullPath("../../archivos/carga_masiva_18829.txt");
            txtResultado.Text = lista.obtenerLineaAleatoria(ruta);
        }

        private void btnAccesoAleatorio_Click(object sender, EventArgs e)
        {
            if (btnAccesoAleatorio.Text == "STOP")
            {
                timer1.Interval = 10000;
                btnAccesoAleatorio.Text = "STAR";
            }else
            {
                timer1.Interval = 100;
                btnAccesoAleatorio.Text = "STOP";
            }
        }
    }
}
