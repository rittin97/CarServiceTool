using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab2
{
    public partial class Form1 : Form
    {
        string path = @"db.txt";
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtboxModel;
        }

        public void CreateFile()
        {
            Service obj = new Service();
            obj.Months = Convert.ToInt32(txtboxMonth.Text);
            DateTime dt = DateTime.Parse(txtboxDate.Text);
            //txtboxDescription.Text = (dt.ToString("MM/dd/yyyy"));
            obj.date = DateTime.Parse(txtboxDate.Text);
            var dateOnly = obj.Compute_Date().Date;

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    // do nothing but create a file
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("License: {0}", txtboxLicense.Text);
                sw.WriteLine("Curent Service Date: {0}", txtboxDate.Text);
                sw.WriteLine("Model: {0}", txtboxModel.Text);
                sw.WriteLine("Year: {0}", txtboxYear.Text);
                sw.WriteLine("Next Service Date: {0}", dateOnly);
                sw.WriteLine(".");
            }            
        }

        public void SearchFile(int num)
        {
            int counter= 0;
            string[] lines = File.ReadAllLines(path);
            string[] data = new string[10];
            foreach (string line in lines)
            {
                if (!line.Contains('.'))
                {
                    data[counter] += line + "\n";
                }
                else
                {
                    counter++;
                }
            }

            if (num == 1)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (data[i].Contains("License: " + txtboxLicense.Text))
                    {
                        txtboxDescription.Text = data[i];
                    }
                }
            }
            
            if (num == 2)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (data[i].Contains("Next Service Date: " + txtboxDate.Text))
                    {
                        txtboxDescription.Text = data[i];
                    }
                }
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchFile(1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateFile();
            txtboxModel.Text = String.Empty;
            txtboxYear.Text = String.Empty;
            txtboxLicense.Text = String.Empty;
            this.ActiveControl = txtboxModel;
            txtboxDescription.Text = "Added!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtboxModel.Text = String.Empty;
            txtboxYear.Text = String.Empty;
            txtboxDate.Text = String.Empty;
            txtboxLicense.Text = String.Empty;
            txtboxMonth.Text = String.Empty;
            txtboxDescription.Text = String.Empty;
            this.ActiveControl = txtboxModel;
        }

        private void btnServiceDate_Click(object sender, EventArgs e)
        {
            
            Service obj = new Service();
            obj.Months = Convert.ToInt32(txtboxMonth.Text);
            DateTime dt = DateTime.Parse(txtboxDate.Text);
            txtboxDescription.Text = (dt.ToString("MM/dd/yyyy"));
            obj.date = DateTime.Parse(txtboxDate.Text);
            var dateOnly = obj.Compute_Date().Date;
            txtboxDescription.Text = "Service is due on " + dateOnly;
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            SearchFile(2);
        }

    }

    class Vehicle
    {
        public String Model { get; set; }

        public int Year { get; set; }

        public String License { get; set; }

        public DateTime date { get; set; }

        public void get_data()
        {
            // enable console
            // also set focus
            // only for console purposes which I didn't use
            Console.WriteLine("Enter Car's Model Name: ");
            Model = Console.ReadLine();

            Console.WriteLine("Enter the Year it was manufactured: ");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the License Plate Number: ");
            License = Console.ReadLine();

            Console.WriteLine("Enter the Date about the service to be done on this Vehicle: ");
            date = Convert.ToDateTime(Console.ReadLine());
        }
    }

    class Service: Vehicle, ITest
    {
        public String Description { get; set; }
        public int Months { get; set; }
        public DateTime Compute_Date()
        {
            return date.AddMonths(Months);
        }
    }

    public interface ITest
    {
        String Description { get; set; }
        int Months { get; set; }
        DateTime Compute_Date();
    }

}
