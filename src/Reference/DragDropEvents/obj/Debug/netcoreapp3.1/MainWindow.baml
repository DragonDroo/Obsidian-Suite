   M S B A M L   `   `   `  ����I  EDragDropEvents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DragDropEventsDragDropEvents  5   	       DragDropEvents.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DragDropEvents     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � -   5        $��mainGrid��5	       � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��400 �6   .+�5   
   �� 
�������$��1q�6,   $��0��5      $��0��6   $��2��6$   ��5      �� 5       �� 
StartPoint$ 0.5,0&�6&    �� EndPoint$ 0.5,1&�69   ��5      �  � Offset$	 0.0Q�6'    � Color$ White��64   � 5      $	 1.0Q�6'   $ Azure��64   5      ._�5      �� -   5        $��myTextBlock��5   	   $b��\Drag something into and out of this window area and drop it to observe when the events fire.��5    	    �� TextAlignment$ Center=�5!   	   $��Stretch=�6    $
��Bold"�6<   $��30(�6N   $
��Wrap=�6\    � ToolTip$a [Drag something into and out of this window area and drop it to observe when the events fire��5#   	   	 J� 	AllowDrop$
	 True��5$   	   5.   	   50      �� 52   
   
�������$��1q�6-   $��0��6A   $��1��6N   ._�53      �� 
 �� Orientation$
 
Horizontal=�54   	   $��Center=�6"   $��Center=�6?   $��50��55   	   $	��400��6   ��57      �� 58      $ 0.5,0&�6*   $ 0.5,1&�6=   ��5:      � $	 0.0Q�6+   $ Azure��68   � 5;      $	 1.0Q�6+   $ White��68   5=      .+�5@      �� -   5        $��Clear Event History��5A      $��Center=�6)   $4 .Click to clear the event history window below.��5B      $��5q�5C      $��30��6   $��Center=�6"   5D      �� 5G      -   5        $��	cbVerbose��5H      $�� Show Verbose Event Info��5I      $@ :Check for verbose event info.  Clear for brief event info.��5J      $��Center=�5K      $��5q�6&   $��Center=�61   5M      5N      �� 5P   
   -   5        $��spEventWindow��5P      $
 Vertical=�6*   $��1��6A   $��1��6N   .+�5Q      �� -   5        $��lblEventSelectionTitle��5R   	   $	��400��6'   $��25��63   $��Center=�5S   	   
�������$
��Bold"�5T   $   $��Events To Monitor��5U   	   � 5W      -   5        $��eventChecksGrid��5W      $	��130��6*   $��5,0,0,0q�67    5X      �� 5Y      $��* �6'   �� 5Z      $��* �6'    5\      �� 5]      $��* �6$   �� 5^      $��* �6$   �� 5_      $��* �6$   �� 5`      $��* �6$   �� 5a      $��* �6$   .+�5c      �� $��0��6   $��0��6(   $��2q�65   $
��Bold"�6@   $��Bubbling Events��5d      $� �The non-preview events are bubbling events, an event routing strategy where the event instance moves up the element tree (starting with the source and ending at the root of the visual tree).��5e      �� 5g      $��1��6   $��0��6(   $��2q�65   $
��Bold"�6@   $��Tunneling Events��5h      $� �The preview events are tunneling events, an event routing strategy where the event instance moves down the element tree (starting at the root of the visual tree and ending with the source). In Windows Presentation Foundation, the names of events that use this routing strategy are prefixed with the word "Preview". These events have the same signature as their counterparts that use the bubbling event routing strategy.��5i      �� 5k      -	   5        $��cbDragEnter��5k      $��0��6.   $��1��6>   $��2q�6K    d� 	IsChecked$
 TrueY�6V   $��	DragEnter��5l      $S MCheck to listen for the DragEnter event; clear to ignore the DragEnter event.��5m      �� 5o      -
   5        $��cbDragLeave��5o      $��0��6.   $��2��6>   $��2q�6K   $
 TrueY�6V   $��	DragLeave��5p      $S MCheck to listen for the DragLeave event; clear to ignore the DragLeave event.��5q      �� 5s      -   5        $��
cbDragOver��5s      $��0��6-   $��3��6=   $��2q�6J   $
 TrueY�6U   $��DragOver��5t      $Q KCheck to listen for the DragOver event; clear to ignore the DragOver event.��5u      �� 5w      -   5        $��cbDrop��5w      $��0��6)   $��4��69   $��2q�6F   $
 TrueY�6Q   $
��Drop��5x      $I CCheck to listen for the Drop event; clear to ignore the Drop event.��5y      �� 5{      -   5        $��cbPreviewDragEnter��5{      $��1��65   $��1��6E   $��2q�6R   $
 TrueY�6]   $��PreviewDragEnter��5|      $a [Check to listen for the PreviewDragEnter event; clear to ignore the PreviewDragEnter event.��5}      �� 5      -   5        $��cbPreviewDragLeave��5      $��1��65   $��2��6E   $��2q�6R   $
 TrueY�6]   $��PreviewDragLeave��5�      $a [Check to listen for the PreviewDragLeave event; clear to ignore the PreviewDragLeave event.��5�      �� 5�      -   5        $��cbPreviewDragOver��5�      $��1��64   $��3��6D   $��2q�6Q   $
 TrueY�6\   $��PreviewDragOver��5�      $_ YCheck to listen for the PreviewDragOver event; clear to ignore the PreviewDragOver event.��5�      �� 5�      -   5        $��cbPreviewDrop��5�      $��1��60   $��4��6@   $��2q�6M   $
 TrueY�6X   $��PreviewDrop��5�      $W QCheck to listen for the PreviewDrop event; clear to ignore the PreviewDrop event.��5�      5�      �� 5�      -   5        $��lblEventLogWindowTitle��5�   	   $	��400��6'   $��25��63   $��Center=�5�   	   
�������$
��Bold"�5�   #   $��Event History��5�   	   �� 5�      -   5        $��tbEventEvents��5�   	   $
}�True��5�      " �� VerticalScrollBarVisibility$
 Auto=�5�   	    �� AcceptsReturn$
 True��6,    �� 
IsReadOnly$
 True��6A   5�      5�      5�      