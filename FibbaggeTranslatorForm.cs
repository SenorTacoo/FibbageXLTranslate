using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibbageQEdit
{
    public partial class frmMain : Form
    {
        private FibbageData FFibbageContent;
        private TranslateData FEditQuestion;
        public frmMain()
        {
            InitializeComponent();
            dgvQuestions.AutoGenerateColumns = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new CommonOpenFileDialog();
            fd.IsFolderPicker = true;
            if (fd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (ProcessLoadDataFromDirectory(fd.FileName))
                {
                    AppConfig.Configuration.LastUsedPath = fd.FileName;
                    AppConfig.Configuration.SaveDataToFile();
                }
            }
        }

        private bool ProcessLoadDataFromDirectory(string aDirectory)
        {
            try
            {
                FFibbageContent = new FibbageData(aDirectory);
                dgvQuestions.DataSource = FFibbageContent.GetShortiesToTranslate();
                pEditable.Visible = true;
                return true;
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void log(string aText)
        {
            /* var timeNow = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:fff");
             if (String.IsNullOrEmpty(rtbLogs.Text))
                 rtbLogs.AppendText(timeNow + ":::" + aText);
             else
                 rtbLogs.AppendText(Environment.NewLine + timeNow + ":::" + aText);

             rtbLogs.ScrollToCaret();*/
        }

        private void LbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void DgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            log("asd");
        }

        private void DgvQuestions_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rtbOrgQuestion.Visible = dgvQuestions.DataSource != null;
            rtbTranslatedQuestion.Visible = dgvQuestions.DataSource != null;

            rtbOrgSuggestions.Visible = dgvQuestions.DataSource != null;
            rtbTranslatedSuggestions.Visible = dgvQuestions.DataSource != null;

            rtbOrgCorrectAnswer.Visible = dgvQuestions.DataSource != null;
            rtbTranslatedCorrectAnswer.Visible = dgvQuestions.DataSource != null;

            rtbOrgAlternateSpelling.Visible = dgvQuestions.DataSource != null;
            rtbTranslatedAlternateSpelling.Visible = dgvQuestions.DataSource != null;

            if (dgvQuestions.DataSource != null)
            {
                MultiTranslateData dataList = (MultiTranslateData)dgvQuestions.DataSource;
                FEditQuestion = dataList[e.RowIndex];
                ProcessShowEditQuestion();
            }
        }

        private void ProcessShowEditQuestion()
        {
            rtbOrgQuestion.Text = FEditQuestion.OriginalQuestion;
            rtbTranslatedQuestion.Text = FEditQuestion.TranslatedQuestion;

            rtbOrgSuggestions.Text = FEditQuestion.OriginalSuggestion;
            rtbTranslatedSuggestions.Text = FEditQuestion.TranslatedSuggestion;

            rtbOrgCorrectAnswer.Text = FEditQuestion.OriginalCorrectAnswer;
            rtbTranslatedCorrectAnswer.Text = FEditQuestion.TranslatedCorrectAnswer;

            rtbOrgAlternateSpelling.Text = FEditQuestion.OriginalAlternateSpelling;
            rtbTranslatedAlternateSpelling.Text = FEditQuestion.TranslatedAlternateSpelling;

            MultiTranslateData src = (MultiTranslateData) dgvQuestions.DataSource;
            var translated = 0;
            foreach (var single in src)
            {
                if (((single.OriginalQuestion == "") || (single.TranslatedQuestion != "")) &&
                   ((single.OriginalCorrectAnswer == "") || (single.TranslatedCorrectAnswer != "")) &&
                   ((single.OriginalSuggestion == "") || (single.TranslatedSuggestion != "")))
                   translated++;
            }
            lTranslated.Text = string.Format("Translated {0} out of {1} {2:0.00}%", translated, src.Count, Decimal.Divide(translated * 100, src.Count));
        }

        private void RtbTranslatedQuestion_TextChanged(object sender, EventArgs e)
        {
            if (FEditQuestion != null)
            {
                FEditQuestion.TranslatedQuestion = rtbTranslatedQuestion.Text;
            }
        }

        private void DgvQuestions_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvQuestions.Refresh();
        }

        private void RtbTranslatedSuggestions_TextChanged(object sender, EventArgs e)
        {
            if (FEditQuestion != null)
            {
                FEditQuestion.TranslatedSuggestion = rtbTranslatedSuggestions.Text;
            }
        }

        private void RtbTranslatedCorrectAnswer_TextChanged(object sender, EventArgs e)
        {
            if (FEditQuestion != null)
            {
                FEditQuestion.TranslatedCorrectAnswer = rtbTranslatedCorrectAnswer.Text;
            }
        }

        private void RtbTranslatedAlternateSpelling_TextChanged(object sender, EventArgs e)
        {
            if (FEditQuestion != null)
            {
                FEditQuestion.TranslatedAlternateSpelling = rtbTranslatedAlternateSpelling.Text;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (AppConfig.Configuration.LastUsedPath != "")
                if (Directory.Exists(AppConfig.Configuration.LastUsedPath)) {
                    ProcessLoadDataFromDirectory(AppConfig.Configuration.LastUsedPath);
                }
        }

        private void ShowShortieQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvQuestions.DataSource = FFibbageContent.GetShortiesToTranslate();
        }

        private void ShowFinalQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvQuestions.DataSource = FFibbageContent.GetFinalToTranslate();
        }
 
        private void PEditable_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void ProcessKeyPressed(object sender, KeyEventArgs e)
        {
            if (dgvQuestions.SelectedCells.Count == 0)
                return;

            if (e.Control && ((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down)))
            {
                e.Handled = true;
                int currentRowindex = dgvQuestions.SelectedCells[0].OwningRow.Index;

                int newRowIndex = currentRowindex + (e.KeyCode == Keys.Up ? -1 : 1);

                if (newRowIndex > -1 && newRowIndex < dgvQuestions.Rows.Count)
                {
                    dgvQuestions.ClearSelection();
                    dgvQuestions.Rows[newRowIndex].Selected = true;
                    if (newRowIndex < 5)
                        dgvQuestions.FirstDisplayedScrollingRowIndex = newRowIndex;
                    else
                        dgvQuestions.FirstDisplayedScrollingRowIndex = newRowIndex - 5;

                    DgvQuestions_RowEnter(sender, new DataGridViewCellEventArgs(0, newRowIndex));
                    rtbTranslatedQuestion.Focus();
                }
            } else if (e.Control && e.KeyCode == Keys.Q)
            {
                FEditQuestion.TranslatedAlternateSpelling = FEditQuestion.OriginalAlternateSpelling;
                FEditQuestion.TranslatedCorrectAnswer = FEditQuestion.OriginalCorrectAnswer;
                FEditQuestion.TranslatedQuestion = FEditQuestion.OriginalQuestion;
                FEditQuestion.TranslatedSuggestion = FEditQuestion.OriginalSuggestion;
                ProcessShowEditQuestion();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FFibbageContent.SaveToFile();
        }
    }
}
