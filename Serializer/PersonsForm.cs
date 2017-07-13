using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializer
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            Person.Person.getFileNames();
            serialNumbLbl.Text = (Person.Person.fileNames.Count-1).ToString();
            DORLbl.Text = DateTime.Now.ToString();
        }

        private void ClearTexts()
        {
            nameTxt.Clear();
            addressTxt.Clear();
            phoneTxt.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!CheckIfEmpty()) return;
            if (Person.Person.fileNames.Count == 99)
            {
                MessageBox.Show("There is no empty space");
                return;
            }
            Person.Person per=new Person.Person(nameTxt.Text, addressTxt.Text, phoneTxt.Text);
            int num = GetFirstEmptySpace();
            serialNumbLbl.Text = num.ToString();
            per.Serialize(num);
            ClearTexts();
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            FillTexts(1);
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            FillTexts(Person.Person.fileNames.Count-1);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            int serNumb = Convert.ToInt32(serialNumbLbl.Text);
            if (serNumb == 1)
            {
                MessageBox.Show("No going back beach");
                return;
            }
            FillTexts(serNumb - 1);
        }

        private void FillTexts(int serNumber)
        {
            string fileName = Person.Person.fileNames[serNumber].ToString();
            Person.Person per = Person.Person.Deserialize(fileName);
            nameTxt.Text = per.Name;
            addressTxt.Text = per.Address;
            phoneTxt.Text = per.PhoneNumber;
            serialNumbLbl.Text = serNumber.ToString();
            DORLbl.Text = per.DateOfRecording.ToString();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            int serNumb = Convert.ToInt32(serialNumbLbl.Text);
            if (serNumb == (Person.Person.fileNames.Count-1))
            {
                MessageBox.Show("No more beach");
                return;
            }
            FillTexts(serNumb + 1);
        }

        private Boolean CheckIfEmpty()
        {
            if (nameTxt.TextLength==0 || addressTxt.TextLength==0 || phoneTxt.TextLength == 0)
            {
                MessageBox.Show("Please fill in the boxes");
                return false;
            }
            return true;
        }

        private  int GetFirstEmptySpace()
        {
            int index = 1;
            Person.Person.fileNames.Sort();
            foreach (string name in Person.Person.fileNames)
            {
                string numberParts = name.Substring(name.Length - 6, 2);
                int number=0;
                if (!Int32.TryParse(numberParts, out number))
                {
                    number = Convert.ToInt32(numberParts.Substring(1));
                }
                if (index != number)
                {
                    return index;
                }
                index++;
            }
            return index;
        }

        
    }
}
