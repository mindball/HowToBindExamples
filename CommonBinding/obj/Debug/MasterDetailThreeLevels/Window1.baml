   M S B A M L   `   `   `  ����H  DCommonBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:CommonBinding.MasterDetailThreeLevels%CommonBinding.MasterDetailThreeLevels  5   	   3    -CommonBinding.MasterDetailThreeLevels.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:CommonBinding.MasterDetailThreeLevels     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&    � 	Resources 5	      5   /CommonBinding.MasterDetailThreeLevels.Mountains   
dataSource �� Source  cvs  cvs2 �� Source �� Path��%�   &	        &	      7   &	 +     7    5
   
   6   �� 5   
   8   6D   �� 5   
    6   �� 8   $ Lifts�6Z   5      .��5   
   �� $��30q�6   
����  �$��2q�60    �� Padding$ 10q�6D   ._�5      �� $	��200��6   $	��240��6   .+�5!      �� -   5        $	��lb1��5!   j    �� DisplayMemberPath$
 Name��6Q   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6u   ��6   �� # [  6u   �� 5"      -   5        $	��lb2��5"   }   $
 Name��6d   $
 TrueY�6�    � DataContext 6   �� 	 �� ElementName$		 lb1��$ Items���6A   �� $ Lifts�6�   �� 5#      -   5        $	��lb3��5#   c   $
 TrueY�6n    6   �� $		 lb2��$ Items���6A   �� $
 Runs�6n   5$      5%      5'      