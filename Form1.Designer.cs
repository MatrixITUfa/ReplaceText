namespace ReplaceTextInXML
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.listViewEnterFiles = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReplaceText = new System.Windows.Forms.DataGridView();
            this.oldText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.labCountFiles = new System.Windows.Forms.Label();
            this.btInputIsFile = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btClearTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplaceText)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btOpenFile
            // 
            this.btOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btOpenFile.Location = new System.Drawing.Point(12, 59);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(106, 31);
            this.btOpenFile.TabIndex = 0;
            this.btOpenFile.Text = "Выбрать файлы";
            this.btOpenFile.UseVisualStyleBackColor = false;
            this.btOpenFile.Click += new System.EventHandler(this.BtOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Данное приложение  делает замену текста";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btStart.Location = new System.Drawing.Point(537, 464);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(106, 31);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Начать";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.IndianRed;
            this.btExit.Location = new System.Drawing.Point(537, 501);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(106, 31);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // listViewEnterFiles
            // 
            this.listViewEnterFiles.HideSelection = false;
            this.listViewEnterFiles.Location = new System.Drawing.Point(12, 137);
            this.listViewEnterFiles.Name = "listViewEnterFiles";
            this.listViewEnterFiles.Size = new System.Drawing.Size(186, 395);
            this.listViewEnterFiles.TabIndex = 4;
            this.listViewEnterFiles.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выбранные файлы:";
            // 
            // dgvReplaceText
            // 
            this.dgvReplaceText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplaceText.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oldText,
            this.newText});
            this.dgvReplaceText.Location = new System.Drawing.Point(204, 137);
            this.dgvReplaceText.Name = "dgvReplaceText";
            this.dgvReplaceText.Size = new System.Drawing.Size(445, 321);
            this.dgvReplaceText.TabIndex = 6;
            // 
            // oldText
            // 
            this.oldText.HeaderText = "Заменяемый текст";
            this.oldText.Name = "oldText";
            this.oldText.Width = 200;
            // 
            // newText
            // 
            this.newText.HeaderText = "Заменяющий текст";
            this.newText.Name = "newText";
            this.newText.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество файлов:";
            // 
            // labCountFiles
            // 
            this.labCountFiles.AutoSize = true;
            this.labCountFiles.Location = new System.Drawing.Point(129, 102);
            this.labCountFiles.Name = "labCountFiles";
            this.labCountFiles.Size = new System.Drawing.Size(13, 13);
            this.labCountFiles.TabIndex = 8;
            this.labCountFiles.Text = "0";
            // 
            // btInputIsFile
            // 
            this.btInputIsFile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btInputIsFile.Location = new System.Drawing.Point(429, 100);
            this.btInputIsFile.Name = "btInputIsFile";
            this.btInputIsFile.Size = new System.Drawing.Size(106, 31);
            this.btInputIsFile.TabIndex = 9;
            this.btInputIsFile.Text = "Взять из файла";
            this.btInputIsFile.UseVisualStyleBackColor = false;
            this.btInputIsFile.Click += new System.EventHandler(this.BtInputIsFile_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btClearTable
            // 
            this.btClearTable.BackColor = System.Drawing.Color.NavajoWhite;
            this.btClearTable.Location = new System.Drawing.Point(541, 100);
            this.btClearTable.Name = "btClearTable";
            this.btClearTable.Size = new System.Drawing.Size(106, 31);
            this.btClearTable.TabIndex = 10;
            this.btClearTable.Text = "Очистить таблицу";
            this.btClearTable.UseVisualStyleBackColor = false;
            this.btClearTable.Click += new System.EventHandler(this.BtClearTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 551);
            this.Controls.Add(this.btClearTable);
            this.Controls.Add(this.btInputIsFile);
            this.Controls.Add(this.labCountFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvReplaceText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewEnterFiles);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpenFile);
            this.Name = "Form1";
            this.Text = "Замена текста";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplaceText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ListView listViewEnterFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvReplaceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labCountFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldText;
        private System.Windows.Forms.DataGridViewTextBoxColumn newText;
        private System.Windows.Forms.Button btInputIsFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btClearTable;
    }
}

