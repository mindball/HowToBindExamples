   M S B A M L   `   `   `  ����p  lBindToCollectionAndDisplayInformationBasedOnSelection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:BindToCollectionAndDisplayInformationBasedOnSelection5BindToCollectionAndDisplayInformationBasedOnSelection  5   	   F    @BindToCollectionAndDisplayInformationBasedOnSelection.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   UlocalCclr-namespace:BindToCollectionAndDisplayInformationBasedOnSelection     5   	     � Title$  Binding to a Collection��5   	    � SizeToContent$ WidthAndHeight=�5	   	    � 	Resources 5
      B   <BindToCollectionAndDisplayInformationBasedOnSelection.Person   	MyFriends  DetailTemplate �� Padding � RowDefinitions � ColumnDefinitions �� Path��%�  &	        &	        5   
   6   �� 5   
   .R�5      �� $	��300��6   $	��100��6!   $��20q�6.   
����� �$��1q�5      $ 8q�62   ._�5      �  5      �� 5      �� 5      �� 5       5      �� 5      �� 5      .+�5      �� $��0��6    $��0��6-   $��First Name:��6=   �� 5      $��0��6    $��1��6-   ��6=   �� $ 	FirstName��� 5      $��1��6    $��0��6-   $��
Last Name:��6=   �� 5      $��1��6    $��1��6-   ��6=   �� $ LastName��� 5      $��2��6    $��0��6-   $��
Home Town:��6=   �� 5      $��2��6    $��1��6-   ��6=   �� $ HomeTown�5       5!      5"      5$      .��5&      �� .+�5'   
   �� $��Verdana)�6   $��11(�6)   $��	5,15,0,10q�5(      $
��Bold"�6#   My Friends:6B   �� 5)   
   $	��200��6   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6   ��5*      ��  �� Source# [  �� 5+   
   $��Verdana)�6   $��11(�6)   $��5,15,0,5q�5,      $
��Bold"�6"   Information:6B   �� 5-   
   #��[ 5.      ��5-      �� # [  5.      �� 5/   
   -   5        5/   !   50      51      