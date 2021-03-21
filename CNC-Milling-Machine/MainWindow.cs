﻿using System;
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

        private void button_start_Click(object sender, EventArgs e)
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
            var array = new int[10,10];

            dataGridView_main.RowCount = 10;
            dataGridView_main.ColumnCount = 10;
            for(var i = 0; i < 10; ++i)
                for(var j = 0; j < 10; ++j)
                    dataGridView_main.Rows[i].Cells[j].Value = array[i, j];

            dataGridView_main.AutoSizeColumnsMode = 
                DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData_stub();
        }

        private void numericUpDown_xmax_Leave(object sender, EventArgs e)
        {
            var senderObj = (NumericUpDown) sender;
            senderObj.Text = senderObj.Value.ToString(CultureInfo.CurrentCulture);
        }
    }
}
