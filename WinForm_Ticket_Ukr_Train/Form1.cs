using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinForm_Ticket_Ukr_Train
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int tea = 50;
        int postil = 77;
        string typevagon = null;
        List<Ticket> tickets = new List<Ticket>();
        Ticket ticketForWriteRead = new Ticket();
        List<string> selItems = new List<string>();
        public Form1()
        {
            InitializeComponent();
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.uz.gov.ua";
            linkLabelUKRZAL.Links.Add(link);
            timer1.Start();
            textBoxName.Validating += TextBoxName_Validating;
            textBoxSerName.Validating += TextBoxSerName_Validating;
        }

        private void TextBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider1.SetError(textBoxName, "Вкажіть ім'я");
            }
            else if (textBoxName.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxName, "Занадто коротке ім'я");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void TextBoxSerName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSerName.Text))
            {
                errorProvider2.SetError(textBoxSerName, "Вкажіть прізвище");
            }
            else if (textBoxSerName.Text.Length < 3)
            {
                errorProvider2.SetError(textBoxSerName, "Занадто коротке прізвище");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void linkLabelUKRZAL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabelUKRZAL.Links[0].LinkData as string);
        }
        private void fullNameChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxSerName.Text) /*&& !string.IsNullOrEmpty(textBox1.Text)*/)
            {
                comboBoxFrom.Enabled = true;
                comboBoxTo.Enabled = true;
                groupBox1.BringToFront();
            }
            else
            {
                comboBoxFrom.Enabled = false;
                comboBoxTo.Enabled = false;
            }
        }
        //перевірка для генерації випадкового номеру поїздiв
        private void AllInfoHadGot(object sender, EventArgs e)
        {
            //якщо дані введені можна згенерувати рандомно номер поїзда
            if (comboBoxTo.SelectedIndex > -1 && comboBoxFrom.SelectedIndex > -1)
            {
                textBox1.Enabled = true;
                Random random = new Random();
                textBox1.Text = Convert.ToString(random.Next(7, 777));
                textBox1.Enabled = false;
            }
        }
        private void comboBoxTo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxFrom.Text == comboBoxTo.Text)
            {
                MessageBox.Show("Місце відправки не може бути місцем призначення");
            }
            else
            {
                buttonPrice.Enabled = true;
            }
        }
        private void buttonPrice_Click(object sender, EventArgs e)
        {
            sum = 0;
            textBoxPriceBase.Clear();
            if (radioButtonCupe.Checked)
            {
                typevagon = radioButtonCupe.Text;
                sum += 777;
            }
            if (radioButtonPlacKart.Checked)
            {
                typevagon = radioButtonPlacKart.Text;
                sum += 555;
            }
            if (radioButtonSV.Checked)
            {
                typevagon = radioButtonSV.Text;
                sum += 1777;
            }
            textBoxPriceBase.Text = Convert.ToString(sum);
            if (sum != 0)
            {
                buttonFullPrice.Enabled = true;
            }
        }

        private void buttonFullPrice_Click(object sender, EventArgs e)
        {
            sum = 0;
            textBoxFullPrice.Clear();
            var checked_indexes = checkedListBox.CheckedIndices;
            if (checked_indexes.Contains(0))
            {
                sum += tea;
            }
            if (checked_indexes.Contains(1))
            {
                sum += postil;
            }
            if (checked_indexes.Contains(2))
            {
                sum += 177;
            }
            sum += Convert.ToInt32(textBoxPriceBase.Text);
            textBoxFullPrice.Text += Convert.ToString(sum);
            buttonSaveToFile.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarSaveToFile.Value == progressBarSaveToFile.Maximum)
            {
                progressBarSaveToFile.Value = progressBarSaveToFile.Minimum;
            }
            else
            {
                progressBarSaveToFile.Value += 10;
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox.SelectedItems)
            {
                selItems.Add(item.ToString());
            }
            int price = Convert.ToInt32(textBoxFullPrice.Text);
            ticketForWriteRead = new Ticket(
                textBoxName.Text,
                textBoxSerName.Text,
                textBox1.Text,
                comboBoxFrom.SelectedItem.ToString(),
                comboBoxTo.SelectedItem.ToString(),
                dateTimePicker1.Value,
                typevagon,
                numericUpDownVagon.Value.ToString(),
                selItems, price
                );

            string ticketForSave = textBoxName.Text +
                +dateTimePicker1.Value.Year +
                +dateTimePicker1.Value.Month +
                +dateTimePicker1.Value.Day + ".xml";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Ticket));
            using (FileStream file = new FileStream(ticketForSave, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, ticketForWriteRead);
                MessageBox.Show("Запис здійснено");
            }
            //зберігаємо квиток в масивчик
            tickets.Add(ticketForWriteRead);
        }

        private void buttonClearAllItem_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSerName.Clear();
            textBox1.Enabled = true;
            textBox1.Clear();
            textBox1.Enabled = false;
            textBoxPriceBase.Clear();
            textBoxFullPrice.Clear();
            textBox1.Clear();
            comboBoxFrom.SelectedIndex = -1;
            comboBoxTo.SelectedIndex = -1;
            var radioButtons = groupBox1.Controls.OfType<RadioButton>().ToArray();
            foreach (RadioButton item in radioButtons)
            {
                item.Checked = false;
            }
            dateTimePicker1.Value = DateTime.Today;
            numericUpDownVagon.Value = 1;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }

        }

        private void buttunSaveAllTickets_Click(object sender, EventArgs e)
        {
            string alltickets = "alltickets.xml";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Ticket>));
            using (FileStream file = new FileStream(alltickets, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, tickets);
            }
        }
        //commit changes
        private void buttonSeeAllTickets_Click(object sender, EventArgs e)
        {
            textBoxSeeAllTickets.Clear();
            string res = "";
            foreach (var item in tickets)
            {
                res += item.ToString();
                res += "\n";
            }
            textBoxSeeAllTickets.Text = res;
        }
        private void RightSymbols(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            //якщо це не символ - то текст бокс нічого не прийме
            if (Char.IsDigit(symbol))
            {
                //подія вводу символу не оброблена - тру 
                e.Handled = true;
            }
        }
        private void buttonForOpening_Click(object sender, EventArgs e)
        {
            string alltickets = "";
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XML Files (*..xml)|*.xml";
            //XmlSerializer xmlDeSerializer = new XmlSerializer(typeof(List<Ticket>));
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Ticket));
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                alltickets = Path.GetFileName(openFile.FileName);
                using (FileStream fs = new FileStream(alltickets,FileMode.Open))
                {
                    //tickets = (List<Ticket>)xmlDeSerializer.Deserialize(fs);
                    ticketForWriteRead = (Ticket)xmlSerializer.Deserialize(fs);
                }
            }
            textBoxForOpeningTickets.Text = ticketForWriteRead.ToString();
        }
    }
}
