   M S B A M L   `   `   `  ����P  LAuto-Shutdown Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Auto_Shutdown_ProgramAuto_Shutdown_Program  5   	   &     Auto_Shutdown_Program.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Auto_Shutdown_Program     5   	   -   5          �Name$  Avstängnings_Program��5   	    � Title$ Auto-Shutdown Program��5   	   $	��350��6'   $	��525��64    � 
ResizeMode$ NoResize=�6@   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��97* �6   �� 5      $	��98* �6   �� 5      $
��322* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ button_90min��5      $��90 min��6'   $
��Left=�68   $��
25,167,0,0q�6S   $	��Top=�6g   $	��121��6   $	��113��6�   $��2��6�   $��21.333(�6�   �� 5   
   -   5        $ button_Avbryt��5      $��ABORT��6(   $
��Left=�68   $��
179,33,0,0q�6S   $	��Top=�6g   $	��119��6   $	��100��6�   $��2��6�   $��21.333(�6�   �� 5   
   -   5        $ button_60min��5      $��60 min��6'   $
��Left=�68   $��
27,167,0,0q�6S   $	��Top=�6g   $	��121��6   $	��113��6�   $��2��6�   $��21.333(�6�   �� 5   
   -   5        $ button��5      $��SHUT
DOWN
NOW��6!   $��2��6K   $
��Left=�6[   $��179,167,0,0q�6v   $	��Top=�6�   $	��119��6�   $	��113��6�   $��21.333(�6�   �� 5   
   -   5         ��Name$ currentLabel��5      $
��Left=�6&   $��	47,67,0,0q�6A   $	��Top=�6T   $��62��6l   $��1��6w   $��2��6�   �� 5   
   -   5        $ 
buttonPlus��5      $��+��6%   $��2��61   $
��Left=�6A   $��	25,33,0,0q�6\   $	��Top=�6o   $	��121��6�   $	��100��6�   $��22(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ buttonMinus��5      $	��-
��6&   $
��Left=�6<   $��	27,33,0,0q�6W   $	��Top=�6j   $	��121��6�   $	��100��6�   $��2��6�   $��22(�6�   $
��Bold"�6�   6�   �� 5   
   -	   5        $ currentLabel1��5      $�� ��6'   $��1��62   $
��Left=�6B   $��	72,55,0,0q�6]   $	��Top=�6p   $��59��6�   $��78��6�   $��2��6�   $��16(�6�   5      5      