namespace UML_parser
{
    partial class Parser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parser));
            this.pnlClassDetails = new System.Windows.Forms.Panel();
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
            this.pnlRelationshipDetails = new System.Windows.Forms.Panel();
            this.lblLeftMultiplicity = new System.Windows.Forms.Label();
            this.lblRightMultiplicity = new System.Windows.Forms.Label();
            this.cbxRightMultiplicity = new System.Windows.Forms.ComboBox();
            this.cbxLeftMultiplicity = new System.Windows.Forms.ComboBox();
            this.lblRelationshipName = new System.Windows.Forms.Label();
            this.txtRelationshipName = new System.Windows.Forms.TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grbAddRelationship = new System.Windows.Forms.GroupBox();
            this.rdbGeneralization = new System.Windows.Forms.RadioButton();
            this.rdbComposition = new System.Windows.Forms.RadioButton();
            this.rdbAggregation = new System.Windows.Forms.RadioButton();
            this.rdbRealization = new System.Windows.Forms.RadioButton();
            this.rdbAssociation = new System.Windows.Forms.RadioButton();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.cbShowObjectDetails = new System.Windows.Forms.CheckBox();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbClass = new System.Windows.Forms.RadioButton();
            this.rdbSelectTool = new System.Windows.Forms.RadioButton();
            this.lblClassName = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlClassDetails.SuspendLayout();
            this.grbAddProperties.SuspendLayout();
            this.grbClassBehaviour.SuspendLayout();
            this.grbAddMethods.SuspendLayout();
            this.grbClassState.SuspendLayout();
            this.pnlRelationshipDetails.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.grbAddRelationship.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClassDetails
            // 
            this.pnlClassDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlClassDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClassDetails.Controls.Add(this.ClassName);
            this.pnlClassDetails.Controls.Add(this.grbAddProperties);
            this.pnlClassDetails.Controls.Add(this.grbClassBehaviour);
            this.pnlClassDetails.Controls.Add(this.grbAddMethods);
            this.pnlClassDetails.Controls.Add(this.grbClassState);
            this.pnlClassDetails.Location = new System.Drawing.Point(655, -1);
            this.pnlClassDetails.Name = "pnlClassDetails";
            this.pnlClassDetails.Size = new System.Drawing.Size(179, 645);
            this.pnlClassDetails.TabIndex = 0;
            this.pnlClassDetails.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Location = new System.Drawing.Point(55, 9);
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
            this.grbAddProperties.Location = new System.Drawing.Point(22, 320);
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
            this.grbClassBehaviour.Location = new System.Drawing.Point(22, 171);
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
            this.grbAddMethods.Location = new System.Drawing.Point(22, 503);
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
            this.grbClassState.Location = new System.Drawing.Point(22, 37);
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
            // pnlRelationshipDetails
            // 
            this.pnlRelationshipDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRelationshipDetails.Controls.Add(this.lblLeftMultiplicity);
            this.pnlRelationshipDetails.Controls.Add(this.lblRightMultiplicity);
            this.pnlRelationshipDetails.Controls.Add(this.cbxRightMultiplicity);
            this.pnlRelationshipDetails.Controls.Add(this.cbxLeftMultiplicity);
            this.pnlRelationshipDetails.Controls.Add(this.lblRelationshipName);
            this.pnlRelationshipDetails.Controls.Add(this.txtRelationshipName);
            this.pnlRelationshipDetails.Location = new System.Drawing.Point(655, -1);
            this.pnlRelationshipDetails.Name = "pnlRelationshipDetails";
            this.pnlRelationshipDetails.Size = new System.Drawing.Size(179, 647);
            this.pnlRelationshipDetails.TabIndex = 0;
            this.pnlRelationshipDetails.Visible = false;
            // 
            // lblLeftMultiplicity
            // 
            this.lblLeftMultiplicity.AutoSize = true;
            this.lblLeftMultiplicity.Location = new System.Drawing.Point(56, 109);
            this.lblLeftMultiplicity.Name = "lblLeftMultiplicity";
            this.lblLeftMultiplicity.Size = new System.Drawing.Size(75, 13);
            this.lblLeftMultiplicity.TabIndex = 5;
            this.lblLeftMultiplicity.Text = "Left multiplicity";
            // 
            // lblRightMultiplicity
            // 
            this.lblRightMultiplicity.AutoSize = true;
            this.lblRightMultiplicity.Location = new System.Drawing.Point(56, 216);
            this.lblRightMultiplicity.Name = "lblRightMultiplicity";
            this.lblRightMultiplicity.Size = new System.Drawing.Size(82, 13);
            this.lblRightMultiplicity.TabIndex = 4;
            this.lblRightMultiplicity.Text = "Right multiplicity";
            // 
            // cbxRightMultiplicity
            // 
            this.cbxRightMultiplicity.FormattingEnabled = true;
            this.cbxRightMultiplicity.Items.AddRange(new object[] {
            "1",
            "0..1",
            "1*",
            "*"});
            this.cbxRightMultiplicity.Location = new System.Drawing.Point(35, 255);
            this.cbxRightMultiplicity.Name = "cbxRightMultiplicity";
            this.cbxRightMultiplicity.Size = new System.Drawing.Size(121, 21);
            this.cbxRightMultiplicity.TabIndex = 3;
            // 
            // cbxLeftMultiplicity
            // 
            this.cbxLeftMultiplicity.FormattingEnabled = true;
            this.cbxLeftMultiplicity.Items.AddRange(new object[] {
            "1",
            "0..1",
            "1*",
            "*"});
            this.cbxLeftMultiplicity.Location = new System.Drawing.Point(35, 143);
            this.cbxLeftMultiplicity.Name = "cbxLeftMultiplicity";
            this.cbxLeftMultiplicity.Size = new System.Drawing.Size(121, 21);
            this.cbxLeftMultiplicity.TabIndex = 2;
            // 
            // lblRelationshipName
            // 
            this.lblRelationshipName.AutoSize = true;
            this.lblRelationshipName.Location = new System.Drawing.Point(47, 24);
            this.lblRelationshipName.Name = "lblRelationshipName";
            this.lblRelationshipName.Size = new System.Drawing.Size(97, 13);
            this.lblRelationshipName.TabIndex = 1;
            this.lblRelationshipName.Text = "Relationship name:";
            // 
            // txtRelationshipName
            // 
            this.txtRelationshipName.Location = new System.Drawing.Point(35, 49);
            this.txtRelationshipName.Name = "txtRelationshipName";
            this.txtRelationshipName.Size = new System.Drawing.Size(121, 20);
            this.txtRelationshipName.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.grbAddRelationship);
            this.pnlLeft.Controls.Add(this.cbShowObjectDetails);
            this.pnlLeft.Controls.Add(this.btnClearScreen);
            this.pnlLeft.Controls.Add(this.txtClassName);
            this.pnlLeft.Controls.Add(this.groupBox1);
            this.pnlLeft.Controls.Add(this.lblClassName);
            this.pnlLeft.Location = new System.Drawing.Point(-2, -1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(167, 647);
            this.pnlLeft.TabIndex = 1;
            // 
            // grbAddRelationship
            // 
            this.grbAddRelationship.Controls.Add(this.rdbGeneralization);
            this.grbAddRelationship.Controls.Add(this.rdbComposition);
            this.grbAddRelationship.Controls.Add(this.rdbAggregation);
            this.grbAddRelationship.Controls.Add(this.rdbRealization);
            this.grbAddRelationship.Controls.Add(this.rdbAssociation);
            this.grbAddRelationship.Controls.Add(this.rdbNone);
            this.grbAddRelationship.Location = new System.Drawing.Point(11, 171);
            this.grbAddRelationship.Name = "grbAddRelationship";
            this.grbAddRelationship.Size = new System.Drawing.Size(130, 159);
            this.grbAddRelationship.TabIndex = 0;
            this.grbAddRelationship.TabStop = false;
            this.grbAddRelationship.Text = "Choose a relation";
            // 
            // rdbGeneralization
            // 
            this.rdbGeneralization.AutoSize = true;
            this.rdbGeneralization.Location = new System.Drawing.Point(6, 111);
            this.rdbGeneralization.Name = "rdbGeneralization";
            this.rdbGeneralization.Size = new System.Drawing.Size(92, 17);
            this.rdbGeneralization.TabIndex = 1;
            this.rdbGeneralization.TabStop = true;
            this.rdbGeneralization.Text = "Generalization";
            this.rdbGeneralization.UseVisualStyleBackColor = true;
            // 
            // rdbComposition
            // 
            this.rdbComposition.AutoSize = true;
            this.rdbComposition.Location = new System.Drawing.Point(6, 88);
            this.rdbComposition.Name = "rdbComposition";
            this.rdbComposition.Size = new System.Drawing.Size(82, 17);
            this.rdbComposition.TabIndex = 2;
            this.rdbComposition.TabStop = true;
            this.rdbComposition.Text = "Composition";
            this.rdbComposition.UseVisualStyleBackColor = true;
            // 
            // rdbAggregation
            // 
            this.rdbAggregation.AutoSize = true;
            this.rdbAggregation.Location = new System.Drawing.Point(6, 65);
            this.rdbAggregation.Name = "rdbAggregation";
            this.rdbAggregation.Size = new System.Drawing.Size(82, 17);
            this.rdbAggregation.TabIndex = 4;
            this.rdbAggregation.TabStop = true;
            this.rdbAggregation.Text = "Aggregation";
            this.rdbAggregation.UseVisualStyleBackColor = true;
            // 
            // rdbRealization
            // 
            this.rdbRealization.AutoSize = true;
            this.rdbRealization.Location = new System.Drawing.Point(6, 134);
            this.rdbRealization.Name = "rdbRealization";
            this.rdbRealization.Size = new System.Drawing.Size(77, 17);
            this.rdbRealization.TabIndex = 5;
            this.rdbRealization.TabStop = true;
            this.rdbRealization.Text = "Realization";
            this.rdbRealization.UseVisualStyleBackColor = true;
            // 
            // rdbAssociation
            // 
            this.rdbAssociation.AutoSize = true;
            this.rdbAssociation.Location = new System.Drawing.Point(6, 42);
            this.rdbAssociation.Name = "rdbAssociation";
            this.rdbAssociation.Size = new System.Drawing.Size(79, 17);
            this.rdbAssociation.TabIndex = 3;
            this.rdbAssociation.TabStop = true;
            this.rdbAssociation.Text = "Association";
            this.rdbAssociation.UseVisualStyleBackColor = true;
            // 
            // rdbNone
            // 
            this.rdbNone.AutoSize = true;
            this.rdbNone.Location = new System.Drawing.Point(6, 19);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(51, 17);
            this.rdbNone.TabIndex = 0;
            this.rdbNone.TabStop = true;
            this.rdbNone.Text = "None";
            this.rdbNone.UseVisualStyleBackColor = true;
            // 
            // cbShowObjectDetails
            // 
            this.cbShowObjectDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.cbShowObjectDetails.AutoSize = true;
            this.cbShowObjectDetails.Location = new System.Drawing.Point(3, 535);
            this.cbShowObjectDetails.Name = "cbShowObjectDetails";
            this.cbShowObjectDetails.Size = new System.Drawing.Size(161, 17);
            this.cbShowObjectDetails.TabIndex = 2;
            this.cbShowObjectDetails.Text = "Show selected object details";
            this.cbShowObjectDetails.UseVisualStyleBackColor = true;
            this.cbShowObjectDetails.CheckedChanged += new System.EventHandler(this.CbShowObjectDetails_CheckedChanged);
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
            this.pnlCenter.Location = new System.Drawing.Point(169, -1);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(480, 647);
            this.pnlCenter.TabIndex = 2;
            this.pnlCenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlCenter_MouseClick);
            // 
            // Parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 646);
            this.Controls.Add(this.pnlRelationshipDetails);
            this.Controls.Add(this.pnlClassDetails);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Parser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UML parser";
            this.pnlClassDetails.ResumeLayout(false);
            this.pnlClassDetails.PerformLayout();
            this.grbAddProperties.ResumeLayout(false);
            this.grbAddProperties.PerformLayout();
            this.grbClassBehaviour.ResumeLayout(false);
            this.grbAddMethods.ResumeLayout(false);
            this.grbAddMethods.PerformLayout();
            this.grbClassState.ResumeLayout(false);
            this.pnlRelationshipDetails.ResumeLayout(false);
            this.pnlRelationshipDetails.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.grbAddRelationship.ResumeLayout(false);
            this.grbAddRelationship.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ListView listClassBehaviour;
        private System.Windows.Forms.ListView listClassState;
        private System.Windows.Forms.GroupBox grbAddRelationship;
        private System.Windows.Forms.Label lblLeftMultiplicity;
        private System.Windows.Forms.Label lblRightMultiplicity;
        private System.Windows.Forms.Label lblRelationshipName;
        public System.Windows.Forms.Panel pnlRelationshipDetails;
        public System.Windows.Forms.Panel pnlClassDetails;
        public System.Windows.Forms.CheckBox cbShowObjectDetails;
        public System.Windows.Forms.Button btnClearScreen;
        public System.Windows.Forms.TextBox txtClassName;
        public System.Windows.Forms.RadioButton rdbClass;
        public System.Windows.Forms.RadioButton rdbSelectTool;
        public System.Windows.Forms.Panel pnlCenter;
        public System.Windows.Forms.RadioButton rdbGeneralization;
        public System.Windows.Forms.RadioButton rdbComposition;
        public System.Windows.Forms.RadioButton rdbAggregation;
        public System.Windows.Forms.RadioButton rdbRealization;
        public System.Windows.Forms.RadioButton rdbAssociation;
        public System.Windows.Forms.RadioButton rdbNone;
        public System.Windows.Forms.ComboBox cbxRightMultiplicity;
        public System.Windows.Forms.ComboBox cbxLeftMultiplicity;
        public System.Windows.Forms.TextBox txtRelationshipName;
        public System.Windows.Forms.Label ClassName;
    }
}

