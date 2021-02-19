
namespace Assignment_3
{
    partial class Form1
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
            this.count_Box = new System.Windows.Forms.GroupBox();
            this.numStudents_error = new System.Windows.Forms.Label();
            this.numAssign_error = new System.Windows.Forms.Label();
            this.submitCount_btn = new System.Windows.Forms.Button();
            this.numAssign_label = new System.Windows.Forms.Label();
            this.numStudents_label = new System.Windows.Forms.Label();
            this.assignNumInputBox = new System.Windows.Forms.TextBox();
            this.studentInputBox = new System.Windows.Forms.TextBox();
            this.nav_Box = new System.Windows.Forms.GroupBox();
            this.lastStudent_btn = new System.Windows.Forms.Button();
            this.nextStudent_btn = new System.Windows.Forms.Button();
            this.prevStudent_btn = new System.Windows.Forms.Button();
            this.firstStudent_btn = new System.Windows.Forms.Button();
            this.sInfoBox_1 = new System.Windows.Forms.GroupBox();
            this.saveName_btn = new System.Windows.Forms.Button();
            this.sInfoTextBox = new System.Windows.Forms.TextBox();
            this.studentNum_label = new System.Windows.Forms.Label();
            this.sInfoBox_2 = new System.Windows.Forms.GroupBox();
            this.saveScore_btn = new System.Windows.Forms.Button();
            this.assignScoreTextBox = new System.Windows.Forms.TextBox();
            this.assignNumTextBox = new System.Windows.Forms.TextBox();
            this.assignScore_label = new System.Windows.Forms.Label();
            this.assignNum_label = new System.Windows.Forms.Label();
            this.resetScores_btn = new System.Windows.Forms.Button();
            this.displayScores_btn = new System.Windows.Forms.Button();
            this.displayOutput_Box = new System.Windows.Forms.RichTextBox();
            this.count_Box.SuspendLayout();
            this.nav_Box.SuspendLayout();
            this.sInfoBox_1.SuspendLayout();
            this.sInfoBox_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // count_Box
            // 
            this.count_Box.Controls.Add(this.numStudents_error);
            this.count_Box.Controls.Add(this.numAssign_error);
            this.count_Box.Controls.Add(this.submitCount_btn);
            this.count_Box.Controls.Add(this.numAssign_label);
            this.count_Box.Controls.Add(this.numStudents_label);
            this.count_Box.Controls.Add(this.assignNumInputBox);
            this.count_Box.Controls.Add(this.studentInputBox);
            this.count_Box.Location = new System.Drawing.Point(17, 16);
            this.count_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.count_Box.Name = "count_Box";
            this.count_Box.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.count_Box.Size = new System.Drawing.Size(667, 123);
            this.count_Box.TabIndex = 0;
            this.count_Box.TabStop = false;
            this.count_Box.Text = "Counts";
            this.count_Box.Enter += new System.EventHandler(this.count_Box_Enter);
            // 
            // numStudents_error
            // 
            this.numStudents_error.AutoSize = true;
            this.numStudents_error.ForeColor = System.Drawing.Color.Red;
            this.numStudents_error.Location = new System.Drawing.Point(251, 14);
            this.numStudents_error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numStudents_error.Name = "numStudents_error";
            this.numStudents_error.Size = new System.Drawing.Size(0, 17);
            this.numStudents_error.TabIndex = 6;
            // 
            // numAssign_error
            // 
            this.numAssign_error.AutoSize = true;
            this.numAssign_error.ForeColor = System.Drawing.Color.Red;
            this.numAssign_error.Location = new System.Drawing.Point(251, 106);
            this.numAssign_error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numAssign_error.Name = "numAssign_error";
            this.numAssign_error.Size = new System.Drawing.Size(0, 17);
            this.numAssign_error.TabIndex = 5;
            // 
            // submitCount_btn
            // 
            this.submitCount_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCount_btn.Location = new System.Drawing.Point(459, 47);
            this.submitCount_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitCount_btn.Name = "submitCount_btn";
            this.submitCount_btn.Size = new System.Drawing.Size(167, 52);
            this.submitCount_btn.TabIndex = 4;
            this.submitCount_btn.Text = "Submit Counts";
            this.submitCount_btn.UseVisualStyleBackColor = true;
            this.submitCount_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // numAssign_label
            // 
            this.numAssign_label.AutoSize = true;
            this.numAssign_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAssign_label.Location = new System.Drawing.Point(15, 79);
            this.numAssign_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numAssign_label.Name = "numAssign_label";
            this.numAssign_label.Size = new System.Drawing.Size(214, 20);
            this.numAssign_label.TabIndex = 3;
            this.numAssign_label.Text = "Number of assigmnents:";
            // 
            // numStudents_label
            // 
            this.numStudents_label.AutoSize = true;
            this.numStudents_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStudents_label.Location = new System.Drawing.Point(59, 33);
            this.numStudents_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numStudents_label.Name = "numStudents_label";
            this.numStudents_label.Size = new System.Drawing.Size(180, 20);
            this.numStudents_label.TabIndex = 2;
            this.numStudents_label.Text = "Number of students:";
            this.numStudents_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // assignNumInputBox
            // 
            this.assignNumInputBox.Location = new System.Drawing.Point(255, 78);
            this.assignNumInputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignNumInputBox.Name = "assignNumInputBox";
            this.assignNumInputBox.Size = new System.Drawing.Size(132, 22);
            this.assignNumInputBox.TabIndex = 1;
            this.assignNumInputBox.TextChanged += new System.EventHandler(this.assignNumInputBox_TextChanged);
            // 
            // studentInputBox
            // 
            this.studentInputBox.Location = new System.Drawing.Point(255, 33);
            this.studentInputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentInputBox.Name = "studentInputBox";
            this.studentInputBox.Size = new System.Drawing.Size(132, 22);
            this.studentInputBox.TabIndex = 0;
            this.studentInputBox.TextChanged += new System.EventHandler(this.studentInputBox_TextChanged);
            // 
            // nav_Box
            // 
            this.nav_Box.Controls.Add(this.lastStudent_btn);
            this.nav_Box.Controls.Add(this.nextStudent_btn);
            this.nav_Box.Controls.Add(this.prevStudent_btn);
            this.nav_Box.Controls.Add(this.firstStudent_btn);
            this.nav_Box.Location = new System.Drawing.Point(17, 167);
            this.nav_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nav_Box.Name = "nav_Box";
            this.nav_Box.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nav_Box.Size = new System.Drawing.Size(804, 86);
            this.nav_Box.TabIndex = 1;
            this.nav_Box.TabStop = false;
            this.nav_Box.Text = "Navigate";
            // 
            // lastStudent_btn
            // 
            this.lastStudent_btn.CausesValidation = false;
            this.lastStudent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastStudent_btn.Location = new System.Drawing.Point(605, 23);
            this.lastStudent_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastStudent_btn.Name = "lastStudent_btn";
            this.lastStudent_btn.Size = new System.Drawing.Size(163, 52);
            this.lastStudent_btn.TabIndex = 8;
            this.lastStudent_btn.TabStop = false;
            this.lastStudent_btn.Text = ">> Last Student";
            this.lastStudent_btn.UseVisualStyleBackColor = true;
            this.lastStudent_btn.Click += new System.EventHandler(this.lastStudent_btn_Click);
            // 
            // nextStudent_btn
            // 
            this.nextStudent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextStudent_btn.Location = new System.Drawing.Point(415, 23);
            this.nextStudent_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextStudent_btn.Name = "nextStudent_btn";
            this.nextStudent_btn.Size = new System.Drawing.Size(163, 52);
            this.nextStudent_btn.TabIndex = 7;
            this.nextStudent_btn.TabStop = false;
            this.nextStudent_btn.Text = "> Next Student";
            this.nextStudent_btn.UseVisualStyleBackColor = true;
            this.nextStudent_btn.Click += new System.EventHandler(this.nextStudent_btn_Click);
            // 
            // prevStudent_btn
            // 
            this.prevStudent_btn.CausesValidation = false;
            this.prevStudent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevStudent_btn.Location = new System.Drawing.Point(225, 23);
            this.prevStudent_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prevStudent_btn.Name = "prevStudent_btn";
            this.prevStudent_btn.Size = new System.Drawing.Size(163, 52);
            this.prevStudent_btn.TabIndex = 6;
            this.prevStudent_btn.TabStop = false;
            this.prevStudent_btn.Text = "<Prev Student";
            this.prevStudent_btn.UseVisualStyleBackColor = true;
            this.prevStudent_btn.Click += new System.EventHandler(this.prevStudent_btn_Click);
            // 
            // firstStudent_btn
            // 
            this.firstStudent_btn.CausesValidation = false;
            this.firstStudent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstStudent_btn.Location = new System.Drawing.Point(36, 23);
            this.firstStudent_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstStudent_btn.Name = "firstStudent_btn";
            this.firstStudent_btn.Size = new System.Drawing.Size(163, 52);
            this.firstStudent_btn.TabIndex = 5;
            this.firstStudent_btn.TabStop = false;
            this.firstStudent_btn.Text = "<< First Student";
            this.firstStudent_btn.UseVisualStyleBackColor = true;
            this.firstStudent_btn.Click += new System.EventHandler(this.firstStudent_btn_Click);
            // 
            // sInfoBox_1
            // 
            this.sInfoBox_1.Controls.Add(this.saveName_btn);
            this.sInfoBox_1.Controls.Add(this.sInfoTextBox);
            this.sInfoBox_1.Controls.Add(this.studentNum_label);
            this.sInfoBox_1.Location = new System.Drawing.Point(17, 287);
            this.sInfoBox_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sInfoBox_1.Name = "sInfoBox_1";
            this.sInfoBox_1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sInfoBox_1.Size = new System.Drawing.Size(804, 79);
            this.sInfoBox_1.TabIndex = 2;
            this.sInfoBox_1.TabStop = false;
            this.sInfoBox_1.Text = "Student Info";
            // 
            // saveName_btn
            // 
            this.saveName_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveName_btn.Location = new System.Drawing.Point(605, 26);
            this.saveName_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveName_btn.Name = "saveName_btn";
            this.saveName_btn.Size = new System.Drawing.Size(133, 36);
            this.saveName_btn.TabIndex = 9;
            this.saveName_btn.TabStop = false;
            this.saveName_btn.Text = "Save Name";
            this.saveName_btn.UseVisualStyleBackColor = true;
            this.saveName_btn.Click += new System.EventHandler(this.saveName_btn_Click);
            // 
            // sInfoTextBox
            // 
            this.sInfoTextBox.Location = new System.Drawing.Point(152, 33);
            this.sInfoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sInfoTextBox.Name = "sInfoTextBox";
            this.sInfoTextBox.Size = new System.Drawing.Size(416, 22);
            this.sInfoTextBox.TabIndex = 6;
            this.sInfoTextBox.TextChanged += new System.EventHandler(this.sInfoTextBox_TextChanged);
            // 
            // studentNum_label
            // 
            this.studentNum_label.AutoSize = true;
            this.studentNum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNum_label.Location = new System.Drawing.Point(32, 33);
            this.studentNum_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentNum_label.Name = "studentNum_label";
            this.studentNum_label.Size = new System.Drawing.Size(105, 20);
            this.studentNum_label.TabIndex = 5;
            this.studentNum_label.Text = "Student #1:";
            // 
            // sInfoBox_2
            // 
            this.sInfoBox_2.Controls.Add(this.saveScore_btn);
            this.sInfoBox_2.Controls.Add(this.assignScoreTextBox);
            this.sInfoBox_2.Controls.Add(this.assignNumTextBox);
            this.sInfoBox_2.Controls.Add(this.assignScore_label);
            this.sInfoBox_2.Controls.Add(this.assignNum_label);
            this.sInfoBox_2.Location = new System.Drawing.Point(17, 393);
            this.sInfoBox_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sInfoBox_2.Name = "sInfoBox_2";
            this.sInfoBox_2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sInfoBox_2.Size = new System.Drawing.Size(804, 123);
            this.sInfoBox_2.TabIndex = 3;
            this.sInfoBox_2.TabStop = false;
            this.sInfoBox_2.Text = "Student Info";
            // 
            // saveScore_btn
            // 
            this.saveScore_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveScore_btn.Location = new System.Drawing.Point(492, 59);
            this.saveScore_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveScore_btn.Name = "saveScore_btn";
            this.saveScore_btn.Size = new System.Drawing.Size(133, 36);
            this.saveScore_btn.TabIndex = 10;
            this.saveScore_btn.Text = "Save Score";
            this.saveScore_btn.UseVisualStyleBackColor = true;
            this.saveScore_btn.Click += new System.EventHandler(this.saveScore_btn_Click);
            // 
            // assignScoreTextBox
            // 
            this.assignScoreTextBox.Location = new System.Drawing.Point(340, 75);
            this.assignScoreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignScoreTextBox.Name = "assignScoreTextBox";
            this.assignScoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.assignScoreTextBox.TabIndex = 13;
            // 
            // assignNumTextBox
            // 
            this.assignNumTextBox.Location = new System.Drawing.Point(341, 41);
            this.assignNumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignNumTextBox.Name = "assignNumTextBox";
            this.assignNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.assignNumTextBox.TabIndex = 12;
            // 
            // assignScore_label
            // 
            this.assignScore_label.AutoSize = true;
            this.assignScore_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignScore_label.Location = new System.Drawing.Point(149, 75);
            this.assignScore_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignScore_label.Name = "assignScore_label";
            this.assignScore_label.Size = new System.Drawing.Size(168, 20);
            this.assignScore_label.TabIndex = 11;
            this.assignScore_label.Text = "Assignment Score:";
            // 
            // assignNum_label
            // 
            this.assignNum_label.AutoSize = true;
            this.assignNum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignNum_label.Location = new System.Drawing.Point(32, 41);
            this.assignNum_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignNum_label.Name = "assignNum_label";
            this.assignNum_label.Size = new System.Drawing.Size(284, 20);
            this.assignNum_label.TabIndex = 10;
            this.assignNum_label.Text = "Enter Assignment Number (1-X):";
            // 
            // resetScores_btn
            // 
            this.resetScores_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetScores_btn.Location = new System.Drawing.Point(757, 63);
            this.resetScores_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetScores_btn.Name = "resetScores_btn";
            this.resetScores_btn.Size = new System.Drawing.Size(140, 55);
            this.resetScores_btn.TabIndex = 5;
            this.resetScores_btn.Text = "Reset Scores";
            this.resetScores_btn.UseVisualStyleBackColor = true;
            this.resetScores_btn.Click += new System.EventHandler(this.resetScores_btn_Click);
            // 
            // displayScores_btn
            // 
            this.displayScores_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayScores_btn.Location = new System.Drawing.Point(335, 523);
            this.displayScores_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayScores_btn.Name = "displayScores_btn";
            this.displayScores_btn.Size = new System.Drawing.Size(208, 47);
            this.displayScores_btn.TabIndex = 14;
            this.displayScores_btn.Text = "Display Scores";
            this.displayScores_btn.UseVisualStyleBackColor = true;
            this.displayScores_btn.Click += new System.EventHandler(this.displayScores_btn_Click);
            // 
            // displayOutput_Box
            // 
            this.displayOutput_Box.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOutput_Box.Location = new System.Drawing.Point(17, 598);
            this.displayOutput_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayOutput_Box.Name = "displayOutput_Box";
            this.displayOutput_Box.ReadOnly = true;
            this.displayOutput_Box.Size = new System.Drawing.Size(932, 226);
            this.displayOutput_Box.TabIndex = 15;
            this.displayOutput_Box.Text = "";
            this.displayOutput_Box.WordWrap = false;
            this.displayOutput_Box.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 839);
            this.Controls.Add(this.displayOutput_Box);
            this.Controls.Add(this.displayScores_btn);
            this.Controls.Add(this.resetScores_btn);
            this.Controls.Add(this.sInfoBox_2);
            this.Controls.Add(this.sInfoBox_1);
            this.Controls.Add(this.nav_Box);
            this.Controls.Add(this.count_Box);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Scores";
            this.count_Box.ResumeLayout(false);
            this.count_Box.PerformLayout();
            this.nav_Box.ResumeLayout(false);
            this.sInfoBox_1.ResumeLayout(false);
            this.sInfoBox_1.PerformLayout();
            this.sInfoBox_2.ResumeLayout(false);
            this.sInfoBox_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox count_Box;
        private System.Windows.Forms.GroupBox nav_Box;
        private System.Windows.Forms.GroupBox sInfoBox_1;
        private System.Windows.Forms.GroupBox sInfoBox_2;
        private System.Windows.Forms.TextBox assignNumInputBox;
        private System.Windows.Forms.TextBox studentInputBox;
        private System.Windows.Forms.Label numStudents_label;
        private System.Windows.Forms.Label numAssign_label;
        private System.Windows.Forms.Button submitCount_btn;
        private System.Windows.Forms.Button resetScores_btn;
        private System.Windows.Forms.Button firstStudent_btn;
        private System.Windows.Forms.Button prevStudent_btn;
        private System.Windows.Forms.Button nextStudent_btn;
        private System.Windows.Forms.Button lastStudent_btn;
        private System.Windows.Forms.Label studentNum_label;
        private System.Windows.Forms.TextBox sInfoTextBox;
        private System.Windows.Forms.Button saveName_btn;
        private System.Windows.Forms.Label assignNum_label;
        private System.Windows.Forms.Label assignScore_label;
        private System.Windows.Forms.TextBox assignNumTextBox;
        private System.Windows.Forms.TextBox assignScoreTextBox;
        private System.Windows.Forms.Button saveScore_btn;
        private System.Windows.Forms.Button displayScores_btn;
        private System.Windows.Forms.RichTextBox displayOutput_Box;
        private System.Windows.Forms.Label numAssign_error;
        private System.Windows.Forms.Label numStudents_error;
    }
}

