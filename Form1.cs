using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Localization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("uk-UA");
            Controls.Clear();
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
            Controls.Clear();
            InitializeComponent();
        }
    }
}