namespace WatchTower
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listGridView = new System.Windows.Forms.DataGridView();
            this.NameP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OnOffColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseElement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listGridView);
            this.panel1.Location = new System.Drawing.Point(8, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 275);
            this.panel1.TabIndex = 0;
            // 
            // listGridView
            // 
            this.listGridView.AllowUserToAddRows = false;
            this.listGridView.AllowUserToDeleteRows = false;
            this.listGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameP,
            this.IPAdress,
            this.port,
            this.status,
            this.alarm,
            this.OnOffColumn});
            this.listGridView.Location = new System.Drawing.Point(0, 3);
            this.listGridView.Name = "listGridView";
            this.listGridView.ReadOnly = true;
            this.listGridView.Size = new System.Drawing.Size(571, 272);
            this.listGridView.TabIndex = 0;
            this.listGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listGridView_CellContentClick);
            // 
            // NameP
            // 
            this.NameP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameP.DataPropertyName = "Name";
            this.NameP.HeaderText = "Название";
            this.NameP.Name = "NameP";
            this.NameP.ReadOnly = true;
            // 
            // IPAdress
            // 
            this.IPAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IPAdress.DataPropertyName = "IPAdress";
            this.IPAdress.HeaderText = "IP Адрес";
            this.IPAdress.Name = "IPAdress";
            this.IPAdress.ReadOnly = true;
            this.IPAdress.Width = 76;
            // 
            // port
            // 
            this.port.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.port.DataPropertyName = "port";
            this.port.HeaderText = "Порт";
            this.port.Name = "port";
            this.port.ReadOnly = true;
            this.port.Width = 57;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.FalseValue = "false";
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.TrueValue = "true";
            // 
            // alarm
            // 
            this.alarm.FalseValue = "false";
            this.alarm.HeaderText = "Alarm";
            this.alarm.Name = "alarm";
            this.alarm.ReadOnly = true;
            this.alarm.TrueValue = "true";
            this.alarm.Visible = false;
            // 
            // OnOffColumn
            // 
            this.OnOffColumn.HeaderText = "Оповещение";
            this.OnOffColumn.Name = "OnOffColumn";
            this.OnOffColumn.ReadOnly = true;
            this.OnOffColumn.Text = "Выкл.";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(8, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 24);
            this.panel2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(562, 14);
            this.progressBar1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Watchtower";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseElement});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // CloseElement
            // 
            this.CloseElement.Name = "CloseElement";
            this.CloseElement.Size = new System.Drawing.Size(103, 22);
            this.CloseElement.Text = "Close";
            this.CloseElement.Click += new System.EventHandler(this.Close_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звукToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // звукToolStripMenuItem
            // 
            this.звукToolStripMenuItem.Checked = true;
            this.звукToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.звукToolStripMenuItem.Name = "звукToolStripMenuItem";
            this.звукToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.звукToolStripMenuItem.Text = "Звук";
            this.звукToolStripMenuItem.Click += new System.EventHandler(this.звукToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 333);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "WatchTower";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView listGridView;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseElement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звукToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alarm;
        private System.Windows.Forms.DataGridViewButtonColumn OnOffColumn;
    }
}

