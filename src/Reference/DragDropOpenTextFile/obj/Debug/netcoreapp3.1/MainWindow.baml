   M S B A M L   `   `   `  ����O  KDragDropOpenTextFile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DragDropOpenTextFileDragDropOpenTextFile  5   	   %    DragDropOpenTextFile.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:DragDropOpenTextFile     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   ���	#CC0088FF.+�5      �� -   5        $��btClear��5      $��Clear��6-   $��5q�6=   �� 5      
���   �$��1q�6)   $��25��6=   ._�5      �� -   5        $��cbWrap��5      $��Wrap Content��5       d� 	IsChecked$ FalseY�5      $��5q�5      $��5,0,0,0q�6   $��Center=�5      $��Center=�6(   5      5      �� 5      -   5        $��lblInstructions��5      $��Center=�5      $��Center=�6/   $
��Bold"�5       $A��;     Drop a single file below to display its contents.     ��5!      5#      �� 5%   
   -   5        $��tbDisplayFileContents��5&   	   $��1��5'   	    �� AcceptsReturn$
 True��5(   	    �� 
AcceptsTab$
 True��6    J� 	AllowDrop$
 True��5)   	   $��1q�5*   	   
���   �$ �� HorizontalScrollBarVisibility$
 Auto=�5+   	   " �� VerticalScrollBarVisibility$
 Auto=�6.   5-   &   5/      50      