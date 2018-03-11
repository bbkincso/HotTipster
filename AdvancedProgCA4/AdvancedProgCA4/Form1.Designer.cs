namespace AdvancedProgCA4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRaceCourse = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rdoLost = new System.Windows.Forms.RadioButton();
            this.rdoWon = new System.Windows.Forms.RadioButton();
            this.lblRaceCourse = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblEfficiency = new System.Windows.Forms.Label();
            this.btnEfficiency = new System.Windows.Forms.Button();
            this.lblPopularRCourse = new System.Windows.Forms.Label();
            this.btnMostPopRaceCourse = new System.Windows.Forms.Button();
            this.lblHighest = new System.Windows.Forms.Label();
            this.btnMostValues = new System.Windows.Forms.Button();
            this.btnTotalProfitLoss = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnOrderByDate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Records";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.txtRaceCourse);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.rdoLost);
            this.groupBox1.Controls.Add(this.rdoWon);
            this.groupBox1.Controls.Add(this.lblRaceCourse);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Location = new System.Drawing.Point(99, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new bet record";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(214, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add new record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(214, 106);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // txtRaceCourse
            // 
            this.txtRaceCourse.Location = new System.Drawing.Point(214, 64);
            this.txtRaceCourse.Name = "txtRaceCourse";
            this.txtRaceCourse.Size = new System.Drawing.Size(100, 20);
            this.txtRaceCourse.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(214, 142);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // rdoLost
            // 
            this.rdoLost.AutoSize = true;
            this.rdoLost.Location = new System.Drawing.Point(214, 192);
            this.rdoLost.Name = "rdoLost";
            this.rdoLost.Size = new System.Drawing.Size(45, 17);
            this.rdoLost.TabIndex = 4;
            this.rdoLost.TabStop = true;
            this.rdoLost.Text = "Lost";
            this.rdoLost.UseVisualStyleBackColor = true;
            // 
            // rdoWon
            // 
            this.rdoWon.AutoSize = true;
            this.rdoWon.Checked = true;
            this.rdoWon.Location = new System.Drawing.Point(111, 192);
            this.rdoWon.Name = "rdoWon";
            this.rdoWon.Size = new System.Drawing.Size(48, 17);
            this.rdoWon.TabIndex = 3;
            this.rdoWon.TabStop = true;
            this.rdoWon.Text = "Won";
            this.rdoWon.UseVisualStyleBackColor = true;
            // 
            // lblRaceCourse
            // 
            this.lblRaceCourse.AutoSize = true;
            this.lblRaceCourse.Location = new System.Drawing.Point(108, 67);
            this.lblRaceCourse.Name = "lblRaceCourse";
            this.lblRaceCourse.Size = new System.Drawing.Size(72, 13);
            this.lblRaceCourse.TabIndex = 2;
            this.lblRaceCourse.Text = "Race Course:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(108, 145);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(108, 106);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblEfficiency);
            this.tabPage2.Controls.Add(this.btnEfficiency);
            this.tabPage2.Controls.Add(this.lblPopularRCourse);
            this.tabPage2.Controls.Add(this.btnMostPopRaceCourse);
            this.tabPage2.Controls.Add(this.lblHighest);
            this.tabPage2.Controls.Add(this.btnMostValues);
            this.tabPage2.Controls.Add(this.btnTotalProfitLoss);
            this.tabPage2.Controls.Add(this.btnWrite);
            this.tabPage2.Controls.Add(this.btnOrderByDate);
            this.tabPage2.Controls.Add(this.btnShow);
            this.tabPage2.Controls.Add(this.rtbDisplay);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(608, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show Record";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblEfficiency
            // 
            this.lblEfficiency.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEfficiency.Location = new System.Drawing.Point(240, 344);
            this.lblEfficiency.Name = "lblEfficiency";
            this.lblEfficiency.Size = new System.Drawing.Size(347, 23);
            this.lblEfficiency.TabIndex = 10;
            // 
            // btnEfficiency
            // 
            this.btnEfficiency.Location = new System.Drawing.Point(22, 344);
            this.btnEfficiency.Name = "btnEfficiency";
            this.btnEfficiency.Size = new System.Drawing.Size(186, 23);
            this.btnEfficiency.TabIndex = 9;
            this.btnEfficiency.Text = "Efficiency";
            this.btnEfficiency.UseVisualStyleBackColor = true;
            this.btnEfficiency.Click += new System.EventHandler(this.btnEfficiency_Click);
            // 
            // lblPopularRCourse
            // 
            this.lblPopularRCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPopularRCourse.Location = new System.Drawing.Point(243, 303);
            this.lblPopularRCourse.Name = "lblPopularRCourse";
            this.lblPopularRCourse.Size = new System.Drawing.Size(347, 23);
            this.lblPopularRCourse.TabIndex = 8;
            // 
            // btnMostPopRaceCourse
            // 
            this.btnMostPopRaceCourse.Location = new System.Drawing.Point(22, 303);
            this.btnMostPopRaceCourse.Name = "btnMostPopRaceCourse";
            this.btnMostPopRaceCourse.Size = new System.Drawing.Size(186, 23);
            this.btnMostPopRaceCourse.TabIndex = 7;
            this.btnMostPopRaceCourse.Text = "The Most Popular Race Course";
            this.btnMostPopRaceCourse.UseVisualStyleBackColor = true;
            this.btnMostPopRaceCourse.Click += new System.EventHandler(this.btnMostPopRaceCourse_Click);
            // 
            // lblHighest
            // 
            this.lblHighest.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHighest.Location = new System.Drawing.Point(243, 260);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(347, 23);
            this.lblHighest.TabIndex = 6;
            // 
            // btnMostValues
            // 
            this.btnMostValues.Location = new System.Drawing.Point(22, 260);
            this.btnMostValues.Name = "btnMostValues";
            this.btnMostValues.Size = new System.Drawing.Size(186, 23);
            this.btnMostValues.TabIndex = 5;
            this.btnMostValues.Text = "Highest Amount Won and Most Lost";
            this.btnMostValues.UseVisualStyleBackColor = true;
            this.btnMostValues.Click += new System.EventHandler(this.btnMostValues_Click);
            // 
            // btnTotalProfitLoss
            // 
            this.btnTotalProfitLoss.Location = new System.Drawing.Point(22, 190);
            this.btnTotalProfitLoss.Name = "btnTotalProfitLoss";
            this.btnTotalProfitLoss.Size = new System.Drawing.Size(186, 23);
            this.btnTotalProfitLoss.TabIndex = 4;
            this.btnTotalProfitLoss.Text = "Total Profit and Total Loss By Year";
            this.btnTotalProfitLoss.UseVisualStyleBackColor = true;
            this.btnTotalProfitLoss.Click += new System.EventHandler(this.btnTotalProfitLoss_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(22, 18);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(186, 23);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Create File/Load Data";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnOrderByDate
            // 
            this.btnOrderByDate.Location = new System.Drawing.Point(22, 149);
            this.btnOrderByDate.Name = "btnOrderByDate";
            this.btnOrderByDate.Size = new System.Drawing.Size(186, 23);
            this.btnOrderByDate.TabIndex = 2;
            this.btnOrderByDate.Text = "Order By Date";
            this.btnOrderByDate.UseVisualStyleBackColor = true;
            this.btnOrderByDate.Click += new System.EventHandler(this.btnOrderByDate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(22, 109);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(186, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show All Records";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(243, 18);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(347, 195);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRaceCourse;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRaceCourse;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton rdoLost;
        private System.Windows.Forms.RadioButton rdoWon;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnOrderByDate;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnTotalProfitLoss;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Button btnMostValues;
        private System.Windows.Forms.Label lblPopularRCourse;
        private System.Windows.Forms.Button btnMostPopRaceCourse;
        private System.Windows.Forms.Button btnEfficiency;
        private System.Windows.Forms.Label lblEfficiency;
    }
}

