namespace WynnIR
{
    partial class wynnir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wynnir));
            this.openThread = new System.Windows.Forms.Button();
            this.ragniB = new System.Windows.Forms.RadioButton();
            this.detlasB = new System.Windows.Forms.RadioButton();
            this.almujB = new System.Windows.Forms.RadioButton();
            this.nemractB = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.serverB = new System.Windows.Forms.NumericUpDown();
            this.time = new System.Windows.Forms.TextBox();
            this.timeB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serverB)).BeginInit();
            this.SuspendLayout();
            // 
            // openThread
            // 
            this.openThread.BackColor = System.Drawing.Color.Black;
            this.openThread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openThread.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Bold);
            this.openThread.ForeColor = System.Drawing.SystemColors.Control;
            this.openThread.Location = new System.Drawing.Point(12, 239);
            this.openThread.Name = "openThread";
            this.openThread.Size = new System.Drawing.Size(180, 44);
            this.openThread.TabIndex = 0;
            this.openThread.Text = "Open Invasion Tracker";
            this.openThread.UseVisualStyleBackColor = false;
            this.openThread.Click += new System.EventHandler(this.openThread_Click);
            // 
            // ragniB
            // 
            this.ragniB.AutoSize = true;
            this.ragniB.BackColor = System.Drawing.Color.Black;
            this.ragniB.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ragniB.ForeColor = System.Drawing.Color.White;
            this.ragniB.Location = new System.Drawing.Point(12, 42);
            this.ragniB.Name = "ragniB";
            this.ragniB.Size = new System.Drawing.Size(73, 19);
            this.ragniB.TabIndex = 1;
            this.ragniB.TabStop = true;
            this.ragniB.Text = "Ragni";
            this.ragniB.UseVisualStyleBackColor = false;
            this.ragniB.CheckedChanged += new System.EventHandler(this.ragniB_CheckedChanged);
            // 
            // detlasB
            // 
            this.detlasB.AutoSize = true;
            this.detlasB.Font = new System.Drawing.Font("Minecraft", 11.25F);
            this.detlasB.ForeColor = System.Drawing.SystemColors.Control;
            this.detlasB.Location = new System.Drawing.Point(91, 42);
            this.detlasB.Name = "detlasB";
            this.detlasB.Size = new System.Drawing.Size(83, 19);
            this.detlasB.TabIndex = 2;
            this.detlasB.TabStop = true;
            this.detlasB.Text = "Detlas";
            this.detlasB.UseVisualStyleBackColor = true;
            this.detlasB.CheckedChanged += new System.EventHandler(this.detlasB_CheckedChanged);
            // 
            // almujB
            // 
            this.almujB.AutoSize = true;
            this.almujB.Font = new System.Drawing.Font("Minecraft", 11.25F);
            this.almujB.ForeColor = System.Drawing.SystemColors.Control;
            this.almujB.Location = new System.Drawing.Point(117, 67);
            this.almujB.Name = "almujB";
            this.almujB.Size = new System.Drawing.Size(75, 19);
            this.almujB.TabIndex = 3;
            this.almujB.TabStop = true;
            this.almujB.Text = "Almuj";
            this.almujB.UseVisualStyleBackColor = true;
            this.almujB.CheckedChanged += new System.EventHandler(this.almujB_CheckedChanged);
            // 
            // nemractB
            // 
            this.nemractB.AutoSize = true;
            this.nemractB.Font = new System.Drawing.Font("Minecraft", 11.25F);
            this.nemractB.ForeColor = System.Drawing.SystemColors.Control;
            this.nemractB.Location = new System.Drawing.Point(12, 67);
            this.nemractB.Name = "nemractB";
            this.nemractB.Size = new System.Drawing.Size(99, 19);
            this.nemractB.TabIndex = 4;
            this.nemractB.TabStop = true;
            this.nemractB.Text = "Nemract";
            this.nemractB.UseVisualStyleBackColor = true;
            this.nemractB.CheckedChanged += new System.EventHandler(this.nemractB_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Minecraft", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 24);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "City";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Minecraft", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 24);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Server";
            // 
            // serverB
            // 
            this.serverB.BackColor = System.Drawing.SystemColors.InfoText;
            this.serverB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverB.Font = new System.Drawing.Font("Minecraft", 11.25F);
            this.serverB.ForeColor = System.Drawing.SystemColors.Menu;
            this.serverB.Location = new System.Drawing.Point(12, 134);
            this.serverB.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.serverB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.serverB.Name = "serverB";
            this.serverB.ReadOnly = true;
            this.serverB.Size = new System.Drawing.Size(44, 18);
            this.serverB.TabIndex = 7;
            this.serverB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.serverB.ValueChanged += new System.EventHandler(this.serverB_ValueChanged);
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time.Font = new System.Drawing.Font("Minecraft", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(12, 165);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(115, 24);
            this.time.TabIndex = 8;
            this.time.Text = "Time";
            // 
            // timeB
            // 
            this.timeB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.timeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeB.Font = new System.Drawing.Font("Minecraft", 11.25F);
            this.timeB.ForeColor = System.Drawing.SystemColors.Window;
            this.timeB.FormattingEnabled = true;
            this.timeB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "Unsure"});
            this.timeB.Location = new System.Drawing.Point(12, 195);
            this.timeB.Name = "timeB";
            this.timeB.Size = new System.Drawing.Size(121, 23);
            this.timeB.TabIndex = 9;
            this.timeB.SelectedIndexChanged += new System.EventHandler(this.timeB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(213, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 88);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraft", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(238, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "WynnIR created \r\nby Acer78.";
            // 
            // wynnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(443, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeB);
            this.Controls.Add(this.time);
            this.Controls.Add(this.serverB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nemractB);
            this.Controls.Add(this.almujB);
            this.Controls.Add(this.detlasB);
            this.Controls.Add(this.ragniB);
            this.Controls.Add(this.openThread);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wynnir";
            this.Text = "WynnIR";
            this.Load += new System.EventHandler(this.wynnir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openThread;
        private System.Windows.Forms.RadioButton ragniB;
        private System.Windows.Forms.RadioButton detlasB;
        private System.Windows.Forms.RadioButton almujB;
        private System.Windows.Forms.RadioButton nemractB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown serverB;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.ComboBox timeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


    }
}

