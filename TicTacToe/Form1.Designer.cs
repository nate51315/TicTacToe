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
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnBotRight = new System.Windows.Forms.Button();
            this.btnBotMid = new System.Windows.Forms.Button();
            this.btnBotLeft = new System.Windows.Forms.Button();
            this.btnMidRight = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnMidLeft = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnTopMid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopLeft.Location = new System.Drawing.Point(3, 3);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(180, 180);
            this.btnTopLeft.TabIndex = 2;
            this.btnTopLeft.UseVisualStyleBackColor = false;
            this.btnTopLeft.Click += new System.EventHandler(this.btnTopLeft_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.btnBotRight);
            this.panelContainer.Controls.Add(this.btnBotMid);
            this.panelContainer.Controls.Add(this.btnBotLeft);
            this.panelContainer.Controls.Add(this.btnMidRight);
            this.panelContainer.Controls.Add(this.btnMid);
            this.panelContainer.Controls.Add(this.btnMidLeft);
            this.panelContainer.Controls.Add(this.btnTopRight);
            this.panelContainer.Controls.Add(this.btnTopMid);
            this.panelContainer.Controls.Add(this.btnTopLeft);
            this.panelContainer.Location = new System.Drawing.Point(12, 12);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(560, 560);
            this.panelContainer.TabIndex = 3;
            // 
            // btnBotRight
            // 
            this.btnBotRight.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBotRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotRight.Location = new System.Drawing.Point(375, 376);
            this.btnBotRight.Name = "btnBotRight";
            this.btnBotRight.Size = new System.Drawing.Size(180, 180);
            this.btnBotRight.TabIndex = 10;
            this.btnBotRight.UseVisualStyleBackColor = false;
            this.btnBotRight.Click += new System.EventHandler(this.btnBotRight_Click);
            // 
            // btnBotMid
            // 
            this.btnBotMid.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBotMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotMid.Location = new System.Drawing.Point(189, 376);
            this.btnBotMid.Name = "btnBotMid";
            this.btnBotMid.Size = new System.Drawing.Size(180, 180);
            this.btnBotMid.TabIndex = 9;
            this.btnBotMid.UseVisualStyleBackColor = false;
            this.btnBotMid.Click += new System.EventHandler(this.btnBotMid_Click);
            // 
            // btnBotLeft
            // 
            this.btnBotLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBotLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotLeft.Location = new System.Drawing.Point(3, 376);
            this.btnBotLeft.Name = "btnBotLeft";
            this.btnBotLeft.Size = new System.Drawing.Size(180, 180);
            this.btnBotLeft.TabIndex = 8;
            this.btnBotLeft.UseVisualStyleBackColor = false;
            this.btnBotLeft.Click += new System.EventHandler(this.btnBotLeft_Click);
            // 
            // btnMidRight
            // 
            this.btnMidRight.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMidRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMidRight.Location = new System.Drawing.Point(376, 190);
            this.btnMidRight.Name = "btnMidRight";
            this.btnMidRight.Size = new System.Drawing.Size(180, 180);
            this.btnMidRight.TabIndex = 7;
            this.btnMidRight.UseVisualStyleBackColor = false;
            this.btnMidRight.Click += new System.EventHandler(this.btnMidRight_Click);
            // 
            // btnMid
            // 
            this.btnMid.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMid.Location = new System.Drawing.Point(190, 190);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(180, 180);
            this.btnMid.TabIndex = 6;
            this.btnMid.UseVisualStyleBackColor = false;
            this.btnMid.Click += new System.EventHandler(this.btnMid_Click);
            // 
            // btnMidLeft
            // 
            this.btnMidLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMidLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMidLeft.Location = new System.Drawing.Point(4, 190);
            this.btnMidLeft.Name = "btnMidLeft";
            this.btnMidLeft.Size = new System.Drawing.Size(180, 180);
            this.btnMidLeft.TabIndex = 5;
            this.btnMidLeft.UseVisualStyleBackColor = false;
            this.btnMidLeft.Click += new System.EventHandler(this.btnMidLeft_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopRight.Location = new System.Drawing.Point(375, 3);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(180, 180);
            this.btnTopRight.TabIndex = 4;
            this.btnTopRight.UseVisualStyleBackColor = false;
            this.btnTopRight.Click += new System.EventHandler(this.btnTopRight_Click);
            // 
            // btnTopMid
            // 
            this.btnTopMid.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTopMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopMid.Location = new System.Drawing.Point(189, 3);
            this.btnTopMid.Name = "btnTopMid";
            this.btnTopMid.Size = new System.Drawing.Size(180, 180);
            this.btnTopMid.TabIndex = 3;
            this.btnTopMid.UseVisualStyleBackColor = false;
            this.btnTopMid.Click += new System.EventHandler(this.btnTopMid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tic Tac Toe";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(620, 165);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(230, 58);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(620, 266);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(230, 58);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player Two";
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Location = new System.Drawing.Point(620, 425);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(230, 22);
            this.txtPlayerOne.TabIndex = 9;
            this.txtPlayerOne.Text = "O";
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Location = new System.Drawing.Point(620, 530);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(230, 22);
            this.txtPlayerTwo.TabIndex = 10;
            this.txtPlayerTwo.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(890, 583);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContainer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnBotRight;
        private System.Windows.Forms.Button btnBotMid;
        private System.Windows.Forms.Button btnBotLeft;
        private System.Windows.Forms.Button btnMidRight;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnMidLeft;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnTopMid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerTwo;
    }
}

