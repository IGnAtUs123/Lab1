namespace View
{
    partial class DeleteForm
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
            deleteBtn = new Button();
            label43 = new Label();
            studId = new TextBox();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(626, 341);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(134, 52);
            deleteBtn.TabIndex = 0;
            deleteBtn.Text = "Удалить";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 18F);
            label43.Location = new Point(60, 164);
            label43.Name = "label43";
            label43.Size = new Size(240, 32);
            label43.TabIndex = 1;
            label43.Text = "Студенческий билет";
            label43.Click += label1_Click;
            // 
            // studId
            // 
            studId.Location = new Point(60, 199);
            studId.Name = "studId";
            studId.Size = new Size(700, 23);
            studId.TabIndex = 2;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studId);
            Controls.Add(label43);
            Controls.Add(deleteBtn);
            Name = "DeleteForm";
            Text = "DeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private Label label43;
        private TextBox studId;
    }
}