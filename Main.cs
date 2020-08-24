using BnsDatTool;
using BnsDatTool.lib;
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

namespace BnSTranslator
{
    public partial class Main : Form
    {

        OpenFileDialog TranslationOfileDat = new OpenFileDialog();
        FolderBrowserDialog TranslationOfolderDat = new FolderBrowserDialog();

        OpenFileDialog TranslationOSourceFile = new OpenFileDialog();
        OpenFileDialog TranslationOMergeFile = new OpenFileDialog();
        //
        public BackgroundWorker multiworker;
        //
        private string TranslationDatPath;//path of local.dat
        private string TranslationlocaldatName;//file name only
        private string TranslationlocalOutPath;//path where the files will be extracted
        private string TranslationBinFile;//that's it

        private string TranslationExportFile;//translation.xml file that will be generated
        private string TranslationFilePath;//path where translation.xml will be saved
        private string TranslateRepackPath;//
        private string TranslationSourceFile;//file from where the translation will be read
        private string TranslationTargetFile;//file that will be translated

        //
        public bool TranslationDatIs64 = false;
        public bool TranslateIs64 = false;
        //
        TextWriter _writer = null;
        public static string Lkstr;

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            _writer = new StrWriter(richOut);
            Console.SetOut(_writer);
        }
        private void BtnSearchLocal_Click(object sender, EventArgs e)
        {
            if (TranslationOfileDat.ShowDialog() != DialogResult.OK)
                return;

            TxbLocalFile.Text = TranslationOfileDat.FileName;
            TranslationDatPath = TranslationOfileDat.FileName;
            TranslationlocaldatName = TranslationOfileDat.SafeFileName;

            // Check if 64bit or 32bit
            if (TranslationDatPath.Contains("64"))
                TranslationDatIs64 = true;
            else
                TranslationDatIs64 = false;

            //if (cB_output.Checked == true)
            //{
            TranslateRepackPath = Path.GetDirectoryName(TranslationDatPath) + @"\";//get working dir
            TranslationlocalOutPath = TranslationDatPath + ".files"; //get full file path and add .files
            TxbOut.Text = TranslationlocalOutPath;
            //}

            TranslationBinFile = TranslationlocalOutPath + @"\" + (TranslateIs64 ? "localfile64.bin" : "localfile.bin"); //get full file path and add .files

            TranslationFilePath = TranslateRepackPath + (TranslateIs64 ? "Translation64" : "Translation");
            if (!Directory.Exists(TranslationFilePath))
                Directory.CreateDirectory(TranslationFilePath);

            TranslationExportFile = TranslationFilePath + (TranslateIs64 ? @"\Translation64.xml" : @"\Translation.xml");//original translation xml
        }

        private void BtnUnpack_Click(object sender, EventArgs e)
        {
            if (multiworker != null && multiworker.IsBusy)
                multiworker.CancelAsync();

            try
            {
                if (File.Exists(TranslationDatPath))
                {
                    Extractor(TranslationDatPath);
                    GboxTranslator.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Select .dat file to unpack.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSearchOutput_Click(object sender, EventArgs e)
        {
            if (TranslationOfolderDat.ShowDialog() != DialogResult.OK)
                return;

            TxbOut.Text = TranslationOfolderDat.SelectedPath;
            TranslationlocalOutPath = TranslationOfolderDat.SelectedPath;

            if (TranslationlocalOutPath.Contains("64"))
                TranslationDatIs64 = true;
            else
                TranslationDatIs64 = false;

            string datName = Path.GetFileName(TranslationlocalOutPath);
            //get dat file name from folder
            TranslationlocaldatName = datName.Replace(".files", "");
            //get working path
            TranslateRepackPath = TranslationlocalOutPath.Replace(datName, "\\");
            //Console.WriteLine(DatfileName);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (multiworker != null && multiworker.IsBusy)
                multiworker.CancelAsync();

            try
            {
                if (File.Exists(TranslationBinFile))
                {
                    GboxTranslator.Enabled = false;
                    RunWithWorker(((o, args) =>
                    {
                        BDat bdat = new BDat();
                        bdat.ExportTranslate(TranslationBinFile, TranslationExportFile, BXML_TYPE.BXML_PLAIN, TranslateIs64);
                        GboxTranslator.Enabled = true;
                    }));

                }
                else
                {
                    MessageBox.Show(".bin not exist please extract first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSearchMerge_Click(object sender, EventArgs e)
        {
            if (TranslationOMergeFile.ShowDialog() != DialogResult.OK)
                return;

            TxbMergeFile.Text = TranslationOMergeFile.FileName;
            TranslationTargetFile = TranslationOMergeFile.FileName;
            //DatfileName = OSourceFile.SafeFileName;

            // Check if 64bit or 32bit
            if (TranslationTargetFile.Contains("64"))
                TranslationDatIs64 = true;
            else
                TranslationDatIs64 = false;
        }
        private void BtnSourceSearch_Click(object sender, EventArgs e)
        {
            if (TranslationOSourceFile.ShowDialog() != DialogResult.OK)
                return;

            TxbSourceTranslate.Text = TranslationOSourceFile.FileName;
            TranslationSourceFile = TranslationOSourceFile.FileName;
            //DatfileName = OSourceFile.SafeFileName;

            // Check if 64bit or 32bit
            if (TranslationSourceFile.Contains("64"))
                TranslationDatIs64 = true;
            else
                TranslationDatIs64 = false;
        }


        private void BtnMerge_Click(object sender, EventArgs e)
        {
            if (multiworker != null && multiworker.IsBusy)
                multiworker.CancelAsync();

            try
            {
                if (File.Exists(TranslationSourceFile) || File.Exists(TranslationTargetFile))
                {
                    Console.WriteLine("\rMerging translation...");
                    GboxTranslator.Enabled = false;
                    RunWithWorker(((o, args) =>
                    {
                        TranslateReader translateControl_Na = new TranslateReader();
                        translateControl_Na.Load(TranslationSourceFile);//Source xml
                        TranslateReader translateControl_Org = new TranslateReader();
                        translateControl_Org.Load(TranslationTargetFile, true);//Target xml          
                        translateControl_Org.MergeTranslation(translateControl_Na, TranslationTargetFile);//Target xml
                        GboxTranslator.Enabled = true;
                    }));
                }
                else
                {
                    MessageBox.Show("Translation files not exist please select source and merge files first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnRepack_Click(object sender, EventArgs e)
        {
            // Copy one file to a location where there is a file.
            File.Copy(TranslateRepackPath + (TranslationDatIs64 ? "localfile64_new.bin" : "localfile_new.bin"),
                    TranslationlocalOutPath + (TranslationDatIs64 ? @"\localfile64.bin" : @"\localfile.bin"), true); // overwrite = true
            if (CboxBackup.Checked)
                BackUpManager(TranslationDatPath, TranslateRepackPath, TranslationlocaldatName, TranslationDatIs64);
            else
                CompileManager(TranslationlocalOutPath, TranslationDatIs64);
        }
        private void BackUpManager(string filepath, string dir, string filename, bool is64)
        {
            //filepath full file path
            //dir filepath dir only
            if (multiworker != null && multiworker.IsBusy)
                multiworker.CancelAsync();

            RunWithWorker(((o, args) =>
            {
                if (string.IsNullOrEmpty(filename) == false)
                {
                    try
                    {
                        GboxTranslator.Enabled = false;
                        //get current date and time
                        string date = DateTime.Now.ToString("dd-MM-yy_"); // includes leading zeros
                        string time = DateTime.Now.ToString("hh.mm.ss"); // includes leading zeros

                        // folder location
                        var BackDir = dir + "Bacukp\\";

                        // if it doesn't exist, create
                        if (!Directory.Exists(BackDir))
                            Directory.CreateDirectory(BackDir);

                        //Create a new subfolder under the current active folder
                        string newPath = Path.Combine(BackDir, date + time);

                        // Create the subfolder
                        Directory.CreateDirectory(newPath);

                        // Copy file to backup folder
                        var CurrBackPath = newPath + "\\";
                        File.Copy(dir + filename, CurrBackPath + filename, true);
                    }
                    catch
                    {
                        MessageBox.Show(".dat file not found can't create backup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GboxTranslator.Enabled = true;
                    }
                }
            }));
            CompileManager(TranslationlocalOutPath, is64);
        }
        void CompileManager(string outdir, bool is64)
        {
            //outdir
            if (Directory.Exists(outdir))
                Compiler(outdir, is64);
            else
                MessageBox.Show("Select Folder to repack.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Compiler(string repackPath, bool is64)
        {
            if (repackPath == null)
                return;
            if (multiworker != null && multiworker.IsBusy)
                multiworker.CancelAsync();

            try
            {
                GboxTranslator.Enabled = false;
                RunWithWorker(((o, args) =>
                {
                    BNSDat m_bnsDat = new BNSDat();
                    new BNSDat().Compress(repackPath, (number, of) =>
                    {
                        richOut.Text = "Compressing Files: " + number + "/" + of;
                    }, is64, 9);
                    GboxTranslator.Enabled = true;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //
        private void RunWithWorker(DoWorkEventHandler doWork)
        {
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                multiworker = new BackgroundWorker
                {
                    WorkerReportsProgress = true
                };
                multiworker.DoWork += doWork;
                multiworker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Extractor(string datFile)
        {
            if (datFile == null)
                return;
            try
            {
                RunWithWorker(((o, args) =>
                {
                    new BNSDat().Extract(TranslationDatPath, (number, of) =>
                    {
                        richOut.Text = "Extracting Files: " + number + "/" + of;
                    }, TranslationDatIs64);
                    GboxTranslator.Enabled = true;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            if (multiworker != null && multiworker.IsBusy)
                multiworker.CancelAsync();
            try
            {
                if (File.Exists(TranslationTargetFile))
                {
                    GboxTranslator.Enabled = false;
                    RunWithWorker(((o, args) =>
                    {
                        //BackgroundWorker backgroundWorker = o as BackgroundWorker;
                        BDat bdat = new BDat();
                        bdat.Translate(TranslateRepackPath, TranslationTargetFile, TranslateIs64);
                        GboxTranslator.Enabled = true;
                    }));
                }
                else
                {
                    MessageBox.Show("Translation files not exist please select source and merge files first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
