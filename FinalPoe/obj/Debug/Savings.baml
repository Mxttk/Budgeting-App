   M S B A M L   `   `   `  ����C  ?FinalPoe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FinalPoeFinalPoe  5   	       FinalPoe.Savings   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:FinalPoe     5   	     � Title$  Savings��5   	   $	��400��6   $	��800��6&    � WindowStartupLocation$ CenterScreen=�62    � 
ResizeMode$ NoResize=�6W    � WindowStyle$
 None=�5	   	   .��5
      �� 
���   �$��5q�6!   ._�5   
   � .+�5      � -   5         �Name$ BG��5      $	��390��6   $��Center=�6,   ��5      �� 5      -   5        
img_bg�� �� ImageSource$ Background/background.png��5   !    j� Stretch$
 None=�5   !   5      �� 5      $��21,21,19,16q�6   .+�5      �� $��Savings��6   
���   �$��20(�6=   $��Center=�6K   $
��Bold"�6h   6|   �� 5      
���   �61   �� 5      $+��%Amount you would like to save up to: ��6   
���   �6]   �� 5      -   5        $��tbSavingAmount��5      
���   �
�������6X   �� 5      $3��-Time you would like to save for (In months): ��6   
���   �6e   �� 5       -   5        $��tbsavingTime��5       
���   �
�������6V   �� 5"      $��Reason for saving: ��6   
���   �6K   �� 5#      -   5        $��tbSavingReason��5#      
���   �
�������6X   �� 5%      $��Interest rate: ��6   
���   �6G   �� 5&      -   5        $��tbInterestRate��5&      
���   �
�������6X   �� 5(      
���   �$
��0 10q�6/   6?   �� 5)      -   5         ��Name$ enterBtn��5)      $��Enter��6+   
���   �
�������$	��306��6a   $��10 10q�5*      6A   �� 5,      
���   �62   �� 5.      $_��Y**Once savings has been entered click detailed expenses to be taken to the final screen**��6   $��Center=�5/      $��10q�65   $
��Bold"�6A   6U   51      � 54      -   5        $	 btn��54      $��Center=�6    $��
0,300,0,10q�6=   $	��741��6Q   .+�55      �� -	   5        $ detailedExpensesBtn��55      $��Detailed expenses��66   
���   �
�������$��Center=�6x   $	��Top=�56      $	��176��6S   $��30��6_   $��0,50,0,0q�6k   6   58      5<      5=      5>      