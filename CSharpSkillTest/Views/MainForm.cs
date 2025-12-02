using CSharpSkillTest.Controller;
using CSharpSkillTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSkillTest.Views
{
    public partial class MainForm : Form
    {

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private readonly SortModel _model;
        private readonly SortController _controller;

        public MainForm()
        {
            InitializeComponent();
            _model = new SortModel();
            _controller = new SortController(_model);

            cboStrategy.Items.Add("Bubble Sort");
            cboStrategy.Items.Add("Quick Sort");
            cboStrategy.SelectedIndex = 0;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            _model.Input = txtInput.Text;

            // select strategy
            if (cboStrategy.SelectedItem.ToString() == "Bubble Sort")
                _controller.SetStrategy(new BubbleSortStrategy());
            else
                _controller.SetStrategy(new QuickSortStrategy());

            // perform sorting
            _controller.SortInput();

            // update view
            lblOutput.Text = _controller.GetOutput();
        }
    }
}
