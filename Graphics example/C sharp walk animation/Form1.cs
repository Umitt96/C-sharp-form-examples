using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_walk_animation
{
    public partial class Form1 : Form
    {
        Graphics g;
        int sayac = 1;
        int x = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 13)
                sayac = 1;

            string dosya_yolu = @"C:\Users\Umit\Desktop\C sharp graphics\animation\a (" + sayac.ToString() +").gif";

            Image im = Image.FromFile(dosya_yolu);

            x += 5;
            g.DrawImage(im,x*1,1);
        }
    }
}
