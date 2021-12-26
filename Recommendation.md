# How should I decide whether to use DataContext or Source?
```
 use DataContext only when you need to bind more than one property 
 to a particular source. When binding only one property to a source, 
 I always use Source. The reason for this is ease of debugging - I 
 would rather see all the information about the Binding in one place 
 than search for the nearest DataContext to understand what is going on. 
 In a small sample like the one above there is no big advantage, but 
 in complex applications this could save you some time.
```
```xaml
<Window.Resources>
    <local:GreekGod Name="Zeus" Description="Supreme God of the Olympians" RomanName="Jupiter" x:Key="zeus"/>
    <local:GreekGod Name="Poseidon" Description="God of the sea, earthquakes and horses" RomanName="Neptune" x:Key="poseidon"/>
</Window.Resources>

<StackPanel DataContext="{StaticResource poseidon}">
    <TextBlock TextContent="{Binding Source={StaticResource zeus}, Path=Name}"/>
    <TextBlock TextContent="{Binding Path=Description}"/>
    <TextBlock TextContent="{Binding Path=RomanName}"/>
</StackPanel>
```
