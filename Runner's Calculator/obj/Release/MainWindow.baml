   M S B A M L   `   `   `  ���� L  HRunner Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Runners_CalculatorRunners_Calculator  #    Runners_Calculator.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:Runners_Calculator     -     �Name$  frmMain�� � Title$ Runner Calculator��$��280.408��$��449.51�� � WindowStartupLocation$ CenterScreen=����	#FFF0F0F0 � 
ResizeMode$ NoResize=�.��� $	��254��$	��Top=�$��0,0,0,-3q�.+��� -    ��Name$ txtTimeHours��$
��Left=�$��23��$��	51,25,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��72��$��0��$��Tahoma)��� -    ��Name$ lblTime��$��Time:��$
��Left=�$��	13,21,0,0q�$	��Top=�$��Tahoma)��� -   $ txtTimeMinutes��$
��Left=�$��23��$��
128,25,0,0q�$
 Wrap=�$	��Top=�$��73��$��1��$��Tahoma)��� -   $ txtTimeSeconds��$
��Left=�$��23��$��
206,25,0,0q�$
 Wrap=�$	��Top=�$��87��$��2��$��Tahoma)��� -   $ lblTimeHours��$��hours��$
��Left=�$��67,1,0,0q�$	��Top=�$��Tahoma)��� -   $ lblTimeMinutes��$
��mins��$
��Left=�$��	147,1,0,0q�$	��Top=�$��Tahoma)��� -   $ lblTimeSeconds��$
��secs��$
��Left=�$��	233,1,0,0q�$	��Top=�$��Tahoma)��� -	   $ txtPaceHours��$
��Left=�$��23��$��
51,154,0,0q�$
 Wrap=�$	��Top=�$��72��$��Tahoma)�$��4���� -
   $ lblPace��$��Pace:��$
��Left=�$��
13,150,0,0q�$	��Top=�$��Tahoma)��� -   $ txtPaceMinutes��$
��Left=�$��23��$��128,154,0,0q�$
 Wrap=�$	��Top=�$��73��$��Tahoma)�$��5���� -   $ txtPaceSeconds��$
��Left=�$��23��$��206,154,0,0q�$
 Wrap=�$	��Top=�$��87��$��Tahoma)�$��6���� -   $ lblPaceHours��$��hours��$
��Left=�$��
67,131,0,0q�$	��Top=�$��Tahoma)��� -   $ lblPaceMinutes��$
��mins��$
��Left=�$��147,131,0,0q�$	��Top=�$��Tahoma)��� -   $ lblPaceSeconds��$
��secs��$
��Left=�$��233,131,0,0q�$	��Top=�$��Tahoma)��� -   $ lblDistance��$��	Distance:��$
��Left=�$��	13,89,0,0q�$	��Top=�$��Tahoma)��� -   $ txtDistance��$
��Left=�$��23��$��	71,92,0,0q�$
 Wrap=�$	��Top=�$	��120��$��Tahoma)�$��3���� -   $ lblMiles��$��miles��$
��Left=�$��
112,67,0,0q�$	��Top=�$��Tahoma)��� -    ��Name$ btnTime��$��Calculate Time��$
��Left=�$��
312,27,0,0q�$	��Top=�$	��113��$��Tahoma)�$��7���� -   $ btnDistance��$��Calculate Distance��$
��Left=�$��
312,95,0,0q�$	��Top=�$	��113��$��Tahoma)�$��8���� -   $ btnPace��$��Calculate Pace��$
��Left=�$��312,156,0,0q�$	��Top=�$	��113��$��Tahoma)�$��9���� -   $ btnReset��$��Reset��$
��Left=�$��147,218,0,0q�$	��Top=�$	��108��$��Tahoma)�$��10���� -    ��Name$ cmbDistance��$
��Left=�$��
206,93,0,0q�$	��Top=�$��87��.@��� $��Miles��$
��Left=�$��92���� $��
Kilometers��$
��Left=�$��92���� $��Meters��$
��Left=�$��92���� $��Yards��$
��Left=�$��92���� -   $ lblPer��$	��Per��$
��Left=�$��
51,182,0,0q�$	��Top=�$��Tahoma)��� -   $ cmbPace��$
��Left=�$��128,184,0,0q�$	��Top=�$��87��.@��� $
��Mile��$
��Left=�$��92���� $��	Kilometer��$
��Left=�$��92���� $��800 M��$
��Left=�$��92���� $��400 M��$
��Left=�$��92���� $��200 M��$
��Left=�$��92��