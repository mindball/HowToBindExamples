   M S B A M L   `   `   `  ����H  DCommonBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CommonBinding.MasterDetailCommonBinding.MasterDetail  5   	   (    "CommonBinding.MasterDetail.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:CommonBinding.MasterDetail     5   	     � Title$  Window1��5   	    � SizeToContent$ WidthAndHeight=�5	   	    � 	Resources 5      3   -CommonBinding.MasterDetail.SolarSystemPlanets   solarPlanets=   7CommonBinding.MasterDetail.StringToImageSourceConverter  stringToImageSource �� Source  cvs  detailTemplate �� Padding �� Path �� 	Converter �� Orientation��%>  &	        &	      &	 &     7   &	 >     7    5   
   6#     5   
   6-   �� 5   
   8   6F   �� 5   
   .R�5      �� 
���   �$��1q�6)   $ 5q�6=   ._�5      � $	��200��6   $	��200��6#   .+�5      �� ��6   �� $ Image�8   �� 5      ���	#A0FFFFFF$��Bottom=�68   .+�5      �� $ 
Horizontal=�6%   $��5,5,5,0q�6>   .+�5      �� $��Orbit:��6(   $
��Bold"�66   �� 5      ��6(   �� $ Diameter�5      �� 5      $ 
Horizontal=�6%   $��5,0,5,0q�6>   .+�5      �� $��	Diameter:��6(   $
��Bold"�69   �� 5      ��6(   �� $ Orbit�5      �� 5      $ 
Horizontal=�6%   $��5,0,5,5q�6>   .+�5      �� $��Mass:��6(   $
��Bold"�65   �� 5       ��6(   �� $
 Mass�5!      5"      5#      5$      5%      5&      .��5(      �� $��30q�6   
����  �$��2q�6,   $ 10q�6@   ._�5)   
   �� $ 
Horizontal=�6   .+�5+      ��  �� DisplayMemberPath$
 Name��6J   $��5q�6c   $��0,0,5,0q�6o   ��6   �� 	 �� Source#	 [ 6o   �� 5-      #��[ 6   ��6O   �� #	 [ 5.      5/      51      