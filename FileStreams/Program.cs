﻿using System;
using System.IO;
using System.Text;

namespace FileStreams
{
    public class Program
    {
        // Nomes dos ficheiros
        private const string filenameText = "dados.txt";
        private const string filenameBinary = "dados.bin";

        // Dados a escrever e ler nos ficheiros
        private const string dataString = "Hello world!";
        private const int dataInt = 18;
        private const float dataFloat = 3.1415f;

        private static void Main()
        {
            // String para onde ler opção inserida pelo utilizador
            string option;

            // Ciclo do menu principal
            do
            {
                // Apresentar menu principal
                Console.WriteLine("==== Que programa devo executar? ==== \n");
                Console.WriteLine("\t1. Escreve ficheiro em modo de texto");
                Console.WriteLine("\t2. Lê ficheiro em modo de texto");
                Console.WriteLine("\t3. Escreve ficheiro em modo binário");
                Console.WriteLine("\t4. Lê ficheiro em modo binário");
                Console.WriteLine("\t5. Sair");
                Console.Write("\n>");

                // Solicitar opção ao utilizador
                option = Console.ReadLine();

                // Tratar opção do utilizador
                switch (option)
                {
                    case "1":
                        EscreverTexto(); break;
                    case "2":
                        LerTexto(); break;
                    case "3":
                        EscreverBin(); break;
                    case "4":
                        LerBin(); break;
                    case "5":
                        Console.WriteLine("Obrigado e até à próxima!");
                        break;
                    default:
                        Console.WriteLine("**** Opção inválida! ****");
                        break;
                }

                Console.WriteLine(
                    "Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (option != "5");
        }

        // 1. Escreve ficheiro em modo de texto
        private static void EscreverTexto()
        {
            // Código aqui

            using FileStream fs = new FileStream(
                filenameText, FileMode.Create, FileAccess.Write);

            // StreamWriter sw = new StreamWriter(filenameText);

            using StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(dataString);
            sw.WriteLine(dataInt);
            sw.WriteLine(dataFloat);
        
        }

        // 2. Lê ficheiro em modo de texto
        private static void LerTexto()
        {
            string line;

            // Código aqui
            using FileStream fs = new FileStream(
                filenameText,FileMode.Open, FileAccess.Read);

            using StreamReader sr = new StreamReader(fs);

            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            // outra forma de ler
            //string stuffString = sr.ReadLine();
            //int stuffInt = int.Parse(sr.ReadLine()); 
            //float stuffFloat = float.Parse(sr.ReadLine());  

        }

        // 3. Escreve ficheiro em modo binário
        private static void EscreverBin()
        {
            // Código aqui

            using FileStream fs = new FileStream(
                filenameBinary, FileMode.Create, FileAccess.Write);

            using BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(dataString);
            bw.Write(dataInt);
            bw.Write(dataFloat);

        }

        // 4. Lê ficheiro em modo binário
        private static void LerBin()
        {
            // Código aqui


            using FileStream fs = new FileStream(
                filenameBinary, FileMode.Open, FileAccess.Read);

            using BinaryReader br = new BinaryReader(fs);


            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadSingle());
        
        }
    }
}
