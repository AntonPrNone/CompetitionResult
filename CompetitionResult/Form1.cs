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
        public int maxTimePer;

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

        private void SaveAndCloseButton_Click(object sender, EventArgs e) // При нажатии на кнопку Save And Close
        {
            var rs = new StreamWriter(openFileDialog1.FileName, false);
            rs.WriteLine(input);
            rs.Close();
        }

        private void SaveReportButton_Click(object sender, EventArgs e) // При нажатии на кнопку Save Report
        {
            string otchet = "";
            selectedNamePer = selectedName.Text;
            maxTimePer = Int32.Parse(maxTime.Text);

            var sr = new StreamReader(openFileDialog1.FileName);
            int lenfile = sr.ReadToEnd().Split('\n').Length;
            sr = new StreamReader(openFileDialog1.FileName);

            ArrayList names = new ArrayList();
            ArrayList dates = new ArrayList();
            ArrayList raceTimes = new ArrayList();

            for (int i = 0; i < lenfile; i++)
            {
                string inputline = sr.ReadLine();
                if (inputline != "\n" && inputline != "" && inputline != null)
                {
                    names.Add(inputline.Split(',')[0].Trim());
                    dates.Add(DateTime.Parse(inputline.Split(',')[1].Trim()));
                    raceTimes.Add(Int32.Parse(inputline.Split(',')[2].Trim()));
                }
            }

            lenfile = names.Count;

            for (int i = 0; i < lenfile; i++)  // Фильтрация забегов
            {
                if (!(selectedNamePer == (string)names[i] && maxTimePer >= (int)raceTimes[i])) 
                {
                    names[i] = "";
                    dates[i] = "";
                    raceTimes[i] = "";
                }
            }

            for (int i = 0; i < lenfile; i++)
            {
                names.Remove("");
                dates.Remove("");
                raceTimes.Remove("");
            }

            string temp1;
            DateTime temp2;
            int temp3;
            for (int i = 0; i < names.Count - 1; i++) // Сортировка забегов по дате
            {
                for (int j = i + 1; j < names.Count; j++)
                {
                    if ((DateTime)dates[i] > (DateTime)dates[j])
                    {
                        temp1 = (string)names[i];
                        names[i] = names[j];
                        names[j] = temp1;

                        temp2 = (DateTime)dates[i];
                        dates[i] = dates[j];
                        dates[j] = temp2;

                        temp3 = (int)raceTimes[i];
                        raceTimes[i] = raceTimes[j];
                        raceTimes[j] = temp3;
                    }
                }
            }

            names.Reverse();
            dates.Reverse();
            raceTimes.Reverse();

            for (int i = 0; i < names.Count; i++)   
            {
                otchet += names[i] + ", " + dates[i] + ", " + raceTimes[i] + '\n';
            }

            otchet = otchet.TrimEnd('\n');

            System.IO.File.WriteAllText("C:\\Users\\201904\\Documents\\Report.txt", otchet);
        }
    }
}
