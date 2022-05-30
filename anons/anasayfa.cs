using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace anons
{
    public partial class anasayfa : Form
    {

      
        public anasayfa()
        {
            InitializeComponent();
           
        }

        SoundPlayer splayer = new SoundPlayer();
        private void btnanaonset_Click(object sender, EventArgs e)
        {
            int sayi, yuzler, onlar, birler;
            sayi = Convert.ToInt32(guna2TextBox3.Text);
           

          
            if(sayi < 10 )
            {
                
                onlar = sayi / 10;
                sayi = sayi - (onlar * 10);
                birler = sayi;
                splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Asıl Rakamlar\\" + onlar + ".wav";
                splayer.Play();
                Thread.Sleep(1000);
                splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Asıl Rakamlar\\" + birler + ".wav";
                splayer.Play();

            }
            else if (sayi >= 10 )
            {
                yuzler = sayi / 100;
                sayi = sayi - (yuzler * 100);
                onlar = sayi / 10;
                sayi = sayi - (onlar * 10);
                birler = sayi;
                splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Asıl Rakamlar\\" + onlar*10 + ".wav";
                splayer.Play();
                Thread.Sleep(1000);
                if(birler !=0 )
                {
                    splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Asıl Rakamlar\\" + birler + ".wav";
                    splayer.Play();

                }
              
            }
           

           

            //if (guna2TextBox3.Text.Length <= 12 && guna2TextBox3.Text.Length >= 1)
            //{
            //    Int64 sayi = Convert.ToInt64(guna2TextBox3.Text);
            //    Int64 basamak = 0;
            //    for (int i = 0; i < guna2TextBox3.Text.Length; i++)
            //    {
            //        basamak = sayi % 10;
            //        sayi = sayi / 10;
                   
            //        //splayer.SoundLocation = Application.StartupPath + "\\Sesler\\Asıl Rakamlar\\" + basamak + ".wav";
            //        //splayer.Play();
            //    }
            //    guna2TextBox1.Text = basamak.ToString();
            //}

           
           
        }
    }
}
