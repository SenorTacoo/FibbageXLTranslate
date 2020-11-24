namespace FibbageQEdit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showShortieQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFinalQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.OriginalQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslatedQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pEditable = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pSuggestions = new System.Windows.Forms.Panel();
            this.rtbTranslatedSuggestions = new System.Windows.Forms.RichTextBox();
            this.rtbOrgSuggestions = new System.Windows.Forms.RichTextBox();
            this.lSuggestion = new System.Windows.Forms.Label();
            this.pAlternateSpellings = new System.Windows.Forms.Panel();
            this.rtbTranslatedAlternateSpelling = new System.Windows.Forms.RichTextBox();
            this.rtbOrgAlternateSpelling = new System.Windows.Forms.RichTextBox();
            this.lAlternateSpelling = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.pCorrectAnswers = new System.Windows.Forms.Panel();
            this.rtbTranslatedCorrectAnswer = new System.Windows.Forms.RichTextBox();
            this.rtbOrgCorrectAnswer = new System.Windows.Forms.RichTextBox();
            this.lCorrectAnswer = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.pQuestions = new System.Windows.Forms.Panel();
            this.rtbTranslatedQuestion = new System.Windows.Forms.RichTextBox();
            this.rtbOrgQuestion = new System.Windows.Forms.RichTextBox();
            this.lQuestion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.pEditable.SuspendLayout();
            this.pSuggestions.SuspendLayout();
            this.pAlternateSpellings.SuspendLayout();
            this.pCorrectAnswers.SuspendLayout();
            this.pQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showShortieQuestionsToolStripMenuItem,
            this.showFinalQuestionsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // showShortieQuestionsToolStripMenuItem
            // 
            this.showShortieQuestionsToolStripMenuItem.Name = "showShortieQuestionsToolStripMenuItem";
            this.showShortieQuestionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.showShortieQuestionsToolStripMenuItem.Text = "Show shortie questions";
            this.showShortieQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ShowShortieQuestionsToolStripMenuItem_Click);
            // 
            // showFinalQuestionsToolStripMenuItem
            // 
            this.showFinalQuestionsToolStripMenuItem.Name = "showFinalQuestionsToolStripMenuItem";
            this.showFinalQuestionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.showFinalQuestionsToolStripMenuItem.Text = "Show final questions";
            this.showFinalQuestionsToolStripMenuItem.Click += new System.EventHandler(this.ShowFinalQuestionsToolStripMenuItem_Click);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuestions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalQuestion,
            this.TranslatedQuestion});
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestions.Location = new System.Drawing.Point(0, 24);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(802, 261);
            this.dgvQuestions.StandardTab = true;
            this.dgvQuestions.TabIndex = 0;
            this.dgvQuestions.TabStop = false;
            this.dgvQuestions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvQuestions_RowEnter);
            this.dgvQuestions.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvQuestions_RowLeave);
            this.dgvQuestions.SelectionChanged += new System.EventHandler(this.DgvQuestions_SelectionChanged);
            // 
            // OriginalQuestion
            // 
            this.OriginalQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OriginalQuestion.DataPropertyName = "OriginalQuestion";
            this.OriginalQuestion.HeaderText = "Original question";
            this.OriginalQuestion.Name = "OriginalQuestion";
            this.OriginalQuestion.ReadOnly = true;
            // 
            // TranslatedQuestion
            // 
            this.TranslatedQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TranslatedQuestion.DataPropertyName = "TranslatedQuestion";
            this.TranslatedQuestion.HeaderText = "Translated question";
            this.TranslatedQuestion.Name = "TranslatedQuestion";
            this.TranslatedQuestion.ReadOnly = true;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 285);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(802, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.Splitter1_SplitterMoved);
            // 
            // pEditable
            // 
            this.pEditable.Controls.Add(this.splitter2);
            this.pEditable.Controls.Add(this.pSuggestions);
            this.pEditable.Controls.Add(this.pAlternateSpellings);
            this.pEditable.Controls.Add(this.splitter3);
            this.pEditable.Controls.Add(this.pCorrectAnswers);
            this.pEditable.Controls.Add(this.splitter4);
            this.pEditable.Controls.Add(this.pQuestions);
            this.pEditable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pEditable.Location = new System.Drawing.Point(0, 288);
            this.pEditable.Name = "pEditable";
            this.pEditable.Size = new System.Drawing.Size(802, 162);
            this.pEditable.TabIndex = 0;
            this.pEditable.Visible = false;
            this.pEditable.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PEditable_PreviewKeyDown);
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Location = new System.Drawing.Point(584, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 162);
            this.splitter2.TabIndex = 14;
            this.splitter2.TabStop = false;
            // 
            // pSuggestions
            // 
            this.pSuggestions.Controls.Add(this.rtbTranslatedSuggestions);
            this.pSuggestions.Controls.Add(this.rtbOrgSuggestions);
            this.pSuggestions.Controls.Add(this.lSuggestion);
            this.pSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSuggestions.Location = new System.Drawing.Point(584, 0);
            this.pSuggestions.Name = "pSuggestions";
            this.pSuggestions.Padding = new System.Windows.Forms.Padding(3);
            this.pSuggestions.Size = new System.Drawing.Size(218, 162);
            this.pSuggestions.TabIndex = 3;
            // 
            // rtbTranslatedSuggestions
            // 
            this.rtbTranslatedSuggestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTranslatedSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTranslatedSuggestions.Location = new System.Drawing.Point(3, 97);
            this.rtbTranslatedSuggestions.Name = "rtbTranslatedSuggestions";
            this.rtbTranslatedSuggestions.Size = new System.Drawing.Size(212, 62);
            this.rtbTranslatedSuggestions.TabIndex = 0;
            this.rtbTranslatedSuggestions.Text = "";
            this.rtbTranslatedSuggestions.TextChanged += new System.EventHandler(this.RtbTranslatedSuggestions_TextChanged);
            this.rtbTranslatedSuggestions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessKeyPressed);
            // 
            // rtbOrgSuggestions
            // 
            this.rtbOrgSuggestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOrgSuggestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbOrgSuggestions.Location = new System.Drawing.Point(3, 16);
            this.rtbOrgSuggestions.Margin = new System.Windows.Forms.Padding(20);
            this.rtbOrgSuggestions.Name = "rtbOrgSuggestions";
            this.rtbOrgSuggestions.ReadOnly = true;
            this.rtbOrgSuggestions.Size = new System.Drawing.Size(212, 81);
            this.rtbOrgSuggestions.TabIndex = 0;
            this.rtbOrgSuggestions.TabStop = false;
            this.rtbOrgSuggestions.Text = "";
            this.rtbOrgSuggestions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessKeyPressed);
            // 
            // lSuggestion
            // 
            this.lSuggestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSuggestion.Location = new System.Drawing.Point(3, 3);
            this.lSuggestion.Name = "lSuggestion";
            this.lSuggestion.Size = new System.Drawing.Size(212, 13);
            this.lSuggestion.TabIndex = 1;
            this.lSuggestion.Text = "Suggestions";
            this.lSuggestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pAlternateSpellings
            // 
            this.pAlternateSpellings.Controls.Add(this.rtbTranslatedAlternateSpelling);
            this.pAlternateSpellings.Controls.Add(this.rtbOrgAlternateSpelling);
            this.pAlternateSpellings.Controls.Add(this.lAlternateSpelling);
            this.pAlternateSpellings.Dock = System.Windows.Forms.DockStyle.Left;
            this.pAlternateSpellings.Location = new System.Drawing.Point(384, 0);
            this.pAlternateSpellings.Name = "pAlternateSpellings";
            this.pAlternateSpellings.Padding = new System.Windows.Forms.Padding(3);
            this.pAlternateSpellings.Size = new System.Drawing.Size(200, 162);
            this.pAlternateSpellings.TabIndex = 2;
            // 
            // rtbTranslatedAlternateSpelling
            // 
            this.rtbTranslatedAlternateSpelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTranslatedAlternateSpelling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTranslatedAlternateSpelling.Location = new System.Drawing.Point(3, 97);
            this.rtbTranslatedAlternateSpelling.Name = "rtbTranslatedAlternateSpelling";
            this.rtbTranslatedAlternateSpelling.Size = new System.Drawing.Size(194, 62);
            this.rtbTranslatedAlternateSpelling.TabIndex = 0;
            this.rtbTranslatedAlternateSpelling.Text = "";
            this.rtbTranslatedAlternateSpelling.TextChanged += new System.EventHandler(this.RtbTranslatedAlternateSpelling_TextChanged);
            this.rtbTranslatedAlternateSpelling.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessKeyPressed);
            // 
            // rtbOrgAlternateSpelling
            // 
            this.rtbOrgAlternateSpelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOrgAlternateSpelling.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbOrgAlternateSpelling.Location = new System.Drawing.Point(3, 16);
            this.rtbOrgAlternateSpelling.Margin = new System.Windows.Forms.Padding(20);
            this.rtbOrgAlternateSpelling.Name = "rtbOrgAlternateSpelling";
            this.rtbOrgAlternateSpelling.ReadOnly = true;
            this.rtbOrgAlternateSpelling.Size = new System.Drawing.Size(194, 81);
            this.rtbOrgAlternateSpelling.TabIndex = 0;
            this.rtbOrgAlternateSpelling.TabStop = false;
            this.rtbOrgAlternateSpelling.Text = "";
            this.rtbOrgAlternateSpelling.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessKeyPressed);
            // 
            // lAlternateSpelling
            // 
            this.lAlternateSpelling.Dock = System.Windows.Forms.DockStyle.Top;
            this.lAlternateSpelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAlternateSpelling.Location = new System.Drawing.Point(3, 3);
            this.lAlternateSpelling.Name = "lAlternateSpelling";
            this.lAlternateSpelling.Size = new System.Drawing.Size(194, 13);
            this.lAlternateSpelling.TabIndex = 2;
            this.lAlternateSpelling.Text = "Alternate spelling";
            this.lAlternateSpelling.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter3
            // 
            this.splitter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter3.Location = new System.Drawing.Point(381, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 162);
            this.splitter3.TabIndex = 16;
            this.splitter3.TabStop = false;
            // 
            // pCorrectAnswers
            // 
            this.pCorrectAnswers.Controls.Add(this.rtbTranslatedCorrectAnswer);
            this.pCorrectAnswers.Controls.Add(this.rtbOrgCorrectAnswer);
            this.pCorrectAnswers.Controls.Add(this.lCorrectAnswer);
            this.pCorrectAnswers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCorrectAnswers.Location = new System.Drawing.Point(253, 0);
            this.pCorrectAnswers.Name = "pCorrectAnswers";
            this.pCorrectAnswers.Padding = new System.Windows.Forms.Padding(3);
            this.pCorrectAnswers.Size = new System.Drawing.Size(128, 162);
            this.pCorrectAnswers.TabIndex = 1;
            // 
            // rtbTranslatedCorrectAnswer
            // 
            this.rtbTranslatedCorrectAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTranslatedCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTranslatedCorrectAnswer.Location = new System.Drawing.Point(3, 97);
            this.rtbTranslatedCorrectAnswer.Name = "rtbTranslatedCorrectAnswer";
            this.rtbTranslatedCorrectAnswer.Size = new System.Drawing.Size(122, 62);
            this.rtbTranslatedCorrectAnswer.TabIndex = 0;
            this.rtbTranslatedCorrectAnswer.Text = "";
            this.rtbTranslatedCorrectAnswer.TextChanged += new System.EventHandler(this.RtbTranslatedCorrectAnswer_TextChanged);
            this.rtbTranslatedCorrectAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessKeyPressed);
            // 
            // rtbOrgCorrectAnswer
            // 
            this.rtbOrgCorrectAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOrgCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbOrgCorrectAnswer.Location = new System.Drawing.Point(3, 16);
            this.rtbOrgCorrectAnswer.Margin = new System.Windows.Forms.Padding(20);
            this.rtbOrgCorrectAnswer.Name = "rtbOrgCorrectAnswer";
            this.rtbOrgCorrectAnswer.ReadOnly = true;
            this.rtbOrgCorrectAnswer.Size = new System.Drawing.Size(122, 81);
            this.rtbOrgCorrectAnswer.TabIndex = 0;
            this.rtbOrgCorrectAnswer.TabStop = false;
            this.rtbOrgCorrectAnswer.Text = "";
            this.rtbOrgCorrectAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessKeyPressed);
            // 
            // lCorrectAnswer
            // 
            this.lCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCorrectAnswer.Location = new System.Drawing.Point(3, 3);
            this.lCorrectAnswer.Name = "lCorrectAnswer";
            this.lCorrectAnswer.Size = new System.Drawing.Size(122, 13);
            this.lCorrectAnswer.TabIndex = 2;
            this.lCorrectAnswer.Text = "Correct answer";
            this.lCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter4
            // 
            this.splitter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter4.Location = new System.Drawing.Point(250, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 162);
            this.splitter4.TabIndex = 15;
            this.splitter4.TabStop = false;
            // 
            // pQuestions
            // 
            this.pQuestions.Controls.Add(this.rtbTranslatedQuestion);
            this.pQuestions.Controls.Add(this.rtbOrgQuestion);
            this.pQuestions.Controls.Add(this.lQuestion);
            this.pQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pQuestions.Location = new System.Drawing.Point(0, 0);
            this.pQuestions.Name = "pQuestions";
            this.pQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.pQuestions.Size = new System.Drawing.Size(250, 162);
            this.pQuestions.TabIndex = 0;
            // 
            // rtbTranslatedQuestion
            // 
            this.rtbTranslatedQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTranslatedQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTranslatedQuestion.Location = new System.Drawing.Point(3, 97);
            this.rtbTranslatedQuestion.Name = "rtbTranslatedQuestion";
            this.rtbTranslatedQuestion.Size = new System.Drawing.Size(244, 62);
            this.rtbTranslatedQuestion.TabIndex = 0;
            this.rtbTranslatedQuestion.Text = "";
            this.rtbTranslatedQuestion.TextChanged += new System.EventHandler(this.RtbTranslatedQuestion_TextChanged);
            this.rtbTranslatedQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessKeyPressed);
            // 
            // rtbOrgQuestion
            // 
            this.rtbOrgQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOrgQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbOrgQuestion.Location = new System.Drawing.Point(3, 16);
            this.rtbOrgQuestion.Margin = new System.Windows.Forms.Padding(20);
            this.rtbOrgQuestion.Name = "rtbOrgQuestion";
            this.rtbOrgQuestion.ReadOnly = true;
            this.rtbOrgQuestion.Size = new System.Drawing.Size(244, 81);
            this.rtbOrgQuestion.TabIndex = 0;
            this.rtbOrgQuestion.TabStop = false;
            this.rtbOrgQuestion.Text = "";
            this.rtbOrgQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessKeyPressed);
            // 
            // lQuestion
            // 
            this.lQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lQuestion.Location = new System.Drawing.Point(3, 3);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(244, 13);
            this.lQuestion.TabIndex = 2;
            this.lQuestion.Text = "Question";
            this.lQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pEditable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Fibbage questions editor";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.pEditable.ResumeLayout(false);
            this.pSuggestions.ResumeLayout(false);
            this.pAlternateSpellings.ResumeLayout(false);
            this.pCorrectAnswers.ResumeLayout(false);
            this.pQuestions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslatedQuestion;
        private System.Windows.Forms.Panel pEditable;
        private System.Windows.Forms.RichTextBox rtbOrgQuestion;
        private System.Windows.Forms.RichTextBox rtbOrgSuggestions;
        private System.Windows.Forms.RichTextBox rtbOrgCorrectAnswer;
        private System.Windows.Forms.RichTextBox rtbOrgAlternateSpelling;
        private System.Windows.Forms.RichTextBox rtbTranslatedQuestion;
        private System.Windows.Forms.RichTextBox rtbTranslatedSuggestions;
        private System.Windows.Forms.RichTextBox rtbTranslatedCorrectAnswer;
        private System.Windows.Forms.RichTextBox rtbTranslatedAlternateSpelling;
        private System.Windows.Forms.Panel pCorrectAnswers;
        private System.Windows.Forms.Panel pQuestions;
        private System.Windows.Forms.Panel pSuggestions;
        private System.Windows.Forms.Panel pAlternateSpellings;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showShortieQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFinalQuestionsToolStripMenuItem;
        private System.Windows.Forms.Label lSuggestion;
        private System.Windows.Forms.Label lAlternateSpelling;
        private System.Windows.Forms.Label lCorrectAnswer;
        private System.Windows.Forms.Label lQuestion;
    }
}

