using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesement
{
    public partial class Form1 : Form
    {
        hvclass hvclass = new hvclass();
        public StreamingContext Voice { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //I am listening gun voice
            SoundPlayer sound = new SoundPlayer(Properties.Resources.Gun_Voice);
            sound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hvclass.WeaponLoad();
        }

        private void ShootAhead_Click(object sender, EventArgs e)
        {
            hvclass.ShootAhead();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            hvclass.Spin();
        }
    }
}
