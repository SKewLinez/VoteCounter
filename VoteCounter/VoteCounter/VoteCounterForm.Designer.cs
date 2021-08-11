
namespace VoteCounter
{
    partial class VoteCounterForm
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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.tlpRemoveCandidates = new System.Windows.Forms.TableLayoutPanel();
            this.rbCoin = new System.Windows.Forms.RadioButton();
            this.lbCandidatesLowest = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveOne = new ePOSOne.btnProduct.Button_WOC();
            this.btnRemoveAll = new ePOSOne.btnProduct.Button_WOC();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.msFile = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbOriginal = new System.Windows.Forms.RadioButton();
            this.rbSequential = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFile = new System.Windows.Forms.Label();
            this.VoteButton = new ePOSOne.btnProduct.Button_WOC();
            this.btnShowResults = new ePOSOne.btnProduct.Button_WOC();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpRemoveCandidates.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.msFile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.ResultTextBox.Location = new System.Drawing.Point(43, 167);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(466, 291);
            this.ResultTextBox.TabIndex = 0;
            // 
            // tlpRemoveCandidates
            // 
            this.tlpRemoveCandidates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpRemoveCandidates.ColumnCount = 1;
            this.tlpRemoveCandidates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRemoveCandidates.Controls.Add(this.rbCoin, 0, 0);
            this.tlpRemoveCandidates.Controls.Add(this.lbCandidatesLowest, 0, 2);
            this.tlpRemoveCandidates.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tlpRemoveCandidates.Controls.Add(this.rbUser, 0, 1);
            this.tlpRemoveCandidates.Location = new System.Drawing.Point(83, 218);
            this.tlpRemoveCandidates.Name = "tlpRemoveCandidates";
            this.tlpRemoveCandidates.RowCount = 4;
            this.tlpRemoveCandidates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpRemoveCandidates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpRemoveCandidates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tlpRemoveCandidates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpRemoveCandidates.Size = new System.Drawing.Size(466, 323);
            this.tlpRemoveCandidates.TabIndex = 2;
            // 
            // rbCoin
            // 
            this.rbCoin.AutoSize = true;
            this.rbCoin.Checked = true;
            this.rbCoin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.rbCoin.Location = new System.Drawing.Point(3, 3);
            this.rbCoin.Name = "rbCoin";
            this.rbCoin.Size = new System.Drawing.Size(152, 19);
            this.rbCoin.TabIndex = 0;
            this.rbCoin.TabStop = true;
            this.rbCoin.Text = "Random coin toss";
            this.rbCoin.UseVisualStyleBackColor = true;
            // 
            // lbCandidatesLowest
            // 
            this.lbCandidatesLowest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lbCandidatesLowest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCandidatesLowest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCandidatesLowest.Enabled = false;
            this.lbCandidatesLowest.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCandidatesLowest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.lbCandidatesLowest.FormattingEnabled = true;
            this.lbCandidatesLowest.ItemHeight = 20;
            this.lbCandidatesLowest.Location = new System.Drawing.Point(3, 60);
            this.lbCandidatesLowest.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lbCandidatesLowest.Name = "lbCandidatesLowest";
            this.lbCandidatesLowest.Size = new System.Drawing.Size(460, 222);
            this.lbCandidatesLowest.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.45454F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.54546F));
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveOne, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveAll, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 288);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 32);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveOne.AutoSize = true;
            this.btnRemoveOne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveOne.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnRemoveOne.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnRemoveOne.Enabled = false;
            this.btnRemoveOne.FlatAppearance.BorderSize = 0;
            this.btnRemoveOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnRemoveOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnRemoveOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOne.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveOne.Location = new System.Drawing.Point(297, 0);
            this.btnRemoveOne.Margin = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnRemoveOne.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnRemoveOne.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemoveOne.Size = new System.Drawing.Size(163, 32);
            this.btnRemoveOne.TabIndex = 50;
            this.btnRemoveOne.Text = "Remove One";
            this.btnRemoveOne.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            this.btnRemoveOne.Click += new System.EventHandler(this.btnRemoveOne_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.AutoSize = true;
            this.btnRemoveAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnRemoveAll.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnRemoveAll.Enabled = false;
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnRemoveAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveAll.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(0, 0, 70, 0);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnRemoveAll.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnRemoveAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemoveAll.Size = new System.Drawing.Size(157, 32);
            this.btnRemoveAll.TabIndex = 49;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.rbUser.Location = new System.Drawing.Point(3, 28);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(116, 19);
            this.rbUser.TabIndex = 1;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "User decides";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // msFile
            // 
            this.msFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(75)))));
            this.msFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.msFile.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msFile.Location = new System.Drawing.Point(0, 0);
            this.msFile.Name = "msFile";
            this.msFile.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msFile.Size = new System.Drawing.Size(1196, 28);
            this.msFile.TabIndex = 45;
            this.msFile.Text = "msFile";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Exit});
            this.Menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(44, 24);
            this.Menu.Text = "File";
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFiles});
            this.Open.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(120, 26);
            this.Open.Text = "Open";
            // 
            // OpenFiles
            // 
            this.OpenFiles.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenFiles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenFiles.Name = "OpenFiles";
            this.OpenFiles.Size = new System.Drawing.Size(123, 26);
            this.OpenFiles.Text = "File(s)";
            this.OpenFiles.Click += new System.EventHandler(this.OpenFiles_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 26);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rbOriginal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbSequential, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(83, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 54);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // rbOriginal
            // 
            this.rbOriginal.AutoSize = true;
            this.rbOriginal.Checked = true;
            this.rbOriginal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.rbOriginal.Location = new System.Drawing.Point(3, 3);
            this.rbOriginal.Name = "rbOriginal";
            this.rbOriginal.Size = new System.Drawing.Size(83, 21);
            this.rbOriginal.TabIndex = 0;
            this.rbOriginal.TabStop = true;
            this.rbOriginal.Text = "Original";
            this.rbOriginal.UseVisualStyleBackColor = true;
            // 
            // rbSequential
            // 
            this.rbSequential.AutoSize = true;
            this.rbSequential.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSequential.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.rbSequential.Location = new System.Drawing.Point(3, 30);
            this.rbSequential.Name = "rbSequential";
            this.rbSequential.Size = new System.Drawing.Size(104, 21);
            this.rbSequential.TabIndex = 1;
            this.rbSequential.TabStop = true;
            this.rbSequential.Text = "Sequential";
            this.rbSequential.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 50);
            this.label1.TabIndex = 47;
            this.label1.Text = "Choose the validation method of votes:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 28);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1196, 90);
            this.pnTitle.TabIndex = 48;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(459, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Voting System";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 118);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1196, 590);
            this.tableLayoutPanel3.TabIndex = 49;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lblFile, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ResultTextBox, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.VoteButton, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnShowResults, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(601, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(40, 40, 80, 40);
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.88889F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.3254F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.07143F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(592, 584);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.lblFile.Location = new System.Drawing.Point(43, 40);
            this.lblFile.MaximumSize = new System.Drawing.Size(466, 50);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(466, 50);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "No file has been selected yet.";
            // 
            // VoteButton
            // 
            this.VoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VoteButton.AutoSize = true;
            this.VoteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VoteButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.VoteButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.VoteButton.Enabled = false;
            this.VoteButton.FlatAppearance.BorderSize = 0;
            this.VoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.VoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.VoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoteButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VoteButton.Location = new System.Drawing.Point(43, 105);
            this.VoteButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.VoteButton.MaximumSize = new System.Drawing.Size(0, 40);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.VoteButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.VoteButton.OnHoverTextColor = System.Drawing.Color.White;
            this.VoteButton.Size = new System.Drawing.Size(466, 40);
            this.VoteButton.TabIndex = 4;
            this.VoteButton.Text = "Run Vote";
            this.VoteButton.TextColor = System.Drawing.Color.WhiteSmoke;
            this.VoteButton.UseVisualStyleBackColor = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // btnShowResults
            // 
            this.btnShowResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResults.AutoSize = true;
            this.btnShowResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowResults.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnShowResults.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnShowResults.Enabled = false;
            this.btnShowResults.FlatAppearance.BorderSize = 0;
            this.btnShowResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnShowResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.btnShowResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowResults.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResults.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowResults.Location = new System.Drawing.Point(340, 481);
            this.btnShowResults.Margin = new System.Windows.Forms.Padding(300, 20, 3, 10);
            this.btnShowResults.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnShowResults.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnShowResults.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowResults.Size = new System.Drawing.Size(169, 40);
            this.btnShowResults.TabIndex = 5;
            this.btnShowResults.Text = "Show Results";
            this.btnShowResults.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tlpRemoveCandidates, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(80, 40, 40, 40);
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(592, 584);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(194)))));
            this.label3.Location = new System.Drawing.Point(83, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 65);
            this.label3.TabIndex = 48;
            this.label3.Text = "Choose the method of removing candidate(s) with the same lowest votes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // VoteCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1196, 708);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.msFile);
            this.Name = "VoteCounterForm";
            this.Text = "Vote Counter";
            this.tlpRemoveCandidates.ResumeLayout(false);
            this.tlpRemoveCandidates.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.msFile.ResumeLayout(false);
            this.msFile.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TableLayoutPanel tlpRemoveCandidates;
        private System.Windows.Forms.RadioButton rbCoin;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.ListBox lbCandidatesLowest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.MenuStrip msFile;
        internal System.Windows.Forms.ToolStripMenuItem Menu;
        internal System.Windows.Forms.ToolStripMenuItem Open;
        internal System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem OpenFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rbSequential;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private VoteCounter.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC VoteButton;
        private ePOSOne.btnProduct.Button_WOC btnRemoveAll;
        private ePOSOne.btnProduct.Button_WOC btnRemoveOne;
        private ePOSOne.btnProduct.Button_WOC btnShowResults;
    }
}

