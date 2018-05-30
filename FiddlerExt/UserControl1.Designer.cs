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
            this.label3 = new System.Windows.Forms.Label();
            this.dfsUrlLeft = new System.Windows.Forms.TextBox();
            this.dfsUrlRight = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dfsHeaderLeft = new System.Windows.Forms.TextBox();
            this.dfsHeaderRight = new System.Windows.Forms.TextBox();
            this.dfsBodyLeft = new System.Windows.Forms.TextBox();
            this.dfsBodyRight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.tabCompare = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dfsLeftUrlOriginal = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dfsRightUrlOriginal = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabCompare.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Url";
            // 
            // dfsUrlLeft
            // 
            this.dfsUrlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsUrlLeft.Location = new System.Drawing.Point(41, 4);
            this.dfsUrlLeft.Multiline = true;
            this.dfsUrlLeft.Name = "dfsUrlLeft";
            this.dfsUrlLeft.Size = new System.Drawing.Size(502, 24);
            this.dfsUrlLeft.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dfsUrlLeft, "use {} to add url segments and notice the code change");
            // 
            // dfsUrlRight
            // 
            this.dfsUrlRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsUrlRight.Location = new System.Drawing.Point(549, 6);
            this.dfsUrlRight.Name = "dfsUrlRight";
            this.dfsUrlRight.Size = new System.Drawing.Size(513, 20);
            this.dfsUrlRight.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dfsUrlRight, "Change output class");
            // 
            // dfsHeaderLeft
            // 
            this.dfsHeaderLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsHeaderLeft.Location = new System.Drawing.Point(41, 79);
            this.dfsHeaderLeft.Multiline = true;
            this.dfsHeaderLeft.Name = "dfsHeaderLeft";
            this.dfsHeaderLeft.Size = new System.Drawing.Size(502, 145);
            this.dfsHeaderLeft.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dfsHeaderLeft, "use {} to add url segments and notice the code change");
            // 
            // dfsHeaderRight
            // 
            this.dfsHeaderRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsHeaderRight.Location = new System.Drawing.Point(549, 79);
            this.dfsHeaderRight.Multiline = true;
            this.dfsHeaderRight.Name = "dfsHeaderRight";
            this.dfsHeaderRight.Size = new System.Drawing.Size(513, 145);
            this.dfsHeaderRight.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dfsHeaderRight, "Change output class");
            // 
            // dfsBodyLeft
            // 
            this.dfsBodyLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsBodyLeft.Location = new System.Drawing.Point(41, 252);
            this.dfsBodyLeft.Multiline = true;
            this.dfsBodyLeft.Name = "dfsBodyLeft";
            this.dfsBodyLeft.Size = new System.Drawing.Size(502, 246);
            this.dfsBodyLeft.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dfsBodyLeft, "use {} to add url segments and notice the code change");
            // 
            // dfsBodyRight
            // 
            this.dfsBodyRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsBodyRight.Location = new System.Drawing.Point(549, 252);
            this.dfsBodyRight.Multiline = true;
            this.dfsBodyRight.Name = "dfsBodyRight";
            this.dfsBodyRight.Size = new System.Drawing.Size(513, 246);
            this.dfsBodyRight.TabIndex = 11;
            this.toolTip1.SetToolTip(this.dfsBodyRight, "Change output class");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Headers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Body";
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(41, 34);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(103, 23);
            this.btnAgain.TabIndex = 9;
            this.btnAgain.Text = "Compare Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            // 
            // tabCompare
            // 
            this.tabCompare.Controls.Add(this.tabPage1);
            this.tabCompare.Controls.Add(this.tabPage2);
            this.tabCompare.Location = new System.Drawing.Point(3, 3);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.SelectedIndex = 0;
            this.tabCompare.Size = new System.Drawing.Size(1076, 530);
            this.tabCompare.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAgain);
            this.tabPage1.Controls.Add(this.dfsUrlLeft);
            this.tabPage1.Controls.Add(this.dfsHeaderLeft);
            this.tabPage1.Controls.Add(this.dfsBodyRight);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dfsUrlRight);
            this.tabPage1.Controls.Add(this.dfsHeaderRight);
            this.tabPage1.Controls.Add(this.dfsBodyLeft);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Differences";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dfsLeftUrlOriginal);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.dfsRightUrlOriginal);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Original";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Url";
            // 
            // dfsLeftUrlOriginal
            // 
            this.dfsLeftUrlOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsLeftUrlOriginal.Location = new System.Drawing.Point(41, 5);
            this.dfsLeftUrlOriginal.Multiline = true;
            this.dfsLeftUrlOriginal.Name = "dfsLeftUrlOriginal";
            this.dfsLeftUrlOriginal.Size = new System.Drawing.Size(502, 24);
            this.dfsLeftUrlOriginal.TabIndex = 14;
            this.toolTip1.SetToolTip(this.dfsLeftUrlOriginal, "use {} to add url segments and notice the code change");
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(41, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(502, 145);
            this.textBox2.TabIndex = 17;
            this.toolTip1.SetToolTip(this.textBox2, "use {} to add url segments and notice the code change");
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(549, 253);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(513, 246);
            this.textBox3.TabIndex = 18;
            this.toolTip1.SetToolTip(this.textBox3, "Change output class");
            // 
            // dfsRightUrlOriginal
            // 
            this.dfsRightUrlOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsRightUrlOriginal.Location = new System.Drawing.Point(549, 7);
            this.dfsRightUrlOriginal.Name = "dfsRightUrlOriginal";
            this.dfsRightUrlOriginal.Size = new System.Drawing.Size(513, 20);
            this.dfsRightUrlOriginal.TabIndex = 13;
            this.toolTip1.SetToolTip(this.dfsRightUrlOriginal, "Change output class");
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(549, 80);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(513, 145);
            this.textBox5.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBox5, "Change output class");
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(41, 253);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(502, 246);
            this.textBox6.TabIndex = 19;
            this.toolTip1.SetToolTip(this.textBox6, "use {} to add url segments and notice the code change");
            // 
            // UserControl1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCompare);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1082, 533);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UserControl1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UserControl1_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.UserControl1_DragOver);
            this.tabCompare.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox dfsUrlRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dfsUrlLeft;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox dfsHeaderLeft;
        private System.Windows.Forms.TextBox dfsHeaderRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dfsBodyLeft;
        private System.Windows.Forms.TextBox dfsBodyRight;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.TabControl tabCompare;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dfsLeftUrlOriginal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox dfsRightUrlOriginal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}
