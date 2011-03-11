/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 10/03/2011
 * Hora: 06:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CZServer
{	
	public partial class frmConsola : Form
	{
		#region "Variables"	
			public Socket skt = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
			public Thread trdRecibir;
			public bool Saliendo=false;
			public string DireccionIP;
			public string ContenidoMensaje;
			public string strConsola;
			public string MyIP;
		#endregion
		public frmConsola()
		{			
			InitializeComponent();
			Iniciar();
		}
		public void Iniciar()
		{
			MyIP = LocalIPAddress();      			
				skt.Bind(new IPEndPoint(IPAddress.Any, 20145));
				skt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
			
			trdRecibir = new Thread(RecibirDatos);
			trdRecibir.Start();
			EnviarDatos("CLIENTES",DireccionIP + "[ServerConectado]");
		}	
		public  void Parar()
		{
			skt.Close();
			trdRecibir.Abort();
			strConsola = string.Empty;
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
				txtConsola.Invoke(new EventHandler(ActualizarConsola));
			}
		}
		protected void ActualizarConsola(object sender, EventArgs e)
		{
			if(txtConsola.Text.Length==0)
			{
				txtConsola.Text = ">" +ContenidoMensaje;
			}
			else
			{
				txtConsola.Text += "\r\n>" + ContenidoMensaje;
			}
		}
		
		void FrmConsolaFormClosed(object sender, FormClosedEventArgs e)
		{
			//skt.Close();
			trdRecibir.Abort();
			this.Dispose();
		}
	}
}
