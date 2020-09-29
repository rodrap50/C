using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GetRegitryInfo
{
    public partial class Form1 : Form
    {
        private string SoftwareName;
        private string Reg;
        List<String> Apps = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClearForm();

            textBoxDisplayResults.Text = "";
            
            progressBar1.Value = 0;
            Reg = "";
            SoftwareName = textBoxStringInput.Text;

            Apps = GetUnintstallString(SoftwareName);

            if (Apps.Count != 0)
            {

                foreach (string found in Apps)
                {
                    Reg += found + Environment.NewLine;
                }

                textBoxDisplayResults.Text = Reg;
            }
            else
            {
                label2.ForeColor = Color.FromName("RED");
                label2.Text = "Software not found";

            }

        }

        private List<string> GetUnintstallString(string Software)
        {
            if (Software == "")
            {
                var invalidEntry = new List<string>();

                return invalidEntry;
            }

            String DisplayName, UninstallString, Path, DispalyVersion, finalOutput;
            var softwareFound = new List<string>();
            var uninstallReg = new List<RegistryKey>();


            uninstallReg.Add(Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"));
            uninstallReg.Add(Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall"));

            foreach (RegistryKey Archi in uninstallReg)
            {
                string[] regKeys = Archi.GetSubKeyNames();

                for (int i = 0; i < regKeys.Length; i++)
                {

                    progressBar1.PerformStep();

                    if (regKeys[i] != null)
                    {
                        RegistryKey keySearch = Archi.OpenSubKey(regKeys[i]);
                        if (keySearch != null)
                        {
                            try
                            {

                                if (keySearch.GetValue("DisplayName").ToString().ToLower().Contains(Software.ToLower()))
                                {

                                    DisplayName ="DisplayName: " + keySearch.GetValue("DisplayName").ToString();
                                    UninstallString ="UninstallString: " + keySearch.GetValue("UninstallString").ToString();
                                    Path = "Path: " +keySearch.Name;
                                    DispalyVersion = "DispalyVersion: " + keySearch.GetValue("DisplayVersion").ToString();

                                    finalOutput = DisplayName + Environment.NewLine + 
                                        UninstallString + Environment.NewLine + 
                                        DispalyVersion + Environment.NewLine +
                                        Path + Environment.NewLine + 
                                        "===================================================================";
                                    softwareFound.Add(finalOutput);
                                }
                            }
                            catch (NullReferenceException e)
                            {
                                Console.WriteLine(e);
                            }
                        }
                    }


                }
            }
            return softwareFound;
        }


        private void ClearForm()
        {
            label2.Text = "";
            label2.ForeColor = Color.FromName("Black");
            textBoxDisplayResults.Text = "";
            progressBar1.Value = 0;
            progressBar1.Refresh();

        }

        private void textBoxStringInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                button1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}