/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 03/03/2011
 * Hora: 11:54 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Security;
using System.Net;

namespace CZServer
{
	//Formulario de busqueda para los catalogos
	//obtendra el tipo de catalogo a buscar, se adecuaran las busquedas filtradas
	//dependiendo de la tabla a consultar
	public partial class frmBuscar : Form
	{		
		private List<Tipos> lstTipos;
		private List<Equipos> lstEquipos;
		
		private IPHostEntry IPs;
        private IPAddress [] lstIPs; 
		
        #region Dll imports
		[DllImport("Netapi32", CharSet = CharSet.Auto, SetLastError = true),SuppressUnmanagedCodeSecurityAttribute]
        public static extern int NetServerEnum(
            string ServerNane, 
            int dwLevel,
            ref IntPtr pBuf,
            int dwPrefMaxLen,
            out int dwEntriesRead,
            out int dwTotalEntries,
            int dwServerType,
            string domain, 
            out int dwResumeHandle
            );       
        [DllImport("Netapi32", SetLastError = true),SuppressUnmanagedCodeSecurityAttribute]        
        public static extern int NetApiBufferFree(
            IntPtr pBuf);        
        [StructLayout(LayoutKind.Sequential)]
        public struct _SERVER_INFO_100
        {
            internal int sv100_platform_id;
            [MarshalAs(UnmanagedType.LPWStr)]
            internal string sv100_name;
        }
		#endregion
        
		public frmBuscar(string Catalogo)
		{			
			InitializeComponent();			
			ConfigurarTabla(Catalogo);
		}
		
		private void ConfigurarTabla(string strCatalogo)
		{
			int i;			
			DataGridViewColumn Columna;
			Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "ID";
                        dgvContenido.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "ID";                        
                        dgvBusqueda.Columns.Add(Columna);
			Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Descripción";
                        dgvContenido.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Descripción";
                        dgvBusqueda.Columns.Add(Columna);
                        
                        switch(strCatalogo)
                        {
                        	case "Tipos":
                        		lstTipos = new Tipos().Mostrar();
                        		for(i=0;i<lstTipos.Count;i++)
                        		{
                        			dgvContenido.Rows.Add(lstTipos[i].ID_TIPO,lstTipos[i].NOMBRE_TIPO);						
                        		}
                        		break;
                        	case "Equipos":
                        		lstEquipos = new Equipos().Mostrar();
                        		for(i=0;i<lstTipos.Count;i++)
                        		{
                        			dgvContenido.Rows.Add(lstTipos[i].ID_TIPO,lstTipos[i].NOMBRE_TIPO);						
                        		}
                        		break;
                        	case "EquiposRed":
                        		try
                        		{
                        			foreach(string pc in ObtenerEquiposenRed())
                        			{
                        				IPs = Dns.GetHostByName(pc);
                        				lstIPs = IPs.AddressList;
                        				dgvContenido.Rows.Add(lstIPs[0].ToString(),pc);                        				
                        			}
                        		}
                        		catch(Exception e)
                        		{
                        			MessageBox.Show("A Ocurrido Un Error Intentando Accesar a la Red."+e.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        		}
                        		break;
                        	default:
                        		break;
                        }
                        dgvBusqueda.Rows.Clear();
                        for(int j=0;j<dgvContenido.Rows.Count;j++)
                        {
                        	dgvBusqueda.Rows.Add(dgvContenido.Rows[j].Cells[0].Value.ToString(),dgvContenido.Rows[j].Cells[1].Value.ToString());
                        }
		}
		
		private ArrayList ObtenerEquiposenRed()
        {       
            ArrayList networkComputers = new ArrayList();
            const int MAX_PREFERRED_LENGTH = -1;
            int SV_TYPE_WORKSTATION = 1;
            int SV_TYPE_SERVER = 2;
            IntPtr buffer = IntPtr.Zero;
            IntPtr tmpBuffer = IntPtr.Zero;
            int entriesRead = 0;
            int totalEntries = 0;
            int resHandle = 0;
            int sizeofINFO = Marshal.SizeOf(typeof(_SERVER_INFO_100));
            
            try
            {
                
                int ret = NetServerEnum(null, 100, ref buffer, MAX_PREFERRED_LENGTH, out entriesRead,    out totalEntries, SV_TYPE_WORKSTATION | SV_TYPE_SERVER, null, out resHandle);
                if (ret == 0)
                {                
                    for (int i = 0; i < totalEntries; i++)
                    {                      
                        tmpBuffer = new IntPtr((int)buffer + (i * sizeofINFO));
                       
                        _SERVER_INFO_100 svrInfo = (_SERVER_INFO_100)
                            Marshal.PtrToStructure(tmpBuffer, typeof(_SERVER_INFO_100));                        
                        networkComputers.Add(svrInfo.sv100_name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with acessing network computers in NetworkBrowser " +
                    "\r\n\r\n\r\n" + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
            finally
            {               
                NetApiBufferFree(buffer);
            }           
            return networkComputers;
        }
		
		void CmdSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			dgvBusqueda.Rows.Clear();
			for(int i=0;i<dgvContenido.Rows.Count;i++)
			{
				if(Regex.IsMatch(dgvContenido.Rows[i].Cells[0].Value.ToString(),txtBuscar.Text,RegexOptions.IgnoreCase) || Regex.IsMatch(dgvContenido.Rows[i].Cells[1].Value.ToString(),txtBuscar.Text,RegexOptions.IgnoreCase))
				{
					dgvBusqueda.Rows.Add(dgvContenido.Rows[i].Cells[0].Value.ToString(),dgvContenido.Rows[i].Cells[1].Value.ToString());
				}
			}
		}
	}
}
