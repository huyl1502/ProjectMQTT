   M S B A M L   `   `   `  ����E  AFireDetect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System.Windows.ControlsSystem.Windows.Controls  5   	   *    $System.Windows.Controls.MyMessageBox   2Controls%clr-namespace:System.Windows.Controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Message��5   	   $	��250��6   $	��400��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � ShowInTaskbar .  $��Calbiri)�6�   .��5      �  � RowDefinitions 5	   
   �� 5
      $��3* �6   �� 5      $��2* �6   .+�5   
   � $��0��6   $��13q�6   $��3��6(   .+�5      �� -   5         ��Name$ Message��5      $��Message��6)   $	�� 15(�68   6J   5      �� 5   
   $��2��6   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   63   �� 5      $��* �6'   63   .+�5      *   $System.Windows.Controls.CreateAction  -   5          Name$ OK��5   (   *   $System.Windows.Controls.ActionButton   Text$ OK��64   $��Center=�6>   $��0��6[   	   Width$		 150Q�5      $��15(�6+   
   
Background

 �����$��5q�6L   6Y   *   $System.Windows.Controls.CancelAction  5      -   5          Name$ Cancel��5   (   $ Cancel��68   $��Center=�6F   $��1��6c   $		 150Q�5      $��15(�6+   

 �����$��5q�6L   6Y   5      5      5&      5'      