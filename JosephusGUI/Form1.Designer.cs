namespace JosephusGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NumSol = new Label();
            label2 = new Label();
            nSoldiers = new NumericUpDown();
            nCount = new NumericUpDown();
            bGo = new Button();
            pink_duck = new PictureBox();
            pnlBattleField = new Panel();
            goose = new PictureBox();
            yellow_duck = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nSoldiers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pink_duck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellow_duck).BeginInit();
            SuspendLayout();
            // 
            // NumSol
            // 
            NumSol.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumSol.Location = new Point(28, 24);
            NumSol.Name = "NumSol";
            NumSol.Size = new Size(168, 25);
            NumSol.TabIndex = 0;
            NumSol.Text = "Number of Soldiers";
            NumSol.TextAlign = ContentAlignment.MiddleRight;
            NumSol.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 73);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Countdown";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nSoldiers
            // 
            nSoldiers.BackColor = SystemColors.ControlLight;
            nSoldiers.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nSoldiers.Location = new Point(215, 12);
            nSoldiers.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nSoldiers.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nSoldiers.Name = "nSoldiers";
            nSoldiers.ReadOnly = true;
            nSoldiers.RightToLeft = RightToLeft.No;
            nSoldiers.Size = new Size(57, 30);
            nSoldiers.TabIndex = 2;
            nSoldiers.TextAlign = HorizontalAlignment.Center;
            nSoldiers.Value = new decimal(new int[] { 3, 0, 0, 0 });
            nSoldiers.ValueChanged += nSoldiers_ValueChanged;
            // 
            // nCount
            // 
            nCount.BackColor = SystemColors.ControlLight;
            nCount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nCount.Location = new Point(215, 72);
            nCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nCount.Name = "nCount";
            nCount.Size = new Size(57, 30);
            nCount.TabIndex = 3;
            nCount.TextAlign = HorizontalAlignment.Center;
            nCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // bGo
            // 
            bGo.BackColor = SystemColors.ButtonFace;
            bGo.BackgroundImage = Properties.Resources.sword;
            bGo.BackgroundImageLayout = ImageLayout.Center;
            bGo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bGo.Location = new Point(326, 20);
            bGo.Name = "bGo";
            bGo.Size = new Size(65, 82);
            bGo.TabIndex = 4;
            bGo.TextImageRelation = TextImageRelation.ImageAboveText;
            bGo.UseVisualStyleBackColor = false;
            bGo.Click += bGo_Click;
            // 
            // pink_duck
            // 
            pink_duck.Image = (Image)resources.GetObject("pink_duck.Image");
            pink_duck.Location = new Point(889, 12);
            pink_duck.Name = "pink_duck";
            pink_duck.Size = new Size(27, 37);
            pink_duck.TabIndex = 5;
            pink_duck.TabStop = false;
            pink_duck.Visible = false;
            pink_duck.Click += pbSoldier_Click;
            // 
            // pnlBattleField
            // 
            pnlBattleField.Location = new Point(269, 128);
            pnlBattleField.Name = "pnlBattleField";
            pnlBattleField.Size = new Size(600, 600);
            pnlBattleField.TabIndex = 6;
            pnlBattleField.Paint += panel1_Paint;
            // 
            // goose
            // 
            goose.Image = (Image)resources.GetObject("goose.Image");
            goose.Location = new Point(710, 24);
            goose.Name = "goose";
            goose.Size = new Size(35, 37);
            goose.TabIndex = 7;
            goose.TabStop = false;
            goose.Visible = false;
            // 
            // yellow_duck
            // 
            yellow_duck.Image = Properties.Resources.shrunk_yellow_duck;
            yellow_duck.Location = new Point(796, 24);
            yellow_duck.Name = "yellow_duck";
            yellow_duck.Size = new Size(40, 47);
            yellow_duck.TabIndex = 8;
            yellow_duck.TabStop = false;
            yellow_duck.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 740);
            Controls.Add(yellow_duck);
            Controls.Add(goose);
            Controls.Add(pnlBattleField);
            Controls.Add(pink_duck);
            Controls.Add(bGo);
            Controls.Add(nCount);
            Controls.Add(nSoldiers);
            Controls.Add(label2);
            Controls.Add(NumSol);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nSoldiers).EndInit();
            ((System.ComponentModel.ISupportInitialize)nCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pink_duck).EndInit();
            ((System.ComponentModel.ISupportInitialize)goose).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellow_duck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label NumSol;
        private Label label2;
        private NumericUpDown nSoldiers;
        private NumericUpDown nCount;
        private Button bGo;
        private PictureBox pink_duck;
        private Panel pnlBattleField;
        private PictureBox goose;
        private PictureBox yellow_duck;
    }
}