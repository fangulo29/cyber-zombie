/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 02/03/2011
 * Hora: 04:27 p.m.
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
	public partial class frmPrincipal : Form
	{
		#region "Variables para Sockets"	
			public Socket skt = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
			public Thread trdRecibir;
			public bool Saliendo=false;
			public string DireccionIP;
			public string ContenidoMensaje;
			public string strConsola;
			public string MyIP;
		#endregion
		# region "Variables Generales"
			private Configuracion.frmTipos objTipos;
			private Configuracion.frmEquipos objEquipos;			
		#endregion
		public frmPrincipal()
		{
			InitializeComponent();			
		}
		
		void TiposToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(objTipos == null || objTipos.IsDisposed)
			{
				objTipos = new CZServer.Configuracion.frmTipos();				
			}
			objTipos.MdiParent = this;
			objTipos.Show();
		}
		
		void EquiposToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(objEquipos == null || objEquipos.IsDisposed)
			{
				objEquipos = new CZServer.Configuracion.frmEquipos();
			}
			objEquipos.MdiParent = this;
			objEquipos.Show();
		}
		
		void IniciarToolStripMenuItemClick(object sender, EventArgs e)
		{			
			Iniciar();
		}
		
		#region "Consola del Socket"
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
			EnviarDatos("CLIENTES",DireccionIP + "[ServerDesconectado]");
			skt.Close();
			trdRecibir.Abort();
			strConsola = string.Empty;
		}
		public string LocalIPAddress()
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
		public void EnviarDatos(string strIP,string strTexto)
		{
			IPEndPoint DireccionDestino;
			if(strIP == "CLIENTES")
				DireccionDestino = new IPEndPoint(IPAddress.Broadcast,20145);
			else
				DireccionDestino = new IPEndPoint(IPAddress.Parse(strIP),20145);
			byte[] DatosBytes = Encoding.Default.GetBytes(strTexto);
			skt.SendTo(DatosBytes,DatosBytes.Length,SocketFlags.None,DireccionDestino);			
		}
		public void RecibirDatos()
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
				DireccionIP = "[" + LaIpRemota.Address.ToString() + "]";
				ContenidoMensaje = Datos.ToString();
				
				txtConsola.Invoke(new EventHandler(ActualizarConsola));
			}
		}
		public void ActualizarConsola(object sender, EventArgs e)
		{
			if(txtConsola.Text.Length==0)
			{
				txtConsola.Text = DireccionIP + ">" +ContenidoMensaje;
			}
			else
			{
				txtConsola.Text += DireccionIP + "\r\n>" + ContenidoMensaje;
			}
		}		
		#endregion
	}
}
