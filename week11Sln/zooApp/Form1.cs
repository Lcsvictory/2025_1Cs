using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dog d = new Dog("dog1", Animal.COLOR.BLACK, 1);
            Animal a = new Dog("dog2", Animal.COLOR.BLACK, 1);

            //Animal c = new Animal("animal1", Animal.COLOR.BLACK);
            //Dog b = new Animal("dog4", Animal.COLOR.BLACK);

            d.Bark(3);
            //a.Bark(3);
            ((Dog)a).Bark(3);




            tbxResult.Text = $"{a.Level} {d.Level}\r\n";
            a.Eat();
            d.Eat();
            tbxResult.Text += $"{a.Level} {d.Level}\r\n";
            a.Play();
            d.Play();
            tbxResult.Text += $"{a.Level} {d.Level}\r\n";
        }
    }
}
