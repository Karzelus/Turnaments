   M S B A M L   `   `   `  ����D  @Turnament, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Turnament	Turnament  5   	       Turnament.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Turnament     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ���#26292B � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButton �� 
TargetType	 �� 
TargetType
 ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6&   .�5      ��  �@�FocusVisualStyle8   61   �� 5        � ��8  6+   �� 5!       � ��8  6,   �� 5"       � ��# � ��6+   �� 5#       � ��$ 0q�60   �� 5$       � ��$ Center=�6;   �� 5%       � ��$ Center=�69   �� 5&       � ��$ 1q�6(   �� 5'       � �� 5(      �� 5)      "	 ��6&   .R�5*      �� $
 border��6!   $ 20��61   #��z��6C   #��z��6m   #��z��6�    . ._�5+      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5,       5-      P� 5.       �@��IsDefaulted . . �5/   "   �� $ border��6@   # � ��6T    � ��50      P� 51       �@J�	IsFocused . . �52   "   �� $ border��6@   # � ��6T    � ��53      P� 54       �@J�IsMouseOver . . �55   "   �� $ border��6?    � �� �#A2B2EE6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � �� . . �59   "   �� $ border��6?    � �� �#A2B2EE6S   �� 5:   "   $ border��6@    � �� �#A2B2EE6T   5;      P� 5<       � {� .  . �5=   "   �� $ border��6?   8   � ��6S   �� 5>   "   $ border��6@   8   � ��6T   �� 5?   "   $ contentPresenter��6K   8   � ��6i   5@      5B      5D      5E      5F      .��5G      � .+�5I   
   �� .+�5J      �� -   5         ��Name$ 
BracketBtn��5J      #��� 
 6)   $��Bracket��6Q   $��80��6c   $��40��6n   $
��Left=�5K      ���#5F7ADB���#FEF4F4$��
10,100,0,0q�5L      6)   �� 5M      -   5        $ 
RankingBtn��5M      #��� 
 6)   $��Ranking��6Q   $��80��6c   $��40��6n   $
��Left=�5N      ���#5F7ADB���#FEF4F4$��	10,10,0,0q�5O      6(   �� 5P      -   5        $ TeamsBtn��5P      #��� 
 6'   $��Teams��6O   $��80��6_   $��40��6j   $
��Left=�5Q      ���#5F7ADB���#FEF4F4$��	10,10,0,0q�5R      6(   �� 5S      -   5        $ 
HistoryBtn��5S      #��� 
 6)   $��History��6Q   $��80��6c   $��40��6n   $
��Left=�5T      ���#5F7ADB���#FEF4F4$��	10,10,0,0q�5U      6(   �� 5V      -   5        #��� 
 5V      $��Exit Tournament��6=   $��80��6W   $��40��6b   $
��Left=�5W      ���#5F7ADB���#FEF4F4$��	10,70,0,0q�5X      6(   5Y       � 5Z   
   -   5          �Name$
 Main��5Z      $��	100,0,0,0q�6     � NavigationUIVisibility$ Hidden=�61   5[      5\      