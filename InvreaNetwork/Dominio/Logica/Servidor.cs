using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Logica
{
    public class Servidor
    {


        TcpListener tcpListener;

        public void encender()
        {
            tcpListener = new TcpListener(10000);
            Console.WriteLine("Servidor");

            Console.WriteLine("Esperando un Cliente");
        }

        public void escuchar()
        {
            while (1 == 1)
            {
                tcpListener.Start();

                Socket socketParaCliente = tcpListener.AcceptSocket();

                if (socketParaCliente.Connected)
                {
                    Console.WriteLine("Se ha conectado un cliente.");
                    NetworkStream networkStream = new NetworkStream(socketParaCliente);
                    StreamReader streamReader = new StreamReader(networkStream);
                    StreamWriter streamWriter = new StreamWriter(networkStream);

                    String peticion = streamReader.ReadLine();

                    Console.WriteLine("Cliente dice: " + peticion);


                    Departamento departamento = new Departamento();

                    
                    streamWriter.WriteLine(departamento.newPeticion(peticion));
                    streamWriter.Flush();

                    streamReader.Close();
                    streamWriter.Close();
                    networkStream.Close();
                }
            }
        }
    }
}

        
        
        
        
        
        
        
        
        
        
        
        //public void InstanciarSocket()
        //{
        //    //ACA va  a instancia Socket, ponerse en escuchar 
        //    System.Console.WriteLine("Escriba la Peticion:");
            
            //String peticion ="RRHI0007|antonio|sanchez|09/04/90|gerente|19045403|100000|10/12/40";
            //String peticion = "GP I0005|DQW0011|RELAMPAGO AZUL|31/03/2010|02/05/2010|1000000,00|";
           // String peticion = "ADII0004|12345|laptop|10|20000|";

            //String peticion = "RRHE0001|19045403|";
            //String peticion = "ADIE0001|CODIGO|";
            //String peticion = "GP E0001|DQW0011|";

            //String peticion = "ADIM0003|12345|cantidad|200|precio|90|";
            
            //peticion = System.Console.ReadLine();   para leer por teclado


             //String peticion = "ADIC0001|1234|";

          //  String peticion = "ADIT0000";

            //String peticion = "RRHA0002|blanca|977|";
            
            //String peticion = "AC C0002|tony|1234|";

           // String peticion = "AC E0002|blanca|977|";
           
            
            //String peticion = "GP A0002|tony1|1234";
            //String peticion = "RRHA0002|maria|1234";
            //String peticion = "ADIA0002|lola|matrona";




            //PRUEBAS HECHAS EL DIA 26/04/2010

            //GP
            //String peticion = "GP I0005|DQW0011|RELAMPAGO AZUL|31/03/2010|02/05/2010|1000000,00|";
            //String peticion = "GP C0001|codigoo|";  //ERROR ACA EL CODIGO NO EXISTE Y NO ME DICE CUAL ES EL ERROR
            //String peticion = "GP I0005|codigito|AZUL|31/03/2010|02/05/2010|1000000,00|";
            //String peticion = "GP T0000";
            //String peticion = "GP E0001|DQW0011|";
            //String peticion = "GP M0007|codigo|fechaInicio|10/11/13|fechaFin|21/11/2012|presupuesto|123|";
            

           //RRH
           // String peticion = "RRHI0007|antonio|sanchez|09/04/90|gerente|19045403|100000|10/12/40";
           // String peticion = "RRHI0007|nelly|coromoto|1/4/90|cocina|18223442|10000|1/1/2010|";
           // String peticion = "RRHC0001|18223442|";
           // String peticion = "RRHE0001|19045403|";
           // String peticion = "RRHT0001";
            //String peticion = "RRHM0007|18223442|cargo|secretaria|fechaIngreso|12/12/12|costo|99999|";


            //ADI


            //String peticion = "ADII0004|12345|laptop|10|20000|";
            //String peticion = "ADIM0003|12345|codigo|codigo|";
            //String peticion = "ADII0004|codigo2|laptop2|1|20000|";
        //String peticion = "ADIC0001|codigho|";
        //String peticion = "ADIT0000";
        //String peticion = "ADIE0005|codigo2|";
        //String peticion = "ADIM0007|codito|nombre|maquinaria|";

        
        //Usuario

        //String peticion =  "AC E0002|tony1|12322|";
        //String peticion = "AC C0002|tony|1233|";


//        Departamento departamento = new Departamento();
//        departamento.newPeticion(peticion);
       
//    }

//}
        
    
  







   

