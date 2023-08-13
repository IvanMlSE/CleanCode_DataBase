using System;
using System.Data;
using System.Windows.Forms;

namespace CleanCode_DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string passportNumber = GetPassportNumber();

            if (IsValidPassportNumber(passportNumber) == false)
            {
                textResult.Text = "Неверный формат серии или номера паспорта";

                return;
            }

            string commandText = string.Format("select * from passports where num='{0}' limit 1;", ComputeSha256Hash(passportNumber));

            LocalDatabase localDatabase = new LocalDatabase(commandText);
            DataTable dataTableResult = localDatabase.SendReuqest();

            ShowResault(passportNumber, dataTableResult);
        }

        private void ShowResault(string passportNumber, DataTable dataTableResult)
        {
            if (dataTableResult.Rows.Count == 0)
            {
                textResult.Text = $"Паспорт «{passportNumber}» в списке участников дистанционного голосования НЕ НАЙДЕН";

                return;
            }

            DataRow voterData = dataTableResult.Rows[0];
            bool accessVoter = Convert.ToBoolean(voterData.ItemArray[1]);

            if (accessVoter)
                textResult.Text = $"По паспорту «{passportNumber}» доступ к бюллетеню на дистанционном электронном голосовании ПРЕДОСТАВЛЕН";
            else
                textResult.Text = $"По паспорту «{passportNumber}» доступ к бюллетеню на дистанционном электронном голосовании НЕ ПРЕДОСТАВЛЯЛСЯ";
        }

        private static string ComputeSha256Hash(string validPassportNumber)
        {
            //вычисление контрольной суммы SHA256 номера пасспорта
            string hash = validPassportNumber;

            return hash;
        }

        private bool IsValidPassportNumber(string passportNumber)
        {
            const int PassportNumberLength = 10;

            if (passportNumber.Length != PassportNumberLength)
            {
                return false;
            }

            return true;
        }

        private string GetPassportNumber()
        {
            string passportNumber = passportTextbox.Text;

            passportNumber = passportNumber.Replace(" ", string.Empty);
            passportTextbox.Text = passportNumber;

            if (string.IsNullOrEmpty(passportNumber))
            {
                MessageBox.Show("Введите серию и номер паспорта");
            }

            return passportNumber;
        }
    }
}