   M S B A M L   `   `   `  ����A  =CYCLOP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CYCLOP.ViewsCYCLOP.Views  5   	       CYCLOP.Views.Test   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CYCLOP.Views     5   	     � Title$
  Test��5   	   $	��350��6   $	��525��6#   .��5	      � .+�5
   
   �  � ColumnDefinitions 5      �� 5      $
��250* �6#   62   �� 5      $
��350* �6#   .+�5      �� $��0��6   $��15,15,15.4,15.4q�6)   .+�5      �  5      �� 5      6-   �� 5      6-   .+�5      �� $��50��6   $��35��6(   $
��Left=�64   ��6P   �� *PreviousEvent+6u   �� 5      $��50��6   $��35��6(   $��1��65   $��Right=�6E   ��6a   �� *	NextEvent+6�   5      �� 5      First Name:6)   �� 5      -   5        $��Txt_Firstname��5      ��6/   �� *SelectedItem.FirstName+ �� Mode$ TwoWay=�6e   �� 5      
Last Name:6(   �� 5      -   5        $��Txt_Lastname��5      ��6.   �� *SelectedItem.LastName+$ TwoWay=�6c   �� 5      
Address:6&   �� 5      -   5        $��Txt_Address��5      ��6-   �� *SelectedItem.Address+$ TwoWay=�6b   �� 5      Telephone No:6+   �� 5       -   5        $��Txt_Tpno��5       ��6*   �� *SelectedItem.TP_NO+$ TwoWay=�6]   � 5!      $��80��6    5"      �� 5#      6.   �� 5$      6.   �� 5%      6.    � RowDefinitions 5'      �� 5(      6*   �� 5)      6*   .+�5+      �� -   5        $��Btn_Refresh��5+      $��0��60   $��5q�6@   .��6K   	Refresh6T   �� 5,      -   5        $��
Btn_Delete��5,      $��1��6/   $��5q�6?   .��6J   Delete6R   �� 5-      -   5        $��Btn_Add��5-      $��2��6-   $��5q�6=   ��6H   �� *
AddEvent+.��6e   Add6j   �� 5.      -   5        $��Btn_Save��5.      $��0��6-   $��1��6=   $��3��6J   $��5q�6^   ��6i   �� *	SaveEvent+.��6�   Save6�   51      56      &   System.Windows.Controls.DataGrid  57      -	   5        $��Dg_Users��57      $��1��6'   $��10q�67      RowDetailsVisibilityMode$ VisibleWhenSelected=�6C      EnableRowVirtualization .    AutoGenerateColumns .  ��6�   �� *Collection.View+ �� SelectedItem 6�   �� *SelectedItem.FirstName+   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      -
   5        id��,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��59   L   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 Auto 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+6g     5:      -   5        	firstname��$	 
First Name��5:   Z   $

 Auto 6n    6<   �� *	FirstName+6}     5;      -   5        lastname��$	 	Last Name��5;   X   $

 Auto 6k    6;   �� *
LastName+6z     5<      -   5        address��$	 Address��5<   V   $

 Auto 6g    6:   �� *	Address+6v     5=      -   5        tpno��$	 TP NO��5=   Q   $

 Auto 6`    67   �� *TP_NO+6o   5?      5@      5A      5B      