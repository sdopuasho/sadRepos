   M S B A M L   `   `   `  ���� N  JAccountigConsumable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:WPF_Base_Styling_App.UI.WindowsWPF_Base_Styling_App.UI.Windows  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0892    ,WPF_Base_Styling_App.UI.Windows.StyledWindow  �� 
TargetType   WindowStyle �� Property �� Value&   System.Windows.Media.TextOptions  ControlBorder'  !System.Windows.Shell.WindowChrome   GlassFrameThickness   ResizeBorderThickness   CornerRadius   CaptionHeight �� 
TargetType J� SnapsToDevicePixels	 � RowDefinitions
 ��Name   IsHitTestVisibleInChrome  ControlWindowFrame � ColumnDefinitions �� Orientation  ControlFontWindowFrame �� RelativeSource �� AncestorType �� Mode �� Path F�Name  ControlFontNormal J� IsHitTestVisible �� Triggers P� 
SourceName P� Property P� Value �� 
TargetName  ControlActive  ControlWindowActiveBorder�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     9windows-clr-namespace:WPF_Base_Styling_App.UI.Windows  %,
  &	        �� "    .���  �@�FocusVisualStyle Z� ��  �@�WindowStyle$
 None=���  � �� �#E8E8E8��  �@J�SnapsToDevicePixels . ��  �@ TextFormattingMode$ Display=���  �@��ClearTypeHint$ Enabled=���  �@��BitmapScalingMode$ HighQuality=���  � ��$ 1q���  � ��# �  ��  �@ WindowChrome   $ 6q�$ 5q�$ 0��$ 8Q���  � �� �� "   .R��� #��z��#��z�� . ._�� #��z��	 �� $
��Auto ��� $��* �.+��� $
 PART_WindowFrame��$��0��$��0,0,0,0q� .  ._�� #���   �� $��2 ��� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��2 �.+��� $��1��$ 
Horizontal=�.+��� $-��'pack://application:,,,/icon_program.ico��$��Center=�$��18��$��18��$��2,0,0,0q��� #���  $��Center=�����  �� $ WindowL�$ FindAncestor=�$ Title��� $
 PART_Minimize��$��3�� .  . $��20��$��20��$��Center=�
������ $��0,2,0,0q�._�F� $ PathMinimize��$��Center=�$��Center=�#���   .   .  $��2������    ��j ���j ��j 	�� $
 PART_Maximize��$��4�� .  . $��20��$��20��$��Center=�
������ $��0,2,0,0q�._�F� $ PathMaximize��$��Center=�$��Center=�#���   .   .  $��2��4����        ���j     ���j ��j �    ��j �        	�� $
 
PART_Close��$��5�� .  . $��20��$��20��$��Center=�
������ $��0,2,6,0q�._�F� $ 	PathClose��$��Center=�$��Center=�#���   .   .  $��2��+����        ���j ��j �    ��j ���j     	� $��1��.+��� ����  �� $ WindowL�$ FindAncestor=�$ Content� P� $ 
PART_Close�� �@J�IsMouseOver . . ��� $ 	PathClose��# �   � ��P� $ PART_Maximize�� �@J�IsMouseOver . . ��� $ PathMaximize��# �   � ��P� $ PART_Minimize�� �@J�IsMouseOver . . ��� $ PathMinimize��# �   � ��P�  �@�
ResizeMode$ NoResize=�. ��� $ PART_Maximize�� � y�$ 	Collapsed=��� $ PART_Maximize�� �@J�IsHitTestVisible .  �� $ PART_Maximize��  �@ IsHitTestVisibleInChrome .  �� $ PART_Minimize�� � y�$ 	Collapsed=��� $ PART_Minimize�� �@J�IsHitTestVisible .  �� $ PART_Minimize��  �@ IsHitTestVisibleInChrome .  P�  �@�
ResizeMode$ CanMinimize=�. ��� $ PART_Maximize�� � y�$ 	Collapsed=��� $ PART_Maximize�� �@J�IsHitTestVisible .  �� $ PART_Maximize��  �@ IsHitTestVisibleInChrome .  P�  �@�IsActive . . ��� # �   � ��