   M S B A M L   `   `   `  ����c  _ImplementValidationLogicОnCustomObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:ImplementValidationLogicОnCustomObjects(ImplementValidationLogicОnCustomObjects  5   	   9    3ImplementValidationLogicОnCustomObjects.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:ImplementValidationLogicОnCustomObjects     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      5   /ImplementValidationLogicОnCustomObjects.Person   data  textBoxInError �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%�   &	        &	        5
   
   6   �� 5   
   " ��6'    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� #	 Z $)
 #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      �� $��20q�6   .+�5   
   �� Enter your age:6%   �� 5   
   #��[ 6   .��6;   ��5      �� 5      $	
 Age�6    �� Source# [  6%    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5      5      .��5      5       5!      5"      