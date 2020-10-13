using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesement
{
    public class hvclass

    {

        int Bullet = 0;
        int Chances = 1;


        public object Public { get; private set; }

        public void ShootAhead()
        {
            //If bullet is in the barrel, shooting start
            if (Bullet == 5)
            {
                MessageBox.Show("Die");
            }
            else
            {
                MessageBox.Show("barrel rotating");
                Bullet = Bullet + 1;
            }
        }


        public void shootaway()
        {
            //if i have one chance
            if (Chances > 1)
            {
                if (Bullet == 5)
                {
                    MessageBox.Show("loose the game");
                }
                else
                {
                    //not shooting
                    MessageBox.Show("barrel rotating");
                    Bullet = Bullet + 1;
                }

            }
            // not chance
            else
            {
                MessageBox.Show("loose game");
            }
            Chances = Chances - 1;
        }




        public int Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 5);
            MessageBox.Show("spinng");
            return Bullet;
        }


        public int WeaponLoad()
        {
            Bullet = 0;
            MessageBox.Show("reloading");
            return Bullet;



        }

    }
}





