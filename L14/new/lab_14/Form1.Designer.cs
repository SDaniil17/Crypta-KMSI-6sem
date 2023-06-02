namespace lab_14
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.extractedMessage = new System.Windows.Forms.RichTextBox();
            this.extract = new System.Windows.Forms.Button();
            this.fileForExtract = new System.Windows.Forms.Label();
            this.chooseFileForExtract = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hide = new System.Windows.Forms.Button();
            this.fileForHide = new System.Windows.Forms.Label();
            this.hiddenMessage = new System.Windows.Forms.RichTextBox();
            this.chooseFileForHide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Images (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Images (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.extractedMessage);
            this.tabPage2.Controls.Add(this.extract);
            this.tabPage2.Controls.Add(this.fileForExtract);
            this.tabPage2.Controls.Add(this.chooseFileForExtract);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(441, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Получить текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Исходное сообщение, скорытое в файле-контейнере";
            // 
            // extractedMessage
            // 
            this.extractedMessage.Location = new System.Drawing.Point(2, 136);
            this.extractedMessage.Margin = new System.Windows.Forms.Padding(2);
            this.extractedMessage.Name = "extractedMessage";
            this.extractedMessage.ReadOnly = true;
            this.extractedMessage.Size = new System.Drawing.Size(431, 67);
            this.extractedMessage.TabIndex = 3;
            this.extractedMessage.Text = "";
            // 
            // extract
            // 
            this.extract.Location = new System.Drawing.Point(5, 74);
            this.extract.Margin = new System.Windows.Forms.Padding(2);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(428, 35);
            this.extract.TabIndex = 2;
            this.extract.Text = "Получить сообщение";
            this.extract.UseVisualStyleBackColor = true;
            this.extract.Click += new System.EventHandler(this.extract_Click);
            // 
            // fileForExtract
            // 
            this.fileForExtract.AutoSize = true;
            this.fileForExtract.Location = new System.Drawing.Point(86, 18);
            this.fileForExtract.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileForExtract.Name = "fileForExtract";
            this.fileForExtract.Size = new System.Drawing.Size(0, 13);
            this.fileForExtract.TabIndex = 1;
            // 
            // chooseFileForExtract
            // 
            this.chooseFileForExtract.Location = new System.Drawing.Point(120, 46);
            this.chooseFileForExtract.Margin = new System.Windows.Forms.Padding(2);
            this.chooseFileForExtract.Name = "chooseFileForExtract";
            this.chooseFileForExtract.Size = new System.Drawing.Size(180, 24);
            this.chooseFileForExtract.TabIndex = 0;
            this.chooseFileForExtract.Text = "Выберите стеганоконтейнер";
            this.chooseFileForExtract.UseVisualStyleBackColor = true;
            this.chooseFileForExtract.Click += new System.EventHandler(this.chooseFileForExtract_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.hide);
            this.tabPage1.Controls.Add(this.fileForHide);
            this.tabPage1.Controls.Add(this.hiddenMessage);
            this.tabPage1.Controls.Add(this.chooseFileForHide);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(441, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Скрыть текст";
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(4, 164);
            this.hide.Margin = new System.Windows.Forms.Padding(2);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(428, 37);
            this.hide.TabIndex = 4;
            this.hide.Text = "Скрыть сообщение";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // fileForHide
            // 
            this.fileForHide.AutoSize = true;
            this.fileForHide.Location = new System.Drawing.Point(86, 237);
            this.fileForHide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileForHide.Name = "fileForHide";
            this.fileForHide.Size = new System.Drawing.Size(0, 13);
            this.fileForHide.TabIndex = 3;
            // 
            // hiddenMessage
            // 
            this.hiddenMessage.Location = new System.Drawing.Point(4, 25);
            this.hiddenMessage.Margin = new System.Windows.Forms.Padding(2);
            this.hiddenMessage.Name = "hiddenMessage";
            this.hiddenMessage.Size = new System.Drawing.Size(431, 107);
            this.hiddenMessage.TabIndex = 2;
            this.hiddenMessage.Text = "";
            // 
            // chooseFileForHide
            // 
            this.chooseFileForHide.Location = new System.Drawing.Point(145, 136);
            this.chooseFileForHide.Margin = new System.Windows.Forms.Padding(2);
            this.chooseFileForHide.Name = "chooseFileForHide";
            this.chooseFileForHide.Size = new System.Drawing.Size(152, 24);
            this.chooseFileForHide.TabIndex = 0;
            this.chooseFileForHide.Text = "Выбрать файл-контенер";
            this.chooseFileForHide.UseVisualStyleBackColor = true;
            this.chooseFileForHide.Click += new System.EventHandler(this.chooseFileForHide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите сообщение для сокрытия в файле-контейнере";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 233);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 253);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "LSB";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox extractedMessage;
        private System.Windows.Forms.Button extract;
        private System.Windows.Forms.Label fileForExtract;
        private System.Windows.Forms.Button chooseFileForExtract;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Label fileForHide;
        private System.Windows.Forms.RichTextBox hiddenMessage;
        private System.Windows.Forms.Button chooseFileForHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

