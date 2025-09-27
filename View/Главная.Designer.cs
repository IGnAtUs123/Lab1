namespace View
{
    
    partial class Главная
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
            addButton.Location = new Point(640, 31);
            addButton.Name = "addButton";
            addButton.Size = new Size(122, 41);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(503, 31);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(122, 41);
            removeButton.TabIndex = 1;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, studId });
            listView.Location = new Point(35, 78);
            listView.Name = "listView";
            listView.Size = new Size(727, 342);
            listView.TabIndex = 2;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            listView.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            showAllButton.Location = new Point(363, 31);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(122, 41);
            showAllButton.TabIndex = 3;
            showAllButton.Text = "Показать студентов";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += showAllButton_Click;
            // 
            // histogramButton
            // 
            histogramButton.Location = new Point(174, 31);
            histogramButton.Name = "histogramButton";
            histogramButton.Size = new Size(170, 41);
            histogramButton.TabIndex = 4;
            histogramButton.Text = "Показать Гистограмму";
            histogramButton.UseVisualStyleBackColor = true;
            histogramButton.Click += histogramButton_Click;
            // 
            // Главная
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 450);
            Controls.Add(histogramButton);
            Controls.Add(showAllButton);
            Controls.Add(listView);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Name = "Главная";
            Text = "Главная";
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
