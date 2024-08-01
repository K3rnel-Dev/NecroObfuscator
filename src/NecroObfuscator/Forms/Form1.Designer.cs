namespace NecroObfuscator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Antide4dot_Chk = new MetroFramework.Controls.MetroCheckBox();
            this.Watermark_Chk = new MetroFramework.Controls.MetroCheckBox();
            this.ControlFlow_Chk = new MetroFramework.Controls.MetroCheckBox();
            this.SelectorBtn = new System.Windows.Forms.Button();
            this.BuildBtn = new System.Windows.Forms.Button();
            this.ProxyString_Chk = new MetroFramework.Controls.MetroCheckBox();
            this.JunkMethods_Chk = new MetroFramework.Controls.MetroCheckBox();
            this.RenameFuncs_Chk = new MetroFramework.Controls.MetroCheckBox();
            this.SelectedFile_Box = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.DetectorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScriptObfuscateBtn = new System.Windows.Forms.Button();
            this.ScriptSelectorBtn = new System.Windows.Forms.Button();
            this.ScripLocateBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HideOEP_Chk = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(70, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(203, 50);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "NecroObfuscator v 1.2\r\n";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.CustomBackground = true;
            this.metroTabControl1.Location = new System.Drawing.Point(13, 89);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(384, 261);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage1.Controls.Add(this.HideOEP_Chk);
            this.metroTabPage1.Controls.Add(this.Antide4dot_Chk);
            this.metroTabPage1.Controls.Add(this.Watermark_Chk);
            this.metroTabPage1.Controls.Add(this.ControlFlow_Chk);
            this.metroTabPage1.Controls.Add(this.SelectorBtn);
            this.metroTabPage1.Controls.Add(this.BuildBtn);
            this.metroTabPage1.Controls.Add(this.ProxyString_Chk);
            this.metroTabPage1.Controls.Add(this.JunkMethods_Chk);
            this.metroTabPage1.Controls.Add(this.RenameFuncs_Chk);
            this.metroTabPage1.Controls.Add(this.SelectedFile_Box);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(376, 222);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = ".NET/DLL-Obfuscator";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // Antide4dot_Chk
            // 
            this.Antide4dot_Chk.AutoSize = true;
            this.Antide4dot_Chk.BackColor = System.Drawing.Color.White;
            this.Antide4dot_Chk.CustomBackground = true;
            this.Antide4dot_Chk.CustomForeColor = true;
            this.Antide4dot_Chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Antide4dot_Chk.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.Antide4dot_Chk.ForeColor = System.Drawing.Color.Black;
            this.Antide4dot_Chk.Location = new System.Drawing.Point(221, 116);
            this.Antide4dot_Chk.Name = "Antide4dot_Chk";
            this.Antide4dot_Chk.Size = new System.Drawing.Size(96, 19);
            this.Antide4dot_Chk.Style = MetroFramework.MetroColorStyle.Blue;
            this.Antide4dot_Chk.TabIndex = 16;
            this.Antide4dot_Chk.Text = "AntiDe4dot";
            this.Antide4dot_Chk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Antide4dot_Chk.UseStyleColors = true;
            this.Antide4dot_Chk.UseVisualStyleBackColor = false;
            // 
            // Watermark_Chk
            // 
            this.Watermark_Chk.AutoSize = true;
            this.Watermark_Chk.BackColor = System.Drawing.Color.White;
            this.Watermark_Chk.CustomBackground = true;
            this.Watermark_Chk.CustomForeColor = true;
            this.Watermark_Chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Watermark_Chk.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.Watermark_Chk.ForeColor = System.Drawing.Color.Black;
            this.Watermark_Chk.Location = new System.Drawing.Point(221, 66);
            this.Watermark_Chk.Name = "Watermark_Chk";
            this.Watermark_Chk.Size = new System.Drawing.Size(92, 19);
            this.Watermark_Chk.Style = MetroFramework.MetroColorStyle.Blue;
            this.Watermark_Chk.TabIndex = 15;
            this.Watermark_Chk.Text = "Watermark";
            this.Watermark_Chk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Watermark_Chk.UseStyleColors = true;
            this.Watermark_Chk.UseVisualStyleBackColor = false;
            // 
            // ControlFlow_Chk
            // 
            this.ControlFlow_Chk.AutoSize = true;
            this.ControlFlow_Chk.BackColor = System.Drawing.Color.White;
            this.ControlFlow_Chk.CustomBackground = true;
            this.ControlFlow_Chk.CustomForeColor = true;
            this.ControlFlow_Chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlFlow_Chk.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ControlFlow_Chk.ForeColor = System.Drawing.Color.Black;
            this.ControlFlow_Chk.Location = new System.Drawing.Point(221, 91);
            this.ControlFlow_Chk.Name = "ControlFlow_Chk";
            this.ControlFlow_Chk.Size = new System.Drawing.Size(99, 19);
            this.ControlFlow_Chk.Style = MetroFramework.MetroColorStyle.Blue;
            this.ControlFlow_Chk.TabIndex = 14;
            this.ControlFlow_Chk.Text = "ControlFlow";
            this.ControlFlow_Chk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ControlFlow_Chk.UseStyleColors = true;
            this.ControlFlow_Chk.UseVisualStyleBackColor = false;
            // 
            // SelectorBtn
            // 
            this.SelectorBtn.BackColor = System.Drawing.Color.Aqua;
            this.SelectorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SelectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectorBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectorBtn.ForeColor = System.Drawing.Color.White;
            this.SelectorBtn.Location = new System.Drawing.Point(319, 31);
            this.SelectorBtn.Name = "SelectorBtn";
            this.SelectorBtn.Size = new System.Drawing.Size(42, 29);
            this.SelectorBtn.TabIndex = 13;
            this.SelectorBtn.Text = "...";
            this.SelectorBtn.UseVisualStyleBackColor = false;
            this.SelectorBtn.Click += new System.EventHandler(this.SelectorBtn_Click);
            // 
            // BuildBtn
            // 
            this.BuildBtn.BackColor = System.Drawing.Color.Aqua;
            this.BuildBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildBtn.ForeColor = System.Drawing.Color.White;
            this.BuildBtn.Location = new System.Drawing.Point(79, 152);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(215, 49);
            this.BuildBtn.TabIndex = 12;
            this.BuildBtn.Text = "OBFUSCATE";
            this.BuildBtn.UseVisualStyleBackColor = false;
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // ProxyString_Chk
            // 
            this.ProxyString_Chk.AutoSize = true;
            this.ProxyString_Chk.BackColor = System.Drawing.Color.White;
            this.ProxyString_Chk.CustomBackground = true;
            this.ProxyString_Chk.CustomForeColor = true;
            this.ProxyString_Chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProxyString_Chk.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ProxyString_Chk.ForeColor = System.Drawing.Color.Black;
            this.ProxyString_Chk.Location = new System.Drawing.Point(21, 116);
            this.ProxyString_Chk.Name = "ProxyString_Chk";
            this.ProxyString_Chk.Size = new System.Drawing.Size(95, 19);
            this.ProxyString_Chk.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProxyString_Chk.TabIndex = 5;
            this.ProxyString_Chk.Text = "ProxyString";
            this.ProxyString_Chk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProxyString_Chk.UseStyleColors = true;
            this.ProxyString_Chk.UseVisualStyleBackColor = false;
            // 
            // JunkMethods_Chk
            // 
            this.JunkMethods_Chk.AutoSize = true;
            this.JunkMethods_Chk.BackColor = System.Drawing.Color.White;
            this.JunkMethods_Chk.CustomBackground = true;
            this.JunkMethods_Chk.CustomForeColor = true;
            this.JunkMethods_Chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JunkMethods_Chk.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.JunkMethods_Chk.ForeColor = System.Drawing.Color.Black;
            this.JunkMethods_Chk.Location = new System.Drawing.Point(21, 91);
            this.JunkMethods_Chk.Name = "JunkMethods_Chk";
            this.JunkMethods_Chk.Size = new System.Drawing.Size(114, 19);
            this.JunkMethods_Chk.Style = MetroFramework.MetroColorStyle.Blue;
            this.JunkMethods_Chk.TabIndex = 4;
            this.JunkMethods_Chk.Text = "Junk-Methods";
            this.JunkMethods_Chk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.JunkMethods_Chk.UseStyleColors = true;
            this.JunkMethods_Chk.UseVisualStyleBackColor = false;
            // 
            // RenameFuncs_Chk
            // 
            this.RenameFuncs_Chk.AutoSize = true;
            this.RenameFuncs_Chk.BackColor = System.Drawing.Color.White;
            this.RenameFuncs_Chk.CustomBackground = true;
            this.RenameFuncs_Chk.CustomForeColor = true;
            this.RenameFuncs_Chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenameFuncs_Chk.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.RenameFuncs_Chk.ForeColor = System.Drawing.Color.Black;
            this.RenameFuncs_Chk.Location = new System.Drawing.Point(21, 66);
            this.RenameFuncs_Chk.Name = "RenameFuncs_Chk";
            this.RenameFuncs_Chk.Size = new System.Drawing.Size(139, 19);
            this.RenameFuncs_Chk.Style = MetroFramework.MetroColorStyle.Blue;
            this.RenameFuncs_Chk.TabIndex = 3;
            this.RenameFuncs_Chk.Text = "Rename-Functions";
            this.RenameFuncs_Chk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RenameFuncs_Chk.UseStyleColors = true;
            this.RenameFuncs_Chk.UseVisualStyleBackColor = false;
            // 
            // SelectedFile_Box
            // 
            this.SelectedFile_Box.BackColor = System.Drawing.Color.White;
            this.SelectedFile_Box.CustomBackground = true;
            this.SelectedFile_Box.CustomForeColor = true;
            this.SelectedFile_Box.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SelectedFile_Box.ForeColor = System.Drawing.Color.Black;
            this.SelectedFile_Box.Location = new System.Drawing.Point(3, 31);
            this.SelectedFile_Box.Multiline = true;
            this.SelectedFile_Box.Name = "SelectedFile_Box";
            this.SelectedFile_Box.PromptText = "EXE PATH";
            this.SelectedFile_Box.Size = new System.Drawing.Size(310, 29);
            this.SelectedFile_Box.Style = MetroFramework.MetroColorStyle.Blue;
            this.SelectedFile_Box.TabIndex = 2;
            this.SelectedFile_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectedFile_Box.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SelectedFile_Box.UseStyleColors = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.DetectorLabel);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.ScriptObfuscateBtn);
            this.metroTabPage2.Controls.Add(this.ScriptSelectorBtn);
            this.metroTabPage2.Controls.Add(this.ScripLocateBox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(376, 222);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Script-Obfuscate";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(2, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Detected:";
            // 
            // DetectorLabel
            // 
            this.DetectorLabel.AutoSize = true;
            this.DetectorLabel.BackColor = System.Drawing.Color.Transparent;
            this.DetectorLabel.Font = new System.Drawing.Font("Liberation Mono", 11.75F);
            this.DetectorLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DetectorLabel.Location = new System.Drawing.Point(98, 98);
            this.DetectorLabel.Name = "DetectorLabel";
            this.DetectorLabel.Size = new System.Drawing.Size(48, 18);
            this.DetectorLabel.TabIndex = 18;
            this.DetectorLabel.Text = "Idle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "Available files for obfuscation\r\n      [ .BAT    .VBS ]";
            // 
            // ScriptObfuscateBtn
            // 
            this.ScriptObfuscateBtn.BackColor = System.Drawing.Color.Aqua;
            this.ScriptObfuscateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScriptObfuscateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptObfuscateBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScriptObfuscateBtn.ForeColor = System.Drawing.Color.White;
            this.ScriptObfuscateBtn.Location = new System.Drawing.Point(66, 154);
            this.ScriptObfuscateBtn.Name = "ScriptObfuscateBtn";
            this.ScriptObfuscateBtn.Size = new System.Drawing.Size(247, 52);
            this.ScriptObfuscateBtn.TabIndex = 15;
            this.ScriptObfuscateBtn.Text = "OBFUSCATE";
            this.ScriptObfuscateBtn.UseVisualStyleBackColor = false;
            this.ScriptObfuscateBtn.Click += new System.EventHandler(this.ScriptObfuscateBtn_Click);
            // 
            // ScriptSelectorBtn
            // 
            this.ScriptSelectorBtn.BackColor = System.Drawing.Color.Aqua;
            this.ScriptSelectorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScriptSelectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptSelectorBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScriptSelectorBtn.ForeColor = System.Drawing.Color.White;
            this.ScriptSelectorBtn.Location = new System.Drawing.Point(317, 61);
            this.ScriptSelectorBtn.Name = "ScriptSelectorBtn";
            this.ScriptSelectorBtn.Size = new System.Drawing.Size(49, 29);
            this.ScriptSelectorBtn.TabIndex = 15;
            this.ScriptSelectorBtn.Text = "...";
            this.ScriptSelectorBtn.UseVisualStyleBackColor = false;
            this.ScriptSelectorBtn.Click += new System.EventHandler(this.ScriptSelectorBtn_Click);
            // 
            // ScripLocateBox
            // 
            this.ScripLocateBox.BackColor = System.Drawing.Color.White;
            this.ScripLocateBox.CustomBackground = true;
            this.ScripLocateBox.CustomForeColor = true;
            this.ScripLocateBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ScripLocateBox.ForeColor = System.Drawing.Color.Black;
            this.ScripLocateBox.Location = new System.Drawing.Point(1, 61);
            this.ScripLocateBox.Multiline = true;
            this.ScripLocateBox.Name = "ScripLocateBox";
            this.ScripLocateBox.PromptText = "EXE PATH";
            this.ScripLocateBox.Size = new System.Drawing.Size(310, 29);
            this.ScripLocateBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.ScripLocateBox.TabIndex = 14;
            this.ScripLocateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScripLocateBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ScripLocateBox.UseStyleColors = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage3.Controls.Add(this.AuthorLabel);
            this.metroTabPage3.Controls.Add(this.label3);
            this.metroTabPage3.Controls.Add(this.pictureBox2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(376, 222);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About Program";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.BackColor = System.Drawing.Color.White;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AuthorLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AuthorLabel.Location = new System.Drawing.Point(17, 164);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(278, 51);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author: K3rnel-Dev\r\nGithub: https://github.com/k3rnel-dev\r\nTelegram: @K666Plus";
            this.AuthorLabel.Click += new System.EventHandler(this.AuthorLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 65);
            this.label3.TabIndex = 3;
            this.label3.Text = "A simple example of an obfuscator using \r\nthe dnlib library, the finished version" +
    ", allows\r\nyou to obfuscate the main code of an \r\napplication to further complica" +
    "te its \r\nreadability and parsing";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NecroObfuscator.Properties.Resources.auth;
            this.pictureBox2.Location = new System.Drawing.Point(20, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NecroObfuscator.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HideOEP_Chk
            // 
            this.HideOEP_Chk.AutoSize = true;
            this.HideOEP_Chk.BackColor = System.Drawing.Color.White;
            this.HideOEP_Chk.CustomBackground = true;
            this.HideOEP_Chk.CustomForeColor = true;
            this.HideOEP_Chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideOEP_Chk.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.HideOEP_Chk.ForeColor = System.Drawing.Color.Black;
            this.HideOEP_Chk.Location = new System.Drawing.Point(126, 117);
            this.HideOEP_Chk.Name = "HideOEP_Chk";
            this.HideOEP_Chk.Size = new System.Drawing.Size(83, 19);
            this.HideOEP_Chk.Style = MetroFramework.MetroColorStyle.Blue;
            this.HideOEP_Chk.TabIndex = 17;
            this.HideOEP_Chk.Text = "Hide OEP";
            this.HideOEP_Chk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HideOEP_Chk.UseStyleColors = true;
            this.HideOEP_Chk.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 368);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "NecroObfuscator [ Main ]";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox SelectedFile_Box;
        private MetroFramework.Controls.MetroCheckBox ProxyString_Chk;
        private MetroFramework.Controls.MetroCheckBox JunkMethods_Chk;
        private MetroFramework.Controls.MetroCheckBox RenameFuncs_Chk;
        private System.Windows.Forms.Button BuildBtn;
        private System.Windows.Forms.Button SelectorBtn;
        private MetroFramework.Controls.MetroCheckBox ControlFlow_Chk;
        private System.Windows.Forms.Button ScriptObfuscateBtn;
        private System.Windows.Forms.Button ScriptSelectorBtn;
        private MetroFramework.Controls.MetroTextBox ScripLocateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DetectorLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroCheckBox Antide4dot_Chk;
        private MetroFramework.Controls.MetroCheckBox Watermark_Chk;
        private MetroFramework.Controls.MetroCheckBox HideOEP_Chk;
    }
}

