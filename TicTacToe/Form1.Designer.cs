namespace TicTacToe
{
    partial class Form1
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
            this.bottomRightLbl = new System.Windows.Forms.Label();
            this.bottonMiddleLbl = new System.Windows.Forms.Label();
            this.bottomLeftLbl = new System.Windows.Forms.Label();
            this.middleRightLbl = new System.Windows.Forms.Label();
            this.middleMiddleLbl = new System.Windows.Forms.Label();
            this.middleLeftLbl = new System.Windows.Forms.Label();
            this.topRightLbl = new System.Windows.Forms.Label();
            this.topMiddleLbl = new System.Windows.Forms.Label();
            this.topLeftLbl = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.Label();
            this.gameStatisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.numOfCatsLbl = new System.Windows.Forms.Label();
            this.numOfP2WinsLbl = new System.Windows.Forms.Label();
            this.numOfP1WinsLbl = new System.Windows.Forms.Label();
            this.catsLbl = new System.Windows.Forms.Label();
            this.player2WinsLbl = new System.Windows.Forms.Label();
            this.player1WLbl = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.gameStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.gameStatusRTB = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gameStatisticsGroupBox.SuspendLayout();
            this.gameStatusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomRightLbl
            // 
            this.bottomRightLbl.BackColor = System.Drawing.Color.Gray;
            this.bottomRightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.bottomRightLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bottomRightLbl.Location = new System.Drawing.Point(267, 278);
            this.bottomRightLbl.Name = "bottomRightLbl";
            this.bottomRightLbl.Size = new System.Drawing.Size(114, 115);
            this.bottomRightLbl.TabIndex = 20;
            this.bottomRightLbl.Tag = "22";
            this.bottomRightLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // bottonMiddleLbl
            // 
            this.bottonMiddleLbl.BackColor = System.Drawing.Color.Gray;
            this.bottonMiddleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.bottonMiddleLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bottonMiddleLbl.Location = new System.Drawing.Point(147, 278);
            this.bottonMiddleLbl.Name = "bottonMiddleLbl";
            this.bottonMiddleLbl.Size = new System.Drawing.Size(112, 115);
            this.bottonMiddleLbl.TabIndex = 19;
            this.bottonMiddleLbl.Tag = "21";
            this.bottonMiddleLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // bottomLeftLbl
            // 
            this.bottomLeftLbl.BackColor = System.Drawing.Color.Gray;
            this.bottomLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.bottomLeftLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bottomLeftLbl.Location = new System.Drawing.Point(30, 278);
            this.bottomLeftLbl.Name = "bottomLeftLbl";
            this.bottomLeftLbl.Size = new System.Drawing.Size(108, 115);
            this.bottomLeftLbl.TabIndex = 18;
            this.bottomLeftLbl.Tag = "20";
            this.bottomLeftLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // middleRightLbl
            // 
            this.middleRightLbl.BackColor = System.Drawing.Color.Gray;
            this.middleRightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.middleRightLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.middleRightLbl.Location = new System.Drawing.Point(267, 153);
            this.middleRightLbl.Name = "middleRightLbl";
            this.middleRightLbl.Size = new System.Drawing.Size(114, 115);
            this.middleRightLbl.TabIndex = 17;
            this.middleRightLbl.Tag = "12";
            this.middleRightLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // middleMiddleLbl
            // 
            this.middleMiddleLbl.BackColor = System.Drawing.Color.Gray;
            this.middleMiddleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.middleMiddleLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.middleMiddleLbl.Location = new System.Drawing.Point(146, 153);
            this.middleMiddleLbl.Name = "middleMiddleLbl";
            this.middleMiddleLbl.Size = new System.Drawing.Size(113, 115);
            this.middleMiddleLbl.TabIndex = 16;
            this.middleMiddleLbl.Tag = "11";
            this.middleMiddleLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // middleLeftLbl
            // 
            this.middleLeftLbl.BackColor = System.Drawing.Color.Gray;
            this.middleLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.middleLeftLbl.ForeColor = System.Drawing.Color.Black;
            this.middleLeftLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.middleLeftLbl.Location = new System.Drawing.Point(30, 153);
            this.middleLeftLbl.Name = "middleLeftLbl";
            this.middleLeftLbl.Size = new System.Drawing.Size(108, 115);
            this.middleLeftLbl.TabIndex = 15;
            this.middleLeftLbl.Tag = "10";
            this.middleLeftLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // topRightLbl
            // 
            this.topRightLbl.BackColor = System.Drawing.Color.Gray;
            this.topRightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.topRightLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.topRightLbl.Location = new System.Drawing.Point(267, 30);
            this.topRightLbl.Name = "topRightLbl";
            this.topRightLbl.Size = new System.Drawing.Size(114, 113);
            this.topRightLbl.TabIndex = 14;
            this.topRightLbl.Tag = "02";
            this.topRightLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // topMiddleLbl
            // 
            this.topMiddleLbl.BackColor = System.Drawing.Color.Gray;
            this.topMiddleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.topMiddleLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.topMiddleLbl.Location = new System.Drawing.Point(146, 30);
            this.topMiddleLbl.Name = "topMiddleLbl";
            this.topMiddleLbl.Size = new System.Drawing.Size(113, 113);
            this.topMiddleLbl.TabIndex = 13;
            this.topMiddleLbl.Tag = "01";
            this.topMiddleLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // topLeftLbl
            // 
            this.topLeftLbl.BackColor = System.Drawing.Color.Gray;
            this.topLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.topLeftLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.topLeftLbl.Location = new System.Drawing.Point(30, 30);
            this.topLeftLbl.Name = "topLeftLbl";
            this.topLeftLbl.Size = new System.Drawing.Size(108, 113);
            this.topLeftLbl.TabIndex = 12;
            this.topLeftLbl.Tag = "00";
            this.topLeftLbl.Click += new System.EventHandler(this.Space_Click);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Background.ForeColor = System.Drawing.Color.Gray;
            this.Background.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Background.Location = new System.Drawing.Point(30, 30);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(351, 363);
            this.Background.TabIndex = 11;
            // 
            // gameStatisticsGroupBox
            // 
            this.gameStatisticsGroupBox.BackColor = System.Drawing.Color.White;
            this.gameStatisticsGroupBox.Controls.Add(this.numOfCatsLbl);
            this.gameStatisticsGroupBox.Controls.Add(this.numOfP2WinsLbl);
            this.gameStatisticsGroupBox.Controls.Add(this.numOfP1WinsLbl);
            this.gameStatisticsGroupBox.Controls.Add(this.catsLbl);
            this.gameStatisticsGroupBox.Controls.Add(this.player2WinsLbl);
            this.gameStatisticsGroupBox.Controls.Add(this.player1WLbl);
            this.gameStatisticsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gameStatisticsGroupBox.Location = new System.Drawing.Point(460, 147);
            this.gameStatisticsGroupBox.Name = "gameStatisticsGroupBox";
            this.gameStatisticsGroupBox.Size = new System.Drawing.Size(274, 144);
            this.gameStatisticsGroupBox.TabIndex = 22;
            this.gameStatisticsGroupBox.TabStop = false;
            this.gameStatisticsGroupBox.Text = "Game Statistics";
            // 
            // numOfCatsLbl
            // 
            this.numOfCatsLbl.AutoSize = true;
            this.numOfCatsLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numOfCatsLbl.Location = new System.Drawing.Point(180, 100);
            this.numOfCatsLbl.Name = "numOfCatsLbl";
            this.numOfCatsLbl.Size = new System.Drawing.Size(16, 18);
            this.numOfCatsLbl.TabIndex = 17;
            this.numOfCatsLbl.Text = "0";
            // 
            // numOfP2WinsLbl
            // 
            this.numOfP2WinsLbl.AutoSize = true;
            this.numOfP2WinsLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numOfP2WinsLbl.Location = new System.Drawing.Point(180, 69);
            this.numOfP2WinsLbl.Name = "numOfP2WinsLbl";
            this.numOfP2WinsLbl.Size = new System.Drawing.Size(16, 18);
            this.numOfP2WinsLbl.TabIndex = 16;
            this.numOfP2WinsLbl.Text = "0";
            // 
            // numOfP1WinsLbl
            // 
            this.numOfP1WinsLbl.AutoSize = true;
            this.numOfP1WinsLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numOfP1WinsLbl.Location = new System.Drawing.Point(180, 38);
            this.numOfP1WinsLbl.Name = "numOfP1WinsLbl";
            this.numOfP1WinsLbl.Size = new System.Drawing.Size(16, 18);
            this.numOfP1WinsLbl.TabIndex = 15;
            this.numOfP1WinsLbl.Text = "0";
            // 
            // catsLbl
            // 
            this.catsLbl.AutoSize = true;
            this.catsLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.catsLbl.Location = new System.Drawing.Point(97, 100);
            this.catsLbl.Name = "catsLbl";
            this.catsLbl.Size = new System.Drawing.Size(43, 18);
            this.catsLbl.TabIndex = 2;
            this.catsLbl.Text = "Cats:";
            // 
            // player2WinsLbl
            // 
            this.player2WinsLbl.AutoSize = true;
            this.player2WinsLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.player2WinsLbl.Location = new System.Drawing.Point(37, 69);
            this.player2WinsLbl.Name = "player2WinsLbl";
            this.player2WinsLbl.Size = new System.Drawing.Size(103, 18);
            this.player2WinsLbl.TabIndex = 1;
            this.player2WinsLbl.Text = "Player 2 Wins:";
            // 
            // player1WLbl
            // 
            this.player1WLbl.AutoSize = true;
            this.player1WLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.player1WLbl.Location = new System.Drawing.Point(37, 38);
            this.player1WLbl.Name = "player1WLbl";
            this.player1WLbl.Size = new System.Drawing.Size(111, 18);
            this.player1WLbl.TabIndex = 0;
            this.player1WLbl.Text = "Player 1 Wins:  ";
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.White;
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.StartGameButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartGameButton.Location = new System.Drawing.Point(525, 56);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(131, 44);
            this.StartGameButton.TabIndex = 21;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // gameStatusGroupBox
            // 
            this.gameStatusGroupBox.Controls.Add(this.gameStatusRTB);
            this.gameStatusGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gameStatusGroupBox.Location = new System.Drawing.Point(49, 438);
            this.gameStatusGroupBox.Name = "gameStatusGroupBox";
            this.gameStatusGroupBox.Size = new System.Drawing.Size(360, 109);
            this.gameStatusGroupBox.TabIndex = 23;
            this.gameStatusGroupBox.TabStop = false;
            this.gameStatusGroupBox.Text = "Game Status";
            // 
            // gameStatusRTB
            // 
            this.gameStatusRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameStatusRTB.Enabled = false;
            this.gameStatusRTB.Location = new System.Drawing.Point(14, 24);
            this.gameStatusRTB.Name = "gameStatusRTB";
            this.gameStatusRTB.Size = new System.Drawing.Size(332, 69);
            this.gameStatusRTB.TabIndex = 15;
            this.gameStatusRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.gameStatusGroupBox);
            this.Controls.Add(this.gameStatisticsGroupBox);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.bottomRightLbl);
            this.Controls.Add(this.bottonMiddleLbl);
            this.Controls.Add(this.bottomLeftLbl);
            this.Controls.Add(this.middleRightLbl);
            this.Controls.Add(this.middleMiddleLbl);
            this.Controls.Add(this.middleLeftLbl);
            this.Controls.Add(this.topRightLbl);
            this.Controls.Add(this.topMiddleLbl);
            this.Controls.Add(this.topLeftLbl);
            this.Controls.Add(this.Background);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gameStatisticsGroupBox.ResumeLayout(false);
            this.gameStatisticsGroupBox.PerformLayout();
            this.gameStatusGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bottomRightLbl;
        private System.Windows.Forms.Label bottonMiddleLbl;
        private System.Windows.Forms.Label bottomLeftLbl;
        private System.Windows.Forms.Label middleRightLbl;
        private System.Windows.Forms.Label middleMiddleLbl;
        private System.Windows.Forms.Label middleLeftLbl;
        private System.Windows.Forms.Label topRightLbl;
        private System.Windows.Forms.Label topMiddleLbl;
        private System.Windows.Forms.Label topLeftLbl;
        private System.Windows.Forms.Label Background;
        private System.Windows.Forms.GroupBox gameStatisticsGroupBox;
        private System.Windows.Forms.Label numOfCatsLbl;
        private System.Windows.Forms.Label numOfP2WinsLbl;
        private System.Windows.Forms.Label numOfP1WinsLbl;
        private System.Windows.Forms.Label catsLbl;
        private System.Windows.Forms.Label player2WinsLbl;
        private System.Windows.Forms.Label player1WLbl;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.GroupBox gameStatusGroupBox;
        private System.Windows.Forms.RichTextBox gameStatusRTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

