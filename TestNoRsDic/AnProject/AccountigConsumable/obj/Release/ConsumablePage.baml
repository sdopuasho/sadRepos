   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  (    "AccountigConsumable.ConsumablePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable     -     N� Title$  ConsumablePage�� � 	Resources  �� MergedDictionaries��  %    .���  � ColumnDefinitions �� $��* ��� $	��190 �.+��� ���#6A779E$��2q�$��10q�._�&   System.Windows.Controls.DataGrid  -     Name$ DGridConsumable����.     AutoGenerateColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Materials.MaterialName+  $% Ивентарный номер��$
	 auto 
 �� *InventNumber+  $  Производитель��$
	 auto 
 �� *)'Materials.Manufacturer.ManufacturerName+  $ Группа��$
	 auto 
 �� *-+Materials.MaterialGroup.NameOfMaterialGroup+  $' !Единица измерения��$
	 auto 
 �� *Materials.Unit.UnitName+4  .System.Windows.Controls.DataGridTemplateColumn  $
	 auto    CellTemplate �� .R��� $��BtnEdit��-   $ ��Редактировать����  �� Orientation$ Vertical=�$��1��$��5q�.+��� $��2q����#6A779E$��5q�._��� $ Vertical=�$��10q�.+��� -    ��Name$ BtnConsumable��$��Материал��$��Center=�$��Center=��� -   $ BtnAbout��$��Расход��$��Center=�$��Center=��� -   $ BtnIssue��$��Выданный��$��Center=�$��Center=��� $��2q����#6A779E$��5q�._��� $ Vertical=�$��1��$��15q�.+��� -    ��Name$ NameTxt��$��Center=�$��Center=�$	��120��$��25��$��10q��� -    ��Name$ ManufacturerCmb�� �� DisplayMemberPath$ ManufacturerName�� �� SelectedIndex$ 0��$��Center=�$	��120��$��25��$��10q��� -	   $ 	ReportBtn��$��10q�$��
Отчет���� -
   $��BtnAdd��$��Добавить��$��Center=�$��10q�$��Center=��� -   $��BtnDel��$��Удалить��$��Center=�$��10q�$��Center=�