   M S B A M L   `   `   `  ����E  AFireDetect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System.Windows.ControlsSystem.Windows.Controls  5      (    "System.Windows.Controls.MainLayout   5      2Controls%clr-namespace:System.Windows.Controls  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5
      �   � RowDefinitions  5   
   �� 5      $��40 �6   �� 5      .+�5   
   �� ���#29348E._�5      � $��5q�6    � ColumnDefinitions 5      �� 5      $
��211* �6'   �� 5      $
��105* �6'   �� 5      $
��158* �6'   �� 5      $
��316* �6'   .+�5      �� -   5         ��Name$ banner��5       �� Orientation$ 
Horizontal=�5      
������ $��2��5   >   .+�5      �� -   5         ��Name$ btnMenu��5!      $��28��5      $��26��5       �� Padding$	 4 6q�5      $��1q�5      ���#29348E � Cursor$
 Hand��5       ._�5"      � .+�5#      �� 
�������$��3��5$      	 �� X2$ 18��5%      �� 5&      
�������$��3��5'      $ 18��5(      $��Center=�6'   �� 5)      
�������$��3��5*      $ 18��5+      $��Bottom=�6'   5,      ��5-      �� 5.       �� Triggers 5/   "   P� 50   &   	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �51   *   ��  �� Property � �� �� Value
 �����6O   52   '   54      56      �� 57      -   5         ��Name$ main_caption��57      $��15(�58      $
��Bold"�59      $��Center=�5:      
�������5;      5<      �� 5=      -   5        $��Clock��5=   (   $��2��6   $��18(�65   
�������$��Calibri)�6V   �� 5>      -   5        $ dropdownPanel��5>      $��Center=�5?   !   $ 
Horizontal=�5@   !   $��2��5A   !   $
��79,0q�61   5B      �� 5C      -   5        $ 
actionMenu��5C      $��Right=�5D   !   $ 
Horizontal=�5E   !   $��3��5F   !   5G      5H      5I      � 5J   
   -   5         �Name$ 
splitPanel��5J      $��1��6   
������� 5K      �� 5L      $	��250 �6#   $	��250��6/   �� 5M      .+�5O      �� ���#29348E._�5P      �� .+�5Q      �� ���#616ed1._�5R      �� 
�������$��14(�5S   $   $��10q�5T       Quản lý chung5U   0   5V      )   #System.Windows.Controls.NavMenuItem  5W         Text$ Trong ngày��6+   
   Url$ building/manage��6=     5X      $ Đồ thị��6+   $ home/chartsample��69   �� 5Z      ���#616ed1._�5[      �� 
�������$��14(�5\   $   $��10q�5]       Cài đặt5^   *   5_        5a      -   5          Name$ 
simulation��5a   +   $ Giả lập��6?   $ Simulation/Start��6N     5b      $ Đăng xuất��6+   $ Account/Logout��6<   5c      5d      �� 5e      -	   5        $ main_content��5e      $��1��6+   
�������6P   5f      5g      5h      