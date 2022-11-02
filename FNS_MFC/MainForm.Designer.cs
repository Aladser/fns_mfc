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
            this.selectButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.oldNameLabel = new System.Windows.Forms.Label();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newNameField = new System.Windows.Forms.Label();
            this.oldNameFiled = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(17, 15);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(137, 59);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Открыть файл";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(17, 164);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(137, 59);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Выполнить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // oldNameLabel
            // 
            this.oldNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.oldNameLabel.Location = new System.Drawing.Point(173, 38);
            this.oldNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.oldNameLabel.Name = "oldNameLabel";
            this.oldNameLabel.Size = new System.Drawing.Size(89, 23);
            this.oldNameLabel.TabIndex = 4;
            this.oldNameLabel.Text = "Открыт файл";
            this.oldNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newNameLabel
            // 
            this.newNameLabel.Location = new System.Drawing.Point(173, 164);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(89, 59);
            this.newNameLabel.TabIndex = 5;
            this.newNameLabel.Text = "Новый файл сохранен как";
            this.newNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitLabel
            // 
            this.unitLabel.Location = new System.Drawing.Point(173, 101);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(89, 34);
            this.unitLabel.TabIndex = 6;
            this.unitLabel.Text = "Отделение:";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitComboBox
            // 
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.unitComboBox.Location = new System.Drawing.Point(268, 109);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(121, 21);
            this.unitComboBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.newNameField);
            this.panel1.Controls.Add(this.oldNameFiled);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Controls.Add(this.unitLabel);
            this.panel1.Controls.Add(this.unitComboBox);
            this.panel1.Controls.Add(this.newNameLabel);
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Controls.Add(this.oldNameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 249);
            this.panel1.TabIndex = 8;
            // 
            // newNameField
            // 
            this.newNameField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newNameField.Location = new System.Drawing.Point(271, 164);
            this.newNameField.Name = "newNameField";
            this.newNameField.Padding = new System.Windows.Forms.Padding(5);
            this.newNameField.Size = new System.Drawing.Size(328, 59);
            this.newNameField.TabIndex = 9;
            // 
            // oldNameFiled
            // 
            this.oldNameFiled.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oldNameFiled.Location = new System.Drawing.Point(268, 15);
            this.oldNameFiled.Name = "oldNameFiled";
            this.oldNameFiled.Padding = new System.Windows.Forms.Padding(5);
            this.oldNameFiled.Size = new System.Drawing.Size(331, 59);
            this.oldNameFiled.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(642, 276);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "ФНС";
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
    }
}

