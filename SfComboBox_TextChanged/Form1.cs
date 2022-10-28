#region Copyright Syncfusion Inc. 2001-2018.

// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 

#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace GettingStarted
{
    public partial class Form1 : SfForm
    {
        #region constructor

        public Form1()
        {
            InitializeComponent();
            SfComboBoxSeetings();

            try
            {
                var bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                Icon = Icon.FromHandle(bmp.GetHicon());
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        #region SfComboBoxSettings

        private void SfComboBoxSeetings()
        {
            var list = GetData();

            #region editMode

            sfComboBox1.DataSource = list;
            sfComboBox1.DisplayMember = "LongName";
            sfComboBox1.ValueMember = "LongName";

            sfComboBox1.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);

            sfComboBox1.TextBox.TextChanged += SfComboBox1_TextChanged;
            sfComboBox1.SelectedIndexChanged += SfComboBox1_SelectedIndexChanged;

            #endregion
        }

        private void SfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SelectedIndexChanged event will be triggered when index is equal or greater than 0
        }

        private void SfComboBox1_TextChanged(object sender, EventArgs e)
        {
            //Text changed
            var selectedText = ((TextBox) sender).Text;
        }

        #region GenerateData

        private List<USState> GetData()
        {
            // DisplayMember is used to display just the long name of each state.
            var usStates = new List<USState>
            {
                new USState("Alaska", "AK", 1),
                new USState("Arizona", "AZ", 2),
                new USState("Arkansas", "AK", 3),
                new USState("California", "CA", 4),
                new USState("Colorado", "CO", 5),
                new USState("Connecticut", "CT", 6),
                new USState("Delaware", "DE", 3),
                new USState("Florida", "FL", 4),
                new USState("Georgia", "GA", 1),
                new USState("Hawaii", "HI", 0),
                new USState("Idaho", "ID", 3),
                new USState("Illinois", "IL", 2),
                new USState("Indiana", "IN", 6),
                new USState("Iowa", "IA", 5),
                new USState("Kansas", "KA", 5),
                new USState("Kentucky", "KY", 4),
                new USState("Louisiana", "LA", 3),
                new USState("Maine", "ME", 0),
                new USState("Maryland", "MD", 0),
                new USState("Massachusetts", "MA", 2),
                new USState("Michigan", "MI", 1),
                new USState("Minnesota", "MN", 6),
                new USState("Mississippi", "MS", 5),
                new USState("Missouri", "MO", 2),
                new USState("Montana", "MT", 1),
                new USState("Nebraska", "NE", 4),
                new USState("Nevada", "NV", 0),
                new USState("New Hampshire", "NH", 3),
                new USState("New Jersey", "NJ", 3),
                new USState("New Mexico", "NM", 2),
                new USState("New York", "NY", 5),
                new USState("North Carolina", "NC", 4),
                new USState("North Dakota", "ND", 4),
                new USState("Ohio", "OH", 1),
                new USState("Oklahoma", "OK", 2),
                new USState("Oregon", "OR", 5),
                new USState("Pennsylvania", "PA", 0),
                new USState("Rhode Island", "RI", 6),
                new USState("South Carolina", "SC", 5),
                new USState("South Dakota", "SD", 4),
                new USState("Tennessee", "TN", 3),
                new USState("Texas", "TX", 2),
                new USState("Utah", "UT", 0),
                new USState("Vermont", "VT", 1),
                new USState("Virginia", "VA", 0),
                new USState("Washington", "WA", 2),
                new USState("West Virginia", "WV", 0),
                new USState("Wisconsin", "WI", 3),
                new USState("Wyoming", "WY", 5)
            };

            return usStates;
        }

        #endregion

        #endregion
    }

    #region "USState Class"

    /// <summary>
    ///     Creating the class
    /// </summary>
    public class USState
    {
        public USState(string strLongName, string strShortName, int imageIndex)
        {
            ShortName = strShortName;
            LongName = strLongName;
            ImageIndex = imageIndex;
        }

        public string ShortName { get; }

        public string LongName { get; }

        public int ImageIndex { get; set; }


        public override string ToString()
        {
            return ShortName + " - " + LongName;
        }
    }

    #endregion
}