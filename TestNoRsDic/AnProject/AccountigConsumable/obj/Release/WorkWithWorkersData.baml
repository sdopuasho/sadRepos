   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  -    'AccountigConsumable.WorkWithWorkersData   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable       N� Title$  WorkWithWorkersData�� � 	Resources  �� MergedDictionaries��  %    .��� .+��  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $	��37* ��� $
��163* �.+��� $��Фамилия���� $��Имя��$��1���� $��Отчество��$��2���� $��Пол��$��3���� $!��Номер телефона��$��4���� $��Email��$��5���� $��Должность��$��6���� $��Статус��$��7���� $��0��$��1�� �� Orientation$ Vertical=�.+��� -    ��Name$ TxtFname��$	��250��$
��Left=�$��10q����� *	FirstName+�� -    ��Name$ 	FNameFail��
���  ��$y�	Collapsed=��� $��1��$��1��$ Vertical=�.+��� -   $ TxtLastName��$	��250��$
��Left=�$��10q����� *
LastName+�� -   $ 	LNameFail��
���  ��$y�	Collapsed=��� $��2��$��1��$ Vertical=�.+��� -   $ TxtMName��$	��250��$
��Left=�$��10q����� *
MiddleName+�� -   $ 	MNameFail��
���  ��$y�	Collapsed=��� $��3��$��1��$ Vertical=�.+��� -    ��Name$ 	GenderBox��$	��250��$
��Left=�$��10q�	 �� DisplayMemberPath$	 
GenderName��
 �� SelectedItem
 �� *Gender+�� -   $ 
GenderFail��
���  ��$y�	Collapsed=��� $��4��$��1��$ Vertical=�.+��� -	   $ PhoneTxt��$	��250��$
��Left=�$��10q����� *PhoneNumber+�� -
   $ 	PhoneFail��
���  ��$y�	Collapsed=��� $��5��$��1��$ Vertical=�.+��� -   $ EmailTxt��$	��250��$
��Left=�$��10q����� *Email+�� -   $ 	EmailFail��
���  ��$y�	Collapsed=��� $��1��$��6��$ Vertical=�.+��� -   $ ComboPosition��$	��250��$
��Left=�$��10q�$	 PositionName��
 �� *
Position+�� -   $ ComboPositionFail��
���  ��$y�	Collapsed=��� $��1��$��7��$ Vertical=�.+��� -   $ ComboStatus��$	��250��$
��Left=�$��10q�$	 NameOfStatus��
 �� *StatusOfWorker+�� -   $ ComboStatisFail��
���  ��$y�	Collapsed=��� -   $��BtnSave��$��Сохранить��$	��120��$��2��$��8��