using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_System
{
    public partial class Splashpage : Form
    {
        Timer t;
        public Splashpage()
        {
            InitializeComponent();
        }

        private void Splashpage_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 3000;
            t.Start();
            t.Tick += T_Tick;
           
        }

        private void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
