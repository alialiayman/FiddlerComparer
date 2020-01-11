namespace onSoft
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dfsUrlLeft = new System.Windows.Forms.TextBox();
            this.dfsUrlRight = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dfsHeaderLeft = new System.Windows.Forms.TextBox();
            this.dfsHeaderRight = new System.Windows.Forms.TextBox();
            this.dfsBodyLeft = new System.Windows.Forms.TextBox();
            this.dfsBodyRight = new System.Windows.Forms.TextBox();
            this.dfsBodyRightOriginal = new System.Windows.Forms.TextBox();
            this.dfsBodyLeftOriginal = new System.Windows.Forms.TextBox();
            this.dfsHeaderLeftOriginal = new System.Windows.Forms.TextBox();
            this.dfsHeaderRightOriginal = new System.Windows.Forms.TextBox();
            this.dfsUrlLeftOriginal = new System.Windows.Forms.TextBox();
            this.dfsUrlRightOriginal = new System.Windows.Forms.TextBox();
            this.btnAgain = new System.Windows.Forms.Button();
            this.tabCompare = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUrlEncodedCompare = new System.Windows.Forms.Button();
            this.lblSession1 = new System.Windows.Forms.Label();
            this.lblSession2Id = new System.Windows.Forms.Label();
            this.grbBodies = new System.Windows.Forms.GroupBox();
            this.lblRightBodyStats = new System.Windows.Forms.Label();
            this.lblLeftBodyStats = new System.Windows.Forms.Label();
            this.grbUrl = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbBodiesOriginal = new System.Windows.Forms.GroupBox();
            this.grbHeadersOriginal = new System.Windows.Forms.GroupBox();
            this.grbUrlOriginal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dfsDelimeters = new System.Windows.Forms.TextBox();
            this.btnRemoveObvious = new System.Windows.Forms.Button();
            this.dfsGivenName1 = new System.Windows.Forms.TextBox();
            this.dfsGivenName2 = new System.Windows.Forms.TextBox();
            this.tabCompare.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbBodies.SuspendLayout();
            this.grbUrl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grbBodiesOriginal.SuspendLayout();
            this.grbHeadersOriginal.SuspendLayout();
            this.grbUrlOriginal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dfsUrlLeft
            // 
            this.dfsUrlLeft.Location = new System.Drawing.Point(6, 17);
            this.dfsUrlLeft.Multiline = true;
            this.dfsUrlLeft.Name = "dfsUrlLeft";
            this.dfsUrlLeft.Size = new System.Drawing.Size(467, 20);
            this.dfsUrlLeft.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dfsUrlLeft, "use {} to add url segments and notice the code change");
            // 
            // dfsUrlRight
            // 
            this.dfsUrlRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsUrlRight.Location = new System.Drawing.Point(675, 17);
            this.dfsUrlRight.Name = "dfsUrlRight";
            this.dfsUrlRight.Size = new System.Drawing.Size(499, 20);
            this.dfsUrlRight.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dfsUrlRight, "Change output class");
            // 
            // dfsHeaderLeft
            // 
            this.dfsHeaderLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dfsHeaderLeft.Location = new System.Drawing.Point(15, 84);
            this.dfsHeaderLeft.Multiline = true;
            this.dfsHeaderLeft.Name = "dfsHeaderLeft";
            this.dfsHeaderLeft.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsHeaderLeft.Size = new System.Drawing.Size(467, 381);
            this.dfsHeaderLeft.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dfsHeaderLeft, "use {} to add url segments and notice the code change");
            // 
            // dfsHeaderRight
            // 
            this.dfsHeaderRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsHeaderRight.Location = new System.Drawing.Point(684, 84);
            this.dfsHeaderRight.Multiline = true;
            this.dfsHeaderRight.Name = "dfsHeaderRight";
            this.dfsHeaderRight.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsHeaderRight.Size = new System.Drawing.Size(502, 381);
            this.dfsHeaderRight.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dfsHeaderRight, "Change output class");
            // 
            // dfsBodyLeft
            // 
            this.dfsBodyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dfsBodyLeft.Location = new System.Drawing.Point(6, 19);
            this.dfsBodyLeft.Multiline = true;
            this.dfsBodyLeft.Name = "dfsBodyLeft";
            this.dfsBodyLeft.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsBodyLeft.Size = new System.Drawing.Size(474, 134);
            this.dfsBodyLeft.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dfsBodyLeft, "use {} to add url segments and notice the code change");
            // 
            // dfsBodyRight
            // 
            this.dfsBodyRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsBodyRight.Location = new System.Drawing.Point(678, 17);
            this.dfsBodyRight.Multiline = true;
            this.dfsBodyRight.Name = "dfsBodyRight";
            this.dfsBodyRight.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsBodyRight.Size = new System.Drawing.Size(499, 134);
            this.dfsBodyRight.TabIndex = 11;
            this.toolTip1.SetToolTip(this.dfsBodyRight, "Change output class");
            // 
            // dfsBodyRightOriginal
            // 
            this.dfsBodyRightOriginal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dfsBodyRightOriginal.Location = new System.Drawing.Point(541, 19);
            this.dfsBodyRightOriginal.Multiline = true;
            this.dfsBodyRightOriginal.Name = "dfsBodyRightOriginal";
            this.dfsBodyRightOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsBodyRightOriginal.Size = new System.Drawing.Size(515, 134);
            this.dfsBodyRightOriginal.TabIndex = 11;
            this.toolTip1.SetToolTip(this.dfsBodyRightOriginal, "Change output class");
            // 
            // dfsBodyLeftOriginal
            // 
            this.dfsBodyLeftOriginal.Location = new System.Drawing.Point(6, 19);
            this.dfsBodyLeftOriginal.Multiline = true;
            this.dfsBodyLeftOriginal.Name = "dfsBodyLeftOriginal";
            this.dfsBodyLeftOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsBodyLeftOriginal.Size = new System.Drawing.Size(515, 134);
            this.dfsBodyLeftOriginal.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dfsBodyLeftOriginal, "use {} to add url segments and notice the code change");
            // 
            // dfsHeaderLeftOriginal
            // 
            this.dfsHeaderLeftOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dfsHeaderLeftOriginal.Location = new System.Drawing.Point(6, 19);
            this.dfsHeaderLeftOriginal.Multiline = true;
            this.dfsHeaderLeftOriginal.Name = "dfsHeaderLeftOriginal";
            this.dfsHeaderLeftOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsHeaderLeftOriginal.Size = new System.Drawing.Size(515, 207);
            this.dfsHeaderLeftOriginal.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dfsHeaderLeftOriginal, "use {} to add url segments and notice the code change");
            // 
            // dfsHeaderRightOriginal
            // 
            this.dfsHeaderRightOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dfsHeaderRightOriginal.Location = new System.Drawing.Point(538, 19);
            this.dfsHeaderRightOriginal.Multiline = true;
            this.dfsHeaderRightOriginal.Name = "dfsHeaderRightOriginal";
            this.dfsHeaderRightOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsHeaderRightOriginal.Size = new System.Drawing.Size(515, 207);
            this.dfsHeaderRightOriginal.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dfsHeaderRightOriginal, "Change output class");
            // 
            // dfsUrlLeftOriginal
            // 
            this.dfsUrlLeftOriginal.Location = new System.Drawing.Point(6, 17);
            this.dfsUrlLeftOriginal.Multiline = true;
            this.dfsUrlLeftOriginal.Name = "dfsUrlLeftOriginal";
            this.dfsUrlLeftOriginal.Size = new System.Drawing.Size(515, 20);
            this.dfsUrlLeftOriginal.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dfsUrlLeftOriginal, "use {} to add url segments and notice the code change");
            // 
            // dfsUrlRightOriginal
            // 
            this.dfsUrlRightOriginal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dfsUrlRightOriginal.Location = new System.Drawing.Point(538, 17);
            this.dfsUrlRightOriginal.Name = "dfsUrlRightOriginal";
            this.dfsUrlRightOriginal.Size = new System.Drawing.Size(515, 20);
            this.dfsUrlRightOriginal.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dfsUrlRightOriginal, "Change output class");
            // 
            // btnAgain
            // 
            this.btnAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgain.Location = new System.Drawing.Point(1080, 672);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(103, 23);
            this.btnAgain.TabIndex = 9;
            this.btnAgain.Text = "Re-Compare";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // tabCompare
            // 
            this.tabCompare.Controls.Add(this.tabPage1);
            this.tabCompare.Controls.Add(this.tabPage2);
            this.tabCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCompare.Location = new System.Drawing.Point(0, 0);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.SelectedIndex = 0;
            this.tabCompare.Size = new System.Drawing.Size(1203, 727);
            this.tabCompare.TabIndex = 14;
            this.tabCompare.SelectedIndexChanged += new System.EventHandler(this.tabCompare_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dfsGivenName1);
            this.tabPage1.Controls.Add(this.lblSession1);
            this.tabPage1.Controls.Add(this.dfsGivenName2);
            this.tabPage1.Controls.Add(this.lblSession2Id);
            this.tabPage1.Controls.Add(this.btnRemoveObvious);
            this.tabPage1.Controls.Add(this.dfsDelimeters);
            this.tabPage1.Controls.Add(this.dfsHeaderLeft);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnUrlEncodedCompare);
            this.tabPage1.Controls.Add(this.dfsHeaderRight);
            this.tabPage1.Controls.Add(this.grbBodies);
            this.tabPage1.Controls.Add(this.grbUrl);
            this.tabPage1.Controls.Add(this.btnAgain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1195, 701);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Differences";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUrlEncodedCompare
            // 
            this.btnUrlEncodedCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUrlEncodedCompare.Location = new System.Drawing.Point(458, 672);
            this.btnUrlEncodedCompare.Name = "btnUrlEncodedCompare";
            this.btnUrlEncodedCompare.Size = new System.Drawing.Size(81, 23);
            this.btnUrlEncodedCompare.TabIndex = 18;
            this.btnUrlEncodedCompare.Text = "Replace";
            this.btnUrlEncodedCompare.UseVisualStyleBackColor = true;
            this.btnUrlEncodedCompare.Click += new System.EventHandler(this.btnUrlEncodedCompare_Click);
            // 
            // lblSession1
            // 
            this.lblSession1.AutoSize = true;
            this.lblSession1.Location = new System.Drawing.Point(15, 65);
            this.lblSession1.Name = "lblSession1";
            this.lblSession1.Size = new System.Drawing.Size(49, 13);
            this.lblSession1.TabIndex = 17;
            this.lblSession1.Text = "Session1";
            // 
            // lblSession2Id
            // 
            this.lblSession2Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSession2Id.AutoSize = true;
            this.lblSession2Id.Location = new System.Drawing.Point(1028, 65);
            this.lblSession2Id.Name = "lblSession2Id";
            this.lblSession2Id.Size = new System.Drawing.Size(49, 13);
            this.lblSession2Id.TabIndex = 16;
            this.lblSession2Id.Text = "Session2";
            // 
            // grbBodies
            // 
            this.grbBodies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBodies.BackColor = System.Drawing.Color.PaleGreen;
            this.grbBodies.Controls.Add(this.lblRightBodyStats);
            this.grbBodies.Controls.Add(this.lblLeftBodyStats);
            this.grbBodies.Controls.Add(this.dfsBodyRight);
            this.grbBodies.Controls.Add(this.dfsBodyLeft);
            this.grbBodies.Location = new System.Drawing.Point(6, 498);
            this.grbBodies.Name = "grbBodies";
            this.grbBodies.Size = new System.Drawing.Size(1183, 168);
            this.grbBodies.TabIndex = 15;
            this.grbBodies.TabStop = false;
            this.grbBodies.Text = "BODIES";
            // 
            // lblRightBodyStats
            // 
            this.lblRightBodyStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRightBodyStats.AutoSize = true;
            this.lblRightBodyStats.Location = new System.Drawing.Point(1071, 154);
            this.lblRightBodyStats.Name = "lblRightBodyStats";
            this.lblRightBodyStats.Size = new System.Drawing.Size(109, 13);
            this.lblRightBodyStats.TabIndex = 14;
            this.lblRightBodyStats.Text = "0 Lines, 0 Characters";
            // 
            // lblLeftBodyStats
            // 
            this.lblLeftBodyStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftBodyStats.AutoSize = true;
            this.lblLeftBodyStats.Location = new System.Drawing.Point(9, 154);
            this.lblLeftBodyStats.Name = "lblLeftBodyStats";
            this.lblLeftBodyStats.Size = new System.Drawing.Size(109, 13);
            this.lblLeftBodyStats.TabIndex = 13;
            this.lblLeftBodyStats.Text = "0 Lines, 0 Characters";
            // 
            // grbUrl
            // 
            this.grbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbUrl.BackColor = System.Drawing.Color.PaleGreen;
            this.grbUrl.Controls.Add(this.dfsUrlLeft);
            this.grbUrl.Controls.Add(this.dfsUrlRight);
            this.grbUrl.Location = new System.Drawing.Point(9, 13);
            this.grbUrl.Name = "grbUrl";
            this.grbUrl.Size = new System.Drawing.Size(1180, 47);
            this.grbUrl.TabIndex = 14;
            this.grbUrl.TabStop = false;
            this.grbUrl.Text = "URL";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grbBodiesOriginal);
            this.tabPage2.Controls.Add(this.grbHeadersOriginal);
            this.tabPage2.Controls.Add(this.grbUrlOriginal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1074, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Original";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grbBodiesOriginal
            // 
            this.grbBodiesOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBodiesOriginal.BackColor = System.Drawing.Color.PaleGreen;
            this.grbBodiesOriginal.Controls.Add(this.dfsBodyRightOriginal);
            this.grbBodiesOriginal.Controls.Add(this.dfsBodyLeftOriginal);
            this.grbBodiesOriginal.Location = new System.Drawing.Point(6, 308);
            this.grbBodiesOriginal.Name = "grbBodiesOriginal";
            this.grbBodiesOriginal.Size = new System.Drawing.Size(1062, 168);
            this.grbBodiesOriginal.TabIndex = 18;
            this.grbBodiesOriginal.TabStop = false;
            this.grbBodiesOriginal.Text = "BODIES";
            // 
            // grbHeadersOriginal
            // 
            this.grbHeadersOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbHeadersOriginal.BackColor = System.Drawing.Color.Transparent;
            this.grbHeadersOriginal.Controls.Add(this.dfsHeaderLeftOriginal);
            this.grbHeadersOriginal.Controls.Add(this.dfsHeaderRightOriginal);
            this.grbHeadersOriginal.Location = new System.Drawing.Point(6, 70);
            this.grbHeadersOriginal.Name = "grbHeadersOriginal";
            this.grbHeadersOriginal.Size = new System.Drawing.Size(1059, 232);
            this.grbHeadersOriginal.TabIndex = 17;
            this.grbHeadersOriginal.TabStop = false;
            this.grbHeadersOriginal.Text = "HEADERS";
            // 
            // grbUrlOriginal
            // 
            this.grbUrlOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbUrlOriginal.BackColor = System.Drawing.Color.PaleGreen;
            this.grbUrlOriginal.Controls.Add(this.dfsUrlLeftOriginal);
            this.grbUrlOriginal.Controls.Add(this.dfsUrlRightOriginal);
            this.grbUrlOriginal.Location = new System.Drawing.Point(6, 17);
            this.grbUrlOriginal.Name = "grbUrlOriginal";
            this.grbUrlOriginal.Size = new System.Drawing.Size(1059, 47);
            this.grbUrlOriginal.TabIndex = 16;
            this.grbUrlOriginal.TabStop = false;
            this.grbUrlOriginal.Text = "URL";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "With new line";
            // 
            // dfsDelimeters
            // 
            this.dfsDelimeters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dfsDelimeters.Location = new System.Drawing.Point(545, 672);
            this.dfsDelimeters.Name = "dfsDelimeters";
            this.dfsDelimeters.Size = new System.Drawing.Size(114, 20);
            this.dfsDelimeters.TabIndex = 20;
            this.dfsDelimeters.Text = ";&";
            // 
            // btnRemoveObvious
            // 
            this.btnRemoveObvious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveObvious.Location = new System.Drawing.Point(9, 672);
            this.btnRemoveObvious.Name = "btnRemoveObvious";
            this.btnRemoveObvious.Size = new System.Drawing.Size(137, 23);
            this.btnRemoveObvious.TabIndex = 21;
            this.btnRemoveObvious.Text = "Remove Obvious";
            this.btnRemoveObvious.UseVisualStyleBackColor = true;
            this.btnRemoveObvious.Click += new System.EventHandler(this.btnRemoveObvious_Click);
            // 
            // dfsGivenName1
            // 
            this.dfsGivenName1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::onSoft.Properties.Settings.Default, "givenName1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsGivenName1.Location = new System.Drawing.Point(79, 61);
            this.dfsGivenName1.Name = "dfsGivenName1";
            this.dfsGivenName1.Size = new System.Drawing.Size(100, 20);
            this.dfsGivenName1.TabIndex = 18;
            this.dfsGivenName1.Text = global::onSoft.Properties.Settings.Default.givenName1;
            this.dfsGivenName1.Leave += new System.EventHandler(this.dfsGivenName1_Leave);
            // 
            // dfsGivenName2
            // 
            this.dfsGivenName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsGivenName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::onSoft.Properties.Settings.Default, "givenName2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsGivenName2.Location = new System.Drawing.Point(1083, 61);
            this.dfsGivenName2.Name = "dfsGivenName2";
            this.dfsGivenName2.Size = new System.Drawing.Size(100, 20);
            this.dfsGivenName2.TabIndex = 19;
            this.dfsGivenName2.Text = global::onSoft.Properties.Settings.Default.givenName2;
            this.dfsGivenName2.Leave += new System.EventHandler(this.dfsGivenName2_Leave);
            // 
            // UserControl1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCompare);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1203, 727);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UserControl1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UserControl1_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.UserControl1_DragOver);
            this.tabCompare.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grbBodies.ResumeLayout(false);
            this.grbBodies.PerformLayout();
            this.grbUrl.ResumeLayout(false);
            this.grbUrl.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grbBodiesOriginal.ResumeLayout(false);
            this.grbBodiesOriginal.PerformLayout();
            this.grbHeadersOriginal.ResumeLayout(false);
            this.grbHeadersOriginal.PerformLayout();
            this.grbUrlOriginal.ResumeLayout(false);
            this.grbUrlOriginal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox dfsUrlRight;
        private System.Windows.Forms.TextBox dfsUrlLeft;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox dfsHeaderLeft;
        private System.Windows.Forms.TextBox dfsHeaderRight;
        private System.Windows.Forms.TextBox dfsBodyLeft;
        private System.Windows.Forms.TextBox dfsBodyRight;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.TabControl tabCompare;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbBodies;
        private System.Windows.Forms.GroupBox grbUrl;
        private System.Windows.Forms.GroupBox grbBodiesOriginal;
        private System.Windows.Forms.TextBox dfsBodyRightOriginal;
        private System.Windows.Forms.TextBox dfsBodyLeftOriginal;
        private System.Windows.Forms.GroupBox grbHeadersOriginal;
        private System.Windows.Forms.TextBox dfsHeaderLeftOriginal;
        private System.Windows.Forms.TextBox dfsHeaderRightOriginal;
        private System.Windows.Forms.GroupBox grbUrlOriginal;
        private System.Windows.Forms.TextBox dfsUrlLeftOriginal;
        private System.Windows.Forms.TextBox dfsUrlRightOriginal;
        private System.Windows.Forms.Label lblRightBodyStats;
        private System.Windows.Forms.Label lblLeftBodyStats;
        private System.Windows.Forms.Label lblSession1;
        private System.Windows.Forms.Label lblSession2Id;
        private System.Windows.Forms.Button btnUrlEncodedCompare;
        private System.Windows.Forms.TextBox dfsDelimeters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dfsGivenName2;
        private System.Windows.Forms.TextBox dfsGivenName1;
        private System.Windows.Forms.Button btnRemoveObvious;
    }
}
