   M S B A M L   `   `   `  ����N  JTrabajoFinalDeGrado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TrabajoFinalDeGrado.ToastsTrabajoFinalDeGrado.Toasts  5   	   &     TrabajoFinalDeGrado.Toasts.Toast   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:TrabajoFinalDeGrado.Toasts     5   	   -   5        $��w1��5        � Title$  Toast��5   	   $��90��6   $	��270��6#    � WindowStyle$
 None=�6/   
������  � 
ResizeMode$ NoResize=�6[    � AllowsTransparency$
 True��6q    � Triggers 5
      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5      .��5      ��  g� 	BeginTime 06!    g� Duration$ 4D�6/   .��5      W� -   5         g�Name$ 	animacion��5   �   	 �� 
TargetName$	 w1��6*   
 �� TargetProperty$
 (Window.Left)�6E    W� From 06o   	 W� To 06x    g� AutoReverse$
 true��6   	 0:0:06�   $ 0:0:2D�6�    g� RepeatBehavior$ Forever��6�   6�   5      5      5      .��5      � 
������ .+�5   
   �� 
������ �� CornerRadius$ 4,0,0,4��6*   $��0,0,30,0q�6A   �� 5   
   ���#212529$ 0,4,4,0��6'   $��10,0,0,0q�6>   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��0��6   $
��Left=�6%   $��5,0,0,0q�6@   $��/imagenes/logoCarrito.png��6Q   $
��Fill=�6t   $��40��6�   $	��100��6�   �� 5      -   5        $	��msg��5      $��Texto de ejemplo��6'   $��Center=�6?   $��0,0,0,0q�6Z   
�������$��19(�6~   5      5      5       5!      