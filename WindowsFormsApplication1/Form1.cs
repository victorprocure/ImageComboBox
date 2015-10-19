using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageComboBox;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            imageComboBox.Items.Add(new ComboBoxItem("Item without image"));
            imageComboBox.Items.Add(new ComboBoxItem("Exclamation", SystemIcons.Exclamation.ToBitmap()));
            imageComboBox.Items.Add(new ComboBoxItem("Information", SystemIcons.Information.ToBitmap()));
            imageComboBox.Items.Add(new ComboBoxItem("Error", SystemIcons.Error.ToBitmap()));
            imageComboBox.Items.Add(new ComboBoxItem("Filters", Image.FromFile("filterIcon.png")));
            imageComboBox.SelectedIndex = 1;
        }
    }
}