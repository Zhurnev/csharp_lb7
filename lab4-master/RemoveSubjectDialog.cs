using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class RemoveSubjectDialog : Form
    {

        public RemoveSubjectDialog(List<Subject> subjects)
        {
            InitializeComponent();
            
            foreach (var subject in subjects)
            {
                subjectListBox.Items.Add(subject);
            }

            removeButton.Click += removeButton_Click;
        }

        public Subject SelectedSubject { get; private set; }

        private void removeButton_Click(object sender, EventArgs e)
        {
            SelectedSubject = (Subject)subjectListBox.SelectedItem;
        }
    }
}
