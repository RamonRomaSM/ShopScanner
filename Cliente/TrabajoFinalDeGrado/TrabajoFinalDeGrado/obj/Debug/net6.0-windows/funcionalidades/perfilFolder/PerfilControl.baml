   M S B A M L   `   `   `  ����N  JTrabajoFinalDeGrado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:TrabajoFinalDeGrado.funcionalidades.perfilFolder0TrabajoFinalDeGrado.funcionalidades.perfilFolder  5      D    >TrabajoFinalDeGrado.funcionalidades.perfilFolder.PerfilControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:TrabajoFinalDeGrado.funcionalidades.perfilFolder     5      .��5	      � .+�5   
   � $��0,50,0,0q�6     � RowDefinitions  5      �� 5      $��0.15* �6    �� 5      $��0.16* �6    �� 5      $��0.15* �6    �� 5      .+�5      �� -   5        $��	nombrelbl��5      $��1��5      $��Bottom=�5      $��80��5      $��19(�5      $�� ��5      $
��Left=�5      
������ 
�������5      �� 5      $��2��6   $	��Top=�5      $��55��5       $��Mis listas de la compra:��5!      $��18(�5"      
�������
������ 5$      �� 5(      -   5         ��Name$ ListViewListas��5)      $��10,0,0,0q�5(      $��3��6.   $
��True��5*      $��Disabled=�6A   $��Visible=�5+      $��0q�6O   
������ ��5)   4   �� *listas+ �� SelectedItem 6S   �� *SelectedProduct+��5-      �� 5.      .R�5/      �� $��Center=�6%    �� CornerRadius$ 8��50      $	��900��51      $	��150��52       �� Padding$ 5q�53      ���#272B2F J� Opacity$ .9Q�55      $��10q�56      ._�57   "   �   59   &   �� 5:   *   $
��1.5* �68   �� 5;   *    � ColumnDefinitions 5=   &   �� 5>   *   $
��2.8* �6;   �� 5?   *   �� 5@   *   �� 5A   *   �� 5B   *   .+�5E   &   �� 
�������$��19(�6[   $��	20,0,20,0q�6i   $��Center=�6|   ��60   �� *nombre+6|   �� 5F   &   $��Precio total (€): ��60   
�������$��19(�6]   $��1��6k   $��Center=�6{   �� 5G   &   
�������$��19(�6[   $��2��6i   $��Center=�6y   ��60   �� *precio+6y   �� 5H   &   $��
Productos:��60   
�������$��19(�6U   $��3��6c   $��Center=�6s   �� 5I   &   
�������$��19(�6d   $��4��6r   $��Center=�6�   ��60   �� *numeroProductos+6�   �� 5K   &   $��eliminarButton��6-   -   5        $��0��5K   C   $��1��6S   $��Bottom=�6`    � Cursor$
 Hand��5L   <   $��0q�6J   
�������$��19(�6q   
 � Tag 5K   {   �� .��5M   *   �� $)��#/imagenes/papelera-de-reciclaje.png��60   $��30��6]   $��30��6i   ��5O   *   �� 5P   .   	 �� 
TargetType"	 ��64   .�5Q   .   �� 
 �� Property
 � �� �� Value �	#FFA505056K    �� Triggers 5R   2   P� 5S   6    P� Property �@J�IsMouseOver P� Value$
 True��6U   . �5T   6   �� 
 � �� �	#FF9401016S   5U   7   5X   /   ��5Z   *   �� 5[   .    �� 
TargetType" ��6>   .R�5\   2   �� $��40��69   $��40��6D   $��Center=�6P   $��Center=�6l   $ 20��5]   Y   #��z��6k   ._�5^   6   �� $��Center=�6G   $��Center=�6b   5_   3   5`   /   5b   '   �� 5c   "   $��	verButton��6)   -   5        $��0��5c   :   $��1��6J   $��Center=�6W   $
��Left=�6�   $��20,0,0,0q�6�   $
 Hand��5d   <   $��0q�6J   
�������$��19(�6q    5c   r   �� .��5e   &   �� $��/imagenes/ojo.png��6,   $��30��6G   $��30��6S   ��5g   &   �� 5h   *   "	 ��60   .�5i   .   �� 
 � ��
 ����6K    5j   .   P� 5k   2    �@J�IsMouseOver$
 True��6Q   . �5l   6   �� 
 � �� �#0F4A826S   5m   3   5p   +   ��5r   &   �� 5s   *   " ��6:   .R�5t   .   �� $��40��65   $��40��6@   $��Center=�6L   $��Center=�6h   $ 20��5u   Y   #��z��6k   ._�5v   2   �� $��Center=�6C   $��Center=�6^   5w   /   5x   +   5z   #   5}      5      5�      ��5�      �� 5�      .R�5�      � 5�      5�      5�      5�      5�      