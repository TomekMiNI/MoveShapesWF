using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace wfsurprise
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private List<Figure> lista = new List<Figure>();
        public List<Figure> editlista = new List<Figure>();
        public List<Figure> animlista = new List<Figure>();
        private TabControl tc;
        private System.ComponentModel.IContainer components = null;
        private TabPage start;
        private TabPage end;
        private TabPage animation;
        private RadioButton paintline;
        private RadioButton paintcircle;
        private Button pick;
        private Label prostokat;
        private Label colorpreview;
        private TableLayoutPanel tpstart;
        private TableLayoutPanel tpedit;
        public ListView dg;
        private PictureBox panel;
        private PictureBox editpanel;
        private ListView editlist;
        private TableLayoutPanel tpanim;
        private Label speedanim;
        private TrackBar trackanim;
        private Label fpsanim;
        private Label showfps;
        private Button startanim;
        private Button resetanim;
        private PictureBox animpanel;
        private BackgroundWorker bw;
        private double tempo = 1;
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
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.animpanel = new System.Windows.Forms.PictureBox();
            this.speedanim = new System.Windows.Forms.Label();
            this.trackanim = new System.Windows.Forms.TrackBar();
            this.fpsanim = new System.Windows.Forms.Label();
            this.showfps = new System.Windows.Forms.Label();
            this.startanim = new System.Windows.Forms.Button();
            this.resetanim = new System.Windows.Forms.Button();
            this.tpanim = new System.Windows.Forms.TableLayoutPanel();
            this.animation = new System.Windows.Forms.TabPage();
            this.tpedit = new System.Windows.Forms.TableLayoutPanel();
            this.editpanel = new System.Windows.Forms.PictureBox();
            this.editlist = new System.Windows.Forms.ListView();
            this.editname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editcolor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel = new System.Windows.Forms.PictureBox();
            this.dg = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpstart = new System.Windows.Forms.TableLayoutPanel();
            this.prostokat = new System.Windows.Forms.Label();
            this.paintcircle = new System.Windows.Forms.RadioButton();
            this.pick = new System.Windows.Forms.Button();
            this.colorpreview = new System.Windows.Forms.Label();
            this.paintline = new System.Windows.Forms.RadioButton();
            this.tc = new System.Windows.Forms.TabControl();
            this.start = new System.Windows.Forms.TabPage();
            this.end = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animpanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackanim)).BeginInit();
            this.tpanim.SuspendLayout();
            this.animation.SuspendLayout();
            this.tpedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editpanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.tpstart.SuspendLayout();
            this.tc.SuspendLayout();
            this.start.SuspendLayout();
            this.end.SuspendLayout();
            this.SuspendLayout();
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.moveit);
            // 
            // animpanel
            // 
            this.tpanim.SetColumnSpan(this.animpanel, 2);
            this.animpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animpanel.Location = new System.Drawing.Point(3, 39);
            this.animpanel.Name = "animpanel";
            this.tpanim.SetRowSpan(this.animpanel, 3);
            this.animpanel.Size = new System.Drawing.Size(621, 393);
            this.animpanel.TabIndex = 6;
            this.animpanel.TabStop = false;
            this.animpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.animpaint);
            // 
            // speedanim
            // 
            this.speedanim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.speedanim.Location = new System.Drawing.Point(3, 8);
            this.speedanim.Name = "speedanim";
            this.speedanim.Size = new System.Drawing.Size(95, 20);
            this.speedanim.TabIndex = 0;
            this.speedanim.Text = "Animation Speed";
            this.speedanim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackanim
            // 
            this.trackanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackanim.Location = new System.Drawing.Point(104, 3);
            this.trackanim.Maximum = 100;
            this.trackanim.Minimum = 1;
            this.trackanim.Name = "trackanim";
            this.trackanim.Size = new System.Drawing.Size(520, 30);
            this.trackanim.TabIndex = 1;
            this.trackanim.Value = 100;
            // 
            // fpsanim
            // 
            this.fpsanim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsanim.Location = new System.Drawing.Point(637, 10);
            this.fpsanim.Margin = new System.Windows.Forms.Padding(10);
            this.fpsanim.Name = "fpsanim";
            this.fpsanim.Size = new System.Drawing.Size(129, 16);
            this.fpsanim.TabIndex = 2;
            this.fpsanim.Text = "FPS:";
            this.fpsanim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showfps
            // 
            this.showfps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showfps.Location = new System.Drawing.Point(637, 61);
            this.showfps.Margin = new System.Windows.Forms.Padding(10);
            this.showfps.Name = "showfps";
            this.showfps.Size = new System.Drawing.Size(129, 20);
            this.showfps.TabIndex = 3;
            this.showfps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startanim
            // 
            this.startanim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startanim.Location = new System.Drawing.Point(637, 145);
            this.startanim.Margin = new System.Windows.Forms.Padding(10);
            this.startanim.Name = "startanim";
            this.startanim.Size = new System.Drawing.Size(129, 23);
            this.startanim.TabIndex = 4;
            this.startanim.Text = "Start";
            this.startanim.Click += new System.EventHandler(this.startanim_Click);
            // 
            // resetanim
            // 
            this.resetanim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resetanim.Location = new System.Drawing.Point(637, 309);
            this.resetanim.Margin = new System.Windows.Forms.Padding(10);
            this.resetanim.Name = "resetanim";
            this.resetanim.Size = new System.Drawing.Size(129, 23);
            this.resetanim.TabIndex = 5;
            this.resetanim.Text = "Reset";
            this.resetanim.Click += new System.EventHandler(this.resetanim_Click);
            // 
            // tpanim
            // 
            this.tpanim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpanim.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tpanim.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 526F));
            this.tpanim.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tpanim.Controls.Add(this.speedanim, 0, 0);
            this.tpanim.Controls.Add(this.trackanim, 1, 0);
            this.tpanim.Controls.Add(this.fpsanim, 2, 0);
            this.tpanim.Controls.Add(this.startanim, 2, 2);
            this.tpanim.Controls.Add(this.resetanim, 2, 3);
            this.tpanim.Controls.Add(this.animpanel, 0, 1);
            this.tpanim.Controls.Add(this.showfps, 2, 1);
            this.tpanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpanim.Location = new System.Drawing.Point(0, 0);
            this.tpanim.Name = "tpanim";
            this.tpanim.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tpanim.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tpanim.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tpanim.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tpanim.Size = new System.Drawing.Size(776, 435);
            this.tpanim.TabIndex = 0;
            // 
            // animation
            // 
            this.animation.Controls.Add(this.tpanim);
            this.animation.Location = new System.Drawing.Point(4, 22);
            this.animation.Name = "animation";
            this.animation.Size = new System.Drawing.Size(776, 435);
            this.animation.TabIndex = 2;
            this.animation.Text = "Animation";
            // 
            // tpedit
            // 
            this.tpedit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tpedit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpedit.Controls.Add(this.editpanel, 0, 0);
            this.tpedit.Controls.Add(this.editlist, 1, 0);
            this.tpedit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpedit.Location = new System.Drawing.Point(0, 0);
            this.tpedit.Name = "tpedit";
            this.tpedit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.tpedit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.tpedit.Size = new System.Drawing.Size(776, 435);
            this.tpedit.TabIndex = 0;
            // 
            // editpanel
            // 
            this.editpanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editpanel.Location = new System.Drawing.Point(3, 3);
            this.editpanel.Name = "editpanel";
            this.editpanel.Size = new System.Drawing.Size(614, 429);
            this.editpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.editpanel.TabIndex = 0;
            this.editpanel.TabStop = false;
            this.editpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editpaint);
            // 
            // editlist
            // 
            this.editlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.editname,
            this.editcolor});
            this.editlist.Location = new System.Drawing.Point(623, 3);
            this.editlist.Name = "editlist";
            this.editlist.Size = new System.Drawing.Size(150, 429);
            this.editlist.TabIndex = 1;
            this.editlist.UseCompatibleStateImageBehavior = false;
            this.editlist.View = System.Windows.Forms.View.Details;
            this.editlist.Click += new System.EventHandler(this.drawrectangles);
            this.editlist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remove);
            this.editlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.changecolor);
            // 
            // editname
            // 
            this.editname.Text = "Name";
            // 
            // editcolor
            // 
            this.editcolor.Text = "Color";
            this.editcolor.Width = 120;
            // 
            // panel
            // 
            this.tpstart.SetColumnSpan(this.panel, 3);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 43);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(504, 389);
            this.panel.TabIndex = 0;
            this.panel.TabStop = false;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelpaint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.beginpaint);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.durante);
            // 
            // dg
            // 
            this.dg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.color});
            this.tpstart.SetColumnSpan(this.dg, 2);
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(513, 43);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(260, 389);
            this.dg.TabIndex = 0;
            this.dg.UseCompatibleStateImageBehavior = false;
            this.dg.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // color
            // 
            this.color.Text = "Color";
            this.color.Width = 120;
            // 
            // tpstart
            // 
            this.tpstart.BackColor = System.Drawing.SystemColors.Window;
            this.tpstart.ColumnCount = 5;
            this.tpstart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tpstart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tpstart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tpstart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tpstart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tpstart.Controls.Add(this.panel, 0, 1);
            this.tpstart.Controls.Add(this.dg, 3, 1);
            this.tpstart.Controls.Add(this.prostokat, 4, 0);
            this.tpstart.Controls.Add(this.paintcircle, 1, 0);
            this.tpstart.Controls.Add(this.pick, 2, 0);
            this.tpstart.Controls.Add(this.colorpreview, 3, 0);
            this.tpstart.Controls.Add(this.paintline, 0, 0);
            this.tpstart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpstart.Location = new System.Drawing.Point(0, 0);
            this.tpstart.Name = "tpstart";
            this.tpstart.RowCount = 2;
            this.tpstart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpstart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpstart.Size = new System.Drawing.Size(776, 435);
            this.tpstart.TabIndex = 4;
            // 
            // prostokat
            // 
            this.prostokat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prostokat.BackColor = System.Drawing.Color.Black;
            this.prostokat.Location = new System.Drawing.Point(651, 10);
            this.prostokat.Margin = new System.Windows.Forms.Padding(10);
            this.prostokat.Name = "prostokat";
            this.prostokat.Size = new System.Drawing.Size(115, 20);
            this.prostokat.TabIndex = 0;
            // 
            // paintcircle
            // 
            this.paintcircle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintcircle.Location = new System.Drawing.Point(180, 10);
            this.paintcircle.Margin = new System.Windows.Forms.Padding(10);
            this.paintcircle.Name = "paintcircle";
            this.paintcircle.Size = new System.Drawing.Size(150, 20);
            this.paintcircle.TabIndex = 1;
            this.paintcircle.Text = "Draw Circles";
            this.paintcircle.CheckedChanged += new System.EventHandler(this.paintcircle_CheckedChanged);
            // 
            // pick
            // 
            this.pick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pick.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pick.Location = new System.Drawing.Point(355, 10);
            this.pick.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pick.Name = "pick";
            this.pick.Size = new System.Drawing.Size(140, 20);
            this.pick.TabIndex = 2;
            this.pick.Text = "Pick a Color";
            this.pick.UseVisualStyleBackColor = false;
            this.pick.Click += new System.EventHandler(this.pickacolor);
            // 
            // colorpreview
            // 
            this.colorpreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorpreview.Location = new System.Drawing.Point(520, 10);
            this.colorpreview.Margin = new System.Windows.Forms.Padding(10);
            this.colorpreview.Name = "colorpreview";
            this.colorpreview.Size = new System.Drawing.Size(111, 20);
            this.colorpreview.TabIndex = 3;
            this.colorpreview.Text = "Color preview";
            this.colorpreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintline
            // 
            this.paintline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintline.Checked = true;
            this.paintline.Location = new System.Drawing.Point(10, 10);
            this.paintline.Margin = new System.Windows.Forms.Padding(10);
            this.paintline.Name = "paintline";
            this.paintline.Size = new System.Drawing.Size(150, 20);
            this.paintline.TabIndex = 0;
            this.paintline.TabStop = true;
            this.paintline.Text = "Draw Lines";
            this.paintline.CheckedChanged += new System.EventHandler(this.paintline_CheckedChanged);
            // 
            // tc
            // 
            this.tc.Controls.Add(this.start);
            this.tc.Controls.Add(this.end);
            this.tc.Controls.Add(this.animation);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(784, 461);
            this.tc.TabIndex = 0;
            // 
            // start
            // 
            this.start.Controls.Add(this.tpstart);
            this.start.Location = new System.Drawing.Point(4, 22);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(776, 435);
            this.start.TabIndex = 0;
            this.start.Text = "Starting frame";
            // 
            // end
            // 
            this.end.Controls.Add(this.label1);
            this.end.Controls.Add(this.label2);
            this.end.Controls.Add(this.tpedit);
            this.end.Location = new System.Drawing.Point(4, 22);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(776, 435);
            this.end.TabIndex = 1;
            this.end.Text = "Ending Frame";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(7, 9);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1move);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(7, 9);
            this.label2.TabIndex = 3;
            this.label2.Text = " ";
            this.label2.Visible = false;
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2move);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tc);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.animpanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackanim)).EndInit();
            this.tpanim.ResumeLayout(false);
            this.tpanim.PerformLayout();
            this.animation.ResumeLayout(false);
            this.tpedit.ResumeLayout(false);
            this.tpedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editpanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.tpstart.ResumeLayout(false);
            this.tc.ResumeLayout(false);
            this.start.ResumeLayout(false);
            this.end.ResumeLayout(false);
            this.end.PerformLayout();
            this.ResumeLayout(false);

        }

        private void moveit(object sender, DoWorkEventArgs e)
        {
            double[] startXdist = new double[animlista.Count];
            double[] startYdist = new double[animlista.Count];
            double[] endXdist = new double[animlista.Count];
            double[] endYdist = new double[animlista.Count];
            int counter = 0;
            bool[] doneSX = new bool[animlista.Count];
            bool[] doneSY = new bool[animlista.Count];
            bool[] doneEX = new bool[animlista.Count];
            bool[] doneEY = new bool[animlista.Count];
            for (int i=0;i<animlista.Count;i++)
            {
                startXdist[i] = (editlista[i].startx - animlista[i].startx)/tempo;
                startYdist[i] = (editlista[i].starty - animlista[i].starty)/tempo;
                endXdist[i] = (editlista[i].endx - animlista[i].endx) / tempo;
                endYdist[i] = (editlista[i].endy - animlista[i].endy) / tempo;
            }
            while (counter < 4 * animlista.Count)
            {
                if (((sender as BackgroundWorker).CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                for (int i = 0; i < animlista.Count; i++)
                {
                    if (!doneSX[i])
                    {
                        animlista[i].startx += startXdist[i];
                        if (Math.Abs(animlista[i].startx - editlista[i].startx) < 2)
                        {
                            animlista[i].startx = editlista[i].startx;
                            doneSX[i] = true;
                            counter++;
                        }
                    }
                    if (!doneSY[i])
                    { 
                        animlista[i].starty += startYdist[i];
                        if (Math.Abs(animlista[i].starty - editlista[i].starty) < 2)
                        {
                            animlista[i].starty = editlista[i].starty;
                            doneSY[i] = true;
                            counter++;
                        }
                    }
                    if(animlista[i].AmILine)
                    {
                        if (!doneEX[i])
                        {
                            animlista[i].endx += endXdist[i];
                            if (Math.Abs(animlista[i].endx - editlista[i].endx) < 2)
                            {
                                animlista[i].endx = editlista[i].endx;
                                doneEX[i] = true;
                                counter++;
                            }
                        }
                        if (!doneEY[i])
                        {
                            animlista[i].endy += endYdist[i];
                            if (Math.Abs(animlista[i].endy - editlista[i].endy) < 2)
                            {
                                animlista[i].endy = editlista[i].endy;
                                doneEY[i] = true;
                                counter++;
                            }
                        }
                    }
                    else
                    {
                        if (!doneEX[i])
                        {
                            counter++;
                            doneEX[i] = true;
                        }
                        if (!doneEY[i])
                        {
                            counter++;
                            doneEY[i] = true;
                        }
                    }
                }
                System.Threading.Thread.Sleep((int)tempo);
                animpanel.Invalidate();
            }
            bw.CancelAsync();
        }

        private void animpaint(object sender, PaintEventArgs e)
        {
            foreach (var el in animlista)
                el.Draw(sender, e);
        }

        private void label2move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label2.Location = editpanel.PointToClient(Cursor.Position);
                editpanel.Invalidate();
            }
        }

        private void label1move(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                label1.Location = editpanel.PointToClient(Cursor.Position);
                editpanel.Invalidate();
            }
        }

        private void remove(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Delete)
            {
                int index = editlist.SelectedIndices[0];
                lista.RemoveAt(index);
                editlista.RemoveAt(index);
                dg.Items.RemoveAt(index);
                editlist.Items.RemoveAt(index);
                animlista.RemoveAt(index);
                animpanel.Invalidate();
                editpanel.Invalidate();
                panel.Invalidate();
                dg.Invalidate();
                editlist.Invalidate();
                label1.Visible = false;
                label2.Visible = false;

            }
        }


        #endregion

        private ColumnHeader name;
        private ColumnHeader color;
        private ColumnHeader editname;
        private ColumnHeader editcolor;
        private Label label1;
        private Label label2;
    }
    public class Figure
    {
        private Point start;
        private Point end;
        private double r;
        private Pen p;
        private Color c;
        public Figure(Figure f)
        {
            start = f.start;
            end = f.end;
            r = f.r;
            c = f.c;
            p = new Pen(c);
        }
        public Figure(Point start, Point end, Color c) { this.start = start; this.end = end; r = -1; p = new Pen(c); this.c = c; }
        public Figure(Point middle, double radius, Color c) { this.start = middle; end = new Point();  r = radius; p = new Pen(c); this.c = c; }
        public bool AmILine
        {
            get
            {
                return r == -1;
            }
        }
        public double getr
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public Color getcolor
        {
            get
            {
                return c; 
            }
            set
            {
                c = value;
            }
        }
        public double startx
        {
            get
            {
                return start.X;
            }
            set
            {
                start.X = (int)value;
            }
        }
        public double starty
        {
            get
            {
                return start.Y;
            }
            set
            {
                start.Y = (int)value;
            }
        }
        public double endx
        {
            get
            {
                return end.X;
            }
            set
            {
                end.X = (int)value;
            }
        }
        public double endy
        {
            get
            {
                return end.Y;
            }
            set
            {
                end.Y = (int)value;
            }
        }
        public Point getstart
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }
        }
        public Point getend
        {
            get
            {
                return end;
            }
            set
            {
                end = value;
            }
        }
        public void Draw(object sender, PaintEventArgs e)
        {
            
            if(AmILine)
            {
                e.Graphics.DrawLine(new Pen(c), start, end);
            }
            else
            {
                e.Graphics.DrawEllipse(new Pen(c), start.X - (float)r, start.Y - (float)r, (float)r*2, (float)r*2);
            }
        }
    }
}

