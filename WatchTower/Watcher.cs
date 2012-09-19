using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Timers;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace WatchTower
{
    class Watcher
    {
        public List<string> fileRows;
        public System.Timers.Timer _timer;
        public System.Timers.Timer _ticktack;
        public MainWindow parent;
        public Watcher(List<string>fileRows)
        {
            this.fileRows = fileRows;
            this._timer = new System.Timers.Timer(Properties.Settings.Default.Timer);
            this._ticktack = new System.Timers.Timer(1000);
            this._ticktack.Elapsed += new ElapsedEventHandler(_ticktack_Elapsed);
            this._timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            
            
            
        }

        void _ticktack_Elapsed(object sender, ElapsedEventArgs e)
        {
            MainWindow mainWindow = this.parent;
            mainWindow.Invoke(mainWindow.performStep);
        }
        

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this._timer.Stop();
            this._ticktack.Stop();
            MainWindow mainWindow = this.parent;
            
            int i=0;
            foreach (string str in this.fileRows)
            {
                char[] delimiterChars = { ';', ':' };
                string[] stringParts = str.Split(delimiterChars);
                if (stringParts[2] == "ping")
                {
                    Ping pPing = new Ping();
                    PingOptions pOptions = new PingOptions();
                    string data = "1234567890asdfghjklzxcvbnm";
                    byte[] buffer = Encoding.ASCII.GetBytes(data);
                    int timeout = Properties.Settings.Default.PingTimeout;
                    PingReply reply = pPing.Send(stringParts[1], timeout, buffer, pOptions);
                    if (reply.Status == IPStatus.Success)
                    {

                        
                        mainWindow.Invoke(mainWindow.statusSet, i,true);
                    }
                    else
                    {
                       
                        mainWindow.Invoke(mainWindow.statusSet, i, false);
                    }

                
                }
                else
                {
                    try
                    {
                        TcpClient tcpClient = new TcpClient(stringParts[1], Convert.ToInt32(stringParts[2]));
                        tcpClient.Close();
                        
                        mainWindow.Invoke(mainWindow.statusSet, i, true);

                    }
                    catch (Exception)
                    {

                        
                        mainWindow.Invoke(mainWindow.statusSet, i, false);
                    }
                }
                i++;
                this._timer.Start();
                this._ticktack.Start();
               
            }
            
        }
        public void watch()
        {

            this._ticktack.Start();
            this._timer.Start();
            

        }
    }
}
