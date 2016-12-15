using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BlokiranjeGlavneNiti
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
        }

        //  Na glavnu formu dodati timer (npr. povlačenjem s alatne trake/toolboxa, pod Components)



        // U glavnu formu dodati metodu koja će biti okinuta togađajem Tick objekta timer. Unutar metode treba ažurirati sadržaj textBox kontrole tako da prikazuje vrijeme u sekundama, pozivom metode DateTime.Now.ToLongTimeString();



        // U glavnu metodu dodati metodu koja će biti okinuta događajem Click tipke buttonBlock. Metoda treba zaustaviti izvođenje glavne niti na 10 sekundi pozivom metode Thread.Sleep(10000)



        // Pokrenuti kod i provjeriti odziv forme nakon pritiska tipke Block


    }
}
