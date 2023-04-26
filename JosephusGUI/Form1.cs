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
            soldiersList.Clear();
            for (int ns = 0; ns < numSoldiers; ns++)
            {
                MakeSoldier(ns, numSoldiers);
            }
        }

        private void MakeSoldier(int ns, int numSoldiers)
        {
            PictureBox soldier = new PictureBox();
            pnlBattleField.Controls.Add(soldier);
            soldiersList.Add(soldier);
            soldier.Image = yellow_duck.Image;
            soldier.Visible = true;
            soldier.Size = new Size(SOLDIER_W, SOLDIER_H);
            double degree = 360 / numSoldiers;
            double radians = ns * (degree / 180 * Math.PI);
            int xCord = (int)(CENTER + RADIUS * Math.Cos(radians));
            int yCord = (int)(CENTER - RADIUS * Math.Sin(radians));
            soldier.Location = new Point(xCord, yCord);
           
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            int index = 0;
            GoCountdown((int)nCount.Value, index);
        }

        private void GoCountdown(int nCount, int StartIndex)
        {

            //base case of 1 remaining duck 
            if (soldiersList.Count == 1)
            {
                TextBox textBox = new TextBox(); 
                textBox.Text = "Last duck!!";
                textBox.Visible = true; 
                textBox.Location = new Point(CENTER, CENTER);
                pnlBattleField.Controls.Add(textBox);

                return;
            }

            //count the ducks leading up to the goose
            int pinkLocation = StartIndex;
            for (int pinkCount = 0; pinkCount < nCount; pinkCount++)
            {
                pinkLocation %= soldiersList.Count;

                soldiersList[pinkLocation].Image = pink_duck.Image;
                soldiersList[pinkLocation].Visible = true;
                pnlBattleField.Refresh();

                Thread.Sleep(1000);
                soldiersList[pinkLocation].Image = yellow_duck.Image;
                soldiersList[pinkLocation].Visible = true;
                pnlBattleField.Refresh();

                pinkLocation += 1;


                Thread.Sleep(1000);
            }

            //move the index to the duck about to be goosed
            StartIndex = ((StartIndex + nCount) % soldiersList.Count);

            // goose the duck at the end of the countdown 
            soldiersList[StartIndex].Image = goose.Image;
            soldiersList[StartIndex].Visible=true;
            pnlBattleField.Refresh();


            Thread.Sleep(1000);
           

            //remove the goose 
            pnlBattleField.Controls.Remove(soldiersList.ElementAt(StartIndex));
            paintDeadGoose(soldiersList.ElementAt(StartIndex));
            soldiersList.Remove(soldiersList.ElementAt(StartIndex));


            //recursive call to find the goose with n-1 ducks 
            GoCountdown(nCount, StartIndex);

        }

        private void paintDeadGoose(PictureBox pictureBox)
        {
            PictureBox deadGoose = new PictureBox();
            deadGoose.Image = goose.Image;
            Point deadGooseLocation = new Point(pictureBox.Location.X, pictureBox.Location.Y); 

            deadGoose.Location = deadGooseLocation;
            deadGoose.Visible = true;
            pnlBattleField.Controls.Add(deadGoose);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbSoldier_Click(object sender, EventArgs e)
        {

        }
    }
}