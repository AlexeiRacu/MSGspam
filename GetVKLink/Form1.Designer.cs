namespace GetVKLink
{
    partial class MainForm
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
            SearchButton = new Button();
            ReadMyText = new TextBox();
            LinkArr = new RichTextBox();
            trackBar = new TrackBar();
            Filtr = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.Menu;
            SearchButton.Font = new Font("Consolas", 25.75F);
            SearchButton.ForeColor = Color.FromArgb(255, 128, 128);
            SearchButton.Location = new Point(12, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(454, 97);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Нажми для поиска";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ReadMyText
            // 
            ReadMyText.BackColor = SystemColors.ScrollBar;
            ReadMyText.Font = new Font("Consolas", 10F);
            ReadMyText.ForeColor = Color.Gray;
            ReadMyText.Location = new Point(12, 115);
            ReadMyText.Name = "ReadMyText";
            ReadMyText.Size = new Size(317, 23);
            ReadMyText.TabIndex = 1;
            ReadMyText.Text = "Введи свой запрос";
            ReadMyText.TextAlign = HorizontalAlignment.Center;
            ReadMyText.Enter += ReadMyText_Enter;
            ReadMyText.Leave += ReadMyText_Leave;
            // 
            // LinkArr
            // 
            LinkArr.BackColor = SystemColors.ScrollBar;
            LinkArr.Font = new Font("Consolas", 10F);
            LinkArr.Location = new Point(12, 144);
            LinkArr.Name = "LinkArr";
            LinkArr.ReadOnly = true;
            LinkArr.Size = new Size(414, 411);
            LinkArr.TabIndex = 2;
            LinkArr.Text = "";
            // 
            // trackBar
            // 
            trackBar.LargeChange = 1;
            trackBar.Location = new Point(432, 144);
            trackBar.Maximum = 4;
            trackBar.Minimum = 1;
            trackBar.Name = "trackBar";
            trackBar.Orientation = Orientation.Vertical;
            trackBar.Size = new Size(45, 411);
            trackBar.TabIndex = 3;
            trackBar.TickStyle = TickStyle.Both;
            trackBar.Value = 1;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // Filtr
            // 
            Filtr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Filtr.AutoSize = true;
            Filtr.BackColor = Color.Transparent;
            Filtr.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Filtr.ForeColor = SystemColors.GrayText;
            Filtr.Location = new Point(401, 141);
            Filtr.Name = "Filtr";
            Filtr.RightToLeft = RightToLeft.No;
            Filtr.Size = new Size(25, 13);
            Filtr.TabIndex = 4;
            Filtr.Text = "Все";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Consolas", 10F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(335, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "количество видео";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(478, 567);
            Controls.Add(textBox1);
            Controls.Add(Filtr);
            Controls.Add(trackBar);
            Controls.Add(LinkArr);
            Controls.Add(ReadMyText);
            Controls.Add(SearchButton);
            MaximumSize = new Size(494, 606);
            MinimumSize = new Size(494, 606);
            Name = "MainForm";
            Text = "getVK";
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox ReadMyText;
        private RichTextBox LinkArr;
        private TrackBar trackBar;
        private Label Filtr;
        private TextBox textBox1;
    }
}
