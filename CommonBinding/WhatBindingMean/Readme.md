# What Binding mean:

```
Most Bindings you see in samples have the Source and Path properties set. The Source property specifies the 
object you're binding to and the Path specifies a property in that object whose value you're interested in. 
I've seen several people get confused when encountering an empty Binding for the first time - "{Binding}". 
It seems at first sight that we're not giving the Binding enough information to do anything useful. This is 
not true and I will explain why. If you read my previous post you should understand that it is not necessary 
to set a Source in a Binding, as long as there is a DataContext set somewhere up in the tree. As for the Path, 
it should be left out when you want to bind to a whole object, and not only to a single property of an object.
```

```
{Binding} Empty binding interacts well with DataTemplate:
1. ContentControl does not know how to display the GreekGod data. Therefore you will only see the results of a ToString()
2.  DataTemplate specify the appearance of your data. Notice that none of the Binding statements inside the DataTemplate 
has a Source. That is because a DataContext is automatically set to the data object being templated.
``` 