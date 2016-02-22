namespace TestForm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.lblBodyColor = new System.Windows.Forms.Label();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.lblTileColor = new System.Windows.Forms.Label();
            this.cbTile = new System.Windows.Forms.ComboBox();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.cbBackColor = new System.Windows.Forms.ComboBox();
            this.gbAnim = new System.Windows.Forms.GroupBox();
            this.lblStyle = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.cbFlags = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.txtIconPath = new System.Windows.Forms.TextBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.cbDelay = new System.Windows.Forms.CheckBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbInstant = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.gbColor.SuspendLayout();
            this.gbAnim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.gbOther.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(197, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.Location = new System.Drawing.Point(116, 19);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(75, 23);
            this.btnDismiss.TabIndex = 1;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // nudDelay
            // 
            this.nudDelay.Enabled = false;
            this.nudDelay.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDelay.Location = new System.Drawing.Point(85, 20);
            this.nudDelay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(187, 20);
            this.nudDelay.TabIndex = 2;
            this.nudDelay.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.lblBodyColor);
            this.gbColor.Controls.Add(this.cbBody);
            this.gbColor.Controls.Add(this.lblTileColor);
            this.gbColor.Controls.Add(this.cbTile);
            this.gbColor.Controls.Add(this.lblBackColor);
            this.gbColor.Controls.Add(this.cbBackColor);
            this.gbColor.Location = new System.Drawing.Point(12, 118);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(278, 107);
            this.gbColor.TabIndex = 4;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Coloring";
            // 
            // lblBodyColor
            // 
            this.lblBodyColor.AutoSize = true;
            this.lblBodyColor.Location = new System.Drawing.Point(6, 76);
            this.lblBodyColor.Name = "lblBodyColor";
            this.lblBodyColor.Size = new System.Drawing.Size(31, 13);
            this.lblBodyColor.TabIndex = 5;
            this.lblBodyColor.Text = "Body";
            // 
            // cbBody
            // 
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Location = new System.Drawing.Point(85, 73);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(187, 21);
            this.cbBody.TabIndex = 4;
            // 
            // lblTileColor
            // 
            this.lblTileColor.AutoSize = true;
            this.lblTileColor.Location = new System.Drawing.Point(6, 49);
            this.lblTileColor.Name = "lblTileColor";
            this.lblTileColor.Size = new System.Drawing.Size(50, 13);
            this.lblTileColor.TabIndex = 3;
            this.lblTileColor.Text = "Tile color";
            // 
            // cbTile
            // 
            this.cbTile.FormattingEnabled = true;
            this.cbTile.Location = new System.Drawing.Point(85, 46);
            this.cbTile.Name = "cbTile";
            this.cbTile.Size = new System.Drawing.Size(187, 21);
            this.cbTile.TabIndex = 2;
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(6, 22);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(58, 13);
            this.lblBackColor.TabIndex = 1;
            this.lblBackColor.Text = "Back color";
            // 
            // cbBackColor
            // 
            this.cbBackColor.FormattingEnabled = true;
            this.cbBackColor.Location = new System.Drawing.Point(85, 19);
            this.cbBackColor.Name = "cbBackColor";
            this.cbBackColor.Size = new System.Drawing.Size(187, 21);
            this.cbBackColor.TabIndex = 0;
            // 
            // gbAnim
            // 
            this.gbAnim.Controls.Add(this.lblStyle);
            this.gbAnim.Controls.Add(this.nudDuration);
            this.gbAnim.Controls.Add(this.cbFlags);
            this.gbAnim.Controls.Add(this.lblDuration);
            this.gbAnim.Location = new System.Drawing.Point(12, 231);
            this.gbAnim.Name = "gbAnim";
            this.gbAnim.Size = new System.Drawing.Size(278, 77);
            this.gbAnim.TabIndex = 6;
            this.gbAnim.TabStop = false;
            this.gbAnim.Text = "Animation";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(6, 48);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(30, 13);
            this.lblStyle.TabIndex = 7;
            this.lblStyle.Text = "Style";
            // 
            // nudDuration
            // 
            this.nudDuration.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDuration.Location = new System.Drawing.Point(85, 19);
            this.nudDuration.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(187, 20);
            this.nudDuration.TabIndex = 7;
            this.nudDuration.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // cbFlags
            // 
            this.cbFlags.FormattingEnabled = true;
            this.cbFlags.Location = new System.Drawing.Point(85, 45);
            this.cbFlags.Name = "cbFlags";
            this.cbFlags.Size = new System.Drawing.Size(187, 21);
            this.cbFlags.TabIndex = 6;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(6, 21);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(69, 13);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration (ms)";
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.txtIconPath);
            this.gbOther.Controls.Add(this.nudDelay);
            this.gbOther.Controls.Add(this.lblIcon);
            this.gbOther.Controls.Add(this.cbDelay);
            this.gbOther.Location = new System.Drawing.Point(12, 314);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(278, 77);
            this.gbOther.TabIndex = 8;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Other";
            // 
            // txtIconPath
            // 
            this.txtIconPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIconPath.Location = new System.Drawing.Point(85, 45);
            this.txtIconPath.Name = "txtIconPath";
            this.txtIconPath.Size = new System.Drawing.Size(187, 20);
            this.txtIconPath.TabIndex = 8;
            this.txtIconPath.Click += new System.EventHandler(this.txtIconPath_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(6, 48);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(47, 13);
            this.lblIcon.TabIndex = 6;
            this.lblIcon.Text = "Tile icon";
            // 
            // cbDelay
            // 
            this.cbDelay.AutoSize = true;
            this.cbDelay.Location = new System.Drawing.Point(9, 21);
            this.cbDelay.Name = "cbDelay";
            this.cbDelay.Size = new System.Drawing.Size(75, 17);
            this.cbDelay.TabIndex = 9;
            this.cbDelay.Text = "Delay (ms)";
            this.cbDelay.UseVisualStyleBackColor = true;
            this.cbDelay.CheckedChanged += new System.EventHandler(this.cbDelay_CheckedChanged);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnShow);
            this.gbControl.Controls.Add(this.btnDismiss);
            this.gbControl.Controls.Add(this.cbInstant);
            this.gbControl.Location = new System.Drawing.Point(12, 397);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(278, 55);
            this.gbControl.TabIndex = 9;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.txtBody);
            this.gbText.Controls.Add(this.txtTitle);
            this.gbText.Controls.Add(this.lblBody);
            this.gbText.Controls.Add(this.lblTitle);
            this.gbText.Location = new System.Drawing.Point(12, 7);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(278, 105);
            this.gbText.TabIndex = 8;
            this.gbText.TabStop = false;
            this.gbText.Text = "Text";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(86, 44);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(186, 44);
            this.txtBody.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(186, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(6, 48);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Body";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // cbInstant
            // 
            this.cbInstant.AutoSize = true;
            this.cbInstant.Location = new System.Drawing.Point(9, 23);
            this.cbInstant.Name = "cbInstant";
            this.cbInstant.Size = new System.Drawing.Size(94, 17);
            this.cbInstant.TabIndex = 5;
            this.cbInstant.Text = "Instant dismiss";
            this.cbInstant.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 464);
            this.Controls.Add(this.gbText);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.gbAnim);
            this.Controls.Add(this.gbColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tray Notification";
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.gbAnim.ResumeLayout(false);
            this.gbAnim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.gbOther.ResumeLayout(false);
            this.gbOther.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbText.ResumeLayout(false);
            this.gbText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Label lblBodyColor;
        private System.Windows.Forms.ComboBox cbBody;
        private System.Windows.Forms.Label lblTileColor;
        private System.Windows.Forms.ComboBox cbTile;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.ComboBox cbBackColor;
        private System.Windows.Forms.GroupBox gbAnim;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.ComboBox cbFlags;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.TextBox txtIconPath;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.CheckBox cbDelay;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.CheckBox cbInstant;
    }
}

