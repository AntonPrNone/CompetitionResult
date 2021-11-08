namespace CompetitionResult
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_IncomingCall = new System.Windows.Forms.Label();
            this.TimeRace = new System.Windows.Forms.MaskedTextBox();
            this.DateRace = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.Text_OutgoingCall = new System.Windows.Forms.Label();
            this.SaveReportButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Label();
            this.raceTime = new System.Windows.Forms.MaskedTextBox();
            this.maxTime = new System.Windows.Forms.MaskedTextBox();
            this.selectedName = new System.Windows.Forms.MaskedTextBox();
            this.PutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveAndCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(338, 427);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(108, 27);
            this.SaveAndCloseButton.TabIndex = 53;
            this.SaveAndCloseButton.Text = "Save and Close";
            this.SaveAndCloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAndCloseButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(510, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Maximum allowed time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Selected Name:";
            // 
            // Text_IncomingCall
            // 
            this.Text_IncomingCall.AutoSize = true;
            this.Text_IncomingCall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Text_IncomingCall.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_IncomingCall.ForeColor = System.Drawing.SystemColors.Control;
            this.Text_IncomingCall.Location = new System.Drawing.Point(684, 130);
            this.Text_IncomingCall.Name = "Text_IncomingCall";
            this.Text_IncomingCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_IncomingCall.Size = new System.Drawing.Size(85, 18);
            this.Text_IncomingCall.TabIndex = 45;
            this.Text_IncomingCall.Text = "Race Time";
            // 
            // TimeRace
            // 
            this.TimeRace.Location = new System.Drawing.Point(469, 125);
            this.TimeRace.Mask = "00:00:00";
            this.TimeRace.Name = "TimeRace";
            this.TimeRace.Size = new System.Drawing.Size(48, 20);
            this.TimeRace.TabIndex = 44;
            this.TimeRace.ValidatingType = typeof(System.DateTime);
            // 
            // DateRace
            // 
            this.DateRace.Location = new System.Drawing.Point(288, 125);
            this.DateRace.Name = "DateRace";
            this.DateRace.Size = new System.Drawing.Size(140, 20);
            this.DateRace.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(337, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Date/time race";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(22, 168);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 20);
            this.name.TabIndex = 41;
            // 
            // Text_OutgoingCall
            // 
            this.Text_OutgoingCall.AutoSize = true;
            this.Text_OutgoingCall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Text_OutgoingCall.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_OutgoingCall.ForeColor = System.Drawing.SystemColors.Control;
            this.Text_OutgoingCall.Location = new System.Drawing.Point(19, 127);
            this.Text_OutgoingCall.Name = "Text_OutgoingCall";
            this.Text_OutgoingCall.Size = new System.Drawing.Size(119, 18);
            this.Text_OutgoingCall.TabIndex = 40;
            this.Text_OutgoingCall.Text = "Athlete\'s name";
            // 
            // SaveReportButton
            // 
            this.SaveReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SaveReportButton.Location = new System.Drawing.Point(687, 37);
            this.SaveReportButton.Name = "SaveReportButton";
            this.SaveReportButton.Size = new System.Drawing.Size(91, 26);
            this.SaveReportButton.TabIndex = 39;
            this.SaveReportButton.Text = "Save Report";
            this.SaveReportButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.Location = new System.Drawing.Point(22, 37);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 26);
            this.OpenFileButton.TabIndex = 38;
            this.OpenFileButton.Text = "Open file";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // Heading
            // 
            this.Heading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heading.Dock = System.Windows.Forms.DockStyle.Top;
            this.Heading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.ForeColor = System.Drawing.Color.Green;
            this.Heading.Location = new System.Drawing.Point(0, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(800, 35);
            this.Heading.TabIndex = 37;
            this.Heading.Text = "Competition Result";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // raceTime
            // 
            this.raceTime.Location = new System.Drawing.Point(710, 168);
            this.raceTime.Mask = "00000";
            this.raceTime.Name = "raceTime";
            this.raceTime.Size = new System.Drawing.Size(38, 20);
            this.raceTime.TabIndex = 54;
            this.raceTime.ValidatingType = typeof(int);
            // 
            // maxTime
            // 
            this.maxTime.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maxTime.Location = new System.Drawing.Point(740, 376);
            this.maxTime.Mask = "00000";
            this.maxTime.Name = "maxTime";
            this.maxTime.Size = new System.Drawing.Size(38, 20);
            this.maxTime.TabIndex = 56;
            this.maxTime.ValidatingType = typeof(int);
            // 
            // selectedName
            // 
            this.selectedName.Location = new System.Drawing.Point(176, 379);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(188, 20);
            this.selectedName.TabIndex = 57;
            // 
            // PutButton
            // 
            this.PutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PutButton.Location = new System.Drawing.Point(356, 217);
            this.PutButton.Name = "PutButton";
            this.PutButton.Size = new System.Drawing.Size(75, 23);
            this.PutButton.TabIndex = 58;
            this.PutButton.Text = "Put";
            this.PutButton.UseVisualStyleBackColor = true;
            this.PutButton.Click += new System.EventHandler(this.PutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.PutButton);
            this.Controls.Add(this.selectedName);
            this.Controls.Add(this.maxTime);
            this.Controls.Add(this.raceTime);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_IncomingCall);
            this.Controls.Add(this.TimeRace);
            this.Controls.Add(this.DateRace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Text_OutgoingCall);
            this.Controls.Add(this.SaveReportButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.Heading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Text_IncomingCall;
        private System.Windows.Forms.MaskedTextBox TimeRace;
        private System.Windows.Forms.DateTimePicker DateRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.Label Text_OutgoingCall;
        private System.Windows.Forms.Button SaveReportButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.MaskedTextBox raceTime;
        private System.Windows.Forms.MaskedTextBox maxTime;
        private System.Windows.Forms.MaskedTextBox selectedName;
        private System.Windows.Forms.Button PutButton;
    }
}

