   M S B A M L   `   `   `  ����R  NLagerverwaltung_Bauhaus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lagerverwaltung_BauhausLagerverwaltung_Bauhaus  5      3    -Lagerverwaltung_Bauhaus.UserControl_TabDrinks   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Lagerverwaltung_Bauhaus     5      $��
Tekton Pro)�5   8   $��20(�6P   ���	#FFCC0001.��5
      � -   5          �Name$  Drinks_OuterGrid��5
       � RowDefinitions 5   
   �� 5      $	��75* �6   �� 5      $	��25* �6   .+�5   
   � -   5        $  Drinks_InnerGrid��5      $��0��6)   $��
10,10,10,0q�66   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Drinks_dataTableGrid��5      
����������	#FFCC0001   
IsReadOnly . 5      5      � 5   
   -   5        $  Drinks_Button_Grid��5      $��1��6    5      �� 5      $��* �6    �� 5      $��* �6    �� 5       $��* �6     � ColumnDefinitions 5#      �� 5$      �� 5&      $	��180 �6#   �� 5(      $��* �6#   �� 5*      $	��180 �6#   �� 5,      $��* �6#   �� 5.      $	��180 �6#   �� 50      $��* �6#   �� 52      $	��180 �6#   �� 54      .+�59      �� -   5         ��Name$ button_Drinks_fridge��59   2   $��1��6   $��1��6%   $��Kühlschrank��6P   $��
Tekton Pro)�6f   $��20(�6~   
����������	#FFCC0001$��45��6�   $	��180��6�   6�   �� 5:      -   5        $ button_Drinks_bar��5:   2   $��3��6   $��1��6%   $	��Bar��6M   $��
Tekton Pro)�6[   $��20(�6s   
����������	#FFCC0001$��45��6�   $	��180��6�   6�   �� 5;      -   5        $ button_Drinks_stock��5;   2   $��5��6   $��1��6%   $��Lager��6O   $��
Tekton Pro)�6_   $��20(�6w   
����������	#FFCC0001$��45��6�   $	��180��6�   6�   �� 5<      -   5        $ button_Drinks_total��5<   2   $��7��6   $��1��6%   $��Gesamt��6O   $��
Tekton Pro)�6`   $��20(�6x   
����������	#FFCC0001$��45��6�   $	��180��6�   6�   5=      5@      5A      