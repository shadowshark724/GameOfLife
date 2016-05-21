namespace GameOfLife
{
    partial class Options
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yAxis = new System.Windows.Forms.NumericUpDown();
            this.xAxisUD = new System.Windows.Forms.NumericUpDown();
            this.secondsUD = new System.Windows.Forms.NumericUpDown();
            this.viewTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.liveButton = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.x10button = new System.Windows.Forms.Button();
            this.gridColor = new System.Windows.Forms.Button();
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wrapRadio = new System.Windows.Forms.RadioButton();
            this.finiteRadio = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.generalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAxisUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUD)).BeginInit();
            this.viewTab.SuspendLayout();
            this.advancedTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTab);
            this.tabControl1.Controls.Add(this.viewTab);
            this.tabControl1.Controls.Add(this.advancedTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.label3);
            this.generalTab.Controls.Add(this.label2);
            this.generalTab.Controls.Add(this.label1);
            this.generalTab.Controls.Add(this.yAxis);
            this.generalTab.Controls.Add(this.xAxisUD);
            this.generalTab.Controls.Add(this.secondsUD);
            this.generalTab.Location = new System.Drawing.Point(4, 25);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(596, 338);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount Y Axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount X Axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer";
            // 
            // yAxis
            // 
            this.yAxis.Location = new System.Drawing.Point(182, 150);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(120, 22);
            this.yAxis.TabIndex = 2;
            // 
            // xAxisUD
            // 
            this.xAxisUD.Location = new System.Drawing.Point(182, 78);
            this.xAxisUD.Name = "xAxisUD";
            this.xAxisUD.Size = new System.Drawing.Size(120, 22);
            this.xAxisUD.TabIndex = 1;
            // 
            // secondsUD
            // 
            this.secondsUD.Location = new System.Drawing.Point(182, 16);
            this.secondsUD.Name = "secondsUD";
            this.secondsUD.Size = new System.Drawing.Size(120, 22);
            this.secondsUD.TabIndex = 0;
            // 
            // viewTab
            // 
            this.viewTab.Controls.Add(this.label7);
            this.viewTab.Controls.Add(this.label6);
            this.viewTab.Controls.Add(this.label5);
            this.viewTab.Controls.Add(this.label4);
            this.viewTab.Controls.Add(this.resetButton);
            this.viewTab.Controls.Add(this.liveButton);
            this.viewTab.Controls.Add(this.backgroundButton);
            this.viewTab.Controls.Add(this.x10button);
            this.viewTab.Controls.Add(this.gridColor);
            this.viewTab.Location = new System.Drawing.Point(4, 25);
            this.viewTab.Name = "viewTab";
            this.viewTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewTab.Size = new System.Drawing.Size(596, 338);
            this.viewTab.TabIndex = 1;
            this.viewTab.Text = "View";
            this.viewTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Live Cell Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Background Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grid x10 Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grid Color";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(23, 289);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // liveButton
            // 
            this.liveButton.Location = new System.Drawing.Point(23, 171);
            this.liveButton.Name = "liveButton";
            this.liveButton.Size = new System.Drawing.Size(75, 23);
            this.liveButton.TabIndex = 3;
            this.liveButton.UseVisualStyleBackColor = true;
            this.liveButton.Click += new System.EventHandler(this.liveButton_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.Location = new System.Drawing.Point(23, 123);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(75, 23);
            this.backgroundButton.TabIndex = 2;
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // x10button
            // 
            this.x10button.Location = new System.Drawing.Point(23, 73);
            this.x10button.Name = "x10button";
            this.x10button.Size = new System.Drawing.Size(75, 23);
            this.x10button.TabIndex = 1;
            this.x10button.UseVisualStyleBackColor = true;
            this.x10button.Click += new System.EventHandler(this.x10button_Click);
            // 
            // gridColor
            // 
            this.gridColor.Location = new System.Drawing.Point(23, 23);
            this.gridColor.Name = "gridColor";
            this.gridColor.Size = new System.Drawing.Size(75, 23);
            this.gridColor.TabIndex = 0;
            this.gridColor.UseVisualStyleBackColor = true;
            this.gridColor.Click += new System.EventHandler(this.gridColor_Click);
            // 
            // advancedTab
            // 
            this.advancedTab.Controls.Add(this.groupBox1);
            this.advancedTab.Location = new System.Drawing.Point(4, 25);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Padding = new System.Windows.Forms.Padding(3);
            this.advancedTab.Size = new System.Drawing.Size(596, 338);
            this.advancedTab.TabIndex = 2;
            this.advancedTab.Text = "Advanced";
            this.advancedTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wrapRadio);
            this.groupBox1.Controls.Add(this.finiteRadio);
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boundary Type";
            // 
            // wrapRadio
            // 
            this.wrapRadio.AutoSize = true;
            this.wrapRadio.Location = new System.Drawing.Point(34, 59);
            this.wrapRadio.Name = "wrapRadio";
            this.wrapRadio.Size = new System.Drawing.Size(63, 21);
            this.wrapRadio.TabIndex = 1;
            this.wrapRadio.TabStop = true;
            this.wrapRadio.Text = "Wrap";
            this.wrapRadio.UseVisualStyleBackColor = true;
            // 
            // finiteRadio
            // 
            this.finiteRadio.AutoSize = true;
            this.finiteRadio.Location = new System.Drawing.Point(34, 32);
            this.finiteRadio.Name = "finiteRadio";
            this.finiteRadio.Size = new System.Drawing.Size(63, 21);
            this.finiteRadio.TabIndex = 0;
            this.finiteRadio.TabStop = true;
            this.finiteRadio.Text = "Finite";
            this.finiteRadio.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(27, 369);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(141, 369);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 399);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAxisUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUD)).EndInit();
            this.viewTab.ResumeLayout(false);
            this.viewTab.PerformLayout();
            this.advancedTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yAxis;
        private System.Windows.Forms.NumericUpDown xAxisUD;
        private System.Windows.Forms.NumericUpDown secondsUD;
        private System.Windows.Forms.TabPage viewTab;
        private System.Windows.Forms.Button liveButton;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Button x10button;
        private System.Windows.Forms.Button gridColor;
        private System.Windows.Forms.TabPage advancedTab;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton wrapRadio;
        private System.Windows.Forms.RadioButton finiteRadio;
    }
}