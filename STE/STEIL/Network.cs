using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace STEIL
{
    #region client
    public class STENetworkClient
    {
        private string hostname;
        private int port;
        private TcpClient connection; 
        public STENetworkClient(string name, int _port)
        {
            hostname=name;
            port=_port;
        }
        public int Connect()
        {
            return 0;
        }
        public int Authorize()
        {
            return 0;
        }
        public void RequireTestList()
        {

        }
        public void RequireTest()
        {

        }
        public void CheckResults()
        {

        }
        public void GetReport(string[] rules)
        {

        }
        public void Disconnect()
        {
            connection.Close();
        }
    }
#endregion client
    #region server
    public class STENetworkServer
    {

    }
    public class STEClientConnection
    {

    }
#endregion server
}
