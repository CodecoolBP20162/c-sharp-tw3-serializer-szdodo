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
            Person.Person.getSerialNumbers();
            serialNumbLbl.Text = (Person.Person.serialNumbers.Count-1).ToString();
            DORLbl.Text = DateTime.Now.ToString();
        }

        private void ClearTexts()
        {
            nameTxt.Clear();
            addressTxt.Clear();
            phoneTxt.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!checkIfEmpty()) return;
            Person.Person per=new Person.Person(nameTxt.Text, addressTxt.Text, phoneTxt.Text);
            per.Serialize();
            ClearTexts();
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            fillTexts(1);
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            fillTexts(Person.Person.serialNumbers.Count-1);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            int serNumb = Convert.ToInt32(serialNumbLbl.Text);
            if (serNumb == 1)
            {
                MessageBox.Show("No going back beach");
                return;
            }
            fillTexts(serNumb - 1);
        }

        private void fillTexts(int serNumber)
        {
            string fileName = Person.Person.serialNumbers[serNumber].ToString();
            Person.Person per = Person.Person.Deserialize(fileName);
            nameTxt.Text = per.Name;
            addressTxt.Text = per.Address;
            phoneTxt.Text = per.PhoneNumber;
            serialNumbLbl.Text = serNumber.ToString();
            DORLbl.Text = per.DateOfRecording.ToString();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int serNumb = Convert.ToInt32(serialNumbLbl.Text);
            if (serNumb == (Person.Person.serialNumbers.Count-1))
            {
                MessageBox.Show("No more beach");
                return;
            }
            fillTexts(serNumb + 1);
        }

        private Boolean checkIfEmpty()
        {
            if (nameTxt.TextLength==0 || addressTxt.TextLength==0 || phoneTxt.TextLength == 0)
            {
                MessageBox.Show("Please fill in the boxes");
                return false;
            }
            return true;
        }

        
    }
}
