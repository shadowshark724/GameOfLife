using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLife.Properties;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        int generations, cellcount, xcnt, ycnt, timerint;
        Timer timer = new Timer();
        bool[,] cellarr;
        bool[,] updatearr;
        int neighbors;

        Color rectcolor1 = new Color();
        Color linex10 = new Color();
        Color cellclr = new Color();

        public Form1()
        {
            InitializeComponent();
            //timer.Interval = Settings.Default.timerinterval;
            timer.Tick += Timer_Tick;
            //Settings.Default.xAmount = 30;
            //Settings.Default.yAmount = 30;
            cellarr = new bool[Settings.Default.xAmount , Settings.Default.yAmount];
            updatearr = new bool[Settings.Default.xAmount, Settings.Default.yAmount];
            generations = 0;
            genLabelstatus.Text = "Generations: " + generations.ToString();
            cellcount = 0;
            //rectcolor1 = Settings.Default.Grid_C;
            //linex10 = Settings.Default.Grid_10_C;


        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            graphicsPanel1.BackColor = Settings.Default.PanelColor;
            xcnt = Settings.Default.xAmount;
            ycnt = Settings.Default.yAmount;
            timerint = Settings.Default.timerinterval;
            timer.Interval = Settings.Default.timerinterval;

            rectcolor1 = Settings.Default.Grid_C;
            linex10 = Settings.Default.Grid_10_C;
            cellclr = Settings.Default.CellColor;

            float width = ((float)graphicsPanel1.ClientSize.Width / (float)cellarr.GetLength(0));
            float height = ((float)graphicsPanel1.ClientSize.Height / (float)cellarr.GetLength(1));

            Pen pen1 = new Pen(rectcolor1, .01f);
            Pen pen2 = new Pen(linex10, 2.0f);

            
            updatearr = new bool[xcnt, ycnt];

            cellcount = 0;

            for (int y = 0; y < cellarr.GetLength(1); y++)
            {
                for (int x = 0; x < cellarr.GetLength(0); x++)
                {

                    SolidBrush cellcolor = new SolidBrush(cellclr);

                    neighbors = 0;
                    RectangleF rect = RectangleF.Empty;
                    rect.X = x * width;
                    rect.Y = y * height;
                    rect.Width = width;
                    rect.Height = height;
                                      

                    if (cellarr[x, y])
                    {
                        cellcount++;
                        e.Graphics.FillRectangle(cellcolor, rect.X, rect.Y, rect.Width, rect.Height);

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

                    if (x % 10 == 0)
                    {
                        e.Graphics.DrawLine(pen2, rect.Width * x, 0.0f, rect.Width * x, graphicsPanel1.Height);
                    }
                    if (y % 10 == 0)
                    {
                        e.Graphics.DrawLine(pen2, 0.0f, rect.Height * y, graphicsPanel1.Width, rect.Height * y);
                    }
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

                if (clickX >= xcnt)
                    clickX -= 1;
                if (clickY >= ycnt)
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
                    if (x > 0 && y < ycnt - 1 && cellarr[x - 1, y + 1])
                    { neighbors += 1; }
                    if (y > 0 && cellarr[x, y - 1])
                    { neighbors += 1; }
                    if (y < ycnt - 1 && cellarr[x, y + 1])
                    { neighbors += 1; }
                    if (x < xcnt - 1 && y > 0 && cellarr[x + 1, y - 1])
                    { neighbors += 1; }
                    if (x < xcnt - 1 && cellarr[x + 1, y])
                    { neighbors += 1; }
                    if (x < xcnt - 1 && y < ycnt - 1 && cellarr[x + 1, y + 1])
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
            cellLabel.Text = "Cell's Alive: " + cellcount.ToString();
            graphicsPanel1.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            cellarr = new bool[Settings.Default.xAmount, Settings.Default.yAmount];
            generations = 0;
            genLabelstatus.Text = "Generations: " + generations.ToString();            
            graphicsPanel1.Invalidate();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            linex10 = Settings.Default.Grid_10_C;
            rectcolor1 = Settings.Default.Grid_C;
            graphicsPanel1.BackColor = Settings.Default.PanelColor;
            cellclr = Settings.Default.CellColor;
            timerint = Settings.Default.timerinterval;
            xcnt = Settings.Default.xAmount;
            ycnt = Settings.Default.yAmount;

            cellarr = new bool[xcnt, ycnt];

            graphicsPanel1.Invalidate();

            //Settings.Default.Grid_10_C = linex10;
            //Settings.Default.Grid_C = rectcolor1;
            //Settings.Default.PanelColor = graphicsPanel1.BackColor;
            //Settings.Default.CellColor = cellclr;
            //Settings.Default.timerinterval = timerint;
            //Settings.Default.xAmount = xcnt;
            //Settings.Default.yAmount = ycnt;
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            linex10 = Settings.Default.Grid_10_C;
            rectcolor1 = Settings.Default.Grid_C;
            graphicsPanel1.BackColor = Settings.Default.PanelColor;
            cellclr = Settings.Default.CellColor;
            timerint = Settings.Default.timerinterval;
            xcnt = Settings.Default.xAmount;
            ycnt = Settings.Default.yAmount;

            cellarr = new bool[xcnt, ycnt];

            graphicsPanel1.Invalidate();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options ops = new Options();

            

            if (DialogResult.OK == ops.ShowDialog())
            {
                graphicsPanel1.BackColor = ops.BackColor;
                linex10 = Settings.Default.Grid_10_C;
                rectcolor1 = Settings.Default.Grid_C;
                graphicsPanel1.BackColor = Settings.Default.PanelColor;
                cellclr = Settings.Default.CellColor;
                timerint = Settings.Default.timerinterval;
                xcnt = Settings.Default.xAmount;
                ycnt = Settings.Default.yAmount;


                cellarr = new bool[xcnt, ycnt];
            }
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
                        if (x > 0 && y < ycnt -1 && cellarr[x - 1, y + 1])
                        { neighbors += 1; }
                        if ( y > 0 && cellarr[x, y - 1])
                        { neighbors += 1; }
                        if ( y < ycnt -1 && cellarr[x, y + 1])
                        { neighbors += 1; }
                        if (x < xcnt - 1 && y > 0 && cellarr[x + 1, y - 1])
                        { neighbors += 1; }
                        if (x < xcnt - 1 && cellarr[x + 1, y])
                        { neighbors += 1; }
                        if ( x < xcnt - 1 && y < ycnt -1 && cellarr[x + 1, y + 1])
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
            cellLabel.Text = "Cell's Alive: " + cellcount.ToString();
            graphicsPanel1.Invalidate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Grid_10_C = linex10;
            Settings.Default.Grid_C = rectcolor1;
            Settings.Default.PanelColor = graphicsPanel1.BackColor;
            Settings.Default.CellColor = cellclr;
            Settings.Default.timerinterval = timerint;
            Settings.Default.xAmount = xcnt;
            Settings.Default.yAmount = ycnt;
            Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
