using System.ComponentModel;

namespace MyControls
{
    partial class DoubleProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoubleProgress));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbEntryP = new System.Windows.Forms.Label();
            this.lbPInfo = new System.Windows.Forms.Label();
            this.lbFiles = new System.Windows.Forms.Label();
            this.lbInfoName = new System.Windows.Forms.Label();
            this.lbInfoInf = new System.Windows.Forms.Label();
            this.barEntryProgress = new System.Windows.Forms.ProgressBar();
            this.barTotalProgress = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalP = new System.Windows.Forms.Label();
            this.lbInfoSup = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Controls.Add(this.lbInfoSup, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbEntryP, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbPInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbFiles, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbInfoName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbInfoInf, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.barEntryProgress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.barTotalProgress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbTotalP, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbEntryP
            // 
            resources.ApplyResources(this.lbEntryP, "lbEntryP");
            this.lbEntryP.Name = "lbEntryP";
            this.lbEntryP.Click += new System.EventHandler(this.lbEntryP_Click);
            // 
            // lbPInfo
            // 
            resources.ApplyResources(this.lbPInfo, "lbPInfo");
            this.lbPInfo.Name = "lbPInfo";
            // 
            // lbFiles
            // 
            resources.ApplyResources(this.lbFiles, "lbFiles");
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Click += new System.EventHandler(this.lbFiles_Click);
            // 
            // lbInfoName
            // 
            resources.ApplyResources(this.lbInfoName, "lbInfoName");
            this.lbInfoName.Name = "lbInfoName";
            // 
            // lbInfoInf
            // 
            resources.ApplyResources(this.lbInfoInf, "lbInfoInf");
            this.lbInfoInf.Name = "lbInfoInf";
            // 
            // barEntryProgress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.barEntryProgress, 2);
            resources.ApplyResources(this.barEntryProgress, "barEntryProgress");
            this.barEntryProgress.Name = "barEntryProgress";
            // 
            // barTotalProgress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.barTotalProgress, 2);
            resources.ApplyResources(this.barTotalProgress, "barTotalProgress");
            this.barTotalProgress.Name = "barTotalProgress";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Name = "panel1";
            // 
            // lbTotalP
            // 
            resources.ApplyResources(this.lbTotalP, "lbTotalP");
            this.lbTotalP.Name = "lbTotalP";
            // 
            // lbInfoSup
            // 
            resources.ApplyResources(this.lbInfoSup, "lbInfoSup");
            this.lbInfoSup.Name = "lbInfoSup";
            // 
            // DoubleProgress
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoubleProgress";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar barEntryProgress;
        private System.Windows.Forms.ProgressBar barTotalProgress;
        private System.Windows.Forms.Label lbPInfo;
        [Localizable(true)]
        private System.Windows.Forms.Label lbInfoName;
        private System.Windows.Forms.Label lbInfoInf;
        private System.Windows.Forms.Label lbFiles;
        private System.Windows.Forms.Label lbEntryP;
        private System.Windows.Forms.Label lbTotalP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbInfoSup;
    }
}
