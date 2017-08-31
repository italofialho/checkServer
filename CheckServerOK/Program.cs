using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.ComponentModel;

namespace CheckServerOK
{
    class Program
    {
        static void Main(string[] args)
        {
            //int resetCount = 1;
            int timeToCheck = 30;
            int allProcess = 0;
            bool needCountdown = true;
            bool isStopped = false;

            //RAZOR::Define name of start log file
            /*string file = "CheckServerLogParte1.txt";

            //RAZOR::Check all old files in directory and delet it !
            string[] filePaths = Directory.GetFiles(@"C:\CheckServer\", "*.txt");
            foreach (string filePath in filePaths)
            {
                if (filePath.EndsWith(".txt"))
                {
                    File.Delete(filePath);
                    Console.WriteLine("Apagando logs anteriores ...");
                    //RAZOR::Clear all console ....
                    Console.Clear();
                }
            }

        //RAZOR::Define loop start point .......
        reset:

            //RAZOR::If reseted increase number of log file ..
            if (resetCount > 1)
                file = "CheckServerLogParte" + resetCount + ".txt";

            //RAZOR::Start new file ....
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Arquivo antigo foi deletado com sucesso ! -- Criando um novo arquivo !");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Iniciando serviços KilledZ - Made by: RAZOR");
            Console.WriteLine("Iniciando em: {0} ", DateTime.Now.ToString("h:mm:ss"));
            Console.ResetColor();

            writer.WriteLine("Iniciando serviços KilledZ - Made by: RAZOR");
            writer.WriteLine("Iniciando em: " + DateTime.Now.ToString("h:mm:ss"));*/
            Console.Title = "Iniciando .... - Italo Fialho";
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Versão CainZMMO");
            Console.WriteLine("Iniciando serviços CainZ - Italo Fialho");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Iniciando em: {0} ", DateTime.Now.ToString("h:mm:ss"));
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Title = "Iniciado ! - Italo Fialho";
            Thread.Sleep(1000);
        verifica:
            Console.Title = "CainZ - Verificando ... - Italo Fialho";
            needCountdown = true;

            //RAZOR::Increase the value of loop count
            allProcess++;

            //RAZOR::Check if need reset logs !
            /*if (allProcess > (100 * resetCount))
            {
                writer.WriteLine("Arquivo chegou no limite de 100 verificações ! Criando novo arquivo 1");
                writer.Close();
                writer.Dispose();
                resetCount++;
                goto reset;
            }*/



            //RAZOR::Only logs ....
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nVerificação N°:{0}\n\n", allProcess);
            //writer.WriteLine("Verificação N°:" + allProcess);
            Console.ResetColor();

            if (Process.GetProcessesByName("rsbuild").Length == 0)
            {

                if (Process.GetProcessesByName("masterserver").Length != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[{0}] masterserver está em execução", allProcess);
                    //writer.WriteLine("masterserver está em execução");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[{0}] masterserver não está em execução", allProcess);
                    //writer.WriteLine("masterserver não está em execução");
                    Console.ResetColor();
                    OpenProgram("C:\\WarZ\\bin\\", "MasterServer.exe");
                }

                if (Process.GetProcessesByName("supervisorserver").Length != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    //writer.WriteLine("supervisorserver está em execução");
                    Console.WriteLine("[{0}] supervisorserver está em execução", allProcess);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[{0}] supervisorserver não está em execução", allProcess);
                    //writer.WriteLine("supervisorserver não está em execução");
                    Console.ResetColor();
                    OpenProgram("C:\\WarZ\\bin\\", "SupervisorServer.exe");
                }

                /*if (Process.GetProcessesByName("accountingserveremulator-windows").Length != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    //writer.WriteLine("TS3 Accounting está em execução");
                    Console.WriteLine("[{0}] TS3 Accounting está em execução", allProcess);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[{0}] TS3 Accounting não está em execução", allProcess);
                    //writer.WriteLine("TS3 Accounting não está em execução");
                    Console.ResetColor();
                    OpenProgram("C:\\Users\\root\\Desktop\\TS3\\", "AccountingServerEmulator-Windows.exe");
                    Thread.Sleep(3000);
                }*/

                /*if (Process.GetProcessesByName("ts3server").Length != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    //writer.WriteLine("Servidor TS3 está em execução");
                    Console.WriteLine("[{0}] Servidor TS3 está em execução", allProcess);
                    Console.ResetColor();
                }
                else
                {
                    if (Process.GetProcessesByName("accountingserveremulator-windows").Length != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[{0}] Account funcionando ! Servidor TS3 não está em execução", allProcess);
                        //writer.WriteLine("Account funcionando ! Servidor TS3 não está em execução");
                        Console.ResetColor();
                        OpenProgram("C:\\Users\\root\\Desktop\\TS3\\", "ts3server.exe");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[{0}] Account não funcionando ! Servidor TS3 não está em execução", allProcess);
                        //writer.WriteLine("Account não funcionando ! Servidor TS3 não está em execução");
                        Console.ResetColor();
                        while (Process.GetProcessesByName("accountingserveremulator-windows").Length != 0)
                        {
                            OpenProgram("C:\\Users\\root\\Desktop\\TS3\\", "AccountingServerEmulator-Windows.exe");
                            Console.WriteLine("Aguardando a inicialização do Accounting ...");
                            Thread.Sleep(2000);
                        }

                        OpenProgram("C:\\Users\\root\\Desktop\\TS3\\", "ts3server.exe");

                    }
                }*/
            }
            else
            {
            rsbuild:
                while (Process.GetProcessesByName("rsbuild").Length != 0)
                {
                    Console.Title = "Verificação em pausa ! Aguardando a finalização da atualização - Italo Fialho";
                    Console.WriteLine("Verificação em pausa ! Aguardando a finalização da atualização .... Verificando novamente em 5s");
                    Thread.Sleep(5000);
                    needCountdown = false;
                    goto rsbuild;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVerificado em: {0}\n", DateTime.Now.ToString("h:mm:ss"));
            Console.WriteLine("Aguardando .... Verificando novamente em {0}s", timeToCheck);

            //RAZOR::Create timeout loop !
            if (needCountdown && !isStopped)
            {
                int timeOut = 0;
                for (int zx = 0; zx < timeToCheck; zx++)
                {
                    timeOut = zx;
                    Console.WriteLine("Verificando novamente em {0}s", Convert.ToInt32(timeToCheck - zx));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Thread.Sleep(1000);
                    //RAZOR::Reset line while countdown is working 1
                    ClearCurrentConsoleLine();

                    
                }
            }

            //writer.WriteLine("======================================================================");
            Console.WriteLine("======================================================================");
            Console.ResetColor();

            //RAZOR::Restart all !
            goto verifica;



        }

        public static void OpenProgram(string dir, string exe)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            try
            {
                Process processo = new Process();
                processo.StartInfo.FileName = exe;
                processo.StartInfo.WorkingDirectory = dir;
                processo.StartInfo.CreateNoWindow = true;
                processo.StartInfo.UseShellExecute = true;
                processo.Start();
                Console.WriteLine("Programa {0} iniciado com sucesso !", exe);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Programa não foi executado ! Erro: {0}", ex.Message);
            }

            Console.ResetColor();
            return;
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
