namespace WindowsFormsApplication1
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
            this.txtbxMachine = new System.Windows.Forms.TextBox();
            this.txtbxTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxDirection = new System.Windows.Forms.TextBox();
            this.lstbxResults = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnStopTest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxIDNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxMachine
            // 
            this.txtbxMachine.Location = new System.Drawing.Point(308, 24);
            this.txtbxMachine.Name = "txtbxMachine";
            this.txtbxMachine.ReadOnly = true;
            this.txtbxMachine.Size = new System.Drawing.Size(305, 20);
            this.txtbxMachine.TabIndex = 0;
            // 
            // txtbxTest
            // 
            this.txtbxTest.Location = new System.Drawing.Point(308, 92);
            this.txtbxTest.Name = "txtbxTest";
            this.txtbxTest.ReadOnly = true;
            this.txtbxTest.Size = new System.Drawing.Size(304, 20);
            this.txtbxTest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Machine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direction";
            // 
            // txtbxDirection
            // 
            this.txtbxDirection.Location = new System.Drawing.Point(308, 131);
            this.txtbxDirection.Multiline = true;
            this.txtbxDirection.Name = "txtbxDirection";
            this.txtbxDirection.ReadOnly = true;
            this.txtbxDirection.Size = new System.Drawing.Size(304, 89);
            this.txtbxDirection.TabIndex = 4;
            // 
            // lstbxResults
            // 
            this.lstbxResults.FormattingEnabled = true;
            this.lstbxResults.Location = new System.Drawing.Point(308, 241);
            this.lstbxResults.Name = "lstbxResults";
            this.lstbxResults.Size = new System.Drawing.Size(304, 134);
            this.lstbxResults.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Results";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(317, 402);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(131, 29);
            this.btnStartTest.TabIndex = 8;
            this.btnStartTest.Text = "Start Test!";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // btnStopTest
            // 
            this.btnStopTest.Location = new System.Drawing.Point(454, 402);
            this.btnStopTest.Name = "btnStopTest";
            this.btnStopTest.Size = new System.Drawing.Size(131, 29);
            this.btnStopTest.TabIndex = 9;
            this.btnStopTest.Text = "Stop Test";
            this.btnStopTest.UseVisualStyleBackColor = true;
            this.btnStopTest.Click += new System.EventHandler(this.btnStopTest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID Number";
            // 
            // txtbxIDNumber
            // 
            this.txtbxIDNumber.Location = new System.Drawing.Point(308, 57);
            this.txtbxIDNumber.Name = "txtbxIDNumber";
            this.txtbxIDNumber.ReadOnly = true;
            this.txtbxIDNumber.Size = new System.Drawing.Size(304, 20);
            this.txtbxIDNumber.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxIDNumber);
            this.Controls.Add(this.btnStopTest);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstbxResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxDirection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxTest);
            this.Controls.Add(this.txtbxMachine);
            this.Name = "Form1";
            this.Text = "Device Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxMachine;
        private System.Windows.Forms.TextBox txtbxTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxDirection;
        private System.Windows.Forms.ListBox lstbxResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnStopTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxIDNumber;
    }
}

