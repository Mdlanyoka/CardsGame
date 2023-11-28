
namespace CardsGame
{
    partial class GamePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYour = new System.Windows.Forms.TextBox();
            this.txtComputer = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picYou = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblRounds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblCardsLeft = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblTie = new System.Windows.Forms.Label();
            this.txtTie = new System.Windows.Forms.TextBox();
            this.txtLeftCards = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.rateToolStripMenuItem,
            this.playOnlineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Checked = true;
            this.exitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1,
            this.languageToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.BackColorChanged += new System.EventHandler(this.ColorToolStripMenuItem_Click_1);
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click_1);
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            this.colorToolStripMenuItem1.Click += new System.EventHandler(this.colorToolStripMenuItem1_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.languageToolStripMenuItem.Text = "Language";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // rateToolStripMenuItem
            // 
            this.rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            this.rateToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.rateToolStripMenuItem.Text = "Rate";
            this.rateToolStripMenuItem.Click += new System.EventHandler(this.rateToolStripMenuItem_Click);
            // 
            // playOnlineToolStripMenuItem
            // 
            this.playOnlineToolStripMenuItem.Name = "playOnlineToolStripMenuItem";
            this.playOnlineToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.playOnlineToolStripMenuItem.Text = "Play online";
            this.playOnlineToolStripMenuItem.Click += new System.EventHandler(this.playOnlineToolStripMenuItem_Click);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ColorToolStripMenuItem.Text = "Color";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(571, 511);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 33);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Location = new System.Drawing.Point(159, 120);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(119, 16);
            this.lblComputerScore.TabIndex = 6;
            this.lblComputerScore.Text = "Computer Score";
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Location = new System.Drawing.Point(15, 120);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(85, 16);
            this.lblYourScore.TabIndex = 7;
            this.lblYourScore.Text = "Your Score";
            this.lblYourScore.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "You";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Computer";
            // 
            // txtYour
            // 
            this.txtYour.Location = new System.Drawing.Point(18, 139);
            this.txtYour.Name = "txtYour";
            this.txtYour.Size = new System.Drawing.Size(100, 22);
            this.txtYour.TabIndex = 11;
            this.txtYour.TextChanged += new System.EventHandler(this.txtYour_TextChanged);
            // 
            // txtComputer
            // 
            this.txtComputer.Location = new System.Drawing.Point(162, 139);
            this.txtComputer.Name = "txtComputer";
            this.txtComputer.Size = new System.Drawing.Size(100, 22);
            this.txtComputer.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CardsGame.Properties.Resources.images;
            this.pictureBox3.Location = new System.Drawing.Point(1024, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 164);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // picComputer
            // 
            this.picComputer.Location = new System.Drawing.Point(664, 237);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(117, 179);
            this.picComputer.TabIndex = 1;
            this.picComputer.TabStop = false;
            this.picComputer.VisibleChanged += new System.EventHandler(this.cardSelection_Click);
            this.picComputer.Click += new System.EventHandler(this.cardSelection_Click);
            // 
            // picYou
            // 
            this.picYou.Location = new System.Drawing.Point(484, 237);
            this.picYou.Name = "picYou";
            this.picYou.Size = new System.Drawing.Size(117, 179);
            this.picYou.TabIndex = 0;
            this.picYou.TabStop = false;
            this.picYou.Click += new System.EventHandler(this.cardSelection_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CardsGame.Properties.Resources.images;
            this.pictureBox4.Location = new System.Drawing.Point(1158, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CardsGame.Properties.Resources.images;
            this.pictureBox5.Location = new System.Drawing.Point(1033, 364);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 164);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CardsGame.Properties.Resources.images;
            this.pictureBox6.Location = new System.Drawing.Point(1158, 364);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(106, 164);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(481, 123);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(61, 16);
            this.lblRounds.TabIndex = 17;
            this.lblRounds.Text = "Rounds";
            this.lblRounds.Click += new System.EventHandler(this.Rounds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "High Scores  :";
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(110, 269);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(100, 22);
            this.txtHigh.TabIndex = 19;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CardsGame.Properties.Resources.images;
            this.pictureBox7.Location = new System.Drawing.Point(891, 364);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(106, 164);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CardsGame.Properties.Resources.images;
            this.pictureBox8.Location = new System.Drawing.Point(891, 152);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(106, 164);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(571, 550);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(110, 33);
            this.btnPause.TabIndex = 22;
            this.btnPause.Text = "Pause game";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(571, 589);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(110, 33);
            this.btnRestart.TabIndex = 23;
            this.btnRestart.Text = "Restart game";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblCardsLeft
            // 
            this.lblCardsLeft.AutoSize = true;
            this.lblCardsLeft.Location = new System.Drawing.Point(888, 123);
            this.lblCardsLeft.Name = "lblCardsLeft";
            this.lblCardsLeft.Size = new System.Drawing.Size(78, 16);
            this.lblCardsLeft.TabIndex = 24;
            this.lblCardsLeft.Text = "Left Cards";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2_of_clubs.png");
            this.imageList1.Images.SetKeyName(1, "2_of_diamonds.png");
            this.imageList1.Images.SetKeyName(2, "2_of_hearts.png");
            this.imageList1.Images.SetKeyName(3, "2_of_spades.png");
            this.imageList1.Images.SetKeyName(4, "3_of_clubs.png");
            this.imageList1.Images.SetKeyName(5, "3_of_diamonds.png");
            this.imageList1.Images.SetKeyName(6, "3_of_hearts.png");
            this.imageList1.Images.SetKeyName(7, "3_of_spades.png");
            this.imageList1.Images.SetKeyName(8, "4_of_clubs.png");
            this.imageList1.Images.SetKeyName(9, "4_of_diamonds.png");
            this.imageList1.Images.SetKeyName(10, "4_of_hearts.png");
            this.imageList1.Images.SetKeyName(11, "4_of_spades.png");
            this.imageList1.Images.SetKeyName(12, "5_of_clubs.png");
            this.imageList1.Images.SetKeyName(13, "5_of_diamonds.png");
            this.imageList1.Images.SetKeyName(14, "5_of_hearts.png");
            this.imageList1.Images.SetKeyName(15, "5_of_spades.png");
            this.imageList1.Images.SetKeyName(16, "6_of_clubs.png");
            this.imageList1.Images.SetKeyName(17, "6_of_diamonds.png");
            this.imageList1.Images.SetKeyName(18, "6_of_hearts.png");
            this.imageList1.Images.SetKeyName(19, "6_of_spades.png");
            this.imageList1.Images.SetKeyName(20, "7_of_clubs.png");
            this.imageList1.Images.SetKeyName(21, "7_of_diamonds.png");
            this.imageList1.Images.SetKeyName(22, "7_of_hearts.png");
            this.imageList1.Images.SetKeyName(23, "7_of_spades.png");
            this.imageList1.Images.SetKeyName(24, "8_of_clubs.png");
            this.imageList1.Images.SetKeyName(25, "8_of_diamonds.png");
            this.imageList1.Images.SetKeyName(26, "8_of_hearts.png");
            this.imageList1.Images.SetKeyName(27, "8_of_spades.png");
            this.imageList1.Images.SetKeyName(28, "9_of_clubs.png");
            this.imageList1.Images.SetKeyName(29, "9_of_diamonds.png");
            this.imageList1.Images.SetKeyName(30, "9_of_hearts.png");
            this.imageList1.Images.SetKeyName(31, "9_of_spades.png");
            this.imageList1.Images.SetKeyName(32, "10_of_clubs.png");
            this.imageList1.Images.SetKeyName(33, "10_of_diamonds.png");
            this.imageList1.Images.SetKeyName(34, "10_of_hearts.png");
            this.imageList1.Images.SetKeyName(35, "10_of_spades.png");
            this.imageList1.Images.SetKeyName(36, "ace_of_clubs.png");
            this.imageList1.Images.SetKeyName(37, "ace_of_diamonds.png");
            this.imageList1.Images.SetKeyName(38, "ace_of_hearts.png");
            this.imageList1.Images.SetKeyName(39, "ace_of_spades.png");
            this.imageList1.Images.SetKeyName(40, "jack_of_clubs2.png");
            this.imageList1.Images.SetKeyName(41, "jack_of_diamonds2.png");
            this.imageList1.Images.SetKeyName(42, "jack_of_hearts2.png");
            this.imageList1.Images.SetKeyName(43, "jack_of_spades2.png");
            this.imageList1.Images.SetKeyName(44, "king_of_clubs2.png");
            this.imageList1.Images.SetKeyName(45, "king_of_diamonds2.png");
            this.imageList1.Images.SetKeyName(46, "king_of_hearts2.png");
            this.imageList1.Images.SetKeyName(47, "king_of_spades2.png");
            this.imageList1.Images.SetKeyName(48, "queen_of_clubs2.png");
            this.imageList1.Images.SetKeyName(49, "queen_of_diamonds2.png");
            this.imageList1.Images.SetKeyName(50, "queen_of_hearts2.png");
            this.imageList1.Images.SetKeyName(51, "queen_of_spades2.png");
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Location = new System.Drawing.Point(53, 196);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(31, 16);
            this.lblTie.TabIndex = 27;
            this.lblTie.Text = "Tie";
            // 
            // txtTie
            // 
            this.txtTie.Location = new System.Drawing.Point(110, 193);
            this.txtTie.Name = "txtTie";
            this.txtTie.Size = new System.Drawing.Size(100, 22);
            this.txtTie.TabIndex = 28;
            // 
            // txtLeftCards
            // 
            this.txtLeftCards.Location = new System.Drawing.Point(888, 89);
            this.txtLeftCards.Name = "txtLeftCards";
            this.txtLeftCards.Size = new System.Drawing.Size(78, 22);
            this.txtLeftCards.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(117, 328);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 16);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "........";
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1264, 634);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTie);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.txtLeftCards);
            this.Controls.Add(this.lblCardsLeft);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtComputer);
            this.Controls.Add(this.txtYour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.picYou);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GamePage";
            this.Text = "GamePage";
            this.Load += new System.EventHandler(this.GamePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picYou;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYour;
        private System.Windows.Forms.TextBox txtComputer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblCardsLeft;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem playOnlineToolStripMenuItem;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.TextBox txtTie;
        private System.Windows.Forms.TextBox txtLeftCards;
        private System.Windows.Forms.Label lblStatus;
    }
}