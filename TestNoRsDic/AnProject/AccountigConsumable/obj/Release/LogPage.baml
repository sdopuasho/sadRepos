   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccountigConsumableAccountigConsumable  !    AccountigConsumable.LogPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:AccountigConsumable       N� Title$  LogPage��.��� .+���  �� Orientation$ Vertical=�$��Center=�.+��� $��Center=�$��Center=�$ Vertical=�.+�&    AccountigConsumable.PlaceTextBox  -     Name$ LoginTextBX��   	PlaceText$ 
Логин��   
PlaceBrush �#6A779E���#6A779E$��18(�$��0q�$	��175��$��25���� -    ��Name$ Fail1��$y�Hidden=�$,��&Логина не существует��$��15(�
��������� $��Center=�$��Center=�$	��180��.+�.   (AccountigConsumable.PasswordBoxWatermark  -     Name$ PasswordTextBX��   	Watermark$ Пароль��$��5��$��1��   TextSize$ 18��	   Password	 �� *
Password+
 �� Mode$
 TwoWay=��� -   $ Fail2��$y�Hidden=�$#��Неверный пароль��$��15(����#e5266f�� $��Center=�$��Bottom=�$��60��$��0,0,0,50q�.+��� -   $��
Войти��
��������� $
��Left=�$��80��$��	10,10,0,0q�$	��Top=�$	��229��.+��� $��Авторизация�����#6A779E$��20(�$��Center=�$��10q��� -   $ 
GlobarFail��$?��9 Логин и пароль введены неверно��$��Center=�$��10(�$y�Hidden=����#e5266f