using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
namespace WindowsFormsApplication3
{
    public class Cliente
    {




        public void encerderCliente()
        {

        }

        public String enviar(String peticion)
        {
            TcpClient socketParaServidor;
            socketParaServidor = new TcpClient("127.0.0.1", 10000);

            Console.WriteLine("Cliente dice: " + peticion);
            NetworkStream networkStream = socketParaServidor.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            StreamReader streamReader = new StreamReader(networkStream);
            streamWriter.WriteLine(peticion);
            streamWriter.Flush();
            String respuesta = streamReader.ReadLine();
            Console.WriteLine("soy cliente y el servidor responde: " + respuesta);
            streamReader.Close();
            streamWriter.Close();// no seguro
            networkStream.Close();//no seguro
            return respuesta;
        }



    }
}
