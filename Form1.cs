using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            // start creating the PDF file
            Document docPDFResults = new Document();
            Section sectionMain = docPDFResults.AddSection();
            
            // instantiate data class for dummy data
            ComponentChecklist componentChecklist = new ComponentChecklist();

            try
            {
                int count = 0;
                Boolean isTestContinuing = true;
                Form2 form = new Form2();

                // load values into the form
                txtbxMachine.Text = componentChecklist.Machine;
                txtbxIDNumber.Text = componentChecklist.IDNum;

                // start creating the PDF document
                Paragraph paragraphTest = sectionMain.AddParagraph();
                paragraphTest.AddText("Test Results: " + txtbxMachine.Text + ", ID Number: " + txtbxIDNumber.Text + "\n" + System.DateTime.Now.ToString() + "\n\n");

                while ((count < componentChecklist.TestsAndDirections.Length / 2) && (isTestContinuing == true))
                {
                    // get test
                    txtbxTest.Text = componentChecklist.TestsAndDirections[count, 0];
                    form.testValue = componentChecklist.TestsAndDirections[count, 0];

                    // get directions
                    txtbxDirection.Text = componentChecklist.TestsAndDirections[count, 1];


                    DialogResult result = form.ShowDialog();


                    if (result == DialogResult.Yes)
                    {
                        // the test result passed...
                        string strPassResult = "PASSED: " + txtbxTest.Text;

                        // result is in the listbox...
                        displayResult(strPassResult);

                        // and in the PDF document
                        MigraDoc.DocumentObjectModel.Color colorGreen = MigraDoc.DocumentObjectModel.Color.FromCmyk(100, 0, 100, 50);

                        addResultToPDF(sectionMain, colorGreen, strPassResult);

                        count++;
                    }
                    else if (result == DialogResult.No)
                    {
                        // the test result failed...
                        string strFailResult = "FAILED: " + txtbxTest.Text;

                        // listbox result
                        displayResult(strFailResult);

                        // PDF document result
                        MigraDoc.DocumentObjectModel.Color colorRed = MigraDoc.DocumentObjectModel.Color.FromCmyk(0, 100, 100, 0);

                        addResultToPDF(sectionMain, colorRed, strFailResult);

                        count++;
                    }
                    else if (result == DialogResult.Ignore)
                    {
                        // this test was skipped...
                        string strSkipResult = "SKIPPED: " + txtbxTest.Text;

                        // listbox result
                        displayResult(strSkipResult);

                        // PDF document result
                        MigraDoc.DocumentObjectModel.Color colorBlack = MigraDoc.DocumentObjectModel.Color.FromCmyk(0, 0, 0, 100);

                        addResultToPDF(sectionMain, colorBlack, strSkipResult);

                        count++;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // the entire test suite was canceled
                        string strCancelResult = "CANCELED: " + txtbxTest.Text;

                        // listbox result
                        displayResult(strCancelResult);

                        // PDF document result
                        MigraDoc.DocumentObjectModel.Color colorBlack = MigraDoc.DocumentObjectModel.Color.FromCmyk(0, 0, 0, 100);

                        addResultToPDF(sectionMain, colorBlack, strCancelResult);

                        isTestContinuing = false;
                    }
                }

                disableButtons();

                // finish PDF document
                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();

                pdfRenderer.Document = docPDFResults;

                pdfRenderer.RenderDocument();

                string filename = "TestResults.pdf";

                pdfRenderer.PdfDocument.Save(filename);

                Process.Start(filename);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.ToString());
            }
        }

        private void btnStopTest_Click(object sender, EventArgs e)
        {
            // this doesn't seem necessary, but this is what I put in the original program
            MessageBox.Show("Test stopped.", "Test Halted", MessageBoxButtons.OK);

            disableButtons();
        }

        public void displayResult(string strResult)
        {
            lstbxResults.Items.Add(strResult);
        }

        public void disableButtons()
        {
            // this is to disable the Start and Stop buttons on the main/first form to indicate testing has finished,
            // although there are better and much more graceful ways of doing this
            btnStartTest.Enabled = false;
            btnStopTest.Enabled = false;
        }

        public void addResultToPDF(Section section, MigraDoc.DocumentObjectModel.Color color, string txtResult)
        {
            // as each result is displayed in the listbox, also put the result into the PDF document too
            Paragraph paragraphTestResult = section.AddParagraph();
            paragraphTestResult.Format.Font.Color = color;
            paragraphTestResult.AddFormattedText(txtResult, TextFormat.Bold);
        }
    }
}
