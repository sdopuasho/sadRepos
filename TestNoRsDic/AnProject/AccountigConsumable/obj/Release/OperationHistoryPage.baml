   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  .    (AccountigConsumable.OperationHistoryPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable       N� Title$  OperationHistoryPage�� � 	Resources  �� MergedDictionaries��  %    .���  � ColumnDefinitions �� $��* ��� $	��190 �.+��� ���#6A779E$��2q�$��10q�._�&   System.Windows.Controls.DataGrid  -     Name$ DGridConsumable��   AutoGenerateColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *
Worker.FIO+  $ Должность��$
	 auto 
 �� *Worker.Position.PositionName+  $ Операция��$
	 auto 
 �� *	Operation+  $! Дата обращения��$
	 auto 
 �� *DateTimeOfOperation+��  �� Orientation$ Vertical=�$��1��$��10q�.+��� $��2q����#6A779E$��5q�._��� $ Vertical=�$��10q�.+��� -    ��Name$ FIOCmb�� �� SelectedIndex$ 0��$��10q� �� DisplayMemberPath$	 FIO��$	��110���� $��2q����#6A779E$��5q�._��� $ Vertical=�$��10q�.+��� -    ��Name$ 	BtnWorker��$��Работники��$	��110��$��Center=�$��Center=��� -   $ 
BtnHistory��$��История��$	��110��$��Center=�$��Center=�