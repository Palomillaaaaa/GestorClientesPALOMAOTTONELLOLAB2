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

        // Campos de la clase
        private Int32 idCli;
        private String nom;
        private Decimal deu;
        private Decimal lim;
        private Int32 idAut;

        public struct RegClientes
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
            public Int32 IdAut;
        }

        private RegClientes[] VecClientes = new RegClientes[1500];
        private Int32 IND = 0;

        // Propiedades
        public string CadenaConexion { get { return cadenaConexion; } }
        public string Tabla { get { return tabla; } }

        public Decimal TotalDeuda { get { return deuda; } }
        public Int32 CantidadDeudores { get { return cantidad; } }
        public Decimal PromDeuda
        {
            get { return cantidad != 0 ? deuda / cantidad : 0; }
        }

        public Int32 idCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }
        public Decimal Limite
        {
            get { return lim; }
            set { lim = value; }
        }
        public Int32 idAutomovil
        {
            get { return idAut; }
            set { idAut = value; }
        }

        // ---------- MÉTODOS ----------

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(cod); AD.Write(";");
            AD.Write(nom); AD.Write(";");
            AD.Write(deu); AD.Write(";");
            AD.WriteLine(lim);
            AD.Close();
            AD.Dispose();
        }

        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArchivo();
        }

        private void CargarVector()
        {
            string DatosLeidos;
            string[] VecDatos = new string[5];

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            IND = 0;

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

            RegClientes aux;
            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1; i++)
                {
                    if (VecClientes[i].Codigo > VecClientes[i + 1].Codigo)
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
                AD.Write(VecClientes[i].Codigo); AD.Write(";");
                AD.Write(VecClientes[i].Nombre); AD.Write(";");
                AD.Write(VecClientes[i].Deuda); AD.Write(";");
                AD.WriteLine(VecClientes[i].Limite);
            }
            AD.Close();
            AD.Dispose();
        }

        public Int32 CantidadClientes()
        {
            string DatosLeidos;
            int C = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null) { C++; DatosLeidos = AD.ReadLine(); }
            AD.Close();
            AD.Dispose();
            return C;
        }

        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[5];

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
            string[] VecDatos = new string[5];
            string DatosLeidos;
            decimal total = 0;
            int C = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                C++;
                VecDatos = DatosLeidos.Split(';');
                total += Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return C != 0 ? total / C : 0;
        }

        public Decimal SumarDeuda()
        {
            string[] VecDatos = new string[5];
            string DatosLeidos;
            decimal total = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                total += Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return total;
        }

        public void GenerarReporte()
        {
            string DatosLeidos;
            string[] VecDatos = new string[5];
            StreamWriter Reporte = new StreamWriter("Reporte.csv", false, Encoding.UTF8);
            Int32 cantidad = 0;
            decimal total = 0;
            Reporte.WriteLine("Listado de Clientes\n");
            Reporte.WriteLine("Código; Nombre; Límite; Deuda");
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Reporte.Write(VecDatos[0]); Reporte.Write(';');
                Reporte.Write(VecDatos[1]); Reporte.Write(';');
                Reporte.Write(VecDatos[3]); Reporte.Write(';');
                Reporte.WriteLine(VecDatos[2]);
                cantidad++;
                total += Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            Reporte.Write("Total de deudas: ;; "); Reporte.WriteLine(total);
            Reporte.Write("Cantidad de Clientes: ;; "); Reporte.WriteLine(cantidad);
            Reporte.Write("Promedio de deudas: ;; "); Reporte.WriteLine(cantidad != 0 ? total / cantidad : 0);
            Reporte.Close();
            Reporte.Dispose();
        }

        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[5];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(VecDatos[2]) > 0)
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3], VecDatos[4]);
                }
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }

        public int cantidadClientesDeudores()
        {
            int cont = 0;
            string DatosLeidos;
            string[] VecDatos = new string[5];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(VecDatos[2]) > 0)
                    cont++;
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return cont;
        }

        public void Buscar(Int32 idCliente)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == idCliente)
                        {
                            idCli = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            deu = DR.GetDecimal(2);
                            lim = DR.GetDecimal(3);
                            idAut = DR.GetInt32(4);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }
    }
}




