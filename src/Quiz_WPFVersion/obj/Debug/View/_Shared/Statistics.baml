   M S B A M L   `   `   `  ����J  FQuiz_WPFVersion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Quiz_WPFVersion.View._SharedQuiz_WPFVersion.View._Shared  5      G(clr-namespace:Quiz_WPFVersion.ViewModelsQuiz_WPFVersion.ViewModels  5      -    'Quiz_WPFVersion.View._Shared.Statistics   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Quiz_WPFVersion.View._Shared     5      ?
ViewModels(clr-namespace:Quiz_WPFVersion.ViewModels     5        N� Title$  
Statistics��5
      $	��550��6    � 	Resources 5         GridAnimate �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%  &	        �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ gridMain��6�   .\�5        $ 0��6'   $
 19.2Q�63     5      $ 0:0:0.5��6'   $ 0Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ gridMain��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $ 1Q�69   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ 	stack_Edu��6�   .\�5        $ 0:0:0.6��6'   $	 -17Q�69     5      $ 0:0:0.9��6'   $ 0Q�69   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ 
stacl_User��6�   .\�5        $ 0:0:0.8��6'   $	 -17Q�69     5      $ 0:0:1.1��6'   $ 0Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ 	stack_Edu��6\   .\�5        $ 0��6'   $ 0Q�63     5       $ 0:0:0.6��6'   $ 0Q�69     5!      $ 0:0:0.9��6'   $ 1Q�69   5"      U� 5#      $ (UIElement.Opacity)�6,   $ 
stacl_User��6\   .\�5$        $ 0��6'   $ 0Q�63     5%      $ 0:0:0.8��6'   $ 0Q�69     5&      $ 0:0:1.1��6'   $ 1Q�69   5'      5(      5*       � Triggers 5+      :� 5,   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5-      �� #��[  6   5.       � DataContext 50      5   /Quiz_WPFVersion.ViewModels.Statistics_ViewModel  51   
   .��54      � $��0q�6   	 � RowDefinitions	 55   
   �� 56      $��28 �6   �� 57      $��14 �6   �� 58      $��14 �6   �� 59      $��3* �6   $	��100��6(   �� 5:      $��73 �6   �� 5;      $��3* �6   
 � ColumnDefinitions
 5=   
   �� 5?      $	��11* �6   �� 5@      $
��439* �6   ��5C   
   �� 5D       $  ListBox_GardinentBackground_List �� Color# �  6   .+�5F   
   �� -   5         ��Name$ 	textBlock��5F      $
��Wrap=�6'   $
��Bold"�6;   $��17.333(�6M   $��1��6_     	fontColor#���  6o   $��
7,-10,-7,1q�6�   $��1��6�   �� 6�   $
�STAT��6  �� 6  $�I��6  �� 6   $
�STIK��6$  63  �� 5G   
   -   5        $ textBlock_Copy��5G      $��7,-1,0,0q�6,   $
��Wrap=�6>   $
��Bold"�6R   $��Segoe UI Light)�6d   $��Completed tests��6�   $��2��6�   $��1��6�   $
��Left=�6�   $	��104��6�   #���  6�   � 5H   
   -   5         �Name$ gridMain��5H      $��1��6!   $��7,7,62,0q�61   $��3��6C   $��2��6P    J� RenderTransformOrigin$ 0.5,0.5&�6a   z�5I      V� 5J      .~�5K      �� �� 5L      �� 5M      T� 5N      5O      .+�5T      �� -   5         ��Name$ listView��5T      $��0,0,0,70q�6)   #���  6Y   $��Hidden=�6�    � ToolTip$/ )Provresultat på prov som har genomförts��6�   ��6;   �� *_Quiz+��5U      �� 5V       " TextBox_Background_LightYellow# �  6&    �� View 5X      �� 5Y      .P�5[      �� $
��Test��6)    �� Width$	 129��67    �� DisplayMemberBinding 6C   �� *Title+�� 5\      $��	Completed��6)   $ 90��6<    6G   �� *	QuizTaken+�� 5]      $��Not Completed��6)   $ 87��6@    6K   �� *QuizNotTaken+�� 5^      $��Approved��6)   $ 71��6;    6F   �� *GradeG+�� 5_      $��Failed��6)   $ 87��69    6D   �� *GradeF+5`      5b      �� 5f       �� Orientation$ 
Horizontal=�6   $��20,0,0,0q�62   $��60��6D   $��Bottom=�6P   .+�5g      �� -   5         ��Name$ 	stack_Edu��5g      $��0,0.053,0,0q�60   $ Vertical=�6E   $	��120��6w   $ 0.5,0.5&�6�   z�5h      V� 5i      .~�5j      �� �� 5k      �� 5l      T� 5m      5n      .+�5p      �� -   5        $ textBlock_Copy1��5p       $��0q�69   $
��Wrap=�6D   $
��Bold"�6X   $��Segoe UI Light)�6j   $��CLASSES��6�   $��18��6�   #���  6�   �� 5q      -   5         ��Name$ comboBox_Education��5q      $��1,0,0,0q�6;   $��21��6�   $	��120��6�   $( "Visa statestik för specifik klass��6�   ��6L   �� *
_Education+��5r      �� 5s      .R�5t   "   �� ��6,   �� *Name+5u      5w      5x      �� 5z      -   5        $ 
stacl_User��5z      $��20,0,0,0q�61   $ Vertical=�6C   $	��104��6Z   $
��52.8��6i   $	��Top=�6w   $ 0.5,0.5&�6�   z�5{      V� 5|      .~�5}      �� �� 5~      �� 5      T� 5�      5�      .+�5�      �� -	   5        $ textBlock_Copy3��5�       $
��Wrap=�69   $
��Bold"�6M   $��Segoe UI Light)�6_   $��PUPIL��6{   $��18��6�   #���  6�   �� 5�      -
   5        $ comboBox_User��5�      $��21��6�   $��60��6�   $' !Visa statestik för specifik elev��6�   ��66   �� *_Users+��5�      �� 5�      .R�5�   "   �� ��6,   �� *Name+5�      5�      5�      5�      �� 5�      ���	#FFFFE4B3 K� ZIndex$ -3��6)    �� RadiusY$ 30��6g    �� RadiusX$ 30��6t    J� Effect 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�         
BlurRadius$ 25Q�6'      Opacity$	 0.1Q�67   5�      5�      5�      5�      