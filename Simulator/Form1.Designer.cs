
namespace Simulator
{
    partial class MainUI
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ScenarioPath = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.ConfigFilePath = new MetroFramework.Controls.MetroTextBox();
            this.ScenarioProgress = new MetroFramework.Controls.MetroProgressBar();
            this.Log = new MetroFramework.Controls.MetroTextBox();
            this.RunSimulationButton = new MetroFramework.Controls.MetroButton();
            this.ConfigStateLabel = new MetroFramework.Controls.MetroLabel();
            this.ClearLog = new MetroFramework.Controls.MetroButton();
            this.OpenScenarioFile = new System.Windows.Forms.OpenFileDialog();
            this.OpenConfigFile = new System.Windows.Forms.OpenFileDialog();
            this.bw_main = new System.ComponentModel.BackgroundWorker();
            this.logger_main = new System.ComponentModel.BackgroundWorker();
            this.progress_main = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ScenarioPath
            // 
            this.ScenarioPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ScenarioPath.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.ScenarioPath.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.ScenarioPath.CustomButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScenarioPath.CustomButton.Image = null;
            this.ScenarioPath.CustomButton.Location = new System.Drawing.Point(391, 2);
            this.ScenarioPath.CustomButton.Name = "";
            this.ScenarioPath.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ScenarioPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ScenarioPath.CustomButton.TabIndex = 1;
            this.ScenarioPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ScenarioPath.CustomButton.UseSelectable = true;
            this.ScenarioPath.CustomButton.UseVisualStyleBackColor = false;
            this.ScenarioPath.DisplayIcon = true;
            this.ScenarioPath.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ScenarioPath.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.ScenarioPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScenarioPath.Lines = new string[] {
        "Scenario File"};
            this.ScenarioPath.Location = new System.Drawing.Point(59, 108);
            this.ScenarioPath.MaxLength = 32767;
            this.ScenarioPath.Name = "ScenarioPath";
            this.ScenarioPath.PasswordChar = '\0';
            this.ScenarioPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ScenarioPath.SelectedText = "";
            this.ScenarioPath.SelectionLength = 0;
            this.ScenarioPath.SelectionStart = 0;
            this.ScenarioPath.ShortcutsEnabled = true;
            this.ScenarioPath.ShowButton = true;
            this.ScenarioPath.ShowClearButton = true;
            this.ScenarioPath.Size = new System.Drawing.Size(425, 36);
            this.ScenarioPath.Style = MetroFramework.MetroColorStyle.Silver;
            this.ScenarioPath.TabIndex = 0;
            this.ScenarioPath.Text = "Scenario File";
            this.ScenarioPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ScenarioPath.UseSelectable = true;
            this.ScenarioPath.UseStyleColors = true;
            this.ScenarioPath.WaterMarkColor = System.Drawing.Color.Transparent;
            this.ScenarioPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScenarioPath.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.ScenarioPath_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(26, 57);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(352, 10);
            this.metroTile1.TabIndex = 100;
            this.metroTile1.TabStop = false;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // ConfigFilePath
            // 
            // 
            // 
            // 
            this.ConfigFilePath.CustomButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConfigFilePath.CustomButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfigFilePath.CustomButton.Image = null;
            this.ConfigFilePath.CustomButton.Location = new System.Drawing.Point(391, 2);
            this.ConfigFilePath.CustomButton.Name = "";
            this.ConfigFilePath.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ConfigFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.White;
            this.ConfigFilePath.CustomButton.TabIndex = 1;
            this.ConfigFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConfigFilePath.CustomButton.UseSelectable = true;
            this.ConfigFilePath.DisplayIcon = true;
            this.ConfigFilePath.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ConfigFilePath.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.ConfigFilePath.Lines = new string[] {
        "Config File"};
            this.ConfigFilePath.Location = new System.Drawing.Point(59, 171);
            this.ConfigFilePath.MaxLength = 32767;
            this.ConfigFilePath.Name = "ConfigFilePath";
            this.ConfigFilePath.PasswordChar = '\0';
            this.ConfigFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConfigFilePath.SelectedText = "";
            this.ConfigFilePath.SelectionLength = 0;
            this.ConfigFilePath.SelectionStart = 0;
            this.ConfigFilePath.ShortcutsEnabled = true;
            this.ConfigFilePath.ShowButton = true;
            this.ConfigFilePath.ShowClearButton = true;
            this.ConfigFilePath.Size = new System.Drawing.Size(425, 36);
            this.ConfigFilePath.Style = MetroFramework.MetroColorStyle.Silver;
            this.ConfigFilePath.TabIndex = 4;
            this.ConfigFilePath.Text = "Config File";
            this.ConfigFilePath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConfigFilePath.UseSelectable = true;
            this.ConfigFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConfigFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigFilePath.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.ConfigFilePath_ButtonClick);
            // 
            // ScenarioProgress
            // 
            this.ScenarioProgress.FontSize = MetroFramework.MetroProgressBarSize.Tall;
            this.ScenarioProgress.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.ScenarioProgress.HideProgressText = false;
            this.ScenarioProgress.Location = new System.Drawing.Point(524, 108);
            this.ScenarioProgress.Name = "ScenarioProgress";
            this.ScenarioProgress.Size = new System.Drawing.Size(383, 36);
            this.ScenarioProgress.Style = MetroFramework.MetroColorStyle.Blue;
            this.ScenarioProgress.TabIndex = 7;
            this.ScenarioProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScenarioProgress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ScenarioProgress.UseCustomBackColor = true;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // 
            // 
            this.Log.CustomButton.Image = null;
            this.Log.CustomButton.Location = new System.Drawing.Point(628, 1);
            this.Log.CustomButton.Name = "";
            this.Log.CustomButton.Size = new System.Drawing.Size(219, 219);
            this.Log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Log.CustomButton.TabIndex = 1;
            this.Log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Log.CustomButton.UseSelectable = true;
            this.Log.CustomButton.Visible = false;
            this.Log.DisplayIcon = true;
            this.Log.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Log.ForeColor = System.Drawing.Color.Transparent;
            this.Log.Lines = new string[0];
            this.Log.Location = new System.Drawing.Point(59, 313);
            this.Log.MaxLength = 32767;
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.PasswordChar = '\0';
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.SelectedText = "";
            this.Log.SelectionLength = 0;
            this.Log.SelectionStart = 0;
            this.Log.ShortcutsEnabled = true;
            this.Log.ShowClearButton = true;
            this.Log.Size = new System.Drawing.Size(848, 221);
            this.Log.Style = MetroFramework.MetroColorStyle.Blue;
            this.Log.TabIndex = 2;
            this.Log.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Log.UseSelectable = true;
            this.Log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // RunSimulationButton
            // 
            this.RunSimulationButton.DisplayFocus = true;
            this.RunSimulationButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.RunSimulationButton.Highlight = true;
            this.RunSimulationButton.Location = new System.Drawing.Point(327, 230);
            this.RunSimulationButton.Name = "RunSimulationButton";
            this.RunSimulationButton.Size = new System.Drawing.Size(326, 60);
            this.RunSimulationButton.TabIndex = 1;
            this.RunSimulationButton.Text = "RUN";
            this.RunSimulationButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RunSimulationButton.UseSelectable = true;
            this.RunSimulationButton.Click += new System.EventHandler(this.RunSimulationButton_Click);
            // 
            // ConfigStateLabel
            // 
            this.ConfigStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConfigStateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ConfigStateLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ConfigStateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfigStateLabel.Location = new System.Drawing.Point(524, 182);
            this.ConfigStateLabel.Name = "ConfigStateLabel";
            this.ConfigStateLabel.Size = new System.Drawing.Size(300, 25);
            this.ConfigStateLabel.Style = MetroFramework.MetroColorStyle.White;
            this.ConfigStateLabel.TabIndex = 4;
            this.ConfigStateLabel.Text = "ConfigState = None";
            this.ConfigStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfigStateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConfigStateLabel.WrapToLine = true;
            // 
            // ClearLog
            // 
            this.ClearLog.DisplayFocus = true;
            this.ClearLog.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ClearLog.Highlight = true;
            this.ClearLog.Location = new System.Drawing.Point(762, 243);
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(145, 36);
            this.ClearLog.TabIndex = 7;
            this.ClearLog.Text = "Clear Logs";
            this.ClearLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ClearLog.UseSelectable = true;
            this.ClearLog.Click += new System.EventHandler(this.ClearLog_Click);
            // 
            // OpenScenarioFile
            // 
            this.OpenScenarioFile.Filter = "Scenario File|*.csv|All Files|*.*";
            this.OpenScenarioFile.InitialDirectory = ".\\";
            this.OpenScenarioFile.RestoreDirectory = true;
            // 
            // OpenConfigFile
            // 
            this.OpenConfigFile.Filter = "Config File|*.xml|All Files|*.*";
            this.OpenConfigFile.InitialDirectory = ".\\";
            this.OpenConfigFile.RestoreDirectory = true;
            // 
            // bw_main
            // 
            this.bw_main.WorkerReportsProgress = true;
            // 
            // progress_main
            // 
            this.progress_main.WorkerReportsProgress = true;
            this.progress_main.WorkerSupportsCancellation = true;
            this.progress_main.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.progress_main_ProgressChanged);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.ConfigStateLabel);
            this.Controls.Add(this.ClearLog);
            this.Controls.Add(this.RunSimulationButton);
            this.Controls.Add(this.ScenarioProgress);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.ConfigFilePath);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.ScenarioPath);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainUI";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Built In System Simlator v1.00";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox ScenarioPath;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox ConfigFilePath;
        private MetroFramework.Controls.MetroProgressBar ScenarioProgress;
        private MetroFramework.Controls.MetroTextBox Log;
        private MetroFramework.Controls.MetroButton RunSimulationButton;
        private MetroFramework.Controls.MetroLabel ConfigStateLabel;
        private MetroFramework.Controls.MetroButton ClearLog;
        private System.Windows.Forms.OpenFileDialog OpenScenarioFile;
        private System.Windows.Forms.OpenFileDialog OpenConfigFile;
        private System.ComponentModel.BackgroundWorker bw_main;
        private System.ComponentModel.BackgroundWorker logger_main;
        private System.ComponentModel.BackgroundWorker progress_main;
    }
}

