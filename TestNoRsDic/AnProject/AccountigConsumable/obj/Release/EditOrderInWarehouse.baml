   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  .    (AccountigConsumable.EditOrderInWarehouse   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable       N� Title$  EditOrderInWarehouse�� � 	Resources  �� MergedDictionaries��  %    .���  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $	��50* ��� $
��163* �.+��� $#��Номер хранилища���� $%��Контактный номер��$��1���� $#��Номер контракта��$��2���� $��Дата поставки��$��3���� $��ФИО��$��4���� $��Проверенно?��$��5����  �� Orientation$ Vertical=�$��0��$��1��.+��� -   $
��Left=�$��10q�$	��250������ *Warehouse.NumberOfWarehouse+�� -    ��Name$ NumberWarehouseFail��
���  ��$y�	Collapsed=��� $ Vertical=�$��1��$��1��.+��� -   $
��Left=�$��10q�$	��250������ *Warehouse.ContactNumber+�� -   $ ContactPhoneFail��
���  ��$y�	Collapsed=��� $ Vertical=�$��2��$��1��.+��� -   $
��Left=�$��10q�$	��250������ *ContractNumber+�� -   $ ContractFail��
���  ��$y�	Collapsed=��� $ Vertical=�$��1��$��4��.+��� -    ��Name$ Fasds�� �� DisplayMemberPath$	 FIO��$
��Left=�$��10q�$	��250��	 �� SelectedItem	 �� *Worker+�� -   $ 
WorkerFail��
���  ��$y�	Collapsed=��� -	   
 ��Name$
 CheckAdv��$��5��$��1��$��Center=�$
��Left=�$��10q� d� 	IsChecked ��  �� Path$ 	Certified� �� Mode$ TwoWay=��� $ Vertical=�$��3��$��1��.+�(  "System.Windows.Controls.DatePicker  -
     Name$ 	DPDeliver��$	��250��$��30�����#6A779E$��Moloto)�$��10(�$
��Bold"����#6A779E$��1q�$
��Left=�$��10q�   SelectedDate �� * DateOfAcceptanceToTheWarehouse+�� -   $ DateFail��
���  ��$y�	Collapsed=��� -   $��BtnSave��$��Сохранить��$	��120��$��2��$��8��