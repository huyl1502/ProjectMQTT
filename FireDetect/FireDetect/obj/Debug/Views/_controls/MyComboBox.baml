   M S B A M L   `   `   `  ����E  AFireDetect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System.Windows.ControlsSystem.Windows.Controls  5      (    "System.Windows.Controls.MyComboBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:System.Windows.Controls     5      $��Calbiri)�5   7   $��13(�6L     � 	Resources  5	         ComboBoxToggleButton �� 
TargetType � ColumnDefinitions ��Name �� CornerRadius F�Name  ComboBoxTextBox �� 
TargetType �� Property �� Value	 �� 	ClickMode
 d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation �� Triggers P� Property P� Value �� 
TargetName P� 
SourceName  �� Triggers! �� Padding��%�  &	        &	     '�� u    7   7  '�� �
    �� 5
   
   " d�67   .R�5      �  5      �� 5      �� 5      $��20 �6'   .+�5      �� $ Border��5      $��2��5      $ 0��5      
����������	#FF97A0A5$��1q�5      �� 5      $��0��5      $ 0��5      $��1q�5      
����������	#FF97A0A5$��0,0,1,0q�5      F� 5      $ Arrow��5      $��1��5       ���	#FF3F3F3F$��Center=�5"      $��Center=�5#      =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	5$      5&      55      �� 57   
   " ��62   .R�58      �� $ PART_ContentHost��6   |�.  #��z��6A   59      �� 5;   
   " ��6*   .�5<      ��  �@J�SnapsToDevicePixels . 64   �� 5=       �@�OverridesDefaultStyle . 66   �� 5>       � ��$
 Auto=�6K   �� 5?       � ��$
 Auto=�6I   �� 5@       � �� . 6>   �� 5A       � ��$	 120��6)   �� 5B       � ��$ 20��6*   �� 5C       � ��
 �   �6+   �� 5D       � �� 5E      �� 5F      " ��6&   .R�5G      � .+�5H      d� $��ToggleButton��5I      8��  $��2��5K      |�.  $	 Press=�5N      
 5M      �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+5O      �� 5P      $��ContentSite��6/    .  #��z 6\   #��z 5Q      #��z��5R      $��3,3,23,3q�5S      $��Center=�5T      $
��Left=�5U      �� 5V      $ PART_EditableTextBox��6&   8�� $
��Left=�5Y      $��Center=�5Z      $��3,3,23,3q�5[      |�. 
�������
��� � �$y�Hidden=�5_      # z 5`      ��5W      Z� 5`      � 5a      $��Popup��5b      $��Bottom=�5c      #��z 5d       . |�.  $��Slide=�5g      .��5i   "   � $��DropDown��6'    . #��z 5k      #��z 5l      .+�5m   &   �� $ DropDownBorder��5n   !   
�������$��1q�5q   !   ���#8888885r   !   �� 5s   &   $��4,6,4,6q�63    . .��5t   *   ��  . $ 	Contained=�6H   5u   '   5v   #   5w      5x       5y      P� 5z       �@��HasItems .  . �5{   "   �� $ DropDownBorder��6)    � ��$ 95��6Z   5|      P� 5}       � {� .  . �5~   "   ��  � ��
 �   �6?   5      P� 5�       �@��
IsGrouping . . �5�   "   ��  � �� .  6R   5�      P� 5�      $ Popup��6&    �@�AllowsTransparency . . �5�   "   �� $ DropDownBorder��6)    �@��CornerRadius$ 0��6]   �� 5�   "   $ DropDownBorder��6)    � ��$ 0,2,0,0q�6W   5�      P� 5�       �@��
IsEditable . . �5�   "   ��  � �� .  6>   �� 5�   "   $ PART_EditableTextBox��6)    � y�$ Visible=�6a   �� 5�   "   $ ContentSite��6)    � y�$ Hidden=�6X   5�      5�      5�        5�      5�      �� 5�   
   " ��6   .�5�      ��  �@J�SnapsToDevicePixels . 64   �� 5�       � ��
 �   �6+   �� 5�       � ��$ 5q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� #! z��6!   #��z��6E   #��z��6q   #��z��6�    . ._�5�      �� # z 6/   5�      5�      5�        5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � �� �#616ed163   �� 5�       � ��
 �����63   5�      P� 5�       �@��
IsSelected . . �5�      ��  � �� �#29348E63   �� 5�       � ��
 �����63   5�      5�      5�      .��5�      � .+�5�   
   �� $! 10q�6   
�������._�5�      �� -   5        " ��Name$" Content��5�      $��1��6(   $	��150��68   5�      5�      5�      5�      