namespace SpaceShooterGame_1
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
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(1018, 12);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(111, 50);
            this.btnLoadGame.TabIndex = 1;
            this.btnLoadGame.Text = "Start";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.BackColor = System.Drawing.Color.Black;
            this.pnlGameBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(1000, 500);
            this.pnlGameBoard.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 534);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.pnlGameBoard);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Timer gameTimer;
    }
}

