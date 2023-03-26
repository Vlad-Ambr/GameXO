using System.Drawing;
using System;
using System.Windows.Forms;

namespace GameXO
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Tic-Tac-Toe";
            this.ShowIcon = false;

            this.MaximumSize = new Size(750, 450);
            this.Width = 750;
            this.Height = 450;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(189, 149, 121);
            this.Location = new Point(0, 0);



            //
            //  Button One
            //
            One = new Button();
            One.Width = 100;
            One.Height = 100;
            One.BackColor = Color.FromArgb(255, 255, 255);
            One.Location = new Point(60, 60);
            One.Font = new Font("Comic Sans MS", 25);
            
            this.Controls.Add(One);



            //
            //  Button Two
            //
            Two = new Button();
            Two.Width = 100;
            Two.Height = 100;
            Two.BackColor = Color.FromArgb(255, 255, 255);
            Two.Location = new Point(160, 60);
            Two.Font = new Font("Comic Sans MS", 25);
            
            this.Controls.Add(Two);



            //
            //  Button Three
            //
            Three = new Button();
            Three.Width = 100;
            Three.Height = 100;
            Three.BackColor = Color.FromArgb(255, 255, 255);
            Three.Location = new Point(260, 60);
            Three.Font = new Font("Comic Sans MS", 25);
            
            this.Controls.Add(Three);



            //
            //  Button Four
            //
            Four = new Button();
            Four.Width = 100;
            Four.Height = 100;
            Four.BackColor = Color.FromArgb(255, 255, 255);
            Four.Location = new Point(60, 160);
            Four.Font = new Font("Comic Sans MS", 25);
           
            this.Controls.Add(Four);



            //
            //  Button Five
            //
            Five = new Button();
            Five.Width = 100;
            Five.Height = 100;
            Five.BackColor = Color.FromArgb(255, 255, 255);
            Five.Location = new Point(160, 160);
            Five.Font = new Font("Comic Sans MS", 25);
            
            this.Controls.Add(Five);



            //
            //  Button Six
            //
            Six = new Button();
            Six.Width = 100;
            Six.Height = 100;
            Six.BackColor = Color.FromArgb(255, 255, 255);
            Six.Location = new Point(260, 160);
            Six.Font = new Font("Comic Sans MS", 25);
            
            this.Controls.Add(Six);



            //
            //  Button Seven
            //
            Seven = new Button();
            Seven.Width = 100;
            Seven.Height = 100;
            Seven.BackColor = Color.FromArgb(255, 255, 255);
            Seven.Location = new Point(60, 260);
            Seven.Font = new Font("Comic Sans MS", 25);
            
            this.Controls.Add(Seven);



            //
            //  Button Eight
            //
            Eight = new Button();
            Eight.Width = 100;
            Eight.Height = 100;
            Eight.BackColor = Color.FromArgb(255, 255, 255);
            Eight.Location = new Point(160, 260);
            Eight.Font = new Font("Comic Sans MS", 25);
           
            this.Controls.Add(Eight);



            //
            //  Button Nine
            //
            Nine = new Button();
            Nine.Width = 100;
            Nine.Height = 100;
            Nine.BackColor = Color.FromArgb(255, 255, 255);
            Nine.Location = new Point(260, 260);
            Nine.Font = new Font("Comic Sans MS", 25);
            
            this.Controls.Add(Nine);



            //
            // Label turn players
            //
            PlayerTurn = new Label();
            PlayerTurn.Width = 330;
            PlayerTurn.Height = 50;
            PlayerTurn.Text = "X turn";
            PlayerTurn.BackColor = Color.FromArgb(189, 149, 121);
            PlayerTurn.BorderStyle = BorderStyle.None;
            PlayerTurn.Font = new Font("Comic Sans MS", 30);
            PlayerTurn.Location = new Point(420, 180);
            this.Controls.Add(PlayerTurn);
        }
        Button One;
        Button Two;
        Button Three;
        Button Four;
        Button Five;
        Button Six;
        Button Seven;
        Button Eight;
        Button Nine;
        Label PlayerTurn;
        #endregion
    }
}

