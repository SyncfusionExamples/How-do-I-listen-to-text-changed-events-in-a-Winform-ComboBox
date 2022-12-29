# Events-to-hook-for-text-changed-events-in-a-WinForms-ComboBox

WinForms SfComboBox.TextBox.TextChanged event can be hooked to listen the textbox’s text changes. Also you can use [SelectedIndexChanged](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.ListView.SfComboBox.html#Syncfusion_WinForms_ListView_SfComboBox_SelectedIndexChanged), [SelectedValueChanged](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.ListView.SfComboBox.html#Syncfusion_WinForms_ListView_SfComboBox_SelectedValueChanged) events of [SfComboBox](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.ListView.SfComboBox.html) to listen the selection changes.


**C#**

```
sfComboBox1.TextBox.TextChanged += SfComboBox1_TextChanged;
sfComboBox1.SelectedIndexChanged += SfComboBox1_SelectedIndexChanged;
  
private void SfComboBox1_TextChanged(object sender, EventArgs e)
{
     //Text changed
     var selectedText = ((TextBox) sender).Text;
}
  
private void SfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
}
```
