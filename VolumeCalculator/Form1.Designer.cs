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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.value1Lbl = new System.Windows.Forms.Label();
            this.value2Lbl = new System.Windows.Forms.Label();
            this.value3Lbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Shape";
            // 
            // value1Lbl
            // 
            this.value1Lbl.AutoSize = true;
            this.value1Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1Lbl.Location = new System.Drawing.Point(64, 184);
            this.value1Lbl.Name = "value1Lbl";
            this.value1Lbl.Size = new System.Drawing.Size(77, 27);
            this.value1Lbl.TabIndex = 2;
            this.value1Lbl.Text = "Value1";
            // 
            // value2Lbl
            // 
            this.value2Lbl.AutoSize = true;
            this.value2Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2Lbl.Location = new System.Drawing.Point(64, 235);
            this.value2Lbl.Name = "value2Lbl";
            this.value2Lbl.Size = new System.Drawing.Size(77, 27);
            this.value2Lbl.TabIndex = 3;
            this.value2Lbl.Text = "Value2";
            // 
            // value3Lbl
            // 
            this.value3Lbl.AutoSize = true;
            this.value3Lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value3Lbl.Location = new System.Drawing.Point(64, 286);
            this.value3Lbl.Name = "value3Lbl";
            this.value3Lbl.Size = new System.Drawing.Size(77, 27);
            this.value3Lbl.TabIndex = 4;
            this.value3Lbl.Text = "Value3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 517);
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
    }
}

