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
		#region "Atributos"
		protected string Server = "localhost";
		protected string Data_Base = "cz";
		protected string User = "usrcz";
		protected string Password = "usrcz";
		protected string strConexion;
		protected string strConsulta;

		public MySqlConnection Conexion;
		public MySqlCommand Comando;
		public MySqlDataReader Lector;
		#endregion
		#region "Métodos"
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
		#endregion
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
		#region "Métodos"
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
		public int ID_EQUIPO;
		public int ID_TIPO;
		public string IP_EQUIPO;
		public string NOMBRE_EQUIPO;
		public string CARACTERISTICAS_EQUIPO;
		private List<Equipo> lstEquipos;
		private Eqipos objEquipos; 
		#endregion
		#region "Métodos"
		public bool Insertar()
		{
			strConsulta = "CALL Ins_Equipo("+ID_TIPO+",'"+IP_EQUIPO+"','"+NOMBRE_EQUIPO+"','"+CARACTERISTICAS_EQUIPO+"');";
			return Ejecuta();
		}
		public bool Actualizar()
		{
			strConsulta = "CALL Act_Equipo("+ID_EQUIPO+","+ID_TIPO+",'"+IP_EQUIPO+"','"+NOMBRE_EQUIPO+"','"+CARACTERISTICAS_EQUIPO+"');";
			return Ejecuta();
		}
		public bool Eliminar()
		{
			strConsulta = "CALL Eli_Equipo("+ID_EQUIPO+");";
			return Ejecuta();
		}
		public void Buscar(int ID)
		{
			strConsulta = "CALL Buscar_Equipo("+ID+");";
			Conexion.Open();
			try
			{
				Comando = new MySqlCommand(strConsulta, Conexion);
				Lector = Comando.ExecuteReader();
				while (Lector.Read())
				{
					ID_EQUIPO = int.Parse(Lector[0].ToString());
					ID_TIPO = int.Parse(Lector[1].ToString());
					IP_EQUIPO = Lector[2].ToString();
					NOMBRE_EQUIPO = Lector[3].ToString();
					CARACTERISTICAS_EQUIPO = Lector[4].ToString();
				}
				Conexion.Close();
			}
			catch(MySqlException e)
			{
				MessageBox.Show("Error al realizar operación.\\n" + e.Number + "\\n" + e.Message + "\\n" + e.Source);
				if (Conexion.State == System.Data.ConnectionState.Open) Conexion.Close();
			}
		}
		public List<Equipos> Mostrar()
		{
			lstEquipos = new List<Equipo>();
			objEquipos = new Equipos();
			strConsulta = "CALL Buscar_Equipos();";
			Conexion.Open();
			try
			{
				Comando = new MySqlCommand(strConsulta, Conexion);
				Lector = Comando.ExecuteReader();
				while (Lector.Read())
				{
					objEquipos.ID_EQUIPO = int.Parse(Lector[0].ToString());
					objEquipos.ID_TIPO = int.Parse(Lector[1].ToString());
					objEquipos.IP_EQUIPO = Lector[2].ToString();
					objEquipos.NOMBRE_EQUIPO = Lector[3].ToString();
					objEquipos.CARACTERISTICAS_EQUIPO = Lector[4].ToString();
					lstEquipos.Add(objEquipos);
					objEquipos = new Equipos();
				}
				Conexion.Close();
			}
			catch(MySqlException e)
			{
				MessageBox.Show("Error al realizar operación.\\n" + e.Number + "\\n" + e.Message + "\\n" + e.Source);
				if (Conexion.State == System.Data.ConnectionState.Open) Conexion.Close();
			}
			return lstEquipos;
		}
		#endregion
	}
	
	public class Sesiones:BDEngine
	{
		#region "Atributos"		
		public int ID_SESION;
		public int ID_EQUIPO;
		public string FECHA_SESION;
		public string HORA_INICIO;
		public string HORA_FIN;
		public decimal TOTAL_SESION;
		public decimal TOTAL_SESIONIMP;
		public decimal TOTAL;
		private List<Sesiones> lstSesiones;
		private Sesiones objSesiones;
		#endregion
		#region "Métodos"
		#endregion		
	}
	
	public class SesionesImp:BDEngine
	{
		#region "Atributos"			
		public int ID_EQUIPO;
		public int ID_SESION;
		public int NO_IMPRESIONES;
		public decimal PRECIO_UNITARIO;
		public decimal TOTAL_PRECIO;
		#endregion
		#region "Métodos"
		#endregion		
	}
}
