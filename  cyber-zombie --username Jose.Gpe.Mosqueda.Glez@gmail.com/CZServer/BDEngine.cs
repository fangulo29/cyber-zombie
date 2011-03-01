using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;

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
            try
            {
                Comando = new MySqlCommand(strConsulta, Conexion);
                if (Comando.ExecuteNonQuery() > 0) Atomica = true;
                Conexion.Close();
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error al realizar operación.\\n" + e.Number + "\\n" + e.Message + "\\n" + e.Source);
                if (Conexion.State == System.Data.ConnectionState.Open) Conexion.Close();                
            }
            return Atomica;
        }
    }

    public class Tipos : BDEngine
    {
        #region "Atributos"
        public int ID_TIPO;
        public string NOMBRE_TIPO;
        public string DESCRIPCION_TIPO;
        public decimal PRECIO_UNITARIO;
        public string UNIDAD_TIPO;
        private List<Tipos> lstTipos;
        private Tipos objTipos;
        #endregion
        #region "Metodos"
        public bool Insertar()
        {
            strConsulta = "CALL Ins_Tipo('"+NOMBRE_TIPO+"','"+DESCRIPCION_TIPO+"',"+PRECIO_UNITARIO+",'"+UNIDAD_TIPO+"');";
            return Ejecuta();
        }
        public bool Actualizar()
        {
            strConsulta = "CALL Act_Tipo("+ID_TIPO+",'"+NOMBRE_TIPO+"','"+DESCRIPCION_TIPO+"',"+PRECIO_UNITARIO+",'"+UNIDAD_TIPO+"');";
            return Ejecuta();
        }
        public bool Eliminar(int ID)
        {
            strConsulta = "CALL Eli_Tipo("+ID+");";
            return Ejecuta();
        }
        public void Buscar(int ID)
        {            
            strConsulta = "CALL Buscar_Tipo(" + ID + ");";
            Conexion.Open();
            try
            {
                Comando = new MySqlCommand(strConsulta, Conexion);
                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    ID_TIPO = int.Parse(Lector[0].ToString());
                    NOMBRE_TIPO = Lector[1].ToString();
                    DESCRIPCION_TIPO = Lector[2].ToString();
                    PRECIO_UNITARIO = decimal.Parse(Lector[3].ToString());
                    UNIDAD_TIPO = Lector[4].ToString();
                }
                Conexion.Close();
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error al realizar operación.\\n" + e.Number + "\\n" + e.Message + "\\n" + e.Source);
                if (Conexion.State == System.Data.ConnectionState.Open) Conexion.Close();                
            }
        }
        public List<Tipos> Mostrar()
        {
            lstTipos = new List<Tipos>();
            objTipos = new Tipos();
            strConsulta = "CALL Buscar_Tipos();";
            Conexion.Open();
            try
            {
                Comando = new MySqlCommand(strConsulta, Conexion);
                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    objTipos.ID_TIPO = int.Parse(Lector[0].ToString());
                    objTipos.NOMBRE_TIPO = Lector[1].ToString();
                    objTipos.DESCRIPCION_TIPO = Lector[2].ToString();
                    objTipos.PRECIO_UNITARIO = decimal.Parse(Lector[3].ToString());
                    objTipos.UNIDAD_TIPO = Lector[4].ToString();
                    lstTipos.Add(objTipos);
                    objTipos = new Tipos();
                }
                Conexion.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al realizar operación.\\n" + e.Number + "\\n" + e.Message + "\\n" + e.Source);
                if (Conexion.State == System.Data.ConnectionState.Open) Conexion.Close();
            }
            return lstTipos;
        }
        #endregion
    }

    public class Equipos : BDEngine
    {
        #region "Atributos"
        
        #endregion
    }
}
