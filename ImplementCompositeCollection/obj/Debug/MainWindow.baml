   M S B A M L   `   `   `  ����W  SImplementCompositeCollection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ImplementCompositeCollectionImplementCompositeCollection  5   	   -    'ImplementCompositeCollection.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ImplementCompositeCollection     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      ,   &ImplementCompositeCollection.GreekGods   GreekGodsData  GreekHeroesdata � XPath �� DataType+   %ImplementCompositeCollection.GreekGod �� Path �� XPath��%�  &	        &	      (�� �    5      *, +)(�� �    5      *Hero+)  5
   
   6   � 5   
   $ GreekHeroes/Hero��62   .��5      ��<GreekHeroes xmlns="">
                    <Hero Name="Jason" />
                    <Hero Name="Hercules" />
                    <Hero Name="Bellerophon" />
                    <Hero Name="Theseus" />
                    <Hero Name="Odysseus" />
                    <Hero Name="Perseus" />
                </GreekHeroes>        5      �� 5   
   "  6   .R�5      �� 
��� �����6   �� $
 Name�63   5      �� 5   
   $
 Hero��6   .R�5      �� 
����� ���6   �� $ @Name��65   5      5      .��5      �� .+�5    
   �� $��18(�6   $
��Bold"�6"   $��10q�64   $��Center=�5!      Composite Collection Samle6M   �� 5"   
   -   5        $��	myListBox��5"      $	��300��6#   $	��200��60   
�������$ �� IsSynchronizedWithCurrentItem$
 trueY�6O   ��5#      -  'System.Windows.Data.CompositeCollection  5$      �� 5%       �� 
Collection 6*   ��  �� Source# [  �� 5&       6*   �� # [ �� 5'      
���  ��.��63   Otjer List Box item16I   �� 5(      
���  ��.��63   Otjer List Box item26I   5)      5+      �� 5,   
   -   5        $��SetItem��5,      $��50��6#   $��5q�6.   69   5-      5.      