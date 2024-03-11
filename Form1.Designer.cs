namespace Assignment_10_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.rtxtData = new System.Windows.Forms.RichTextBox();
            this.grpSerialize = new System.Windows.Forms.GroupBox();
            this.btnJSONSerialize = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.btnBinSerialize = new System.Windows.Forms.Button();
            this.grpDeSerialize = new System.Windows.Forms.GroupBox();
            this.btnJSONDeSerialize = new System.Windows.Forms.Button();
            this.btnXMLDeSerialize = new System.Windows.Forms.Button();
            this.btnBinDeSerialize = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.grpSerialize.SuspendLayout();
            this.grpDeSerialize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(82, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(445, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtStudentID.Location = new System.Drawing.Point(82, 266);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(103, 20);
            this.txtStudentID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Location = new System.Drawing.Point(82, 292);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAddress.Location = new System.Drawing.Point(82, 318);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(215, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtMarks
            // 
            this.txtMarks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMarks.Location = new System.Drawing.Point(82, 344);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(103, 20);
            this.txtMarks.TabIndex = 5;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGrade.Location = new System.Drawing.Point(82, 370);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(103, 20);
            this.txtGrade.TabIndex = 6;
            // 
            // rtxtData
            // 
            this.rtxtData.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtxtData.Location = new System.Drawing.Point(252, 44);
            this.rtxtData.Name = "rtxtData";
            this.rtxtData.Size = new System.Drawing.Size(268, 178);
            this.rtxtData.TabIndex = 7;
            this.rtxtData.Text = "";
            // 
            // grpSerialize
            // 
            this.grpSerialize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpSerialize.Controls.Add(this.btnJSONSerialize);
            this.grpSerialize.Controls.Add(this.btnXMLSerialize);
            this.grpSerialize.Controls.Add(this.btnBinSerialize);
            this.grpSerialize.Location = new System.Drawing.Point(318, 294);
            this.grpSerialize.Name = "grpSerialize";
            this.grpSerialize.Size = new System.Drawing.Size(87, 109);
            this.grpSerialize.TabIndex = 8;
            this.grpSerialize.TabStop = false;
            this.grpSerialize.Text = "Serialize";
            // 
            // btnJSONSerialize
            // 
            this.btnJSONSerialize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnJSONSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJSONSerialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJSONSerialize.Location = new System.Drawing.Point(6, 77);
            this.btnJSONSerialize.Name = "btnJSONSerialize";
            this.btnJSONSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnJSONSerialize.TabIndex = 12;
            this.btnJSONSerialize.Text = "JSON";
            this.btnJSONSerialize.UseVisualStyleBackColor = false;
            this.btnJSONSerialize.Click += new System.EventHandler(this.btnJSONSerialize_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXMLSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXMLSerialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXMLSerialize.Location = new System.Drawing.Point(6, 48);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnXMLSerialize.TabIndex = 11;
            this.btnXMLSerialize.Text = "XML";
            this.btnXMLSerialize.UseVisualStyleBackColor = false;
            this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
            // 
            // btnBinSerialize
            // 
            this.btnBinSerialize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBinSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBinSerialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBinSerialize.Location = new System.Drawing.Point(6, 19);
            this.btnBinSerialize.Name = "btnBinSerialize";
            this.btnBinSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnBinSerialize.TabIndex = 10;
            this.btnBinSerialize.Text = "Binary";
            this.btnBinSerialize.UseVisualStyleBackColor = false;
            this.btnBinSerialize.Click += new System.EventHandler(this.btnBinSerialize_Click);
            // 
            // grpDeSerialize
            // 
            this.grpDeSerialize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpDeSerialize.Controls.Add(this.btnJSONDeSerialize);
            this.grpDeSerialize.Controls.Add(this.btnXMLDeSerialize);
            this.grpDeSerialize.Controls.Add(this.btnBinDeSerialize);
            this.grpDeSerialize.Location = new System.Drawing.Point(432, 294);
            this.grpDeSerialize.Name = "grpDeSerialize";
            this.grpDeSerialize.Size = new System.Drawing.Size(87, 109);
            this.grpDeSerialize.TabIndex = 13;
            this.grpDeSerialize.TabStop = false;
            this.grpDeSerialize.Text = "Deserialize";
            // 
            // btnJSONDeSerialize
            // 
            this.btnJSONDeSerialize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnJSONDeSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJSONDeSerialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJSONDeSerialize.Location = new System.Drawing.Point(6, 77);
            this.btnJSONDeSerialize.Name = "btnJSONDeSerialize";
            this.btnJSONDeSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnJSONDeSerialize.TabIndex = 12;
            this.btnJSONDeSerialize.Text = "JSON";
            this.btnJSONDeSerialize.UseVisualStyleBackColor = false;
            this.btnJSONDeSerialize.Click += new System.EventHandler(this.btnJSONDeSerialize_Click);
            // 
            // btnXMLDeSerialize
            // 
            this.btnXMLDeSerialize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXMLDeSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXMLDeSerialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXMLDeSerialize.Location = new System.Drawing.Point(6, 48);
            this.btnXMLDeSerialize.Name = "btnXMLDeSerialize";
            this.btnXMLDeSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnXMLDeSerialize.TabIndex = 11;
            this.btnXMLDeSerialize.Text = "XML";
            this.btnXMLDeSerialize.UseVisualStyleBackColor = false;
            this.btnXMLDeSerialize.Click += new System.EventHandler(this.btnXMLDeSerialize_Click);
            // 
            // btnBinDeSerialize
            // 
            this.btnBinDeSerialize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBinDeSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBinDeSerialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBinDeSerialize.Location = new System.Drawing.Point(6, 19);
            this.btnBinDeSerialize.Name = "btnBinDeSerialize";
            this.btnBinDeSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnBinDeSerialize.TabIndex = 10;
            this.btnBinDeSerialize.Text = "Binary";
            this.btnBinDeSerialize.UseVisualStyleBackColor = false;
            this.btnBinDeSerialize.Click += new System.EventHandler(this.btnBinDeSerialize_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 269);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 295);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(31, 321);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(40, 347);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(36, 13);
            this.lblMarks.TabIndex = 17;
            this.lblMarks.Text = "Marks";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(40, 373);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 18;
            this.lblGrade.Text = "Grade";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpen.Location = new System.Drawing.Point(364, 228);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "Open Folder";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 461);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.grpDeSerialize);
            this.Controls.Add(this.grpSerialize);
            this.Controls.Add(this.rtxtData);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Education Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSerialize.ResumeLayout(false);
            this.grpDeSerialize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.RichTextBox rtxtData;
        private System.Windows.Forms.GroupBox grpSerialize;
        private System.Windows.Forms.Button btnJSONSerialize;
        private System.Windows.Forms.Button btnXMLSerialize;
        private System.Windows.Forms.Button btnBinSerialize;
        private System.Windows.Forms.GroupBox grpDeSerialize;
        private System.Windows.Forms.Button btnJSONDeSerialize;
        private System.Windows.Forms.Button btnXMLDeSerialize;
        private System.Windows.Forms.Button btnBinDeSerialize;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnOpen;
    }
}

