   M S B A M L   `   `   `  ����J  FDragDropTextOps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DragDropTextOpsDragDropTextOps  5   	        DragDropTextOps.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DragDropTextOps     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1q�6   
���   �
�������._�5      �� $��Center=�6   $��Center=�64    �� Orientation$ 
Horizontal=�6Q   .+�5      �� $
��Wrap=�6   $	��300��60   ��Select some text in the area below-left, and click the button to create a data object that contains the selected text. Info about the data objectwill be displayed below-right.5      �� 5      -   5        $	��200��5      $��30��6   $*��$Create data object from selection...��5      5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5"      �� 2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve5,      -   5        $��sourceTextBox��5#      $��0��5%      $
{�True��5&      $
|�True��5'       �� 
IsReadOnly$
 True��5(       �� TextWrapping$ NoWrap=�5)      $��1q�5*      
���   �
�������.��5-      ��
The fair breeze blew, the white foam flew,
The furrow followed free;
We were the first that ever burst
Into that silent sea.

Down dropt the breeze, the sails dropt down,
'Twas sad as sad could be;
And we did speak only to break
The silence of the sea!

All in a hot and copper sky,
The bloody Sun, at noon,
Right up above the mast did stand,
No bigger than the Moon.

Day after day, day after day,
We stuck, nor breath nor motion;
As idle as a painted ship
Upon a painted ocean.

Water, water, every where,
And all the boards did shrink;
Water, water, every where,
Nor any drop to drink.
      5F      �� 5H      -   5        $��dataObjectInfoTextBox��5I      $��1��5J      $
{�True��5K      $
|�True��5L      $
 True��5M      $
 Wrap=�5N      $��1q�5O      
���   �
�������5Q      5S      5T      5U      