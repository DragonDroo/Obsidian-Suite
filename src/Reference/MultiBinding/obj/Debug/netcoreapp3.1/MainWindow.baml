   M S B A M L   `   `   `  ����G  CMultiBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MultiBindingMultiBinding  5   	       MultiBinding.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MultiBinding     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5	         MultiBinding.NameList   NameListData    MultiBinding.NameConverter  MyNameConverter  NameItemTemplate `� 	Converter �� Path �� 
TargetType �� Property �� Value��%�  &	        &	      &	 &     7  '�� �       5
   
   6     5   
   6   �� 5   
   .R�5      �� ��5      `� 5      8   .1�5      �� $ 	FirstName�6"   �� 5      $ LastName�6"   5      5      5      �� 5   
   " ��6   .�5      ��  � ��$	 120��6&   �� 5       � ��
 �����6+   �� 5       � ��$ Center=�64   5      5      .��5      �� .+�5   
   �� $��18(�6   $
��Bold"�6"   $��10q�64   
�������$
��Auto��5    %   MultiBinding Sample6G   �� 5"   
   $	��200��6   #��[ 5$      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5%      ��5#      ��  �� Source# [  5%      �� 5(   
   	 �� Padding$	 0,20,0,0q�6   $��11(�6'   
�������Normal Format:6X   �� 5)   
   -   5        $��textBox1��5)      
 � DataContext#
 [  6$   ��5*      `� 5+      # [ 6    `� ConverterParameter$ FormatNormal��5,      .1�5-      �� $ 	FirstName�6   �� 5.      $ LastName�6   5/      51      �� 53   
   $	 0,20,0,0q�6   $��11(�6'   
�������Last Name First Format:6a   �� 54   
   -   5        $��textBox2��54      #
 [  6$   ��55      `� 56      # [ 6   $ FormatLastFirst��57      .1�58      �� $ 	FirstName�6   �� 59      $ LastName�6   5:      5<      5=      5>      