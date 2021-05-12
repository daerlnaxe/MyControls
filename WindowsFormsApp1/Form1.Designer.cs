namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressWithLabel1 = new MyControls.ProgressWithLabel();
            this.SuspendLayout();
            // 
            // progressWithLabel1
            // 
            this.progressWithLabel1.Location = new System.Drawing.Point(52, 36);
            this.progressWithLabel1.Name = "progressWithLabel1";
            this.progressWithLabel1.Size = new System.Drawing.Size(594, 31);
            this.progressWithLabel1.TabIndex = 0;
            this.progressWithLabel1.Value = 50;
            this.progressWithLabel1.Click += new System.EventHandler(this.progressWithLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressWithLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.ProgressWithLabel progressWithLabel1;
    }
}

