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
            int index = 0;
            GoCountdown((int)nCount.Value - 1, index);
        }

        private void GoCountdown(int nCount, int index)
        {
            //KNOWN BUG: changing the images within the run of the algorithm does not work. 

            //base case of 1 remaining duck 
            if (soldiersList.Count == 1)
            {
                soldiersList[0].Visible = false;
                soldiersList[0].Image = goose.Image;
                soldiersList[0].Visible = true;

                return;
            }
            
            //count the ducks leading up to the goose 
            for (int i = index; i < (nCount % soldiersList.Count); i++)
            {
                Thread.Sleep(1000);
                soldiersList[i].Visible = false;
                soldiersList[i].Image = pink_duck.Image;
                soldiersList[i].Visible = true;

            }

            //move the index to the duck about to be goosed
            index = ((index + nCount) % soldiersList.Count);

            // goose the duck at the end of the countdown 
            soldiersList[index].Visible = false;
            soldiersList[index].Image = goose.Image;
            soldiersList[index].Visible=true;

            //remove the goose so the recursive call will work 
            pnlBattleField.Controls.Remove(soldiersList.ElementAt(index));
            soldiersList.Remove(soldiersList.ElementAt(index));

            Thread.Sleep(index * 1000);
            //recursive call to find the goose with n-1 ducks 
            GoCountdown(nCount, index);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbSoldier_Click(object sender, EventArgs e)
        {

        }
    }
}