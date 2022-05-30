using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace anons
{
    public partial class anasayfa : Form
    {

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public anasayfa()
        {
            InitializeComponent();
           
        }

        private void btnanaonset_Click(object sender, EventArgs e)
        {
            player.URL = @"" + Application.StartupPath + "\\Sesler\\zil_plaka.mp3";
            player.controls.play();
        }
    }
}
