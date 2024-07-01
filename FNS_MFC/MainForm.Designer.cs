namespace FNS_MFC
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.selectButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.oldNameLabel = new System.Windows.Forms.Label();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newNameField = new System.Windows.Forms.Label();
            this.oldNameFiled = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(23, 18);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(183, 73);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Открыть файл";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(23, 202);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(183, 73);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Выполнить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // oldNameLabel
            // 
            this.oldNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.oldNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.oldNameLabel.Location = new System.Drawing.Point(231, 47);
            this.oldNameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.oldNameLabel.Name = "oldNameLabel";
            this.oldNameLabel.Size = new System.Drawing.Size(119, 28);
            this.oldNameLabel.TabIndex = 4;
            this.oldNameLabel.Text = "Открыт файл";
            this.oldNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newNameLabel
            // 
            this.newNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.newNameLabel.Location = new System.Drawing.Point(231, 202);
            this.newNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(119, 73);
            this.newNameLabel.TabIndex = 5;
            this.newNameLabel.Text = "Новый файл сохранен как";
            this.newNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitLabel
            // 
            this.unitLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.unitLabel.Location = new System.Drawing.Point(231, 124);
            this.unitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(119, 42);
            this.unitLabel.TabIndex = 6;
            this.unitLabel.Text = "Отделение:";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitComboBox
            // 
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "Офис 1",
            "Офис 2",
            "Офис 3",
            "Архара",
            "Новобурейский",
            "Прогресс",
            "Константиновка",
            "Магдагачи",
            "Новокиевский Увал",
            "Поярково",
            "Екатеринославка",
            "Ромны",
            "Серышево",
            "Сковородино",
            "Тамбовка",
            "Зея",
            "Райчихинск",
            "Тында",
            "Завитинск",
            "Ивановка",
            "Свободный",
            "Белогорск",
            "Февральск",
            "Циолковский",
            "Шимановск"});
            this.unitComboBox.Location = new System.Drawing.Point(361, 128);
            this.unitComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(207, 32);
            this.unitComboBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.newNameField);
            this.panel1.Controls.Add(this.oldNameFiled);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Controls.Add(this.unitLabel);
            this.panel1.Controls.Add(this.unitComboBox);
            this.panel1.Controls.Add(this.newNameLabel);
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Controls.Add(this.oldNameLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 306);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Image = global::FNS_MFC.Properties.Resources.info;
            this.label1.Location = new System.Drawing.Point(760, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "                   ";
            this.toolTip1.SetToolTip(this.label1, "Программа подготовки документов для ФНС 1.2\r\nAladser (c)\r\n2024");
            // 
            // newNameField
            // 
            this.newNameField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newNameField.Location = new System.Drawing.Point(361, 202);
            this.newNameField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newNameField.Name = "newNameField";
            this.newNameField.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.newNameField.Size = new System.Drawing.Size(437, 73);
            this.newNameField.TabIndex = 9;
            // 
            // oldNameFiled
            // 
            this.oldNameFiled.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oldNameFiled.Location = new System.Drawing.Point(357, 18);
            this.oldNameFiled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oldNameFiled.Name = "oldNameFiled";
            this.oldNameFiled.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.oldNameFiled.Size = new System.Drawing.Size(441, 73);
            this.oldNameFiled.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(856, 340);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ФНС 1.2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label oldNameLabel;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label newNameField;
        private System.Windows.Forms.Label oldNameFiled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

