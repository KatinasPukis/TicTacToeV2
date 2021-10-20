namespace TicTacToeV2
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
            this.textbox_x_value = new System.Windows.Forms.RichTextBox();
            this.textbox_y_value = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.choice_combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // textbox_x_value
            // 
            this.textbox_x_value.Location = new System.Drawing.Point(138, 106);
            this.textbox_x_value.Name = "textbox_x_value";
            this.textbox_x_value.Size = new System.Drawing.Size(50, 36);
            this.textbox_x_value.TabIndex = 1;
            this.textbox_x_value.Text = "";
            // 
            // textbox_y_value
            // 
            this.textbox_y_value.Location = new System.Drawing.Point(233, 106);
            this.textbox_y_value.Name = "textbox_y_value";
            this.textbox_y_value.Size = new System.Drawing.Size(50, 36);
            this.textbox_y_value.TabIndex = 2;
            this.textbox_y_value.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasirinkite dydi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pasirinkite kas pirmas pradeda:";
            // 
            // choice_combobox
            // 
            this.choice_combobox.FormattingEnabled = true;
            this.choice_combobox.Items.AddRange(new object[] {
            "X",
            "O"});
            this.choice_combobox.Location = new System.Drawing.Point(257, 175);
            this.choice_combobox.Name = "choice_combobox";
            this.choice_combobox.Size = new System.Drawing.Size(94, 21);
            this.choice_combobox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pradeti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choice_combobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_y_value);
            this.Controls.Add(this.textbox_x_value);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textbox_x_value;
        private System.Windows.Forms.RichTextBox textbox_y_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox choice_combobox;
        private System.Windows.Forms.Button button1;
    }
}

