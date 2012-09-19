using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WatchTower
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public delegate void StatusSet(int number, bool status);
        public delegate void PerformStep();
        public StatusSet statusSet;
        public PerformStep performStep;
        public DataTable dTable;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = Properties.Settings.Default.Timer;
            this.progressBar1.Step = Properties.Settings.Default.Timer / 1000;
            
            statusSet = new StatusSet(setStatus);
            performStep = new PerformStep(performStepM);
            char[] delimiterChars = { ';', ':' };
            List<string> fileRows = new List<string>();

            try
            {
                StreamReader sReader = File.OpenText("config.ini");
                string read = null;
                while ((read = sReader.ReadLine()) != null)
                {
                    fileRows.Add(read);
                }
                
            }
            catch (Exception)
            {
            
                MessageBox.Show("Не найден файл config.ini");
                this.Close();

            }
            if (fileRows.Count == 0)
            {
                MessageBox.Show("Файл настроек пуст");
                this.Close();
            }
            this.dTable = new DataTable();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dTable;
            this.listGridView.DataSource = bSource;
            dTable.Columns.Add("Name");
            dTable.Columns.Add("IPAdress");
            dTable.Columns.Add("port");
            dTable.Columns.Add("status",typeof(bool));
            
            int i = 0;
            foreach (string str in fileRows)
            {
                string[] stringParts = str.Split(delimiterChars);
                DataRow dRow = dTable.NewRow();
                dRow["Name"] = stringParts[0];
                dRow["IPAdress"] = stringParts[1];
                dRow["port"] = stringParts[2];
                dTable.Rows.Add(dRow);

                
            }
            
            Watcher watcher = new Watcher(fileRows);
            watcher.parent = this;
            Thread watchDuty = new Thread(new ThreadStart(watcher.watch));
            watchDuty.Start();
               
            
            
        }
        public void setStatus(int number, bool status){
            this.dTable.Rows[number]["status"] = status;
        
        }
        public void performStepM()
        {
            
            this.progressBar1.Value=this.progressBar1.Value+1000;
            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                this.progressBar1.Value = 0;
            }

        }
    }
}
