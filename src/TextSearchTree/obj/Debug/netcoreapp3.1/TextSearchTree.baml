   M S B A M L   `   `   `  ����  TextSearchTree#    TextSearchTree.TextSearchTree   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        +� FocusedElement  5      ��  �� ElementName$ searchTextBox��.��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   �� $��Bottom=�6   
�������$��1,0,1,1q�5      $��1��5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 0,1&�5   &   .��5      �  � Color$ 	#33000000��6#    � Offset$ 0Q�5   #   � 5      $ 	#11000000��6#   $ 1Q�5   #   5      ._�5      � $��Stretch=�6   $��4q�5      $��1��5       � ColumnDefinitions 5       �� 5!      $��35 �6'   �� 5"      $��* �6'   �� 5#      $��55 �6'   .+�5%      �� $��Search:��6   $��0��6+   �� 5&      -   5         ��Name$ searchTextBox��5&      $	��6,0q�5(      $��Stretch=�5*      $��1��5+      ��5)      �� *
SearchText+	 �� UpdateSourceTrigger$	 PropertyChanged=�5+      �� 5,      $��_Find��5-      $	��8,0q�5.      $��2��5/      ��5,      �� *SearchCommand+5/      50      51      R� 54   
   $��0��55      ��54      �� *FirstGeneration+��56      �� 5:      
 �� 
TargetType"
 Q�6   .�5;      ��  �� Property �@Q�
IsExpanded �� Value 5<      �� *
IsExpanded+ �� Mode$ TwoWay=��� 5=       �@Q�
IsSelected 5>      �� *
IsSelected+$ TwoWay=��� 5?       � ��$ Normal"�5@       �� Triggers 5A      P� 5B       P� Property �@Q�
IsSelected P� Value$
 True��5C   "   . �5D      ��  � ��$
 Bold"�5E   %   5F      5H      ��5K      �� 5L       �� ItemsSource 6+   �� *
Children+.R�5M      �� ��6    �� *Name+5N      5P      5R      5S      