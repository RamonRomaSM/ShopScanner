   M S B A M L   `   `   `  ����N  JTrabajoFinalDeGrado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:TrabajoFinalDeGrado.autenthTrabajoFinalDeGrado.autenth  5      +    %TrabajoFinalDeGrado.autenth.loginForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:TrabajoFinalDeGrado.autenth     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $	��.4* �6   �� 5      �� 5      $	��.4* �6   .+�5   
   �� $��1��6   .+�5      �� -   5        $��nombre��5   $   $��30��5      $	��200��6"   $��Center=�6.   $	��Top=�5      $��0,0,0,40q�6.   $��Center=�5      $��Center=�5      
�������$��0,0,0,2q�5      $��18(�5      .��62   ��5      �� 5       �� ImageSource$ /imagenes/userIcon.png��6!    j� Stretch$
 None=�5   !    j� 
AlignmentX$
 Left=�5   !   .��5   &   ��5      �� 5       �� 
TargetType" ��6   .�5       ��  �� Property � �� �� Value
 ���� 67   5"      .��5#   !   5&      G� 5'      -   5        $
��pasw��5-   .   $��30��5'      $	��200��6'   $��Center=�63   $��Center=�5(      $��Center=�5)      $��Center=�5*      $��0,0,0,2q�5+      $��18(�5,      
���������5.      �� 5/      $ /imagenes/passwIcon.png��6!   $
 None=�50      $
 Left=�51      ��54      �� 55      " G�6   .�56      ��  � ��
 ���� 67    �� Triggers 57      5:      5=      �� 5@      -   5        $��
aceptarBtn��5@   '   $��0,70,0,0q�6   $��18(�5A       � Cursor$
 Hand��6#   $��0q�61   
���������5B      �� 5C      " ��6   .�5D      ��  � ��
 ����67    5E      P� 5F      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��6=   . �5G   "   ��  � �� �#0F4A826?   5H      5K      ��5M      �� 5N       �� 
TargetType" ��6&   .R�5O      �� $	��150��6!   $��40��6-    �� CornerRadius$ 20��5P   !   #��z��63   ._�5Q      �� $��Center=�6/   $��Center=�6J   $��Aceptar��6g   5R      5S      5U      �� 5V      -   5        $��feedbacklbl��5[      $��2��5W      $��Center=�5X      $	��Top=�5Y      $��20q�5Z      $��18(�5\      $
��Wrap=�5]      5_      5`      5a      