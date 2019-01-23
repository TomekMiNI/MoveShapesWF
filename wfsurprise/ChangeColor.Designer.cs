using System;
using System.Drawing;
using System.Windows.Forms;

namespace wfsurprise
{
    partial class ChangeColor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tp;
        private TrackBar trackR;
        private TrackBar trackG;
        private TrackBar trackB;
        private Label prostokat;
        private Button baton;
        private Label name;
        private TextBox submitname;
        private Label redname;
        private Label greenname;
        private Label bluename;
        private Label radius;
        private TextBox submitradius;

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
            this.radius = new System.Windows.Forms.Label();
            this.submitradius = new System.Windows.Forms.TextBox();
            this.greenname = new System.Windows.Forms.Label();
            this.redname = new System.Windows.Forms.Label();
            this.bluename = new System.Windows.Forms.Label();
            this.tp = new System.Windows.Forms.TableLayoutPanel();
            this.trackR = new System.Windows.Forms.TrackBar();
            this.trackG = new System.Windows.Forms.TrackBar();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.prostokat = new System.Windows.Forms.Label();
            this.baton = new System.Windows.Forms.Button();
            this.submitname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            this.SuspendLayout();
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(215, 0);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 23);
            this.radius.TabIndex = 11;
            this.radius.Text = "Radius";
            this.radius.Visible = false;
            // 
            // submitradius
            // 
            this.submitradius.Location = new System.Drawing.Point(321, 3);
            this.submitradius.Name = "submitradius";
            this.submitradius.Size = new System.Drawing.Size(100, 20);
            this.submitradius.TabIndex = 10;
            this.submitradius.Visible = false;
            // 
            // greenname
            // 
            this.greenname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greenname.Location = new System.Drawing.Point(3, 76);
            this.greenname.Name = "greenname";
            this.greenname.Size = new System.Drawing.Size(100, 50);
            this.greenname.TabIndex = 8;
            this.greenname.Text = "Green";
            this.greenname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redname
            // 
            this.redname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redname.Location = new System.Drawing.Point(3, 26);
            this.redname.Name = "redname";
            this.redname.Size = new System.Drawing.Size(100, 50);
            this.redname.TabIndex = 7;
            this.redname.Text = "Red";
            this.redname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bluename
            // 
            this.bluename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bluename.Location = new System.Drawing.Point(3, 126);
            this.bluename.Name = "bluename";
            this.bluename.Size = new System.Drawing.Size(100, 50);
            this.bluename.TabIndex = 9;
            this.bluename.Text = "Blue";
            this.bluename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tp
            // 
            this.tp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tp.Controls.Add(this.trackR, 1, 1);
            this.tp.Controls.Add(this.trackG, 1, 2);
            this.tp.Controls.Add(this.trackB, 1, 3);
            this.tp.Controls.Add(this.prostokat, 0, 4);
            this.tp.Controls.Add(this.baton, 1, 4);
            this.tp.Controls.Add(this.submitname, 1, 0);
            this.tp.Controls.Add(this.name, 0, 0);
            this.tp.Controls.Add(this.redname, 0, 1);
            this.tp.Controls.Add(this.greenname, 0, 2);
            this.tp.Controls.Add(this.bluename, 0, 3);
            this.tp.Controls.Add(this.submitradius, 3, 0);
            this.tp.Controls.Add(this.radius, 2, 0);
            this.tp.Location = new System.Drawing.Point(0, 0);
            this.tp.Name = "tp";
            this.tp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tp.Size = new System.Drawing.Size(595, 241);
            this.tp.TabIndex = 0;
            // 
            // trackR
            // 
            this.tp.SetColumnSpan(this.trackR, 3);
            this.trackR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackR.Location = new System.Drawing.Point(109, 29);
            this.trackR.Maximum = 255;
            this.trackR.Name = "trackR";
            this.trackR.Size = new System.Drawing.Size(589, 44);
            this.trackR.TabIndex = 0;
            this.trackR.ValueChanged += new System.EventHandler(this.updatecolor);
            // 
            // trackG
            // 
            this.tp.SetColumnSpan(this.trackG, 3);
            this.trackG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackG.Location = new System.Drawing.Point(109, 79);
            this.trackG.Maximum = 255;
            this.trackG.Name = "trackG";
            this.trackG.Size = new System.Drawing.Size(589, 44);
            this.trackG.TabIndex = 1;
            this.trackG.ValueChanged += new System.EventHandler(this.updatecolor);
            // 
            // trackB
            // 
            this.tp.SetColumnSpan(this.trackB, 3);
            this.trackB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackB.Location = new System.Drawing.Point(109, 129);
            this.trackB.Maximum = 255;
            this.trackB.Name = "trackB";
            this.trackB.Size = new System.Drawing.Size(589, 44);
            this.trackB.TabIndex = 2;
            this.trackB.ValueChanged += new System.EventHandler(this.updatecolor);
            // 
            // prostokat
            // 
            this.prostokat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prostokat.Location = new System.Drawing.Point(3, 197);
            this.prostokat.Name = "prostokat";
            this.prostokat.Size = new System.Drawing.Size(100, 23);
            this.prostokat.TabIndex = 3;
            // 
            // baton
            // 
            this.baton.Location = new System.Drawing.Point(109, 179);
            this.baton.Name = "baton";
            this.baton.Size = new System.Drawing.Size(75, 23);
            this.baton.TabIndex = 4;
            this.baton.Text = "Done";
            this.baton.Click += new System.EventHandler(this.baton_Click);
            // 
            // submitname
            // 
            this.submitname.Location = new System.Drawing.Point(109, 3);
            this.submitname.Name = "submitname";
            this.submitname.Size = new System.Drawing.Size(100, 20);
            this.submitname.TabIndex = 5;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(3, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 6;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 241);
            this.Controls.Add(this.tp);
            this.Name = "ChangeColor";
            this.Text = "ColorChange";
            this.tp.ResumeLayout(false);
            this.tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            this.ResumeLayout(false);

        }

        private void updatecolor(object sender, EventArgs e)
        {
            prostokat.BackColor = Color.FromArgb(255, trackR.Value, trackG.Value, trackB.Value);
        }

        #endregion
    }
}