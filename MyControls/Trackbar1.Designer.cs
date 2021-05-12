namespace MyControls
{
    partial class Trackbar1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trackbar1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbValue = new System.Windows.Forms.Label();
            this.lbMid = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lbValue, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbMid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbMin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbMax, 3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbValue
            // 
            resources.ApplyResources(this.lbValue, "lbValue");
            this.lbValue.Name = "lbValue";
            // 
            // lbMid
            // 
            resources.ApplyResources(this.lbMid, "lbMid");
            this.lbMid.Name = "lbMid";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // trackBar
            // 
            resources.ApplyResources(this.trackBar, "trackBar");
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar, 3);
            this.trackBar.Name = "trackBar";
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lbMin
            // 
            resources.ApplyResources(this.lbMin, "lbMin");
            this.lbMin.Name = "lbMin";
            // 
            // lbMax
            // 
            resources.ApplyResources(this.lbMax, "lbMax");
            this.lbMax.Name = "lbMax";
            // 
            // Trackbar1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Trackbar1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMid;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbValue;
    }
}
