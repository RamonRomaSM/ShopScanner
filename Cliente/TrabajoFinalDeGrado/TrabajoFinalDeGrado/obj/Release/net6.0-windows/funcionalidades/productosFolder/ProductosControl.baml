   M S B A M L   `   `   `  ���� N  JTrabajoFinalDeGrado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:TrabajoFinalDeGrado.funcionalidades.productosFolder3TrabajoFinalDeGrado.funcionalidades.productosFolder  J    DTrabajoFinalDeGrado.funcionalidades.productosFolder.ProductosControl   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     SlocalAclr-namespace:TrabajoFinalDeGrado.funcionalidades.productosFolder     .��� .+��� -   $��
MyScroller��
������ $��Center=�$��40,0,0,0q�.���� -     ��Name$  ListViewProducts��$��False��$��Disabled=�$��Disabled=�$��0q�
������ ���� *
Products+���� .R��� $��Center=� �� CornerRadius$ 8��$��0q�$	��290��$	��500�� �� Padding$ 5q����#272B2F$��10q� J� Opacity$	 0.9Q�._���  �� Orientation$ Vertical=�.+��� $	��230��$	��280��$��0,10,0,0q����� *imagen+� $��0,20,0,0q�$	��210�� � RowDefinitions �� �� �� .+��� $��Right=�
�������$��18(�$
��Wrap=�$	��280��$��80�� �� Padding$ 	20,0,20,0q����� *nombre+�� -   
������  � Cursor$
 Hand��$��60������ *url+� $��1��$��0,15,0,0q� �� ��  � ColumnDefinitions �� �� .+��� $��Precio: ��$
��Left=�$��0��$��0��
�������$ 20,0,0,0q�$��18(��� $��Supermercado: ��$
��Left=�$��1��$��0��
�������$ 20,0,0,0q�$��18(��� $��Center=�$��0��$��1��
�������$ 0,0,20,0q�$��18(����� *precio+�� $��Center=�$��1��$��1��
�������$ 0,0,20,0q�$��18(����� *supermercado+� $��2�� �� �� .+��� $��addCarritobtn��-   $��0��$��Bottom=�$��18(�$
 Hand��$��0q�
�������
	 � Tag	 �� ���� 
 �� 
TargetType"
 ��.���  �� Property � �� �� Value
 ���� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  � �� �#0F4A82����  �� 
TargetType" ��.R��� $	��130��$��40��$ 5��#��z��._��� $��Center=�$��Center=�$��Añadir al carrito���� $��addListaBtn��-   $��1��$��Bottom=�$��18(�$
 Hand��$��0q�
����������� "
 ��.���  � ��
 ���� P�  �@J�IsMouseOver$
 True��. ���  � �� �#0F4A82���� " ��.R��� $	��130��$��40��$ 5��#��z��._��� $��Center=�$��Center=�$��Añadir a la lista������ .R�� 