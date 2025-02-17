namespace Calculadora
{
    partial class CalcForm
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
            DisplayText = new TextBox();
            signButton = new Button();
            zeroButton = new Button();
            dotButton = new Button();
            percentButton = new Button();
            equalButton = new Button();
            plusButton = new Button();
            minusButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            divisionButton = new Button();
            multiButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            ceButton = new Button();
            cButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            SuspendLayout();
            // 
            // DisplayText
            // 
            DisplayText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DisplayText.BackColor = Color.LightGray;
            DisplayText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            DisplayText.Location = new Point(12, 12);
            DisplayText.Margin = new Padding(3, 1, 3, 1);
            DisplayText.Name = "DisplayText";
            DisplayText.ReadOnly = true;
            DisplayText.Size = new Size(524, 36);
            DisplayText.TabIndex = 0;
            DisplayText.TextAlign = HorizontalAlignment.Right;
            // 
            // signButton
            // 
            signButton.BackColor = Color.LightGray;
            signButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            signButton.ForeColor = SystemColors.ActiveCaptionText;
            signButton.Location = new Point(12, 269);
            signButton.Margin = new Padding(0);
            signButton.Name = "signButton";
            signButton.Size = new Size(91, 62);
            signButton.TabIndex = 1;
            signButton.Text = "+/-";
            signButton.UseVisualStyleBackColor = false;
            signButton.Click += signButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = Color.LightGray;
            zeroButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            zeroButton.ForeColor = SystemColors.ActiveCaptionText;
            zeroButton.Location = new Point(109, 269);
            zeroButton.Margin = new Padding(0);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(91, 62);
            zeroButton.TabIndex = 2;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += NumberButtonClick;
            // 
            // dotButton
            // 
            dotButton.BackColor = Color.LightGray;
            dotButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dotButton.ForeColor = SystemColors.ActiveCaptionText;
            dotButton.Location = new Point(206, 269);
            dotButton.Margin = new Padding(0);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(91, 62);
            dotButton.TabIndex = 3;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = false;
            dotButton.Click += dotButton_Click;
            // 
            // percentButton
            // 
            percentButton.BackColor = Color.LightGray;
            percentButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            percentButton.ForeColor = SystemColors.ActiveCaptionText;
            percentButton.Location = new Point(445, 269);
            percentButton.Margin = new Padding(0);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(91, 62);
            percentButton.TabIndex = 4;
            percentButton.Text = "%";
            percentButton.UseVisualStyleBackColor = false;
            percentButton.Click += OperatorButtonClick;
            // 
            // equalButton
            // 
            equalButton.BackColor = Color.LightGray;
            equalButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            equalButton.ForeColor = SystemColors.ActiveCaptionText;
            equalButton.Location = new Point(348, 269);
            equalButton.Margin = new Padding(0);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(91, 62);
            equalButton.TabIndex = 5;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += equalButton_Click;
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.LightGray;
            plusButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            plusButton.ForeColor = SystemColors.ActiveCaptionText;
            plusButton.Location = new Point(348, 201);
            plusButton.Margin = new Padding(0);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(91, 62);
            plusButton.TabIndex = 10;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += OperatorButtonClick;
            // 
            // minusButton
            // 
            minusButton.BackColor = Color.LightGray;
            minusButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            minusButton.ForeColor = SystemColors.ActiveCaptionText;
            minusButton.Location = new Point(445, 201);
            minusButton.Margin = new Padding(0);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(91, 62);
            minusButton.TabIndex = 9;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = false;
            minusButton.Click += OperatorButtonClick;
            // 
            // threeButton
            // 
            threeButton.BackColor = Color.LightGray;
            threeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            threeButton.ForeColor = SystemColors.ActiveCaptionText;
            threeButton.Location = new Point(206, 201);
            threeButton.Margin = new Padding(0);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(91, 62);
            threeButton.TabIndex = 8;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += NumberButtonClick;
            // 
            // twoButton
            // 
            twoButton.BackColor = Color.LightGray;
            twoButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            twoButton.ForeColor = SystemColors.ActiveCaptionText;
            twoButton.Location = new Point(109, 201);
            twoButton.Margin = new Padding(0);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(91, 62);
            twoButton.TabIndex = 7;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += NumberButtonClick;
            // 
            // oneButton
            // 
            oneButton.BackColor = Color.LightGray;
            oneButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            oneButton.ForeColor = SystemColors.ActiveCaptionText;
            oneButton.Location = new Point(12, 201);
            oneButton.Margin = new Padding(0);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(91, 62);
            oneButton.TabIndex = 6;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += NumberButtonClick;
            // 
            // divisionButton
            // 
            divisionButton.BackColor = Color.LightGray;
            divisionButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            divisionButton.ForeColor = SystemColors.ActiveCaptionText;
            divisionButton.Location = new Point(348, 133);
            divisionButton.Margin = new Padding(0);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(91, 62);
            divisionButton.TabIndex = 15;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = false;
            divisionButton.Click += OperatorButtonClick;
            // 
            // multiButton
            // 
            multiButton.BackColor = Color.LightGray;
            multiButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            multiButton.ForeColor = SystemColors.ActiveCaptionText;
            multiButton.Location = new Point(445, 133);
            multiButton.Margin = new Padding(0);
            multiButton.Name = "multiButton";
            multiButton.Size = new Size(91, 62);
            multiButton.TabIndex = 14;
            multiButton.Text = "X";
            multiButton.UseVisualStyleBackColor = false;
            multiButton.Click += OperatorButtonClick;
            // 
            // sixButton
            // 
            sixButton.BackColor = Color.LightGray;
            sixButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sixButton.ForeColor = SystemColors.ActiveCaptionText;
            sixButton.Location = new Point(206, 133);
            sixButton.Margin = new Padding(0);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(91, 62);
            sixButton.TabIndex = 13;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += NumberButtonClick;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = Color.LightGray;
            fiveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fiveButton.ForeColor = SystemColors.ActiveCaptionText;
            fiveButton.Location = new Point(109, 133);
            fiveButton.Margin = new Padding(0);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(91, 62);
            fiveButton.TabIndex = 12;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += NumberButtonClick;
            // 
            // fourButton
            // 
            fourButton.BackColor = Color.LightGray;
            fourButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fourButton.ForeColor = SystemColors.ActiveCaptionText;
            fourButton.Location = new Point(12, 133);
            fourButton.Margin = new Padding(0);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(91, 62);
            fourButton.TabIndex = 11;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += NumberButtonClick;
            // 
            // ceButton
            // 
            ceButton.BackColor = Color.LightGray;
            ceButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ceButton.ForeColor = SystemColors.ActiveCaptionText;
            ceButton.Location = new Point(348, 65);
            ceButton.Margin = new Padding(0);
            ceButton.Name = "ceButton";
            ceButton.Size = new Size(91, 62);
            ceButton.TabIndex = 20;
            ceButton.Text = "CE";
            ceButton.UseVisualStyleBackColor = false;
            ceButton.Click += ceButton_Click;
            // 
            // cButton
            // 
            cButton.BackColor = Color.LightGray;
            cButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cButton.ForeColor = SystemColors.ActiveCaptionText;
            cButton.Location = new Point(445, 65);
            cButton.Margin = new Padding(0);
            cButton.Name = "cButton";
            cButton.Size = new Size(91, 62);
            cButton.TabIndex = 19;
            cButton.Text = "C";
            cButton.UseVisualStyleBackColor = false;
            cButton.Click += cButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = Color.LightGray;
            nineButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            nineButton.ForeColor = SystemColors.ActiveCaptionText;
            nineButton.Location = new Point(206, 65);
            nineButton.Margin = new Padding(0);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(91, 62);
            nineButton.TabIndex = 18;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += NumberButtonClick;
            // 
            // eightButton
            // 
            eightButton.BackColor = Color.LightGray;
            eightButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            eightButton.ForeColor = SystemColors.ActiveCaptionText;
            eightButton.Location = new Point(109, 65);
            eightButton.Margin = new Padding(0);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(91, 62);
            eightButton.TabIndex = 17;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += NumberButtonClick;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = Color.LightGray;
            sevenButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sevenButton.ForeColor = SystemColors.ActiveCaptionText;
            sevenButton.Location = new Point(12, 65);
            sevenButton.Margin = new Padding(0);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(91, 62);
            sevenButton.TabIndex = 16;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += NumberButtonClick;
            // 
            // CalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(548, 342);
            Controls.Add(ceButton);
            Controls.Add(cButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(divisionButton);
            Controls.Add(multiButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(plusButton);
            Controls.Add(minusButton);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(equalButton);
            Controls.Add(percentButton);
            Controls.Add(dotButton);
            Controls.Add(zeroButton);
            Controls.Add(signButton);
            Controls.Add(DisplayText);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CalcForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Calculadora";
            Load += CalcForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DisplayText;
        private Button signButton;
        private Button zeroButton;
        private Button dotButton;
        private Button percentButton;
        private Button equalButton;
        private Button plusButton;
        private Button minusButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private Button divisionButton;
        private Button multiButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button ceButton;
        private Button cButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
    }
}
