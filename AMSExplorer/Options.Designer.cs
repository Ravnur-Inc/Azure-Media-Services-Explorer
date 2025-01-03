﻿namespace AMSExplorer
{
    partial class Options
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxDisplayAssetID = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDisplayAssetAltId = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayAssetStorage = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.comboBoxAutoRefreshTime = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxDisableTelemetry = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSASDuration = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHideTaskbarNotifications = new System.Windows.Forms.CheckBox();
            this.checkBoxUseAdaptiveStreamingFormat = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownAssetAnalysisStep = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownAssetAnalysisStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownLocatorDuration = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelcdn = new System.Windows.Forms.Label();
            this.textBoxCustomPlayer = new System.Windows.Forms.TextBox();
            this.checkBoxEnableCustomPlayer = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownDataMovNumbParallelOp = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelBlobSizeMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxBlockSize = new System.Windows.Forms.ComboBox();
            this.checkBoxDoNotIncreaseHTTPLimit = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableMD5Check = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoParOpe = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVLCPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxffmpegPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSASDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssetAnalysisStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssetAnalysisStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLocatorDuration)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataMovNumbParallelOp)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Name = "buttonOk";
            this.toolTip1.SetToolTip(this.buttonOk, resources.GetString("buttonOk.ToolTip"));
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.toolTip1.SetToolTip(this.buttonCancel, resources.GetString("buttonCancel.ToolTip"));
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.toolTip1.SetToolTip(this.buttonReset, resources.GetString("buttonReset.ToolTip"));
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // checkBoxDisplayAssetID
            // 
            resources.ApplyResources(this.checkBoxDisplayAssetID, "checkBoxDisplayAssetID");
            this.checkBoxDisplayAssetID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxDisplayAssetID.Name = "checkBoxDisplayAssetID";
            this.toolTip1.SetToolTip(this.checkBoxDisplayAssetID, resources.GetString("checkBoxDisplayAssetID.ToolTip"));
            this.checkBoxDisplayAssetID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.checkBoxDisplayAssetAltId);
            this.groupBox1.Controls.Add(this.checkBoxDisplayAssetStorage);
            this.groupBox1.Controls.Add(this.checkBoxAutoRefresh);
            this.groupBox1.Controls.Add(this.comboBoxAutoRefreshTime);
            this.groupBox1.Controls.Add(this.checkBoxDisplayAssetID);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // checkBoxDisplayAssetAltId
            // 
            resources.ApplyResources(this.checkBoxDisplayAssetAltId, "checkBoxDisplayAssetAltId");
            this.checkBoxDisplayAssetAltId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxDisplayAssetAltId.Name = "checkBoxDisplayAssetAltId";
            this.toolTip1.SetToolTip(this.checkBoxDisplayAssetAltId, resources.GetString("checkBoxDisplayAssetAltId.ToolTip"));
            this.checkBoxDisplayAssetAltId.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisplayAssetStorage
            // 
            resources.ApplyResources(this.checkBoxDisplayAssetStorage, "checkBoxDisplayAssetStorage");
            this.checkBoxDisplayAssetStorage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxDisplayAssetStorage.Name = "checkBoxDisplayAssetStorage";
            this.toolTip1.SetToolTip(this.checkBoxDisplayAssetStorage, resources.GetString("checkBoxDisplayAssetStorage.ToolTip"));
            this.checkBoxDisplayAssetStorage.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoRefresh
            // 
            resources.ApplyResources(this.checkBoxAutoRefresh, "checkBoxAutoRefresh");
            this.checkBoxAutoRefresh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.toolTip1.SetToolTip(this.checkBoxAutoRefresh, resources.GetString("checkBoxAutoRefresh.ToolTip"));
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // comboBoxAutoRefreshTime
            // 
            resources.ApplyResources(this.comboBoxAutoRefreshTime, "comboBoxAutoRefreshTime");
            this.comboBoxAutoRefreshTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutoRefreshTime.FormattingEnabled = true;
            this.comboBoxAutoRefreshTime.Items.AddRange(new object[] {
            resources.GetString("comboBoxAutoRefreshTime.Items"),
            resources.GetString("comboBoxAutoRefreshTime.Items1"),
            resources.GetString("comboBoxAutoRefreshTime.Items2"),
            resources.GetString("comboBoxAutoRefreshTime.Items3")});
            this.comboBoxAutoRefreshTime.Name = "comboBoxAutoRefreshTime";
            this.toolTip1.SetToolTip(this.comboBoxAutoRefreshTime, resources.GetString("comboBoxAutoRefreshTime.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.checkBoxDisableTelemetry);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownSASDuration);
            this.groupBox2.Controls.Add(this.checkBoxHideTaskbarNotifications);
            this.groupBox2.Controls.Add(this.checkBoxUseAdaptiveStreamingFormat);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.numericUpDownAssetAnalysisStep);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDownAssetAnalysisStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDownLocatorDuration);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // checkBoxDisableTelemetry
            // 
            resources.ApplyResources(this.checkBoxDisableTelemetry, "checkBoxDisableTelemetry");
            this.checkBoxDisableTelemetry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxDisableTelemetry.Name = "checkBoxDisableTelemetry";
            this.toolTip1.SetToolTip(this.checkBoxDisableTelemetry, resources.GetString("checkBoxDisableTelemetry.ToolTip"));
            this.checkBoxDisableTelemetry.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // numericUpDownSASDuration
            // 
            resources.ApplyResources(this.numericUpDownSASDuration, "numericUpDownSASDuration");
            this.numericUpDownSASDuration.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownSASDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSASDuration.Name = "numericUpDownSASDuration";
            this.toolTip1.SetToolTip(this.numericUpDownSASDuration, resources.GetString("numericUpDownSASDuration.ToolTip"));
            this.numericUpDownSASDuration.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // checkBoxHideTaskbarNotifications
            // 
            resources.ApplyResources(this.checkBoxHideTaskbarNotifications, "checkBoxHideTaskbarNotifications");
            this.checkBoxHideTaskbarNotifications.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxHideTaskbarNotifications.Name = "checkBoxHideTaskbarNotifications";
            this.toolTip1.SetToolTip(this.checkBoxHideTaskbarNotifications, resources.GetString("checkBoxHideTaskbarNotifications.ToolTip"));
            this.checkBoxHideTaskbarNotifications.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseAdaptiveStreamingFormat
            // 
            resources.ApplyResources(this.checkBoxUseAdaptiveStreamingFormat, "checkBoxUseAdaptiveStreamingFormat");
            this.checkBoxUseAdaptiveStreamingFormat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxUseAdaptiveStreamingFormat.Name = "checkBoxUseAdaptiveStreamingFormat";
            this.toolTip1.SetToolTip(this.checkBoxUseAdaptiveStreamingFormat, resources.GetString("checkBoxUseAdaptiveStreamingFormat.ToolTip"));
            this.checkBoxUseAdaptiveStreamingFormat.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // numericUpDownAssetAnalysisStep
            // 
            resources.ApplyResources(this.numericUpDownAssetAnalysisStep, "numericUpDownAssetAnalysisStep");
            this.numericUpDownAssetAnalysisStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAssetAnalysisStep.Name = "numericUpDownAssetAnalysisStep";
            this.toolTip1.SetToolTip(this.numericUpDownAssetAnalysisStep, resources.GetString("numericUpDownAssetAnalysisStep.ToolTip"));
            this.numericUpDownAssetAnalysisStep.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // numericUpDownAssetAnalysisStart
            // 
            resources.ApplyResources(this.numericUpDownAssetAnalysisStart, "numericUpDownAssetAnalysisStart");
            this.numericUpDownAssetAnalysisStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAssetAnalysisStart.Name = "numericUpDownAssetAnalysisStart";
            this.toolTip1.SetToolTip(this.numericUpDownAssetAnalysisStart, resources.GetString("numericUpDownAssetAnalysisStart.ToolTip"));
            this.numericUpDownAssetAnalysisStart.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // numericUpDownLocatorDuration
            // 
            resources.ApplyResources(this.numericUpDownLocatorDuration, "numericUpDownLocatorDuration");
            this.numericUpDownLocatorDuration.Maximum = new decimal(new int[] {
            36500,
            0,
            0,
            0});
            this.numericUpDownLocatorDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLocatorDuration.Name = "numericUpDownLocatorDuration";
            this.toolTip1.SetToolTip(this.numericUpDownLocatorDuration, resources.GetString("numericUpDownLocatorDuration.ToolTip"));
            this.numericUpDownLocatorDuration.Value = new decimal(new int[] {
            3650,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.labelcdn);
            this.groupBox3.Controls.Add(this.textBoxCustomPlayer);
            this.groupBox3.Controls.Add(this.checkBoxEnableCustomPlayer);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // labelcdn
            // 
            resources.ApplyResources(this.labelcdn, "labelcdn");
            this.labelcdn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelcdn.Name = "labelcdn";
            this.toolTip1.SetToolTip(this.labelcdn, resources.GetString("labelcdn.ToolTip"));
            // 
            // textBoxCustomPlayer
            // 
            resources.ApplyResources(this.textBoxCustomPlayer, "textBoxCustomPlayer");
            this.textBoxCustomPlayer.Name = "textBoxCustomPlayer";
            this.toolTip1.SetToolTip(this.textBoxCustomPlayer, resources.GetString("textBoxCustomPlayer.ToolTip"));
            // 
            // checkBoxEnableCustomPlayer
            // 
            resources.ApplyResources(this.checkBoxEnableCustomPlayer, "checkBoxEnableCustomPlayer");
            this.checkBoxEnableCustomPlayer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxEnableCustomPlayer.Name = "checkBoxEnableCustomPlayer";
            this.toolTip1.SetToolTip(this.checkBoxEnableCustomPlayer, resources.GetString("checkBoxEnableCustomPlayer.ToolTip"));
            this.checkBoxEnableCustomPlayer.UseVisualStyleBackColor = true;
            this.checkBoxEnableCustomPlayer.CheckedChanged += new System.EventHandler(this.checkBoxEnableCustomPlayer_CheckedChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // numericUpDownDataMovNumbParallelOp
            // 
            resources.ApplyResources(this.numericUpDownDataMovNumbParallelOp, "numericUpDownDataMovNumbParallelOp");
            this.numericUpDownDataMovNumbParallelOp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDataMovNumbParallelOp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDataMovNumbParallelOp.Name = "numericUpDownDataMovNumbParallelOp";
            this.toolTip1.SetToolTip(this.numericUpDownDataMovNumbParallelOp, resources.GetString("numericUpDownDataMovNumbParallelOp.ToolTip"));
            this.numericUpDownDataMovNumbParallelOp.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.labelBlobSizeMax);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboBoxBlockSize);
            this.groupBox4.Controls.Add(this.checkBoxDoNotIncreaseHTTPLimit);
            this.groupBox4.Controls.Add(this.checkBoxDisableMD5Check);
            this.groupBox4.Controls.Add(this.checkBoxAutoParOpe);
            this.groupBox4.Controls.Add(this.numericUpDownDataMovNumbParallelOp);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // labelBlobSizeMax
            // 
            resources.ApplyResources(this.labelBlobSizeMax, "labelBlobSizeMax");
            this.labelBlobSizeMax.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelBlobSizeMax.Name = "labelBlobSizeMax";
            this.labelBlobSizeMax.Tag = "Maximum blob size is {0}.";
            this.toolTip1.SetToolTip(this.labelBlobSizeMax, resources.GetString("labelBlobSizeMax.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // comboBoxBlockSize
            // 
            resources.ApplyResources(this.comboBoxBlockSize, "comboBoxBlockSize");
            this.comboBoxBlockSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlockSize.FormattingEnabled = true;
            this.comboBoxBlockSize.Items.AddRange(new object[] {
            resources.GetString("comboBoxBlockSize.Items"),
            resources.GetString("comboBoxBlockSize.Items1"),
            resources.GetString("comboBoxBlockSize.Items2"),
            resources.GetString("comboBoxBlockSize.Items3"),
            resources.GetString("comboBoxBlockSize.Items4"),
            resources.GetString("comboBoxBlockSize.Items5"),
            resources.GetString("comboBoxBlockSize.Items6"),
            resources.GetString("comboBoxBlockSize.Items7")});
            this.comboBoxBlockSize.Name = "comboBoxBlockSize";
            this.toolTip1.SetToolTip(this.comboBoxBlockSize, resources.GetString("comboBoxBlockSize.ToolTip"));
            this.comboBoxBlockSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxBlockSize_SelectedIndexChanged);
            // 
            // checkBoxDoNotIncreaseHTTPLimit
            // 
            resources.ApplyResources(this.checkBoxDoNotIncreaseHTTPLimit, "checkBoxDoNotIncreaseHTTPLimit");
            this.checkBoxDoNotIncreaseHTTPLimit.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDoNotIncreaseHTTPLimit.Name = "checkBoxDoNotIncreaseHTTPLimit";
            this.toolTip1.SetToolTip(this.checkBoxDoNotIncreaseHTTPLimit, resources.GetString("checkBoxDoNotIncreaseHTTPLimit.ToolTip"));
            this.checkBoxDoNotIncreaseHTTPLimit.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisableMD5Check
            // 
            resources.ApplyResources(this.checkBoxDisableMD5Check, "checkBoxDisableMD5Check");
            this.checkBoxDisableMD5Check.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDisableMD5Check.Name = "checkBoxDisableMD5Check";
            this.toolTip1.SetToolTip(this.checkBoxDisableMD5Check, resources.GetString("checkBoxDisableMD5Check.ToolTip"));
            this.checkBoxDisableMD5Check.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoParOpe
            // 
            resources.ApplyResources(this.checkBoxAutoParOpe, "checkBoxAutoParOpe");
            this.checkBoxAutoParOpe.Checked = true;
            this.checkBoxAutoParOpe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoParOpe.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAutoParOpe.Name = "checkBoxAutoParOpe";
            this.toolTip1.SetToolTip(this.checkBoxAutoParOpe, resources.GetString("checkBoxAutoParOpe.ToolTip"));
            this.checkBoxAutoParOpe.UseVisualStyleBackColor = true;
            this.checkBoxAutoParOpe.CheckedChanged += new System.EventHandler(this.checkBoxAutoParOpe_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Name = "tabPage1";
            this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Name = "tabPage2";
            this.toolTip1.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Name = "tabPage3";
            this.toolTip1.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBoxVLCPath);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBoxffmpegPath);
            this.groupBox5.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // textBoxVLCPath
            // 
            resources.ApplyResources(this.textBoxVLCPath, "textBoxVLCPath");
            this.textBoxVLCPath.Name = "textBoxVLCPath";
            this.toolTip1.SetToolTip(this.textBoxVLCPath, resources.GetString("textBoxVLCPath.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // textBoxffmpegPath
            // 
            resources.ApplyResources(this.textBoxffmpegPath, "textBoxffmpegPath");
            this.textBoxffmpegPath.Name = "textBoxffmpegPath";
            this.toolTip1.SetToolTip(this.textBoxffmpegPath, resources.GetString("textBoxffmpegPath.ToolTip"));
            // 
            // Options
            // 
            this.AcceptButton = this.buttonOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Options";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Options_Load);
            this.Shown += new System.EventHandler(this.Options_Shown);
            this.DpiChanged += new System.Windows.Forms.DpiChangedEventHandler(this.Options_DpiChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSASDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssetAnalysisStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssetAnalysisStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLocatorDuration)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataMovNumbParallelOp)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxDisplayAssetID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.ComboBox comboBoxAutoRefreshTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCustomPlayer;
        private System.Windows.Forms.CheckBox checkBoxEnableCustomPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownLocatorDuration;
        private System.Windows.Forms.CheckBox checkBoxDisplayAssetStorage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownDataMovNumbParallelOp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxVLCPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxffmpegPath;
        private System.Windows.Forms.Label labelcdn;
        private System.Windows.Forms.CheckBox checkBoxDisplayAssetAltId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownAssetAnalysisStep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownAssetAnalysisStart;
        private System.Windows.Forms.CheckBox checkBoxUseAdaptiveStreamingFormat;
        private System.Windows.Forms.CheckBox checkBoxHideTaskbarNotifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSASDuration;
        private System.Windows.Forms.CheckBox checkBoxAutoParOpe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxDoNotIncreaseHTTPLimit;
        private System.Windows.Forms.CheckBox checkBoxDisableMD5Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxBlockSize;
        private System.Windows.Forms.Label labelBlobSizeMax;
        private System.Windows.Forms.CheckBox checkBoxDisableTelemetry;
    }
}