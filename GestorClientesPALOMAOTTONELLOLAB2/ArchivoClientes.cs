using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace GestorClientesPALOMAOTTONELLOLAB2
{
    internal class ArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";
        

            public void Grabar(string cod, string nom, string deu, string lim)
        {
            //abrir
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            //LEER
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);
            AD.Close();
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla)
        {
           
            string DatosLeidos;
            string[] VecDatos = new string[4];
            string total;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while(DatosLeidos != null) 
            {
                VecDatos = DatosLeidos .Split(';');
                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3], VecDatos[4]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }

        public Decimal PromedioDeuda() 
        {
            string []VecDatos = new string[4];
            string DatosLeidos;
            decimal total= 0;
            int C = 0;
            

            StreamReader AD = new StreamReader(NombreArchivo);
            
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null) 
            {
                C++;
                VecDatos = DatosLeidos.Split(';');
                total = total + Convert.ToDecimal(VecDatos[2]);

                DatosLeidos = AD.ReadLine();
                
            }
            AD.Close();
            AD.Dispose();
            return total / C;

        }
        public void GenerarReporte()
        {  
            string DatosLeidos;
            string[] VecDatos = new string[4];
            StreamWriter Reporte = new StreamWriter("Reporte.csv", false,Encoding.UTF8);

            Int32 cantidad = 0;
            decimal total = 0;
            Reporte.WriteLine("Listado de Clientes\n");
            Reporte.WriteLine(" ");
            Reporte.WriteLine("Código; Nombre; Límite; Deuda");

            StreamReader AD = new StreamReader(NombreArchivo);

            DatosLeidos = AD.ReadLine();
           
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Reporte.Write(VecDatos[0]);
                Reporte.Write(';');
                Reporte.Write(VecDatos[1]);
                Reporte.Write(';');
                Reporte.Write(VecDatos[3]);
                Reporte.Write(';');
                Reporte.Write(VecDatos[2]);

                DatosLeidos = AD.ReadLine();
                cantidad++;
                total = total + Convert.ToDecimal(VecDatos[2]);

            }
            Reporte.Write("Total de deudas: ;; ");
            Reporte.WriteLine(total);
            Reporte.Write("Cantidad de Clientes: ;; ");
            Reporte.WriteLine(cantidad);
            Reporte.Write("Promedio de deudas: ;; ");
            Reporte.WriteLine(total/cantidad);

            Reporte.Close();
            Reporte.Dispose();
            
        }
    }
    }

            
}

