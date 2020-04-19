namespace Peter
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.changeTheme = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveDataBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.miniMizeBtn1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.PhaseLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mimimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMizeBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PhaseLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.changeTheme);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 70);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(12, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 101;
            this.label10.Text = "Theme:";
            // 
            // changeTheme
            // 
            this.changeTheme.BackColor = System.Drawing.Color.White;
            this.changeTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeTheme.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTheme.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.changeTheme.FormattingEnabled = true;
            this.changeTheme.Items.AddRange(new object[] {
            "White Theme",
            "Dark Theme"});
            this.changeTheme.Location = new System.Drawing.Point(67, 19);
            this.changeTheme.Name = "changeTheme";
            this.changeTheme.Size = new System.Drawing.Size(121, 23);
            this.changeTheme.TabIndex = 10;
            this.changeTheme.SelectedIndexChanged += new System.EventHandler(this.changeTheme_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(415, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(526, 35);
            this.label9.TabIndex = 9;
            this.label9.Text = "QUARRY PLANNING PRODUCTION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.saveDataBtn);
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Controls.Add(this.mimimizeBtn);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.miniMizeBtn1);
            this.panel2.Controls.Add(this.closeBtn1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(984, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 70);
            this.panel2.TabIndex = 1;
            // 
            // saveDataBtn
            // 
            this.saveDataBtn.Activecolor = System.Drawing.Color.Teal;
            this.saveDataBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saveDataBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveDataBtn.BorderRadius = 5;
            this.saveDataBtn.ButtonText = "Save Data";
            this.saveDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveDataBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saveDataBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saveDataBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveDataBtn.Iconimage")));
            this.saveDataBtn.Iconimage_right = null;
            this.saveDataBtn.Iconimage_right_Selected = null;
            this.saveDataBtn.Iconimage_Selected = null;
            this.saveDataBtn.IconMarginLeft = 0;
            this.saveDataBtn.IconMarginRight = 0;
            this.saveDataBtn.IconRightVisible = true;
            this.saveDataBtn.IconRightZoom = 0D;
            this.saveDataBtn.IconVisible = true;
            this.saveDataBtn.IconZoom = 60D;
            this.saveDataBtn.IsTab = false;
            this.saveDataBtn.Location = new System.Drawing.Point(63, 6);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.saveDataBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.saveDataBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveDataBtn.selected = false;
            this.saveDataBtn.Size = new System.Drawing.Size(121, 39);
            this.saveDataBtn.TabIndex = 0;
            this.saveDataBtn.Text = "Save Data";
            this.saveDataBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveDataBtn.Textcolor = System.Drawing.Color.White;
            this.saveDataBtn.TextFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataBtn.Click += new System.EventHandler(this.saveDataBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageActive = null;
            this.refreshBtn.Location = new System.Drawing.Point(3, 6);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(54, 39);
            this.refreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBtn.TabIndex = 97;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Zoom = 10;
            this.refreshBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.refreshBtn_MouseClick);
            // 
            // mimimizeBtn
            // 
            this.mimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.mimimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mimimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("mimimizeBtn.Image")));
            this.mimimizeBtn.ImageActive = null;
            this.mimimizeBtn.Location = new System.Drawing.Point(207, 6);
            this.mimimizeBtn.Name = "mimimizeBtn";
            this.mimimizeBtn.Size = new System.Drawing.Size(27, 36);
            this.mimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mimimizeBtn.TabIndex = 1;
            this.mimimizeBtn.TabStop = false;
            this.mimimizeBtn.Zoom = 10;
            this.mimimizeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mimimizeBtn_MouseClick);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(240, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(27, 23);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // miniMizeBtn1
            // 
            this.miniMizeBtn1.BackColor = System.Drawing.Color.Transparent;
            this.miniMizeBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniMizeBtn1.Image = ((System.Drawing.Image)(resources.GetObject("miniMizeBtn1.Image")));
            this.miniMizeBtn1.ImageActive = null;
            this.miniMizeBtn1.Location = new System.Drawing.Point(207, 6);
            this.miniMizeBtn1.Name = "miniMizeBtn1";
            this.miniMizeBtn1.Size = new System.Drawing.Size(27, 36);
            this.miniMizeBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miniMizeBtn1.TabIndex = 99;
            this.miniMizeBtn1.TabStop = false;
            this.miniMizeBtn1.Visible = false;
            this.miniMizeBtn1.Zoom = 10;
            this.miniMizeBtn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.miniMizeBtn1_MouseClick);
            // 
            // closeBtn1
            // 
            this.closeBtn1.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn1.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn1.Image")));
            this.closeBtn1.ImageActive = null;
            this.closeBtn1.Location = new System.Drawing.Point(240, 12);
            this.closeBtn1.Name = "closeBtn1";
            this.closeBtn1.Size = new System.Drawing.Size(27, 23);
            this.closeBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn1.TabIndex = 98;
            this.closeBtn1.TabStop = false;
            this.closeBtn1.Visible = false;
            this.closeBtn1.Zoom = 10;
            this.closeBtn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn1_MouseClick);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.Location = new System.Drawing.Point(225, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(133, 18);
            this.linkLabel2.TabIndex = 104;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Switch to Phase One";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(225, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 18);
            this.linkLabel1.TabIndex = 102;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Switch to Phase Two";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1278, 702);
            this.panel3.TabIndex = 2;
            // 
            // PhaseLabel
            // 
            this.PhaseLabel.AutoSize = true;
            this.PhaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhaseLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhaseLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PhaseLabel.Location = new System.Drawing.Point(526, 49);
            this.PhaseLabel.Name = "PhaseLabel";
            this.PhaseLabel.Size = new System.Drawing.Size(0, 18);
            this.PhaseLabel.TabIndex = 105;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 772);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mimimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMizeBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuImageButton mimimizeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton saveDataBtn;
        private Bunifu.Framework.UI.BunifuImageButton refreshBtn;
        private System.Windows.Forms.ComboBox changeTheme;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuImageButton miniMizeBtn1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label PhaseLabel;
    }
}

