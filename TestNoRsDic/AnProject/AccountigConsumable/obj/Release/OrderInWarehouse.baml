   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  *    $AccountigConsumable.OrderInWarehouse   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable     -     N� Title$  OrderInWarehouse�� � 	Resources  �� MergedDictionaries��  %    .���  � ColumnDefinitions �� $��* ��� $	��190 �.+��� ���#6A779E$��2q�$��10q�._�&   System.Windows.Controls.DataGrid  -     Name$ DGridConsumable��   AutoGenerateColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$# Номер хранилища��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Warehouse.NumberOfWarehouse+  $% Контактный номер��$
	 auto 
 �� *Warehouse.ContactNumber+  $# Номер контракта��$
	 auto 
 �� *ContractNumber+4  .System.Windows.Controls.DataGridTemplateColumn  -   DPicker1��$ Дата поставки��$		 150    CellTemplate �� .R�(  "System.Windows.Controls.DatePicker     SelectedDate �� * DateOfAcceptanceToTheWarehouse+  $ ФИО��$
	 auto 
 �� *
Worker.FIO+  -   Dy��$ Утверждено?��$		 150  �� .R���  d� 	IsChecked ��  �� Path$ 	Certified� �� Mode$ TwoWay=�  $
	 auto  �� .R��� $��BtnEdit��-   $ ��Редактировать����  �� Orientation$ Vertical=�$��1��$��5q�.+��� $��2q����#6A779E$��5q�._��� $ Vertical=�$��10q�.+��� -    ��Name$ BtnOrder��$��Заказы��$��Center=�$��Center=��� -   $ BtnSupplWarehouse��$��Поставки��$��Center=�$��Center=��� -   $ BtnInventarization��$"��Инвентаризация��$��Center=�$��Center=��� $��2q����#6A779E$��5q�._��� $ Vertical=�$��1��$��10q�.+��� -	    ��Name$ FIOCmb��$��10q� �� DisplayMemberPath$	 FIO�� �� SelectedIndex$ 0��$	��120���� -
   $ 	RaportBtn��$��Center=�$��Center=�$��
Отчет���� -   $ 
RaportBtn2��$��Center=�$��Center=�$��
Отчет���� -   $��BtnAdd��$��Добавить��$��Center=�$��Center=��� -   $��BtnDel��$��Удалить��$��1��$��Center=�$��Center=�