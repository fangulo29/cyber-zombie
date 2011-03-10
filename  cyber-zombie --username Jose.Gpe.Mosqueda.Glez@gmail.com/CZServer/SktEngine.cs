/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 09/03/2011
 * Hora: 11:00 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CZServer
{
	/// <summary>
	/// Description of SktEngine.
	/// </summary>
	public class SktEngine
	{
		#region "Variables"	
			public Socket skt = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
			public Thread trdRecibir;
			public bool Saliendo=false;
			public string DireccionIP;
			public string ContenidoMensaje;
		#endregion
        	#region "Constantes"
            		public string MyIP;
        	#endregion
		public SktEngine()
		{
			MyIP = LocalIPAddress();          
			skt.Bind(new IPEndPoint(IPAddress.Any, 20145));
			skt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
			trdRecibir = new Thread(RecibirDatos);
			trdRecibir.Start();
			EnviarDatos("CLIENTES",DireccionIP + "[ServerConectado]");
		}
		private string LocalIPAddress()
		{
			IPHostEntry host;
			string localIP = "";
			host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress ip in host.AddressList)
			{
				if (ip.AddressFamily.ToString() == "InterNetwork")
				{
					localIP = ip.ToString();
				}
			}
			return localIP;
		}
		private void EnviarDatos(string strIP,string strTexto)
		{
			IPEndPoint DireccionDestino;
			if(strIP == "CLIENTES")
				DireccionDestino = new IPEndPoint(IPAddress.Broadcast,20145);
			else
				DireccionDestino = new IPEndPoint(IPAddress.Parse(strIP),20145);
			byte[] DatosBytes = Encoding.Default.GetBytes(strTexto);
			skt.SendTo(DatosBytes,DatosBytes.Length,SocketFlags.None,DireccionDestino);			
		}
		private void RecibirDatos()
		{
			while(!Saliendo){
				IPEndPoint LaIpRemota = new IPEndPoint(IPAddress.Any,0);
				EndPoint IPRecibida  = (EndPoint)LaIpRemota;
				byte[] RecibirBytes = new byte[256];
				string Datos = "";
				try
				{
					skt.ReceiveFrom(RecibirBytes,RecibirBytes.Length,SocketFlags.None,ref IPRecibida);
					Datos = Encoding.Default.GetString(RecibirBytes);
				}
				catch(SocketException e)
				{
					if(e.ErrorCode == 10040)
					{
						Datos += "[truncado]";
					}
					else
					{
						MessageBox.Show("Error '"+e.ErrorCode+"' "+e.Message,"Error al recibir los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
				LaIpRemota = (IPEndPoint)IPRecibida;
				DireccionIP = LaIpRemota.Address.ToString();
				ContenidoMensaje = Datos.ToString();
				//txtConversacion.Invoke(new EventHandler(ActualizarTextoMensaje));
			}
		}
	}
}
