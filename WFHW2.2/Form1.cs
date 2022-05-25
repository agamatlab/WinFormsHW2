using System.Text.Json;
using System.Text.RegularExpressions;

namespace WFHW2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtPicker_BirthDate.MaxDate = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in pnl_Location.Controls)
            {
                if (item is TextBox tBox)
                    if (tBox.Text == String.Empty)
                    {
                        MessageBox.Show("Please Fill All The Boxes...");
                        return;
                    }
            }


            string filePath = $"{tBox_Name.Text}.json";
            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("There is Already File Specified in this Name. Do you want to Update it?", "Information",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);

                if (result == DialogResult.No)
                    return;
            }

            string pattern = @"^([\+]?[0-9]{1,3}[0-9]{1,12})([\s.-]?[0-9]{1,4}?)$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(tBox_PhoneNumber.Text))
            {
                MessageBox.Show("Please Enter Proper Phone Number.");
                return;
            }

            var JsonStr = JsonSerializer.Serialize(new User(tBox_Name.Text, 
                tBox_Surname.Text,tBox_FatherName.Text,tBox_Country.Text,tBox_City.Text,
                tBox_PhoneNumber.Text, dtPicker_BirthDate.Value,
                rBtn_Male.Checked ? Gender.Male : Gender.Female));

            File.WriteAllText(filePath, JsonStr);
            MessageBox.Show("Data Successfully Added");

        }

        private void Load_Click(object sender, EventArgs e)
        {
            string filePath = $"{tBox_FileName.Text}.json";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("No Credentials Exist...");
                return;
            }

            var readJsonStr = File.ReadAllText(filePath);
            User? user = JsonSerializer.Deserialize<User>(readJsonStr) ?? null;
            
            if (user == null)
            {
                MessageBox.Show("No Data Exists...");
                return;
            }

            tBox_Name.Text = user.Name;
            tBox_Surname.Text = user.Surname;
            tBox_FatherName.Text = user.FatherName;

            tBox_Country.Text = user.Country;
            tBox_City.Text = user.City;
            tBox_PhoneNumber.Text = user.PhoneNumber;

            dtPicker_BirthDate.Value = user.BirthDate;

            if(user.Gender == Gender.Male)
                rBtn_Male.Checked = true;
            else 
                rBtn_Female.Checked = true;

            MessageBox.Show("Data Successfully Loaded");
        }
    }
}