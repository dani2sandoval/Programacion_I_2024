   M S B A M L   `   `   `  ����C  ?Ventanas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:VentanasVentanas  5   	       Ventanas.Cliente1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Ventanas     5   	     � Title$  Cliente1��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   �� .+�5      ]� .+�5      �� -   5        $	��100��5      ���#008000
�������$��10q�6b   .��6n   Usuario nuevo6}   5      ]� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
myDataGrid��5         AutoGenerateColumns$ False��6p      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   
�������$��1q�5   "      HeadersVisibility$ Column=�66      GridLinesVisibility$ 
Horizontal=�6Q      AlternatingRowBackground
 ����� �� AlternationCount$ 2��5   4   ��5   +   ��  �� Path$ GetAllClientes�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6)      Width$	 100 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5      $
 Nombre��6)   $	 150 6T    69   �� *Nombre+6T     5      $
 
Dirección��6)   $	 140 6Z    6<   �� *	Direccion+6Z     5      $
 Telefono��6)   $	 100 6X    6;   �� *
Telefono+6X     5      $
 Email��6-   $	 100 6V    6<   �� *Email+6V   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Acciones��61      CellTemplate 5      �� 5      .R�5   "   ��  �� Orientation$ 
Horizontal=�6-   $��Center=�6F   .+�5   &   ��  ��Name$ 	updateBtn��6-   -   5        $��Update��5   X   $��2q�6i   $��5q�6t   
����ح�
���   �6�   �� 5   &   $ 	deleteBtn��6-   -   5        $��Delete��5   X   $��2q�6i   $��5q�6t   
�������
���   �6�   5   #   5       5"       � 	Resources 5$      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell��%<  '        '  �     �� 5&      "  6   .�5'      ��  � ��
 �����67   �� 5(       � ��
 �����67   �� 5)       � ��$
 Bold"�67   �� 5*       � ��$ Center=�6G   �� 5+       � ��$ 5q�64   5,      �� 5.      "  6   .�5/      ��  � ��$ 5q�64   50      51      52      53      54      55      56      