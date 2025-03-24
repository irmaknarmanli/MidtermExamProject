namespace MidtermExamProject
{
    partial class Form3
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
            this.btnMain = new System.Windows.Forms.Button();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.vScrollBarGreen = new System.Windows.Forms.VScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.lblColorInfo = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Location = new System.Drawing.Point(649, 410);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(150, 40);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(40, 114);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(434, 45);
            this.trackBarRed.TabIndex = 5;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // vScrollBarGreen
            // 
            this.vScrollBarGreen.LargeChange = 5;
            this.vScrollBarGreen.Location = new System.Drawing.Point(520, 31);
            this.vScrollBarGreen.Maximum = 255;
            this.vScrollBarGreen.Name = "vScrollBarGreen";
            this.vScrollBarGreen.Size = new System.Drawing.Size(17, 194);
            this.vScrollBarGreen.TabIndex = 6;
            this.vScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 5;
            this.hScrollBarBlue.Location = new System.Drawing.Point(40, 185);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(434, 17);
            this.hScrollBarBlue.TabIndex = 7;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.AutoSize = true;
            this.lblColorInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblColorInfo.Location = new System.Drawing.Point(37, 239);
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(158, 17);
            this.lblColorInfo.TabIndex = 8;
            this.lblColorInfo.Text = "Current Color: RGB(x, y, z)";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRed.Location = new System.Drawing.Point(37, 94);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(34, 17);
            this.lblRed.TabIndex = 9;
            this.lblRed.Text = "Red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(471, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Green:";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBlue.Location = new System.Drawing.Point(37, 162);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(35, 17);
            this.lblBlue.TabIndex = 11;
            this.lblBlue.Text = "Blue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(226, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Background Color Controller";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblColorInfo);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.vScrollBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.btnMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.VScrollBar vScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Label lblColorInfo;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label label2;
    }
}