

using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Threading;

namespace RAMLite
{
    public partial class SettingsForm : Form
    {
        RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\RamLite", true);
        Boolean Flag;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void HotkeyToCleanMemory_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode.ToString() == "ShiftKey")
                {
                }
                else
                {
                    HotkeyToCleanMemory.Text = "Shift + " + e.KeyCode.ToString();
                }
            }
            else if (Control.ModifierKeys == Keys.Control)
            {
                if (e.KeyCode.ToString() == "ControlKey")
                {
                }
                else
                {
                    HotkeyToCleanMemory.Text = "Control + " + e.KeyCode.ToString();
                }
            }
            else if (Control.ModifierKeys == Keys.Alt)
            {
                if (e.KeyCode.ToString() == "Menu")
                {
                }
                else
                {
                    HotkeyToCleanMemory.Text = "Alt + " + e.KeyCode.ToString();
                }
            }
            else
            {
                HotkeyToCleanMemory.Text = e.KeyCode.ToString();
            }

            Settings.SetValue("HotkeyToCleanMemory", HotkeyToCleanMemory.Text, RegistryValueKind.String);
        }

        private void CheckBoxEnableClearingOfTheStandbyList_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableClearingOfTheStandbyList.Checked == true)
            {
                Settings.SetValue("EnableClearingOfTheStandbyList", "1", RegistryValueKind.String);
            }
            else if (CheckBoxEnableClearingOfTheStandbyList.Checked == false)
            {
                Settings.SetValue("EnableClearingOfTheStandbyList", "0", RegistryValueKind.String);
            }
        }

        private void CheckBoxEnableEmptyingOfTheWorkingSet_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableEmptyingOfTheWorkingSet.Checked == true)
            {
                Settings.SetValue("EnableEmptyingOfTheWorkingSet", "1", RegistryValueKind.String);
            }
            else if (CheckBoxEnableEmptyingOfTheWorkingSet.Checked == false)
            {
                Settings.SetValue("EnableEmptyingOfTheWorkingSet", "0", RegistryValueKind.String);
            }
        }

        private void DesiredTimerResolution_ValueChanged(object sender, EventArgs e)
        {
            Settings.SetValue("DesiredTimerResolution", DesiredTimerResolution.Value, RegistryValueKind.String);
        }

        private void CheckBoxEnableCustomTimerResolution_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableCustomTimerResolution.Checked == true)
            {
                Settings.SetValue("EnableCustomTimerResolution", "1", RegistryValueKind.String);
            }
            else if (CheckBoxEnableCustomTimerResolution.Checked == false)
            {
                Settings.SetValue("EnableCustomTimerResolution", "0", RegistryValueKind.String);
            }
        }

        private void TimerPollingInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.SetValue("TimerPollingInterval", TimerPollingInterval.Text, RegistryValueKind.String);
        }

        private void CheckBoxEnableTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableTimer.Checked == true)
            {
                Settings.SetValue("TimerEnabled", "1", RegistryValueKind.String);
            }
            else if (CheckBoxEnableTimer.Checked == false)
            {
                Settings.SetValue("TimerEnabled", "0", RegistryValueKind.String);
            }
        }

        private void CheckBoxStartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxStartMinimized.Checked == true)
            {
                Settings.SetValue("StartMinimized", "1", RegistryValueKind.String);
            }
            else if (CheckBoxStartMinimized.Checked == false)
            {
                Settings.SetValue("StartMinimized", "0", RegistryValueKind.String);
            }
        }

        private void CheckBoxStartTimerResolutionAutomatically_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxStartTimerResolutionAutomatically.Checked == true)
            {
                Settings.SetValue("StartTimerResolutionAutomatically", "1", RegistryValueKind.String);
            }
            else if (CheckBoxStartTimerResolutionAutomatically.Checked == false)
            {
                Settings.SetValue("StartTimerResolutionAutomatically", "0", RegistryValueKind.String);
            }
        }

        private void CheckBoxStartMemoryCleanerOnSystemStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxStartMemoryCleanerOnSystemStartup.Checked == true)
            {
                Settings.SetValue("StartMemoryCleanerOnSystemStartup", "1", RegistryValueKind.String);
            }
            else if (CheckBoxStartMemoryCleanerOnSystemStartup.Checked == false)
            {
                Settings.SetValue("StartMemoryCleanerOnSystemStartup", "0", RegistryValueKind.String);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Sicuro di voler resettare le impostazioni di fabrica?", "RamLite", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    {
                        Settings.SetValue("DesiredTimerResolution", "5000", RegistryValueKind.String);
                        DesiredTimerResolution.Value = 5000;

                        Settings.SetValue("EnableClearingOfTheStandbyList", "1", RegistryValueKind.String);
                        CheckBoxEnableClearingOfTheStandbyList.Checked = true;

                        Settings.SetValue("EnableCustomTimerResolution", "1", RegistryValueKind.String);
                        CheckBoxEnableTimer.Checked = true;

                        Settings.SetValue("EnableEmptyingOfTheWorkingSet", "1", RegistryValueKind.String);
                        CheckBoxEnableEmptyingOfTheWorkingSet.Checked = true;

                        Settings.SetValue("HotkeyToCleanMemory", "F10", RegistryValueKind.String);
                        HotkeyToCleanMemory.Text = "F10";

                        Settings.SetValue("StartMemoryCleanerOnSystemStartup", "0", RegistryValueKind.String);
                        CheckBoxStartMemoryCleanerOnSystemStartup.Checked = false;

                        Settings.SetValue("StartMinimized", "0", RegistryValueKind.String);
                        CheckBoxStartMinimized.Checked = false;

                        Settings.SetValue("StartTimerResolutionAutomatically", "0", RegistryValueKind.String);
                        CheckBoxStartTimerResolutionAutomatically.Checked = false;

                        Settings.SetValue("TimerEnabled", "1", RegistryValueKind.String);
                        CheckBoxEnableTimer.Checked = true;

                        Settings.SetValue("TimerPollingInterval", "1 sec", RegistryValueKind.String);
                        TimerPollingInterval.Text = "1 sec";

                        break;
                    }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mainform MainForm = (Mainform)Application.OpenForms["MainForm"];
            MainForm.SaveSettings();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs a = new KeyEventArgs(keyData);
            if (a.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void CheckBoxEnableEmptyingOfTheWorkingSet_MouseHover(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                Flag = true;
                tmrFlag.Interval = 2000;
                
                ShowToolTip("Pulizia della memoria RAM in uso sul pc, potrebbero verificarsi errori!");
              
                
            }
        }

        private void ShowToolTip( string message)
        {
            
            new ToolTip().Show(message, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 1000);
            
        }

        private void CheckBoxEnableClearingOfTheStandbyList_MouseHover(object sender, EventArgs e)
        {

            if (Flag == false)
            {
                Flag = true;
                tmrFlag.Interval = 2000;
                tmrFlag.Interval = 2000;
                tmrFlag.Start();
                ShowToolTip("Pulizia della memoria in standby. Riduce lo stutter in game e mantiene il sistema più reattivo");
            }
        }

        private void CheckBoxEnableClearingOfTheStandbyList_MouseLeave(object sender, EventArgs e)
        {
            tmrFlag.Start();
        }

        private void CheckBoxEnableEmptyingOfTheWorkingSet_MouseLeave(object sender, EventArgs e)
        {
            tmrFlag.Start();
        }

        private void LabelTimerPollingInterval_MouseHover(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                Flag = true;
                tmrFlag.Interval = 2000;
                tmrFlag.Start();
                ShowToolTip("Intervallo di aggiornamento dei dati a video");
            }
        }

        private void LabelTimerPollingInterval_MouseLeave(object sender, EventArgs e)
        {
            tmrFlag.Start();
        }

        private void tmrFlag_Tick(object sender, EventArgs e)
        {
            Flag = false;
        }
    }
}
