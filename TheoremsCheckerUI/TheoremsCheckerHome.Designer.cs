namespace TheoremsCheckerUI
{
    partial class TheoremsCheckerHome
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSource = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTeorema = new System.Windows.Forms.RichTextBox();
            this.lblTeorema = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(717, 10);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(19, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(69, 12);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(642, 20);
            this.txtSource.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(717, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Inizia";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtTeorema
            // 
            this.txtTeorema.Enabled = false;
            this.txtTeorema.Location = new System.Drawing.Point(69, 152);
            this.txtTeorema.Name = "txtTeorema";
            this.txtTeorema.Size = new System.Drawing.Size(642, 141);
            this.txtTeorema.TabIndex = 4;
            this.txtTeorema.Text = "";
            // 
            // lblTeorema
            // 
            this.lblTeorema.AutoSize = true;
            this.lblTeorema.Enabled = false;
            this.lblTeorema.Location = new System.Drawing.Point(69, 133);
            this.lblTeorema.Name = "lblTeorema";
            this.lblTeorema.Size = new System.Drawing.Size(52, 13);
            this.lblTeorema.TabIndex = 5;
            this.lblTeorema.Text = "Teorema:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(636, 123);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Conferma";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TheoremsCheckerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 358);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTeorema);
            this.Controls.Add(this.txtTeorema);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnSource);
            this.Name = "TheoremsCheckerHome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtTeorema;
        private System.Windows.Forms.Label lblTeorema;
        private System.Windows.Forms.Button btnConfirm;
    }
}

