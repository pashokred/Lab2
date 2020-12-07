using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeRadioButtons();
            InitializeComponent();
            LoadDocument();
        }

        private void InitializeRadioButtons()
        {
            GroupBox groupbox = new GroupBox();
            Controls.Add(groupbox);
            groupbox.Controls.Add(LinqBtn);
            groupbox.Controls.Add(DomBtn);
            groupbox.Controls.Add(SaxBtn);
        }

        private List<ComboBox> _comboBoxes = new List<ComboBox>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void SPECchB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FillComboBox(XmlNode node)
        {
            if (!comBoxFn.Items.Contains(node.SelectSingleNode("@FirstName").Value))
                comBoxFn.Items.Add(node.SelectSingleNode("@FirstName").Value);
            if (!comBoxLn.Items.Contains(node.SelectSingleNode("@LastName").Value))
                comBoxLn.Items.Add(node.SelectSingleNode("@LastName").Value);
            if (!comBoxFac.Items.Contains(node.SelectSingleNode("@Faculty").Value))
                comBoxFac.Items.Add(node.SelectSingleNode("@Faculty").Value);
            if (!comBoxSpec.Items.Contains(node.SelectSingleNode("@Specialization").Value))
                comBoxSpec.Items.Add(node.SelectSingleNode("@Specialization").Value);
            if (!comBoxCourse.Items.Contains(node.SelectSingleNode("@Course").Value))
                comBoxCourse.Items.Add(node.SelectSingleNode("@Course").Value);
            if (!comBoxRoom.Items.Contains(node.SelectSingleNode("@Room").Value))
                comBoxRoom.Items.Add(node.SelectSingleNode("@Room").Value);
            if (!comBoxCheckIn.Items.Contains(node.SelectSingleNode("@WhenCheckedInto").Value))
                comBoxCheckIn.Items.Add(node.SelectSingleNode("@WhenCheckedInto").Value);
        }

        private void LoadDocument()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml");
            
            
            XmlElement dormitory = xmlDoc.DocumentElement;
            XmlNodeList students = dormitory.SelectNodes("Student");

            for (int i = 0; i < students.Count; ++i)
            {
                XmlNode node = students.Item(i);
                FillComboBox(node);
            }
        }

        public static StringBuilder StrBuilder { get; set; }
        public void FillTextBox()
        {
            TextBox.Text = StrBuilder.ToString();
        }
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<string> checkedBoxes = new List<string>();

            foreach (var cb in Controls.OfType<CheckBox>().Where(x => x.Checked))
                checkedBoxes.Add(cb.Text);

            _comboBoxes = new List<ComboBox>(){comBoxFn, comBoxLn, comBoxFac, comBoxSpec, comBoxCourse, comBoxRoom, comBoxCheckIn};
            var checkedComboBoxes = new List<ComboBox>();
            var dormitory = new Dormitory();
            
            foreach (var checkedBox in checkedBoxes)
            {
                if (checkedBox == "FirstName" && !checkedComboBoxes.Contains(comBoxFn)) {
                    checkedComboBoxes.Add(comBoxFn);
                    dormitory.FirstName = comBoxFn.SelectedItem.ToString();
                }
                else if (checkedBox == "LastName" && !checkedComboBoxes.Contains(comBoxLn))
                {
                    checkedComboBoxes.Add(comBoxLn);
                    dormitory.LastName = comBoxLn.SelectedItem.ToString();
                }
                else if (checkedBox == "Faculty" && !checkedComboBoxes.Contains(comBoxFac))
                {
                    checkedComboBoxes.Add(comBoxFac);
                    dormitory.Faculty = comBoxFac.SelectedItem.ToString();
                }
                else if (checkedBox == "Specialization" && !checkedComboBoxes.Contains(comBoxSpec))
                {
                    checkedComboBoxes.Add(comBoxSpec);
                    dormitory.Specialization = comBoxSpec.SelectedItem.ToString();
                }
                else if (checkedBox == "Course" && !checkedComboBoxes.Contains(comBoxCourse))
                {
                    checkedComboBoxes.Add(comBoxCourse);
                    dormitory.Course = comBoxCourse.SelectedItem.ToString();
                }
                else if (checkedBox == "Room" && !checkedComboBoxes.Contains(comBoxRoom))
                {
                    checkedComboBoxes.Add(comBoxRoom);
                    dormitory.Room = comBoxRoom.SelectedItem.ToString();
                }
                else if (checkedBox == "WhenCheckedInto" && !checkedComboBoxes.Contains(comBoxCheckIn))
                {
                    checkedComboBoxes.Add(comBoxCheckIn);
                    dormitory.WhenCheckedInto = comBoxCheckIn.SelectedItem.ToString();
                }
            }
            
            
            
            
            IAnalyser analyser = new DomAnalyse();
            
            if (LinqBtn.Checked)
            {
                
            }
            else if (DomBtn.Checked)
            {
                analyser = new DomAnalyse();
            }
            else if (SaxBtn.Checked)
            {

            }
            
            foreach (var checkedBox in checkedBoxes)
            {
                string tag = string.Concat(checkedBox.Where(c => !Char.IsWhiteSpace(c)));
                analyser.Analyse(tag, dormitory);
                FillTextBox();
            }
        }
    }
}