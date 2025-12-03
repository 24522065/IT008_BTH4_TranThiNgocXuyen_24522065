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

namespace Bai04
{
    public partial class Form1: Form
    {
        static string textFile = "";
        static bool isOpen = false;
        public Form1()
        {
            InitializeComponent();
            InitializeCombobox();

        }
        private void InitializeCombobox()
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fontCombobox.Items.Add(font.Name);
            }
            for (int i = 8; i < 72; i++)
            {
                fontSizeCombobox.Items.Add(i);
            }
        }

        private void saveAs()
        {
            SaveFileDialog saveTextFile = new SaveFileDialog();
            saveTextFile.Filter = "Document file (*.doc)|*.doc|Document file (NEW) (*.docx)|*.docx|All files (*.*)|*.*";
            if (saveTextFile.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveTextFile.OpenFile();
                StreamWriter s = new StreamWriter(fileStream);
                s.Write(textSpace.Text);
                s.Close();
                fileStream.Close();
            }
        }
        private void newDocument_Click(object sender, EventArgs e)
        {
            if (textSpace.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn lưu các thay đổi?", "Các thay đổi chưa được lưu lại", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (isOpen)
                            saveDocument_Click(sender, e);
                        else saveAs();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            this.Text = "Untittled.txt";
            textSpace.Text = "";
            fontCombobox.Text = "Tahoma";
            fontSizeCombobox.Text = "14";
            isOpen = false;
        }

        private void openDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTextFile = new OpenFileDialog();
            openTextFile.DefaultExt = ".doc";
            openTextFile.Filter = "Document file | *.txt; *.doc; *.docx";
            if (openTextFile.ShowDialog() == DialogResult.OK)
            {
                if (textSpace.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn lưu các thay đổi của tệp tin cũ?", "Các thay đổi chưa được lưu lại", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            if (isOpen)
                                saveDocument_Click(sender, e);
                            else saveAs();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                this.Text = openTextFile.FileName;
                textFile = openTextFile.FileName;
                isOpen = true;
                textSpace.Text = File.ReadAllText(textFile);
            }
        }

        private void saveDocument_Click(object sender, EventArgs e)
        {
            if (textFile == "")
                saveAs();
            else using (StreamWriter sw = new StreamWriter(textFile))
                    sw.WriteLine(textSpace.Text);
        }

        private void exitDocument_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn lưu các thay đổi?", "Các thay đổi chưa được lưu lại", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        saveDocument_Click(sender, e);
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                }
            }
            else if (!isOpen && textSpace.Text == "")
                Application.Exit();
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn lưu các thay đổi?", "Các thay đổi chưa được lưu lại", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        saveAs();
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                }
            }
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            newDocument_Click(sender, e);
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            saveDocument_Click(sender, e);
        }

        private void bold_Click(object sender, EventArgs e)
        {
            if (textSpace.SelectionFont != null)
            {
                Font font = textSpace.SelectionFont;
                FontStyle fs;
                if (font.Bold)
                {
                    fs = FontStyle.Regular;
                }
                else
                {
                    fs = FontStyle.Bold;
                }

                if (font.Underline)
                {
                    fs = (FontStyle)(fs | FontStyle.Underline);
                }
                if (font.Italic)
                {
                    fs = (FontStyle)(fs | FontStyle.Italic);
                }
                textSpace.SelectionFont = new Font(font.FontFamily, font.Size, fs);
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            if (textSpace.SelectionFont != null)
            {
                Font font = textSpace.SelectionFont;
                FontStyle fs;
                if (font.Italic)
                {
                    fs = FontStyle.Regular;
                }
                else
                {
                    fs = FontStyle.Italic;
                }

                if (font.Underline)
                {
                    fs = (FontStyle)(fs | FontStyle.Underline);
                }
                if (font.Bold)
                {
                    fs = (FontStyle)(fs | FontStyle.Bold);
                }
                textSpace.SelectionFont = new Font(font.FontFamily, font.Size, fs);
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            if (textSpace.SelectionFont != null)
            {
                Font font = textSpace.SelectionFont;
                FontStyle fs;
                if (font.Underline)
                {
                    fs = FontStyle.Regular;
                }
                else
                {
                    fs = FontStyle.Underline;
                }

                if (font.Bold)
                {
                    fs = (FontStyle)(fs | FontStyle.Bold);
                }
                if (font.Italic)
                {
                    fs = (FontStyle)(fs | FontStyle.Italic);
                }
                textSpace.SelectionFont = new Font(font.FontFamily, font.Size, fs);
            }
        }

        private void fontCombobox_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog = new FontDialog();
            fontdialog.ShowColor = true;
            fontdialog.ShowApply = true;
            fontdialog.ShowEffects = true;
            fontdialog.ShowHelp = true;
            if (fontdialog.ShowDialog() == DialogResult.OK)
            {
                textSpace.Font = fontdialog.Font;
                textSpace.ForeColor = fontdialog.Color;
            }
        }
        private void changeFontStyle(object sender, EventArgs e)
        {
            textSpace.Font = new Font(fontCombobox.SelectedText, int.Parse(fontSizeCombobox.SelectedText));
        }
        private void fontSizeCombobox_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fontCombobox.Text) && !string.IsNullOrEmpty(fontSizeCombobox.Text))
            {
                float size;
                if (float.TryParse(fontSizeCombobox.Text, out size))
                {
                    // Giữ nguyên màu chữ hiện tại
                    textSpace.Font = new Font(fontCombobox.Text, size);
                }
                else
                {
                    MessageBox.Show("Font size không hợp lệ!");
                }
            }
        }
    }
}
