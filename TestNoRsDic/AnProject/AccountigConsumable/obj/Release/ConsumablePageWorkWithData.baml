   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  4    .AccountigConsumable.ConsumablePageWorkWithData   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable       N� Title$   ConsumablePageWorkWithData�� � 	Resources  �� MergedDictionaries��  %    .���  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $	��50* ��� $
��163* �.+��� $��Наименование���� $'��!Инвентарный номер��$��1���� $ ��Производитель��$��2���� $��Группа��$��3���� $��Ед Измерения��$��4����  �� Orientation$ Vertical=�$��0��$��1��.+��� -    ��Name$ CmbNameMaterial��$��0��$��0��$��1��$
��Left=�$��10q�$	��250��$��30�� �� DisplayMemberPath$ MaterialName�� �� SelectedItem �� *	Materials+�� -   	 ��Name$	 MaterialnameFail��
���  ��$y�	Collapsed=��� $ Vertical=�$��1��$��1��.+��� -   
 ��Name$
 TxtInventNumber��$��1��$
��Left=�$	��250��$��10q����� *InventNumber+�� -   $	 InventNumberFail��
���  ��$y�	Collapsed=��� $ Vertical=�$��1��$��2��.+��� -   $ CmbManufacturer��$��2��$
��Left=�$��10q�$	��250��$��30��$ ManufacturerName�� �� *Materials.Manufacturer+�� -   $	 ManufacturerFail��
���  ��$y�	Collapsed=��� $ Vertical=�$��3��$��1��.+��� -   $ CmbGroup��$��3��$	��250��$��10q�$
��Left=�$ NameOfMaterialGroup�� �� *Materials.MaterialGroup+�� -   $	 MaterialGroupFail��
���  ��$y�	Collapsed=��� $ Vertical=�$��1��$��4��.+��� -	   $ CmbUnit��$��4��$
��Left=�$��10q�$	��250��$��30��$ UnitName�� �� *Materials.Unit+�� -
   $	 UnitFail��
���  ��$y�	Collapsed=��� -   $��BtnSave��$��5��$	��120��$��Сохранить��$��2��$��5��