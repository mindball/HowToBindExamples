   M S B A M L   `   `   `  ����M  IBindТoEnumeration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BindТoEnumerationBindТoEnumeration  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   #    BindТoEnumeration.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BindТoEnumeration     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
       S� 
MethodName S� 
ObjectType  System.Enum   SetSize S� MethodParameters M� TypeName��%~   &	        S� 5   
   $ 	GetValues��6   "  5       5      M� 5      $ HorizontalAlignment��6   5      5      .��5      �� $��10q�6   
����� �$��3q�5       �� Padding$ 8q�6   ._�5   
   �� $	��300��6   .+�5      �� 53Choose the HorizontalAlignment value of the Button:6M   �� 5      -   5        $��
myComboBox��5       �� SelectedIndex$ 0��6(   $��8q�6:   ��5      ��  �� Source# [  �� 5      $��	Click Me!��6   ��5      �� 	 �� ElementName$	 
myComboBox��
 �� Path$
 SelectedItem�5      5      5      