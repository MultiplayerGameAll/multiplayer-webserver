using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace multiplayer_webserver
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServer ws = new WebServer(SendResponse, "http://localhost:8080/test/");
            ws.Run();
            Console.WriteLine("A simple webserver. Press a key to quit.");
            Console.ReadKey();
            ws.Stop();
        }

        public static string SendResponse(HttpListenerRequest request)
        {
            Card carta = new Card();
            carta.tipoCarta = "Magia";
            carta.energia = 3;
            carta.ataque = 2;

            string json = JsonConvert.SerializeObject(carta);
            return json;
            //return string.Format("<HTML><BODY>My web page.<br>{0}</BODY></HTML>", DateTime.Now);
        }
    }
}
