using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfsurprise
{
    public partial class Form1 : Form
    {
        private Point StartPoint = new Point();
        private Point EndPoint = new Point();
        bool rysuj = false;
        bool czkcz = false;
        private int linecounter = 0;
        private int circlecounter = 0;
        private float radius = 0;
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
        }

        private void paintline_CheckedChanged(object sender, EventArgs e)
        {
            czkcz = false;
        }

        private void paintcircle_CheckedChanged(object sender, EventArgs e)
        {
            czkcz = true;
        }

        private void beginpaint(object sender, MouseEventArgs e)
        {
            if (!rysuj)
            {
                StartPoint = (sender as Control).PointToClient(Cursor.Position);
                rysuj = true;
            }
            else
            {
                rysuj = false;
                ListViewItem itm = new ListViewItem();
                ListViewItem itm2 = new ListViewItem();
                if (!czkcz)
                {
                    Figure f= new Figure(StartPoint, EndPoint, prostokat.BackColor);
                    lista.Add(f);
                    editlista.Add(new Figure(f));
                    animlista.Add(new Figure(f));
                    itm.Text = "Line " + linecounter;
                    itm2.Tag = linecounter;
                    linecounter++;
                    itm2.Text= "Line " + linecounter; 
                }
                else
                {
                    Figure f = new Figure(StartPoint, radius, prostokat.BackColor);
                    lista.Add(f);
                    editlista.Add(new Figure(f));
                    animlista.Add(new Figure(f));
                    itm.Text = "Circle " + circlecounter;
                    itm2.Tag = linecounter;
                    circlecounter++;
                    itm2.Text = "Circle " + circlecounter;
                }
                
                itm.SubItems.Add(String.Format( "Color [A={0}, R={1}, G={2}, B={3}", prostokat.BackColor.A, prostokat.BackColor.R, prostokat.BackColor.G, prostokat.BackColor.B));
                itm2.SubItems.Add(String.Format("Color [A={0}, R={1}, G={2}, B={3}", prostokat.BackColor.A, prostokat.BackColor.R, prostokat.BackColor.G, prostokat.BackColor.B));
                dg.Items.Add(itm);
                dg.Invalidate();
                editlist.Items.Add(itm2);
                editlist.Invalidate();
                editpanel.Invalidate();
                animpanel.Invalidate();
                StartPoint = new Point();
                panel.Invalidate();
            }
        }

        private void pickacolor(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                prostokat.BackColor = cd.Color;
            }
        }

        private void durante(object sender, MouseEventArgs e)
        {
            EndPoint = (sender as Control).PointToClient(Cursor.Position);
            panel.Invalidate();
        }

        private void editpaint(object sender, PaintEventArgs e)
        {
            if (editlist.SelectedItems.Count != 0)
            {
                editlista[index].getstart = label1.Location;
                editlista[index].getend = label2.Location;
            }
           foreach (Figure f in editlista)
                    f.Draw(sender, e);
         
        }

        private void panelpaint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in lista)
                f.Draw(sender, e);
            if (rysuj)
            {
                if (!czkcz)
                    e.Graphics.DrawLine(Pens.Red, StartPoint, EndPoint);
                else
                {
                    radius = (float)Math.Sqrt((StartPoint.X - EndPoint.X) * (StartPoint.X - EndPoint.X) + (StartPoint.Y - EndPoint.Y) * (StartPoint.Y - EndPoint.Y));
                    e.Graphics.DrawEllipse(Pens.Red, StartPoint.X - radius, StartPoint.Y - radius, radius * 2, radius * 2);
                }
            }

        }

        private void changecolor(object sender, MouseEventArgs e)
        {
            index = editlist.SelectedIndices[0];
            ChangeColor cc = new ChangeColor(editlista[index], editlist.Items[index]);
            cc.ShowDialog();
            editlist.Items[index].SubItems[0].Text = cc.getname;
            editlist.Items[index].SubItems[1].Text = cc.getcolorname;
            editlist.Invalidate();
            editpanel.Invalidate();
        }

        private void drawrectangles(object sender, EventArgs e)
        {
            index = editlist.SelectedIndices[0];
            label1.Location=editlista[index].getstart;
            label1.Visible = true;
            if (editlista[index].AmILine)
            {
                label2.Location = editlista[index].getend;
                label2.Visible = true;
            }
            tpedit.Invalidate();
        }

        private void startanim_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy)
            {
                bw.CancelAsync();
                return;
            }
            tempo = trackanim.Value;
            bw.RunWorkerAsync();
        }

        private void resetanim_Click(object sender, EventArgs e)
        {
            for(int i=0;i<animlista.Count;i++)
            {
                animlista[i].getstart = lista[i].getstart;
                animlista[i].getend = lista[i].getend;
                animlista[i].getr = lista[i].getr;
            }
            animpanel.Invalidate();
        }
    }
}
