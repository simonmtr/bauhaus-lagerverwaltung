   M S B A M L   `   `   `  ����R  NLagerverwaltung_Bauhaus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lagerverwaltung_BauhausLagerverwaltung_Bauhaus  5      /    )Lagerverwaltung_Bauhaus.UserControl_PopUp   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Lagerverwaltung_Bauhaus     5      .��5
      � -   5          �Name$  PopUp_outer_Grid��5
      .+�5   
   � -   5         �Name$ PopUp_stock��5      .��5      � -   5        $  PopUp_inner_Grid��5      ���	#FFCC0001$	��300��6D   $	��500��6Q   .+�5      �� -   5         ��Name$ label_PopUp_attention��5      $4��. !!! Achtung !!! 
Folgende Bestände niedrig:��67   $	��Top=�6w   $��
Tekton Pro)�6�   $��24(�6�   $
��Bold"�6�   
�������6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dataGrid_PopUp��5      
����������	#FFCC0001$��
Tekton Pro)�6^   $��20(�6v   $��
0,72.6,0,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        DataGridTextColumn_Getränk��,  &System.Windows.Controls.DataGridColumn   Header$ Getränk��5   Q      
FontFamily$ 
Tekton Pro)�6b      FontSize$ 20Q�6z     5      -   5        DataGridTextColumn_Snack��$ Snack��5   O   $ 
Tekton Pro)�6^   $ 20Q�6v     5      -   5        DataGridTextColumn_Marke��$ Marke��5   O   $ 
Tekton Pro)�6^   $ 20Q�6v     5      -	   5        DataGridTextColumn_Bestand��$ Bestand��5   Q   $ 
Tekton Pro)�6b   $ 20Q�6z   5      5      5      5      5      