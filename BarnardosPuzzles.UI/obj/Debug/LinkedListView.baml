   M S B A M L   `   `   `  ����  BarnardosPuzzles.UI(    "BarnardosPuzzles.UI.LinkedListView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � WindowStartupLocation$  CenterScreen=�6@    � Title$% Barnardos Puzzles - Linked List��5   	   $	��300��61   $	��400��6>   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      �� 5      .+�5   
   �� $����Please use the text box and the add button to add items to the list and finally use the Get 5th Element button to show the results��6   $
��Wrap=�6�   $��Center=�6�   $��Stretch=�6�   $��2��6�   $��0��6   �� 5   
   $��1��6   $��0��6#    �� Orientation$ 
Horizontal=�63   .+�5      �� $��Insert Element:��6   $��Center=�6/   �� 5      -   5         ��Name$ txtElements��5      $�� ��6+   $��60��63   $��20��6>   $��Center=�6J   $��5,0,0,0q�6e   5      �� 5   
   $��1��6   $��1��6"   $ Vertical=�62   $��Center=�6I   .+�5      �� -   5         ��Name$ 	AddButton��5      $	��Add��6(   67   �� 5      -   5        $ ClearButton��5      $��Clear��6*   6;   �� 5      -   5        $ Get5thElementButton��5      $��Get 5th Element��62   6L   5      �� 5   
   -   5         ��Name$ 
txtElement��5      $��2��6(   $��2��6<   5      5      