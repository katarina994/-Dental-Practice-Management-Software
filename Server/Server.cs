using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Biblioteka;
using System.Threading;

namespace Server
{
    public class Server
    {
        Socket soket;
        public static List<Zaposleni> ulogovaniKorisnici = new List<Zaposleni>();
        public bool pokreniServer() 
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                EndPoint ep = new IPEndPoint(IPAddress.Any, 20000);
                soket.Bind(ep);


                ThreadStart ts = osluskuj;
                Thread nit = new Thread(ts);
                nit.Start();


                return true;

            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public void osluskuj() 
        {
            try
            {
                soket.Listen(6);
                while (true) 
                {
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    new Obrada(tok);
                }
            }
            catch (Exception)
            {
                
                
            }
        }

        public bool ZaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
