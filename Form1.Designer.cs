namespace fileRenamer3
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
            this.pathToDirText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pathDirBtn = new System.Windows.Forms.Button();
            this.pathToDirLable = new System.Windows.Forms.Label();
            this.nFormatLable = new System.Windows.Forms.Label();
            this.nFormatText = new System.Windows.Forms.TextBox();
            this.stNumbLabel = new System.Windows.Forms.Label();
            this.startNumbText = new System.Windows.Forms.TextBox();
            this.numbOnlyCB = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.renameBtn = new System.Windows.Forms.Button();
            this.errorsText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pathToDirText
            // 
            this.pathToDirText.BackColor = System.Drawing.SystemColors.Window;
            this.pathToDirText.Location = new System.Drawing.Point(12, 24);
            this.pathToDirText.Name = "pathToDirText";
            this.pathToDirText.Size = new System.Drawing.Size(225, 20);
            this.pathToDirText.TabIndex = 0;
            this.pathToDirText.TextChanged += new System.EventHandler(this.pathToDirText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "╔╗              ╔╗    \r\n║║              ║║    \r\n║║      ╔══╗║║╔╗╔╗\r\n║║  ╔╗║╔╗║║╚╝" +
    "╝╠╣\r\n║╚═╝║║╚╝║║╔╗╗║║\r\n╚═══╝╚══╝╚╝╚╝╚╝";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pathDirBtn
            // 
            this.pathDirBtn.Location = new System.Drawing.Point(240, 21);
            this.pathDirBtn.Name = "pathDirBtn";
            this.pathDirBtn.Size = new System.Drawing.Size(50, 25);
            this.pathDirBtn.TabIndex = 1;
            this.pathDirBtn.Text = "Open";
            this.pathDirBtn.UseVisualStyleBackColor = true;
            this.pathDirBtn.Click += new System.EventHandler(this.pathDirBtn_Click);
            // 
            // pathToDirLable
            // 
            this.pathToDirLable.AutoSize = true;
            this.pathToDirLable.Location = new System.Drawing.Point(12, 9);
            this.pathToDirLable.Name = "pathToDirLable";
            this.pathToDirLable.Size = new System.Drawing.Size(84, 13);
            this.pathToDirLable.TabIndex = 2;
            this.pathToDirLable.Text = "Path to directory";
            // 
            // nFormatLable
            // 
            this.nFormatLable.AutoSize = true;
            this.nFormatLable.Enabled = false;
            this.nFormatLable.Location = new System.Drawing.Point(12, 70);
            this.nFormatLable.Name = "nFormatLable";
            this.nFormatLable.Size = new System.Drawing.Size(189, 13);
            this.nFormatLable.TabIndex = 3;
            this.nFormatLable.Text = "Name format (%NUM% - number of file)";
            // 
            // nFormatText
            // 
            this.nFormatText.Enabled = false;
            this.nFormatText.Location = new System.Drawing.Point(12, 86);
            this.nFormatText.Name = "nFormatText";
            this.nFormatText.Size = new System.Drawing.Size(278, 20);
            this.nFormatText.TabIndex = 4;
            this.nFormatText.Text = "%NUM%";
            this.nFormatText.TextChanged += new System.EventHandler(this.nFormatText_TextChanged);
            // 
            // stNumbLabel
            // 
            this.stNumbLabel.AutoSize = true;
            this.stNumbLabel.Location = new System.Drawing.Point(12, 109);
            this.stNumbLabel.Name = "stNumbLabel";
            this.stNumbLabel.Size = new System.Drawing.Size(67, 13);
            this.stNumbLabel.TabIndex = 5;
            this.stNumbLabel.Text = "Start number";
            // 
            // startNumbText
            // 
            this.startNumbText.Location = new System.Drawing.Point(12, 125);
            this.startNumbText.Name = "startNumbText";
            this.startNumbText.Size = new System.Drawing.Size(67, 20);
            this.startNumbText.TabIndex = 6;
            this.startNumbText.Text = "0";
            this.startNumbText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startNumbText.TextChanged += new System.EventHandler(this.startNumbText_TextChanged);
            this.startNumbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startNumbText_KeyPress);
            this.startNumbText.Leave += new System.EventHandler(this.startNumbText_Leave);
            // 
            // numbOnlyCB
            // 
            this.numbOnlyCB.AutoSize = true;
            this.numbOnlyCB.Checked = true;
            this.numbOnlyCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbOnlyCB.Location = new System.Drawing.Point(12, 50);
            this.numbOnlyCB.Name = "numbOnlyCB";
            this.numbOnlyCB.Size = new System.Drawing.Size(127, 17);
            this.numbOnlyCB.TabIndex = 7;
            this.numbOnlyCB.Text = "Only nubmer filename";
            this.numbOnlyCB.UseVisualStyleBackColor = true;
            this.numbOnlyCB.CheckedChanged += new System.EventHandler(this.numbOnlyCB_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(145, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Save file extension";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // renameBtn
            // 
            this.renameBtn.Location = new System.Drawing.Point(85, 112);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(205, 33);
            this.renameBtn.TabIndex = 9;
            this.renameBtn.Text = "Rename";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // errorsText
            // 
            this.errorsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorsText.Enabled = false;
            this.errorsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorsText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorsText.Location = new System.Drawing.Point(112, 148);
            this.errorsText.Name = "errorsText";
            this.errorsText.ReadOnly = true;
            this.errorsText.Size = new System.Drawing.Size(178, 78);
            this.errorsText.TabIndex = 10;
            this.errorsText.TabStop = false;
            this.errorsText.Text = "";
            this.errorsText.TextChanged += new System.EventHandler(this.errorsText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 236);
            this.Controls.Add(this.errorsText);
            this.Controls.Add(this.renameBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numbOnlyCB);
            this.Controls.Add(this.startNumbText);
            this.Controls.Add(this.stNumbLabel);
            this.Controls.Add(this.nFormatText);
            this.Controls.Add(this.nFormatLable);
            this.Controls.Add(this.pathToDirLable);
            this.Controls.Add(this.pathDirBtn);
            this.Controls.Add(this.pathToDirText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File renamer 3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pathToDirText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pathDirBtn;
        private System.Windows.Forms.Label pathToDirLable;
        private System.Windows.Forms.Label nFormatLable;
        private System.Windows.Forms.TextBox nFormatText;
        private System.Windows.Forms.Label stNumbLabel;
        private System.Windows.Forms.TextBox startNumbText;
        private System.Windows.Forms.CheckBox numbOnlyCB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button renameBtn;
        private System.Windows.Forms.RichTextBox errorsText;
    }
}

