   M S B A M L   `   `   `  ����L  HRunner Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Runners_CalculatorRunners_Calculator  5   	   #    Runners_Calculator.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Runners_Calculator     5   	   -   5          �Name$  frmMain��5   	    � Title$ Runner Calculator��5   	   $��280.408��6#   $��449.51��64    � WindowStartupLocation$ CenterScreen=�6C   ���	#FFF0F0F0 � 
ResizeMode$ NoResize=�6   .��5	      � $	��254��6   $	��Top=�6   $��0,0,0,-3q�60   .+�5
   
   �� -   5         ��Name$ txtTimeHours��5
      $
��Left=�6(   $��23��6C   $��	51,25,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $��72��6�   $��0��6�   $��Tahoma)�6�   �� 5   
   -   5         ��Name$ lblTime��5      $��Time:��6!   $
��Left=�61   $��	13,21,0,0q�6L   $	��Top=�6_   $��Tahoma)�6w   �� 5   
   -   5        $ txtTimeMinutes��5      $
��Left=�6*   $��23��6E   $��
128,25,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $��73��6�   $��1��6�   $��Tahoma)�6�   �� 5   
   -   5        $ txtTimeSeconds��5      $
��Left=�6*   $��23��6E   $��
206,25,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $��87��6�   $��2��6�   $��Tahoma)�6�   �� 5   
   -   5        $ lblTimeHours��5      $��hours��6&   $
��Left=�66   $��67,1,0,0q�6Q   $	��Top=�6c   $��Tahoma)�6{   �� 5   
   -   5        $ lblTimeMinutes��5      $
��mins��6(   $
��Left=�67   $��	147,1,0,0q�6R   $	��Top=�6e   $��Tahoma)�6}   �� 5   
   -   5        $ lblTimeSeconds��5      $
��secs��6(   $
��Left=�67   $��	233,1,0,0q�6R   $	��Top=�6e   $��Tahoma)�6}   �� 5   
   -	   5        $ txtPaceHours��5      $
��Left=�6(   $��23��6C   $��
51,154,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $��72��6�   $��Tahoma)�6�   $��4��6�   �� 5   
   -
   5        $ lblPace��5      $��Pace:��6!   $
��Left=�61   $��
13,150,0,0q�6L   $	��Top=�6`   $��Tahoma)�6x   �� 5   
   -   5        $ txtPaceMinutes��5      $
��Left=�6*   $��23��6E   $��128,154,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $��73��6�   $��Tahoma)�6�   $��5��6�   �� 5   
   -   5        $ txtPaceSeconds��5      $
��Left=�6*   $��23��6E   $��206,154,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $��87��6�   $��Tahoma)�6�   $��6��6�   �� 5   
   -   5        $ lblPaceHours��5      $��hours��6&   $
��Left=�66   $��
67,131,0,0q�6Q   $	��Top=�6e   $��Tahoma)�6}   �� 5   
   -   5        $ lblPaceMinutes��5      $
��mins��6(   $
��Left=�67   $��147,131,0,0q�6R   $	��Top=�6g   $��Tahoma)�6   �� 5   
   -   5        $ lblPaceSeconds��5      $
��secs��6(   $
��Left=�67   $��233,131,0,0q�6R   $	��Top=�6g   $��Tahoma)�6   �� 5   
   -   5        $ lblDistance��5      $��	Distance:��6%   $
��Left=�69   $��	13,89,0,0q�6T   $	��Top=�6g   $��Tahoma)�6   �� 5   
   -   5        $ txtDistance��5      $
��Left=�6'   $��23��6B   $��	71,92,0,0q�6N   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $��Tahoma)�6�   $��3��6�   �� 5   
   -   5        $ lblMiles��5      $��miles��6"   $
��Left=�62   $��
112,67,0,0q�6M   $	��Top=�6a   $��Tahoma)�6y   �� 5   
   -   5         ��Name$ btnTime��5      $��Calculate Time��6"   $
��Left=�6;   $��
312,27,0,0q�6V   $	��Top=�6j   $	��113��6�   $��Tahoma)�6�   $��7��6�   �� 5   
   -   5        $ btnDistance��5      $��Calculate Distance��6&   $
��Left=�6C   $��
312,95,0,0q�6^   $	��Top=�6r   $	��113��6�   $��Tahoma)�6�   $��8��6�   �� 5   
   -   5        $ btnPace��5      $��Calculate Pace��6"   $
��Left=�6;   $��312,156,0,0q�6V   $	��Top=�6k   $	��113��6�   $��Tahoma)�6�   $��9��6�   �� 5   
   -   5        $ btnReset��5      $��Reset��6#   $
��Left=�63   $��147,218,0,0q�6N   $	��Top=�6c   $	��108��6{   $��Tahoma)�6�   $��10��6�   �� 5   
   -   5         ��Name$ cmbDistance��5      $
��Left=�6(   $��
206,93,0,0q�6C   $	��Top=�6W   $��87��6o   .@�5       �� $��Miles��6   $
��Left=�6+   $��92��6F   �� 5!      $��
Kilometers��6   $
��Left=�60   $��92��6K   �� 5"      $��Meters��6   $
��Left=�6,   $��92��6G   �� 5#      $��Yards��6   $
��Left=�6+   $��92��6F   5$      �� 5%   
   -   5        $ lblPer��5%      $	��Per��6    $
��Left=�6.   $��
51,182,0,0q�6I   $	��Top=�6]   $��Tahoma)�6u   �� 5&   
   -   5        $ cmbPace��5&      $
��Left=�6$   $��128,184,0,0q�6?   $	��Top=�6T   $��87��6l   .@�5'      �� $
��Mile��6   $
��Left=�6*   $��92��6E   �� 5(      $��	Kilometer��6   $
��Left=�6/   $��92��6J   �� 5)      $��800 M��6   $
��Left=�6+   $��92��6F   �� 5*      $��400 M��6   $
��Left=�6+   $��92��6F   �� 5+      $��200 M��6   $
��Left=�6+   $��92��6F   5,      5-      5.      