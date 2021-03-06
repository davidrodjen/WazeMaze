﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace WazeMaze
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            arrow.Text = "P";
            arrow.Location = new Point(30, 40);

            this.KeyDown += new KeyEventHandler(MainForm_KeyInput);
        }



        public void MainForm_KeyInput(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                arrow.Location = new Point(arrow.Location.X - 4, arrow.Location.Y);
            }

            if (e.KeyData == Keys.Right)
            {
                arrow.Location = new Point(arrow.Location.X + 4, arrow.Location.Y);
            }

            if (e.KeyData == Keys.Up)
            {
                arrow.Location = new Point(arrow.Location.X, arrow.Location.Y - 4);
            }

            if (e.KeyData == Keys.Down)
            {
                arrow.Location = new Point(arrow.Location.X, arrow.Location.Y + 4);
            }

            //
            if (topBorder.Bounds.IntersectsWith(arrow.Bounds) || bottomBorder.Bounds.IntersectsWith(arrow.Bounds)
             || leftBorder.Bounds.IntersectsWith(arrow.Bounds) || rightBorder.Bounds.IntersectsWith(arrow.Bounds))
            {
                GameOver();
            }

            if (a1.Bounds.IntersectsWith(arrow.Bounds) || a2.Bounds.IntersectsWith(arrow.Bounds)
               || a3.Bounds.IntersectsWith(arrow.Bounds) || a4.Bounds.IntersectsWith(arrow.Bounds)
               || a5.Bounds.IntersectsWith(arrow.Bounds) || a6.Bounds.IntersectsWith(arrow.Bounds)
               || a7.Bounds.IntersectsWith(arrow.Bounds) || a8.Bounds.IntersectsWith(arrow.Bounds)
               || a9.Bounds.IntersectsWith(arrow.Bounds) || a10.Bounds.IntersectsWith(arrow.Bounds)
               || a11.Bounds.IntersectsWith(arrow.Bounds) || a12.Bounds.IntersectsWith(arrow.Bounds)
               || a13.Bounds.IntersectsWith(arrow.Bounds) || a14.Bounds.IntersectsWith(arrow.Bounds))

            {
                GameOver();
            }

            if (b1.Bounds.IntersectsWith(arrow.Bounds) || b2.Bounds.IntersectsWith(arrow.Bounds)
               || b3.Bounds.IntersectsWith(arrow.Bounds) || b4.Bounds.IntersectsWith(arrow.Bounds)
               || b5.Bounds.IntersectsWith(arrow.Bounds) || b6.Bounds.IntersectsWith(arrow.Bounds)
               || b7.Bounds.IntersectsWith(arrow.Bounds) || b8.Bounds.IntersectsWith(arrow.Bounds)
               || b9.Bounds.IntersectsWith(arrow.Bounds) || b10.Bounds.IntersectsWith(arrow.Bounds)
               || b11.Bounds.IntersectsWith(arrow.Bounds) || b12.Bounds.IntersectsWith(arrow.Bounds)
               || b13.Bounds.IntersectsWith(arrow.Bounds) || b14.Bounds.IntersectsWith(arrow.Bounds)
               || b15.Bounds.IntersectsWith(arrow.Bounds) || b16.Bounds.IntersectsWith(arrow.Bounds)
               || b17.Bounds.IntersectsWith(arrow.Bounds) || b18.Bounds.IntersectsWith(arrow.Bounds)
               || b19.Bounds.IntersectsWith(arrow.Bounds))

            {
                GameOver();
            }

            if (exit.Bounds.IntersectsWith(arrow.Bounds))
            {
                NextLevel();
            }

        }

        private void GameOver()
        {
            MessageBox.Show("You failed, back to the start");

            arrow.Location = new Point(48, 43);
        }

        private void NextLevel()
        {
            MessageBox.Show("Congratulations! You have passed");
        }

        //private void PlayBtn_Click(object sender, EventArgs e)
        //{
        //    SoundPlayer player = new SoundPlayer();

        //    player.SoundLocation = @"D:\SideProjects\MazeWaze\WazeMaze\WazeMaze\WazeMaze\ParadiseLights.wav";
        //    player.Play();
        //}

        //private void PauseBtn_Click(object sender, EventArgs e)
        //{
        //    SoundPlayer player = new SoundPlayer();

        //    player.SoundLocation = @"D:\SideProjects\MazeWaze\WazeMaze\WazeMaze\WazeMaze\ParadiseLights.wav";

        //    player.Stop();
            
        //}

        //private void exitBtn_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}


        private void PlayBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();

            player.SoundLocation = @"D:\SideProjects\MazeWaze\WazeMaze\WazeMaze\WazeMaze\ParadiseLights.wav";
            player.Play();

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();

            player.SoundLocation = @"D:\SideProjects\MazeWaze\WazeMaze\WazeMaze\WazeMaze\ParadiseLights.wav";
            player.Stop();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }






        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //player = "D:\\SideProjects\\MazeWaze\\WazeMaze\\WazeMaze\\WazeMaze\\ParadiseLights.mp3";
        //player.Play();



    }
}
