
namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_HEX = new System.Windows.Forms.TextBox();
            this.textBox_DEC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_OCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_BIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_HEX = new System.Windows.Forms.Label();
            this.label_DEC = new System.Windows.Forms.Label();
            this.label_OCT = new System.Windows.Forms.Label();
            this.label_BIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "HEX";
            // 
            // textBox_HEX
            // 
            this.textBox_HEX.Location = new System.Drawing.Point(68, 25);
            this.textBox_HEX.Name = "textBox_HEX";
            this.textBox_HEX.Size = new System.Drawing.Size(100, 22);
            this.textBox_HEX.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox_HEX, "Ведіть число \r\nу 16-му форматі");
            this.textBox_HEX.TextChanged += new System.EventHandler(this.textBox_All_TextChanged);
            this.textBox_HEX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_All_KeyPress);
            // 
            // textBox_DEC
            // 
            this.textBox_DEC.Location = new System.Drawing.Point(68, 53);
            this.textBox_DEC.Name = "textBox_DEC";
            this.textBox_DEC.Size = new System.Drawing.Size(100, 22);
            this.textBox_DEC.TabIndex = 7;
            this.textBox_DEC.TextChanged += new System.EventHandler(this.textBox_All_TextChanged);
            this.textBox_DEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_All_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEC";
            // 
            // textBox_OCT
            // 
            this.textBox_OCT.Location = new System.Drawing.Point(68, 81);
            this.textBox_OCT.Name = "textBox_OCT";
            this.textBox_OCT.Size = new System.Drawing.Size(100, 22);
            this.textBox_OCT.TabIndex = 9;
            this.textBox_OCT.TextChanged += new System.EventHandler(this.textBox_All_TextChanged);
            this.textBox_OCT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_All_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "OCT";
            // 
            // textBox_BIN
            // 
            this.textBox_BIN.Location = new System.Drawing.Point(68, 109);
            this.textBox_BIN.Name = "textBox_BIN";
            this.textBox_BIN.Size = new System.Drawing.Size(100, 22);
            this.textBox_BIN.TabIndex = 11;
            this.textBox_BIN.TextChanged += new System.EventHandler(this.textBox_All_TextChanged);
            this.textBox_BIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_All_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "BIN";
            // 
            // label_HEX
            // 
            this.label_HEX.AutoSize = true;
            this.label_HEX.Location = new System.Drawing.Point(178, 28);
            this.label_HEX.Name = "label_HEX";
            this.label_HEX.Size = new System.Drawing.Size(0, 17);
            this.label_HEX.TabIndex = 12;
            // 
            // label_DEC
            // 
            this.label_DEC.AutoSize = true;
            this.label_DEC.Location = new System.Drawing.Point(178, 57);
            this.label_DEC.Name = "label_DEC";
            this.label_DEC.Size = new System.Drawing.Size(0, 17);
            this.label_DEC.TabIndex = 13;
            // 
            // label_OCT
            // 
            this.label_OCT.AutoSize = true;
            this.label_OCT.Location = new System.Drawing.Point(178, 85);
            this.label_OCT.Name = "label_OCT";
            this.label_OCT.Size = new System.Drawing.Size(0, 17);
            this.label_OCT.TabIndex = 14;
            // 
            // label_BIN
            // 
            this.label_BIN.AutoSize = true;
            this.label_BIN.Location = new System.Drawing.Point(178, 113);
            this.label_BIN.Name = "label_BIN";
            this.label_BIN.Size = new System.Drawing.Size(0, 17);
            this.label_BIN.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 214);
            this.Controls.Add(this.label_BIN);
            this.Controls.Add(this.label_OCT);
            this.Controls.Add(this.label_DEC);
            this.Controls.Add(this.label_HEX);
            this.Controls.Add(this.textBox_BIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_OCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DEC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_HEX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_HEX;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_DEC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_OCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_BIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_HEX;
        private System.Windows.Forms.Label label_DEC;
        private System.Windows.Forms.Label label_OCT;
        private System.Windows.Forms.Label label_BIN;
    }
}

