   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  "    AccountigConsumable.WorkersS   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable     -     N� Title$  WorkersS�� � 	Resources  �� MergedDictionaries��  %    .���  � ColumnDefinitions �� $��* ��� $	��180 �.+��� ���#6A779E$��2q�$��5q�._�&   System.Windows.Controls.DataGrid  -     Name$ DGridConsumable��   AutoGenerateColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *FIO+  $ Пол��$
	 auto 
 �� *Gender.GenderName+  $! Номер телефона��$
	 auto 
 �� *PhoneNumber+  $ Email��$
	 auto 
 �� *Email+  $ Должность��$
	 auto 
 �� *Position.PositionName+  $ Статус��$
	 auto 
 �� *StatusOfWorker.NameOfStatus+4  .System.Windows.Controls.DataGridTemplateColumn  $
	 auto    CellTemplate �� .R��� $��BtnEdit��-   $ ��Редактировать����  �� Orientation$ Vertical=�$��1��$��5q�.+��� $��2q����#6A779E$��5q�._��� $ Vertical=�$��10q�.+��� -    ��Name$ 	BtnWorker��$��Работники��$��Center=�$��Center=��� -   $ 
BtnHistory��$��История��$��Center=�$��Center=��� $��2q����#6A779E$��5q�._��� $ Vertical=�$��10q�.+��� -    ��Name$ 
PostionTxt��$��10q��� -    ��Name$ 	GenderCmb�� �� SelectedIndex$ 0��$��10q� �� DisplayMemberPath$ 
GenderName���� -   $ BtnAdd��$��Добавить��$	��110��$��Center=�$��Center=��� -	   $ BtnDel��$��Удалить��$	��110��$��Center=�$��Center=�