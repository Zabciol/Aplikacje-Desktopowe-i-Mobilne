
namespace SimpleCalculatorApp
{
    partial class MainForm
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
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.textBoxFirsNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.labelSecondNumber = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonChangeChar = new System.Windows.Forms.Button();
            this.buttonProcent = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.AutoSize = true;
            this.labelFirstNumber.Location = new System.Drawing.Point(56, 27);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(88, 15);
            this.labelFirstNumber.TabIndex = 0;
            this.labelFirstNumber.Text = "Pierwsza liczba:";
            // 
            // textBoxFirsNumber
            // 
            this.textBoxFirsNumber.Location = new System.Drawing.Point(56, 45);
            this.textBoxFirsNumber.Name = "textBoxFirsNumber";
            this.textBoxFirsNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirsNumber.TabIndex = 1;
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Location = new System.Drawing.Point(183, 45);
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxSecondNumber.TabIndex = 3;
            // 
            // labelSecondNumber
            // 
            this.labelSecondNumber.AutoSize = true;
            this.labelSecondNumber.Location = new System.Drawing.Point(183, 27);
            this.labelSecondNumber.Name = "labelSecondNumber";
            this.labelSecondNumber.Size = new System.Drawing.Size(75, 15);
            this.labelSecondNumber.TabIndex = 2;
            this.labelSecondNumber.Text = "Druga liczba:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 95);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(100, 95);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(181, 95);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 23);
            this.buttonMul.TabIndex = 6;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(262, 95);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 7;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(19, 143);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 8;
            // 
            // buttonClean
            // 
            this.buttonClean.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClean.Location = new System.Drawing.Point(19, 139);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(60, 60);
            this.buttonClean.TabIndex = 9;
            this.buttonClean.Text = "C";
            this.buttonClean.UseVisualStyleBackColor = true;
            // 
            // buttonChangeChar
            // 
            this.buttonChangeChar.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeChar.Location = new System.Drawing.Point(85, 139);
            this.buttonChangeChar.Name = "buttonChangeChar";
            this.buttonChangeChar.Size = new System.Drawing.Size(60, 60);
            this.buttonChangeChar.TabIndex = 10;
            this.buttonChangeChar.Text = "+/-";
            this.buttonChangeChar.UseVisualStyleBackColor = true;
            // 
            // buttonProcent
            // 
            this.buttonProcent.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProcent.Location = new System.Drawing.Point(151, 139);
            this.buttonProcent.Name = "buttonProcent";
            this.buttonProcent.Size = new System.Drawing.Size(60, 60);
            this.buttonProcent.TabIndex = 11;
            this.buttonProcent.Text = "%";
            this.buttonProcent.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 13;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(151, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 14;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNumber1.Location = new System.Drawing.Point(19, 336);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(60, 60);
            this.buttonNumber1.TabIndex = 15;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber1_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNumber2.Location = new System.Drawing.Point(84, 337);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(60, 60);
            this.buttonNumber2.TabIndex = 16;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNumber3.Location = new System.Drawing.Point(151, 336);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(60, 60);
            this.buttonNumber3.TabIndex = 17;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDot.Location = new System.Drawing.Point(151, 402);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(60, 60);
            this.buttonDot.TabIndex = 18;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = true;
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNumber0.Location = new System.Drawing.Point(19, 402);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(125, 60);
            this.buttonNumber0.TabIndex = 19;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(217, 337);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 20;
            this.button12.Text = "➕";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(217, 271);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMinus.TabIndex = 21;
            this.buttonMinus.Text = "➖";
            this.buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiplication.Location = new System.Drawing.Point(217, 205);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(60, 60);
            this.buttonMultiplication.TabIndex = 22;
            this.buttonMultiplication.Text = "✖️";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDivision.Location = new System.Drawing.Point(217, 139);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(60, 60);
            this.buttonDivision.TabIndex = 23;
            this.buttonDivision.Text = "➗";
            this.buttonDivision.UseVisualStyleBackColor = true;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEqual.Location = new System.Drawing.Point(217, 402);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(60, 60);
            this.buttonEqual.TabIndex = 24;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNumber4.Location = new System.Drawing.Point(19, 270);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(60, 60);
            this.buttonNumber4.TabIndex = 25;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNumber5.Location = new System.Drawing.Point(84, 270);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(60, 60);
            this.buttonNumber5.TabIndex = 26;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(151, 270);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 27;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 489);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonNumber5);
            this.Controls.Add(this.buttonNumber4);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.buttonNumber0);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonNumber3);
            this.Controls.Add(this.buttonNumber2);
            this.Controls.Add(this.buttonNumber1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonProcent);
            this.Controls.Add(this.buttonChangeChar);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSecondNumber);
            this.Controls.Add(this.labelSecondNumber);
            this.Controls.Add(this.textBoxFirsNumber);
            this.Controls.Add(this.labelFirstNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Prosty kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.TextBox textBoxFirsNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.Label labelSecondNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonChangeChar;
        private System.Windows.Forms.Button buttonProcent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonNumber0;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button button7;
    }
}

