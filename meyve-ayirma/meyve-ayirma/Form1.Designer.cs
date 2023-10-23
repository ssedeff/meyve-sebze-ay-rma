namespace meyve_ayirma
{
    partial class form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lstTumu = new System.Windows.Forms.ListBox();
            this.lstMeyve = new System.Windows.Forms.ListBox();
            this.lstSebze = new System.Windows.Forms.ListBox();
            this.lblTümü = new System.Windows.Forms.Label();
            this.lblMeyve = new System.Windows.Forms.Label();
            this.lblSebze = new System.Windows.Forms.Label();
            this.btnSırala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTumu
            // 
            this.lstTumu.FormattingEnabled = true;
            this.lstTumu.Items.AddRange(new object[] {
            "patates",
            "mandalina",
            "muz",
            "soğan",
            "ıspanak",
            "üzüm",
            "armut"});
            this.lstTumu.Location = new System.Drawing.Point(25, 112);
            this.lstTumu.Name = "lstTumu";
            this.lstTumu.Size = new System.Drawing.Size(141, 199);
            this.lstTumu.TabIndex = 0;
            // 
            // lstMeyve
            // 
            this.lstMeyve.FormattingEnabled = true;
            this.lstMeyve.Location = new System.Drawing.Point(187, 112);
            this.lstMeyve.Name = "lstMeyve";
            this.lstMeyve.Size = new System.Drawing.Size(139, 199);
            this.lstMeyve.TabIndex = 1;
            // 
            // lstSebze
            // 
            this.lstSebze.FormattingEnabled = true;
            this.lstSebze.Location = new System.Drawing.Point(344, 112);
            this.lstSebze.Name = "lstSebze";
            this.lstSebze.Size = new System.Drawing.Size(130, 199);
            this.lstSebze.TabIndex = 2;
            // 
            // lblTümü
            // 
            this.lblTümü.AutoSize = true;
            this.lblTümü.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTümü.Location = new System.Drawing.Point(56, 67);
            this.lblTümü.Name = "lblTümü";
            this.lblTümü.Size = new System.Drawing.Size(52, 24);
            this.lblTümü.TabIndex = 3;
            this.lblTümü.Text = "tümü";
            // 
            // lblMeyve
            // 
            this.lblMeyve.AutoSize = true;
            this.lblMeyve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMeyve.Location = new System.Drawing.Point(222, 67);
            this.lblMeyve.Name = "lblMeyve";
            this.lblMeyve.Size = new System.Drawing.Size(66, 24);
            this.lblMeyve.TabIndex = 4;
            this.lblMeyve.Text = "meyve";
            // 
            // lblSebze
            // 
            this.lblSebze.AutoSize = true;
            this.lblSebze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSebze.Location = new System.Drawing.Point(378, 67);
            this.lblSebze.Name = "lblSebze";
            this.lblSebze.Size = new System.Drawing.Size(60, 24);
            this.lblSebze.TabIndex = 5;
            this.lblSebze.Text = "label3";
            // 
            // btnSırala
            // 
            this.btnSırala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSırala.Location = new System.Drawing.Point(130, 343);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(253, 40);
            this.btnSırala.TabIndex = 6;
            this.btnSırala.Text = "sırala";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.lblSebze);
            this.Controls.Add(this.lblMeyve);
            this.Controls.Add(this.lblTümü);
            this.Controls.Add(this.lstSebze);
            this.Controls.Add(this.lstMeyve);
            this.Controls.Add(this.lstTumu);
            this.Name = "form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTumu;
        private System.Windows.Forms.ListBox lstMeyve;
        private System.Windows.Forms.ListBox lstSebze;
        private System.Windows.Forms.Label lblTümü;
        private System.Windows.Forms.Label lblMeyve;
        private System.Windows.Forms.Label lblSebze;
        private System.Windows.Forms.Button btnSırala;
    }
}

