   M S B A M L   `   `   `  ����N  JTrabajoFinalDeGrado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:TrabajoFinalDeGrado.funcionalidades.perfilFolder0TrabajoFinalDeGrado.funcionalidades.perfilFolder  5   	   B    <TrabajoFinalDeGrado.funcionalidades.perfilFolder.ListaWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:TrabajoFinalDeGrado.funcionalidades.perfilFolder     5   	   $	��800��5   "   $	��780��6/     � 
ResizeMode$  CanMinimize=�5	   	    � AllowsTransparency$
 True��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � Title 5   	   �� *nombre+.��5      � .+�5   
   �� ���#272B2F �� CornerRadius$ 8��6&   ._�5      �  � RowDefinitions 5      �� 5      $��30 �6$   �� 5      .+�5      � -   5        $��0��5      .+�5      �� ���#272B2F$ 8,8,0,0��5      5      � 5"      $��1��6   $��Center=�6$   ���#313338$��20q�6X   $	��780��6d    5#      �� 5$      $
��0.3* �6(   �� 5%      .+�5'      �� -   5        $��
MyScroller��5'   0   $��1��6#   
������ $��Center=�6[   $��20q�6�   .��5(      �� -   5         ��Name$ ListViewCarrito��5(   #   $��False��5)      $��Disabled=�5*      $��Disabled=�5+      $��0q�5,      
������ $��Center=�5.      ��5(   <   �� *lista+��5/      �� 50   "   .R�51   &   �� $��Center=�6-   $ 8��52   %   $��0q�53   %   $	��290��54   %   $	��500��55   %    �� Padding$ 5q�56   %   ���#272B2F$��15q�58   %   	 J� Opacity$		 0.9Q�59   %   ._�5:   *   �� 
 �� Orientation$
 Vertical=�65   .+�5<   .   �� $	��230��6N   $	��280��6[   $��0,10,0,0q�6g   ��64   �� *imagen+6g   � 5>   .   $��0,20,0,0q�63   $	��210��6E    5?   2   �� 5@   6   �� 5A   6   �� 5B   6   $��0.75* �6D   .+�5D   2   �� $��Right=�6T   
�������$��18(�5F   0   $
��Wrap=�6>   $	��280��6R   $��80��6^    �� Padding$ 	20,0,20,0q�6m   ��5D   <   �� *nombre+5F   m   �� 5G   2   -   5        
������  � Cursor$
 Hand��5H   M   $��60��6[   ��5G   <   �� *url+5H   [   � 5I   2   $��1��67   $��0,15,0,0q�6D    5J   6   �� 5K   :   �� 5L   :   �� 5M   :    � ColumnDefinitions 5O   6   �� 5P   :   �� 5Q   :   .+�5S   6   �� $��Precio: ��6A   $
��Left=�6Q   $��0��6m   $��0��6z   
�������$ 20,0,0,0q�5T   L   $��18(�5U   9   �� 5V   6   $��Supermercado: ��6A   $
��Left=�6W   $��1��6s   $��0��6�   
�������$ 20,0,0,0q�5W   L   $��18(�5X   9   �� 5Y   6   $��
Cantidad: ��6A   $
��Left=�6S   $��2��6o   $��0��6|   
�������$ 20,0,0,0q�5Z   L   $��18(�5[   9   �� 5\   6   $��Center=�6Y   $��0��6w   $��1��6�   
�������$ 0,0,20,0q�5]   L   $��18(�5^   9   ��5\   A   �� *precio+5^   9   �� 5_   6   $��Center=�6_   $��1��6}   $��1��6�   
�������$ 0,0,20,0q�5`   L   $��18(�5a   9   ��5_   A   �� *supermercado+5a   9   �� 5b   6   $��Center=�6[   $��2��6y   $��1��6�   
�������$ 0,0,20,0q�5c   L   $��18(�5d   9   ��5b   A   �� *
cantidad+5d   9   5e   3   � 5g   2   $��2��67    5h   6   �� 5i   :   �� 5j   :   �� 5k   :   .+�5n   6   �� $��	addButton��6=   -   5        $��0��5n   N   $��Bottom=�6^   $
 Hand��5o   4   $��0q�6B   
�������$��19(�6i   
 � Tag 5n   �   �� ��5p   :   �� 5q   >    �� 
TargetType" ��6D   .�5r   B   ��  �� Property � �� �� Value �	#FFF3BF096_    �� Triggers 5s   B   P� 5t   F    P� Property �@J�IsMouseOver P� Value$
 True��6e   . �5u   J   ��  � �� �	#FFAF99046g   5v   G   5y   ?   ��5{   :   �� 5|   >    �� 
TargetType" ��6N   .R�5}   B   �� $��40��6I   $��40��6T   $��Center=�6`   $��Center=�6|   $ 20��5~   A   #��z��6S   ._�5   F   �� $��Center=�6W   $��Center=�6r   $��+��6�   5�   C   5�   ?   5�   7   �� 5�   6   $��substractButton��6=   -   5        $��1��5�   T   $��Bottom=�6d   $��19(�5�   5   $
 Hand��6C   $��0q�6Q   
������� 5�   �   �� ��5�   :   �� 5�   >   " ��6D   .�5�   B   ��  � �� �	#FFF3BF096_    5�   B   P� 5�   F    �@J�IsMouseOver$
 True��6e   . �5�   J   ��  � �� �	#FFAF99046g   5�   G   5�   ?   ��5�   :   �� 5�   >   " ��6N   .R�5�   B   �� $��40��6I   $��40��6T   $��Center=�6`   $��Center=�6|   $ 20��5�   A   #��z��6S   ._�5�   F   �� $��Center=�6W   $��Center=�6r   $��-��6�   5�   C   5�   ?   5�   7   �� 5�   6   $��	binButton��6=   -   5        $��2��5�   N   $��Bottom=�6^   $��19(�5�   5   $
 Hand��6C   $��0q�6Q   
������� 5�   �   �� .��5�   :   �� $)��#/imagenes/papelera-de-reciclaje.png��6@   $��30��6m   $��30��6y   ��5�   :   �� 5�   >   " ��6D   .�5�   B   ��  � �� �	#FFA505056_    5�   B   P� 5�   F    �@J�IsMouseOver$
 True��6e   . �5�   J   ��  � �� �	#FF9401016g   5�   G   5�   ?   ��5�   :   �� 5�   >   " ��6N   .R�5�   B   �� $��40��6I   $��40��6T   $��Center=�6`   $��Center=�6|   $ 20��5�   A   #��z��6S   ._�5�   F   �� $��Center=�6W   $��Center=�6r   5�   C   5�   ?   5�   7   5�   3   5�   /   5�   +   5�   '   5�   #   ��5�      �� 5�   "   .R�5�   &   � 5�   #   5�      5�      � 5�      
������ $��0��64   $��40,20,40,20q�6A   .+�5�      �� $��10q�6!   ���#272B2F$ 5��5�   +   ���#272B2F._�5�      �  5�   "   �� 5�   &   $��3* �67   �� 5�   &   .+�5�   "   �� -   5        $��txtNombreLista��5�   �   $	 .8Q�6*   $��19(�67   $��40��6E   $��10,0,0,0q�6Q   $��Center=�6c   5�   !   �� 5�   "   -	   5        $��addListaBtn��5�   )   $��1��6<   $��Center=�6L   $��15(�5�   5   $
 Hand��6C   $��0q�6Q   
������� 6x   �� ��5�   &   �� 5�   *   " ��60   .�5�   .   ��  � ��
 ����6K    5�   .   P� 5�   2    �@J�IsMouseOver$
 True��6Q   . �5�   6   ��  � �� �#0F4A826S   5�   3   5�   +   ��5�   &   �� 5�   *   " ��6:   .R�5�   .   �� $	��130��65   $��40��6A   $ 5��5�   A   #��z��6R   ._�5�   2   �� $��Center=�6C   $��Center=�6^   $��Guardar��6{   5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      