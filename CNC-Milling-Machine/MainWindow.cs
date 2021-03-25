using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC_Milling_Machine {
  public partial class MainWindow : Form {
        public MainWindow() {
          InitializeComponent();
        }

        private readonly Machine machine = new Machine();
        private int xmax = 1;
        private int ymax = 1;
        private int zmax = 4;

        private void trackBar_x_Scroll(object sender, EventArgs e)
        {
            label9.Text = "X: " + trackBar_x.Value;
            machine.GetPosition(out var t_x, out _, out var t_z);
            machine.SetZPosition(Constants.BlankSizeZ);
            while (t_x != trackBar_x.Value)
            {
                if (t_x < trackBar_x.Value)
                {
                    machine.StepXPos();
                }
                else
                {
                    machine.ResetXPosition();
                }
                machine.GetPosition(out t_x, out var _, out var _);
            }
            machine.SetZPosition(t_z);
            UpdateData();
        }

        private void trackBar_y_Scroll(object sender, EventArgs e)
        {
            label10.Text = "Y: " + trackBar_y.Value;
            machine.GetPosition(out var _, out var tY, out var _);
            while (tY != trackBar_y.Value)
            {
                if (tY < trackBar_y.Value)
                {
                    machine.StepYPos();
                }
                else
                {
                    machine.StepYNeg();
                }
                machine.GetPosition(out var _, out tY, out var _);
            }
            UpdateData();
        }

        private void trackBar_z_Scroll(object sender, EventArgs e)
        {
        }

        private void numericUpDown_xmax_ValueChanged(object sender, EventArgs e)
        {
            xmax = (int)numericUpDown_xmax.Value;
        }

        private void numericUpDown_ymax_ValueChanged(object sender, EventArgs e)
        {
            ymax = (int)numericUpDown_ymax.Value;
        }

        private void numericUpDown_zmax_ValueChanged(object sender, EventArgs e)
        {
            zmax = (int)numericUpDown_zmax.Value;
        }

        private void numericUpDown_step_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)numericUpDown_step.Value;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            
            button_play.Enabled = false;
            button_pause.Enabled = true;
            button_stop.Enabled = true;
            button_step.Enabled = false;
            numericUpDown_xmax.Enabled = false;
            numericUpDown_ymax.Enabled = false;
            numericUpDown_zmax.Enabled = false;
            numericUpDown_step.Enabled = false;
            trackBar_x.Enabled = false;
            trackBar_y.Enabled = false;
            // todo add task
            timer.Start();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            button_play.Enabled = true;
            button_pause.Enabled = false;
            timer.Stop();
        }

        private void button_step_Click(object sender, EventArgs e)
        {
            machine.GetPosition(out var x, out var y, out _);
            machine.SetZPosition(machine.GetBlank()[x,y] - 1);
            machine.StepXPos();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            button_play.Enabled = true;
            button_pause.Enabled = false;
            button_stop.Enabled = false;
            button_step.Enabled = false;
            numericUpDown_xmax.Enabled = true;
            numericUpDown_ymax.Enabled = true;
            numericUpDown_zmax.Enabled = true;
            numericUpDown_step.Enabled = true;
            trackBar_x.Enabled = true;
            trackBar_y.Enabled = true;
            // todo remove task
        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            // todo catch pressed keys
            // value: e.KeyChar

            // Use class Keys to compare keycode
            if (char.ToLower(e.KeyChar) == char.ToLower((char)Keys.F))
            {
                MessageBox.Show("Произведено воинское приветствие.",
                    "F");
            }
        }



        public void InitMatrix()
        {
            var size_x = Constants.BlankSizeX;
            var size_y = Constants.BlankSizeY;
            var size_z = Constants.BlankSizeZ;

            // todo remove and add real data


            // i - row, j - column
            var array_main = new int[size_x,size_y];
            for(var i = 0; i < size_x; i++)
            for (var j = 0; j < size_y; j++)
                array_main[i, j] = size_z;

            dataGridView_main.RowCount = size_x;
            dataGridView_main.ColumnCount = size_y;
            for(var i = 0; i < size_x; ++i)
                for(var j = 0; j < size_y; ++j)
                    dataGridView_main.Rows[i].Cells[j].Value = array_main[i, j];

            var array_second = new int[size_z, size_y];
            for(var i = 0; i < size_z; i++)
            for (var j = 0; j < size_y; j++)
                array_second[i, j] = size_x;

            dataGridView_second.RowCount = size_z;
            dataGridView_second.ColumnCount = size_y;
            for(var i = 0; i < size_z; ++i)
            for (var j = 0; j < size_y; ++j)
                dataGridView_second.Rows[i].Cells[j].Value =
                    array_second[i, j];
        }

        void UpdateData()
        {
            for(var i = 0; i < Constants.BlankSizeX; ++i)
            for(var j = 0; j < Constants.BlankSizeY; ++j)
                dataGridView_main.Rows[i].Cells[j].Value = 
                    machine.GetBlank()[i, j] > 0
                        ? machine.GetBlank()[i, j].ToString()
                        : " ";

            for(var i = 0; i < Constants.BlankSizeZ; i++)
            for (var j = 0; j < Constants.BlankSizeY; j++)
            {
                var val = 0;
                for(var k = 0; k < Constants.BlankSizeX; k++)
                    if (machine.GetBlank()[k, j] >= i + 1)
                        val++;

                dataGridView_second.Rows[Constants.BlankSizeZ - i - 1]
                    .Cells[j].Value = 
                    val > 0 
                        ? val.ToString() 
                        : " ";


            }

            machine.GetPosition(out var xPos, out var yPos, out var zPos);
            dataGridView_main.Rows[xPos].Cells[yPos].Value = "*";
            for (var mm = 4; mm >= zPos; mm--)
                dataGridView_second.Rows[mm].Cells[yPos].Value = "*";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // todo delete this button and method
            InitMatrix();
        }

        private void numericUpDown_Focus_Leave(object sender, EventArgs e)
        {
            // universal method, just little improvement to
            // default UI behavior
            var senderObj = (NumericUpDown) sender;
            senderObj.Text = senderObj.Value.ToString(CultureInfo.CurrentCulture);
        }

        private void dataGridView_main_SelectionChanged(object sender, EventArgs e)
        {
            // forbid selection
            try
            {
                ((DataGridView)sender).SelectedCells[0].Selected = false;
            }
            catch { }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            InitMatrix();
            trackBar_x.Maximum = Constants.BlankSizeX - 1;
            trackBar_y.Maximum = Constants.BlankSizeY - 1;
            dataGridView_main.AutoSizeColumnsMode = 
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_second.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            UpdateData();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // do iteration
            UpdateData();
        }
    }
}
