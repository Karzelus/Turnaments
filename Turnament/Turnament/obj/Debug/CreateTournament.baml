   M S B A M L   `   `   `  ����D  @Turnament, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Turnament	Turnament  5   	        Turnament.CreateTournament   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Turnament     5   	     � Title$  CreateTournament��5   	   $	��450��6"   $	��800��6/   ���#26292B � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButton �� 
TargetType	 �� 
TargetType
 ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%P  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7 	 �� 5   
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
 border��6!   $ 20��61   #��z��6C   #��z��6m   #��z��6�    . ._�5+      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5,       5-      P� 5.       �@��IsDefaulted . . �5/   "   �� $ border��6@   # � ��6T    � ��50      P� 51       �@J�IsMouseOver . . �52   "   �� $ border��6?    � �� �#A2B2EE6S   �� 53   "   $ border��6@   8   � ��6T   54      P� 55       � �� . . �56   "   �� $ border��6?   8   � ��6S   �� 57   "   $ border��6@   8   � ��6T   58      P� 59       � {� .  . �5:   "   �� $ border��6?   8   � ��6S   �� 5;   "   $ border��6@   8   � ��6T   �� 5<   "   $ contentPresenter��6K   8   � ��6i   5=      5?      5A      5B      5C      .��5D      �  � RowDefinitions 5E   
   �� 5F      6   �� 5G      6   �� 5H      6   �� 5I      $��60 �6   5J      .+�5L   
   �� $��0��6   $��Create Tournament��6!   $��Center=�6:   $	��Top=�6W   $��25(�5M      $��10,20,10,10q�6"   
�������67   �� 5O   
   $��1��6   $��Tournament Name��6!   $��Center=�68   $	��Top=�6U   $��15(�5P      
�������$��
10,5,10,10q�65   �� 5Q   
   $��1��6   $��Center=�6   $��Center=�6<   $	��200��5R      $��40��6   $��Center=�6*   $��Center=�6N   �� 5T   
   $��2��6   $��Tournament Password��6!   $��Center=�6<   $	��Top=�6Y   $��15(�5U      
�������$��
10,5,10,10q�65   �� 5V   
   $��2��6   $��Center=�6   $��Center=�6<   $	��200��5W      $��40��6   $��Center=�6*   $��Center=�6N   �� 5Y   
   -   5        #��� 
 5Y      $��3��69   $��Create��5Z      $��40��6"   $	��100��6.   $��200,0,20,20q�6:   ���#5F7ADB���#FEF4F45[   &   �� 5\   
   -   5        #��� 
 5\      $��3��69   $
��Back��5]      $��40��6    $	��100��6,   $��20,0,200,20q�68   ���#5F7ADB���#FEF4F45^   &   5_      5`      