namespace GameOfFifteen
{
    partial class PuzzleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleForm));
            this.pnlPuzzle = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.cmbPuzzleSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pbOriginalImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPuzzle
            // 
            this.pnlPuzzle.AutoSize = true;
            this.pnlPuzzle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPuzzle.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPuzzle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPuzzle.Location = new System.Drawing.Point(36, 60);
            this.pnlPuzzle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPuzzle.Name = "pnlPuzzle";
            this.pnlPuzzle.Size = new System.Drawing.Size(4, 4);
            this.pnlPuzzle.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(352, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Moves:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(417, 480);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 19);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // cmbPuzzleSize
            // 
            this.cmbPuzzleSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuzzleSize.FormattingEnabled = true;
            this.cmbPuzzleSize.Items.AddRange(new object[] {
            "3*3",
            "4*4",
            "5*5",
            "6*6",
            "7*7"});
            this.cmbPuzzleSize.Location = new System.Drawing.Point(153, 32);
            this.cmbPuzzleSize.Name = "cmbPuzzleSize";
            this.cmbPuzzleSize.Size = new System.Drawing.Size(40, 21);
            this.cmbPuzzleSize.TabIndex = 8;
            this.cmbPuzzleSize.SelectedIndexChanged += new System.EventHandler(this.CmbPuzzleSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puzzle Size:";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.AutoSize = true;
            this.btnSelectImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectImage.Image")));
            this.btnSelectImage.Location = new System.Drawing.Point(36, 476);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(87, 46);
            this.btnSelectImage.TabIndex = 7;
            this.btnSelectImage.Text = "New";
            this.btnSelectImage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(227, 476);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 54);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.Location = new System.Drawing.Point(467, 53);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(412, 447);
            this.pbOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbOriginalImage.TabIndex = 1;
            this.pbOriginalImage.TabStop = false;
            // 
            // PuzzleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 540);
            this.Controls.Add(this.cmbPuzzleSize);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pbOriginalImage);
            this.Controls.Add(this.pnlPuzzle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 500);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1054, 579);
            this.MinimumSize = new System.Drawing.Size(524, 579);
            this.Name = "PuzzleForm";
            this.Text = "Game of Fifteen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPuzzle;
        private System.Windows.Forms.PictureBox pbOriginalImage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ComboBox cmbPuzzleSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

