   M S B A M L   `   `   `  ����  TestWPF    TestWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	測試WPF��5   	   $	��350��6   $	��351��6$   .��5      � -   5         �Name$ iGrid1��5      $��
10,10,10,8q�6    � RowDefinitions 5   
   �� 5      $
��169* �6   �� 5      $
��136* �6    � ColumnDefinitions 5
   
   �� 5      �� 5      $
��305* �6   ��5   
   �� 5       �� EndPoint$	 1,1&�6"    � MappingMode$ RelativeToBoundingBox=�61    �� 
StartPoint$	 0,0&�6U   .��5      �  � Color$
 Blue��6    � Offset$ 0Q�6,   � 5      $ 	LightBlue��6   $	 0.5Q�61   5      .+�5   
   �� -   5        	 ��Name$	 btnHello��5      $	��WPF��6#   $��Right=�61   $��	0,40,10,0q�6M   $	��Top=�6`   $��75��6x   $��1��6�   ��6�   Z� 6�   �� 5   
   -   5        
 ��Name$
 edtText��5      $��23��6#   $��	9,10,10,0q�6/    �� TextWrapping$
 Wrap=�6B   $	��Top=�6�   $��1��6�   ��6V   ��  �� ElementName$ Slider1�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ Slider1��5      $��1��6"   $��
10,70,10,0q�62   $	��Top=�6F    � Maximum$	 100Q�6^   �� 5   
   -   5        $	 HelloWindows��5      �� 5   
   -   5        $	 btnClose��5      $
��Exit��6#   $��1��62   $
��Left=�6B   $��237,138,0,0q�6]   $	��Top=�6r   $��75��6�   ��6�   Z� 6�   5      5      