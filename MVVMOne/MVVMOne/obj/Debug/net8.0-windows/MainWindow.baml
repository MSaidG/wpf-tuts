   M S B A M L   `   `   `  ����B  >MVVMOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MVVMOneMVVMOne  5   	       MVVMOne.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MVVMOne     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� $	��Add��6   $��75��6#   $��30��6.   $��0,0,5,0q�6:   ��5      �� *
AddCommand+�� 5      $��Delete��6   $��75��6&   $��30��61   $��0,0,5,0q�6=   ��5      �� *DeleteCommand+�� 5      $
��Save��6   $��75��6$   $��30��6/   $��0,0,5,0q�6;   ��5      �� *SaveCommand+5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��70* �6#   �� 5      $	��30* �6#   .+�5      &   System.Windows.Controls.DataGrid     CanUserAddRows$ False��5!         CanUserDeleteRows$ False��6(      AutoGenerateColumns$ False��5"      ��5      �� *Items+ �� SelectedItem 5       �� *SelectedItem+   Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 4* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6P     5%      $	 Serial Number��6)   $
 4* 6a    6@   �� *SerialNumber+6a     5&      $	 Quantity��6)   $
 2* 6X    6;   �� *
Quantity+6X   5(      �� 5*      $��1��6   .+�5+      �� $
��Name��6   �� 5,      $��5,0,5,15q�6   ��6,   �� *SelectedItem.Name+ �� UpdateSourceTrigger$ PropertyChanged=��� 5-      $��Serial Number��6   �� 5.      $��5,0,5,15q�6   ��6,   �� *SelectedItem.SerialNumber+$ PropertyChanged=��� 5/      $��Quantity��6   �� 50      $��5,0,5,15q�6   ��6,   �� *SelectedItem.Quantity+$ PropertyChanged=�51      53      55      56      