namespace UML_parser
{
    partial class UML_parser
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.ClassName = new System.Windows.Forms.Label();
            this.grbAddProperties = new System.Windows.Forms.GroupBox();
            this.cbxPropertieAccessor = new System.Windows.Forms.ComboBox();
            this.lblPropertieAccessor = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.txtDataType = new System.Windows.Forms.TextBox();
            this.txtPropertieName = new System.Windows.Forms.TextBox();
            this.grbClassBehaviour = new System.Windows.Forms.GroupBox();
            this.listClassBehaviour = new System.Windows.Forms.ListView();
            this.grbAddMethods = new System.Windows.Forms.GroupBox();
            this.lblMethodAccessor = new System.Windows.Forms.Label();
            this.cbxMethodAccessor = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.btnAddMethod = new System.Windows.Forms.Button();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.grbClassState = new System.Windows.Forms.GroupBox();
            this.listClassState = new System.Windows.Forms.ListView();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.cbxShowClassDetails = new System.Windows.Forms.CheckBox();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbClass = new System.Windows.Forms.RadioButton();
            this.rdbSelectTool = new System.Windows.Forms.RadioButton();
            this.lblClassName = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlRight.SuspendLayout();
            this.grbAddProperties.SuspendLayout();
            this.grbClassBehaviour.SuspendLayout();
            this.grbAddMethods.SuspendLayout();
            this.grbClassState.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.ClassName);
            this.pnlRight.Controls.Add(this.grbAddProperties);
            this.pnlRight.Controls.Add(this.grbClassBehaviour);
            this.pnlRight.Controls.Add(this.grbAddMethods);
            this.pnlRight.Controls.Add(this.grbClassState);
            this.pnlRight.Location = new System.Drawing.Point(595, -1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(190, 614);
            this.pnlRight.TabIndex = 0;
            this.pnlRight.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Location = new System.Drawing.Point(19, 12);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(72, 13);
            this.ClassName.TabIndex = 2;
            this.ClassName.Text = "<ClassName>";
            // 
            // grbAddProperties
            // 
            this.grbAddProperties.Controls.Add(this.cbxPropertieAccessor);
            this.grbAddProperties.Controls.Add(this.lblPropertieAccessor);
            this.grbAddProperties.Controls.Add(this.lblDataType);
            this.grbAddProperties.Controls.Add(this.lblName);
            this.grbAddProperties.Controls.Add(this.btnAddProperty);
            this.grbAddProperties.Controls.Add(this.txtDataType);
            this.grbAddProperties.Controls.Add(this.txtPropertieName);
            this.grbAddProperties.Location = new System.Drawing.Point(15, 302);
            this.grbAddProperties.Name = "grbAddProperties";
            this.grbAddProperties.Size = new System.Drawing.Size(141, 159);
            this.grbAddProperties.TabIndex = 1;
            this.grbAddProperties.TabStop = false;
            this.grbAddProperties.Text = "Add properties";
            // 
            // cbxPropertieAccessor
            // 
            this.cbxPropertieAccessor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxPropertieAccessor.FormattingEnabled = true;
            this.cbxPropertieAccessor.Items.AddRange(new object[] {
            "public ",
            "protected",
            "private"});
            this.cbxPropertieAccessor.Location = new System.Drawing.Point(74, 88);
            this.cbxPropertieAccessor.Name = "cbxPropertieAccessor";
            this.cbxPropertieAccessor.Size = new System.Drawing.Size(61, 21);
            this.cbxPropertieAccessor.TabIndex = 2;
            // 
            // lblPropertieAccessor
            // 
            this.lblPropertieAccessor.AutoSize = true;
            this.lblPropertieAccessor.Location = new System.Drawing.Point(4, 91);
            this.lblPropertieAccessor.Name = "lblPropertieAccessor";
            this.lblPropertieAccessor.Size = new System.Drawing.Size(54, 13);
            this.lblPropertieAccessor.TabIndex = 7;
            this.lblPropertieAccessor.Text = "Accessor:";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(4, 58);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(56, 13);
            this.lblDataType.TabIndex = 6;
            this.lblDataType.Text = "Data type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddProperty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProperty.Location = new System.Drawing.Point(60, 130);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(75, 23);
            this.btnAddProperty.TabIndex = 3;
            this.btnAddProperty.Text = "Add property";
            this.btnAddProperty.UseVisualStyleBackColor = false;
            this.btnAddProperty.Click += new System.EventHandler(this.BtnAddProperty_Click);
            // 
            // txtDataType
            // 
            this.txtDataType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDataType.Location = new System.Drawing.Point(74, 55);
            this.txtDataType.Name = "txtDataType";
            this.txtDataType.Size = new System.Drawing.Size(61, 20);
            this.txtDataType.TabIndex = 7;
            // 
            // txtPropertieName
            // 
            this.txtPropertieName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPropertieName.Location = new System.Drawing.Point(74, 29);
            this.txtPropertieName.Name = "txtPropertieName";
            this.txtPropertieName.Size = new System.Drawing.Size(61, 20);
            this.txtPropertieName.TabIndex = 8;
            // 
            // grbClassBehaviour
            // 
            this.grbClassBehaviour.Controls.Add(this.listClassBehaviour);
            this.grbClassBehaviour.Location = new System.Drawing.Point(15, 171);
            this.grbClassBehaviour.Name = "grbClassBehaviour";
            this.grbClassBehaviour.Size = new System.Drawing.Size(141, 125);
            this.grbClassBehaviour.TabIndex = 1;
            this.grbClassBehaviour.TabStop = false;
            this.grbClassBehaviour.Text = "Class behaviour";
            // 
            // listClassBehaviour
            // 
            this.listClassBehaviour.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listClassBehaviour.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listClassBehaviour.Location = new System.Drawing.Point(7, 35);
            this.listClassBehaviour.Name = "listClassBehaviour";
            this.listClassBehaviour.Size = new System.Drawing.Size(128, 69);
            this.listClassBehaviour.TabIndex = 1;
            this.listClassBehaviour.UseCompatibleStateImageBehavior = false;
            this.listClassBehaviour.View = System.Windows.Forms.View.SmallIcon;
            // 
            // grbAddMethods
            // 
            this.grbAddMethods.Controls.Add(this.lblMethodAccessor);
            this.grbAddMethods.Controls.Add(this.cbxMethodAccessor);
            this.grbAddMethods.Controls.Add(this.lblMethod);
            this.grbAddMethods.Controls.Add(this.btnAddMethod);
            this.grbAddMethods.Controls.Add(this.txtMethod);
            this.grbAddMethods.Location = new System.Drawing.Point(15, 467);
            this.grbAddMethods.Name = "grbAddMethods";
            this.grbAddMethods.Size = new System.Drawing.Size(141, 131);
            this.grbAddMethods.TabIndex = 1;
            this.grbAddMethods.TabStop = false;
            this.grbAddMethods.Text = "Add methods";
            // 
            // lblMethodAccessor
            // 
            this.lblMethodAccessor.AutoSize = true;
            this.lblMethodAccessor.Location = new System.Drawing.Point(4, 69);
            this.lblMethodAccessor.Name = "lblMethodAccessor";
            this.lblMethodAccessor.Size = new System.Drawing.Size(54, 13);
            this.lblMethodAccessor.TabIndex = 8;
            this.lblMethodAccessor.Text = "Accessor:";
            // 
            // cbxMethodAccessor
            // 
            this.cbxMethodAccessor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxMethodAccessor.FormattingEnabled = true;
            this.cbxMethodAccessor.Items.AddRange(new object[] {
            "public ",
            "protected",
            "private"});
            this.cbxMethodAccessor.Location = new System.Drawing.Point(74, 66);
            this.cbxMethodAccessor.Name = "cbxMethodAccessor";
            this.cbxMethodAccessor.Size = new System.Drawing.Size(61, 21);
            this.cbxMethodAccessor.TabIndex = 7;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(4, 36);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(46, 13);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "Method:";
            // 
            // btnAddMethod
            // 
            this.btnAddMethod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMethod.Location = new System.Drawing.Point(60, 102);
            this.btnAddMethod.Name = "btnAddMethod";
            this.btnAddMethod.Size = new System.Drawing.Size(75, 23);
            this.btnAddMethod.TabIndex = 4;
            this.btnAddMethod.Text = "Add method";
            this.btnAddMethod.UseVisualStyleBackColor = false;
            this.btnAddMethod.Click += new System.EventHandler(this.BtnAddMethod_Click);
            // 
            // txtMethod
            // 
            this.txtMethod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMethod.Location = new System.Drawing.Point(74, 33);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(61, 20);
            this.txtMethod.TabIndex = 6;
            // 
            // grbClassState
            // 
            this.grbClassState.Controls.Add(this.listClassState);
            this.grbClassState.Location = new System.Drawing.Point(15, 37);
            this.grbClassState.Name = "grbClassState";
            this.grbClassState.Size = new System.Drawing.Size(141, 115);
            this.grbClassState.TabIndex = 0;
            this.grbClassState.TabStop = false;
            this.grbClassState.Text = "Class state";
            // 
            // listClassState
            // 
            this.listClassState.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listClassState.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listClassState.Location = new System.Drawing.Point(7, 26);
            this.listClassState.Name = "listClassState";
            this.listClassState.Size = new System.Drawing.Size(128, 69);
            this.listClassState.TabIndex = 0;
            this.listClassState.UseCompatibleStateImageBehavior = false;
            this.listClassState.View = System.Windows.Forms.View.SmallIcon;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.cbxShowClassDetails);
            this.pnlLeft.Controls.Add(this.btnClearScreen);
            this.pnlLeft.Controls.Add(this.txtClassName);
            this.pnlLeft.Controls.Add(this.groupBox1);
            this.pnlLeft.Controls.Add(this.lblClassName);
            this.pnlLeft.Location = new System.Drawing.Point(-2, -1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(167, 614);
            this.pnlLeft.TabIndex = 1;
            // 
            // cbxShowClassDetails
            // 
            this.cbxShowClassDetails.AutoSize = true;
            this.cbxShowClassDetails.Location = new System.Drawing.Point(11, 532);
            this.cbxShowClassDetails.Name = "cbxShowClassDetails";
            this.cbxShowClassDetails.Size = new System.Drawing.Size(113, 17);
            this.cbxShowClassDetails.TabIndex = 2;
            this.cbxShowClassDetails.Text = "Show class details";
            this.cbxShowClassDetails.UseVisualStyleBackColor = true;
            this.cbxShowClassDetails.CheckedChanged += new System.EventHandler(this.CbxShowClassDetails_CheckedChanged);
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClearScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearScreen.Location = new System.Drawing.Point(17, 569);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(75, 23);
            this.btnClearScreen.TabIndex = 2;
            this.btnClearScreen.Text = "Clear screen";
            this.btnClearScreen.UseVisualStyleBackColor = false;
            this.btnClearScreen.Click += new System.EventHandler(this.BtnClearScreen_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtClassName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtClassName.Location = new System.Drawing.Point(17, 132);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 20);
            this.txtClassName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.Controls.Add(this.rdbClass);
            this.groupBox1.Controls.Add(this.rdbSelectTool);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select object";
            // 
            // rdbClass
            // 
            this.rdbClass.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdbClass.AutoSize = true;
            this.rdbClass.Location = new System.Drawing.Point(6, 51);
            this.rdbClass.Name = "rdbClass";
            this.rdbClass.Size = new System.Drawing.Size(50, 17);
            this.rdbClass.TabIndex = 6;
            this.rdbClass.Text = "Class";
            this.rdbClass.UseVisualStyleBackColor = true;
            // 
            // rdbSelectTool
            // 
            this.rdbSelectTool.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdbSelectTool.AutoSize = true;
            this.rdbSelectTool.Location = new System.Drawing.Point(6, 28);
            this.rdbSelectTool.Name = "rdbSelectTool";
            this.rdbSelectTool.Size = new System.Drawing.Size(75, 17);
            this.rdbSelectTool.TabIndex = 3;
            this.rdbSelectTool.Text = "Select tool";
            this.rdbSelectTool.UseVisualStyleBackColor = true;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(14, 114);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(64, 13);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Class name:";
            // 
            // pnlCenter
            // 
            this.pnlCenter.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.pnlCenter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlCenter.Location = new System.Drawing.Point(164, -1);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(433, 614);
            this.pnlCenter.TabIndex = 2;
            this.pnlCenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlCenter_MouseClick);
            // 
            // UML_parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 610);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UML_parser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UML parser";
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.grbAddProperties.ResumeLayout(false);
            this.grbAddProperties.PerformLayout();
            this.grbClassBehaviour.ResumeLayout(false);
            this.grbAddMethods.ResumeLayout(false);
            this.grbAddMethods.PerformLayout();
            this.grbClassState.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.CheckBox cbxShowClassDetails;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbClass;
        private System.Windows.Forms.RadioButton rdbSelectTool;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.GroupBox grbClassState;
        private System.Windows.Forms.GroupBox grbAddProperties;
        private System.Windows.Forms.TextBox txtDataType;
        private System.Windows.Forms.TextBox txtPropertieName;
        private System.Windows.Forms.GroupBox grbClassBehaviour;
        private System.Windows.Forms.GroupBox grbAddMethods;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblMethodAccessor;
        private System.Windows.Forms.Label lblPropertieAccessor;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Button btnAddMethod;
        private System.Windows.Forms.ComboBox cbxPropertieAccessor;
        private System.Windows.Forms.ComboBox cbxMethodAccessor;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.ListView listClassBehaviour;
        private System.Windows.Forms.ListView listClassState;
        private System.Windows.Forms.Panel pnlCenter;
    }
}

