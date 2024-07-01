using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace FNS_MFC
{
    public partial class MainForm : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        bool isFileSelected = false;

        public MainForm()
        {
            InitializeComponent();
            openFileDialog.Filter = "Adobe Reader (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            unitComboBox.SelectedIndex = 0;
        }
        // Выбор файла
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            oldNameFiled.Text = openFileDialog.FileName;
            this.newNameField.Text = "";
            this.oldNameLabel.ForeColor = System.Drawing.Color.Black;
            this.unitLabel.ForeColor = System.Drawing.Color.Black;
            this.newNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            isFileSelected = true;
        }
        // Переименование файла
        private void runButton_Click(object sender, EventArgs e)
        {
            if (!isFileSelected) return;

            // создание нового имени
            DateTime time = DateTime.Now;
            string year = time.Year.ToString();
            string month = formatNumber(time.Month);
            string day = formatNumber(time.Day);
            string hour = formatNumber(time.Hour);
            string minute = formatNumber(time.Minute);
            string second = formatNumber(time.Second);
            string date = year + month + day + "." + hour + minute + second;
            string extension = Path.GetExtension(openFileDialog.FileName);

            // новое имя файла без разрешения
            string newFileNameWithoutExtension = Program.UNITS[unitComboBox.SelectedIndex] + "_TO_UFNS_" + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + "_" + date;
            // папка архива
            string archiveInnerFolder = openFileDialog.InitialDirectory + '\\' + newFileNameWithoutExtension;

            //------АРХИВАЦИЯ--------
            Directory.CreateDirectory(archiveInnerFolder);
            File.Move(openFileDialog.FileName, archiveInnerFolder + '\\' + newFileNameWithoutExtension  + extension);
            ZipFile.CreateFromDirectory(archiveInnerFolder, archiveInnerFolder + ".zip");
            Directory.Delete(archiveInnerFolder, true);
            //--------------

            newNameField.Text = archiveInnerFolder + ".zip";
            this.oldNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.unitLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.newNameLabel.ForeColor = System.Drawing.Color.Black;
            isFileSelected = false;
        }
        // Дополнение цифры нулями
        private string formatNumber(int number)
        {
            return number.ToString().Length == 2 ? number.ToString() : '0'+ number.ToString();
        }
    }
}
