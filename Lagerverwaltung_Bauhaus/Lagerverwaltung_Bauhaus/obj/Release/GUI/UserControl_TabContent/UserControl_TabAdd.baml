   M S B A M L   `   `   `  ���� R  NLagerverwaltung_Bauhaus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lagerverwaltung_BauhausLagerverwaltung_Bauhaus  0    *Lagerverwaltung_Bauhaus.UserControl_TabAdd   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7local%clr-namespace:Lagerverwaltung_Bauhaus     $��
Tekton Pro)�$��20(�.��� -     �Name$  Add_OuterGrid�� � RowDefinitions �� $	��60* ��� $	��40* �.+��� -    ��Name$D >GUI_LagerVerwaltungBauhaus_component_Pictures_Bauhaus_Ohne_JPG��$��4��$��2��$)��#/Ressourcen/Bilder/Bauhaus_Ohne.JPG��$
��Fill=�� -   $  Add_Inner_TopGrid��$��0��$��2�� � ColumnDefinitions �� �� �� ��  �� �� �� �� �� �� �� �� .+��� -    ��Name$ Label_Add_drinksTitle��$��Getränke Auswahl :��$��2��$��0��$��0��$��
Tekton Pro)�$��30(�
�������$
��Left=�$��Bottom=��� -   $ Label_Add_Art��$	��Art��$��1��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -    ��Name$ comboBox_Add_drinkArt��$��2��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $
��Bier��$
��Left=� �� 
IsSelected . �� $
��Wein��$
��Left=��� $��Spirituosen��$
��Left=��� $
��Saft��$
��Left=��� $��	Softdrink��$
��Left=��� $��Wasser��$
��Left=��� $��Kaffee��$
��Left=��� -   $ Label_Add_Marke��$��Marke��$��3��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $ comboBox_Add_Brand��$��4��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $��Augustiner Helles��$
��Left=� . �� $��Tegernseeer Helles��$
��Left=��� $��Franziskaner Weißbier��$
��Left=��� $%��Franziskaner leichtes Weißbier��$
��Left=��� $��Weiswein��$
��Left=��� $��Rotwein��$
��Left=��� $��Absolut Vodka��$
��Left=��� $��Havanna Club Rum��$
��Left=��� $��Tullamore Dew Whiskey��$
��Left=��� $��	Apfelsaft��$
��Left=��� $��Orangensaft��$
��Left=��� $��CocaCola��$
��Left=��� $��CocaCola light��$
��Left=��� $��Orangenlimo��$
��Left=��� $��Zitronenlimo��$
��Left=��� $��Adelhozener medium��$
��Left=��� $��Adelholzener still��$
��Left=��� $��Kaffee Crema��$
��Left=��� -	   $ Label_Add_Amount��$��Menge��$��5��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -
   $ comboBox_Add_drinkAmount��$��6��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $��1��$
��Left=� . �� $��2��$
��Left=��� $��3��$
��Left=��� $��4��$
��Left=��� $��5��$
��Left=��� $��6��$
��Left=��� $��7��$
��Left=��� $��8��$
��Left=��� $��9��$
��Left=��� $��10��$
��Left=��� -   $ Label_Add_alcohol��$��alkoholisch ?��$��1��$��1��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $ comboBox_Add_alcohol��$��1��$��2��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $��Ja��$
��Left=� . �� $
��Nein��$
��Left=��� -   $ Label_Add_bottleSize��$��Flaschengröße��$��1��$��3��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $ comboBox_Add_bottleSize��$��1��$��4��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $	��0.3��$
��Left=��� $	��0.5��$
��Left=� . �� $	��0.7��$
��Left=��� -   $ Label_Add_storageLocation��$��Lagerort��$��1��$��5��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $' !comboBox_Add_drinkStorageLocation��$��1��$��6��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $	��Bar��$
��Left=��� $��Kühlschrank��$
��Left=��� $��Lager��$
��Left=� . �� -   $ Label_Add_snacksTitle��$��Snack Auswahl :��$��2��$��2��$��0��$��
Tekton Pro)�$��30(�
�������$
��Left=�$��Bottom=��� -   $ Label_Add_saltySweet��$��Salzig?��$��2��$��1��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $ comboBox_Add_saltySweet��$��2��$��2��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $��Ja��$
��Left=� . �� $
��Nein��$
��Left=��� -   $ Label_Add_snackArt��$��	Snack Art��$��2��$��3��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $ comboBox_Add_snackArt��$��2��$��4��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $��Gummibären��$
��Left=��� $��	Erdnüsse��$
��Left=��� $��Salzstangen��$
��Left=��� $��Erdnussflips��$
��Left=��� $��Chips��$
��Left=� . �� -   $ Label_Add_taste��$��	Geschmack��$��2��$��5��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $ comboBox_Add_taste��$��2��$��6��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $��Paprika��$
��Left=� . �� $��natur��$
��Left=��� -   $ Label_Add_snackAmount��$��Anzahl��$��3��$��1��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $ comboBox_Add_snackAmount��$��3��$��2��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $��1��$
��Left=� . �� $��2��$
��Left=��� $��3��$
��Left=��� $��4��$
��Left=��� $��5��$
��Left=��� $��6��$
��Left=��� $��7��$
��Left=��� $��8��$
��Left=��� $��9��$
��Left=��� $��10��$
��Left=��� -   $ Label_Add_snackStorage��$��Lagerort��$��3��$��3��$��
Tekton Pro)�$��20(�
�������$
��Left=�$��Bottom=��� -   $ comboBox_Add_snackStorage��$��3��$��4��$��
Tekton Pro)�$��25(����	#FFCC0001.@��� $	��Bar��$
��Left=� . �� $��Lager��$
��Left=�� -   $  Add_Inner_LowerGrid��$��1��$��2��$��3�� �� $	��33* ��� $	��33* ��� $	��33* � �� �� .+��� -    ��Name$ button_Add_Increase_Drink��$��Getränke Buchen��$��1��$��0��$��
Tekton Pro)�$��20(�
����������	#FFCC0001$��45��$	��180��$��Right=�$��Center=�$��0,0,10,0q��� -   $ button_Add_Increase_Snack��$��Snacks Buchen��$��1��$��1��$��
Tekton Pro)�$��20(�
����������	#FFCC0001$��45��$	��180��$��Right=�$��Center=�$��0,0,10,0q�