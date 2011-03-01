using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;

namespace CZServer
{
    public class BDEngine
    {
        protected string Server = "localhost";
		protected string Data_Base = "cz";
		protected string User = "usrcz";
		protected string Password = "usrcz";
		protected string strConexion;
		protected string strConsulta;

		public MySqlConnection Conexion;
		public MySqlCommand Comando;
		public MySqlDataReader Lector;

		protected BDEngine()
		{
			strConexion = "Server=" + Server + ";Database=" + Data_Base + ";Uid= " +User + ";Pwd="+Password+";";
			Conexion = new MySqlConnection(strConexion);            
		}
        protected bool Ejecuta()
        {
            bool Atomica = false;
            Conexion.Open();
            Comando = new MySqlCommand(strConsulta, Conexion);
            if (Comando.ExecuteNonQuery() > 0) Atomica = true;
            Conexion.Close();
            return Atomica;
        }
    }

    public class Tipos : BDEngine
    {
        public int ID_TIPO;
        public string NOMBRE_TIPO;
        public string DESCRIPCION_TIPO;
        public decimal PRECIO_UNITARIO;
        public string UNIDAD_TIPO;
        
        public bool Insertar()
        {
            strConsulta = "CALL Ins_Tipo('"+NOMBRE_TIPO+"','"+DESCRIPCION_TIPO+"',"+PRECIO_UNITARIO+",'"+UNIDAD_TIPO+"');";
            return Ejecuta();
        }

    }
}
