   M S B A M L   `   `   `  ����J  FQuiz_WPFVersion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Quiz_WPFVersion.ModelsQuiz_WPFVersion.Models  5      W0clr-namespace:Quiz_WPFVersion.ViewModels.Teacher"Quiz_WPFVersion.ViewModels.Teacher  5      I)clr-namespace:Quiz_WPFVersion.HelperClassQuiz_WPFVersion.HelperClass  5      -    'Quiz_WPFVersion.Data.ResourceDictionaryR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0893  -Quiz_WPFVersion.HelperClass.CheckBoxConverter   CheckBoxConverter  
background  �� Color  backgroundGardinentOrange �� EndPoint � MappingMode �� 
StartPoint � Color � Offset  backgroundOrangeLight  NavigationColor  	fontColor  MyButtonStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� Triggers P� Property P� Value �� 
TargetName " TextBox_Background_LightYellow  SingleChoiceQuestion �� Orientation ��Name ��Name ��Name �� TextWrapping �� Mode ��Name ��Name �� ElementName ��Name 	 ListBox_Transparent J� Opacity 	�Name d� 	IsChecked �� 	Converter 	� 	GroupName �� RelativeSource �� AncestorType 
 MultiChoiceQuestion  ��Name  RankQuestion! �� Padding" J� SnapsToDevicePixels $  ListBox_GardinentBackground_List   5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      localQuiz_WPFVersion.Data  5      8d2http://schemas.microsoft.com/expression/blend/2008  5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      /Models$clr-namespace:Quiz_WPFVersion.Models  5      <Teacher0clr-namespace:Quiz_WPFVersion.ViewModels.Teacher  5      9HelperClass)clr-namespace:Quiz_WPFVersion.HelperClass  5      %�%  &	        &	      &	 2     &	     &	 �    &	 �    &	 �    &	 �    &	 �    7   &	
 �    7   &	 �    &		 �"    &	 %      5      6$   �� 5      $  White��6)   �� 5      $ 0.5,1&�6<   $ RelativeToBoundingBox=�6M   $ 0.9,0&�6q   .��5   
   � $ 	#FFFFDDA3��6   � 5   
   $ 	#FFFFA200��6   $ 0.645Q�6)   � 5   
   $ 	#FFFF8000��6   $ 0.909Q�6)   5      �� 5      $ 0.9,1&�68   $ RelativeToBoundingBox=�6I   $ 0.7,0&�6m   .��5   
   � $ 	#FFFFD68F��6   5      �� 5#      $  White��6.   �� 5%      $  	#FF464646��6(   �� 5)      " ��6"   .�5*   
   ��  �@�OverridesDefaultStyle . 62   �� 5+   
    � ��$ 0q�6#   �� 5,   
    �@�Cursor$
 Hand��6#   �� 5-   
    � �� 5.      �� 5/      "	 ��6"   .R�50      �� $
 border��6   #��z��51      ._�52      �� $��Center=�6+   $��Center=�6H   53       54      P� 55       �@J�IsMouseOver . . �56      �� $ border��6%    � ��
 ���� 6P   57      59      5;      5<      ��5>      	#FFFFEBC7��6>   �� 5C      .R�5D   
   � .+�5E      �� $��0q�6   $ Vertical=�6$   .+�5F      �� $ lblQuestionHeader1��6   $
��Wrap=�68   $��Segoe WP Semibold)�6L   #���  6k   $	��Top=�6�   $
��Auto��6�   $
��Left=�6�   $��0q�6�   $��Fråga��6  �� 5G      $ stackQuestion��6   $ 
Horizontal=�64   $
��Auto��6M   $��0,3,0,0q�6�   .+�5H      �� $ txtbQuestion��6   $
 Wrap=�64   $��Stretch=�6H   $��Stretch=�6m   $	��200��6�   ��6�   �� *Title+$ TwoWay=�.��6�   ��5I      �� 5J      #  �  6.   .��5K   .   5L      �� 5M      $ image��6    $��50��6/   $��50��6:   $��10,0,0,0q�6F   ���	#FFFFF7C4$��Stretch=�6i   5Q      �� 5S      $ Vertical=�6!   $��	2,-24,0,0q�68   .+�5T      �� $��Poäng��6    $��Segoe WP Semibold)�60   #���  6O   �� 5U      $ txtbScoreValue��6"   -   5        $��25��5U   :   $��20��6a   $��0,-1,0,0q�6m   ��6E   �� *
ScoreValue+.��6�   ��5V      �� 5W   "   #  �  62   .��5X   2   5Y      5Z      �� 5[      $ btnRemoveQuestion��6   $	����6�   $��25��6�   $��
27.7,0,0,0q�6�   $��Segoe MDL2 Assets)�6�   #���  6%  $
��Left=�6M  $	��Top=�6h  ��68   �� *$"DataContext.commandRemove_Question+$ listQuestion2����6�   �� ��6�   Z� ��6  Z� 6h  5\      �� 5]      $ lblAlternative1��6   $
��Wrap=�65   $��Segoe WP Semibold)�6I   #���  6h   $
��Left=�6�   $��0,14,0,0q�6�   �� 6�   $�
Alternativ��6�   6�   �� 5^      $ listAlternative��6   $	��118��63   $��-7,0,0,0q�6�   $��Hidden=�6�   #��� 	 6�   ��6@   �� *Alternatives+��6e   Z� ��6{   Z� ��5`      �� 5a      .R�5b      � .+�5c   "   �� $ Alternative��6-   $
��Left=�6B   $ 
Horizontal=�6]   $��0,5,0,0q�6v   .+�5d   &   �� $ txtbAlternative1��6.   $
 Wrap=�6H   $��17.96��6\   $	��134��6k   $	��300��6z   $ 1Q�6�   ��6�   �� *Title+$ TwoWay=�.��6�   ��5e   *   �� 5f   .   #  �  6>   .��5g   >   5h   '   	� 5i   &   $ rbtAlt��62   $��10,2,0,0q�6�    6B   �� *
ScoreValue+8   $ TwoWay=� 6�   �� *DataContext.Title+$ OneWay=� �� " ���� 5m   &   $ btnRemoveAlternative��6-   $	����6�   $��25��6�   $��9,0,0,0q�6�   $��Segoe MDL2 Assets)�6  #���  68  ��6K   �� *'%DataContext.commandRemove_Alternative+$ listQuestion2����6�   �� ��6�   Z� ��6!  Z� 68  5n   #   5o      5p      5r      �� 5s      $ btnAddAlternative��6   $	����64   $��25��6]   $��Segoe MDL2 Assets)�6i   $
��Left=�6�   $��0,8,0,25q�6�   #���  6�   $
��Bold"�6�   ��6G   Z� ��6�   Z� ��6  �� *$"DataContext.commandAdd_Alternative+$ listQuestion2����6X  �� 5y      5z      5{      �� 5      .R�5�   
   � .+�5�      �� $��0q�6   $ Vertical=�6$   .+�5�      �� $ lblQuestionHeader1��6   $
��Wrap=�68   $��Segoe WP Semibold)�6L   #���  6k   $	��Top=�6�   $
��Auto��6�   $
��Left=�6�   $��0q�6�   $��Fråga��6  �� 5�      $ stackQuestion��6   $ 
Horizontal=�64   $
��Auto��6M   $��0,3,0,0q�6�   .+�5�      �� $ txtbQuestion��6   $
 Wrap=�64   $��Stretch=�6H   $��Stretch=�6m   $	��200��6�   ��6�   �� *Title+$ TwoWay=�.��6�   ��5�      �� 5�      #  �  6.   .��5�   .   5�      �� 5�      $ image��6    $��50��6/   $��50��6:   $��10,0,0,0q�6F   ���	#FFFFF7C4$��Stretch=�6i   5�      �� 5�      $ Vertical=�6!   $��	2,-24,0,0q�68   .+�5�      �� $��Poäng��6    $��Segoe WP Semibold)�60   #���  6O   �� 5�      $ txtbScoreValue��6"   -   5        $��25��5�   :   $��20��6b   $��0,-1,0,0q�6n   ��6F   �� *
ScoreValue+.��6�   ��5�      �� 5�   "   #  �  62   .��5�   2   5�      5�      �� 5�      $ btnRemoveQuestion��6   $	����6�   $��25��6�   $��
27.7,0,0,0q�6�   $��Segoe MDL2 Assets)�6�   #���  6&  $
��Left=�6N  $	��Top=�6i  ��68   �� *$"DataContext.commandRemove_Question+$ listQuestion2����6�   �� ��6�   Z� ��6  Z� 6i  5�      �� 5�      $ lblAlternative1��6   $
��Wrap=�65   $��Segoe WP Semibold)�6I   #���  6h   $
��Left=�6�   $��0,14,0,0q�6�   �� 6�   $�
Alternativ��6�   6�   �� 5�      $ listAlternative��6   $	��118��63   $��-7,0,0,0q�6�   $��Hidden=�6�   #��� 	 6�   ��6@   �� *Alternatives+��6e   Z� ��6{   Z� ��5�      �� 5�      .R�5�      � .+�5�   "   �� $ Alternative��6-   $
��Left=�6B   $ 
Horizontal=�6]   $��0,5,0,0q�6v   .+�5�   &   �� $ txtbAlternative1��6.   $
 Wrap=�6H   $��17.96��6\   $	��134��6k   $	��300��6z   $ 1Q�6�   $��0,0,10,0q�6�   ��6�   �� *Title+$ TwoWay=�.��6�   ��5�   *   �� 5�   .   #  �  6>   .��5�   >   5�   '   �� 5�   &   $  checkBox��6/   $��0q�6A   $��0,1,0,0q�6M    6^   �� *
ScoreValue+8   $ TwoWay=���5�   *   �� 5�   .   #  �  6>   5�   '   �� 5�   &   $ btnRemoveAlternative��6-   $	����6K   $��25��6t   $��9,0,0,0q�6   $��Segoe MDL2 Assets)�6�   #���  6�   ��6^   Z� ��6�   Z� ��6�   �� *'%DataContext.commandRemove_Alternative+$ listQuestion2����6C  �� 5�   #   5�      5�      5�      �� 5�      $ btnAddAlternative��6   $	����64   $��25��6]   $��Segoe MDL2 Assets)�6i   $
��Left=�6�   $��0,8,0,25q�6�   #���  6�   $
��Bold"�6�   ��6G   Z� ��6�   Z� ��6  �� *$"DataContext.commandAdd_Alternative+$ listQuestion2����6X  �� 5�      5�      5�      �� 5�      .R�5�   
   � .+�5�      �� $��0q�6   $ Vertical=�6$   .+�5�      �� $ lblQuestionHeader1��6   $
��Wrap=�68   $��Segoe WP Semibold)�6L   #���  6k   $	��Top=�6�   $
��Auto��6�   $
��Left=�6�   $��Fråga��6�   �� 5�      $ stackQuestion��6   $ 
Horizontal=�64   $
��Auto��6M   $��0,3,0,0q�6[   .+�5�      �� $ txtbQuestion��6   $
 Wrap=�64   $��Stretch=�6H   $��Stretch=�6m   $	��200��6�   ��6�   �� *Title+$ TwoWay=�.��6�   ��5�      �� 5�      #  �  6.   .��5�   .   5�      �� 5�      $ image��6    $��50��6/   $��50��6:   $��10,0,0,0q�6F   ���	#FFFFF7C4$��Stretch=�6i   5�      �� 5�      $ btnRemoveQuestion��6   $	����6�   $��25��6�   $��49,0,0,0q�6�   $��Segoe MDL2 Assets)�6�   #���  6$  $
��Left=�6L  $	��Top=�6g  ��68   �� *$"DataContext.commandRemove_Question+$ listQuestion2����6�   �� ��6�   Z� ��6  Z� 6g  5�      �� 5�      $ lblAlternative1��6   $
��Wrap=�65   $��Segoe WP Semibold)�6I   #���  6h   $
��Left=�6�   $��0,14,0,0q�6�   �� 6�   $�
Alternativ��6�   6�   �� 5�      $ listAlternative��6   $	��118��63   $��-7,0,0,0q�6�   $��Hidden=�6�   #��� 	 6�   ��6@   �� *Alternatives+��6e   Z� ��6{   Z� ��5�      �� 5�      .R�5�      � .+�5�   "   �� $ Alternative��6-   $
��Left=�6B   $ 
Horizontal=�6]   $��0,5,0,0q�6v   .+�5�   &   �� $ txtbAlternative1��6.   $
 Wrap=�6H   $��17.96��6\   $	��134��6k   $	��300��6z   $ 1Q�6�   ��6�   �� *Title+$ TwoWay=�.��6�   ��5�   *   �� 5�   .   #  �  6>   .��5�   >   5�   '   �� 5�   &   $ btnRemoveAlternative��6-   $	����6K   $��25��6t   $��9,0,0,0q�6   $��Segoe MDL2 Assets)�6�   #���  6�   ��6^   Z� ��6�   Z� ��6�   �� *'%DataContext.commandRemove_Alternative+$ listQuestion2����6D  �� 5�   #   5�      5�      5�      �� 5�      $ btnAddAlternative��6   $	����64   $��25��6]   $��Segoe MDL2 Assets)�6i   $
��Left=�6�   $��0,8,0,25q�6�   #���  6�   $
��Bold"�6�   ��6G   Z� ��6�   Z� ��6  �� *$"DataContext.commandAdd_Alternative+$ listQuestion2����6X  �� 5�      5�      5�      �� 5�      " ��6(   .�5�   
   ��  � ��
 ���� 6'   �� 5�   
    � �� 67   �� *HorizontalContentAlignment+ �� " ���� 5�   
    � �� 65   �� *VerticalContentAlignment+ �� " ���� 5�   
    � �� 5�      �� 5�      "	 ��6"   .R�5�      �� $
 Bd��6   #��z��6)   #��z��5�      #��z��6;   #! z��5�      " . ._�5�      �� #��z��6+   #" z" 5�      #��z��5�      5�       5�      P� 5�       �@��
IsSelected . . �5�      �� $ Bd��6;    � ��
 ���� 6K   5�      5�      5�      5�      ��5�      	#FFFFD68F��6@   5     