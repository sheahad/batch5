﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(6);

            string message = "For\n";
            for (int i = 0; i < numbers.Count; i++)
            {
                message = message + numbers[i] + "\n";
            }

            message = message + "Foreach\n";

            foreach (int number in numbers)
            {
                message = message + number + "\n";
            }
            showRichTextBox.Text = message;

        }
    }
}
