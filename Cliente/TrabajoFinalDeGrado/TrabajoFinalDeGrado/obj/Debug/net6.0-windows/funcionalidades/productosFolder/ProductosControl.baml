   M S B A M L   `   `   `  ����N  JTrabajoFinalDeGrado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:TrabajoFinalDeGrado.funcionalidades.productosFolder3TrabajoFinalDeGrado.funcionalidades.productosFolder  5      J    DTrabajoFinalDeGrado.funcionalidades.productosFolder.ProductosControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      SlocalAclr-namespace:TrabajoFinalDeGrado.funcionalidades.productosFolder     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��0.25* �6   �� 5      .+�5   
   � 
������ $��0��6(   $��55,20,40,20q�65   .+�5      �� $��10q�6   ���#272B2F �� CornerRadius$ 5��5       ���#272B2F._�5      �  � ColumnDefinitions 5      �� 5      $��5* �6+   �� 5      .+�5      �� -   5        $��txtHint��5   y    J� Opacity$ .8Q�6   $��19(�6+   $��40��69   $��10,0,0,0q�6E   $��Center=�6W   $#��Escribe lo que quieras buscar��5      5      �� 5      -   5        $��addListaBtn��5      $��1��60   $��Center=�6@   $��18(�5   *    � Cursor$
 Hand��68   $��0q�6F   
�������
 � Tag 6m   �� ��5      �� 5       �� 
TargetType" ��6$   .�5    "   ��  �� Property � �� �� Value
 ����6?   	 �� Triggers	 5!   "   P� 5"   &   
 P� Property
 �@J�IsMouseOver P� Value$
 True��6E   . �5#   *   ��  � �� �#0F4A826G   5$   '   5'      ��5)      �� 5*       �� 
TargetType" ��6.   .R�5+   "   �� $	��130��6)   $��40��65   $ 5��5,   6   #��z��6G   ._�5-   &   �� $��Center=�67   $��Center=�6R   $��Buscar��6o   5.   #   5/      51      54      56      58      �� 59   
   -   5        $��
MyScroller��59      
������ $��Center=�6b   $��40,0,0,0q�6�   $��1��6�   .��5;      �� -   5         ��Name$ ListViewProducts��5;      $��False��5<      $��Disabled=�5=      $��Disabled=�5>      $��0q�5?      
������ ��5;   1   �� *
Products+��5B      �� 5E      .R�5G      �� $��Center=�6!   $ 8��5H   !   $��0q�5I   !   $	��290��5J   !   $	��500��5K   !    �� Padding$ 5q�5L   !   ���#272B2F$��10q�5N   !   $	 0.9Q�5O   !   ._�5P      ��  �� Orientation$ Vertical=�6)   .+�5R   "   �� $	��230��6B   $	��280��6O   $��0,10,0,0q�6[   ��6(   �� *imagen+6[   � 5T   "   $��0,20,0,0q�6'   $	��210��69     5U   &   �� 5V   *   �� 5W   *   �� 5X   *   .+�5Z   &   �� $��Right=�6H   
�������$��18(�5\   ,   $
��Wrap=�6:   $	��280��6N   $��80��6Z    �� Padding$ 	20,0,20,0q�6i   ��5Z   0   �� *nombre+5\   i   �� 5]   &   -   5        
������ $
 Hand��5^   I   $��60��6W   ��5]   0   �� *url+5^   W   � 5_   &   $��1��6+   $��0,15,0,0q�68     5`   *   �� 5a   .   �� 5b   .    5d   *   �� 5e   .   �� 5f   .   .+�5h   *   �� $��Precio: ��65   $
��Left=�6E   $��0��6a   $��0��6n   
�������$ 20,0,0,0q�5i   H   $��18(�5j   5   �� 5k   *   $��Supermercado: ��65   $
��Left=�6K   $��1��6g   $��0��6t   
�������$ 20,0,0,0q�5l   H   $��18(�5m   5   � 5o   *   $��1��6/    5p   .   �� 5q   2   �� 5r   2   .+�5t   .   �� $��Right=�6Q   $��0��6n   $��0��6{   
�������$ 	10,0,20,0q�5u   L   $��18(�5v   9   ��5t   9   �� *precio+5v   9   �� 5w   .   $	��€��69   $
��Left=�6B   $��0��6^   $��1��6k   
�������$ 0,0,20,0q�5x   L   $��18(�5y   9   5{   +   �� 5|   *   $
��Left=�6S   $��1��6o   $��1��6|   
�������$ 20,0,0,0q�5}   H   $��18(�5~   5   ��5|   5   �� *supermercado+5~   5   5   '   � 5�   &   $��2��6+    5�   *   �� 5�   .   �� 5�   .   .+�5�   *   �� $��addCarritobtn��61   -   5        $��0��5�   F   $��Bottom=�6V   $��18(�5�   1   $
 Hand��6?   $��0q�6M   
������� 6t   �� ��5�   .   �� 5�   2   " ��68   .�5�   6   ��  � ��
 ����6S   	 5�   6   P� 5�   :   
 �@J�IsMouseOver$
 True��6Y   . �5�   >   ��  � �� �#0F4A826[   5�   ;   5�   3   ��5�   .   �� 5�   2   " ��6B   .R�5�   6   �� $	��130��6=   $��40��6I   $ 5��5�   =   #��z��6N   ._�5�   :   �� $��Center=�6K   $��Center=�6f   $��Añadir al carrito��6�   5�   7   5�   3   5�   +   �� 5�   *   $��addListaBtn��61   -   5        $��1��5�   D   $��Bottom=�6T   $��18(�5�   1   $
 Hand��6?   $��0q�6M   
������� 6t   �� ��5�   .   �� 5�   2   " ��68   .�5�   6   ��  � ��
 ����6S   	 5�   6   P� 5�   :   
 �@J�IsMouseOver$
 True��6Y   . �5�   >   ��  � �� �#0F4A826[   5�   ;   5�   3   ��5�   .   �� 5�   2   " ��6B   .R�5�   6   �� $	��130��6=   $��40��6I   $ 5��5�   =   #��z��6N   ._�5�   :   �� $��Center=�6K   $��Center=�6f   $��Añadir a la lista��6�   5�   7   5�   3   5�   +   5�   '   5�   #   5�      5�      5�      ��5�      �� 5�      .R�5�      � 5�      5�      5�      5�      5�      