using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Servidor");

            TcpListener tcpListener = new TcpListener(10000);
            tcpListener.Start();
            Console.WriteLine("Esperando un Cliente");

            Socket socketParaCliente = tcpListener.AcceptSocket();

            if (socketParaCliente.Connected)
            {
                Console.WriteLine("Se ha conectado un cliente.");
                NetworkStream networkStream = new NetworkStream(socketParaCliente);
                StreamReader streamReader = new StreamReader(networkStream);

                String peticion = streamReader.ReadLine();
                Console.WriteLine("Cliente dice: " + peticion);

                streamReader.Close();
                networkStream.Close();
            }
            socketParaCliente.Close();
            Console.WriteLine("Fin de la comunicacion.");
            Console.ReadLine();

        }
    }
}
