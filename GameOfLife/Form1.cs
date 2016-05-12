using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        int xAmount, yAmount, generations;
        Timer timer = new Timer();
        bool[,] cellarr;
        bool[,] updatearr;
        int neighbors;

        Color rectcolor1 = new Color();
        


        public Form1()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            xAmount = 50;
            yAmount = 50;
            cellarr = new bool[xAmount, yAmount];
            updatearr = new bool[xAmount, yAmount];
            generations = 0;
            genLabelstatus.Text = "Generations: " + generations.ToString();

            rectcolor1 = Color.Gray;
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            float width = ((float)graphicsPanel1.ClientSize.Width / (float)cellarr.GetLength(0));
            float height = ((float)graphicsPanel1.ClientSize.Height / (float)cellarr.GetLength(1));

            Pen pen1 = new Pen(rectcolor1, .01f);

            updatearr = new bool[xAmount, yAmount];

            for (int y = 0; y < cellarr.GetLength(1); y++)
            {
                for (int x = 0; x < cellarr.GetLength(0); x++)
                {
                    neighbors = 0;
                    RectangleF rect = RectangleF.Empty;
                    rect.X = x * width;
                    rect.Y = y * height;
                    rect.Width = width;
                    rect.Height = height;

                    if (cellarr[x, y])
                    {
                        e.Graphics.FillRectangle(Brushes.Yellow, rect.X, rect.Y, rect.Width, rect.Height);

                        ////==============================
                        ////   BOUNDRIES CHECK
                        ////==============================
                        //int nxtX = x;
                        //int nxtY = y;

                        //if (x == 0)
                        //{
                        //    nxtX = cellarr.GetLength(0);
                        //}
                        //if (x == cellarr.GetLength(0) - 1)
                        //{
                        //    nxtX = 0;
                        //}
                        //if (y == 0)
                        //{
                        //    nxtY = cellarr.GetLength(1);
                        //}
                        //if (y == cellarr.GetLength(1) - 1)
                        //{
                        //    nxtY = 0;
                        //}
                        ////==============================
                        ////   NEIGHBOR CHECK
                        ////==============================
                        //if (cellarr[nxtX - 1, nxtY - 1])
                        //{ intarr[x, y] += 1; }
                        //else
                        //{ intarr[x, y] -= 1; }
                        //if (cellarr[nxtX - 1, nxtY])
                        //{ intarr[x, y] += 1; }
                        //else
                        //{ intarr[x, y] -= 1; }
                        //if (cellarr[nxtX - 1, nxtY + 1])
                        //{ intarr[x, y] += 1; }
                        //else
                        //{ intarr[x, y] -= 1; }
                        //if (cellarr[nxtX, nxtY - 1])
                        //{ intarr[x, y] += 1; }
                        //else
                        //{ intarr[x, y] -= 1; }
                        //if (cellarr[nxtX, nxtY + 1])
                        //{ intarr[x, y] += 1; }
                        //else
                        //{ intarr[x, y] -= 1; }
                        //if (cellarr[nxtX + 1, nxtY - 1])
                        //{ intarr[x, y] += 1; }
                        //else
                        //{ intarr[x, y] -= 1; }
                        //if (cellarr[nxtX + 1, nxtY])
                        //{ intarr[x, y] += 1; }
                        //else
                        //{ intarr[x, y] -= 1; }
                        //if (cellarr[nxtX + 1, nxtY + 1])
                        //{ intarr[x, y] += 1; }
                        //else
                        //{ intarr[x, y] -= 1; }
                    }
                    e.Graphics.DrawRectangle(pen1, rect.X, rect.Y, rect.Width, rect.Height);
                }
            }
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            float width = ((float)graphicsPanel1.ClientSize.Width / (float)cellarr.GetLength(0));
            float height = ((float)graphicsPanel1.ClientSize.Height / (float)cellarr.GetLength(1));

            if (e.Button == MouseButtons.Left)
            {
                float clickX = (e.X / width);
                float clickY = (e.Y / height);

                if (clickX >= xAmount)
                    clickX -= 1;
                if (clickY >= yAmount)
                    clickY -= 1;

                cellarr[(int)clickX, (int)clickY] = !cellarr[(int)clickX, (int)clickY];

                graphicsPanel1.Invalidate();
             
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < cellarr.GetLength(1); y++)
            {

                for (int x = 0; x < cellarr.GetLength(0); x++)
                {
                    updatearr[x, y] = cellarr[x, y];
                }
            }

            for (int y = 0; y < cellarr.GetLength(1); y++)
            {

                for (int x = 0; x < cellarr.GetLength(0); x++)
                {
                    neighbors = 0;
                    //===================================
                    //    LIVING / DEAD CHECK
                    //===================================                   
                    if (x > 0 && y > 0 && cellarr[x - 1, y - 1] == true)
                    { neighbors += 1; }
                    if (x > 0 && cellarr[x - 1, y])
                    { neighbors += 1; }
                    if (x > 0 && y < yAmount - 1 && cellarr[x - 1, y + 1])
                    { neighbors += 1; }
                    if (y > 0 && cellarr[x, y - 1])
                    { neighbors += 1; }
                    if (y < yAmount - 1 && cellarr[x, y + 1])
                    { neighbors += 1; }
                    if (x < xAmount - 1 && y > 0 && cellarr[x + 1, y - 1])
                    { neighbors += 1; }
                    if (x < xAmount - 1 && cellarr[x + 1, y])
                    { neighbors += 1; }
                    if (x < xAmount - 1 && y < yAmount - 1 && cellarr[x + 1, y + 1])
                    { neighbors += 1; }

                    if (neighbors < 2)
                    { updatearr[x, y] = false; }
                    if (neighbors > 3)
                    { updatearr[x, y] = false; }
                    if (neighbors == 2 || neighbors == 3)
                    { updatearr[x, y] = cellarr[x, y]; }
                    if (neighbors == 3)
                    { updatearr[x, y] = true; }
                    
                }
            }

            for (int y = 0; y < cellarr.GetLength(1); y++)
            {

                for (int x = 0; x < cellarr.GetLength(0); x++)
                {
                    cellarr[x, y] = updatearr[x, y];
                }
            }

            generations++;
            genLabelstatus.Text = "Generations: " + generations.ToString();
            graphicsPanel1.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            cellarr = new bool[xAmount, yAmount];
            generations = 0;
            genLabelstatus.Text = "Generations: " + generations.ToString();            
            graphicsPanel1.Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int y = 0; y < cellarr.GetLength(1); y++)
            {

                for (int x = 0; x < cellarr.GetLength(0); x++)
                {
                    updatearr[x, y] = cellarr[x, y];
                }
            }

            for (int y = 0; y < cellarr.GetLength(1); y++)
            {

                for (int x = 0; x < cellarr.GetLength(0); x++)
                {
                    neighbors = 0;
                    //===================================
                    //    LIVING / DEAD CHECK
                    //===================================
                        if (x > 0 && y > 0 && cellarr[x - 1, y - 1] == true)
                        { neighbors += 1; }
                        if (x > 0 && cellarr[x - 1, y])
                        { neighbors += 1; }
                        if (x > 0 && y < yAmount -1 && cellarr[x - 1, y + 1])
                        { neighbors += 1; }
                        if ( y > 0 && cellarr[x, y - 1])
                        { neighbors += 1; }
                        if ( y < yAmount -1 && cellarr[x, y + 1])
                        { neighbors += 1; }
                        if (x < xAmount -1 && y > 0 && cellarr[x + 1, y - 1])
                        { neighbors += 1; }
                        if (x < xAmount -1 && cellarr[x + 1, y])
                        { neighbors += 1; }
                        if ( x < xAmount- 1 && y < yAmount -1 && cellarr[x + 1, y + 1])
                        { neighbors += 1; }

                        if (neighbors < 2)
                        { updatearr[x, y] = false; }
                        if (neighbors > 3)
                        { updatearr[x, y] = false; }
                        if (neighbors == 2 || neighbors == 3)
                        { updatearr[x,y] = cellarr[x,y]; }
                        if (neighbors == 3)
                        { updatearr[x, y] = true; }
                    
                }
            }

            for (int y = 0; y < cellarr.GetLength(1); y++)
            {

                for (int x = 0; x < cellarr.GetLength(0); x++)
                {
                    cellarr[x, y] = updatearr[x, y];
                }
            }

            generations++;
            genLabelstatus.Text = "Generations: " + generations.ToString();
            graphicsPanel1.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
