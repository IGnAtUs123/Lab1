namespace View
{
    
    partial class Main
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
            addButton = new Button();
            removeButton = new Button();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            studId = new ColumnHeader();
            showAllButton = new Button();
            histogramButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(731, 41);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(139, 55);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(575, 41);
            removeButton.Margin = new Padding(3, 4, 3, 4);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(139, 55);
            removeButton.TabIndex = 1;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, studId });
            listView.Location = new Point(40, 104);
            listView.Margin = new Padding(3, 4, 3, 4);
            listView.Name = "listView";
            listView.Size = new Size(830, 455);
            listView.TabIndex = 2;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ФИО";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Специализация";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Группа";
            columnHeader3.Width = 150;
            // 
            // studId
            // 
            studId.Text = "Студенческий билет";
            studId.Width = 200;
            // 
            // showAllButton
            // 
            showAllButton.Location = new Point(415, 41);
            showAllButton.Margin = new Padding(3, 4, 3, 4);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(139, 55);
            showAllButton.TabIndex = 3;
            showAllButton.Text = "Показать студентов";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += showAllButton_Click;
            // 
            // histogramButton
            // 
            histogramButton.Location = new Point(199, 41);
            histogramButton.Margin = new Padding(3, 4, 3, 4);
            histogramButton.Name = "histogramButton";
            histogramButton.Size = new Size(194, 55);
            histogramButton.TabIndex = 4;
            histogramButton.Text = "Показать Гистограмму";
            histogramButton.UseVisualStyleBackColor = true;
            histogramButton.Click += histogramButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 600);
            Controls.Add(histogramButton);
            Controls.Add(showAllButton);
            Controls.Add(listView);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Главная";
            //Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button removeButton;
        private ListView listView;
        private Button showAllButton;
        private Button histogramButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader studId;
    }
}
