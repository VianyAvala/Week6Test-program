
namespace Week6Test_program
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
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.lblMessage3 = new System.Windows.Forms.Label();
            this.TxtEmployeeId = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.TxtEmployeeType = new System.Windows.Forms.GroupBox();
            this.LblMessage4 = new System.Windows.Forms.Label();
            this.TxtEmployeeType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Location = new System.Drawing.Point(207, 110);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(70, 13);
            this.lblMessage1.TabIndex = 0;
            this.lblMessage1.Text = "Employee No";
            this.lblMessage1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(207, 172);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(84, 13);
            this.lblMessage2.TabIndex = 1;
            this.lblMessage2.Text = "Employee Name";
            // 
            // lblMessage3
            // 
            this.lblMessage3.AutoSize = true;
            this.lblMessage3.Location = new System.Drawing.Point(207, 237);
            this.lblMessage3.Name = "lblMessage3";
            this.lblMessage3.Size = new System.Drawing.Size(36, 13);
            this.lblMessage3.TabIndex = 2;
            this.lblMessage3.Text = "Salary";
            // 
            // TxtEmployeeId
            // 
            this.TxtEmployeeId.Location = new System.Drawing.Point(312, 110);
            this.TxtEmployeeId.Name = "TxtEmployeeId";
            this.TxtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeId.TabIndex = 3;
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(312, 172);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeName.TabIndex = 4;
            // 
            // TxtEmployeeSalary
            // 
            this.TxtEmployeeSalary.Location = new System.Drawing.Point(312, 237);
            this.TxtEmployeeSalary.Name = "TxtEmployeeSalary";
            this.TxtEmployeeSalary.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeSalary.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(245, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(395, 325);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Payroll";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(38, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Consultant";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TxtEmployeeType
            // 
            this.TxtEmployeeType.Controls.Add(this.radioButton1);
            this.TxtEmployeeType.Controls.Add(this.radioButton2);
            this.TxtEmployeeType.Location = new System.Drawing.Point(511, 110);
            this.TxtEmployeeType.Name = "TxtEmployeeType";
            this.TxtEmployeeType.Size = new System.Drawing.Size(200, 100);
            this.TxtEmployeeType.TabIndex = 10;
            this.TxtEmployeeType.TabStop = false;
            this.TxtEmployeeType.Text = "Employee Type";
            // 
            // LblMessage4
            // 
            this.LblMessage4.AutoSize = true;
            this.LblMessage4.Location = new System.Drawing.Point(300, 416);
            this.LblMessage4.Name = "LblMessage4";
            this.LblMessage4.Size = new System.Drawing.Size(0, 13);
            this.LblMessage4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMessage4);
            this.Controls.Add(this.TxtEmployeeType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TxtEmployeeSalary);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.TxtEmployeeId);
            this.Controls.Add(this.lblMessage3);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TxtEmployeeType.ResumeLayout(false);
            this.TxtEmployeeType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Label lblMessage3;
        private System.Windows.Forms.TextBox TxtEmployeeId;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtEmployeeSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox TxtEmployeeType;
        private System.Windows.Forms.Label LblMessage4;
    }
}

