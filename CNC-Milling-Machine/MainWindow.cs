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

        private void trackBar_x_Scroll(object sender, EventArgs e)
        {
            label9.Text = "X: " + trackBar_x.Value;
            // todo change x pos
        }

        private void trackBar_y_Scroll(object sender, EventArgs e)
        {
            label10.Text = "Y: " + trackBar_y.Value;
            // todo change y pos
        }

        private void trackBar_z_Scroll(object sender, EventArgs e)
        {
            label11.Text = "Z: " + trackBar_z.Value;
            // todo change z pos
        }

        private void numericUpDown_xmax_ValueChanged(object sender, EventArgs e)
        {
            // todo xmax changed
            // how to get value:
            // numericUpDown_xmax.Value
        }

        private void numericUpDown_ymax_ValueChanged(object sender, EventArgs e)
        {
            // todo ymax changed
            // how to get value:
            // numericUpDown_ymax.Value
        }

        private void numericUpDown_zmax_ValueChanged(object sender, EventArgs e)
        {
            // todo zmax changed
            // how to get value:
            // numericUpDown_zmax.Value
        }

        private void numericUpDown_step_ValueChanged(object sender, EventArgs e)
        {
            // todo step changed
            // how to get value:
            // numericUpDown_step.Value
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            // todo
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            // todo
        }

        private void button_step_Click(object sender, EventArgs e)
        {
            // todo
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            // todo
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



        public void UpdateData_stub()
        {
            var size_x = 10;
            var size_y = 20;
            var size_z = 5;

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
            for(var j = 0; j < size_y; ++j)
                dataGridView_second.Rows[i].Cells[j].Value = array_second[i, j];
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // todo delete this button and method
            UpdateData_stub();
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
            dataGridView_main.AutoSizeColumnsMode = 
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_second.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
