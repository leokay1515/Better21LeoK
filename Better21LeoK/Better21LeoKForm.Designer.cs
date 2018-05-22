namespace Better21LeoK
{
    partial class frmBetter21LeoK
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniClearWins = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYourCards = new System.Windows.Forms.Label();
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.picUserCard1 = new System.Windows.Forms.PictureBox();
            this.picUserCard2 = new System.Windows.Forms.PictureBox();
            this.picUserCard3 = new System.Windows.Forms.PictureBox();
            this.picDealerCard1 = new System.Windows.Forms.PictureBox();
            this.picDealerCard2 = new System.Windows.Forms.PictureBox();
            this.picDealerCard3 = new System.Windows.Forms.PictureBox();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblUserTotal = new System.Windows.Forms.Label();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniOptions});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniOptions
            // 
            this.mniOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniClearWins});
            this.mniOptions.Name = "mniOptions";
            this.mniOptions.Size = new System.Drawing.Size(61, 20);
            this.mniOptions.Text = "Options";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(180, 22);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.mniNewGame_Click);
            // 
            // mniClearWins
            // 
            this.mniClearWins.Name = "mniClearWins";
            this.mniClearWins.Size = new System.Drawing.Size(180, 22);
            this.mniClearWins.Text = "Clear Wins";
            this.mniClearWins.Click += new System.EventHandler(this.mniClearWins_Click);
            // 
            // lblYourCards
            // 
            this.lblYourCards.AutoSize = true;
            this.lblYourCards.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourCards.Location = new System.Drawing.Point(12, 24);
            this.lblYourCards.Name = "lblYourCards";
            this.lblYourCards.Size = new System.Drawing.Size(124, 31);
            this.lblYourCards.TabIndex = 1;
            this.lblYourCards.Text = "Your Cards";
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.AutoSize = true;
            this.lblDealerCards.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCards.Location = new System.Drawing.Point(454, 24);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(144, 31);
            this.lblDealerCards.TabIndex = 2;
            this.lblDealerCards.Text = "Dealer Cards";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(323, 369);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(93, 70);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(323, 287);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(93, 35);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(323, 328);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(93, 35);
            this.btnStay.TabIndex = 5;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // picUserCard1
            // 
            this.picUserCard1.Image = global::Better21LeoK.Properties.Resources.Front;
            this.picUserCard1.Location = new System.Drawing.Point(18, 58);
            this.picUserCard1.Name = "picUserCard1";
            this.picUserCard1.Size = new System.Drawing.Size(127, 187);
            this.picUserCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCard1.TabIndex = 6;
            this.picUserCard1.TabStop = false;
            // 
            // picUserCard2
            // 
            this.picUserCard2.Image = global::Better21LeoK.Properties.Resources.Front;
            this.picUserCard2.Location = new System.Drawing.Point(151, 58);
            this.picUserCard2.Name = "picUserCard2";
            this.picUserCard2.Size = new System.Drawing.Size(127, 187);
            this.picUserCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCard2.TabIndex = 7;
            this.picUserCard2.TabStop = false;
            // 
            // picUserCard3
            // 
            this.picUserCard3.Image = global::Better21LeoK.Properties.Resources.Front;
            this.picUserCard3.Location = new System.Drawing.Point(85, 251);
            this.picUserCard3.Name = "picUserCard3";
            this.picUserCard3.Size = new System.Drawing.Size(127, 187);
            this.picUserCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCard3.TabIndex = 8;
            this.picUserCard3.TabStop = false;
            // 
            // picDealerCard1
            // 
            this.picDealerCard1.Image = global::Better21LeoK.Properties.Resources.Front;
            this.picDealerCard1.Location = new System.Drawing.Point(460, 58);
            this.picDealerCard1.Name = "picDealerCard1";
            this.picDealerCard1.Size = new System.Drawing.Size(127, 187);
            this.picDealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard1.TabIndex = 9;
            this.picDealerCard1.TabStop = false;
            // 
            // picDealerCard2
            // 
            this.picDealerCard2.Image = global::Better21LeoK.Properties.Resources.Front;
            this.picDealerCard2.Location = new System.Drawing.Point(593, 58);
            this.picDealerCard2.Name = "picDealerCard2";
            this.picDealerCard2.Size = new System.Drawing.Size(127, 187);
            this.picDealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard2.TabIndex = 10;
            this.picDealerCard2.TabStop = false;
            // 
            // picDealerCard3
            // 
            this.picDealerCard3.Image = global::Better21LeoK.Properties.Resources.Front;
            this.picDealerCard3.Location = new System.Drawing.Point(525, 251);
            this.picDealerCard3.Name = "picDealerCard3";
            this.picDealerCard3.Size = new System.Drawing.Size(127, 187);
            this.picDealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard3.TabIndex = 11;
            this.picDealerCard3.TabStop = false;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(302, 143);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(67, 31);
            this.lblWins.TabIndex = 12;
            this.lblWins.Text = "Wins:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(201, 504);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 31);
            this.lblResult.TabIndex = 13;
            // 
            // lblUserTotal
            // 
            this.lblUserTotal.AutoSize = true;
            this.lblUserTotal.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTotal.Location = new System.Drawing.Point(18, 450);
            this.lblUserTotal.Name = "lblUserTotal";
            this.lblUserTotal.Size = new System.Drawing.Size(123, 31);
            this.lblUserTotal.TabIndex = 14;
            this.lblUserTotal.Text = "Your total:";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.Location = new System.Drawing.Point(440, 450);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(147, 31);
            this.lblDealerTotal.TabIndex = 15;
            this.lblDealerTotal.Text = "Dealer Total:";
            // 
            // frmBetter21LeoK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.lblUserTotal);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.picDealerCard3);
            this.Controls.Add(this.picDealerCard2);
            this.Controls.Add(this.picDealerCard1);
            this.Controls.Add(this.picUserCard3);
            this.Controls.Add(this.picUserCard2);
            this.Controls.Add(this.picUserCard1);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblDealerCards);
            this.Controls.Add(this.lblYourCards);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmBetter21LeoK";
            this.Text = "Better 21 by Leo Kay";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniOptions;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniClearWins;
        private System.Windows.Forms.Label lblYourCards;
        private System.Windows.Forms.Label lblDealerCards;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.PictureBox picUserCard1;
        private System.Windows.Forms.PictureBox picUserCard2;
        private System.Windows.Forms.PictureBox picUserCard3;
        private System.Windows.Forms.PictureBox picDealerCard1;
        private System.Windows.Forms.PictureBox picDealerCard2;
        private System.Windows.Forms.PictureBox picDealerCard3;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblUserTotal;
        private System.Windows.Forms.Label lblDealerTotal;
    }
}

