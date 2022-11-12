namespace VolumeCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.value1Lbl = new System.Windows.Forms.Label();
            this.value2Lbl = new System.Windows.Forms.Label();
            this.value3Lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.value3 = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Shape";
            // 
            // value1Lbl
            // 
            this.value1Lbl.AutoSize = true;
            this.value1Lbl.BackColor = System.Drawing.Color.Transparent;
            this.value1Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1Lbl.ForeColor = System.Drawing.Color.White;
            this.value1Lbl.Location = new System.Drawing.Point(86, 184);
            this.value1Lbl.Name = "value1Lbl";
            this.value1Lbl.Size = new System.Drawing.Size(77, 27);
            this.value1Lbl.TabIndex = 2;
            this.value1Lbl.Text = "Value1";
            // 
            // value2Lbl
            // 
            this.value2Lbl.AutoSize = true;
            this.value2Lbl.BackColor = System.Drawing.Color.Transparent;
            this.value2Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2Lbl.ForeColor = System.Drawing.Color.White;
            this.value2Lbl.Location = new System.Drawing.Point(86, 235);
            this.value2Lbl.Name = "value2Lbl";
            this.value2Lbl.Size = new System.Drawing.Size(77, 27);
            this.value2Lbl.TabIndex = 3;
            this.value2Lbl.Text = "Value2";
            // 
            // value3Lbl
            // 
            this.value3Lbl.AutoSize = true;
            this.value3Lbl.BackColor = System.Drawing.Color.Transparent;
            this.value3Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value3Lbl.ForeColor = System.Drawing.Color.White;
            this.value3Lbl.Location = new System.Drawing.Point(86, 284);
            this.value3Lbl.Name = "value3Lbl";
            this.value3Lbl.Size = new System.Drawing.Size(77, 27);
            this.value3Lbl.TabIndex = 4;
            this.value3Lbl.Text = "Value3";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 33);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // value1
            // 
            this.value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1.Location = new System.Drawing.Point(206, 184);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(134, 30);
            this.value1.TabIndex = 6;
            // 
            // value2
            // 
            this.value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2.Location = new System.Drawing.Point(206, 235);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(134, 30);
            this.value2.TabIndex = 7;
            // 
            // value3
            // 
            this.value3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value3.Location = new System.Drawing.Point(206, 289);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(134, 30);
            this.value3.TabIndex = 8;
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.ForeColor = System.Drawing.Color.White;
            this.volume.Location = new System.Drawing.Point(39, 419);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(185, 27);
            this.volume.TabIndex = 9;
            this.volume.Text = "Volume in (cm3)=";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(242, 419);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(66, 25);
            this.result.TabIndex = 10;
            this.result.Text = "Result";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(134, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.value3Lbl);
            this.Controls.Add(this.value2Lbl);
            this.Controls.Add(this.value1Lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label value1Lbl;
        private System.Windows.Forms.Label value2Lbl;
        private System.Windows.Forms.Label value3Lbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.TextBox value3;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
    }
}

