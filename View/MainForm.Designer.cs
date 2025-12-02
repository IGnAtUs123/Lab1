namespace View
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
            label1 = new Label();
            txtName = new TextBox();
            txtSpec = new TextBox();
            label2 = new Label();
            txtGroup = new TextBox();
            label3 = new Label();
            studId = new TextBox();
            label4 = new Label();
            addButton = new Button();
            removeButton = new Button();
            linkLabel1 = new LinkLabel();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(467, 27);
            txtName.TabIndex = 1;
            // 
            // txtSpec
            // 
            txtSpec.Location = new Point(501, 42);
            txtSpec.Name = "txtSpec";
            txtSpec.Size = new Size(476, 27);
            txtSpec.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 19);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Специальность";
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(12, 110);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(467, 27);
            txtGroup.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Группа";
            // 
            // studId
            // 
            studId.Location = new Point(501, 110);
            studId.Name = "studId";
            studId.Size = new Size(476, 27);
            studId.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 87);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 6;
            label4.Text = "Номер студенческого";
            // 
            // addButton
            // 
            addButton.Location = new Point(41, 159);
            addButton.Name = "addButton";
            addButton.Size = new Size(179, 29);
            addButton.TabIndex = 8;
            addButton.Text = "Добавить студента";
            addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(240, 159);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(159, 29);
            removeButton.TabIndex = 9;
            removeButton.Text = "Удалить студента";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(700, 307);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 11;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView.Location = new Point(12, 209);
            listView.Name = "listView";
            listView.Size = new Size(965, 392);
            listView.TabIndex = 12;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ФИО";
            columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Специальность";
            columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Группа";
            columnHeader3.Width = 240;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Номер студенческого ";
            columnHeader4.Width = 240;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 637);
            Controls.Add(listView);
            Controls.Add(linkLabel1);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(studId);
            Controls.Add(label4);
            Controls.Add(txtGroup);
            Controls.Add(label3);
            Controls.Add(txtSpec);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtSpec;
        private Label label2;
        private TextBox txtGroup;
        private Label label3;
        private TextBox studId;
        private Label label4;
        private Button addButton;
        private Button removeButton;
        private LinkLabel linkLabel1;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
