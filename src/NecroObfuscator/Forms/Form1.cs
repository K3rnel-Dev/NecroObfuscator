using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using NecroObfuscator.Algorithms.Obufscation;
using NecroObfuscator.Algorithms.ScriptObfuscation;
using System.Diagnostics;

namespace NecroObfuscator
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region DOTNET OBFUSCATE UTILS
        private void BuildBtn_Click(object sender, EventArgs e)
        {
            bool
                controlFlow = ControlFlow_Chk.Checked,
                 renameFuncs = RenameFuncs_Chk.Checked,
                 junkMethods = JunkMethods_Chk.Checked,
                 proxyString = ProxyString_Chk.Checked,
                 antiDe4dot = Antide4dot_Chk.Checked,
                 watermark = Watermark_Chk.Checked,
                 hideOEP = HideOEP_Chk.Checked;

            string FilePath = SelectedFile_Box.Text;

            if (string.IsNullOrEmpty(FilePath))
            {
                MessageBox.Show("Forms cannot be empty!", "~ Build Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save out file";
                save.Filter = "Exe Files (*.exe)|*.exe";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Runtimer.RuntimeExecute(FilePath, save.FileName, renameFuncs, junkMethods, proxyString, controlFlow, watermark, antiDe4dot, hideOEP);
                    MessageBox.Show("Obfuscation Successfull!", "~ Build Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
            }
        }

        private void SelectorBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open file to Obfuscate";
                ofd.Filter = "Exe Files (*.exe)|*.exe";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SelectedFile_Box.Text = ofd.FileName;
                }
            }
        }
        #endregion
        #region SCRIPT OBFUSCATE
        private void ScriptObfuscateBtn_Click(object sender, EventArgs e)
        {
            string ScriptLocate = ScripLocateBox.Text;
            string ExtensionFile = DetectorLabel.Text;

            // Проверка на наличие выбранного файла
            if (string.IsNullOrEmpty(ScriptLocate) || ExtensionFile == "Idle")
            {
                MessageBox.Show("Please select file!", "~ Build Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Чтение исходного кода из выбранного файла
            string scriptCode;
            try
            {
                scriptCode = File.ReadAllText(ScriptLocate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Объявление переменной для хранения обфусцированного кода
            string obfuscatedCode = null;

            // Выполнение обфускации в зависимости от типа файла
            if (ExtensionFile.Contains("BAT"))
            {
                obfuscatedCode = ScriptMethod.BatObfuscator(scriptCode);
            }
            else if (ExtensionFile.Contains("VBS"))
            {
                obfuscatedCode = ScriptMethod.VBSObfuscator(scriptCode);
            }
            else
            {
                MessageBox.Show("Unsupported file type!", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка, успешно ли обфусцирован код
            if (obfuscatedCode == null)
            {
                MessageBox.Show("Obfuscation failed!", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save obfuscated file!";

                if (ExtensionFile.Contains("BAT"))
                {
                    save.Filter = "Batch Script (*.bat)|*.bat";
                    save.DefaultExt = "bat";
                }
                else if (ExtensionFile.Contains("VBS"))
                {
                    save.Filter = "VBS Script (*.vbs)|*.vbs";
                    save.DefaultExt = "vbs";
                }
                else
                {
                    MessageBox.Show("Unsupported file type!", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Если пользователь выбрал место для сохранения файла
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string savePath = save.FileName;

                    try
                    {
                        // Сохранение обфусцированного кода в файл
                       File.WriteAllText(savePath, obfuscatedCode);
                        MessageBox.Show($"File saved successfully: {savePath}", "~ Save Successful ~", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void ScriptSelectorBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open file to Obfuscate";
                ofd.Filter = "Script Files (*.vbs;*.bat)|*.vbs;*.bat";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ScripLocateBox.Text = ofd.FileName;

                    // Определяем расширение файла
                    string fileExtension = System.IO.Path.GetExtension(ofd.FileName).ToLower();

                    // В зависимости от расширения добавляем текст к DetectorLabel
                    switch (fileExtension)
                    {
                        case ".vbs":
                            DetectorLabel.Text = "VBS";
                            break;
                        case ".bat":
                            DetectorLabel.Text = "BAT";
                            break;
                        default:
                            DetectorLabel.Text = "Unsupported File Selected";
                            break;
                    }
                }
            }
        }


        #endregion
        #region Form Setters
        private GraphicsPath CreateRoundedRectanglePath(int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Add rounded corners to the path
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(width - radius, 0, radius, radius, 270, 90);
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            path.AddArc(0, height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            return path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int CornerRadius = 30;
            GraphicsPath path = CreateRoundedRectanglePath(this.Width, this.Height, CornerRadius);
            this.Region = new Region(path);
        }
        private void AuthorLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }
        #endregion
    }
}
