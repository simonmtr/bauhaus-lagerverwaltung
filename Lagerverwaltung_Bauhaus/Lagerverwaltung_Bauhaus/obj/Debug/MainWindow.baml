   M S B A M L   `   `   `  ����R  NLagerverwaltung_Bauhaus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lagerverwaltung_BauhausLagerverwaltung_Bauhaus  5   	   (    "Lagerverwaltung_Bauhaus.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lagerverwaltung_Bauhaus     5   	     � Title$  Café Bauhaus��5       � Icon$# Ressourcen/Bilder/Bauhaus.JPG��6   $��
Tekton Pro)�6B   $��20(�6Z   .��5
      � -   5         �Name$ MainWindow_Grid��5
      .+�5   
   �� -   5         ��Name$ 
TabControl��5      .@�5      �� -   5         ��Name$ TabItem_Welcome��5      $��
Willkommen��6/   ���	#FFCC0001$��
Tekton Pro)�6Z   $��20(�6r   $��Center=�6�   $��Center=�6�   ���	#FFCC0001
���   �$��45��6�   .��5      � -   5        $ TabWelcome_Grid��5      .+�5      4   .Lagerverwaltung_Bauhaus.UserControl_TabWelcome  5      5      �� 5      -   5        $ TabItem_Drinks��5      $��	Getränke��6.   ���	#FFCC0001$��
Tekton Pro)�6W   $��20(�6o   $��Center=�6}   $��Center=�6�   ���	#FFCC0001
���   �$��45��6�   .��5      � -   5        $ TabDrinks_Grid��5      .+�5      3   -Lagerverwaltung_Bauhaus.UserControl_TabDrinks  5      5      �� 5      -   5        $ TabItem_Snacks��5      $��Snacks��6.   ���	#FFCC0001$��
Tekton Pro)�6U   $��20(�6m   $��Center=�6{   $��Center=�6�   ���	#FFCC0001
���   �$��45��6�   .��5      � -   5        $ TabSnacks_Grid��5      .+�5      3   -Lagerverwaltung_Bauhaus.UserControl_TabSnacks  5      5      �� 5      -	   5        $ TabItem_Add��5      $��Hinzufügen��6+   ���	#FFCC0001$��
Tekton Pro)�6V   $��20(�6n   $��Center=�6|   $��Center=�6�   ���	#FFCC0001
���   �$��45��6�   .��5       � -
   5        $ TabAdd_Grid��5       .+�5!      0   *Lagerverwaltung_Bauhaus.UserControl_TabAdd  5"      5#      �� 5%      -   5        $ TabItem_Remove��5%      $��	Entfernen��6.   ���	#FFCC0001$��
Tekton Pro)�6X   $��20(�6p   $��Center=�6~   $��Center=�6�   ���	#FFCC0001
���   �$��45��6�   .��5&      � -   5        $ TabRemove_Grid��5&      .+�5'      3   -Lagerverwaltung_Bauhaus.UserControl_TabRemove  5(      5)      5+      5-      5.      