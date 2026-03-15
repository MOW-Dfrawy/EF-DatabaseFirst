namespace EF_D1
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
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cb_topics = new ComboBox();
            txt_Duration = new TextBox();
            txt_name = new TextBox();
            dgv_course = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_course).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(471, 105);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(226, 37);
            btn_delete.TabIndex = 23;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(471, 54);
            btn_update.Margin = new Padding(2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(226, 37);
            btn_update.TabIndex = 22;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(471, 11);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(226, 37);
            btn_add.TabIndex = 21;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 20;
            label4.Text = "Course Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 124);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 18;
            label2.Text = "Topics";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 17;
            label1.Text = "Course Name";
            // 
            // cb_topics
            // 
            cb_topics.FormattingEnabled = true;
            cb_topics.Location = new Point(112, 121);
            cb_topics.Margin = new Padding(2);
            cb_topics.Name = "cb_topics";
            cb_topics.Size = new Size(139, 23);
            cb_topics.TabIndex = 16;
            // 
            // txt_Duration
            // 
            txt_Duration.Location = new Point(112, 83);
            txt_Duration.Margin = new Padding(2);
            txt_Duration.Name = "txt_Duration";
            txt_Duration.Size = new Size(139, 23);
            txt_Duration.TabIndex = 15;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(112, 43);
            txt_name.Margin = new Padding(2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(139, 23);
            txt_name.TabIndex = 13;
            // 
            // dgv_course
            // 
            dgv_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_course.Location = new Point(11, 181);
            dgv_course.Margin = new Padding(2);
            dgv_course.Name = "dgv_course";
            dgv_course.RowHeadersWidth = 62;
            dgv_course.Size = new Size(384, 258);
            dgv_course.TabIndex = 12;
            dgv_course.RowHeaderMouseDoubleClick += dgv_course_RowHeaderMouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_topics);
            Controls.Add(txt_Duration);
            Controls.Add(txt_name);
            Controls.Add(dgv_course);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dgv_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cb_topics;
        private TextBox txt_Duration;
        private TextBox txt_name;
        private DataGridView dgv_course;
    }
}
