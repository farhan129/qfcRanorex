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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace qfcTest
{
    /// <summary>
    /// The class representing the qfcTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.1.2")]
    [RepositoryFolder("81d0428c-6a82-49c9-bfc6-46fdf789916f")]
    public partial class qfcTestRepository : RepoGenBaseFolder
    {
        static qfcTestRepository instance = new qfcTestRepository();
        qfcTestRepositoryFolders.WebDocumentQFCAppFolder _webdocumentqfc;
        qfcTestRepositoryFolders.DropdownAppFolder _dropdown;
        qfcTestRepositoryFolders.QFCGoogleChromeAppFolder _qfcgooglechrome;

        /// <summary>
        /// Gets the singleton class instance representing the qfcTestRepository element repository.
        /// </summary>
        [RepositoryFolder("81d0428c-6a82-49c9-bfc6-46fdf789916f")]
        public static qfcTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public qfcTestRepository() 
            : base("qfcTestRepository", "/", null, 0, false, "81d0428c-6a82-49c9-bfc6-46fdf789916f", ".\\RepositoryImages\\qfcTestRepository81d0428c.rximgres")
        {
            _webdocumentqfc = new qfcTestRepositoryFolders.WebDocumentQFCAppFolder(this);
            _dropdown = new qfcTestRepositoryFolders.DropdownAppFolder(this);
            _qfcgooglechrome = new qfcTestRepositoryFolders.QFCGoogleChromeAppFolder(this);
        }

#region Variables

        string _treatyTabLink = "http://localhost:90/#/document/123";

        /// <summary>
        /// Gets or sets the value of variable treatyTabLink.
        /// </summary>
        [TestVariable("983d3b26-814e-4ba5-9c19-6d627b407465")]
        public string treatyTabLink
        {
            get { return _treatyTabLink; }
            set { _treatyTabLink = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("81d0428c-6a82-49c9-bfc6-46fdf789916f")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The WebDocumentQFC folder.
        /// </summary>
        [RepositoryFolder("2d2e3ce7-afbc-4451-9164-5803a2dae159")]
        public virtual qfcTestRepositoryFolders.WebDocumentQFCAppFolder WebDocumentQFC
        {
            get { return _webdocumentqfc; }
        }

        /// <summary>
        /// The Dropdown folder.
        /// </summary>
        [RepositoryFolder("374ade8a-2964-42bd-aed5-483e8a063551")]
        public virtual qfcTestRepositoryFolders.DropdownAppFolder Dropdown
        {
            get { return _dropdown; }
        }

        /// <summary>
        /// The QFCGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("b184ae91-7a30-44e3-a496-aca27e82719d")]
        public virtual qfcTestRepositoryFolders.QFCGoogleChromeAppFolder QFCGoogleChrome
        {
            get { return _qfcgooglechrome; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.1.2")]
    public partial class qfcTestRepositoryFolders
    {
        /// <summary>
        /// The WebDocumentQFCAppFolder folder.
        /// </summary>
        [RepositoryFolder("2d2e3ce7-afbc-4451-9164-5803a2dae159")]
        public partial class WebDocumentQFCAppFolder : RepoGenBaseFolder
        {
            qfcTestRepositoryFolders.RowSearchHeaderFolder _rowsearchheader;
            RepoItemInfo _lnk_treatyInfo;
            RepoItemInfo _icn_treatycloseInfo;
            RepoItemInfo _welcomeInfo;

            /// <summary>
            /// Creates a new WebDocumentQFC  folder.
            /// </summary>
            public WebDocumentQFCAppFolder(RepoGenBaseFolder parentFolder) :
                    base("WebDocumentQFC", "/dom[@domain='localhost:90']", parentFolder, 30000, null, false, "2d2e3ce7-afbc-4451-9164-5803a2dae159", "")
            {
                _rowsearchheader = new qfcTestRepositoryFolders.RowSearchHeaderFolder(this);
                _lnk_treatyInfo = new RepoItemInfo(this, "lnk_Treaty", "body/div/div[3]//table/tbody/tr[1]/td[1]/a", 30000, null, "998e6fdc-43a5-4108-964b-87c90dbefbd8");
                _icn_treatycloseInfo = new RepoItemInfo(this, "icn_treatyClose", ".//a[@href=$treatyTabLink]/..//span[@class='btn_close']", 30000, null, "db933ab4-945a-494d-b57f-6f5c5d5f1b03");
                _welcomeInfo = new RepoItemInfo(this, "Welcome", "body/div/div[3]//h1[@innertext='Welcome ... ']", 60000, null, "d7d2893a-2313-4b9a-8881-ef22c622342b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2d2e3ce7-afbc-4451-9164-5803a2dae159")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("2d2e3ce7-afbc-4451-9164-5803a2dae159")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The lnk_Treaty item.
            /// </summary>
            [RepositoryItem("998e6fdc-43a5-4108-964b-87c90dbefbd8")]
            public virtual Ranorex.ATag lnk_Treaty
            {
                get
                {
                    return _lnk_treatyInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The lnk_Treaty item info.
            /// </summary>
            [RepositoryItemInfo("998e6fdc-43a5-4108-964b-87c90dbefbd8")]
            public virtual RepoItemInfo lnk_TreatyInfo
            {
                get
                {
                    return _lnk_treatyInfo;
                }
            }

            /// <summary>
            /// The icn_treatyClose item.
            /// </summary>
            [RepositoryItem("db933ab4-945a-494d-b57f-6f5c5d5f1b03")]
            public virtual Ranorex.SpanTag icn_treatyClose
            {
                get
                {
                    return _icn_treatycloseInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The icn_treatyClose item info.
            /// </summary>
            [RepositoryItemInfo("db933ab4-945a-494d-b57f-6f5c5d5f1b03")]
            public virtual RepoItemInfo icn_treatyCloseInfo
            {
                get
                {
                    return _icn_treatycloseInfo;
                }
            }

            /// <summary>
            /// The Welcome item.
            /// </summary>
            [RepositoryItem("d7d2893a-2313-4b9a-8881-ef22c622342b")]
            public virtual Ranorex.H1Tag Welcome
            {
                get
                {
                    return _welcomeInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The Welcome item info.
            /// </summary>
            [RepositoryItemInfo("d7d2893a-2313-4b9a-8881-ef22c622342b")]
            public virtual RepoItemInfo WelcomeInfo
            {
                get
                {
                    return _welcomeInfo;
                }
            }

            /// <summary>
            /// The RowSearchHeader folder.
            /// </summary>
            [RepositoryFolder("04087dca-a1e7-4a11-85af-8dca005b65af")]
            public virtual qfcTestRepositoryFolders.RowSearchHeaderFolder RowSearchHeader
            {
                get { return _rowsearchheader; }
            }
        }

        /// <summary>
        /// The RowSearchHeaderFolder folder.
        /// </summary>
        [RepositoryFolder("04087dca-a1e7-4a11-85af-8dca005b65af")]
        public partial class RowSearchHeaderFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btn_searchInfo;
            RepoItemInfo _drp_countrylistInfo;
            RepoItemInfo _selectedcountryInfo;

            /// <summary>
            /// Creates a new RowSearchHeader  folder.
            /// </summary>
            public RowSearchHeaderFolder(RepoGenBaseFolder parentFolder) :
                    base("RowSearchHeader", "body/div/div[1]/div[2]/div/div/div[2]", parentFolder, 30000, null, false, "04087dca-a1e7-4a11-85af-8dca005b65af", "")
            {
                _btn_searchInfo = new RepoItemInfo(this, "btn_Search", "div[3]/button[@innertext='SEARCH']", 30000, null, "48699342-84cc-4b53-9d62-ad48d4adc2c3");
                _drp_countrylistInfo = new RepoItemInfo(this, "drp_CountryList", "div[1]/select", 30000, null, "c916e6b2-e2c6-49ee-987d-27ecd73875bc");
                _selectedcountryInfo = new RepoItemInfo(this, "selectedCountry", "div[1]/select/option[@value='5']", 30000, null, "9c47d890-1e1f-43db-8703-e847a7488d0f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("04087dca-a1e7-4a11-85af-8dca005b65af")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("04087dca-a1e7-4a11-85af-8dca005b65af")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The btn_Search item.
            /// </summary>
            [RepositoryItem("48699342-84cc-4b53-9d62-ad48d4adc2c3")]
            public virtual Ranorex.ButtonTag btn_Search
            {
                get
                {
                    return _btn_searchInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The btn_Search item info.
            /// </summary>
            [RepositoryItemInfo("48699342-84cc-4b53-9d62-ad48d4adc2c3")]
            public virtual RepoItemInfo btn_SearchInfo
            {
                get
                {
                    return _btn_searchInfo;
                }
            }

            /// <summary>
            /// The drp_CountryList item.
            /// </summary>
            [RepositoryItem("c916e6b2-e2c6-49ee-987d-27ecd73875bc")]
            public virtual Ranorex.SelectTag drp_CountryList
            {
                get
                {
                    return _drp_countrylistInfo.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The drp_CountryList item info.
            /// </summary>
            [RepositoryItemInfo("c916e6b2-e2c6-49ee-987d-27ecd73875bc")]
            public virtual RepoItemInfo drp_CountryListInfo
            {
                get
                {
                    return _drp_countrylistInfo;
                }
            }

            /// <summary>
            /// The selectedCountry item.
            /// </summary>
            [RepositoryItem("9c47d890-1e1f-43db-8703-e847a7488d0f")]
            public virtual Ranorex.OptionTag selectedCountry
            {
                get
                {
                    return _selectedcountryInfo.CreateAdapter<Ranorex.OptionTag>(true);
                }
            }

            /// <summary>
            /// The selectedCountry item info.
            /// </summary>
            [RepositoryItemInfo("9c47d890-1e1f-43db-8703-e847a7488d0f")]
            public virtual RepoItemInfo selectedCountryInfo
            {
                get
                {
                    return _selectedcountryInfo;
                }
            }
        }

        /// <summary>
        /// The DropdownAppFolder folder.
        /// </summary>
        [RepositoryFolder("374ade8a-2964-42bd-aed5-483e8a063551")]
        public partial class DropdownAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new Dropdown  folder.
            /// </summary>
            public DropdownAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Dropdown", "/container[@caption='dropdown']", parentFolder, 30000, null, true, "374ade8a-2964-42bd-aed5-483e8a063551", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("374ade8a-2964-42bd-aed5-483e8a063551")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("374ade8a-2964-42bd-aed5-483e8a063551")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The QFCGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("b184ae91-7a30-44e3-a496-aca27e82719d")]
        public partial class QFCGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _closeInfo;

            /// <summary>
            /// Creates a new QFCGoogleChrome  folder.
            /// </summary>
            public QFCGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("QFCGoogleChrome", "/form[@title='QFC - Google Chrome']", parentFolder, 30000, null, true, "b184ae91-7a30-44e3-a496-aca27e82719d", "")
            {
                _closeInfo = new RepoItemInfo(this, "Close", "container[@accessiblename='Google Chrome']//tabpage[@accessiblename='QFC']/button[@accessiblename='Close']", 30000, null, "79f40636-8b84-4289-ae53-41e395ff0499");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b184ae91-7a30-44e3-a496-aca27e82719d")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b184ae91-7a30-44e3-a496-aca27e82719d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("79f40636-8b84-4289-ae53-41e395ff0499")]
            public virtual Ranorex.Button Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("79f40636-8b84-4289-ae53-41e395ff0499")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }
        }

    }
}