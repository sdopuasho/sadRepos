   M S B A M L   `   `   `  ���� R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ExpandCollapseToggleStyle  �� 
TargetType �� Property �� Value �� 
TargetType F�Name  ControlSelected �� Triggers P� Property P� Value �� 
TargetName  ControlFontNormal	 �� Path
 �� RelativeSource �� AncestorType � ColumnDefinitions � RowDefinitions ��Name J� Opacity d�Name �� 	ClickMode d� 	IsChecked ��Name ��Name ]� 
Conditions �� Property �� Value  ControlBorder  ControlFontDisabled�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %�  &	        'Q� q    �� "  d�.���  �@�FocusVisualStyle Z� ��  � |� .  ��  � �� �� " d�.R�� $��12��$��8��
������ .+�F� $ 
ExpandPath��$
��Left=�$��Center=�#���  "���� 	=     � z  	= � 	=  z 	 P�  �@d�	IsChecked$
 TrueY�. ��� $ 
ExpandPath�� � ��" ��     	= � z  	= � 	=  z 	�� $ 
ExpandPath��# �   � ���� "  Q�.���  �@�FocusVisualStyle Z� ��  � ��# �  ��  � �� �� $ 	 HorizontalContentAlignment�
 �� " ����  � �� �� $	 VerticalContentAlignment�
 �� " ����  � �� �� " Q�.R��  �� $
��Auto ��� $
��Auto ��� $��* � �� $
��Auto ��� .+��� $ Underlay��$��0��$��1��$��2��$��
-100,0,0,0q�
������ $	 0.5Q�d� $ Expander��$��0��$��0��#���   $ Press=� �� $	 
IsExpanded�
 �� *TemplatedParent+�� $ PART_Header��$��0��$��1��#��z��#��z������ *Header+
 �� " Q�y��� $	 
Visibility�
 �� " Q��� $ 	ItemsHost��$��1��$��1��$��2�� P�  �@Q�
IsExpanded .  . ��� $ 	ItemsHost�� � y�$ 	Collapsed=�P�  �@��HasItems .  . ��� $ Expander�� � y�$ Hidden=�]�  ��  � �� .  ��  � ��$
 Auto��./��� $ PART_Header�� � ��$ 75��]�  ��  � �� .  ��  � ��$
 Auto��./��� $ PART_Header�� � ��$ 20��P�  �@Q�
IsSelected . . ��� $ Underlay��# �   � ��P�  � {� .  . ��� # �   � ��