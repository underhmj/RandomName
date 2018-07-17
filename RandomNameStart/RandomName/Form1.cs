using NicknameGeneratorLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateName_Click(object sender, EventArgs e)
        {
            string name = string.Empty;
            PersonCreator personCreator = new PersonCreator();
            Person person;
            person = personCreator.RandomizedPerson();
            name = $"{person.FirstName} \"{person.Nickname}\" {person.LastName}";
            lblGeneratedName.Text = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
