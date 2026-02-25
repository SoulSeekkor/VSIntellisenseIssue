using System;
using System.Windows.Forms;

namespace VSIntellisenseIssue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LibraryTest.Class1.enuTest test = LibraryTest.Class1.enuTest.value2;
        }
    }
}
