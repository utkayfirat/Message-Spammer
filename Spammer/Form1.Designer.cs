
namespace Spammer
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
            this.startBotButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.intervalTextBox = new System.Windows.Forms.NumericUpDown();
            this.firstEnterCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startBotButton
            // 
            this.startBotButton.BackColor = System.Drawing.Color.Transparent;
            this.startBotButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startBotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBotButton.Location = new System.Drawing.Point(298, 58);
            this.startBotButton.Name = "startBotButton";
            this.startBotButton.Size = new System.Drawing.Size(176, 64);
            this.startBotButton.TabIndex = 0;
            this.startBotButton.Text = "Start";
            this.startBotButton.UseVisualStyleBackColor = false;
            this.startBotButton.Click += new System.EventHandler(this.startBotButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Milliseconds (1000 = 1)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.messageTextBox.Location = new System.Drawing.Point(12, 30);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(280, 92);
            this.messageTextBox.TabIndex = 6;
            this.messageTextBox.Text = "";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.BackColor = System.Drawing.Color.Black;
            this.intervalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intervalTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.intervalTextBox.Location = new System.Drawing.Point(298, 30);
            this.intervalTextBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(176, 22);
            this.intervalTextBox.TabIndex = 7;
            // 
            // firstEnterCheckBox
            // 
            this.firstEnterCheckBox.AutoSize = true;
            this.firstEnterCheckBox.Location = new System.Drawing.Point(12, 128);
            this.firstEnterCheckBox.Name = "firstEnterCheckBox";
            this.firstEnterCheckBox.Size = new System.Drawing.Size(157, 20);
            this.firstEnterCheckBox.TabIndex = 8;
            this.firstEnterCheckBox.Text = "First-Enter (OFFLINE)";
            this.firstEnterCheckBox.UseVisualStyleBackColor = true;
            this.firstEnterCheckBox.CheckedChanged += new System.EventHandler(this.firstEnterCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(486, 158);
            this.Controls.Add(this.firstEnterCheckBox);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBotButton);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spammer";
            ((System.ComponentModel.ISupportInitialize)(this.intervalTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBotButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.NumericUpDown intervalTextBox;
        private System.Windows.Forms.CheckBox firstEnterCheckBox;
    }
}

