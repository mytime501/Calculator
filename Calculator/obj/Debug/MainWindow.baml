   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	     � Title$  
MainWindow��5   	   $	��525��6   $	��350��6)    � 	Resources 5	      ��%    5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $
��1.7* �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 	viewtable��5      
�������$��4��5       $��9��5!      $��2��6$   �� 5#   
   -   5         ��Name$ resultLabel��5'      $��0��5#      $��Right=�5$      $	��Top=�5%      $��60(�5&      $��4��5'   %   $��1��69   �� 5)   
   -   5        $ resultLabel2��5.      $��4��5)      $��Right=�5*      $	��Top=�5+      $��20(�5,      
�������$��2��5.   &   �� 50   
   -   5         ��Name$ acButton��50   c   $��AC��6(   $��3��65   $��0��6B   $��5,5,5,5q�6R      additionalButtonStyle#��[  51      �� 53   
   -   5        $ NegateButton��53   h   $	��+/-��6,   $��3��6:   $��1��6G   $��5,5,5,5q�6W   #��[  54      �� 56   
   -   5        $ percentButton��56   g   $��%��6-   $��3��69   $��2��6F   $��5,5,5,5q�6V   #��[  57      �� 59   
   -   5        $ 	mulButton��59   h   $��*��6.   $��4��6:   $��3��6G   $��5,5,5,5q�6W     operatorButtonStyle#��[ 5:      �� 5<   
   -   5        $ 	divButton��5<   h   $��/��6.   $��3��6:   $��3��6G   $��5,5,5,5q�6W   #��[ 5=      �� 5?   
   -	   5        $ 	subButton��5?   h   $��-��6.   $��5��6:   $��3��6G   $��5,5,5,5q�6W   #��[ 5@      �� 5B   
   -
   5        $ 	addButton��5B   h   $��+��6.   $��6��6:   $��3��6G   $��5,5,5,5q�6W   #��[ 5C      �� 5E   
   -   5        $ 	dotButton��5E   c   $��.��6)   $��7��65   $��2��6B   $��5,5,5,5q�6R   #��[  5F      �� 5H   
   -   5        $ equalButton��5H   e   $��=��6+   $��7��67   $��3��6D   $��5,5,5,5q�6T   #��[  5I      �� 5K   
   -   5        $ DeleteButton��5K   h   $	��Del��6,   $��2��6:   $��0��6G   $��5,5,5,5q�6W   #��[  5L      �� 5M   
   -   5        $ 
SqrtButton��5M   h   $
��Sqrt��6+   $��2��6:   $��1��6G   $��5,5,5,5q�6W   #��[  5N      �� 5O   
   -   5        $ XXButton��5O   e   $	��x^2��6)   $��2��67   $��2��6D   $��5,5,5,5q�6T   #��[  5P      �� 5Q   
   -   5        $ XinverseButton��5Q   j   $	��1/x��6.   $��2��6<   $��3��6I   $��5,5,5,5q�6Y   #��[  5R      �� 5T   
   -   5        $ 
nineButton��5T   f   $��9��6,   $��4��68   $��2��6E   $��5,5,5,5q�6U     numberButtonStyle#��[ 5U      �� 5V   
   -   5        $ eightButton��5V   f   $��8��6,   $��4��68   $��1��6E   $��5,5,5,5q�6U   #��[ 5W      �� 5X   
   -   5        $ sevenButton��5X   f   $��7��6,   $��4��68   $��0��6E   $��5,5,5,5q�6U   #��[ 5Y      �� 5Z   
   -   5        $ 	sixButton��5Z   f   $��6��6,   $��5��68   $��2��6E   $��5,5,5,5q�6U   #��[ 5[      �� 5\   
   -   5        $ 
fiveButton��5\   f   $��5��6,   $��5��68   $��1��6E   $��5,5,5,5q�6U   #��[ 5]      �� 5^   
   -   5        $ 
fourButton��5^   f   $��4��6,   $��5��68   $��0��6E   $��5,5,5,5q�6U   #��[ 5_      �� 5`   
   -   5        $ threeButton��5`   g   $��3��6,   $��6��68   $��2��6E   $��5,5,5,5q�6U   #��[ 5a      �� 5b   
   -   5        $ 	twoButton��5b   f   $��2��6,   $��6��68   $��1��6E   $��5,5,5,5q�6U   #��[ 5c      �� 5d   
   -   5        $ 	oneButton��5d   f   $��1��6,   $��6��68   $��0��6E   $��5,5,5,5q�6U   #��[ 5e      �� 5f   
   -   5        $ 
zeroButton��5f   z   $��0��6,   $��7��68   $��0��6E   $��5,5,5,5q�6U   $��2��6f   #��[ 5g      5h      5i      