   M S B A M L   `   `   `  ����E  AFireDetect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System.Windows.ControlsSystem.Windows.Controls  5   	   C&clr-namespace:FireDetect.Views.AccountFireDetect.Views.Account  5   	   (    "FireDetect.Views.Account.LoginForm   5   	   2Controls%clr-namespace:System.Windows.Controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:FireDetect.Views.Account     5   	     � Title$  Login��5   	   $	��600��6   $	��450��6$    � WindowStartupLocation$ CenterScreen=�60   .��5	      � -   5         �Name$ MainContent��5	      ���#333399 � RowDefinitions 5
   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��Center=�5      .+�5      �� $��Center=�6   $��Center=�5      
�������$��25(�5   '   .��65   
Welcome!5      5      �� 5   
   $��1��6   
�������.+�5      �� 
�������$��Center=�5       �� Padding$ 7, 10q�5      $��25, 7q�6   ._�5      �� .+�5      �� $��Tài khoản:��6   $��14(�61   6A   �� 5      -   5         ��Name$ un��5      $��14(�6*   $��
0, 0, 0, 1q�68   $
��5, 7q�6U   6f   5      5      �� 5       
�������$��Center=�5!      $ 7, 10q�5"      $��25, 7q�6   ._�5#      �� .+�5$      �� $��14(�6   $��Mật khẩu:��6*   6@   G� 5%      -   5         G�Name$ pw��5%   "   $��14(�6.   $��
0, 0, 0, 1q�6<   $
��5, 7q�6Y   6j   5&      5'      5(      �� 5)   
   $��2��6   
�������.+�5*      )   #System.Windows.Controls.LoginButton  )   #System.Windows.Controls.LoginButton   Click$ Login_Clicked��6#   $��15(�69   *   $System.Windows.Controls.ActionButton   Width$	 150Q�5+      	   
Background
	 �����$��0,30,0,0q�6>   6R   50      51      52      