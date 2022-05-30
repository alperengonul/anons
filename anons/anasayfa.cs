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

      
        public anasayfa()
        {
            InitializeComponent();
           
        }

        private void btnanaonset_Click(object sender, EventArgs e)
        {

            int sayi = Convert.ToInt32(Console.ReadLine());
            int birler = sayi % 10;
            sayi = sayi / 10;
            int onlar = sayi % 10;
            sayi = sayi / 10;
            int yuzler = sayi % 10;
            sayi = sayi / 10;
            int binler = sayi % 10;
        }
    }
}
