﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace qfcTest
{
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("234d3f6c-d18e-49c5-acd2-4a7d7657ec87", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the qfcTestRepository repository.
        /// </summary>
        public static qfcTestRepository repo = qfcTestRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            treatyTabLink = "http://localhost:90/#/document/123";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable treatyTabLink.
        /// </summary>
        [TestVariable("c9a82572-a69d-4f23-9406-54d7f108d930")]
        public string treatyTabLink
        {
            get { return repo.treatyTabLink; }
            set { repo.treatyTabLink = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.1.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.1.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 500;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://localhost:90' with browser 'Chrome' in maximized mode (with arguments --incognito).", new RecordItemIndex(0));
            Host.Local.OpenBrowser("http://localhost:90", "Chrome", "--incognito", false, true);
            Delay.Milliseconds(100);
            
            // Sometimes very first page load after system restart requires long time
            Report.Log(ReportLevel.Info, "Wait", "Sometimes very first page load after system restart requires long time\r\nWaiting 1m for item 'WebDocumentQFC.Welcome' to exist.", repo.WebDocumentQFC.WelcomeInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.WebDocumentQFC.WelcomeInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 12s.", new RecordItemIndex(2));
            Delay.Duration(12000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentQFC.RowSearchHeader.drp_CountryList' at Center.", repo.WebDocumentQFC.RowSearchHeader.drp_CountryListInfo, new RecordItemIndex(3));
            repo.WebDocumentQFC.RowSearchHeader.drp_CountryList.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dropdown' at 34;30.", repo.Dropdown.SelfInfo, new RecordItemIndex(4));
            repo.Dropdown.Self.Click("34;30");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Select() on item 'WebDocumentQFC.RowSearchHeader.selectedCountry'.", repo.WebDocumentQFC.RowSearchHeader.selectedCountryInfo, new RecordItemIndex(5));
            //repo.WebDocumentQFC.RowSearchHeader.selectedCountry.Select();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentQFC.RowSearchHeader.btn_Search' at 53;19.", repo.WebDocumentQFC.RowSearchHeader.btn_SearchInfo, new RecordItemIndex(6));
            repo.WebDocumentQFC.RowSearchHeader.btn_Search.Click("53;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Href' from item 'WebDocumentQFC.lnk_Treaty' and assigning its value to variable 'treatyTabLink'.", repo.WebDocumentQFC.lnk_TreatyInfo, new RecordItemIndex(7));
            treatyTabLink = repo.WebDocumentQFC.lnk_Treaty.Element.GetAttributeValueText("Href");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentQFC.lnk_Treaty' at CenterLeft.", repo.WebDocumentQFC.lnk_TreatyInfo, new RecordItemIndex(8));
            repo.WebDocumentQFC.lnk_Treaty.Click(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentQFC.icn_treatyClose' at 6;15.", repo.WebDocumentQFC.icn_treatyCloseInfo, new RecordItemIndex(9));
            repo.WebDocumentQFC.icn_treatyClose.Click("6;15");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'QFCGoogleChrome.Close' at 12;14.", repo.QFCGoogleChrome.CloseInfo, new RecordItemIndex(10));
            //repo.QFCGoogleChrome.Close.Click("12;14");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
