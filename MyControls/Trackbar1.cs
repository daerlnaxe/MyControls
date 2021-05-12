using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControls
{
    public partial class Trackbar1 : UserControl
    {
        // Titre
        [Description("Nom"), Category("Titre"), Localizable(true)]
        public string Title { get { return lbTitle.Text; } set { lbTitle.Text = value; } }

        [Description("Taille du titre"), Category("Titre")]
        public int TitleSize
        {
            get { return lbTitle.Width; }
            set
            {
                lbTitle.Width = value;
                lbTitle.MinimumSize = new Size(value, lbTitle.Height);
            }
        }


        // Pos
        [Description("Position"), Category("Trackbar")]
        public int Position
        {
            get { return trackBar.Value; }
            set
            {
                lbValue.Text = value.ToString();
                trackBar.Value = value;
               
            }
        }

        // TrackBar Max
        [Description("Maximum"), Category("Trackbar")]
        public int Maximum { get { return trackBar.Maximum; } set { trackBar.Maximum = value; } }


        [Description("Nom du Maximum"), Category("TrackBar"), Localizable(true)]
        public string MaximumName { get { return lbMax.Text; } set { lbMax.Text = value; } }


        // TrackBar Min
        [Description("Maximum"), Category("Trackbar")]
        public int Minimum { get { return trackBar.Minimum; } set { trackBar.Minimum = value; } }

        [Description("Nom du Minimum"), Category("TrackBar"), Localizable(true)]
        public string MinimumName { get { return lbMin.Text; } set { lbMin.Text = value; } }

        // TrackBar Mid
        [Description("Nom du Milieu"), Category("TrackBar"), Localizable(true)]
        public string MiddleName { get { return lbMid.Text; } set { lbMid.Text = value; } }

        [Description("Mid Spacer"), Category("TrackBar")]
        public Padding MidSpacer { get { return lbMid.Margin; } set { lbMid.Margin = value; } }


        public Trackbar1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            lbValue.Text = trackBar.Value.ToString();
        }
    }
}
