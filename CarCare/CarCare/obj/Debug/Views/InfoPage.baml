   M S B A M L   `   `   `  ����B  >CarCare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CarCareCarCare  5          CarCare.Views.InfoPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:CarCare     5        N� Title$  InfoPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��Center=�6%   $��Center=�6B   
�������$	��300��6p   .+�5   
   �� .��6   Fahrzeuggruppe6    �� 5   
   -   5        $��group��5       �� 
IsReadOnly . $	��5,0q�61   6@   �� 5   
   .��6   	Teilename6   �� 5   
   -   5        $��partname��5       . $	��5,0q�64   6C   �� 5   
   .��6   Austausch in6   �� 5      -   5        $��changein��5       . $	��5,0q�69   6H   �� 5      .��6   Zuletzt ausgetauscht6*   (  "System.Windows.Controls.DatePicker  5      -   5        $��
changelast��5      $	��5,0q�6+   �� 5      .��6   Kilometerstand6$   �� 5   
   -   5        $	��odo��5      $	��5,0q�6   �� 5   
   .��6   Weitere Infos6   �� 5   
   -   5        $��infos��5      $	��5,0q�6   � 5   
   $��0,10,0,5q�6    � RowDefinitions 5      �� 5      $��30 �6    �� 5       $��30 �6     5"      �� 5#      $��* �6#   �� 5$      $��* �6#   .+�5&      � $��5,0,2.5,2.5q�6   .+�5'      �� -   5        $��
bearbeiten��5'      $��
Bearbeiten��6D    � 	Resources 5(       �� 
TargetType �� Property �� Value��%^   '��       �� 5)      " ��6    .�5*      ��  �@��CornerRadius$ 3��6=   5+      5,      5-      5.      � 5/      $��1��6   $��5,2.5,2.5,0q�6    .+�50      �� -   5        $��
Schließen��50   1    51      ��%^   '��       �� 52      " ��6    .�53      ��  �@��CornerRadius$ 3��6=   54      55      56      57      � 58      -	   5        $��loeschen��58      $��1��6#   $��2.5,0,5,2.5q�63   .+�59      �� -
   5        $��Löschen��59   0    5:      ��%^   '��       �� 5;      " ��6    .�5<      ��  �@��CornerRadius$ 3��6=   5=      5>      5?      5@      � 5A      -   5        $��hinzufuegen��5A      $��1��6&   $��1��63   $��2.5,2.5,5,0q�6C   .+�5B      �� -   5        $��Hinzufügen��5B   3    5C      ��%^   '��       �� 5D      " ��6    .�5E      ��  �@��CornerRadius$ 3��6=   5F      5G      5H      5I      5J      5M      &   System.Windows.Controls.DataGrid  5N   
   -   5        $��dg_serviceList��5N   ?   $��1��6      AutoGenerateColumns .  	   Columns	 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Tauschen am��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Frist+ �� StringFormat$ {0:dd/MM/yyyy}��  5Q      $
 Zuletzt getauscht��6%    6@   �� *	Zuletzt+$ {0:dd/MM/yyyy}��  5R      $
 Kilometerstand��6%    6=   �� *Kilometerstand+  5S      $
 Informationen��6%    6<   �� *Info+5U      5V      5W      