# How to change the layout of an ItemsControl
```
this sample show two ways to change the layout of an ItemsControl.
```

## The easiest way to change the layout of an ItemsControl is simply by setting the ItemsPanel property to the Panel that will contain the items:
```xml
<ListBox ItemsSource="{Binding Source={StaticResource xmlData}}" (...) >
	<ListBox.ItemsPanel>
		<StackPanel Orientation="Horizontal" />
	</ListBox.ItemsPanel>
</ListBox>
```
## Alternatively, for more extensive customizations, you can create a ControlTemplate
```
This ControlTemplate allows you to replace the whole VisualTree, including picking a new Panel to hold the items. 
For example, the following markup shows a ControlTemplate that adds a Border and changes the Panel on the ItemsControl:
```

```xml
<ControlTemplate x:Key="listBoxTemplate">
	<Border BorderBrush="Orange" BorderThickness="2" Margin="10,0,10,10">
		<StackPanel Orientation="Horizontal" IsItemsHost="True" />
	</Border>
</ControlTemplate>
    
<ListBox ItemsSource="{Binding Source={StaticResource xmlData}}" Template="{StaticResource listBoxTemplate}" (...) />
```