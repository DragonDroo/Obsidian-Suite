   M S B A M L   `   `   `  ����J  FQuiz_WPFVersion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Quiz_WPFVersion.View._SharedQuiz_WPFVersion.View._Shared  5      ?$clr-namespace:Quiz_WPFVersion.ModelsQuiz_WPFVersion.Models  5      I)clr-namespace:Quiz_WPFVersion.HelperClassQuiz_WPFVersion.HelperClass  5      W0clr-namespace:Quiz_WPFVersion.ViewModels.Teacher"Quiz_WPFVersion.ViewModels.Teacher  5	      -    'Quiz_WPFVersion.View.Teacher.CreateQuiz   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Quiz_WPFVersion.View._Shared     5      7local1$clr-namespace:Quiz_WPFVersion.Models     5      9loc)clr-namespace:Quiz_WPFVersion.HelperClass     5      DTeacher0clr-namespace:Quiz_WPFVersion.ViewModels.Teacher     5	        N� Title$  
CreateQuiz��5       � 	Resources 5         ListViewControlTemplate1 �� 
TargetType � DataContext ��Name ��Name �� TextWrapping ��Name  SimpleCheckBox:  4Quiz_WPFVersion.HelperClass.QuestionTemplateSelector  questionTemplateSelector  AddQuestion_Animation �� TargetProperty	 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value  Save_animation_show R� KeyTime  System.Windows.Visibility   Visible R� Value  Save_animation_hide   Hidden  ListBox_show  ListBox_hide��%  &	        &	 6    &	 I    &	 {    &	 �    &	 A	    &	 
    �� 5   
   " ��6;   .R�5      � 
�������$��54��6&   $	��Top=�62    6J   �� *questionList+.+�5      �� $ 	textBlock��6   $
��Left=�6/   $��22.222��6J   $
��Wrap=�6Z   $	��Top=�6n   $��79.146��6�   ��6�   �� *Title+�� 5      $ textBox��6   $
��Left=�6+   $
��25.4��6F   $��
61.2,0,0,0q�6T   $
 Wrap=�6h   $	��Top=�6�   $��131.4��6�   ��6|   �� *Type+6�   �� 5      $ checkBox��6   $��CheckBox��6-   $��Stretch=�6@   $��197.6,1,187.98,0q�6^   #���  6x   $	��Top=�6�   5      5        5   
   6'   �� 5   
   .��5      U� $ (UIElement.Opacity)�6,   $	 btnSingelQuestion��6\   .\�5        $
 0��6'   $ 0Q�63     5      $
 0:0:0.4��6'   $ 0Q�69     5      $
 0:0:1.4��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $	 btnMultiQuestion��6\   .\�5        $
 0��6'   $ 0Q�63     5      $
 0:0:0.8��6'   $ 0Q�69     5      $
 0:0:1.7��6'   $ 1Q�69   5       U� 5!      $ (UIElement.Opacity)�6,   $	 btnRankQuestion��6\   .\�5"        $
 0��6'   $ 0Q�63     5#      $
 0:0:1.2��6'   $ 0Q�69     5$      $
 0:0:1.9��6'   $ 1Q�69   5%      U� 5&      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $	 QuestionsCreate��6�   .\�5'        $
 0��6'   $ 30Q�63     5(      $
 0:0:1��6'   $ 0Q�67   5)      U� 5*      $ (UIElement.Opacity)�6,   $	 QuestionsCreate��6\   .\�5+        $
 0��6'   $ 0Q�63     5,      $
 0:0:1��6'   $ 1Q�67   5-      5.      �� 5/   
   .��50      T� $ (UIElement.Visibility)�6,   $	 btnSaveQuiz��6_   ..�51      i� $ 0��6)   # Z 65   i� 52      $ 0:0:1��6)   # Z 69   53      U� 54      $ (UIElement.Opacity)�6,   $	 btnSaveQuiz��6\   .\�55        $
 0��6'   $ 0Q�63     56      $
 0:0:1��6'   $ 1Q�67   57      58      �� 59   
   .��5:      T� $ (UIElement.Visibility)�6,   $	 btnSaveQuiz��6_   ..�5;      i� $ 0��6)   # Z 65   i� 5<      $ 0:0:1��6)   # Z 69   5=      U� 5>      $ (UIElement.Opacity)�6,   $	 btnSaveQuiz��6\   .\�5?        $
 0��6'   $ 1Q�63     5@      $
 0:0:1��6'   $ 0Q�67   5A      5B      �� 5C   
   .��5D      U� $ (UIElement.Opacity)�6,   $	 listQuestion2��6\   .\�5E        $
 0��6'   $ 0Q�63     5F      $
 0:0:1��6'   $ 1Q�67   5G      5H      �� 5I   
   .��5J      U� $ (UIElement.Opacity)�6,   $	 listQuestion2��6\   .\�5K        $
 0��6'   $ 1Q�63     5L      $
 0:0:1��6'   $ 0Q�67   5M      5N      5O       � Triggers 5P      :� 5R   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5S      �� #��[ 6   5T       5W      <   6Quiz_WPFVersion.ViewModels.Teacher.CreateQuizViewModel  5X   
   .��5[      �   backgroundOrangeLight#��[ 6   .+�5\   
   � $	��450��6   $��	25,20,0,0q�6   $
��Left=�6.   .+�5^      ��  �� Orientation$ Vertical=�6   .+�5c      �� -   5        $ 	lblHeader��5c      $
��Wrap=�6/   $��CREATE A SAMPLE��6C   $
��Bold"�6[   $��18(�6m    	 	fontColor#��� 	 6{   �� 5d      -   5        $ lblHeader_under��5d      $
��Wrap=�65   $��Newtons testverktyg��6I   $��Segoe UI Light)�6d   $��10(�6�   #��� 	 6�   � 5e      -   5         �Name$ QuestionsCreate��5e      $��209.09��60   $��0,25,0,0q�6@    J� RenderTransformOrigin$ 0.5,0.5&�6R   z�5f      V� 5g      .~�5h      �� �� 5i      �� 5j      T� 5k      5l      .+�5n      � -   5        $ 
gridRubrik��5n      $��38.92��6/   $	��Top=�6>   .+�5o      �� -   5        $ blockHeader��5o   $   $
��Wrap=�69   $��Heading��6M   $
��Bold"�6\   $	��Top=�6n   $��Segoe UI Semibold)�6�   #��� 	 6�   �� 5p      -   5        $ 
txtbHeader��5p   "   $
 Wrap=�66   $��0,16,98.667,4.92q�6a   ���	#FFFFEBC7��6J   Z� .��6�    J� Effect 5q      3  -System.Windows.Media.Effects.DropShadowEffect  5r   "      
BlurRadius$ 30Q�63      Opacity$	 0.1Q�6C   .��5s   .   5t      �� 5u      -   5        $ checkBoxResultat��5u   #   $��View results��6=   $��Right=�6T   $��0,17.122,1.996,6.692q�6p   #��� 	 6�   $��Segoe UI Light)�6�   ��6�   Z�  5v        5w   "   $ 30Q�63   $
 0.16Q�6C   ��5y      �� 5z   "    "
 TextBox_Background_LightYellow �� Color# � 
 62   5|      5}      � 5~      -   5        $ gridBeskrivning��5~      $��38.92��64   $��0,43.92,0,66.17q�6C   $��99��6\   .+�5      �� -	   5        $ blockHeader1��5   $   $
��Wrap=�6:   $��Description��6N   $	��Top=�6a   $��Segoe WP Semibold)�6y   #��� 	 6�   �� 5�      -
   5        $ txtbDescription��5�   "   $
 Wrap=�6;   $��0,15.96,0,5q�6g   ��6O   Z� .��6|    5�        5�   "   $ 30Q�63   $	 0.1Q�6C   .��5�   .   ��5�      �� 5�   "   # � 
 62   .��5�   2   5�      5�      � 5�      -   5        $ gridAddQuestionType��5�      $��66.17��68   $��Bottom=�6G   .+�5�      �� -   5         ��Name$ menuAddQuestionType��5�   %   $��0,4,0,0q�6\   .+�5�      �� -   5        $ lblAddQuestion��5�   (   $
��Wrap=�6@   $��Add a question��6T   $��Segoe WP Semibold)�6j   #��� 	 6�   $	��Top=�6�   �� 5�      -   5        $ stackpanelAddCommand��5�   )   $ 
Horizontal=�6G   $��0,9,0,0q�6a   .+�5�   "   �� -   5         ��Name$ btnSingelQuestion��5�   )     MyButtonStyle#��[ 6D   $��0,0,0,0q�6l   ��5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��Segoe MDL2 Assets)�6=   $	����6\   $��20(�6l   $��Center=�6z   $��Center=�6�   #��� 	 6�   ��6�   Z� 6�   �� 5�   2   $	��0,0q�6<   #��� 	 6I   $��Center=�6r   $��Center=�6�   $��Alternative��6�   5�   /   5�   +   5�   #   �� 5�   "   -   5        $ btnMultiQuestion��5�   )   #��[ 6C   $��16,0,0,0q�6k   ��5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��Segoe MDL2 Assets)�6=   $	����6\   $��24(�6l   $��Center=�6z   $��Center=�6�   #��� 	 6�   $��0,-2,0,0q�6�   ��6�   Z� 6�   �� 5�   2   $��0,-2,0,0q�6<   #��� 	 6N   $��Center=�6w   $��Center=�6�   $��Multiple choice��6�   5�   /   5�   +   5�   #   �� 5�   "   -   5        $ btnRankQuestion��5�   )   #��[ 6B   $��24,0,0,0q�6j   ��5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   �� $��Segoe MDL2 Assets)�6=   $	����6\   $��20(�6l   $��Center=�6z   $��Center=�6�   #��� 	 6�   ��6�   Z� 6�   �� 5�   2   $	��0,0q�6<   #��� 	 6I   $��Center=�6r   $��Center=�6�   $
��Rank��6�   5�   /   5�   +   5�   #   �� 5�   "   -   5         ��Name$ comboBox��5�   +   $	��120��6=   $y�	Collapsed=�6I   5�      5�      5�      5�      �� 5�      -   5        $ gridQuestion_V_2��5�      $��0,15,0,0q�67   $y�Visible=�6I   .+�5�      �� -   5        $ lblQuestionHeader��5�       $
��Wrap=�6;   $��Segoe WP Semibold)�6O   #��� 	 6n   $y�	Collapsed=�6�   �� 6�   $�Fråga��6�   �� 6�   $� ( TEMPLATE)��6�   6�   �� 5�      -   5         ��Name$ listQuestion2��5�      $	��263��65   $��Disabled=�6X   $��0,1,1,1q�6�   $
��Auto=�6,    ListBox_Transparent#���  6s  ��6B   Z� ��6�   ��  �� Mode$ OneWay=� �� Source# [ ��6  �� *questionList+��6\  Z� ��5�      �� 5�      .R�5�   "   $� $��Bottom=�69   5�      5�      5�      �� 5�      -   5        $ stackMessage_SaveButton��5�      $ 
Horizontal=�6>   $��5,0,0,0q�6W   .+�5�      �� -   5        $ btnSaveQuiz��5�      #��[ 62   $
��Left=�6Y   $��0,6,0,0q�6�   $y�Hidden=�6�   ��6�   �� *command_SaveQuiz+��6�   �� ��5�      �� 5�      .R�5�   "   �� .+�5�   &   �� $��Segoe MDL2 Assets)�61   $	����6P   $��20(�6`   $��Center=�6n   $��Center=�6�   #��� 	 6�   ��6�   Z� 6�   �� 5�   &   $	��0,0q�60   #��� 	 6=   $��Center=�6f   $��Center=�6�   $��Spara��6�   5�   #   5�      5�      �� 5�      -   5         ��Name$ lblMessageBoard��5�      #��� 	 65   $��
12,6,12,12q�6^   $�� ��6r   5�      5�      5�      5�      5�      