﻿namespace SDKDownLoadFileDemo
{
    partial class frm_PlayBackByTimeSet
    {
        /// <summary>
        /// the designer variables in need.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// clean up all resource being in use
        /// </summary>
        /// <param name="disposing">If the resource should be released,it's ture.The otherwise,it's false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows the code generated by the form designer.

        /// <summary>
        /// designer support the ways in need-No
        /// Use the code editor to modify the content of the method.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PlayBackByTimeSet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChannelSelect = new System.Windows.Forms.ComboBox();
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChannelID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDevName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChannelSelect);
            this.groupBox1.Controls.Add(this.txtTimeEnd);
            this.groupBox1.Controls.Add(this.txtTimeStart);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtChannelID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDevName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbChannelSelect
            // 
            this.cmbChannelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChannelSelect.FormattingEnabled = true;
            this.cmbChannelSelect.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.cmbChannelSelect.Location = new System.Drawing.Point(153, 65);
            this.cmbChannelSelect.Name = "cmbChannelSelect";
            this.cmbChannelSelect.Size = new System.Drawing.Size(108, 20);
            this.cmbChannelSelect.TabIndex = 16;
            this.cmbChannelSelect.SelectedIndexChanged += new System.EventHandler(this.cmbChannelSelect_SelectedIndexChanged);
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.txtTimeEnd.Location = new System.Drawing.Point(263, 118);
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.Size = new System.Drawing.Size(56, 21);
            this.txtTimeEnd.TabIndex = 15;
            this.txtTimeEnd.Text = "12:01:01";
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.txtTimeStart.Location = new System.Drawing.Point(263, 92);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(56, 21);
            this.txtTimeStart.TabIndex = 14;
            this.txtTimeStart.Text = "12:01:01";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(153, 118);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(108, 21);
            this.dtpEnd.TabIndex = 13;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpStart.Location = new System.Drawing.Point(153, 91);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(108, 21);
            this.dtpStart.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(181, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 26);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(75, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 26);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ending_time:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChannelID
            // 
            this.txtChannelID.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.txtChannelID.Location = new System.Drawing.Point(265, 65);
            this.txtChannelID.Name = "txtChannelID";
            this.txtChannelID.Size = new System.Drawing.Size(54, 21);
            this.txtChannelID.TabIndex = 5;
            this.txtChannelID.Text = "0";
            this.txtChannelID.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Beginning_time:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(63, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Channel ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDevName
            // 
            this.txtDevName.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.txtDevName.Location = new System.Drawing.Point(153, 32);
            this.txtDevName.Name = "txtDevName";
            this.txtDevName.Size = new System.Drawing.Size(108, 21);
            this.txtDevName.TabIndex = 1;
            this.txtDevName.Text = "test";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of equipment:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_PlayBackByTimeSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(371, 237);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PlayBackByTimeSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "download according to the time playback";
            this.Load += new System.EventHandler(this.frm_PlayBackByTimeSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtChannelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDevName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTimeStart;
        public System.Windows.Forms.TextBox txtTimeEnd;
        public System.Windows.Forms.DateTimePicker dtpStart;
        public System.Windows.Forms.DateTimePicker dtpEnd;
        public System.Windows.Forms.ComboBox cmbChannelSelect;
    }
}