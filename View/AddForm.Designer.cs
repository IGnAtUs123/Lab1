namespace View
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addBtn = new Button();
            Name = new Label();
            group = new Label();
            speciality = new Label();
            txtName = new TextBox();
            txtSpec = new TextBox();
            txtGroup = new TextBox();
            studId = new TextBox();
            labe4 = new Label();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(634, 373);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(131, 53);
            addBtn.TabIndex = 0;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += button1_Click;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 18F);
            Name.Location = new Point(70, 27);
            Name.Name = "Name";
            Name.Size = new Size(67, 32);
            Name.TabIndex = 1;
            Name.Text = "ФИО";
            Name.Click += label1_Click;
            // 
            // group
            // 
            group.AutoSize = true;
            group.Font = new Font("Segoe UI", 18F);
            group.Location = new Point(70, 197);
            group.Name = "group";
            group.Size = new Size(91, 32);
            group.TabIndex = 2;
            group.Text = "Группа";
            group.Click += group_Click;
            // 
            // speciality
            // 
            speciality.AutoSize = true;
            speciality.Font = new Font("Segoe UI", 18F);
            speciality.Location = new Point(70, 110);
            speciality.Name = "speciality";
            speciality.Size = new Size(182, 32);
            speciality.TabIndex = 3;
            speciality.Text = "Специальность";
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(695, 23);
            txtName.TabIndex = 4;
            // 
            // txtSpec
            // 
            txtSpec.Location = new Point(70, 145);
            txtSpec.Name = "txtSpec";
            txtSpec.Size = new Size(695, 23);
            txtSpec.TabIndex = 5;
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(70, 235);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(695, 23);
            txtGroup.TabIndex = 6;
            // 
            // studId
            // 
            studId.Location = new Point(70, 321);
            studId.Name = "studId";
            studId.Size = new Size(695, 23);
            studId.TabIndex = 8;
            // 
            // labe4
            // 
            labe4.AutoSize = true;
            labe4.Font = new Font("Segoe UI", 18F);
            labe4.Location = new Point(70, 285);
            labe4.Name = "labe4";
            labe4.Size = new Size(240, 32);
            labe4.TabIndex = 7;
            labe4.Text = "Студенческий билет";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studId);
            Controls.Add(labe4);
            Controls.Add(txtGroup);
            Controls.Add(txtSpec);
            Controls.Add(txtName);
            Controls.Add(speciality);
            Controls.Add(group);
            Controls.Add(Name);
            Controls.Add(addBtn);
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label Name;
        private Label group;
        private Label speciality;
        private TextBox txtName;
        private TextBox txtSpec;
        private TextBox txtGroup;
        private TextBox studId;
        private Label labe4;
    }
}