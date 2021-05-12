using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq.Expressions;

namespace MyControls
{
    public partial class DoubleProgress : UserControl
    {
        delegate void UpdateInt(int percent);
        delegate void UpdateDoubleInt(int one, int two);
        delegate void UpdateString(string text);

        /// <summary>
        /// Nom de l'étiquette information supérieure
        /// </summary>
        [DisplayName("Info Principale"), Description("Information sur la partie supérieure"), Category("General"), Localizable(true)]
        public string SupInfoName { get { return lbPInfo.Text; } set { lbPInfo.Text = value; } }

        /// <summary>
        /// Nom de l'étiquette information inférieure
        /// </summary>
        [DisplayName("Info Secondaire"), Description("Information sur la partie basse"), Category("General"), Localizable(true)]
        public string InfoName { get { return lbInfoName.Text; } set { lbInfoName.Text = value; } }

        [Browsable(false)]
        public int FilesDone { get; set; }

        [Browsable(false)]
        public int TotalFiles { get; set; }

        /// <summary>
        /// Information supérieure
        /// </summary>
        [Browsable(false)]
        public string InfoSup
        {
            get { return this.lbInfoSup.Text; }
            set { AsyncInfoSup(value); }
        }

        /// <summary>
        /// Info en cours
        /// </summary>
        [Browsable(false)]
        public string CurrentInfo
        {
            get { return this.lbInfoInf.Text; }
            set { AsyncCurrentInfo(value); }
        }

        #region Entry
        /// <summary>
        ///  
        /// </summary>
        /// <param name="percent"></param>
        void AsyncBarEntryUpdate(int percent)
        {
            if (this.barEntryProgress.InvokeRequired)
            {
                UpdateInt d = new UpdateInt(AsyncBarEntryUpdate);
                this.Invoke(d, new object[] { percent });
            }
            else
            {
                this.barEntryProgress.Value = percent;
                this.barEntryProgress.Refresh();

            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="percent"></param>
        void AsyncLabEntryUpdate(int percent)
        {
            if (this.lbEntryP.InvokeRequired)
            {
                UpdateInt d = new UpdateInt(AsyncLabEntryUpdate);
                this.Invoke(d, new object[] { percent });
            }
            else
            {
                lbEntryP.Text = $"{ percent}%";
                lbEntryP.Refresh();
            }
        }

        /// <summary>
        /// Update EntryProgressBar
        /// </summary>
        /// <param name="part">Part bytes</param>
        /// <param name="total">Total bytes</param>
        public void EntryCalcUpdate(long part, long total)
        {
            int val = (int)(part * 100 / total);
            AsyncBarEntryUpdate(val);
            AsyncLabEntryUpdate(val);

            //lbEntryP.Refresh();
        }


        public void EntryUpdate(int value)
        {
            AsyncBarEntryUpdate(value);
            AsyncLabEntryUpdate(value);
        }

        #endregion

        #region General

        /// <summary>
        /// Infos Sup en cours
        /// </summary>
        /// <param name="value"></param>
        private void AsyncInfoSup(string info)
        {
            try
            {
                if (this.lbInfoSup.InvokeRequired)
                {
                    UpdateString d = new UpdateString(AsyncInfoSup);
                    this.Invoke(d, new object[] { info });
                }
                else
                {
                    this.lbInfoSup.Text = info;
                    this.lbInfoSup.Refresh();
                }
            }
            catch (Exception exc)
            {
                //1
                Debug.WriteLine($"Bug AsyncInfoSup: {exc.Message}");
            }
        }

        private void AsyncCurrentInfo(string info)
        {
            try
            {
                if (this.lbInfoInf.InvokeRequired)
                {
                    UpdateString d = new UpdateString(AsyncCurrentInfo);
                    this.Invoke(d, new object[] { info });
                }
                else
                {
                    this.lbInfoInf.Text = info;
                    this.lbInfoInf.Refresh();
                }
            }
            catch(Exception exc)
            {
                Debug.WriteLine("Bug AsyncCurrentInfo: " + exc.Message);
            }
        }


        /// <summary>
        /// Async set files
        /// </summary>
        /// <param name="current"></param>
        /// <param name="total"></param>
        void AsyncSetFiles(int current, int total)
        {
            try
            {
                if (lbFiles.InvokeRequired)
                {
                    UpdateDoubleInt d = new UpdateDoubleInt(AsyncSetFiles);
                    this.Invoke(d, new object[] { current, total });
                }
                else
                {
                    lbFiles.Text = $"{current}/{total}";
                    this.lbFiles.Refresh();
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine($"Bug AsyncSetFiles: {exc.Message}");
            }
        }


        #endregion

        #region EntryBar: Concerne la barre de progression de fichier

        /// <summary>
        /// Evite la division par 0
        /// </summary>
        public void EntryInit()
        {
            //lbEntryP.Text = "0%";
            //barEntryProgress.Value = 0;
            //lbEntryP.Refresh();

        }

        /*
        public void EntryFinalize()
        {
            lbEntryP.Text = "100%";
            entryProgress.Value = 100;
        }*/
        #endregion


        #region Total

        /// <summary>
        /// Async barre total
        /// </summary>
        /// <param name="percent"></param>
        void AsyncTotalBarUpdate(int percent)
        {
            try
            {

                if (this.barTotalProgress.InvokeRequired)
                {
                    UpdateInt d = new UpdateInt(AsyncTotalBarUpdate);
                    this.Invoke(d, new object[] { percent });
                }
                else
                {
                    this.barTotalProgress.Value = percent;
                    this.barTotalProgress.Refresh();
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine($"Bug AsyncTotalBarUpdate: {exc.Message}");
            }
        }

        /// <summary>
        ///  Async lab total
        /// </summary>
        /// <param name="percent"></param>
        void AsyncTotalLabUpdate(int percent)
        {
            try
            {

                if (this.lbTotalP.InvokeRequired)
                {
                    UpdateInt d = new UpdateInt(AsyncTotalLabUpdate);
                    this.Invoke(d, new object[] { percent });
                }
                else
                {
                    Debug.WriteLine("else");
                    lbTotalP.Text = $"{ percent}%";
                    Debug.WriteLine("between");
                    lbTotalP.Refresh();
                    Debug.WriteLine("Finished");
                }
            }
            catch (Exception exc)
            {
                //1
                Debug.WriteLine($"Bug AsyncTotalLabUpdate: {exc.Message}");
            }
        }

        public void GlobalProgress(int current, int total)
        {
            //  barTotalProgress.Value = current;
            //  barTotalProgress.Maximum = total;
            int val = (int)(current * 100 / total);

            AsyncTotalLabUpdate(val);
            AsyncSetFiles(current, total);
            AsyncTotalBarUpdate(val);
            // lbFiles.Refresh();
            // lbTotalP.Refresh();
        }

        public void GlobalFinalize(int total)
        {
            lbEntryP.Text = "100%";
            barTotalProgress.Value = 100;
            AsyncSetFiles(total, total);

            lbFiles.Refresh();
            lbTotalP.Refresh();
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        private void SetCurrentTask(string info)
        {
            lbInfoInf.Text = info;
            lbInfoInf.Refresh();
            lbInfoName.Refresh();

        }


        public DoubleProgress()
        {
            InitializeComponent();
        }

        private void lbFiles_Click(object sender, EventArgs e)
        {

        }

        private void lbEntryP_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
