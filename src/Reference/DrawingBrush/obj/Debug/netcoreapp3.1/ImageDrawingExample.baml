   M S B A M L   `   `   `  ����  DrawingBrush$    DrawingBrush.ImageBrushExample   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  Using a DrawingBrush��5      .��5      �� .+�5
      �� ���	#66000000._�5      �� $��10q�6   $
��Left=�6   
�������ImageDrawing Example5   	   5      �� 5      $��10q�6   .+�5      �� ��An ImageDrawing enables a DrawingBrush to contain images. This example shows how to use an ImageDrawing with a DrawingBrush to paint the background of a button, to fill the area of an ellipse, and to fill the area of a CombinedGeometry.5   	   �� 5      $��10q�6    �� Orientation$ 
Horizontal=�6   .+�5   
   �� $	��100��6   $	��100��6   $��15,0,0,0q�6*   .��6<   
Click Me��5      L� 5       L� Drawing 5      I� 5      ��5      �  � Brush
 ����� � Geometry 5      �� 5        �� Rect$ 0,0,100,100�6,   5"      �� 5#       �� ImageSource$ sampleImages\cherries.jpg��6#    �� Rect$ 50,50,50,50�5$      �� 5%      $ sampleImages\cherries.jpg��6#   $ 	0,0,50,50�5&      5(      5*      5,      A� 5.   
   $��15,0,0,0q�6   $	��200��6$   $	��200��60   
���  ��$��1��6J   ��5/      L� 50       j� Viewport$ 
0,0,150,50�6   	 j� ViewportUnits$	 Absolute=�61   
 j� TileMode$

 Tile=�6J    51      I� 52      ��54      �� $ sampleImages\Apple.JPG��6#   $ 
0,0,100,50�6H   �� 55      $ sampleImages\cherries.JPG��6#   $ 100,0,50,50�6K   57      59      5;      F� 5=   
    �� Stretch$ Uniform=�6   $��15,0,0,0q�6!   ��5>      �� 5?       �� GeometryCombineMode$ Union=�6    �� 	Geometry1 5@      �� 5A      $ 50,70 100 100�6$    �� 	Geometry2 5C      @� 5D       @� Center$ 100,70&�6"    @� RadiusX$ 35Q�62    @� RadiusY$ 40Q�6?   5F      ��5H      L� 5I       5J      �� 5K      $" sampleImages\waterlilies.JPG��6    5L      � 5M       � X$	 100Q�6    � Y$	 100Q�6#    � Width$ 50Q�6+    � Height$ 50Q�66   5O      5Q      5S      5T   	   5U      5V      5W      