   M S B A M L   `   `   `  ����J  FPriorityBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PriorityBindingPriorityBinding  5   	        PriorityBinding.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PriorityBinding     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5	      %   PriorityBinding.AsyncDataSource   	SlowestDp   SlowerDp   FastDp   AsyncDs��%h   &	          5
   
   $ Slowest Value��6    $ Slower Value��6:   $ 
Fast Value��5      6,   5      .��5      �� $��Center=�6   $��Center=�6.    � DataContext 5      ��  �� Source# [  .+�5   
   �� $��18(�6   $
��Bold"�6"   $��10q�64   $��Center=�5      Priority Binding66   �� 5   
   
�������$	��100��6*   $��Center=�66   ��5      � 5       �� FallbackValue$ defaultvalue��6"   .&�5      ��  �� Path$ 	SlowestDp�6   	 �� IsAsync$
	 True��6/   �� 5      $ SlowerDp�6   $
	 True��6.   �� 5      $ FastDp�6   5      5      5      5      