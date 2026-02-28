namespace Student_Grade_Application
{
    partial class Form1
    {
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.grades = new System.Windows.Forms.Label();
            this.english = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.Label();
            this.science = new System.Windows.Forms.Label();
            this.filipino = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.textBoxScience = new System.Windows.Forms.TextBox();
            this.textBoxFilipino = new System.Windows.Forms.TextBox();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.averageButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.averageButton);
            this.panel1.Controls.Add(this.textBoxHistory);
            this.panel1.Controls.Add(this.textBoxFilipino);
            this.panel1.Controls.Add(this.textBoxScience);
            this.panel1.Controls.Add(this.textBoxMath);
            this.panel1.Controls.Add(this.textBoxEnglish);
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.filipino);
            this.panel1.Controls.Add(this.science);
            this.panel1.Controls.Add(this.math);
            this.panel1.Controls.Add(this.english);
            this.panel1.Controls.Add(this.grades);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(164, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 419);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(190, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(131, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Student Grade Application";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(29, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // grades
            // 
            this.grades.AutoSize = true;
            this.grades.Location = new System.Drawing.Point(32, 115);
            this.grades.Name = "grades";
            this.grades.Size = new System.Drawing.Size(41, 13);
            this.grades.TabIndex = 4;
            this.grades.Text = "Grades";
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Location = new System.Drawing.Point(32, 148);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(41, 13);
            this.english.TabIndex = 5;
            this.english.Text = "English";
            // 
            // math
            // 
            this.math.AutoSize = true;
            this.math.Location = new System.Drawing.Point(29, 178);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(31, 13);
            this.math.TabIndex = 6;
            this.math.Text = "Math";
            // 
            // science
            // 
            this.science.AutoSize = true;
            this.science.Location = new System.Drawing.Point(35, 208);
            this.science.Name = "science";
            this.science.Size = new System.Drawing.Size(46, 13);
            this.science.TabIndex = 7;
            this.science.Text = "Science";
            // 
            // filipino
            // 
            this.filipino.AutoSize = true;
            this.filipino.Location = new System.Drawing.Point(38, 242);
            this.filipino.Name = "filipino";
            this.filipino.Size = new System.Drawing.Size(39, 13);
            this.filipino.TabIndex = 8;
            this.filipino.Text = "Filipino";
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Location = new System.Drawing.Point(32, 271);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(39, 13);
            this.history.TabIndex = 9;
            this.history.Text = "History";
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(115, 148);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnglish.TabIndex = 10;
            // 
            // textBoxMath
            // 
            this.textBoxMath.Location = new System.Drawing.Point(115, 178);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(100, 20);
            this.textBoxMath.TabIndex = 11;
            // 
            // textBoxScience
            // 
            this.textBoxScience.Location = new System.Drawing.Point(115, 208);
            this.textBoxScience.Name = "textBoxScience";
            this.textBoxScience.Size = new System.Drawing.Size(100, 20);
            this.textBoxScience.TabIndex = 12;
            // 
            // textBoxFilipino
            // 
            this.textBoxFilipino.Location = new System.Drawing.Point(115, 242);
            this.textBoxFilipino.Name = "textBoxFilipino";
            this.textBoxFilipino.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilipino.TabIndex = 13;
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Location = new System.Drawing.Point(115, 271);
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.Size = new System.Drawing.Size(100, 20);
            this.textBoxHistory.TabIndex = 14;
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(72, 323);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(118, 35);
            this.averageButton.TabIndex = 15;
            this.averageButton.Text = "Generate Button";
            this.averageButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Grade_Application.Properties.Resources.forest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grade Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBoxFilipino;
        private System.Windows.Forms.TextBox textBoxScience;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Label filipino;
        private System.Windows.Forms.Label science;
        private System.Windows.Forms.Label math;
        private System.Windows.Forms.Label english;
        private System.Windows.Forms.Label grades;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.TextBox textBoxHistory;
    }
}

