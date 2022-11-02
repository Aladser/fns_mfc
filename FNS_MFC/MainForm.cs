using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace FNS_MFC
{
    public partial class MainForm : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string newName = "";
        bool flag = false;
        public MainForm()
        {
            InitializeComponent();
            ofd.Filter = "Adobe Reader (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            unitComboBox.SelectedIndex = 0;
        }
        // Выбор файла
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK) return;
            oldNameFiled.Text = ofd.FileName;
            this.newNameField.Text = "";
            this.oldNameLabel.ForeColor = System.Drawing.Color.Black;
            this.unitLabel.ForeColor = System.Drawing.Color.Black;
            this.newNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            flag = true;
        }
        // Переименование файла
        private void runButton_Click(object sender, EventArgs e)
        {
            if (!flag) return;
            // создание нового имени
            DateTime time = DateTime.Now;
            string year = time.Year.ToString();
            string month = formatNumber(time.Month);
            string day = formatNumber(time.Day);
            string hour = formatNumber(time.Hour);
            string minute = formatNumber(time.Minute);
            string second = formatNumber(time.Second);
            string date = year + month + day + "." + hour + minute + second;
            newName = Path.GetDirectoryName(ofd.FileName) + '\\' + Program.UNITS[unitComboBox.SelectedIndex] + "_TO_UFNS_" + 
                Path.GetFileNameWithoutExtension(ofd.FileName) + "_" + date + Path.GetExtension(ofd.FileName);
            File.Move(ofd.FileName, newName); // переименование
            // добавить в архив
            string archiveName = Path.GetDirectoryName(ofd.FileName) + '\\' + Program.UNITS[unitComboBox.SelectedIndex] + "_TO_UFNS_" +
                Path.GetFileNameWithoutExtension(ofd.FileName) + "_" + date + ".7z";
            // создание архива
            ZipFile.Open(archiveName, ZipArchiveMode.Create).CreateEntryFromFile(newName, Path.GetFileName(newName));
            File.Delete(newName);
            newNameField.Text = archiveName;
            this.oldNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.unitLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.newNameLabel.ForeColor = System.Drawing.Color.Black;
            flag = false;
        }
        // Дополнение цифры нулями
        private string formatNumber(int number)
        {
            return number.ToString().Length == 2 ? number.ToString() : '0'+ number.ToString();
        }
    }
}
