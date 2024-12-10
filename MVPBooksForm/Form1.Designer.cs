namespace MVPBooksForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bookNameLabel = new Label();
            bookAuthorLabel = new Label();
            bookGenreLabel = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxGenre = new TextBox();
            textBoxYear = new TextBox();
            saveButton = new Button();
            deleteButton = new Button();
            richTextBox1 = new RichTextBox();
            deleteInput = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            deleteAll = new ToolStripMenuItem();
            returnFirst = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            exitToolLabel = new ToolStripLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(48, 82);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(94, 15);
            bookNameLabel.TabIndex = 0;
            bookNameLabel.Text = "Название книги";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Location = new Point(48, 115);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(75, 15);
            bookAuthorLabel.TabIndex = 1;
            bookAuthorLabel.Text = "Автор книги";
            // 
            // bookGenreLabel
            // 
            bookGenreLabel.AutoSize = true;
            bookGenreLabel.Location = new Point(48, 148);
            bookGenreLabel.Name = "bookGenreLabel";
            bookGenreLabel.Size = new Size(38, 15);
            bookGenreLabel.TabIndex = 2;
            bookGenreLabel.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 189);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Год издания";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(148, 79);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(194, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(148, 112);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(194, 23);
            textBoxAuthor.TabIndex = 5;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(148, 145);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(194, 23);
            textBoxGenre.TabIndex = 6;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(148, 186);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(194, 23);
            textBoxYear.TabIndex = 7;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(48, 292);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(132, 42);
            saveButton.TabIndex = 8;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(210, 292);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(132, 42);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(465, 79);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(218, 262);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // deleteInput
            // 
            deleteInput.Location = new Point(210, 263);
            deleteInput.Name = "deleteInput";
            deleteInput.Size = new Size(132, 23);
            deleteInput.TabIndex = 11;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(739, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { deleteAll, returnFirst });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 20);
            toolStripMenuItem1.Text = "Menu";
            // 
            // deleteAll
            // 
            deleteAll.Name = "deleteAll";
            deleteAll.Size = new Size(132, 22);
            deleteAll.Text = "Delete All";
            deleteAll.Click += deleteAll_Click;
            // 
            // returnFirst
            // 
            returnFirst.Name = "returnFirst";
            returnFirst.Size = new Size(132, 22);
            returnFirst.Text = "Return first";
            returnFirst.Click += returnFirst_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, exitToolLabel });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.No;
            toolStrip1.Size = new Size(739, 25);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // exitToolLabel
            // 
            exitToolLabel.Name = "exitToolLabel";
            exitToolLabel.Size = new Size(26, 22);
            exitToolLabel.Text = "Exit";
            exitToolLabel.Click += exitToolLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 359);
            Controls.Add(toolStrip1);
            Controls.Add(deleteInput);
            Controls.Add(richTextBox1);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(bookGenreLabel);
            Controls.Add(bookAuthorLabel);
            Controls.Add(bookNameLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookNameLabel;
        private Label bookAuthorLabel;
        private Label bookGenreLabel;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxAuthor;
        private TextBox textBoxGenre;
        private TextBox textBoxYear;
        private Button saveButton;
        private Button deleteButton;
        private RichTextBox richTextBox1;
        private TextBox deleteInput;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem deleteAll;
        private ToolStripMenuItem returnFirst;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel exitToolLabel;
    }
}
