

namespace RAMLite
{
    partial class Mainform
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxRAM = new System.Windows.Forms.GroupBox();
            this.Utilizzo = new System.Windows.Forms.ProgressBar();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalMemory = new System.Windows.Forms.Label();
            this.AvailableMemory = new System.Windows.Forms.Label();
            this.ButtonCleanMemory = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.automazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.btnFerma = new System.Windows.Forms.Button();
            this.btn_Avvia = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.edtMinima = new System.Windows.Forms.TextBox();
            this.TimerAuto = new System.Windows.Forms.Timer(this.components);
            this.groupBoxCpu = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCpuUsage = new System.Windows.Forms.Label();
            this.gameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxRAM.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxAuto.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxCpu.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.ContextMenuStrip = this.ContextMenuStrip;
            this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
            this.SystemTrayIcon.Text = "RamLite";
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIcon_DoubleClick);
            // 
            // CheckForUpdatesToolStripMenuItem
            // 
            this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
            this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ExitToolStripMenuItem.Text = "Exit RamLite";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // GroupBoxRAM
            // 
            this.GroupBoxRAM.Controls.Add(this.Utilizzo);
            this.GroupBoxRAM.Controls.Add(this.TableLayoutPanel2);
            this.GroupBoxRAM.Controls.Add(this.ButtonCleanMemory);
            this.GroupBoxRAM.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxRAM.Name = "GroupBoxRAM";
            this.GroupBoxRAM.Size = new System.Drawing.Size(216, 135);
            this.GroupBoxRAM.TabIndex = 24;
            this.GroupBoxRAM.TabStop = false;
            this.GroupBoxRAM.Text = "RAM";
            // 
            // Utilizzo
            // 
            this.Utilizzo.Location = new System.Drawing.Point(30, 70);
            this.Utilizzo.Name = "Utilizzo";
            this.Utilizzo.Size = new System.Drawing.Size(143, 20);
            this.Utilizzo.TabIndex = 26;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel2.Controls.Add(this.TotalMemory, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.AvailableMemory, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(30, 19);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 2;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(143, 45);
            this.TableLayoutPanel2.TabIndex = 30;
            // 
            // TotalMemory
            // 
            this.TotalMemory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalMemory.AutoSize = true;
            this.TotalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMemory.Location = new System.Drawing.Point(3, 25);
            this.TotalMemory.Name = "TotalMemory";
            this.TotalMemory.Size = new System.Drawing.Size(112, 17);
            this.TotalMemory.TabIndex = 28;
            this.TotalMemory.Text = "Total: 16384 MB";
            this.TotalMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvailableMemory
            // 
            this.AvailableMemory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailableMemory.AutoSize = true;
            this.AvailableMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableMemory.Location = new System.Drawing.Point(3, 2);
            this.AvailableMemory.Name = "AvailableMemory";
            this.AvailableMemory.Size = new System.Drawing.Size(137, 17);
            this.AvailableMemory.TabIndex = 27;
            this.AvailableMemory.Text = "Available: 12288 MB";
            this.AvailableMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCleanMemory
            // 
            this.ButtonCleanMemory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCleanMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanMemory.Location = new System.Drawing.Point(30, 96);
            this.ButtonCleanMemory.Name = "ButtonCleanMemory";
            this.ButtonCleanMemory.Size = new System.Drawing.Size(143, 23);
            this.ButtonCleanMemory.TabIndex = 28;
            this.ButtonCleanMemory.Text = "Clean memory";
            this.ButtonCleanMemory.UseVisualStyleBackColor = true;
            this.ButtonCleanMemory.Click += new System.EventHandler(this.ButtonCleanMemory_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.automazioneToolStripMenuItem,
            this.cpuToolStripMenuItem,
            this.gameModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.settingsToolStripMenuItem.Text = "Opzioni";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSettings_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem1.Text = "Esci";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // automazioneToolStripMenuItem
            // 
            this.automazioneToolStripMenuItem.Name = "automazioneToolStripMenuItem";
            this.automazioneToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.automazioneToolStripMenuItem.Text = "Automazione";
            this.automazioneToolStripMenuItem.Click += new System.EventHandler(this.automazioneToolStripMenuItem_Click);
            // 
            // cpuToolStripMenuItem
            // 
            this.cpuToolStripMenuItem.Name = "cpuToolStripMenuItem";
            this.cpuToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.cpuToolStripMenuItem.Text = "Cpu";
            this.cpuToolStripMenuItem.Click += new System.EventHandler(this.cpuToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckForUpdatesToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "ContextMenuStrip";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.Controls.Add(this.btnFerma);
            this.groupBoxAuto.Controls.Add(this.btn_Avvia);
            this.groupBoxAuto.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAuto.Location = new System.Drawing.Point(12, 168);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(216, 105);
            this.groupBoxAuto.TabIndex = 26;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "Automazione";
            // 
            // btnFerma
            // 
            this.btnFerma.Image = global::RAMLite.Properties.Resources.pause_16px1;
            this.btnFerma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFerma.Location = new System.Drawing.Point(111, 70);
            this.btnFerma.Name = "btnFerma";
            this.btnFerma.Size = new System.Drawing.Size(59, 23);
            this.btnFerma.TabIndex = 31;
            this.btnFerma.Text = "Ferma";
            this.btnFerma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFerma.UseVisualStyleBackColor = true;
            this.btnFerma.Click += new System.EventHandler(this.btnFerma_Click_1);
            // 
            // btn_Avvia
            // 
            this.btn_Avvia.Image = global::RAMLite.Properties.Resources.play_16px;
            this.btn_Avvia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Avvia.Location = new System.Drawing.Point(33, 70);
            this.btn_Avvia.Name = "btn_Avvia";
            this.btn_Avvia.Size = new System.Drawing.Size(56, 23);
            this.btn_Avvia.TabIndex = 27;
            this.btn_Avvia.Text = "Avvia";
            this.btn_Avvia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Avvia.UseVisualStyleBackColor = true;
            this.btn_Avvia.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.edtMinima, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(143, 45);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ram Minima (mb) ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // edtMinima
            // 
            this.edtMinima.Location = new System.Drawing.Point(3, 25);
            this.edtMinima.Name = "edtMinima";
            this.edtMinima.Size = new System.Drawing.Size(137, 20);
            this.edtMinima.TabIndex = 28;
            // 
            // TimerAuto
            // 
            this.TimerAuto.Tick += new System.EventHandler(this.TimerAuto_Tick);
            // 
            // groupBoxCpu
            // 
            this.groupBoxCpu.Controls.Add(this.progressBar1);
            this.groupBoxCpu.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxCpu.Location = new System.Drawing.Point(245, 27);
            this.groupBoxCpu.Name = "groupBoxCpu";
            this.groupBoxCpu.Size = new System.Drawing.Size(131, 135);
            this.groupBoxCpu.TabIndex = 27;
            this.groupBoxCpu.TabStop = false;
            this.groupBoxCpu.Text = "CPU";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(69, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 26;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblCpuUsage, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(30, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(69, 45);
            this.tableLayoutPanel3.TabIndex = 30;
            // 
            // lblCpuUsage
            // 
            this.lblCpuUsage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCpuUsage.AutoSize = true;
            this.lblCpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuUsage.Location = new System.Drawing.Point(3, 2);
            this.lblCpuUsage.Name = "lblCpuUsage";
            this.lblCpuUsage.Size = new System.Drawing.Size(61, 17);
            this.lblCpuUsage.TabIndex = 28;
            this.lblCpuUsage.Text = "Usage%";
            this.lblCpuUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameModeToolStripMenuItem
            // 
            this.gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            this.gameModeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gameModeToolStripMenuItem.Text = "Game Mode";
            this.gameModeToolStripMenuItem.Click += new System.EventHandler(this.gameModeToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 286);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBoxCpu);
            this.Controls.Add(this.groupBoxAuto);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GroupBoxRAM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RamLite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.GroupBoxRAM.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxAuto.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxCpu.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBoxRAM;
        private System.Windows.Forms.Button ButtonCleanMemory;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        private System.Windows.Forms.Label TotalMemory;
        private System.Windows.Forms.Label AvailableMemory;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ProgressBar Utilizzo;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtMinima;
        private System.Windows.Forms.Timer TimerAuto;
        private System.Windows.Forms.ToolStripMenuItem automazioneToolStripMenuItem;
        private System.Windows.Forms.Button btn_Avvia;
        private System.Windows.Forms.Button btnFerma;
        private System.Windows.Forms.ToolStripMenuItem cpuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCpu;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.ToolStripMenuItem gameModeToolStripMenuItem;
    }
}