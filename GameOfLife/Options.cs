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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            gridColor.BackColor = Settings.Default.Grid_C;
            x10button.BackColor = Settings.Default.Grid_10_C;
            liveButton.BackColor = Settings.Default.CellColor;
            backgroundButton.BackColor = Settings.Default.PanelColor;
            secondsUD.Value = Settings.Default.timerinterval;
            xAxisUD.Value = Settings.Default.xAmount;
            yAxis.Value = Settings.Default.yAmount;
        }

        private void gridColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            gridColor.BackColor = Settings.Default.Grid_C;

            dlg.Color = gridColor.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                gridColor.BackColor = dlg.Color;
                Settings.Default.Grid_C = gridColor.BackColor;
            }
        }

        private void x10button_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            x10button.BackColor = Settings.Default.Grid_10_C;

            dlg.Color = x10button.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                x10button.BackColor = dlg.Color;
                Settings.Default.Grid_10_C = x10button.BackColor;
            }
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();



            dlg.Color = backgroundButton.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                backgroundButton.BackColor = dlg.Color;
            }
        }

        private void liveButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = liveButton.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                liveButton.BackColor = dlg.Color;
            }
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Settings.Default.Grid_10_C = 
            // Settings.Default.Grid_C = 
            // Settings.Default.PanelColor = 
            // Settings.Default.CellColor = 
           // Settings.Default.timerinterval = (int)secondsUD.Value;
           // Settings.Default.xAmount = (int)xAxisUD.Value;
           // Settings.Default.yAmount = (int)yAxis.Value;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Settings.Default.timerinterval = (int)secondsUD.Value;
            Settings.Default.xAmount = (int)xAxisUD.Value;
            Settings.Default.yAmount = (int)yAxis.Value;
        }

        private void secondsUD_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.timerinterval = (int)secondsUD.Value;
        }

        private void xAxisUD_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.xAmount = (int)xAxisUD.Value;
        }

        private void yAxis_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.yAmount = (int)yAxis.Value;
        }
    }
}
