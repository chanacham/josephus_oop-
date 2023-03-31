using System.Collections.Generic;
using System.Drawing.Text;

namespace JosephusGUI
{
    public partial class Form1 : Form
    {
        readonly int RADIUS = 250;
        readonly int CENTER = 300;
        readonly int SOLDIER_H = 65;
        readonly int SOLDIER_W = 25;

        List<PictureBox> soldiersList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            InitialSoldiers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nSoldiers_ValueChanged(object sender, EventArgs e)
        {
            var numSoldiers = (int)nSoldiers.Value;

            CreateSoldiers(numSoldiers);
        }

        private void InitialSoldiers()
        {
            CreateSoldiers(3);
        }
        private void CreateSoldiers(int numSoldiers)
        {
            pnlBattleField.Controls.Clear();
            for (int ns = 0; ns < numSoldiers; ns++)
            {
                MakeSoldier(ns, numSoldiers);
            }
        }

        private void MakeSoldier(int ns, int numSoldiers)
        {
            PictureBox soldier = new PictureBox();
            pnlBattleField.Controls.Add(soldier);
            soldier.Image = yellow_duck.Image;
            soldier.Visible = true;
            soldier.Size = new Size(SOLDIER_W, SOLDIER_H);
            double degree = 360 / numSoldiers;
            double radians = ns * (degree / 180 * Math.PI);
            int xCord = (int)(CENTER + RADIUS * Math.Cos(radians));
            int yCord = (int)(CENTER - RADIUS * Math.Sin(radians));
            soldier.Location = new Point(xCord, yCord);

            soldiersList.Add(soldier);
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            GoCountdown((int)nCount.Value, (int)nSoldiers.Value);
        }

        private void GoCountdown(int nCount, int soldiers)
        {
            List<Boolean> soldierStatus = new List<Boolean>(soldiers);// false is not killed, true is killed 

            // keep going until n-1 ducks are dead, base case 
            int remainingSoldiers = soldiers;
            //position of sword 
            int currentIndex = 0;
            // count of starting position, % ducks  

            // base case of 1 duck remaining  
            if (remainingSoldiers == 1)
            {
                Console.WriteLine("Game over ");
                return;
            }

            //find the index where the first duck will become a goose 
            currentIndex = ((currentIndex + nCount) % soldiers);

            for (int i = 0; i < currentIndex; i++)
            {
                soldiersList[i].Visible = true;
                soldiersList[i].Image = pink_duck.Image;
            }

            // goose the duck at the end of the countdown 
            soldierStatus[currentIndex] = true;
            soldiersList[currentIndex].Visible = false;
            soldiersList[currentIndex].Image = goose.Image;
            remainingSoldiers--;

            //recursive call for 1 less soldier
            GoCountdown(nCount, remainingSoldiers);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbSoldier_Click(object sender, EventArgs e)
        {

        }
    }
}