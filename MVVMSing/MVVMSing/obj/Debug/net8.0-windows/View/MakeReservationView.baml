   M S B A M L   `   `   `  ����C  ?MVVMSing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MVVMSing.ViewMVVMSing.View  5      '    !MVVMSing.View.MakeReservationView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MVVMSing.View     5      .��5	      �   � IsSharedSizeScope$
  True��6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    
  Header#��[  6!   $��Make Reservation��6A   � 5   
   $��1��6   $��0,25,0,0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��Username��6%   �� 5      $��1��6   $��0,5,0,0q�6#   ��64   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5      � 5   
   $��2��6   $��0,10,0,0q�6    5      �� 5       $
��auto �6    �� 5!      $
��auto �6     � ColumnDefinitions 5#      �� 5$      $
��auto �6#    z� SharedSizeGroup$ FirstColumn��60   �� 5%      $
��auto �6#   $ SecondColumn��60   .+�5(      �� $��0��6   $��0��6%   $��	Floor No.��65   �� 5)      $��1��6   $��0��6#   $��0,5,0,0q�63   ��6D   �� *FloorNumber+$ PropertyChanged=��� 5+      $��0��6   $��1��6%   $��Room No.��65   $��10,0,0,0q�6E   �� 5,      $��1��6   $��1��6#   $��10,5,0,0q�63   ��6E   �� *
RoomNumber+$ PropertyChanged=�5-      � 5/   
   $��3��6   $��0,10,0,0q�6    50      �� 51      $
��auto �6    �� 52      $
��auto �6     54      �� 55      $
��auto �6#   $ FirstColumn��60   �� 56      $
��auto �6#   $ SecondColumn��60   .+�59      �� $��0��6   $��0��6%   $��
Start Date��65   (  "System.Windows.Controls.DatePicker  5:      $��1��6   $��0��6&   $��0,5,0,0q�6~      SelectedDate 66   �� *	StartDate+$ PropertyChanged=�6~   �� 5<      $��0��6   $��1��6%   $��End Date��65   $��10,0,0,0q�6E     5=      $��1��6   $��1��6&   $��10,5,0,0q�6|    66   �� *	EndDate+$ PropertyChanged=�6|   5>      �� 5@   
   $��4��6    �� Orientation$ 
Horizontal=�6"   $��0,25,0,0q�6;   .+�5A      �� $��Submit��6   ��6&   �� *SubmitCommand+�� 5B      $��Cancel��6   $��10,0,0,0q�6&   ��68   �� *CancelCommand+5C      5D      5E      