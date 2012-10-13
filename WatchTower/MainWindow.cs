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
using System.Media;
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
        public bool playing = false;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (WatchTower.Properties.Settings.Default.sound == false)
            {
                this.звукToolStripMenuItem.Checked = false;
            }

            
            
            
            
            this.progressBar1.Maximum = Properties.Settings.Default.Timer;
            this.progressBar1.Step = Properties.Settings.Default.Timer / 1000;
            


            statusSet = new StatusSet(setStatus);
            performStep = new PerformStep(performStepM);
            char[] delimiterChars = { ';', ':' };
            List<string> fileRows = new List<string>();

            try
            {
                Encoding win1251 = Encoding.GetEncoding(1251);
                //StreamReader sReader = File.OpenText("config.ini");
                StreamReader sReader = new StreamReader("config.ini", win1251, false, 512);
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
            
           
            foreach (string str in fileRows)
            {
               
                string[] stringParts = str.Split(delimiterChars);
                DataRow dRow = dTable.NewRow();
                dRow["Name"] = stringParts[0];
                dRow["IPAdress"] = stringParts[1];
                dRow["port"] = stringParts[2];
                dTable.Rows.Add(dRow);
                
              
            }
            int i = 0;
            foreach (DataGridViewRow row in this.listGridView.Rows)
            {
                
                this.listGridView["OnOffColumn", i].Value = "Вкл.";
                this.listGridView["Alarm", i].Value = true;
                i++;
            }
            Watcher watcher = new Watcher(fileRows);
            watcher.parent = this;
            Thread watchDuty = new Thread(new ThreadStart(watcher.watch));
            watchDuty.Start();
               
            
            
        }
        public void setStatus(int number, bool status){
            this.dTable.Rows[number]["status"] = status;
            
            if (status == false && (Boolean)this.listGridView["Alarm",number].Value == true)
            {
                this.notifyIcon1.BalloonTipTitle = "Внимание!";
                this.notifyIcon1.BalloonTipText = this.dTable.Rows[number]["Name"].ToString() + " не отвечает";
                this.notifyIcon1.ShowBalloonTip(5000);
                if (WatchTower.Properties.Settings.Default.sound == true && this.playing == false)
                {
                    Console.Beep();
                    SoundPlayer sp = new SoundPlayer();
                    sp.Stream = Properties.Resources.BEEP;
                    this.playing = true;
                    sp.Play();
                           
                    
                }

                
                
            }
        
        }
        public void performStepM()
        {
            
            this.progressBar1.Value=this.progressBar1.Value+1000;
            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                this.progressBar1.Value = 0;
            }

        }


        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (this.Visible)
                {
                    case true:
                        this.Visible = false;
                        break;
                    case false:
                        this.Visible = true;
                        break;
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.listGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
            if (this.listGridView[e.ColumnIndex,e.RowIndex].Value.ToString() == "Вкл.")
            {
                this.listGridView[e.ColumnIndex, e.RowIndex].Value = "Выкл.";
                this.listGridView["alarm", e.RowIndex].Value = false;
                return;
            }
            if (this.listGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == "Выкл.")
            {
                this.listGridView[e.ColumnIndex, e.RowIndex].Value = "Вкл.";
                this.listGridView["alarm", e.RowIndex].Value = true;
                return;
            }
            }
        }

        private void звукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.звукToolStripMenuItem.Checked == false)
            {
                this.звукToolStripMenuItem.Checked = true;
                WatchTower.Properties.Settings.Default.sound = true;
                WatchTower.Properties.Settings.Default.Save();
            }
            if (this.звукToolStripMenuItem.Checked == true)
            {
                this.звукToolStripMenuItem.Checked = false;
                WatchTower.Properties.Settings.Default.sound = false;
                WatchTower.Properties.Settings.Default.Save();
            }
        }
    }
}
