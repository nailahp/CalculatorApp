namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            buttonOnOff = new Button();
            button7 = new Button();
            button4 = new Button();
            button1 = new Button();
            buttonPlusMinus = new Button();
            buttonC = new Button();
            button8 = new Button();
            button5 = new Button();
            button2 = new Button();
            button0 = new Button();
            buttonDel = new Button();
            button9 = new Button();
            button6 = new Button();
            button3 = new Button();
            buttonDecimal = new Button();
            buttonDivided = new Button();
            buttonTimes = new Button();
            buttonMinus = new Button();
            buttonAdd = new Button();
            buttonEqual = new Button();
            textBoxDisplay = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // buttonOnOff
            // 
            buttonOnOff.BackColor = Color.DimGray;
            buttonOnOff.BackgroundImageLayout = ImageLayout.None;
            buttonOnOff.FlatAppearance.BorderColor = Color.DimGray;
            buttonOnOff.FlatAppearance.BorderSize = 0;
            buttonOnOff.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonOnOff.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonOnOff.FlatStyle = FlatStyle.Flat;
            buttonOnOff.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOnOff.ForeColor = SystemColors.ControlLightLight;
            buttonOnOff.Location = new Point(39, 150);
            buttonOnOff.Name = "buttonOnOff";
            buttonOnOff.Size = new Size(100, 70);
            buttonOnOff.TabIndex = 0;
            buttonOnOff.Text = "ON/OFF";
            buttonOnOff.UseVisualStyleBackColor = false;
            buttonOnOff.Click += buttonOnOff_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatAppearance.BorderColor = Color.DimGray;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button7.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(39, 253);
            button7.Name = "button7";
            button7.Size = new Size(100, 70);
            button7.TabIndex = 1;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderColor = Color.DimGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button4.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(39, 351);
            button4.Name = "button4";
            button4.Size = new Size(100, 70);
            button4.TabIndex = 2;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(39, 451);
            button1.Name = "button1";
            button1.Size = new Size(100, 70);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button4_Click;
            // 
            // buttonPlusMinus
            // 
            buttonPlusMinus.BackColor = Color.DimGray;
            buttonPlusMinus.BackgroundImageLayout = ImageLayout.None;
            buttonPlusMinus.FlatAppearance.BorderColor = Color.DimGray;
            buttonPlusMinus.FlatAppearance.BorderSize = 0;
            buttonPlusMinus.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonPlusMinus.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonPlusMinus.FlatStyle = FlatStyle.Flat;
            buttonPlusMinus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPlusMinus.ForeColor = SystemColors.ControlLightLight;
            buttonPlusMinus.Location = new Point(39, 551);
            buttonPlusMinus.Name = "buttonPlusMinus";
            buttonPlusMinus.Size = new Size(100, 70);
            buttonPlusMinus.TabIndex = 4;
            buttonPlusMinus.Text = "+/-";
            buttonPlusMinus.UseVisualStyleBackColor = false;
            buttonPlusMinus.Click += buttonPlusMinus_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.DimGray;
            buttonC.BackgroundImageLayout = ImageLayout.None;
            buttonC.FlatAppearance.BorderColor = Color.DimGray;
            buttonC.FlatAppearance.BorderSize = 0;
            buttonC.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonC.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonC.FlatStyle = FlatStyle.Flat;
            buttonC.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonC.ForeColor = SystemColors.ControlLightLight;
            buttonC.Location = new Point(164, 150);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(100, 70);
            buttonC.TabIndex = 5;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.FlatAppearance.BorderColor = Color.DimGray;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button8.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(166, 253);
            button8.Name = "button8";
            button8.Size = new Size(100, 70);
            button8.TabIndex = 6;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderColor = Color.DimGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button5.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(164, 351);
            button5.Name = "button5";
            button5.Size = new Size(100, 70);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button2.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(166, 451);
            button2.Name = "button2";
            button2.Size = new Size(100, 70);
            button2.TabIndex = 8;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.DimGray;
            button0.BackgroundImageLayout = ImageLayout.None;
            button0.FlatAppearance.BorderColor = Color.DimGray;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button0.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button0.ForeColor = SystemColors.ControlLightLight;
            button0.Location = new Point(166, 551);
            button0.Name = "button0";
            button0.Size = new Size(100, 70);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.DimGray;
            buttonDel.BackgroundImageLayout = ImageLayout.None;
            buttonDel.FlatAppearance.BorderColor = Color.DimGray;
            buttonDel.FlatAppearance.BorderSize = 0;
            buttonDel.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonDel.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonDel.FlatStyle = FlatStyle.Flat;
            buttonDel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDel.ForeColor = SystemColors.ControlLightLight;
            buttonDel.Location = new Point(294, 150);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(100, 70);
            buttonDel.TabIndex = 10;
            buttonDel.Text = "Del";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.FlatAppearance.BorderColor = Color.DimGray;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button9.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(294, 253);
            button9.Name = "button9";
            button9.Size = new Size(100, 70);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.BorderColor = Color.DimGray;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button6.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(294, 351);
            button6.Name = "button6";
            button6.Size = new Size(100, 70);
            button6.TabIndex = 12;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button13_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.DimGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button3.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(294, 451);
            button3.Name = "button3";
            button3.Size = new Size(100, 70);
            button3.TabIndex = 13;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // buttonDecimal
            // 
            buttonDecimal.BackColor = Color.DimGray;
            buttonDecimal.BackgroundImageLayout = ImageLayout.None;
            buttonDecimal.FlatAppearance.BorderColor = Color.DimGray;
            buttonDecimal.FlatAppearance.BorderSize = 0;
            buttonDecimal.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonDecimal.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonDecimal.FlatStyle = FlatStyle.Flat;
            buttonDecimal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDecimal.ForeColor = SystemColors.ControlLightLight;
            buttonDecimal.Location = new Point(294, 551);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(100, 70);
            buttonDecimal.TabIndex = 14;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = false;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // buttonDivided
            // 
            buttonDivided.BackColor = Color.DimGray;
            buttonDivided.BackgroundImageLayout = ImageLayout.None;
            buttonDivided.FlatAppearance.BorderColor = Color.DimGray;
            buttonDivided.FlatAppearance.BorderSize = 0;
            buttonDivided.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonDivided.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonDivided.FlatStyle = FlatStyle.Flat;
            buttonDivided.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivided.ForeColor = SystemColors.ControlLightLight;
            buttonDivided.Location = new Point(420, 150);
            buttonDivided.Name = "buttonDivided";
            buttonDivided.Size = new Size(100, 70);
            buttonDivided.TabIndex = 15;
            buttonDivided.Text = "/";
            buttonDivided.UseVisualStyleBackColor = false;
            buttonDivided.Click += buttonDivided_Click;
            // 
            // buttonTimes
            // 
            buttonTimes.BackColor = Color.DimGray;
            buttonTimes.BackgroundImageLayout = ImageLayout.None;
            buttonTimes.FlatAppearance.BorderColor = Color.DimGray;
            buttonTimes.FlatAppearance.BorderSize = 0;
            buttonTimes.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonTimes.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonTimes.FlatStyle = FlatStyle.Flat;
            buttonTimes.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTimes.ForeColor = SystemColors.ControlLightLight;
            buttonTimes.Location = new Point(420, 253);
            buttonTimes.Name = "buttonTimes";
            buttonTimes.Size = new Size(100, 70);
            buttonTimes.TabIndex = 16;
            buttonTimes.Text = "x";
            buttonTimes.UseVisualStyleBackColor = false;
            buttonTimes.Click += buttonTimes_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.DimGray;
            buttonMinus.BackgroundImageLayout = ImageLayout.None;
            buttonMinus.FlatAppearance.BorderColor = Color.DimGray;
            buttonMinus.FlatAppearance.BorderSize = 0;
            buttonMinus.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonMinus.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMinus.ForeColor = SystemColors.ControlLightLight;
            buttonMinus.Location = new Point(420, 351);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(100, 70);
            buttonMinus.TabIndex = 17;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DimGray;
            buttonAdd.BackgroundImageLayout = ImageLayout.None;
            buttonAdd.FlatAppearance.BorderColor = Color.DimGray;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonAdd.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(420, 451);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 70);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = Color.DodgerBlue;
            buttonEqual.BackgroundImageLayout = ImageLayout.None;
            buttonEqual.FlatAppearance.BorderColor = Color.DimGray;
            buttonEqual.FlatAppearance.BorderSize = 0;
            buttonEqual.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonEqual.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonEqual.FlatStyle = FlatStyle.Flat;
            buttonEqual.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEqual.ForeColor = SystemColors.ControlLightLight;
            buttonEqual.Location = new Point(420, 551);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(100, 70);
            buttonEqual.TabIndex = 19;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.BackColor = SystemColors.ActiveCaptionText;
            textBoxDisplay.BorderStyle = BorderStyle.None;
            textBoxDisplay.Font = new Font("Segoe UI", 43.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxDisplay.ForeColor = SystemColors.Window;
            textBoxDisplay.Location = new Point(39, 24);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.RightToLeft = RightToLeft.Yes;
            textBoxDisplay.Size = new Size(481, 98);
            textBoxDisplay.TabIndex = 20;
            textBoxDisplay.Text = "0";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(561, 661);
            Controls.Add(textBoxDisplay);
            Controls.Add(buttonEqual);
            Controls.Add(buttonAdd);
            Controls.Add(buttonMinus);
            Controls.Add(buttonTimes);
            Controls.Add(buttonDivided);
            Controls.Add(buttonDecimal);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button9);
            Controls.Add(buttonDel);
            Controls.Add(button0);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button8);
            Controls.Add(buttonC);
            Controls.Add(buttonPlusMinus);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(buttonOnOff);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            Text = "Kalkulator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOnOff;
        private Button button7;
        private Button button4;
        private Button button1;
        private Button buttonPlusMinus;
        private Button buttonC;
        private Button button8;
        private Button button5;
        private Button button2;
        private Button button0;
        private Button buttonDel;
        private Button button9;
        private Button button6;
        private Button button3;
        private Button buttonDecimal;
        private Button buttonDivided;
        private Button buttonTimes;
        private Button buttonMinus;
        private Button buttonAdd;
        private Button buttonEqual;
        private TextBox textBoxDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
