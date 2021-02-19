using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        int numStudents = 0;
        int numAssign = 0;
        string studentName = ""; 
        int assignNum;
        int assignScore;
        double avgScore = 0.0;
        double scores = 0;
        string student = "STUDENT";
        double gradeScore = 0;
        string grade = "GRADE";
        string average = "AVERAGE";
        string displayAssignNum = "";
        int assignCount = 0;

        string[] nameArr = { }; //empty single-dim array to hold names
        int[,] assignArr = { }; // empty multi-dim array to hold student scores
        int studentCount = 0;
        private int studentIndex = 0; // global counter for single dim nameArr
        private int row = 0; //global counter for 2d array (rows)
        private int col = 0; //global counter for 2d array (columns)

        /// <summary>
        /// ===TODO LIST ===
        /// -**FINISHED**Update code to change array position when students enter assignment number into the textbox
        /// -**FINISHED**Update assignment score for specific assignArr[row,col] after the 'Save Score' button is clicked.
        /// -**FINISHED**Figure out how to display all student values in the array to the rich text box
       ///  -TODO:
       ///  -**FINISHED**Display key values (student, assignment #'s) to the screen before displaying actual values. 
       ///  -**FINISHED**Create letter grade switch to figure out letter. (scores / (numAssign * 100)), switch (or if-else block) to determine grade.
        /// -**FINISHED**(Last Hard thing): Validate all user input according to Assignment #3 requirements
        /// -**FINISHED**program Reset Button method
        /// 
        /// ==UNIT TESTS PASSED! Configuration Locked. 
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            nav_Box.Enabled = false;
            sInfoBox_1.Enabled = false;
            sInfoBox_2.Enabled = false;
            displayScores_btn.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// This method handles the 'Submit Counts' button click.
        /// This is where we will create the arrays and set everything up to 
        /// allow for student names to be entered, and assignment scores 
        /// for each student as well. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            ///These 2 methods check to make sure that the # of students and # of assignments don't exceed maximums.       
            if (numStudents > 10)
            {
                numStudents_error.Text = "Maximum of 10 Students only.";
                return;
            }
            if (numAssign > 99)
            {
                numAssign_error.Text = "Maximum of 99 assignments only.";
                return;
            }
            numStudents_error.Text = "";
            numAssign_error.Text = "";
            nameArr = new string[numStudents]; // sets single-dim array size to equal # of students.
            assignArr = new int[numStudents, numAssign]; //creates multi-dim array size (# of students * # of assignments)
                 
            /// This loop handles populating all assignment array scores to 0 (integers)
            for (row = 0; row < assignArr.GetLength(0)-1; row++)
            {
                for (col = 0; col < assignArr.GetLength(1)-1; col++)
                {
                    assignArr[row, col] = 0;
                }
            }
            row = 0;
            col = 0;
            studentIndex = 0;
            assignCount = 0;

            /// This loop handles populating the single-dim array with student names (numbered proper)
            for(studentIndex = 0; studentIndex < nameArr.Length; studentIndex++)
            {
                studentCount++;
                nameArr[studentIndex] = "Student #" + Convert.ToString(studentCount) + ":";
            }  
            nav_Box.Enabled = true;
            sInfoBox_1.Enabled = true;
            sInfoBox_2.Enabled = true;
            displayScores_btn.Enabled = true;
            row = 0;
            col = 0;
            studentIndex = 0;
            studentNum_label.Text = nameArr[studentIndex];
            assignNum_label.Text = "Enter Assignment Number (1-" + numAssign + "):";
        }

        
        /// <summary>
        /// This method is for the numOfStudents input text box. This is where
        /// we will handle user input and initially setting all of the buttons 
        /// below to disabled. This will make sure that the users can't interact 
        /// with the buttons before the 'Counts' have been submited. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void studentInputBox_TextChanged(object sender, EventArgs e)
        {
           numStudents = Convert.ToInt32(studentInputBox.Text);
            
        }

        /// <summary>
        /// This method handles the input of number of assignments for the students. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assignNumInputBox_TextChanged(object sender, EventArgs e)
        {
            numAssign = Convert.ToInt32(assignNumInputBox.Text);
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// This method will handle calculating the average grade, assigning a letter grade, then
        /// it will loop through both arrays, convert all scores to strings and append
        /// them together using stringbuilder. Then it will display the entire output to the screen formatted for 
        /// readability.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayScores_btn_Click(object sender, EventArgs e)
        {
            string add = "";
            StringBuilder s = new StringBuilder();  
            s.AppendFormat("{0,10}",student + '\t' + '\t');
            for (int col = 0; col < assignArr.GetLength(1); col++)
            {
                assignCount++;
                displayAssignNum = "#" + Convert.ToString(assignCount); // creates key value for assign num to display.
                s.Append(displayAssignNum + '\t' + '\t');    
            }
            /// This is where we put the append to 's' for displaying the key-values before the true values.     
            s.Append(average + '\t');
            s.Append(grade + '\t');
            s.Append('\n');
            studentIndex = 0;
            ///This nested for-loop below handles getting and displaying the actual values to the screen.
            for (int row = 0; row < assignArr.GetLength(0); row++)
            {
                s.AppendFormat("{0,10}",nameArr[studentIndex] + '\t' + '\t');
                studentIndex++;
                for (int col = 0; col < assignArr.GetLength(1); col++)
                {
                    scores += assignArr[row,col]; //store the score values into the 
                    add = Convert.ToString(assignArr[row, col]); // This assigns the converted values (int -> string) from assignArr to the add string     
                    s.AppendFormat("{0,-4}",add + '\t' + '\t'); //This appends the 'add' string to the 's' stringBuilder object. 
                }
                avgScore = Math.Round((scores / assignNum), 2);
                s.Append(Convert.ToString(avgScore) + '\t' + '\t');
                gradeScore = ((scores / (numAssign*100)) * 100);
                ///This is where we figure out how what the student's letter grade will be. 
                if(gradeScore >= 93.0 && gradeScore <= 100)
                {
                    s.AppendFormat("{0,-4}", 'A');
                }
               else if (gradeScore >= 90 && gradeScore <= 92.9)
                {
                    s.AppendFormat("{0,-4}", "A-");
                }
                else if (gradeScore >= 87 && gradeScore <= 89.9)
                {
                    s.AppendFormat("{0,-4}", "B+");
                }
                else if (gradeScore >= 83 && gradeScore <= 86.9)
                {
                    s.AppendFormat("{0,-4}", "B");
                }
                else if (gradeScore >= 80 && gradeScore <= 82.9)
                {
                    s.AppendFormat("{0,-4}", "B-");
                }
                else if (gradeScore >= 77 && gradeScore <= 79.9)
                {
                    s.AppendFormat("{0,-4}", "C+");
                }
                else if (gradeScore >= 73 && gradeScore <= 76.9)
                {
                    s.AppendFormat("{0,-4}", "C");
                }
                else if (gradeScore >= 70 && gradeScore <= 72.9)
                {
                    s.AppendFormat("{0,-4}", "C-");
                }
                else if (gradeScore >= 67 && gradeScore <= 69.9)
                {
                    s.AppendFormat("{0,-4}", "D+");
                }
                else if (gradeScore >= 63 && gradeScore <= 66.9)
                {
                    s.AppendFormat("{0,-4}", "D");
                }
                else if (gradeScore >= 60 && gradeScore <= 62.9)
                {
                    s.AppendFormat("{0,-4}", "D-");
                }
                else if (gradeScore < 60)
                {
                    s.AppendFormat("{0,-4}", "E");
                }

                avgScore = 0.0;
                scores = 0.0;
                s.Append('\n');
                displayOutput_Box.Text = Convert.ToString(s);///Append the 's' object to a string, and displays to the output box (rich text box)
            }
            studentCount = 0;
            studentIndex = 0;
        }


        /// <summary>
        /// This method handles the First Student  button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstStudent_btn_Click(object sender, EventArgs e)
        {
            studentIndex = 0;
            row = 0;
            studentNum_label.Text = nameArr[studentIndex];
        }


        /// <summary>
        /// this method handles the Last Student button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastStudent_btn_Click(object sender, EventArgs e)
        {
            studentIndex = nameArr.Length-1;
            row = assignArr.Length-1;
            studentNum_label.Text = nameArr[nameArr.Length-1];
        }


        /// <summary>
        /// This method handles the previous student button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevStudent_btn_Click(object sender, EventArgs e)
        {
            if (studentIndex == 0)
            {
                studentIndex = nameArr.Length-1;
                row = assignArr.Length-1;
            }
            else
            {
                studentIndex--;
                row--;
            } 
            studentNum_label.Text = nameArr[studentIndex];     
        }


        /// <summary>
        /// this method handles the next student button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextStudent_btn_Click(object sender, EventArgs e)
        {
            studentIndex++;
            row++;
            if (studentIndex >= nameArr.Length)
            {
                studentIndex = 0;
                row = 0;
            }
            studentNum_label.Text = nameArr[studentIndex]; 
        }

        private void sInfoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method handles the 'Save name" button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void saveName_btn_Click(object sender, EventArgs e)
        {       
            studentName = sInfoTextBox.Text;
            nameArr[studentIndex] = studentName;
            row = studentIndex;
            studentNum_label.Text = nameArr[studentIndex];
        }
       
        /// <summary>
        /// this method will handle inserting the assignment scores into the proper place in the array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void saveScore_btn_Click(object sender, EventArgs e)
        {
            assignNum = Convert.ToInt32(assignNumTextBox.Text);
            assignScore = Convert.ToInt32(assignScoreTextBox.Text);
            col = assignNum-1;
            assignArr[row, col] = assignScore; 
        }

        private void count_Box_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this method handles resetting all values back to zero and restarting the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetScores_btn_Click(object sender, EventArgs e)
        {
            Convert.ToString(sInfoTextBox);
            sInfoTextBox.Text = "";
 
            Convert.ToString(assignNumTextBox.Text);
            assignNumTextBox.Text = "";

            Convert.ToString(assignScoreTextBox.Text);
            assignScoreTextBox.Text = "";

            assignNum_label.Text = "";
            displayOutput_Box.Clear();
            Array.Clear(nameArr, 0, nameArr.Length);
            Array.Clear(assignArr, 0, assignArr.Length);
            studentNum_label.Text = nameArr[studentIndex];
            assignCount = 0;
            nav_Box.Enabled = false;
            sInfoBox_1.Enabled = false;
            sInfoBox_2.Enabled = false;
            displayScores_btn.Enabled = false;
            return;
        }
    }
}
