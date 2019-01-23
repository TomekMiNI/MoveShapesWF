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
    public partial class ChangeColor : Form
    {
        private Figure f;
        private ListViewItem lvi;
        private string modifycolor;
        private double R;
        public ChangeColor(Figure f, ListViewItem lvi)
        {
            
            this.f = f;
            this.lvi = lvi;
            InitializeComponent();
            if (!f.AmILine)
            {
                R = f.getr;
                submitradius.Visible = true;
                radius.Visible = true;
            }
            submitradius.Text = R.ToString();
            submitname.Text = lvi.SubItems[0].Text;
            prostokat.BackColor = f.getcolor;
        }
        public string getname
        {
            get
            {
                return submitname.Text;
            }
        } 
        public string getcolorname
        {
            get
            {
                return modifycolor;
            }
        }
        private void baton_Click(object sender, EventArgs e)
        {
            double tryit;
            if (Double.TryParse(submitradius.Text, out tryit))
                f.getr = tryit;
            f.getcolor = prostokat.BackColor;
            modifycolor= String.Format("Color [A={0}, R={1}, G={2}, B={3}", prostokat.BackColor.A, prostokat.BackColor.R, prostokat.BackColor.G, prostokat.BackColor.B);
            this.Close();
        }
    }
}
