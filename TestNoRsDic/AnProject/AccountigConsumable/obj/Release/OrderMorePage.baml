   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  '    !AccountigConsumable.OrderMorePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable       N� Title$  OrderMorePage�� � 	Resources  �� MergedDictionaries��  %    .���  � RowDefinitions �� $
��200* ��� $
��600* �.+�� $��0�� � ColumnDefinitions �� $
��209* ��� $
��313* ��� $
��278* � �� $��50 ��� $��50 �.+��� $��0��$��Рабочее место���� $��1��$��ФИО работника���� $��2��$��Должность���� -   $��CmbPlace��$��1��$��0�� �� DisplayMemberPath$ NumberPlace�� �� SelectedItem �� *	WorkPlace+�� -   $��CmbFIO��$��1��$��1��$	 FIO�� �� *WorkPlace.Worker+�� -   $��CmbPosition��$��1��$��2��$ PositionName�� �� *WorkPlace.Worker.Position+�� ���#6A779E$��2q�$��1��$��10q�._�&   System.Windows.Controls.DataGrid  -     Name$ DGridConsumable��$��1��   AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$1 +Наименование материала��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *%#MaterialCard.Materials.MaterialName+  $% Группа материала��$
 auto  �� *:8MaterialCard.Materials.MaterialGroup.NameOfMaterialGroup+  $ Кол-во��$
 auto  �� *OrderedQuantity+  $ Ед измерения��$
 auto  �� *&$MaterialCard.Materials.Unit.UnitName+  $! Место хранения��$
 auto  �� *#!Order.Warehouse.NumberOfWarehouse+