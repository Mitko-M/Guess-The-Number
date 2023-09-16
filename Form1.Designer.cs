namespace GuessTheNumber
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
            txt = new TextBox();
            btn = new Button();
            label1 = new Label();
            lbl = new Label();
            button1 = new Button();
            label2 = new Label();
            tryAgain = new Button();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Location = new Point(332, 189);
            txt.Name = "txt";
            txt.Size = new Size(103, 23);
            txt.TabIndex = 0;
            // 
            // btn
            // 
            btn.Location = new Point(307, 289);
            btn.Name = "btn";
            btn.Size = new Size(144, 53);
            btn.TabIndex = 1;
            btn.Text = "Submit";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 143);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 2;
            label1.Text = "Guess the number from 1 to 10";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(322, 238);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 15);
            lbl.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(663, 378);
            button1.Name = "button1";
            button1.Size = new Size(104, 44);
            button1.TabIndex = 4;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(563, 128);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 5;
            label2.Text = "You have 3 trys";
            // 
            // tryAgain
            // 
            tryAgain.Location = new Point(663, 319);
            tryAgain.Name = "tryAgain";
            tryAgain.Size = new Size(104, 38);
            tryAgain.TabIndex = 6;
            tryAgain.Text = "Try again";
            tryAgain.UseVisualStyleBackColor = true;
            tryAgain.Click += tryAgain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tryAgain);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lbl);
            Controls.Add(label1);
            Controls.Add(btn);
            Controls.Add(txt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess The Number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
        private Button btn;
        private Label label1;
        private Label lbl;
        private Button button1;
        private Label label2;
        private Button tryAgain;
    }
}