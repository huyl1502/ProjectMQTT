   M S B A M L   `   `   `  ����E  AFireDetect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System.Windows.ControlsSystem.Windows.Controls  5   	   E'clr-namespace:FireDetect.Views.BuildingFireDetect.Views.Building  5   	   *    $FireDetect.Views.Building.CreateForm   5   	   2Controls%clr-namespace:System.Windows.Controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:FireDetect.Views.Building     5   	     � Title$  Tạo tòa nhà��5   	   $	��550��6   $	��500��6*    � WindowStartupLocation$ CenterScreen=�66   .��5	      � -   5         �Name$ MainContent��5	      
������� � RowDefinitions 5
   
   �� 5      $��3* �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   
�������.+�5      �� 
�������
�������$��Center=�5       �� Padding$ 7, 10q�5      $��25, 7q�6   ._�5      �� .+�5      �� $��Tên:��6   $��15(�6+   6;   �� 5      -   5         ��Name$
 name��5      $��15(�6,   $��
0, 0, 0, 1q�6:   $
��5, 7q�6W   6h   5      5      �� 5      
�������
�������$��Center=�5      $ 7, 10q�5      $��25, 7q�6   ._�5      �� .+�5      �� $��Địa chỉ:��6   $��15(�6/   6?   �� 5      -   5        $ address��5      $��15(�6/   $��
0, 0, 0, 1q�6=   $
��5, 7q�6Z   6k   5      5      �� 5      
�������
�������$��Center=�5       $ 7, 10q�5!      $��25, 7q�6   ._�5"      �� .+�5#      �� $��Số tầng:��6   $��15(�6/   6?   �� 5$      -   5        $ 	no_floors��5$      $��15(�61   $��
0, 0, 0, 1q�6?   $
��5, 7q�6\   6m   5%      5&      �� 5'      
�������
�������$��Center=�5(      $ 7, 10q�5)      $��25, 7q�6   ._�5*      �� .+�5+      �� $"��Số căn hộ mỗi tầng:��6   $��15(�6:   6J   �� 5,      -   5        $ no_apartment_per_floor��5,      $��15(�6>   $��
0, 0, 0, 1q�6L   $
��5, 7q�6i   6z   5-      5.      5/      �� 50   
   $��1��6   
������� �� Orientation$ 
Horizontal=�65   $��Center=�6N   .+�51      �  � ColumnDefinitions 52      �� 53      $��* �6'   63   �� 54      $��* �6'   63   .+�56      *   $System.Windows.Controls.CreateAction  *   $System.Windows.Controls.CreateAction   Click$ Create_Clicked��6(   $��Center=�6?   $��0��6\   *   $System.Windows.Controls.ActionButton	   Width$		 150Q�57      $��15(�6+   
   
Background

 �����$��	0,0,10,15q�6L      Text$ Xác nhận��6_   6q   *   $System.Windows.Controls.CancelAction  58      *   $System.Windows.Controls.CancelAction   Click$ Cancel_Clicked��6(   $��Center=�6?   $��1��6\   $		 150Q�59      $��15(�6+   

 �����$��	10,0,0,15q�6L   6a   5:      5;      5<      5=      