   M S B A M L   `   `   `  ���� R  NLagerverwaltung_Bauhaus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lagerverwaltung_BauhausLagerverwaltung_Bauhaus  3    -Lagerverwaltung_Bauhaus.UserControl_TabDrinks   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7local%clr-namespace:Lagerverwaltung_Bauhaus     $��
Tekton Pro)�$��20(����	#FFCC0001.��� -     �Name$  Drinks_OuterGrid�� � RowDefinitions �� $	��75* ��� $	��25* �.+�� -   $  Drinks_InnerGrid��$��0��$��
10,10,10,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ Drinks_dataTableGrid��
����������	#FFCC0001   
IsReadOnly . � -   $  Drinks_Button_Grid��$��1�� �� $��* ��� $��* ��� $��* � � ColumnDefinitions �� �� $	��180 ��� $��* ��� $	��180 ��� $��* ��� $	��180 ��� $��* ��� $	��180 ��� .+��� -    ��Name$ button_Drinks_fridge��$��1��$��1��$��Kühlschrank��$��
Tekton Pro)�$��20(�
����������	#FFCC0001$��45��$	��180���� -   $ button_Drinks_bar��$��3��$��1��$	��Bar��$��
Tekton Pro)�$��20(�
����������	#FFCC0001$��45��$	��180���� -   $ button_Drinks_stock��$��5��$��1��$��Lager��$��
Tekton Pro)�$��20(�
����������	#FFCC0001$��45��$	��180���� -   $ button_Drinks_total��$��7��$��1��$��Gesamt��$��
Tekton Pro)�$��20(�
����������	#FFCC0001$��45��$	��180��