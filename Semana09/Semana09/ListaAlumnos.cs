using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace Semana09
{
    class ListaAlumnos
    {

        private ArrayList lista;

        public ListaAlumnos()
        {
            lista = new ArrayList();
        }

        public void registrar(Alumno dato)
        {
            lista.Add(dato);
        }

        public void cargaMasiva(string ruta)
        {
            StreamReader leer = new StreamReader(ruta);
            while (!leer.EndOfStream)
            {
                string linea = leer.ReadLine();
                string[] campos = linea.Split('|');
                registrar(new Alumno(
                    campos[0], //codigo
                    campos[1], //nombres
                    campos[2], //apaterno
                    campos[3], //amaterno
                    campos[4] // telefono
                    ));
            }

            leer.Close();
        }
        
        public void imprimir(DataGridView DGV)
        {
            DGV.Rows.Clear();
            foreach (Alumno x in lista)
                DGV.Rows.Add(
                    x.codigo,
                    x.nombres,
                    x.apaterno,
                    x.amaterno,
                    x.telefono
                    );
        }

        public void guardar(Alumno dato, string ruta)
        {
            StreamWriter escribir = new StreamWriter(ruta, true);
            escribir.Write("\r{0}|{1}|{2}|{3}|{4}",
                dato.codigo,
                dato.nombres,
                dato.apaterno,
                dato.amaterno,
                dato.telefono
                );
            escribir.Close();
        }

        public void modificar(Alumno dato, string rutaOriginal)
        {
            StreamReader leer = new StreamReader(rutaOriginal);
            StreamWriter escribir = new StreamWriter("C:\\Users\\Carlos\\Documents\\tempo.txt",true);

            while (!leer.EndOfStream)
            {
                string linea = leer.ReadLine();
                string[] campos = linea.Split('|');

                if (campos[0].Equals(dato.codigo))
                {
                    escribir.WriteLine("{0}|{1}|{2}|{3}|{4}",
                        dato.codigo,
                        dato.nombres,
                        dato.apaterno,
                        dato.amaterno,
                        dato.telefono
                     );
                }
                else escribir.WriteLine(linea);
            }

            leer.Close();
            escribir.Close();

            //realizamos el intercambio
            File.Delete(rutaOriginal);
            File.Move("C:\\Users\\Carlos\\Documents\\tempo.txt", rutaOriginal);

        }

        public void eliminar(string codigo, string rutaOriginal)
        {
            StreamReader leer = new StreamReader(rutaOriginal);
            StreamWriter escribir = new StreamWriter("C:\\Users\\Carlos\\Documents\\tempo.txt", true);

            while (!leer.EndOfStream)
            {
                string linea = leer.ReadLine();
                string[] campos = linea.Split('|');

                if (campos[0].Equals(codigo))
                    continue;
                escribir.WriteLine(linea);
            }

            leer.Close();
            escribir.Close();

            //realizamos el intercambio
            File.Delete(rutaOriginal);
            File.Move("C:\\Users\\Carlos\\Documents\\tempo.txt", rutaOriginal);

        }

        public string obtenerLineaAleatoria(string rutaOriginal)
        {
            string rpta = "";

            if (File.Exists(rutaOriginal))
            {
                //obtengo la cantidad de lineas de mi archivo
                int totalLineas = File.ReadAllLines(rutaOriginal).Length;
                int lineaAleatoria = new Random().Next(1, totalLineas);

                StreamReader leer = new StreamReader(rutaOriginal);

                string linea = "";
                int c = 1;
                while (!leer.EndOfStream)
                {
                    linea = leer.ReadLine();
                    if (c++ == lineaAleatoria) break;
                }

                if (linea != "") rpta = linea;

                leer.Close();

            }

            return rpta;
        }

    }
}
