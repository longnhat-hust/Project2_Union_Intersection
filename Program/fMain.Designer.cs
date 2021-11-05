namespace Project2_UniInt
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txbLink1 = new System.Windows.Forms.TextBox();
            this.btnBrowser1 = new System.Windows.Forms.Button();
            this.txbPreview1 = new System.Windows.Forms.TextBox();
            this.txbLink2 = new System.Windows.Forms.TextBox();
            this.txbPreview2 = new System.Windows.Forms.TextBox();
            this.btnBrowser2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 204;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.txbResult);
            this.splitContainer1.Panel2.Controls.Add(this.btnUnion);
            this.splitContainer1.Panel2.Controls.Add(this.btnInt);
            this.splitContainer1.Panel2MinSize = 120;
            this.splitContainer1.Size = new System.Drawing.Size(1386, 643);
            this.splitContainer1.SplitterDistance = 868;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txbLink1);
            this.splitContainer2.Panel1.Controls.Add(this.btnBrowser1);
            this.splitContainer2.Panel1.Controls.Add(this.txbPreview1);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txbLink2);
            this.splitContainer2.Panel2.Controls.Add(this.txbPreview2);
            this.splitContainer2.Panel2.Controls.Add(this.btnBrowser2);
            this.splitContainer2.Panel2MinSize = 100;
            this.splitContainer2.Size = new System.Drawing.Size(868, 643);
            this.splitContainer2.SplitterDistance = 409;
            this.splitContainer2.TabIndex = 0;
            // 
            // txbLink1
            // 
            this.txbLink1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLink1.BackColor = System.Drawing.Color.Black;
            this.txbLink1.Font = new System.Drawing.Font("Linh Avenir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLink1.ForeColor = System.Drawing.Color.White;
            this.txbLink1.Location = new System.Drawing.Point(104, 5);
            this.txbLink1.Name = "txbLink1";
            this.txbLink1.Size = new System.Drawing.Size(302, 26);
            this.txbLink1.TabIndex = 0;
            this.txbLink1.TextChanged += new System.EventHandler(this.txbLink1_TextChanged);
            // 
            // btnBrowser1
            // 
            this.btnBrowser1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrowser1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBrowser1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrowser1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser1.Font = new System.Drawing.Font("HelveticaNeue MediumCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser1.ForeColor = System.Drawing.Color.Black;
            this.btnBrowser1.Location = new System.Drawing.Point(3, 3);
            this.btnBrowser1.Name = "btnBrowser1";
            this.btnBrowser1.Size = new System.Drawing.Size(95, 29);
            this.btnBrowser1.TabIndex = 1;
            this.btnBrowser1.Text = "Browser";
            this.btnBrowser1.UseVisualStyleBackColor = false;
            this.btnBrowser1.Click += new System.EventHandler(this.btnBrowser1_Click);
            // 
            // txbPreview1
            // 
            this.txbPreview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPreview1.BackColor = System.Drawing.Color.Black;
            this.txbPreview1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreview1.ForeColor = System.Drawing.Color.Lime;
            this.txbPreview1.Location = new System.Drawing.Point(3, 37);
            this.txbPreview1.Multiline = true;
            this.txbPreview1.Name = "txbPreview1";
            this.txbPreview1.ReadOnly = true;
            this.txbPreview1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbPreview1.Size = new System.Drawing.Size(403, 603);
            this.txbPreview1.TabIndex = 10;
            // 
            // txbLink2
            // 
            this.txbLink2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLink2.BackColor = System.Drawing.Color.Black;
            this.txbLink2.Font = new System.Drawing.Font("Linh Avenir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLink2.ForeColor = System.Drawing.Color.White;
            this.txbLink2.Location = new System.Drawing.Point(104, 5);
            this.txbLink2.Name = "txbLink2";
            this.txbLink2.Size = new System.Drawing.Size(348, 26);
            this.txbLink2.TabIndex = 2;
            this.txbLink2.TextChanged += new System.EventHandler(this.txbLink2_TextChanged);
            // 
            // txbPreview2
            // 
            this.txbPreview2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPreview2.BackColor = System.Drawing.Color.Black;
            this.txbPreview2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreview2.ForeColor = System.Drawing.Color.Lime;
            this.txbPreview2.Location = new System.Drawing.Point(3, 37);
            this.txbPreview2.Multiline = true;
            this.txbPreview2.Name = "txbPreview2";
            this.txbPreview2.ReadOnly = true;
            this.txbPreview2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbPreview2.Size = new System.Drawing.Size(449, 603);
            this.txbPreview2.TabIndex = 9;
            // 
            // btnBrowser2
            // 
            this.btnBrowser2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrowser2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBrowser2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrowser2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser2.Font = new System.Drawing.Font("HelveticaNeue MediumCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser2.ForeColor = System.Drawing.Color.Black;
            this.btnBrowser2.Location = new System.Drawing.Point(3, 3);
            this.btnBrowser2.Name = "btnBrowser2";
            this.btnBrowser2.Size = new System.Drawing.Size(95, 29);
            this.btnBrowser2.TabIndex = 3;
            this.btnBrowser2.Text = "Browser";
            this.btnBrowser2.UseVisualStyleBackColor = false;
            this.btnBrowser2.Click += new System.EventHandler(this.btnBrowser2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("HelveticaNeue MediumCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(3, 600);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(508, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbResult
            // 
            this.txbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbResult.BackColor = System.Drawing.Color.Black;
            this.txbResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResult.ForeColor = System.Drawing.Color.Lime;
            this.txbResult.Location = new System.Drawing.Point(3, 95);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbResult.Size = new System.Drawing.Size(508, 499);
            this.txbResult.TabIndex = 8;
            // 
            // btnUnion
            // 
            this.btnUnion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUnion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnion.Font = new System.Drawing.Font("HelveticaNeue MediumCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnion.ForeColor = System.Drawing.Color.Black;
            this.btnUnion.Location = new System.Drawing.Point(3, 3);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(508, 40);
            this.btnUnion.TabIndex = 4;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = false;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnInt
            // 
            this.btnInt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInt.Font = new System.Drawing.Font("HelveticaNeue MediumCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.ForeColor = System.Drawing.Color.Black;
            this.btnInt.Location = new System.Drawing.Point(3, 49);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(508, 40);
            this.btnInt.TabIndex = 5;
            this.btnInt.Text = "Intersection";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1386, 643);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(345, 223);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project2_UniInt";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txbLink1;
        private System.Windows.Forms.Button btnBrowser1;
        private System.Windows.Forms.TextBox txbPreview1;
        private System.Windows.Forms.TextBox txbLink2;
        private System.Windows.Forms.TextBox txbPreview2;
        private System.Windows.Forms.Button btnBrowser2;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txbResult;
    }
}

