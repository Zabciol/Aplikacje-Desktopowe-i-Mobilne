
namespace Sprawdzian_3D
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
            this.labelDane = new System.Windows.Forms.Label();
            this.labelDataA = new System.Windows.Forms.Label();
            this.labelDataC = new System.Windows.Forms.Label();
            this.labelDataB = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxDataA = new System.Windows.Forms.TextBox();
            this.textBoxDataC = new System.Windows.Forms.TextBox();
            this.textBoxDataB = new System.Windows.Forms.TextBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDane
            // 
            this.labelDane.AutoSize = true;
            this.labelDane.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDane.Location = new System.Drawing.Point(12, 9);
            this.labelDane.Name = "labelDane";
            this.labelDane.Size = new System.Drawing.Size(115, 54);
            this.labelDane.TabIndex = 0;
            this.labelDane.Text = "Dane";
            // 
            // labelDataA
            // 
            this.labelDataA.AutoSize = true;
            this.labelDataA.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataA.Location = new System.Drawing.Point(12, 82);
            this.labelDataA.Name = "labelDataA";
            this.labelDataA.Size = new System.Drawing.Size(22, 28);
            this.labelDataA.TabIndex = 1;
            this.labelDataA.Text = "a";
            // 
            // labelDataC
            // 
            this.labelDataC.AutoSize = true;
            this.labelDataC.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataC.Location = new System.Drawing.Point(12, 138);
            this.labelDataC.Name = "labelDataC";
            this.labelDataC.Size = new System.Drawing.Size(21, 28);
            this.labelDataC.TabIndex = 2;
            this.labelDataC.Text = "c";
            // 
            // labelDataB
            // 
            this.labelDataB.AutoSize = true;
            this.labelDataB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataB.Location = new System.Drawing.Point(12, 110);
            this.labelDataB.Name = "labelDataB";
            this.labelDataB.Size = new System.Drawing.Size(24, 28);
            this.labelDataB.TabIndex = 3;
            this.labelDataB.Text = "b";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheck.Location = new System.Drawing.Point(12, 173);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(137, 44);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Policz";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBoxDataA
            // 
            this.textBoxDataA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDataA.Location = new System.Drawing.Point(49, 86);
            this.textBoxDataA.Name = "textBoxDataA";
            this.textBoxDataA.Size = new System.Drawing.Size(100, 23);
            this.textBoxDataA.TabIndex = 5;
            // 
            // textBoxDataC
            // 
            this.textBoxDataC.Location = new System.Drawing.Point(49, 144);
            this.textBoxDataC.Name = "textBoxDataC";
            this.textBoxDataC.Size = new System.Drawing.Size(100, 23);
            this.textBoxDataC.TabIndex = 6;
            // 
            // textBoxDataB
            // 
            this.textBoxDataB.Location = new System.Drawing.Point(49, 115);
            this.textBoxDataB.Name = "textBoxDataB";
            this.textBoxDataB.Size = new System.Drawing.Size(100, 23);
            this.textBoxDataB.TabIndex = 7;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResults.Location = new System.Drawing.Point(12, 220);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(90, 37);
            this.labelResults.TabIndex = 9;
            this.labelResults.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 303);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.textBoxDataB);
            this.Controls.Add(this.textBoxDataC);
            this.Controls.Add(this.textBoxDataA);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelDataB);
            this.Controls.Add(this.labelDataC);
            this.Controls.Add(this.labelDataA);
            this.Controls.Add(this.labelDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDane;
        private System.Windows.Forms.Label labelDataA;
        private System.Windows.Forms.Label labelDataC;
        private System.Windows.Forms.Label labelDataB;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxDataA;
        private System.Windows.Forms.TextBox textBoxDataC;
        private System.Windows.Forms.TextBox textBoxDataB;
        private System.Windows.Forms.Label labelResults;
    }
}

