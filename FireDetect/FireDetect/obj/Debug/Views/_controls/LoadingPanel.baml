   M S B A M L   `   `   `  ����E  AFireDetect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System.Windows.ControlsSystem.Windows.Controls  5      d `PresentationFramework.Classic, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35jMclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.ClassicMicrosoft.Windows.Themes 5      *    $System.Windows.Controls.LoadingPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5ctr%clr-namespace:System.Windows.Controls     5      fclassicThemeMclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Classic     5        � 	Resources  5         bool2visibility  panelBackground �� EndPoint �� 
StartPoint � Color � Offset  basicButton �� 
TargetType �� Property �� Value5  /Microsoft.Windows.Themes.ClassicBorderDecorator   ClassicBorderBrush	 �� 
TargetType
  Name   BorderBrush   BorderThickness   BorderStyle   
Background J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName  closeButton �� BasedOn  panelMessageText  panelSubMessageText��%�	  &	        &	      &	 �     &	 \    7  &	 �    &	 +    �� 5   
   6'   �� 5
   
   $ 0.5,1&�66   $ 0.5,0&�6G   .��5      � $ Transparent��6   $ 1Q�6/   � 5      $ Transparent��6   5      �� 5   
   " ��6$   .�5      ��  � ��# � ��6+   �� 5       � ��# � ��6+   �� 5       � ��# Z 6,   �� 5       � ��$ 3q�60   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 0,0,1,1q�6(   �� 5       � �� 5      �� 5      "	 ��6&   .R�5        $
 ContentContainer��6>   # z��6X   $ 0q�6�   $
 None=�6�   # z��6�    . ._�5      �� #��z��6/   #��z��6r   ��. # z 6�   #��z��6�   5       5      P� 5       �@J�IsKeyboardFocused . . �5   "   �� $ ContentContainer��6@    �@ BorderStyle$ RaisedFocused=�6^   5       P� 5!       �@��IsDefaulted . . �5"   "   �� $ ContentContainer��6@    �@ BorderStyle$ RaisedFocused=�6^   5#      P� 5$       � �� . . �5%   "   �� $ ContentContainer��6@    �@ BorderStyle$ RaisedPressed=�6^   5&      P� 5'       �@d�	IsChecked$
 TrueY�6H   . �5(   "   �� $ ContentContainer��6@    �@ BorderStyle$ RaisedPressed=�6^   5)      P� 5*       � {� .  . �5+   "   �� # � ��6?    � ��5,      5.      50      51      �� 53   
   8   " ��6K   .�54      ��  � ��$	 Top=�62   �� 55       � ��$ Verdana)�6+   �� 56       � ��$ 9(�6)   �� 57       � ��$
 Bold"�6+   �� 58       � ��
 �����6+   �� 59       �@�Cursor$
 Hand��6'   �� 5:       � ��$
 15,7q�6'   �� 5;       � �� 6+   Z� 5<      �� 5>   
   " ��6)   .�5?      ��  � ��$
 Left=�64   �� 5@       � ��$ 0,11,0,0q�6'   �� 5A       � ��$ WrapWithOverflow=�6-   �� 5B       � ��$
 Bold"�6+   �� 5C       � ��$ 16(�6)   �� 5D       � ��$	 Top=�62   �� 5E       � ��$ Arial)�6+   �� 5F       �@J�SnapsToDevicePixels . 64   5G      �� 5I   
   " ��6,   .�5J      ��  � ��$
 Left=�64   �� 5K       � ��$	 0,5q�6'   �� 5L       � ��$
 Wrap=�6-   �� 5M       � ��$ 12(�6)   �� 5N       � ��$	 Top=�62   �� 5O       � ��$ Arial)�6+   �� 5P       �@J�SnapsToDevicePixels . 64   5Q      5R      .��5T      ]� #��[ 6   y�5U      ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" >� �� Path$ 	IsLoading� �� Mode$ OneWay=� �� 	Converter# [  .+�5V   
   F� ����    `���
ט`��	$��1��62   $��
0,0.25,0,0q�6=    �� Stretch$
 Fill=�6Q   $	��Top=�6`   
������ 6u   F� 5W   
   ����    `���
ט`��	$��1��62   $��
0,0.25,0,0q�6=   $
 Fill=�6Q   $	��Top=�6`   
������ 6u   1   +System.Windows.Controls.CircularProgressBar  5Y   
   -   5          Name$ progressBar��5Y   "   $
��Left=�5Z      $
��Left=�5[      $	��Top=�5\      $��45��5]      $��18,10q�5^      �� 5`   
   $	��Top=�6   .+�5a      �� -   5         ��Name$ 
txtMessage��5a      #��[ 5b      ���#333399��5c      ��  �� *FindAncestor+" >�$ Message�5d      �� 5f      -   5        $ txtSubMessage��5f      #��[ 5g      ���#333399��5h      ��  �� *FindAncestor+" >�$ 
SubMessage�5i      5j      5k      5l      