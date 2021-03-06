﻿
namespace CNC_Milling_Machine {
  partial class MainWindow {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_xmax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_ymax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_zmax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_step = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar_x = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar_z = new System.Windows.Forms.TrackBar();
            this.trackBar_y = new System.Windows.Forms.TrackBar();
            this.button_play = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_step = new System.Windows.Forms.Button();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_help = new System.Windows.Forms.Label();
            this.dataGridView_second = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_xmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zmax)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_x)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_second)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xsize";
            // 
            // numericUpDown_xmax
            // 
            this.numericUpDown_xmax.Location = new System.Drawing.Point(52, 26);
            this.numericUpDown_xmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_xmax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_xmax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_xmax.Name = "numericUpDown_xmax";
            this.numericUpDown_xmax.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown_xmax.TabIndex = 1;
            this.numericUpDown_xmax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_xmax.ValueChanged += new System.EventHandler(this.numericUpDown_xmax_ValueChanged);
            this.numericUpDown_xmax.Leave += new System.EventHandler(this.numericUpDown_Focus_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "см";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ysize";
            // 
            // numericUpDown_ymax
            // 
            this.numericUpDown_ymax.Location = new System.Drawing.Point(52, 51);
            this.numericUpDown_ymax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_ymax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_ymax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ymax.Name = "numericUpDown_ymax";
            this.numericUpDown_ymax.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown_ymax.TabIndex = 4;
            this.numericUpDown_ymax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ymax.ValueChanged += new System.EventHandler(this.numericUpDown_ymax_ValueChanged);
            this.numericUpDown_ymax.Leave += new System.EventHandler(this.numericUpDown_Focus_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "см";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zmax";
            // 
            // numericUpDown_zmax
            // 
            this.numericUpDown_zmax.Location = new System.Drawing.Point(52, 76);
            this.numericUpDown_zmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_zmax.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_zmax.Name = "numericUpDown_zmax";
            this.numericUpDown_zmax.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown_zmax.TabIndex = 7;
            this.numericUpDown_zmax.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_zmax.ValueChanged += new System.EventHandler(this.numericUpDown_zmax_ValueChanged);
            this.numericUpDown_zmax.Leave += new System.EventHandler(this.numericUpDown_Focus_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "см";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_step);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDown_zmax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_ymax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown_xmax);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(264, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление работой";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "мс";
            // 
            // numericUpDown_step
            // 
            this.numericUpDown_step.Location = new System.Drawing.Point(52, 100);
            this.numericUpDown_step.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_step.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_step.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_step.Name = "numericUpDown_step";
            this.numericUpDown_step.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown_step.TabIndex = 10;
            this.numericUpDown_step.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_step.ValueChanged += new System.EventHandler(this.numericUpDown_step_ValueChanged);
            this.numericUpDown_step.Leave += new System.EventHandler(this.numericUpDown_Focus_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Шаг";
            // 
            // trackBar_x
            // 
            this.trackBar_x.Location = new System.Drawing.Point(52, 28);
            this.trackBar_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar_x.Maximum = 9;
            this.trackBar_x.Name = "trackBar_x";
            this.trackBar_x.Size = new System.Drawing.Size(207, 45);
            this.trackBar_x.TabIndex = 12;
            this.trackBar_x.Scroll += new System.EventHandler(this.trackBar_x_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.trackBar_z);
            this.groupBox2.Controls.Add(this.trackBar_y);
            this.groupBox2.Controls.Add(this.trackBar_x);
            this.groupBox2.Location = new System.Drawing.Point(10, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(264, 169);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Положение резца";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Z: 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Y: 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "X: 0";
            // 
            // trackBar_z
            // 
            this.trackBar_z.Enabled = false;
            this.trackBar_z.Location = new System.Drawing.Point(52, 122);
            this.trackBar_z.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar_z.Maximum = 5;
            this.trackBar_z.Name = "trackBar_z";
            this.trackBar_z.Size = new System.Drawing.Size(207, 45);
            this.trackBar_z.TabIndex = 14;
            this.trackBar_z.Scroll += new System.EventHandler(this.trackBar_z_Scroll);
            // 
            // trackBar_y
            // 
            this.trackBar_y.Location = new System.Drawing.Point(52, 75);
            this.trackBar_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar_y.Maximum = 19;
            this.trackBar_y.Name = "trackBar_y";
            this.trackBar_y.Size = new System.Drawing.Size(207, 45);
            this.trackBar_y.TabIndex = 13;
            this.trackBar_y.Scroll += new System.EventHandler(this.trackBar_y_Scroll);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(11, 321);
            this.button_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(121, 22);
            this.button_play.TabIndex = 14;
            this.button_play.Text = "Пуск";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_pause
            // 
            this.button_pause.Enabled = false;
            this.button_pause.Location = new System.Drawing.Point(156, 321);
            this.button_pause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(119, 22);
            this.button_pause.TabIndex = 15;
            this.button_pause.Text = "Пауза";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(156, 347);
            this.button_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(119, 22);
            this.button_stop.TabIndex = 17;
            this.button_stop.Text = "Стоп";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_step
            // 
            this.button_step.Location = new System.Drawing.Point(11, 347);
            this.button_step.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_step.Name = "button_step";
            this.button_step.Size = new System.Drawing.Size(121, 22);
            this.button_step.TabIndex = 16;
            this.button_step.Text = "Шаг";
            this.button_step.UseVisualStyleBackColor = true;
            this.button_step.Click += new System.EventHandler(this.button_step_Click);
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.AllowUserToResizeColumns = false;
            this.dataGridView_main.AllowUserToResizeRows = false;
            this.dataGridView_main.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.ColumnHeadersVisible = false;
            this.dataGridView_main.Location = new System.Drawing.Point(291, 34);
            this.dataGridView_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_main.MultiSelect = false;
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.RowHeadersVisible = false;
            this.dataGridView_main.RowHeadersWidth = 51;
            this.dataGridView_main.RowTemplate.Height = 29;
            this.dataGridView_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_main.Size = new System.Drawing.Size(521, 308);
            this.dataGridView_main.TabIndex = 18;
            this.dataGridView_main.SelectionChanged += new System.EventHandler(this.dataGridView_main_SelectionChanged);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(156, 433);
            this.button_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(119, 49);
            this.button_reset.TabIndex = 19;
            this.button_reset.Text = "Сбросить изменения";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_help.Location = new System.Drawing.Point(10, 388);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(250, 21);
            this.label_help.TabIndex = 20;
            this.label_help.Text = "Нажмите \"F\", чтобы отдать честь.";
            // 
            // dataGridView_second
            // 
            this.dataGridView_second.AllowUserToAddRows = false;
            this.dataGridView_second.AllowUserToDeleteRows = false;
            this.dataGridView_second.AllowUserToResizeColumns = false;
            this.dataGridView_second.AllowUserToResizeRows = false;
            this.dataGridView_second.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_second.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_second.ColumnHeadersVisible = false;
            this.dataGridView_second.Location = new System.Drawing.Point(291, 363);
            this.dataGridView_second.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_second.MultiSelect = false;
            this.dataGridView_second.Name = "dataGridView_second";
            this.dataGridView_second.ReadOnly = true;
            this.dataGridView_second.RowHeadersVisible = false;
            this.dataGridView_second.RowHeadersWidth = 51;
            this.dataGridView_second.RowTemplate.Height = 29;
            this.dataGridView_second.Size = new System.Drawing.Size(522, 168);
            this.dataGridView_second.TabIndex = 21;
            this.dataGridView_second.SelectionChanged += new System.EventHandler(this.dataGridView_main_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Вид сверху";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Вид спереди";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 540);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView_second);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.dataGridView_main);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_step);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Станок";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindow_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_xmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_zmax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_x)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_xmax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_ymax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_zmax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_step;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar_x;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar_z;
        private System.Windows.Forms.TrackBar trackBar_y;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_step;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.DataGridView dataGridView_second;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer;
    }
}

