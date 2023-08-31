using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CatchWarnings
{
    public partial class SearchingForm : Form
    {
        public SearchingForm()
        {
            InitializeComponent();
        }

        //Describing Variables/Lists
        List<string> csFiles = new List<string>();


        //ResultModel newModel = new ResultModel() { FilePath="asd",MatchedLine=""};
        List<ResultModel> resultModels = new List<ResultModel>();
        ResultModel newModel = new ResultModel();


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );

        //button radius
        private void SearchingForm_Load(object sender, EventArgs e)
        {
            PathBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PathBtn.Width, PathBtn.Height, 30, 30));
            FindBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FindBtn.Width, PathBtn.Height, 30, 30));
        }


        //Button to find path
        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {

                PathNameTB.Text = dialog.FileName;

            }


        }

        //Button to start search operation in path
        private void FindBtn_Click(object sender, EventArgs e)
        {
            csFiles = SearchCSFiles(PathNameTB.Text);

            dataGridView1.DataSource = csFiles;

            matchSelectedFiles(csFiles);

        }

        //Searching cs files and return path
        private static List<string> SearchCSFiles(string folderPath)
        {
            List<string> csFiles = new List<string>();

            if (folderPath.Equals(""))
            {
                MessageBox.Show("Select a file!");
            }
            else
            {
                string[] files = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    csFiles.Add(file);
                }

            }
            return csFiles;


        }

        //Analyze cs files with given pattern
        private void matchSelectedFiles(List<string> csFiles)
        {
            List<ResultModel> resultModels = new List<ResultModel>();
            //string pattern = @"BaseException\([^)]*\)\s*(?!.*Exception)";
            string pattern = @"BaseException\(([^)]*?)\)";

            for (int i = 0; i < csFiles.Count; i++)
            {
                string content = File.ReadAllText(csFiles[i]);


                MatchCollection matchs = Regex.Matches(content, pattern, RegexOptions.Multiline);

                foreach (Match match in matchs)
                {
                    string extractedContent = match.Groups[1].Value;

                    if (!extractedContent.Contains("ExceptionTypes"))
                    {
                        int lineNumber;
                        ResultModel newModel = new ResultModel();
                        newModel.LineContent = match.Value;
                        newModel.FileName = csFiles[i];
                        lineNumber = getMatchedLineWithNumber(content, match);
                        newModel.LineNumber = lineNumber;
                        resultModels.Add(newModel);
                    }

                }
            }
            dataGridView1.DataSource = resultModels;



        }

        //return line number that include pattern
        private static int getMatchedLineWithNumber(string content, Match match)
        {

            int matchStartIndex = match.Index;
            int lineStartIndex = content.LastIndexOf('\n', matchStartIndex) + 1;

            int currentLineNumber = content.Substring(0, lineStartIndex).Count(c => c == '\n') + 1;


            return currentLineNumber;
        }

    }

}
