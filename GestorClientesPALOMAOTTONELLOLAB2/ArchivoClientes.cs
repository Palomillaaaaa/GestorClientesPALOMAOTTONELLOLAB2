using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestorClientesPALOMAOTTONELLOLAB2.ArchivoClientes;

namespace GestorClientesPALOMAOTTONELLOLAB2
{
    internal class ArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string tabla = "Cliente";

        private Decimal deuda;
        private Int32 cantidad; 

        public struct RegClientes 
        {
            private Int32 idCli;
            private String nom;
            private Int32 Cod;
            private Decimal deu;
            private Decimal Lim;
            private Decimal IdAud;

        }

        public Decimal TotalDeuda
        {
            get { return deuda; }

        }

        public Int32 CantidadDeudores 
        {
            get { return cantidad; }
        }

        public Decimal PromedioDeuda 
        {
            get { return deuda/cantidad;}
        }
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

       
        
        private RegClientes[] VecClientes = new RegClientes[1500];
            private Int32 IND = 0;


            public void OrdenarArchivo()
            {
                CargarVector();
                OrdenarVector();
                ReescribirArchivo();
            }

        private void CargarVector()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            


            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                VecClientes[IND].Codigo = Convert.ToInt32(VecDatos[0]);
                VecClientes[IND].Nombre = VecDatos[1];
                VecClientes[IND].Deuda = Convert.ToDecimal(VecDatos[2]);
                VecClientes[IND].Limite = Convert.ToDecimal(VecDatos[3]);
                IND++;
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
                
        }

        private void OrdenarVector()
        {
            IND = 0;
            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++) //recorre el vector
            {
                for (Int32 i = 0; i < IND - 1; i++)
                {
                    if (VecClientes[i].cod > VecClientes[i + 1].cod) 
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }
        }


        private void ReescribirArchivo() 
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);
                for (Int32 i = 0; i < IND; i++) 
                { 
                //LEER
               
                AD.Write(VecClientes[i].Codigo);
            
                AD.Write(";");
                AD.Write(VecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(VecClientes[i].Deuda);
                AD.Write(";");
                AD.Write(VecClientes[i].Limite);
                }

            AD.Close();
            AD.Dispose();

        } 

        public Decimal CantidadClientes()
        {
            string DatosLeidos;
            int C = 0;


            StreamReader AD = new StreamReader(NombreArchivo);

            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                C++;
                DatosLeidos = AD.ReadLine();

            }
            AD.Close();
            AD.Dispose();
            return C;

        }


        public void Listar(DataGridView Grilla)
            {

                string DatosLeidos;
                string[] VecDatos = new string[4];
                //string total;

                StreamReader AD = new StreamReader(NombreArchivo);
                DatosLeidos = AD.ReadLine();
                Grilla.Rows.Clear();
                while (DatosLeidos != null)
                {
                    VecDatos = DatosLeidos.Split(';');
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3], VecDatos[4]);
                    DatosLeidos = AD.ReadLine();
                }
                AD.Close();
                AD.Dispose();
            }

            public Decimal PromedioDeuda()
            {
                string[] VecDatos = new string[4];
                string DatosLeidos;
                decimal total = 0;
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

        public Decimal SumarDeuda()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            decimal total = 0;
            


            StreamReader AD = new StreamReader(NombreArchivo);

            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
               
                VecDatos = DatosLeidos.Split(';');
                total = total + Convert.ToDecimal(VecDatos[2]);

                DatosLeidos = AD.ReadLine();

            }
            AD.Close();
            AD.Dispose();
            return total;

        }
        public void GenerarReporte()
            {
                string DatosLeidos;
                string[] VecDatos = new string[4];
                StreamWriter Reporte = new StreamWriter("Reporte.csv", false, Encoding.UTF8);

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
                Reporte.WriteLine(total / cantidad);

                Reporte.Close();
                Reporte.Dispose();

            }
        public void ListarDeudores(DataGridView Grilla) 
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            //string total;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                if (Convert.ToInt32(VecDatos[3]) != 0) 
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3], VecDatos[4]);
                }
            
                
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }

        public int cantidadClientesDeudores(DataGridView Grilla) 
        {
            int cont = 0;
            string DatosLeidos;
            string[] VecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos=AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null) 
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToInt32(VecDatos[3]) != 0) 
                {
                    cont++;
                }
                DatosLeidos = AD.ReadLine();
            }
            
            AD.Close();
            AD.Dispose();
            return cont;

        }
    }
}



           

