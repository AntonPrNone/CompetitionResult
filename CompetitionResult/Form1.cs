using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace CompetitionResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string input;
        public string selectedNamePer;
        public string maxTimePer;

        public string namePer;
        public string raceTimePer;
        public string DateRacePer;
        public string TimeRacePer;

        private void OpenFileButton_Click(object sender, EventArgs e) // При нажатии на кнопку Open File
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    input = sr.ReadToEnd();
                    sr.Close();
                }

                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }

            input += '\n';
            input.TrimStart('\n');
        }

        private void PutButton_Click(object sender, EventArgs e)  // При нажатии на кнопку Put
        {
            namePer = name.Text;
            raceTimePer = raceTime.Text;
            DateRacePer = Convert.ToString(DateRace.Value.ToShortDateString());
            TimeRacePer = Convert.ToString(TimeRace.Text);

            // Обработка исключений при неверном формате ввода

            if (namePer.Length == 0)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Athlete's name"" ";
            }

            else if (raceTimePer.Length == 0)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Race Time"" ";
            }

            else if (TimeRacePer.Length != 8)
            {
                Heading.ForeColor = Color.Red;
                Heading.Text = @"Invalid field input format ""Time race"" ";
            }
            
            else // Если формат ввода верный
            {
                Heading.ForeColor = Color.Green;
                Heading.Text = "Spammer Detection";

                input += namePer + ", " + DateRacePer + " " + TimeRacePer + ", " + raceTimePer + "\n";
            }
        }
    }
}
