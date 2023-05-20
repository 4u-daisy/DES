using DES.Realization.Lib.Algorithm;
using DES.Realization.Lib.Helper;
using System.Text;

namespace DES.Realization.Desktop;

public partial class MainWindow : Form
{
    private readonly int _encrypt = 0;
    private readonly int _decrypt = 1;

    private int _operation = 0;
    private string _key = new String("");

    private bool inputTextIsHEX = false;
    private bool outputTextIsHEX = false;
    private bool keyIsHEX = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {

    }

    private void radioButtonEncrypt_CheckedChanged(object sender, EventArgs e)
    {
        _operation = radioButtonEncrypt.Checked ? _encrypt : _decrypt;
    }

    private void radioButtonDecrypt_CheckedChanged(object sender, EventArgs e)
    {
        _operation = radioButtonDecrypt.Checked ? _decrypt : _encrypt;
    }


    private void buttonExecute_Click(object sender, EventArgs e)
    {
        //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //Encoding.GetEncoding("windows-1254");
        
        _key = textBoxInputKey.Text.Trim();
        if (!keyIsHEX)
            _key = Converter.StringToHex(_key, Encoding.BigEndianUnicode);
        if (_key.Length != 16)
        {
            MessageBox.Show("Incorrect key");
            return;
        }
        var text = textBoxInputText.Text;

        var len = (int)Math.Ceiling(1.0 * text.Length / 16);
        text = text.PadRight(len * 16, ' ');

        if (!inputTextIsHEX)
            text = Converter.StringToHex(text, Encoding.BigEndianUnicode);

        var desCipher = new Des();
        var outputText = desCipher.Cipher(text, _key, _operation == _encrypt);

        if (!outputTextIsHEX)
        {
            outputText = Converter.HexToString(outputText, Encoding.BigEndianUnicode);
        }
        textBoxOutputText.Text = outputText;

    }


    private void buttonKeyGeneration_Click(object sender, EventArgs e)
    {
        _key = KeyGeneration.GetKey();
        textBoxInputKey.Text = _key;
    }


    private void inputTextIsHex_CheckedChanged(object sender, EventArgs e)
    {
        inputTextIsHEX = inputTextIsHex.Checked;
    }

    private void outputTextIsHex_CheckedChanged(object sender, EventArgs e)
    {
        outputTextIsHEX = outputTextIsHex.Checked;
    }

    private void keyIsHex_CheckedChanged(object sender, EventArgs e)
    {
        keyIsHEX = keyIsHex.Checked;
    }

    private void OpenFile_Click_1(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
        // получаем выбранный файл
        string filename = openFileDialog1.FileName;
        // читаем файл в строку
        string fileText = System.IO.File.ReadAllText(filename);
        pathToFile.Text = filename;
        textBoxInputText.Text = fileText;

    }

    private void SaveFile_Click_1(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
        // получаем выбранный файл
        string filename = saveFileDialog1.FileName;
        // сохраняем текст в файл
        System.IO.File.WriteAllText(filename, textBoxOutputText.Text);
        MessageBox.Show("Файл сохранен");
    }
}
