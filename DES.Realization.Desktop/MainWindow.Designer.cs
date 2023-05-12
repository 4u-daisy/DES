using System.Security;

namespace DES.Realization.Desktop
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInputKey = new System.Windows.Forms.TextBox();
            this.buttonKeyGeneration = new System.Windows.Forms.Button();
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.radioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.textBoxOutputText = new System.Windows.Forms.TextBox();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.inputTextIsHex = new System.Windows.Forms.CheckBox();
            this.keyIsHex = new System.Windows.Forms.CheckBox();
            this.outputTextIsHex = new System.Windows.Forms.CheckBox();
            this.pathToFile = new System.Windows.Forms.TextBox();
            this.SaveFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxInputKey
            // 
            this.textBoxInputKey.Location = new System.Drawing.Point(28, 29);
            this.textBoxInputKey.Name = "textBoxInputKey";
            this.textBoxInputKey.PlaceholderText = " Input key";
            this.textBoxInputKey.Size = new System.Drawing.Size(797, 27);
            this.textBoxInputKey.TabIndex = 0;
            // 
            // buttonKeyGeneration
            // 
            this.buttonKeyGeneration.Location = new System.Drawing.Point(28, 75);
            this.buttonKeyGeneration.Name = "buttonKeyGeneration";
            this.buttonKeyGeneration.Size = new System.Drawing.Size(189, 29);
            this.buttonKeyGeneration.TabIndex = 1;
            this.buttonKeyGeneration.Text = "Automatic key generation";
            this.buttonKeyGeneration.UseVisualStyleBackColor = true;
            this.buttonKeyGeneration.Click += new System.EventHandler(this.buttonKeyGeneration_Click);
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.AutoSize = true;
            this.radioButtonEncrypt.Location = new System.Drawing.Point(404, 74);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.Size = new System.Drawing.Size(79, 24);
            this.radioButtonEncrypt.TabIndex = 2;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Encrypt";
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            this.radioButtonEncrypt.CheckedChanged += new System.EventHandler(this.radioButtonEncrypt_CheckedChanged);
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.AutoSize = true;
            this.radioButtonDecrypt.Location = new System.Drawing.Point(404, 109);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.Size = new System.Drawing.Size(82, 24);
            this.radioButtonDecrypt.TabIndex = 3;
            this.radioButtonDecrypt.TabStop = true;
            this.radioButtonDecrypt.Text = "Decrypt";
            this.radioButtonDecrypt.UseVisualStyleBackColor = true;
            this.radioButtonDecrypt.CheckedChanged += new System.EventHandler(this.radioButtonDecrypt_CheckedChanged);
            // 
            // textBoxOutputText
            // 
            this.textBoxOutputText.Location = new System.Drawing.Point(492, 191);
            this.textBoxOutputText.Multiline = true;
            this.textBoxOutputText.Name = "textBoxOutputText";
            this.textBoxOutputText.PlaceholderText = "Output text";
            this.textBoxOutputText.ReadOnly = true;
            this.textBoxOutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputText.Size = new System.Drawing.Size(458, 304);
            this.textBoxOutputText.TabIndex = 5;
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Location = new System.Drawing.Point(28, 191);
            this.textBoxInputText.Multiline = true;
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.PlaceholderText = "Input text";
            this.textBoxInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputText.Size = new System.Drawing.Size(458, 304);
            this.textBoxInputText.TabIndex = 7;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(853, 27);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(94, 29);
            this.buttonExecute.TabIndex = 8;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // inputTextIsHex
            // 
            this.inputTextIsHex.AutoSize = true;
            this.inputTextIsHex.Location = new System.Drawing.Point(233, 75);
            this.inputTextIsHex.Name = "inputTextIsHex";
            this.inputTextIsHex.Size = new System.Drawing.Size(126, 24);
            this.inputTextIsHex.TabIndex = 10;
            this.inputTextIsHex.Text = "input text HEX";
            this.inputTextIsHex.UseVisualStyleBackColor = true;
            this.inputTextIsHex.CheckedChanged += new System.EventHandler(this.inputTextIsHex_CheckedChanged);
            // 
            // keyIsHex
            // 
            this.keyIsHex.AutoSize = true;
            this.keyIsHex.Location = new System.Drawing.Point(233, 140);
            this.keyIsHex.Name = "keyIsHex";
            this.keyIsHex.Size = new System.Drawing.Size(85, 24);
            this.keyIsHex.TabIndex = 11;
            this.keyIsHex.Text = "key HEX";
            this.keyIsHex.UseVisualStyleBackColor = true;
            this.keyIsHex.CheckedChanged += new System.EventHandler(this.keyIsHex_CheckedChanged);
            // 
            // outputTextIsHex
            // 
            this.outputTextIsHex.AutoSize = true;
            this.outputTextIsHex.Location = new System.Drawing.Point(233, 110);
            this.outputTextIsHex.Name = "outputTextIsHex";
            this.outputTextIsHex.Size = new System.Drawing.Size(136, 24);
            this.outputTextIsHex.TabIndex = 12;
            this.outputTextIsHex.Text = "output text HEX";
            this.outputTextIsHex.UseVisualStyleBackColor = true;
            this.outputTextIsHex.CheckedChanged += new System.EventHandler(this.outputTextIsHex_CheckedChanged);
            // 
            // pathToFile
            // 
            this.pathToFile.Location = new System.Drawing.Point(522, 77);
            this.pathToFile.Name = "pathToFile";
            this.pathToFile.ReadOnly = true;
            this.pathToFile.Size = new System.Drawing.Size(425, 27);
            this.pathToFile.TabIndex = 13;
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(731, 125);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(94, 29);
            this.SaveFile.TabIndex = 14;
            this.SaveFile.Text = "Save File";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += SaveFile_Click;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(853, 125);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(94, 29);
            this.OpenFile.TabIndex = 15;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += OpenFile_Click;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "save file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "open file";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 507);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.pathToFile);
            this.Controls.Add(this.outputTextIsHex);
            this.Controls.Add(this.keyIsHex);
            this.Controls.Add(this.inputTextIsHex);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBoxInputText);
            this.Controls.Add(this.textBoxOutputText);
            this.Controls.Add(this.radioButtonDecrypt);
            this.Controls.Add(this.radioButtonEncrypt);
            this.Controls.Add(this.buttonKeyGeneration);
            this.Controls.Add(this.textBoxInputKey);
            this.Name = "MainWindow";
            this.Text = "Реализация алгоритма шифрования DES. Никифорова Дарья, 6312";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = pathToFile.Text;
            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(pathToFile.Text))
                {
                    writer.Write(textBoxOutputText.Text);
                }
            }
        }

        private void SetTextName(string text)
        {
            pathToFile.Text = text;
        }
        private void SetText(string text)
        {
            textBoxInputText.Text = text;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    SetTextName(openFileDialog1.FileName);
                    SetText(sr.ReadToEnd());

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        #endregion

        private TextBox textBoxInputKey;
        private Button buttonKeyGeneration;
        private RadioButton radioButtonEncrypt;
        private RadioButton radioButtonDecrypt;
        private TextBox textBoxOutputText;
        private TextBox textBoxInputText;
        private Button buttonExecute;
        private CheckBox inputTextIsHex;
        private CheckBox keyIsHex;
        private CheckBox outputTextIsHex;
        private TextBox pathToFile;
        private Button SaveFile;
        private Button OpenFile;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}