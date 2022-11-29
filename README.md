# Events-to-hook-for-text-changed-events-in-a-WinForms-ComboBox
The TextChanged event is triggered when the [ComboBox](https://help.syncfusion.com/windowsforms/sfcombobox/gettingstarted?utm_medium=listing&utm_source=github-examples) SelectedItem and Textchanges. Please click the following [How do I listen to text changed events in a WinForms ComboBox]( https://www.syncfusion.com/kb/9578?utm_medium=listing&utm_source=github-examples) for more details.

# C#
    private void SfComboBox1_TextChanged(object sender, EventArgs e)
        {
            //Text changed
            var selectedText = ((TextBox) sender).Text;
        }
        
