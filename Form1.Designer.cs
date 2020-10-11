namespace MouseRecorder1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_play = new System.Windows.Forms.Button();
            this.button_rec = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnX = new System.Windows.Forms.ColumnHeader();
            this.columnY = new System.Windows.Forms.ColumnHeader();
            this.columnAction = new System.Windows.Forms.ColumnHeader();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_clear = new System.Windows.Forms.Button();
            this.timer_hotkeys = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playSPEED = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.playRepeat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playSPEED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(13, 13);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 0;
            this.button_play.Text = "PLAY";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_rec
            // 
            this.button_rec.Location = new System.Drawing.Point(94, 13);
            this.button_rec.Name = "button_rec";
            this.button_rec.Size = new System.Drawing.Size(75, 23);
            this.button_rec.TabIndex = 0;
            this.button_rec.Text = "REC";
            this.button_rec.UseVisualStyleBackColor = true;
            this.button_rec.Click += new System.EventHandler(this.button_rec_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(175, 13);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 0;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnX,
            this.columnY,
            this.columnAction});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(177, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(172, 117);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnX
            // 
            this.columnX.Text = "X";
            this.columnX.Width = 35;
            // 
            // columnY
            // 
            this.columnY.Text = "Y";
            this.columnY.Width = 35;
            // 
            // columnAction
            // 
            this.columnAction.Text = "ACTION";
            this.columnAction.Width = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(257, 13);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // timer_hotkeys
            // 
            this.timer_hotkeys.Tick += new System.EventHandler(this.timer_hotkeys_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CTRL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "SHIFT";
            // 
            // playSPEED
            // 
            this.playSPEED.Location = new System.Drawing.Point(256, 79);
            this.playSPEED.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.playSPEED.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.playSPEED.Name = "playSPEED";
            this.playSPEED.Size = new System.Drawing.Size(77, 23);
            this.playSPEED.TabIndex = 6;
            this.playSPEED.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Play Speed(5 fastest, 25 normal, 50 slowest):";
            // 
            // playRepeat
            // 
            this.playRepeat.Location = new System.Drawing.Point(99, 115);
            this.playRepeat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.playRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playRepeat.Name = "playRepeat";
            this.playRepeat.Size = new System.Drawing.Size(57, 23);
            this.playRepeat.TabIndex = 8;
            this.playRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Repeat Times:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "github.com/kasa500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "made by";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 244);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playRepeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playSPEED);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_rec);
            this.Controls.Add(this.button_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mouse Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playSPEED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playRepeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_rec;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnX;
        private System.Windows.Forms.ColumnHeader columnY;
        private System.Windows.Forms.ColumnHeader columnAction;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Timer timer_hotkeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown playSPEED;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown playRepeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

