namespace Level02
{
    partial class Form1
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
            this.tbstart = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInvestPeerMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboutput = new System.Windows.Forms.ListBox();
            this.ctMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.ctMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbstart
            // 
            this.tbstart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbstart.Location = new System.Drawing.Point(68, 420);
            this.tbstart.Name = "tbstart";
            this.tbstart.Size = new System.Drawing.Size(147, 20);
            this.tbstart.TabIndex = 1;
            this.tbstart.Enter += new System.EventHandler(this.tbstart_Enter);
            this.tbstart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbstart_KeyPress);
            this.tbstart.Leave += new System.EventHandler(this.tbstart_Leave);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search.Location = new System.Drawing.Point(564, 419);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "&Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "เงินตั้งต้น";
            // 
            // tbInvestPeerMonth
            // 
            this.tbInvestPeerMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbInvestPeerMonth.Location = new System.Drawing.Point(347, 420);
            this.tbInvestPeerMonth.Name = "tbInvestPeerMonth";
            this.tbInvestPeerMonth.Size = new System.Drawing.Size(147, 20);
            this.tbInvestPeerMonth.TabIndex = 3;
            this.tbInvestPeerMonth.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.tbInvestPeerMonth.Enter += new System.EventHandler(this.tbInvestPeerMonth_Enter);
            this.tbInvestPeerMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInvestPeerMonth_KeyPress);
            this.tbInvestPeerMonth.Leave += new System.EventHandler(this.tbInvestPeerMonth_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "เงินลงทุนต่อเดือน";
            // 
            // lboutput
            // 
            this.lboutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboutput.ContextMenuStrip = this.ctMenuStrip;
            this.lboutput.FormattingEnabled = true;
            this.lboutput.HorizontalScrollbar = true;
            this.lboutput.Location = new System.Drawing.Point(23, 23);
            this.lboutput.Name = "lboutput";
            this.lboutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboutput.Size = new System.Drawing.Size(752, 394);
            this.lboutput.TabIndex = 5;
            this.lboutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lboutput_KeyPress);
            // 
            // ctMenuStrip
            // 
            this.ctMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctCopy,
            this.ctSelect});
            this.ctMenuStrip.Name = "ctMenuStrip";
            this.ctMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // ctCopy
            // 
            this.ctCopy.Image = global::Level02.Properties.Resources.HRMI8;
            this.ctCopy.Name = "ctCopy";
            this.ctCopy.Size = new System.Drawing.Size(180, 22);
            this.ctCopy.Text = "Copy to Clipboard";
            this.ctCopy.Click += new System.EventHandler(this.ctCopy_Click);
            // 
            // ctSelect
            // 
            this.ctSelect.Image = global::Level02.Properties.Resources.HRMI8_Blue;
            this.ctSelect.Name = "ctSelect";
            this.ctSelect.Size = new System.Drawing.Size(180, 22);
            this.ctSelect.Text = "Select all Row";
            this.ctSelect.Click += new System.EventHandler(this.ctSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lboutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInvestPeerMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ctMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbstart;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInvestPeerMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboutput;
        private System.Windows.Forms.ContextMenuStrip ctMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctCopy;
        private System.Windows.Forms.ToolStripMenuItem ctSelect;
    }
}

