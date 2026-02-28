using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Student_Grade_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBackground.BackColor = Color.FromArgb(200, 15, 30, 22);
        }

        // Method to draw perfectly smooth rounded corners
        private void MakeRounded(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Validation for empty name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the student's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation for numeric grades
            if (double.TryParse(txtEnglish.Text, out double english) &&
                double.TryParse(txtMath.Text, out double math) &&
                double.TryParse(txtScience.Text, out double science) &&
                double.TryParse(txtFilipino.Text, out double filipino) &&
                double.TryParse(txtHistory.Text, out double history))
            {
                // Calculate average
                double average = (english + math + science + filipino + history) / 5;

                // Ternary operator to determine pass/fail status
                string status = average >= 75.00 ? "passed" : "failed";

                // Display results
                lblResult.Text = $"The student {status}.\nThe general average of {txtName.Text} is {average:F2}.";

                // Colors that pop on a dark background: Pale Green for pass, Soft Red for fail
                lblResult.ForeColor = average >= 75.00 ? Color.FromArgb(160, 240, 160) : Color.FromArgb(255, 140, 140);
            }
            else
            {
                MessageBox.Show("Please enter valid numeric grades for all subjects.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hover effect for the button
        private void btnGenerate_MouseEnter(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.FromArgb(60, 120, 85);
        }

        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.FromArgb(45, 90, 65);
        }
    }
}