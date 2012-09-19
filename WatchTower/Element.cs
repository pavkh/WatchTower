using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WatchTower
{
    public partial class Element : UserControl
    {
        public Element(string name, string ip)
        {
            InitializeComponent();
            NameNode.Text = name;
            IP.Text = ip;
            status.Text = "";
        }
        

    }
}
