﻿using Mesen.GUI.Controls;

namespace Mesen.GUI.Forms.Config
{
	partial class frmAudioConfig
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
			if(disposing && (components != null)) {
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
            this.grpVolume = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trkDmcVol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkNoiseVol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkTriangleVol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkSquare2Vol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkSquare1Vol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkMaster = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkFdsVol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkMmc5Vol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkVrc6Vol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkVrc7Vol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkNamco163Vol = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkSunsoft5b = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkEPSMVol_L = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkEPSMVol_R = new Mesen.GUI.Controls.ctrlTrackbar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkEnableAudio = new System.Windows.Forms.CheckBox();
            this.chkEnableEPSM = new System.Windows.Forms.CheckBox();
            this.lblSampleRate = new System.Windows.Forms.Label();
            this.lblAudioLatency = new System.Windows.Forms.Label();
            this.cboSampleRate = new System.Windows.Forms.ComboBox();
            this.lblAudioDevice = new System.Windows.Forms.Label();
            this.cboAudioDevice = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLatencyWarning = new System.Windows.Forms.Label();
            this.picLatencyWarning = new System.Windows.Forms.PictureBox();
            this.lblLatencyMs = new System.Windows.Forms.Label();
            this.nudLatency = new Mesen.GUI.Controls.MesenNumericUpDown();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.chkReduceSoundInBackground = new System.Windows.Forms.CheckBox();
            this.chkReduceSoundInFastForward = new System.Windows.Forms.CheckBox();
            this.trkVolumeReduction = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.chkMuteSoundInBackground = new System.Windows.Forms.CheckBox();
            this.lblVolumeReductionSettings = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgGeneral = new System.Windows.Forms.TabPage();
            this.tpgVolume = new System.Windows.Forms.TabPage();
            this.tpgPanning = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.trkSquare1Pan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkFdsPan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkSquare2Pan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkMmc5Pan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkTrianglePan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkNoisePan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkDmcPan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkVrc6Pan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkVrc7Pan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkNamcoPan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkSunsoftPan = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkEPSMPan_L = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.trkEPSMPan_R = new Mesen.GUI.Controls.ctrlHorizontalTrackbar();
            this.tpgEqualizer = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableEqualizer = new System.Windows.Forms.CheckBox();
            this.tlpEqualizer = new System.Windows.Forms.TableLayoutPanel();
            this.trkBand6Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand5Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand4Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand3Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand2Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand1Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand11Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand12Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand13Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand14Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand15Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand16Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand7Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand8Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand9Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand10Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand17Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand18Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand19Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.trkBand20Gain = new Mesen.GUI.Controls.ctrlTrackbar();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEqualizerPreset = new System.Windows.Forms.Label();
            this.cboEqualizerPreset = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEqualizerFilterType = new System.Windows.Forms.Label();
            this.cboEqualizerFilterType = new System.Windows.Forms.ComboBox();
            this.tpgEffects = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grpStereo = new System.Windows.Forms.GroupBox();
            this.tlpStereoFilter = new System.Windows.Forms.TableLayoutPanel();
            this.radStereoCombFilter = new System.Windows.Forms.RadioButton();
            this.lblStereoDelayMs = new System.Windows.Forms.Label();
            this.lblStereoPanningAngle = new System.Windows.Forms.Label();
            this.radStereoDisabled = new System.Windows.Forms.RadioButton();
            this.radStereoDelay = new System.Windows.Forms.RadioButton();
            this.radStereoPanning = new System.Windows.Forms.RadioButton();
            this.nudStereoDelay = new Mesen.GUI.Controls.MesenNumericUpDown();
            this.nudStereoPanning = new Mesen.GUI.Controls.MesenNumericUpDown();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.nudStereoCombFilterStrength = new Mesen.GUI.Controls.MesenNumericUpDown();
            this.lblStereoCombFilterMs = new System.Windows.Forms.Label();
            this.nudStereoCombFilterDelay = new Mesen.GUI.Controls.MesenNumericUpDown();
            this.lblStereoCombFilterDelay = new System.Windows.Forms.Label();
            this.lblStereoCombFilterStrength = new System.Windows.Forms.Label();
            this.lblCombFilterPercent = new System.Windows.Forms.Label();
            this.grpReverb = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chkReverbEnabled = new System.Windows.Forms.CheckBox();
            this.lblReverbStrength = new System.Windows.Forms.Label();
            this.lblReverbDelay = new System.Windows.Forms.Label();
            this.trkReverbDelay = new System.Windows.Forms.TrackBar();
            this.trkReverbStrength = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkCrossFeedEnabled = new System.Windows.Forms.CheckBox();
            this.nudCrossFeedRatio = new Mesen.GUI.Controls.MesenNumericUpDown();
            this.lblCrossFeedRatio = new System.Windows.Forms.Label();
            this.tpgAdvanced = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkDisableDynamicSampleRate = new Mesen.GUI.Controls.ctrlRiskyOption();
            this.chkDisableNoiseModeFlag = new Mesen.GUI.Controls.ctrlRiskyOption();
            this.nudEPSMClockFrequency = new Mesen.GUI.Controls.MesenNumericUpDown();
            this.lblEPSMClockFrequency = new System.Windows.Forms.Label();
            this.chkSilenceTriangleHighFreq = new System.Windows.Forms.CheckBox();
            this.chkSwapDutyCycles = new Mesen.GUI.Controls.ctrlRiskyOption();
            this.chkReduceDmcPopping = new System.Windows.Forms.CheckBox();
            this.baseConfigPanel.SuspendLayout();
            this.grpVolume.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLatencyWarning)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpgGeneral.SuspendLayout();
            this.tpgVolume.SuspendLayout();
            this.tpgPanning.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tpgEqualizer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tlpEqualizer.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.tpgEffects.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpStereo.SuspendLayout();
            this.tlpStereoFilter.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.grpReverb.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkReverbDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkReverbStrength)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.tpgAdvanced.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseConfigPanel
            // 
            this.baseConfigPanel.Controls.Add(this.btnReset);
            this.baseConfigPanel.Location = new System.Drawing.Point(0, 550);
            this.baseConfigPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baseConfigPanel.Size = new System.Drawing.Size(703, 38);
            this.baseConfigPanel.Controls.SetChildIndex(this.btnReset, 0);
            // 
            // grpVolume
            // 
            this.grpVolume.Controls.Add(this.tableLayoutPanel1);
            this.grpVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVolume.Location = new System.Drawing.Point(4, 4);
            this.grpVolume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpVolume.Name = "grpVolume";
            this.grpVolume.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpVolume.Size = new System.Drawing.Size(687, 512);
            this.grpVolume.TabIndex = 2;
            this.grpVolume.TabStop = false;
            this.grpVolume.Text = "Volume";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.trkDmcVol, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.trkNoiseVol, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.trkTriangleVol, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.trkSquare2Vol, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.trkSquare1Vol, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trkMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trkFdsVol, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkMmc5Vol, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkVrc6Vol, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkVrc7Vol, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkNamco163Vol, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkSunsoft5b, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.trkEPSMVol_L, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkEPSMVol_R, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 488);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // trkDmcVol
            // 
            this.trkDmcVol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkDmcVol.Location = new System.Drawing.Point(420, 0);
            this.trkDmcVol.Margin = new System.Windows.Forms.Padding(0);
            this.trkDmcVol.Maximum = 100;
            this.trkDmcVol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkDmcVol.Minimum = 0;
            this.trkDmcVol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkDmcVol.Name = "trkDmcVol";
            this.trkDmcVol.Size = new System.Drawing.Size(84, 209);
            this.trkDmcVol.TabIndex = 16;
            this.trkDmcVol.Text = "DMC";
            this.trkDmcVol.Value = 50;
            // 
            // trkNoiseVol
            // 
            this.trkNoiseVol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkNoiseVol.Location = new System.Drawing.Point(336, 0);
            this.trkNoiseVol.Margin = new System.Windows.Forms.Padding(0);
            this.trkNoiseVol.Maximum = 100;
            this.trkNoiseVol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkNoiseVol.Minimum = 0;
            this.trkNoiseVol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkNoiseVol.Name = "trkNoiseVol";
            this.trkNoiseVol.Size = new System.Drawing.Size(84, 209);
            this.trkNoiseVol.TabIndex = 15;
            this.trkNoiseVol.Text = "Noise";
            this.trkNoiseVol.Value = 50;
            // 
            // trkTriangleVol
            // 
            this.trkTriangleVol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkTriangleVol.Location = new System.Drawing.Point(252, 0);
            this.trkTriangleVol.Margin = new System.Windows.Forms.Padding(0);
            this.trkTriangleVol.Maximum = 100;
            this.trkTriangleVol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkTriangleVol.Minimum = 0;
            this.trkTriangleVol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkTriangleVol.Name = "trkTriangleVol";
            this.trkTriangleVol.Size = new System.Drawing.Size(84, 209);
            this.trkTriangleVol.TabIndex = 14;
            this.trkTriangleVol.Text = "Triangle";
            this.trkTriangleVol.Value = 50;
            // 
            // trkSquare2Vol
            // 
            this.trkSquare2Vol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkSquare2Vol.Location = new System.Drawing.Point(168, 0);
            this.trkSquare2Vol.Margin = new System.Windows.Forms.Padding(0);
            this.trkSquare2Vol.Maximum = 100;
            this.trkSquare2Vol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkSquare2Vol.Minimum = 0;
            this.trkSquare2Vol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkSquare2Vol.Name = "trkSquare2Vol";
            this.trkSquare2Vol.Size = new System.Drawing.Size(84, 209);
            this.trkSquare2Vol.TabIndex = 13;
            this.trkSquare2Vol.Text = "Square 2";
            this.trkSquare2Vol.Value = 50;
            // 
            // trkSquare1Vol
            // 
            this.trkSquare1Vol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkSquare1Vol.Location = new System.Drawing.Point(84, 0);
            this.trkSquare1Vol.Margin = new System.Windows.Forms.Padding(0);
            this.trkSquare1Vol.Maximum = 100;
            this.trkSquare1Vol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkSquare1Vol.Minimum = 0;
            this.trkSquare1Vol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkSquare1Vol.Name = "trkSquare1Vol";
            this.trkSquare1Vol.Size = new System.Drawing.Size(84, 209);
            this.trkSquare1Vol.TabIndex = 12;
            this.trkSquare1Vol.Text = "Square 1";
            this.trkSquare1Vol.Value = 50;
            // 
            // trkMaster
            // 
            this.trkMaster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkMaster.Location = new System.Drawing.Point(0, 0);
            this.trkMaster.Margin = new System.Windows.Forms.Padding(0);
            this.trkMaster.Maximum = 100;
            this.trkMaster.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkMaster.Minimum = 0;
            this.trkMaster.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkMaster.Name = "trkMaster";
            this.trkMaster.Size = new System.Drawing.Size(84, 209);
            this.trkMaster.TabIndex = 11;
            this.trkMaster.Text = "Master";
            this.trkMaster.Value = 50;
            // 
            // trkFdsVol
            // 
            this.trkFdsVol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkFdsVol.Location = new System.Drawing.Point(0, 209);
            this.trkFdsVol.Margin = new System.Windows.Forms.Padding(0);
            this.trkFdsVol.Maximum = 100;
            this.trkFdsVol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkFdsVol.Minimum = 0;
            this.trkFdsVol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkFdsVol.Name = "trkFdsVol";
            this.trkFdsVol.Size = new System.Drawing.Size(84, 209);
            this.trkFdsVol.TabIndex = 17;
            this.trkFdsVol.Text = "FDS";
            this.trkFdsVol.Value = 50;
            // 
            // trkMmc5Vol
            // 
            this.trkMmc5Vol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkMmc5Vol.Location = new System.Drawing.Point(84, 209);
            this.trkMmc5Vol.Margin = new System.Windows.Forms.Padding(0);
            this.trkMmc5Vol.Maximum = 100;
            this.trkMmc5Vol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkMmc5Vol.Minimum = 0;
            this.trkMmc5Vol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkMmc5Vol.Name = "trkMmc5Vol";
            this.trkMmc5Vol.Size = new System.Drawing.Size(84, 209);
            this.trkMmc5Vol.TabIndex = 18;
            this.trkMmc5Vol.Text = "MMC5";
            this.trkMmc5Vol.Value = 50;
            // 
            // trkVrc6Vol
            // 
            this.trkVrc6Vol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkVrc6Vol.Location = new System.Drawing.Point(168, 209);
            this.trkVrc6Vol.Margin = new System.Windows.Forms.Padding(0);
            this.trkVrc6Vol.Maximum = 100;
            this.trkVrc6Vol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkVrc6Vol.Minimum = 0;
            this.trkVrc6Vol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkVrc6Vol.Name = "trkVrc6Vol";
            this.trkVrc6Vol.Size = new System.Drawing.Size(84, 209);
            this.trkVrc6Vol.TabIndex = 19;
            this.trkVrc6Vol.Text = "VRC6";
            this.trkVrc6Vol.Value = 50;
            // 
            // trkVrc7Vol
            // 
            this.trkVrc7Vol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkVrc7Vol.Location = new System.Drawing.Point(252, 209);
            this.trkVrc7Vol.Margin = new System.Windows.Forms.Padding(0);
            this.trkVrc7Vol.Maximum = 100;
            this.trkVrc7Vol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkVrc7Vol.Minimum = 0;
            this.trkVrc7Vol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkVrc7Vol.Name = "trkVrc7Vol";
            this.trkVrc7Vol.Size = new System.Drawing.Size(84, 209);
            this.trkVrc7Vol.TabIndex = 20;
            this.trkVrc7Vol.Text = "VRC7";
            this.trkVrc7Vol.Value = 50;
            // 
            // trkNamco163Vol
            // 
            this.trkNamco163Vol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkNamco163Vol.Location = new System.Drawing.Point(336, 209);
            this.trkNamco163Vol.Margin = new System.Windows.Forms.Padding(0);
            this.trkNamco163Vol.Maximum = 100;
            this.trkNamco163Vol.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkNamco163Vol.Minimum = 0;
            this.trkNamco163Vol.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkNamco163Vol.Name = "trkNamco163Vol";
            this.trkNamco163Vol.Size = new System.Drawing.Size(84, 209);
            this.trkNamco163Vol.TabIndex = 21;
            this.trkNamco163Vol.Text = "Namco";
            this.trkNamco163Vol.Value = 50;
            // 
            // trkSunsoft5b
            // 
            this.trkSunsoft5b.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkSunsoft5b.Location = new System.Drawing.Point(549, 0);
            this.trkSunsoft5b.Margin = new System.Windows.Forms.Padding(0);
            this.trkSunsoft5b.Maximum = 100;
            this.trkSunsoft5b.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkSunsoft5b.Minimum = 0;
            this.trkSunsoft5b.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkSunsoft5b.Name = "trkSunsoft5b";
            this.trkSunsoft5b.Size = new System.Drawing.Size(84, 209);
            this.trkSunsoft5b.TabIndex = 22;
            this.trkSunsoft5b.Text = "Sunsoft";
            this.trkSunsoft5b.Value = 50;
            // 
            // trkEPSMVol_L
            // 
            this.trkEPSMVol_L.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkEPSMVol_L.Location = new System.Drawing.Point(420, 209);
            this.trkEPSMVol_L.Margin = new System.Windows.Forms.Padding(0);
            this.trkEPSMVol_L.Maximum = 100;
            this.trkEPSMVol_L.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkEPSMVol_L.Minimum = 0;
            this.trkEPSMVol_L.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkEPSMVol_L.Name = "trkEPSMVol_L";
            this.trkEPSMVol_L.Size = new System.Drawing.Size(84, 209);
            this.trkEPSMVol_L.TabIndex = 22;
            this.trkEPSMVol_L.Text = "EPSM Left";
            this.trkEPSMVol_L.Value = 100;
            // 
            // trkEPSMVol_R
            // 
            this.trkEPSMVol_R.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkEPSMVol_R.Location = new System.Drawing.Point(549, 209);
            this.trkEPSMVol_R.Margin = new System.Windows.Forms.Padding(0);
            this.trkEPSMVol_R.Maximum = 100;
            this.trkEPSMVol_R.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkEPSMVol_R.Minimum = 0;
            this.trkEPSMVol_R.MinimumSize = new System.Drawing.Size(84, 209);
            this.trkEPSMVol_R.Name = "trkEPSMVol_R";
            this.trkEPSMVol_R.Size = new System.Drawing.Size(84, 209);
            this.trkEPSMVol_R.TabIndex = 22;
            this.trkEPSMVol_R.Text = "EPSM Right";
            this.trkEPSMVol_R.Value = 100;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.chkEnableAudio, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkEnableEPSM, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSampleRate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAudioLatency, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cboSampleRate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAudioDevice, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboAudioDevice, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblVolumeReductionSettings, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(773, 513);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // chkEnableAudio
            // 
            this.chkEnableAudio.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chkEnableAudio, 2);
            this.chkEnableAudio.Location = new System.Drawing.Point(8, 41);
            this.chkEnableAudio.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.chkEnableAudio.Name = "chkEnableAudio";
            this.chkEnableAudio.Size = new System.Drawing.Size(114, 21);
            this.chkEnableAudio.TabIndex = 3;
            this.chkEnableAudio.Text = "Enable Audio";
            this.chkEnableAudio.UseVisualStyleBackColor = true;
            // 
            // chkEnableEPSM
            // 
            this.chkEnableEPSM.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chkEnableEPSM, 2);
            this.chkEnableEPSM.Location = new System.Drawing.Point(8, 8);
            this.chkEnableEPSM.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.chkEnableEPSM.Name = "chkEnableEPSM";
            this.chkEnableEPSM.Size = new System.Drawing.Size(116, 21);
            this.chkEnableEPSM.TabIndex = 3;
            this.chkEnableEPSM.Text = "Enable EPSM";
            this.chkEnableEPSM.UseVisualStyleBackColor = true;
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(4, 107);
            this.lblSampleRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(93, 17);
            this.lblSampleRate.TabIndex = 0;
            this.lblSampleRate.Text = "Sample Rate:";
            // 
            // lblAudioLatency
            // 
            this.lblAudioLatency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAudioLatency.AutoSize = true;
            this.lblAudioLatency.Location = new System.Drawing.Point(4, 141);
            this.lblAudioLatency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAudioLatency.Name = "lblAudioLatency";
            this.lblAudioLatency.Size = new System.Drawing.Size(62, 17);
            this.lblAudioLatency.TabIndex = 0;
            this.lblAudioLatency.Text = "Latency:";
            // 
            // cboSampleRate
            // 
            this.cboSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSampleRate.FormattingEnabled = true;
            this.cboSampleRate.Items.AddRange(new object[] {
            "11,025 Hz",
            "22,050 Hz",
            "44,100 Hz",
            "48,000 Hz",
            "96,000 Hz"});
            this.cboSampleRate.Location = new System.Drawing.Point(105, 103);
            this.cboSampleRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSampleRate.Name = "cboSampleRate";
            this.cboSampleRate.Size = new System.Drawing.Size(99, 25);
            this.cboSampleRate.TabIndex = 5;
            // 
            // lblAudioDevice
            // 
            this.lblAudioDevice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAudioDevice.AutoSize = true;
            this.lblAudioDevice.Location = new System.Drawing.Point(4, 74);
            this.lblAudioDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAudioDevice.Name = "lblAudioDevice";
            this.lblAudioDevice.Size = new System.Drawing.Size(55, 17);
            this.lblAudioDevice.TabIndex = 6;
            this.lblAudioDevice.Text = "Device:";
            // 
            // cboAudioDevice
            // 
            this.cboAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioDevice.FormattingEnabled = true;
            this.cboAudioDevice.Location = new System.Drawing.Point(105, 70);
            this.cboAudioDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAudioDevice.Name = "cboAudioDevice";
            this.cboAudioDevice.Size = new System.Drawing.Size(277, 25);
            this.cboAudioDevice.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.lblLatencyWarning, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.picLatencyWarning, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblLatencyMs, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.nudLatency, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(101, 132);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(672, 35);
            this.tableLayoutPanel7.TabIndex = 15;
            // 
            // lblLatencyWarning
            // 
            this.lblLatencyWarning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLatencyWarning.AutoSize = true;
            this.lblLatencyWarning.Location = new System.Drawing.Point(130, 9);
            this.lblLatencyWarning.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblLatencyWarning.Name = "lblLatencyWarning";
            this.lblLatencyWarning.Size = new System.Drawing.Size(255, 17);
            this.lblLatencyWarning.TabIndex = 4;
            this.lblLatencyWarning.Text = "Low values may cause sound problems";
            // 
            // picLatencyWarning
            // 
            this.picLatencyWarning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picLatencyWarning.BackgroundImage = global::Mesen.GUI.Properties.Resources.Warning;
            this.picLatencyWarning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLatencyWarning.Location = new System.Drawing.Point(109, 7);
            this.picLatencyWarning.Margin = new System.Windows.Forms.Padding(7, 4, 0, 4);
            this.picLatencyWarning.Name = "picLatencyWarning";
            this.picLatencyWarning.Size = new System.Drawing.Size(21, 21);
            this.picLatencyWarning.TabIndex = 3;
            this.picLatencyWarning.TabStop = false;
            // 
            // lblLatencyMs
            // 
            this.lblLatencyMs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLatencyMs.AutoSize = true;
            this.lblLatencyMs.Location = new System.Drawing.Point(72, 9);
            this.lblLatencyMs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLatencyMs.Name = "lblLatencyMs";
            this.lblLatencyMs.Size = new System.Drawing.Size(26, 17);
            this.lblLatencyMs.TabIndex = 2;
            this.lblLatencyMs.Text = "ms";
            // 
            // nudLatency
            // 
            this.nudLatency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudLatency.DecimalPlaces = 0;
            this.nudLatency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLatency.IsHex = false;
            this.nudLatency.Location = new System.Drawing.Point(4, 4);
            this.nudLatency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudLatency.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudLatency.MaximumSize = new System.Drawing.Size(13333, 26);
            this.nudLatency.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudLatency.MinimumSize = new System.Drawing.Size(0, 27);
            this.nudLatency.Name = "nudLatency";
            this.nudLatency.Size = new System.Drawing.Size(60, 27);
            this.nudLatency.TabIndex = 1;
            this.nudLatency.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLatency.ValueChanged += new System.EventHandler(this.nudLatency_ValueChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel8, 2);
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.chkReduceSoundInBackground, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.chkReduceSoundInFastForward, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.trkVolumeReduction, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.chkMuteSoundInBackground, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(13, 192);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(13, 4, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(604, 106);
            this.tableLayoutPanel8.TabIndex = 25;
            // 
            // chkReduceSoundInBackground
            // 
            this.chkReduceSoundInBackground.AutoSize = true;
            this.chkReduceSoundInBackground.Location = new System.Drawing.Point(4, 33);
            this.chkReduceSoundInBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkReduceSoundInBackground.Name = "chkReduceSoundInBackground";
            this.chkReduceSoundInBackground.Size = new System.Drawing.Size(210, 21);
            this.chkReduceSoundInBackground.TabIndex = 13;
            this.chkReduceSoundInBackground.Text = "Reduce when in background";
            this.chkReduceSoundInBackground.UseVisualStyleBackColor = true;
            this.chkReduceSoundInBackground.CheckedChanged += new System.EventHandler(this.chkReduceVolume_CheckedChanged);
            // 
            // chkReduceSoundInFastForward
            // 
            this.chkReduceSoundInFastForward.AutoSize = true;
            this.chkReduceSoundInFastForward.Location = new System.Drawing.Point(4, 62);
            this.chkReduceSoundInFastForward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkReduceSoundInFastForward.Name = "chkReduceSoundInFastForward";
            this.chkReduceSoundInFastForward.Size = new System.Drawing.Size(294, 21);
            this.chkReduceSoundInFastForward.TabIndex = 16;
            this.chkReduceSoundInFastForward.Text = "Reduce when fast forwarding or rewinding";
            this.chkReduceSoundInFastForward.UseVisualStyleBackColor = true;
            this.chkReduceSoundInFastForward.CheckedChanged += new System.EventHandler(this.chkReduceVolume_CheckedChanged);
            // 
            // trkVolumeReduction
            // 
            this.trkVolumeReduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkVolumeReduction.Enabled = false;
            this.trkVolumeReduction.Location = new System.Drawing.Point(302, 29);
            this.trkVolumeReduction.Margin = new System.Windows.Forms.Padding(0);
            this.trkVolumeReduction.Maximum = 100;
            this.trkVolumeReduction.MaximumSize = new System.Drawing.Size(533, 72);
            this.trkVolumeReduction.Minimum = 0;
            this.trkVolumeReduction.MinimumSize = new System.Drawing.Size(200, 72);
            this.trkVolumeReduction.Name = "trkVolumeReduction";
            this.tableLayoutPanel8.SetRowSpan(this.trkVolumeReduction, 2);
            this.trkVolumeReduction.Size = new System.Drawing.Size(302, 72);
            this.trkVolumeReduction.TabIndex = 17;
            this.trkVolumeReduction.Text = "Volume Reduction";
            this.trkVolumeReduction.Value = 50;
            // 
            // chkMuteSoundInBackground
            // 
            this.chkMuteSoundInBackground.AutoSize = true;
            this.chkMuteSoundInBackground.Location = new System.Drawing.Point(4, 4);
            this.chkMuteSoundInBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMuteSoundInBackground.Name = "chkMuteSoundInBackground";
            this.chkMuteSoundInBackground.Size = new System.Drawing.Size(235, 21);
            this.chkMuteSoundInBackground.TabIndex = 18;
            this.chkMuteSoundInBackground.Text = "Mute sound when in background";
            this.chkMuteSoundInBackground.UseVisualStyleBackColor = true;
            this.chkMuteSoundInBackground.CheckedChanged += new System.EventHandler(this.chkMuteWhenInBackground_CheckedChanged);
            // 
            // lblVolumeReductionSettings
            // 
            this.lblVolumeReductionSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVolumeReductionSettings.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblVolumeReductionSettings, 2);
            this.lblVolumeReductionSettings.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblVolumeReductionSettings.Location = new System.Drawing.Point(0, 171);
            this.lblVolumeReductionSettings.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.lblVolumeReductionSettings.Name = "lblVolumeReductionSettings";
            this.lblVolumeReductionSettings.Size = new System.Drawing.Size(123, 17);
            this.lblVolumeReductionSettings.TabIndex = 24;
            this.lblVolumeReductionSettings.Text = "Volume Reduction";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(8, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 35);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset to Defaults";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgGeneral);
            this.tabMain.Controls.Add(this.tpgVolume);
            this.tabMain.Controls.Add(this.tpgPanning);
            this.tabMain.Controls.Add(this.tpgEqualizer);
            this.tabMain.Controls.Add(this.tpgEffects);
            this.tabMain.Controls.Add(this.tpgAdvanced);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(703, 550);
            this.tabMain.TabIndex = 4;
            // 
            // tpgGeneral
            // 
            this.tpgGeneral.Controls.Add(this.tableLayoutPanel2);
            this.tpgGeneral.Location = new System.Drawing.Point(4, 25);
            this.tpgGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgGeneral.Name = "tpgGeneral";
            this.tpgGeneral.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgGeneral.Size = new System.Drawing.Size(781, 521);
            this.tpgGeneral.TabIndex = 0;
            this.tpgGeneral.Text = "General";
            this.tpgGeneral.UseVisualStyleBackColor = true;
            // 
            // tpgVolume
            // 
            this.tpgVolume.Controls.Add(this.grpVolume);
            this.tpgVolume.Location = new System.Drawing.Point(4, 26);
            this.tpgVolume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgVolume.Name = "tpgVolume";
            this.tpgVolume.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgVolume.Size = new System.Drawing.Size(695, 520);
            this.tpgVolume.TabIndex = 1;
            this.tpgVolume.Text = "Volume";
            this.tpgVolume.UseVisualStyleBackColor = true;
            // 
            // tpgPanning
            // 
            this.tpgPanning.Controls.Add(this.tableLayoutPanel6);
            this.tpgPanning.Location = new System.Drawing.Point(4, 26);
            this.tpgPanning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgPanning.Name = "tpgPanning";
            this.tpgPanning.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgPanning.Size = new System.Drawing.Size(628, 521);
            this.tpgPanning.TabIndex = 4;
            this.tpgPanning.Text = "Panning";
            this.tpgPanning.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.trkSquare1Pan, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.trkFdsPan, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.trkSquare2Pan, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.trkMmc5Pan, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.trkTrianglePan, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.trkNoisePan, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.trkDmcPan, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.trkVrc6Pan, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.trkVrc7Pan, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.trkNamcoPan, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.trkSunsoftPan, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.trkEPSMPan_L, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.trkEPSMPan_R, 1, 5);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 8;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(620, 513);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // trkSquare1Pan
            // 
            this.trkSquare1Pan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkSquare1Pan.Location = new System.Drawing.Point(17, 0);
            this.trkSquare1Pan.Margin = new System.Windows.Forms.Padding(0);
            this.trkSquare1Pan.Maximum = 100;
            this.trkSquare1Pan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkSquare1Pan.Minimum = -100;
            this.trkSquare1Pan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkSquare1Pan.Name = "trkSquare1Pan";
            this.trkSquare1Pan.Size = new System.Drawing.Size(275, 72);
            this.trkSquare1Pan.TabIndex = 12;
            this.trkSquare1Pan.Text = "Square 1";
            this.trkSquare1Pan.Value = 0;
            // 
            // trkFdsPan
            // 
            this.trkFdsPan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkFdsPan.Location = new System.Drawing.Point(327, 0);
            this.trkFdsPan.Margin = new System.Windows.Forms.Padding(0);
            this.trkFdsPan.Maximum = 100;
            this.trkFdsPan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkFdsPan.Minimum = -100;
            this.trkFdsPan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkFdsPan.Name = "trkFdsPan";
            this.trkFdsPan.Size = new System.Drawing.Size(275, 72);
            this.trkFdsPan.TabIndex = 17;
            this.trkFdsPan.Text = "FDS";
            this.trkFdsPan.Value = 0;
            // 
            // trkSquare2Pan
            // 
            this.trkSquare2Pan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkSquare2Pan.Location = new System.Drawing.Point(17, 72);
            this.trkSquare2Pan.Margin = new System.Windows.Forms.Padding(0);
            this.trkSquare2Pan.Maximum = 100;
            this.trkSquare2Pan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkSquare2Pan.Minimum = -100;
            this.trkSquare2Pan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkSquare2Pan.Name = "trkSquare2Pan";
            this.trkSquare2Pan.Size = new System.Drawing.Size(275, 72);
            this.trkSquare2Pan.TabIndex = 13;
            this.trkSquare2Pan.Text = "Square 2";
            this.trkSquare2Pan.Value = 0;
            // 
            // trkMmc5Pan
            // 
            this.trkMmc5Pan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkMmc5Pan.Location = new System.Drawing.Point(327, 72);
            this.trkMmc5Pan.Margin = new System.Windows.Forms.Padding(0);
            this.trkMmc5Pan.Maximum = 100;
            this.trkMmc5Pan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkMmc5Pan.Minimum = -100;
            this.trkMmc5Pan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkMmc5Pan.Name = "trkMmc5Pan";
            this.trkMmc5Pan.Size = new System.Drawing.Size(275, 72);
            this.trkMmc5Pan.TabIndex = 18;
            this.trkMmc5Pan.Text = "MMC5";
            this.trkMmc5Pan.Value = 0;
            // 
            // trkTrianglePan
            // 
            this.trkTrianglePan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkTrianglePan.Location = new System.Drawing.Point(17, 144);
            this.trkTrianglePan.Margin = new System.Windows.Forms.Padding(0);
            this.trkTrianglePan.Maximum = 100;
            this.trkTrianglePan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkTrianglePan.Minimum = -100;
            this.trkTrianglePan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkTrianglePan.Name = "trkTrianglePan";
            this.trkTrianglePan.Size = new System.Drawing.Size(275, 72);
            this.trkTrianglePan.TabIndex = 14;
            this.trkTrianglePan.Text = "Triangle";
            this.trkTrianglePan.Value = 0;
            // 
            // trkNoisePan
            // 
            this.trkNoisePan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkNoisePan.Location = new System.Drawing.Point(17, 216);
            this.trkNoisePan.Margin = new System.Windows.Forms.Padding(0);
            this.trkNoisePan.Maximum = 100;
            this.trkNoisePan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkNoisePan.Minimum = -100;
            this.trkNoisePan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkNoisePan.Name = "trkNoisePan";
            this.trkNoisePan.Size = new System.Drawing.Size(275, 72);
            this.trkNoisePan.TabIndex = 15;
            this.trkNoisePan.Text = "Noise";
            this.trkNoisePan.Value = 0;
            // 
            // trkDmcPan
            // 
            this.trkDmcPan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkDmcPan.Location = new System.Drawing.Point(17, 288);
            this.trkDmcPan.Margin = new System.Windows.Forms.Padding(0);
            this.trkDmcPan.Maximum = 100;
            this.trkDmcPan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkDmcPan.Minimum = -100;
            this.trkDmcPan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkDmcPan.Name = "trkDmcPan";
            this.trkDmcPan.Size = new System.Drawing.Size(275, 72);
            this.trkDmcPan.TabIndex = 16;
            this.trkDmcPan.Text = "DMC";
            this.trkDmcPan.Value = 0;
            // 
            // trkVrc6Pan
            // 
            this.trkVrc6Pan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkVrc6Pan.Location = new System.Drawing.Point(327, 144);
            this.trkVrc6Pan.Margin = new System.Windows.Forms.Padding(0);
            this.trkVrc6Pan.Maximum = 100;
            this.trkVrc6Pan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkVrc6Pan.Minimum = -100;
            this.trkVrc6Pan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkVrc6Pan.Name = "trkVrc6Pan";
            this.trkVrc6Pan.Size = new System.Drawing.Size(275, 72);
            this.trkVrc6Pan.TabIndex = 19;
            this.trkVrc6Pan.Text = "VRC6";
            this.trkVrc6Pan.Value = 0;
            // 
            // trkVrc7Pan
            // 
            this.trkVrc7Pan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkVrc7Pan.Location = new System.Drawing.Point(327, 216);
            this.trkVrc7Pan.Margin = new System.Windows.Forms.Padding(0);
            this.trkVrc7Pan.Maximum = 100;
            this.trkVrc7Pan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkVrc7Pan.Minimum = -100;
            this.trkVrc7Pan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkVrc7Pan.Name = "trkVrc7Pan";
            this.trkVrc7Pan.Size = new System.Drawing.Size(275, 72);
            this.trkVrc7Pan.TabIndex = 20;
            this.trkVrc7Pan.Text = "VRC7";
            this.trkVrc7Pan.Value = 0;
            // 
            // trkNamcoPan
            // 
            this.trkNamcoPan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkNamcoPan.Location = new System.Drawing.Point(327, 288);
            this.trkNamcoPan.Margin = new System.Windows.Forms.Padding(0);
            this.trkNamcoPan.Maximum = 100;
            this.trkNamcoPan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkNamcoPan.Minimum = -100;
            this.trkNamcoPan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkNamcoPan.Name = "trkNamcoPan";
            this.trkNamcoPan.Size = new System.Drawing.Size(275, 72);
            this.trkNamcoPan.TabIndex = 21;
            this.trkNamcoPan.Text = "Namco";
            this.trkNamcoPan.Value = 0;
            // 
            // trkSunsoftPan
            // 
            this.trkSunsoftPan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkSunsoftPan.Location = new System.Drawing.Point(17, 432);
            this.trkSunsoftPan.Margin = new System.Windows.Forms.Padding(0);
            this.trkSunsoftPan.Maximum = 100;
            this.trkSunsoftPan.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkSunsoftPan.Minimum = -100;
            this.trkSunsoftPan.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkSunsoftPan.Name = "trkSunsoftPan";
            this.trkSunsoftPan.Size = new System.Drawing.Size(275, 72);
            this.trkSunsoftPan.TabIndex = 22;
            this.trkSunsoftPan.Text = "Sunsoft";
            this.trkSunsoftPan.Value = 0;
            // 
            // trkEPSMPan_L
            // 
            this.trkEPSMPan_L.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkEPSMPan_L.Location = new System.Drawing.Point(17, 360);
            this.trkEPSMPan_L.Margin = new System.Windows.Forms.Padding(0);
            this.trkEPSMPan_L.Maximum = 100;
            this.trkEPSMPan_L.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkEPSMPan_L.Minimum = -100;
            this.trkEPSMPan_L.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkEPSMPan_L.Name = "trkEPSMPan_L";
            this.trkEPSMPan_L.Size = new System.Drawing.Size(275, 72);
            this.trkEPSMPan_L.TabIndex = 22;
            this.trkEPSMPan_L.Text = "EPSM Left";
            this.trkEPSMPan_L.Value = -100;
            // 
            // trkEPSMPan_R
            // 
            this.trkEPSMPan_R.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trkEPSMPan_R.Location = new System.Drawing.Point(327, 360);
            this.trkEPSMPan_R.Margin = new System.Windows.Forms.Padding(0);
            this.trkEPSMPan_R.Maximum = 100;
            this.trkEPSMPan_R.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkEPSMPan_R.Minimum = -100;
            this.trkEPSMPan_R.MinimumSize = new System.Drawing.Size(275, 72);
            this.trkEPSMPan_R.Name = "trkEPSMPan_R";
            this.trkEPSMPan_R.Size = new System.Drawing.Size(275, 72);
            this.trkEPSMPan_R.TabIndex = 22;
            this.trkEPSMPan_R.Text = "EPSM Right";
            this.trkEPSMPan_R.Value = 100;
            // 
            // tpgEqualizer
            // 
            this.tpgEqualizer.Controls.Add(this.groupBox1);
            this.tpgEqualizer.Location = new System.Drawing.Point(4, 26);
            this.tpgEqualizer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgEqualizer.Name = "tpgEqualizer";
            this.tpgEqualizer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgEqualizer.Size = new System.Drawing.Size(628, 521);
            this.tpgEqualizer.TabIndex = 5;
            this.tpgEqualizer.Text = "Equalizer";
            this.tpgEqualizer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEnableEqualizer);
            this.groupBox1.Controls.Add(this.tlpEqualizer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(620, 513);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // chkEnableEqualizer
            // 
            this.chkEnableEqualizer.AutoSize = true;
            this.chkEnableEqualizer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkEnableEqualizer.Location = new System.Drawing.Point(9, 0);
            this.chkEnableEqualizer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEnableEqualizer.Name = "chkEnableEqualizer";
            this.chkEnableEqualizer.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.chkEnableEqualizer.Size = new System.Drawing.Size(144, 21);
            this.chkEnableEqualizer.TabIndex = 5;
            this.chkEnableEqualizer.Text = "Enable Equalizer";
            this.chkEnableEqualizer.UseVisualStyleBackColor = false;
            this.chkEnableEqualizer.CheckedChanged += new System.EventHandler(this.chkEnableEqualizer_CheckedChanged);
            // 
            // tlpEqualizer
            // 
            this.tlpEqualizer.ColumnCount = 10;
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEqualizer.Controls.Add(this.trkBand6Gain, 5, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand5Gain, 4, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand4Gain, 3, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand3Gain, 2, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand2Gain, 1, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand1Gain, 0, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand11Gain, 0, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand12Gain, 1, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand13Gain, 2, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand14Gain, 3, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand15Gain, 4, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand16Gain, 5, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand7Gain, 6, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand8Gain, 7, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand9Gain, 8, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand10Gain, 9, 1);
            this.tlpEqualizer.Controls.Add(this.trkBand17Gain, 6, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand18Gain, 7, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand19Gain, 8, 2);
            this.tlpEqualizer.Controls.Add(this.trkBand20Gain, 9, 2);
            this.tlpEqualizer.Controls.Add(this.flowLayoutPanel6, 0, 0);
            this.tlpEqualizer.Controls.Add(this.flowLayoutPanel7, 6, 0);
            this.tlpEqualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEqualizer.Location = new System.Drawing.Point(4, 20);
            this.tlpEqualizer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpEqualizer.Name = "tlpEqualizer";
            this.tlpEqualizer.RowCount = 4;
            this.tlpEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEqualizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpEqualizer.Size = new System.Drawing.Size(612, 489);
            this.tlpEqualizer.TabIndex = 3;
            // 
            // trkBand6Gain
            // 
            this.trkBand6Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand6Gain.Location = new System.Drawing.Point(305, 28);
            this.trkBand6Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand6Gain.Maximum = 200;
            this.trkBand6Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand6Gain.Minimum = -200;
            this.trkBand6Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand6Gain.Name = "trkBand6Gain";
            this.trkBand6Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand6Gain.TabIndex = 16;
            this.trkBand6Gain.Text = "225 Hz";
            this.trkBand6Gain.Value = 50;
            this.trkBand6Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand5Gain
            // 
            this.trkBand5Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand5Gain.Location = new System.Drawing.Point(244, 28);
            this.trkBand5Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand5Gain.Maximum = 200;
            this.trkBand5Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand5Gain.Minimum = -200;
            this.trkBand5Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand5Gain.Name = "trkBand5Gain";
            this.trkBand5Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand5Gain.TabIndex = 15;
            this.trkBand5Gain.Text = "160 Hz";
            this.trkBand5Gain.Value = 50;
            this.trkBand5Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand4Gain
            // 
            this.trkBand4Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand4Gain.Location = new System.Drawing.Point(183, 28);
            this.trkBand4Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand4Gain.Maximum = 200;
            this.trkBand4Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand4Gain.Minimum = -200;
            this.trkBand4Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand4Gain.Name = "trkBand4Gain";
            this.trkBand4Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand4Gain.TabIndex = 14;
            this.trkBand4Gain.Text = "113 Hz";
            this.trkBand4Gain.Value = 50;
            this.trkBand4Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand3Gain
            // 
            this.trkBand3Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand3Gain.Location = new System.Drawing.Point(122, 28);
            this.trkBand3Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand3Gain.Maximum = 200;
            this.trkBand3Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand3Gain.Minimum = -200;
            this.trkBand3Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand3Gain.Name = "trkBand3Gain";
            this.trkBand3Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand3Gain.TabIndex = 13;
            this.trkBand3Gain.Text = "80 Hz";
            this.trkBand3Gain.Value = 50;
            this.trkBand3Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand2Gain
            // 
            this.trkBand2Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand2Gain.Location = new System.Drawing.Point(61, 28);
            this.trkBand2Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand2Gain.Maximum = 200;
            this.trkBand2Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand2Gain.Minimum = -200;
            this.trkBand2Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand2Gain.Name = "trkBand2Gain";
            this.trkBand2Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand2Gain.TabIndex = 12;
            this.trkBand2Gain.Text = "56 Hz";
            this.trkBand2Gain.Value = 50;
            this.trkBand2Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand1Gain
            // 
            this.trkBand1Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand1Gain.Location = new System.Drawing.Point(0, 28);
            this.trkBand1Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand1Gain.Maximum = 200;
            this.trkBand1Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand1Gain.Minimum = -200;
            this.trkBand1Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand1Gain.Name = "trkBand1Gain";
            this.trkBand1Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand1Gain.TabIndex = 11;
            this.trkBand1Gain.Text = "40 Hz";
            this.trkBand1Gain.Value = 50;
            this.trkBand1Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand11Gain
            // 
            this.trkBand11Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand11Gain.Location = new System.Drawing.Point(0, 237);
            this.trkBand11Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand11Gain.Maximum = 200;
            this.trkBand11Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand11Gain.Minimum = -200;
            this.trkBand11Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand11Gain.Name = "trkBand11Gain";
            this.trkBand11Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand11Gain.TabIndex = 17;
            this.trkBand11Gain.Text = "1.0 kHz";
            this.trkBand11Gain.Value = 50;
            this.trkBand11Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand12Gain
            // 
            this.trkBand12Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand12Gain.Location = new System.Drawing.Point(61, 237);
            this.trkBand12Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand12Gain.Maximum = 200;
            this.trkBand12Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand12Gain.Minimum = -200;
            this.trkBand12Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand12Gain.Name = "trkBand12Gain";
            this.trkBand12Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand12Gain.TabIndex = 18;
            this.trkBand12Gain.Text = "2.0 kHz";
            this.trkBand12Gain.Value = 50;
            this.trkBand12Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand13Gain
            // 
            this.trkBand13Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand13Gain.Location = new System.Drawing.Point(122, 237);
            this.trkBand13Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand13Gain.Maximum = 200;
            this.trkBand13Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand13Gain.Minimum = -200;
            this.trkBand13Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand13Gain.Name = "trkBand13Gain";
            this.trkBand13Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand13Gain.TabIndex = 19;
            this.trkBand13Gain.Text = "3.0 kHz";
            this.trkBand13Gain.Value = 50;
            this.trkBand13Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand14Gain
            // 
            this.trkBand14Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand14Gain.Location = new System.Drawing.Point(183, 237);
            this.trkBand14Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand14Gain.Maximum = 200;
            this.trkBand14Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand14Gain.Minimum = -200;
            this.trkBand14Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand14Gain.Name = "trkBand14Gain";
            this.trkBand14Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand14Gain.TabIndex = 20;
            this.trkBand14Gain.Text = "4.0 kHz";
            this.trkBand14Gain.Value = 50;
            this.trkBand14Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand15Gain
            // 
            this.trkBand15Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand15Gain.Location = new System.Drawing.Point(244, 237);
            this.trkBand15Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand15Gain.Maximum = 200;
            this.trkBand15Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand15Gain.Minimum = -200;
            this.trkBand15Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand15Gain.Name = "trkBand15Gain";
            this.trkBand15Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand15Gain.TabIndex = 21;
            this.trkBand15Gain.Text = "5.0 kHz";
            this.trkBand15Gain.Value = 50;
            this.trkBand15Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand16Gain
            // 
            this.trkBand16Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand16Gain.Location = new System.Drawing.Point(305, 237);
            this.trkBand16Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand16Gain.Maximum = 200;
            this.trkBand16Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand16Gain.Minimum = -200;
            this.trkBand16Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand16Gain.Name = "trkBand16Gain";
            this.trkBand16Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand16Gain.TabIndex = 22;
            this.trkBand16Gain.Text = "6.0 kHz";
            this.trkBand16Gain.Value = 50;
            this.trkBand16Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand7Gain
            // 
            this.trkBand7Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand7Gain.Location = new System.Drawing.Point(366, 28);
            this.trkBand7Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand7Gain.Maximum = 200;
            this.trkBand7Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand7Gain.Minimum = -200;
            this.trkBand7Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand7Gain.Name = "trkBand7Gain";
            this.trkBand7Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand7Gain.TabIndex = 23;
            this.trkBand7Gain.Text = "320 Hz";
            this.trkBand7Gain.Value = 50;
            this.trkBand7Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand8Gain
            // 
            this.trkBand8Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand8Gain.Location = new System.Drawing.Point(427, 28);
            this.trkBand8Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand8Gain.Maximum = 200;
            this.trkBand8Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand8Gain.Minimum = -200;
            this.trkBand8Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand8Gain.Name = "trkBand8Gain";
            this.trkBand8Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand8Gain.TabIndex = 24;
            this.trkBand8Gain.Text = "450 Hz";
            this.trkBand8Gain.Value = 50;
            this.trkBand8Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand9Gain
            // 
            this.trkBand9Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand9Gain.Location = new System.Drawing.Point(488, 28);
            this.trkBand9Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand9Gain.Maximum = 200;
            this.trkBand9Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand9Gain.Minimum = -200;
            this.trkBand9Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand9Gain.Name = "trkBand9Gain";
            this.trkBand9Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand9Gain.TabIndex = 25;
            this.trkBand9Gain.Text = "600 Hz";
            this.trkBand9Gain.Value = 50;
            this.trkBand9Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand10Gain
            // 
            this.trkBand10Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand10Gain.Location = new System.Drawing.Point(549, 28);
            this.trkBand10Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand10Gain.Maximum = 200;
            this.trkBand10Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand10Gain.Minimum = -200;
            this.trkBand10Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand10Gain.Name = "trkBand10Gain";
            this.trkBand10Gain.Size = new System.Drawing.Size(63, 209);
            this.trkBand10Gain.TabIndex = 26;
            this.trkBand10Gain.Text = "750 Hz";
            this.trkBand10Gain.Value = 50;
            this.trkBand10Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand17Gain
            // 
            this.trkBand17Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand17Gain.Location = new System.Drawing.Point(366, 237);
            this.trkBand17Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand17Gain.Maximum = 200;
            this.trkBand17Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand17Gain.Minimum = -200;
            this.trkBand17Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand17Gain.Name = "trkBand17Gain";
            this.trkBand17Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand17Gain.TabIndex = 27;
            this.trkBand17Gain.Text = "7.0 kHz";
            this.trkBand17Gain.Value = 50;
            this.trkBand17Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand18Gain
            // 
            this.trkBand18Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand18Gain.Location = new System.Drawing.Point(427, 237);
            this.trkBand18Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand18Gain.Maximum = 200;
            this.trkBand18Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand18Gain.Minimum = -200;
            this.trkBand18Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand18Gain.Name = "trkBand18Gain";
            this.trkBand18Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand18Gain.TabIndex = 28;
            this.trkBand18Gain.Text = "10.0 kHz";
            this.trkBand18Gain.Value = 50;
            this.trkBand18Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand19Gain
            // 
            this.trkBand19Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand19Gain.Location = new System.Drawing.Point(488, 237);
            this.trkBand19Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand19Gain.Maximum = 200;
            this.trkBand19Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand19Gain.Minimum = -200;
            this.trkBand19Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand19Gain.Name = "trkBand19Gain";
            this.trkBand19Gain.Size = new System.Drawing.Size(61, 209);
            this.trkBand19Gain.TabIndex = 29;
            this.trkBand19Gain.Text = "12.5 kHz";
            this.trkBand19Gain.Value = 50;
            this.trkBand19Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // trkBand20Gain
            // 
            this.trkBand20Gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBand20Gain.Location = new System.Drawing.Point(549, 237);
            this.trkBand20Gain.Margin = new System.Windows.Forms.Padding(0);
            this.trkBand20Gain.Maximum = 200;
            this.trkBand20Gain.MaximumSize = new System.Drawing.Size(84, 209);
            this.trkBand20Gain.Minimum = -200;
            this.trkBand20Gain.MinimumSize = new System.Drawing.Size(45, 209);
            this.trkBand20Gain.Name = "trkBand20Gain";
            this.trkBand20Gain.Size = new System.Drawing.Size(63, 209);
            this.trkBand20Gain.TabIndex = 30;
            this.trkBand20Gain.Text = "15 kHz";
            this.trkBand20Gain.Value = 50;
            this.trkBand20Gain.ValueChanged += new System.EventHandler(this.trkBandGain_ValueChanged);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.tlpEqualizer.SetColumnSpan(this.flowLayoutPanel6, 5);
            this.flowLayoutPanel6.Controls.Add(this.lblEqualizerPreset);
            this.flowLayoutPanel6.Controls.Add(this.cboEqualizerPreset);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(221, 25);
            this.flowLayoutPanel6.TabIndex = 33;
            this.flowLayoutPanel6.Visible = false;
            // 
            // lblEqualizerPreset
            // 
            this.lblEqualizerPreset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEqualizerPreset.AutoSize = true;
            this.lblEqualizerPreset.Location = new System.Drawing.Point(4, 4);
            this.lblEqualizerPreset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEqualizerPreset.Name = "lblEqualizerPreset";
            this.lblEqualizerPreset.Size = new System.Drawing.Size(53, 17);
            this.lblEqualizerPreset.TabIndex = 32;
            this.lblEqualizerPreset.Text = "Preset:";
            // 
            // cboEqualizerPreset
            // 
            this.cboEqualizerPreset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEqualizerPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEqualizerPreset.FormattingEnabled = true;
            this.cboEqualizerPreset.Location = new System.Drawing.Point(61, 0);
            this.cboEqualizerPreset.Margin = new System.Windows.Forms.Padding(0);
            this.cboEqualizerPreset.Name = "cboEqualizerPreset";
            this.cboEqualizerPreset.Size = new System.Drawing.Size(160, 25);
            this.cboEqualizerPreset.TabIndex = 33;
            this.cboEqualizerPreset.SelectedIndexChanged += new System.EventHandler(this.cboEqualizerPreset_SelectedIndexChanged);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel7.AutoSize = true;
            this.tlpEqualizer.SetColumnSpan(this.flowLayoutPanel7, 4);
            this.flowLayoutPanel7.Controls.Add(this.lblEqualizerFilterType);
            this.flowLayoutPanel7.Controls.Add(this.cboEqualizerFilterType);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(401, 3);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(211, 25);
            this.flowLayoutPanel7.TabIndex = 34;
            this.flowLayoutPanel7.Visible = false;
            // 
            // lblEqualizerFilterType
            // 
            this.lblEqualizerFilterType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEqualizerFilterType.AutoSize = true;
            this.lblEqualizerFilterType.Location = new System.Drawing.Point(4, 4);
            this.lblEqualizerFilterType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEqualizerFilterType.Name = "lblEqualizerFilterType";
            this.lblEqualizerFilterType.Size = new System.Drawing.Size(43, 17);
            this.lblEqualizerFilterType.TabIndex = 31;
            this.lblEqualizerFilterType.Text = "Filter:";
            // 
            // cboEqualizerFilterType
            // 
            this.cboEqualizerFilterType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEqualizerFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEqualizerFilterType.FormattingEnabled = true;
            this.cboEqualizerFilterType.Location = new System.Drawing.Point(51, 0);
            this.cboEqualizerFilterType.Margin = new System.Windows.Forms.Padding(0);
            this.cboEqualizerFilterType.Name = "cboEqualizerFilterType";
            this.cboEqualizerFilterType.Size = new System.Drawing.Size(160, 25);
            this.cboEqualizerFilterType.TabIndex = 32;
            // 
            // tpgEffects
            // 
            this.tpgEffects.Controls.Add(this.tableLayoutPanel4);
            this.tpgEffects.Location = new System.Drawing.Point(4, 26);
            this.tpgEffects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgEffects.Name = "tpgEffects";
            this.tpgEffects.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgEffects.Size = new System.Drawing.Size(628, 521);
            this.tpgEffects.TabIndex = 3;
            this.tpgEffects.Text = "Effects";
            this.tpgEffects.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.grpStereo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.grpReverb, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(620, 513);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // grpStereo
            // 
            this.grpStereo.Controls.Add(this.tlpStereoFilter);
            this.grpStereo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStereo.Location = new System.Drawing.Point(4, 4);
            this.grpStereo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStereo.Name = "grpStereo";
            this.grpStereo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStereo.Size = new System.Drawing.Size(612, 150);
            this.grpStereo.TabIndex = 0;
            this.grpStereo.TabStop = false;
            this.grpStereo.Text = "Stereo";
            // 
            // tlpStereoFilter
            // 
            this.tlpStereoFilter.ColumnCount = 3;
            this.tlpStereoFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStereoFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStereoFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStereoFilter.Controls.Add(this.radStereoCombFilter, 0, 3);
            this.tlpStereoFilter.Controls.Add(this.lblStereoDelayMs, 2, 1);
            this.tlpStereoFilter.Controls.Add(this.lblStereoPanningAngle, 2, 2);
            this.tlpStereoFilter.Controls.Add(this.radStereoDisabled, 0, 0);
            this.tlpStereoFilter.Controls.Add(this.radStereoDelay, 0, 1);
            this.tlpStereoFilter.Controls.Add(this.radStereoPanning, 0, 2);
            this.tlpStereoFilter.Controls.Add(this.nudStereoDelay, 1, 1);
            this.tlpStereoFilter.Controls.Add(this.nudStereoPanning, 1, 2);
            this.tlpStereoFilter.Controls.Add(this.tableLayoutPanel9, 1, 3);
            this.tlpStereoFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStereoFilter.Location = new System.Drawing.Point(4, 20);
            this.tlpStereoFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpStereoFilter.Name = "tlpStereoFilter";
            this.tlpStereoFilter.RowCount = 5;
            this.tlpStereoFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStereoFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStereoFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStereoFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStereoFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStereoFilter.Size = new System.Drawing.Size(604, 126);
            this.tlpStereoFilter.TabIndex = 0;
            // 
            // radStereoCombFilter
            // 
            this.radStereoCombFilter.AutoSize = true;
            this.radStereoCombFilter.Location = new System.Drawing.Point(4, 91);
            this.radStereoCombFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radStereoCombFilter.Name = "radStereoCombFilter";
            this.radStereoCombFilter.Size = new System.Drawing.Size(100, 21);
            this.radStereoCombFilter.TabIndex = 4;
            this.radStereoCombFilter.TabStop = true;
            this.radStereoCombFilter.Tag = "Panning";
            this.radStereoCombFilter.Text = "Comb Filter";
            this.radStereoCombFilter.UseVisualStyleBackColor = true;
            // 
            // lblStereoDelayMs
            // 
            this.lblStereoDelayMs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStereoDelayMs.AutoSize = true;
            this.lblStereoDelayMs.Location = new System.Drawing.Point(172, 35);
            this.lblStereoDelayMs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStereoDelayMs.Name = "lblStereoDelayMs";
            this.lblStereoDelayMs.Size = new System.Drawing.Size(26, 17);
            this.lblStereoDelayMs.TabIndex = 1;
            this.lblStereoDelayMs.Text = "ms";
            // 
            // lblStereoPanningAngle
            // 
            this.lblStereoPanningAngle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStereoPanningAngle.AutoSize = true;
            this.lblStereoPanningAngle.Location = new System.Drawing.Point(172, 64);
            this.lblStereoPanningAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStereoPanningAngle.Name = "lblStereoPanningAngle";
            this.lblStereoPanningAngle.Size = new System.Drawing.Size(125, 17);
            this.lblStereoPanningAngle.TabIndex = 1;
            this.lblStereoPanningAngle.Text = "(Angle in degrees)";
            // 
            // radStereoDisabled
            // 
            this.radStereoDisabled.AutoSize = true;
            this.radStereoDisabled.Checked = true;
            this.radStereoDisabled.Location = new System.Drawing.Point(4, 4);
            this.radStereoDisabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radStereoDisabled.Name = "radStereoDisabled";
            this.radStereoDisabled.Size = new System.Drawing.Size(84, 21);
            this.radStereoDisabled.TabIndex = 1;
            this.radStereoDisabled.TabStop = true;
            this.radStereoDisabled.Tag = "None";
            this.radStereoDisabled.Text = "Disabled";
            this.radStereoDisabled.UseVisualStyleBackColor = true;
            // 
            // radStereoDelay
            // 
            this.radStereoDelay.AutoSize = true;
            this.radStereoDelay.Location = new System.Drawing.Point(4, 33);
            this.radStereoDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radStereoDelay.Name = "radStereoDelay";
            this.radStereoDelay.Size = new System.Drawing.Size(65, 21);
            this.radStereoDelay.TabIndex = 2;
            this.radStereoDelay.TabStop = true;
            this.radStereoDelay.Tag = "Delay";
            this.radStereoDelay.Text = "Delay";
            this.radStereoDelay.UseVisualStyleBackColor = true;
            // 
            // radStereoPanning
            // 
            this.radStereoPanning.AutoSize = true;
            this.radStereoPanning.Location = new System.Drawing.Point(4, 62);
            this.radStereoPanning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radStereoPanning.Name = "radStereoPanning";
            this.radStereoPanning.Size = new System.Drawing.Size(81, 21);
            this.radStereoPanning.TabIndex = 3;
            this.radStereoPanning.TabStop = true;
            this.radStereoPanning.Tag = "Panning";
            this.radStereoPanning.Text = "Panning";
            this.radStereoPanning.UseVisualStyleBackColor = true;
            // 
            // nudStereoDelay
            // 
            this.nudStereoDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudStereoDelay.DecimalPlaces = 0;
            this.nudStereoDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStereoDelay.IsHex = false;
            this.nudStereoDelay.Location = new System.Drawing.Point(108, 30);
            this.nudStereoDelay.Margin = new System.Windows.Forms.Padding(0);
            this.nudStereoDelay.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudStereoDelay.MaximumSize = new System.Drawing.Size(13333, 26);
            this.nudStereoDelay.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudStereoDelay.MinimumSize = new System.Drawing.Size(0, 27);
            this.nudStereoDelay.Name = "nudStereoDelay";
            this.nudStereoDelay.Size = new System.Drawing.Size(60, 27);
            this.nudStereoDelay.TabIndex = 1;
            this.nudStereoDelay.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nudStereoPanning
            // 
            this.nudStereoPanning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudStereoPanning.DecimalPlaces = 0;
            this.nudStereoPanning.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStereoPanning.IsHex = false;
            this.nudStereoPanning.Location = new System.Drawing.Point(108, 59);
            this.nudStereoPanning.Margin = new System.Windows.Forms.Padding(0);
            this.nudStereoPanning.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudStereoPanning.MaximumSize = new System.Drawing.Size(13333, 26);
            this.nudStereoPanning.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudStereoPanning.MinimumSize = new System.Drawing.Size(0, 27);
            this.nudStereoPanning.Name = "nudStereoPanning";
            this.nudStereoPanning.Size = new System.Drawing.Size(60, 27);
            this.nudStereoPanning.TabIndex = 1;
            this.nudStereoPanning.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 7;
            this.tlpStereoFilter.SetColumnSpan(this.tableLayoutPanel9, 2);
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.nudStereoCombFilterStrength, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblStereoCombFilterMs, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.nudStereoCombFilterDelay, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblStereoCombFilterDelay, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblStereoCombFilterStrength, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblCombFilterPercent, 5, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(108, 87);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(496, 35);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // nudStereoCombFilterStrength
            // 
            this.nudStereoCombFilterStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudStereoCombFilterStrength.DecimalPlaces = 0;
            this.nudStereoCombFilterStrength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStereoCombFilterStrength.IsHex = false;
            this.nudStereoCombFilterStrength.Location = new System.Drawing.Point(247, 4);
            this.nudStereoCombFilterStrength.Margin = new System.Windows.Forms.Padding(0);
            this.nudStereoCombFilterStrength.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudStereoCombFilterStrength.MaximumSize = new System.Drawing.Size(13333, 26);
            this.nudStereoCombFilterStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStereoCombFilterStrength.MinimumSize = new System.Drawing.Size(0, 27);
            this.nudStereoCombFilterStrength.Name = "nudStereoCombFilterStrength";
            this.nudStereoCombFilterStrength.Size = new System.Drawing.Size(60, 27);
            this.nudStereoCombFilterStrength.TabIndex = 5;
            this.nudStereoCombFilterStrength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStereoCombFilterMs
            // 
            this.lblStereoCombFilterMs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStereoCombFilterMs.AutoSize = true;
            this.lblStereoCombFilterMs.Location = new System.Drawing.Point(120, 9);
            this.lblStereoCombFilterMs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStereoCombFilterMs.Name = "lblStereoCombFilterMs";
            this.lblStereoCombFilterMs.Size = new System.Drawing.Size(26, 17);
            this.lblStereoCombFilterMs.TabIndex = 3;
            this.lblStereoCombFilterMs.Text = "ms";
            // 
            // nudStereoCombFilterDelay
            // 
            this.nudStereoCombFilterDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudStereoCombFilterDelay.DecimalPlaces = 0;
            this.nudStereoCombFilterDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStereoCombFilterDelay.IsHex = false;
            this.nudStereoCombFilterDelay.Location = new System.Drawing.Point(56, 4);
            this.nudStereoCombFilterDelay.Margin = new System.Windows.Forms.Padding(0);
            this.nudStereoCombFilterDelay.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudStereoCombFilterDelay.MaximumSize = new System.Drawing.Size(13333, 26);
            this.nudStereoCombFilterDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStereoCombFilterDelay.MinimumSize = new System.Drawing.Size(0, 27);
            this.nudStereoCombFilterDelay.Name = "nudStereoCombFilterDelay";
            this.nudStereoCombFilterDelay.Size = new System.Drawing.Size(60, 27);
            this.nudStereoCombFilterDelay.TabIndex = 2;
            this.nudStereoCombFilterDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStereoCombFilterDelay
            // 
            this.lblStereoCombFilterDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStereoCombFilterDelay.AutoSize = true;
            this.lblStereoCombFilterDelay.Location = new System.Drawing.Point(4, 9);
            this.lblStereoCombFilterDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStereoCombFilterDelay.Name = "lblStereoCombFilterDelay";
            this.lblStereoCombFilterDelay.Size = new System.Drawing.Size(48, 17);
            this.lblStereoCombFilterDelay.TabIndex = 0;
            this.lblStereoCombFilterDelay.Text = "Delay:";
            // 
            // lblStereoCombFilterStrength
            // 
            this.lblStereoCombFilterStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStereoCombFilterStrength.AutoSize = true;
            this.lblStereoCombFilterStrength.Location = new System.Drawing.Point(177, 9);
            this.lblStereoCombFilterStrength.Margin = new System.Windows.Forms.Padding(27, 0, 4, 0);
            this.lblStereoCombFilterStrength.Name = "lblStereoCombFilterStrength";
            this.lblStereoCombFilterStrength.Size = new System.Drawing.Size(66, 17);
            this.lblStereoCombFilterStrength.TabIndex = 4;
            this.lblStereoCombFilterStrength.Text = "Strength:";
            // 
            // lblCombFilterPercent
            // 
            this.lblCombFilterPercent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCombFilterPercent.AutoSize = true;
            this.lblCombFilterPercent.Location = new System.Drawing.Point(311, 9);
            this.lblCombFilterPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCombFilterPercent.Name = "lblCombFilterPercent";
            this.lblCombFilterPercent.Size = new System.Drawing.Size(20, 17);
            this.lblCombFilterPercent.TabIndex = 6;
            this.lblCombFilterPercent.Text = "%";
            // 
            // grpReverb
            // 
            this.grpReverb.Controls.Add(this.tableLayoutPanel5);
            this.grpReverb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReverb.Location = new System.Drawing.Point(4, 162);
            this.grpReverb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReverb.Name = "grpReverb";
            this.grpReverb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReverb.Size = new System.Drawing.Size(612, 139);
            this.grpReverb.TabIndex = 1;
            this.grpReverb.TabStop = false;
            this.grpReverb.Text = "Reverb";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.chkReverbEnabled, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblReverbStrength, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblReverbDelay, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.trkReverbDelay, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.trkReverbStrength, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(604, 115);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // chkReverbEnabled
            // 
            this.chkReverbEnabled.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.chkReverbEnabled, 2);
            this.chkReverbEnabled.Location = new System.Drawing.Point(4, 4);
            this.chkReverbEnabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkReverbEnabled.Name = "chkReverbEnabled";
            this.chkReverbEnabled.Size = new System.Drawing.Size(124, 21);
            this.chkReverbEnabled.TabIndex = 0;
            this.chkReverbEnabled.Text = "Enable Reverb";
            this.chkReverbEnabled.UseVisualStyleBackColor = true;
            // 
            // lblReverbStrength
            // 
            this.lblReverbStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReverbStrength.AutoSize = true;
            this.lblReverbStrength.Location = new System.Drawing.Point(4, 41);
            this.lblReverbStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReverbStrength.Name = "lblReverbStrength";
            this.lblReverbStrength.Size = new System.Drawing.Size(66, 17);
            this.lblReverbStrength.TabIndex = 2;
            this.lblReverbStrength.Text = "Strength:";
            // 
            // lblReverbDelay
            // 
            this.lblReverbDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReverbDelay.AutoSize = true;
            this.lblReverbDelay.Location = new System.Drawing.Point(4, 83);
            this.lblReverbDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReverbDelay.Name = "lblReverbDelay";
            this.lblReverbDelay.Size = new System.Drawing.Size(48, 17);
            this.lblReverbDelay.TabIndex = 3;
            this.lblReverbDelay.Text = "Delay:";
            // 
            // trkReverbDelay
            // 
            this.trkReverbDelay.Location = new System.Drawing.Point(78, 75);
            this.trkReverbDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkReverbDelay.Maximum = 30;
            this.trkReverbDelay.Minimum = 1;
            this.trkReverbDelay.Name = "trkReverbDelay";
            this.trkReverbDelay.Size = new System.Drawing.Size(128, 34);
            this.trkReverbDelay.TabIndex = 4;
            this.trkReverbDelay.TickFrequency = 3;
            this.trkReverbDelay.Value = 1;
            // 
            // trkReverbStrength
            // 
            this.trkReverbStrength.Location = new System.Drawing.Point(78, 33);
            this.trkReverbStrength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkReverbStrength.Minimum = 1;
            this.trkReverbStrength.Name = "trkReverbStrength";
            this.trkReverbStrength.Size = new System.Drawing.Size(128, 34);
            this.trkReverbStrength.TabIndex = 1;
            this.trkReverbStrength.Value = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.chkCrossFeedEnabled);
            this.flowLayoutPanel5.Controls.Add(this.nudCrossFeedRatio);
            this.flowLayoutPanel5.Controls.Add(this.lblCrossFeedRatio);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(8, 305);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(612, 32);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // chkCrossFeedEnabled
            // 
            this.chkCrossFeedEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkCrossFeedEnabled.AutoSize = true;
            this.chkCrossFeedEnabled.Location = new System.Drawing.Point(4, 7);
            this.chkCrossFeedEnabled.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.chkCrossFeedEnabled.Name = "chkCrossFeedEnabled";
            this.chkCrossFeedEnabled.Size = new System.Drawing.Size(146, 21);
            this.chkCrossFeedEnabled.TabIndex = 1;
            this.chkCrossFeedEnabled.Text = "Enable Crossfeed:";
            this.chkCrossFeedEnabled.UseVisualStyleBackColor = true;
            // 
            // nudCrossFeedRatio
            // 
            this.nudCrossFeedRatio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCrossFeedRatio.DecimalPlaces = 0;
            this.nudCrossFeedRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCrossFeedRatio.IsHex = false;
            this.nudCrossFeedRatio.Location = new System.Drawing.Point(154, 2);
            this.nudCrossFeedRatio.Margin = new System.Windows.Forms.Padding(0);
            this.nudCrossFeedRatio.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCrossFeedRatio.MaximumSize = new System.Drawing.Size(13333, 26);
            this.nudCrossFeedRatio.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCrossFeedRatio.MinimumSize = new System.Drawing.Size(0, 27);
            this.nudCrossFeedRatio.Name = "nudCrossFeedRatio";
            this.nudCrossFeedRatio.Size = new System.Drawing.Size(56, 27);
            this.nudCrossFeedRatio.TabIndex = 2;
            this.nudCrossFeedRatio.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblCrossFeedRatio
            // 
            this.lblCrossFeedRatio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCrossFeedRatio.AutoSize = true;
            this.lblCrossFeedRatio.Location = new System.Drawing.Point(214, 7);
            this.lblCrossFeedRatio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrossFeedRatio.Name = "lblCrossFeedRatio";
            this.lblCrossFeedRatio.Size = new System.Drawing.Size(20, 17);
            this.lblCrossFeedRatio.TabIndex = 3;
            this.lblCrossFeedRatio.Text = "%";
            // 
            // tpgAdvanced
            // 
            this.tpgAdvanced.Controls.Add(this.tableLayoutPanel3);
            this.tpgAdvanced.Location = new System.Drawing.Point(4, 26);
            this.tpgAdvanced.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgAdvanced.Name = "tpgAdvanced";
            this.tpgAdvanced.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgAdvanced.Size = new System.Drawing.Size(628, 521);
            this.tpgAdvanced.TabIndex = 2;
            this.tpgAdvanced.Text = "Advanced";
            this.tpgAdvanced.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.chkDisableDynamicSampleRate, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkDisableNoiseModeFlag, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.nudEPSMClockFrequency, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblEPSMClockFrequency, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.chkSilenceTriangleHighFreq, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkSwapDutyCycles, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.chkReduceDmcPopping, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(620, 513);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // chkDisableDynamicSampleRate
            // 
            this.chkDisableDynamicSampleRate.Checked = false;
            this.chkDisableDynamicSampleRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDisableDynamicSampleRate.Location = new System.Drawing.Point(0, 62);
            this.chkDisableDynamicSampleRate.Name = "chkDisableDynamicSampleRate";
            this.chkDisableDynamicSampleRate.Size = new System.Drawing.Size(620, 31);
            this.chkDisableDynamicSampleRate.TabIndex = 4;
            this.chkDisableDynamicSampleRate.Text = "Disable dynamic sample rate";
            // 
            // chkDisableNoiseModeFlag
            // 
            this.chkDisableNoiseModeFlag.Checked = false;
            this.chkDisableNoiseModeFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDisableNoiseModeFlag.Location = new System.Drawing.Point(0, 124);
            this.chkDisableNoiseModeFlag.Name = "chkDisableNoiseModeFlag";
            this.chkDisableNoiseModeFlag.Size = new System.Drawing.Size(620, 31);
            this.chkDisableNoiseModeFlag.TabIndex = 3;
            this.chkDisableNoiseModeFlag.Text = "Disable noise channel mode flag";
            // 
            // nudEPSMClockFrequency
            // 
            this.nudEPSMClockFrequency.DecimalPlaces = 0;
            this.nudEPSMClockFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEPSMClockFrequency.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudEPSMClockFrequency.IsHex = false;
            this.nudEPSMClockFrequency.Location = new System.Drawing.Point(4, 190);
            this.nudEPSMClockFrequency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudEPSMClockFrequency.Maximum = new decimal(new int[] {
            32000000,
            0,
            0,
            0});
            this.nudEPSMClockFrequency.MaximumSize = new System.Drawing.Size(13333, 26);
            this.nudEPSMClockFrequency.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEPSMClockFrequency.MinimumSize = new System.Drawing.Size(267, 27);
            this.nudEPSMClockFrequency.Name = "nudEPSMClockFrequency";
            this.nudEPSMClockFrequency.Size = new System.Drawing.Size(612, 27);
            this.nudEPSMClockFrequency.TabIndex = 3;
            this.nudEPSMClockFrequency.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblEPSMClockFrequency
            // 
            this.lblEPSMClockFrequency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEPSMClockFrequency.AutoSize = true;
            this.lblEPSMClockFrequency.Location = new System.Drawing.Point(4, 162);
            this.lblEPSMClockFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEPSMClockFrequency.Name = "lblEPSMClockFrequency";
            this.lblEPSMClockFrequency.Size = new System.Drawing.Size(303, 17);
            this.lblEPSMClockFrequency.TabIndex = 3;
            this.lblEPSMClockFrequency.Text = "EPSM Clock Frequency (default is 8000000Hz)";
            // 
            // chkSilenceTriangleHighFreq
            // 
            this.chkSilenceTriangleHighFreq.AutoSize = true;
            this.chkSilenceTriangleHighFreq.Location = new System.Drawing.Point(4, 4);
            this.chkSilenceTriangleHighFreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSilenceTriangleHighFreq.Name = "chkSilenceTriangleHighFreq";
            this.chkSilenceTriangleHighFreq.Size = new System.Drawing.Size(449, 21);
            this.chkSilenceTriangleHighFreq.TabIndex = 1;
            this.chkSilenceTriangleHighFreq.Text = "Mute ultrasonic frequencies on triangle channel (reduces popping)";
            // 
            // chkSwapDutyCycles
            // 
            this.chkSwapDutyCycles.Checked = false;
            this.chkSwapDutyCycles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSwapDutyCycles.Location = new System.Drawing.Point(0, 93);
            this.chkSwapDutyCycles.Name = "chkSwapDutyCycles";
            this.chkSwapDutyCycles.Size = new System.Drawing.Size(620, 31);
            this.chkSwapDutyCycles.TabIndex = 0;
            this.chkSwapDutyCycles.Text = "Swap square channels duty cycles (Mimics old clones)";
            // 
            // chkReduceDmcPopping
            // 
            this.chkReduceDmcPopping.AutoSize = true;
            this.chkReduceDmcPopping.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkReduceDmcPopping.Location = new System.Drawing.Point(4, 35);
            this.chkReduceDmcPopping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkReduceDmcPopping.Name = "chkReduceDmcPopping";
            this.chkReduceDmcPopping.Size = new System.Drawing.Size(316, 21);
            this.chkReduceDmcPopping.TabIndex = 2;
            this.chkReduceDmcPopping.Text = "Reduce popping sounds on the DMC channel";
            this.chkReduceDmcPopping.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkReduceDmcPopping.UseVisualStyleBackColor = true;
            // 
            // frmAudioConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 588);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Audio Options";
            this.Controls.SetChildIndex(this.baseConfigPanel, 0);
            this.Controls.SetChildIndex(this.tabMain, 0);
            this.baseConfigPanel.ResumeLayout(false);
            this.baseConfigPanel.PerformLayout();
            this.grpVolume.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLatencyWarning)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tpgGeneral.ResumeLayout(false);
            this.tpgVolume.ResumeLayout(false);
            this.tpgPanning.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tpgEqualizer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tlpEqualizer.ResumeLayout(false);
            this.tlpEqualizer.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.tpgEffects.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.grpStereo.ResumeLayout(false);
            this.tlpStereoFilter.ResumeLayout(false);
            this.tlpStereoFilter.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.grpReverb.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkReverbDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkReverbStrength)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tpgAdvanced.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpVolume;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.CheckBox chkEnableAudio;
		private System.Windows.Forms.CheckBox chkEnableEPSM;
		private System.Windows.Forms.Label lblAudioLatency;
		private MesenNumericUpDown nudLatency;
		private System.Windows.Forms.Label lblLatencyMs;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblSampleRate;
		private System.Windows.Forms.ComboBox cboSampleRate;
		private System.Windows.Forms.Label lblAudioDevice;
		private System.Windows.Forms.ComboBox cboAudioDevice;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Controls.ctrlTrackbar trkDmcVol;
		private Controls.ctrlTrackbar trkNoiseVol;
		private Controls.ctrlTrackbar trkTriangleVol;
		private Controls.ctrlTrackbar trkSquare2Vol;
		private Controls.ctrlTrackbar trkSquare1Vol;
		private Controls.ctrlTrackbar trkMaster;
		private Controls.ctrlTrackbar trkFdsVol;
		private Controls.ctrlTrackbar trkMmc5Vol;
		private Controls.ctrlTrackbar trkVrc6Vol;
		private Controls.ctrlTrackbar trkVrc7Vol;
		private Controls.ctrlTrackbar trkNamco163Vol;
		private Controls.ctrlTrackbar trkSunsoft5b;
		private Controls.ctrlTrackbar trkEPSMVol_L;
		private Controls.ctrlTrackbar trkEPSMVol_R;
	  private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tpgGeneral;
		private System.Windows.Forms.TabPage tpgVolume;
		private System.Windows.Forms.CheckBox chkReduceSoundInBackground;
		private System.Windows.Forms.TabPage tpgAdvanced;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private ctrlRiskyOption chkSwapDutyCycles;
		private System.Windows.Forms.TabPage tpgEffects;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.GroupBox grpStereo;
		private System.Windows.Forms.TableLayoutPanel tlpStereoFilter;
		private MesenNumericUpDown nudStereoDelay;
		private System.Windows.Forms.Label lblStereoDelayMs;
		private System.Windows.Forms.RadioButton radStereoDisabled;
		private System.Windows.Forms.RadioButton radStereoDelay;
		private System.Windows.Forms.RadioButton radStereoPanning;
		private MesenNumericUpDown nudStereoPanning;
		private System.Windows.Forms.Label lblStereoPanningAngle;
		private System.Windows.Forms.GroupBox grpReverb;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.CheckBox chkReverbEnabled;
		private System.Windows.Forms.Label lblReverbStrength;
		private System.Windows.Forms.Label lblReverbDelay;
		private System.Windows.Forms.TrackBar trkReverbDelay;
		private System.Windows.Forms.TrackBar trkReverbStrength;
		private System.Windows.Forms.CheckBox chkSilenceTriangleHighFreq;
		private System.Windows.Forms.CheckBox chkReduceDmcPopping;
		private System.Windows.Forms.PictureBox picLatencyWarning;
		private System.Windows.Forms.Label lblLatencyWarning;
		private System.Windows.Forms.TabPage tpgPanning;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private Controls.ctrlHorizontalTrackbar trkDmcPan;
		private Controls.ctrlHorizontalTrackbar trkNoisePan;
		private Controls.ctrlHorizontalTrackbar trkSquare2Pan;
		private Controls.ctrlHorizontalTrackbar trkFdsPan;
		private Controls.ctrlHorizontalTrackbar trkMmc5Pan;
		private Controls.ctrlHorizontalTrackbar trkVrc6Pan;
		private Controls.ctrlHorizontalTrackbar trkVrc7Pan;
		private Controls.ctrlHorizontalTrackbar trkNamcoPan;
		private Controls.ctrlHorizontalTrackbar trkSunsoftPan;
		private Controls.ctrlHorizontalTrackbar trkEPSMPan_L;
		private Controls.ctrlHorizontalTrackbar trkEPSMPan_R;
		private Controls.ctrlHorizontalTrackbar trkSquare1Pan;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.CheckBox chkCrossFeedEnabled;
		private MesenNumericUpDown nudCrossFeedRatio;
		private System.Windows.Forms.Label lblCrossFeedRatio;
		private Controls.ctrlHorizontalTrackbar trkTrianglePan;
		private ctrlRiskyOption chkDisableNoiseModeFlag;
		private MesenNumericUpDown nudEPSMClockFrequency;
		private System.Windows.Forms.Label lblEPSMClockFrequency;
		private System.Windows.Forms.TabPage tpgEqualizer;
		private System.Windows.Forms.TableLayoutPanel tlpEqualizer;
		private ctrlTrackbar trkBand6Gain;
		private ctrlTrackbar trkBand5Gain;
		private ctrlTrackbar trkBand4Gain;
		private ctrlTrackbar trkBand3Gain;
		private ctrlTrackbar trkBand2Gain;
		private ctrlTrackbar trkBand1Gain;
		private ctrlTrackbar trkBand11Gain;
		private ctrlTrackbar trkBand12Gain;
		private ctrlTrackbar trkBand13Gain;
		private ctrlTrackbar trkBand14Gain;
		private ctrlTrackbar trkBand15Gain;
		private ctrlTrackbar trkBand16Gain;
		private ctrlTrackbar trkBand7Gain;
		private ctrlTrackbar trkBand8Gain;
		private ctrlTrackbar trkBand9Gain;
		private ctrlTrackbar trkBand10Gain;
		private ctrlTrackbar trkBand17Gain;
		private ctrlTrackbar trkBand18Gain;
		private ctrlTrackbar trkBand19Gain;
		private ctrlTrackbar trkBand20Gain;
		private System.Windows.Forms.Label lblEqualizerFilterType;
		private System.Windows.Forms.ComboBox cboEqualizerFilterType;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkEnableEqualizer;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		private System.Windows.Forms.Label lblEqualizerPreset;
		private System.Windows.Forms.ComboBox cboEqualizerPreset;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.CheckBox chkReduceSoundInFastForward;
		private System.Windows.Forms.Label lblVolumeReductionSettings;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private ctrlHorizontalTrackbar trkVolumeReduction;
		private System.Windows.Forms.CheckBox chkMuteSoundInBackground;
		private ctrlRiskyOption chkDisableDynamicSampleRate;
		private System.Windows.Forms.RadioButton radStereoCombFilter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private MesenNumericUpDown nudStereoCombFilterStrength;
		private System.Windows.Forms.Label lblStereoCombFilterMs;
		private MesenNumericUpDown nudStereoCombFilterDelay;
		private System.Windows.Forms.Label lblStereoCombFilterDelay;
		private System.Windows.Forms.Label lblStereoCombFilterStrength;
		private System.Windows.Forms.Label lblCombFilterPercent;
	}
}