# What is the difference between SelectedValue and SelectedItem?
```
When they are used by themselves, these two properties are very similar. The need for both and the 
difference between the two becomes apparent when SelectedValuePath is also set.
```
> Try without selected item from listBox (none select):
```
string messengerOfGods = (string)(listBoxGods.SelectedValue); //Display Messenger of the Gods
GreekGod hermes = (GreekGod)(listBoxGods.SelectedItem);
```
```
Each item in the ListBox is a GreekGod object, so by setting SelectedValuePath to "Description" I am 
able to drill down into the Description property of each GreekGod. Then I just have to set SelectedValue
to the description I am looking for and the item becomes selected.
```
```
The difference between SelectedValue and SelectedItem should be obvious now. SelectedValue if is
selecting into listBox returns the string it was set to SelectedValuePath="Description", while SelectedItem returns the actual GreekGod object 
with that description.
```
```
SelectedValue is particularly useful when only part of your item is stored in the model you are data binding to. 
In this scenario, you would data bind the SelectedValue property to the partial information in your model but 
the ListBox can show a lot more information about that item.
```