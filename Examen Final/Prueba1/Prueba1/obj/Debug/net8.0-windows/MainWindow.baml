   M S B A M L   `   `   `  ����  Prueba1    WpfApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   �� .+�5      ]� .+�5      �� -   5        $	��100��5      ���#008000
�������$��10q�6b   .��6n   Agregar nuevo6}   5	      ]� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
myDataGrid��5         AutoGenerateColumns$ False��6H      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6d   
�������$��1q�5   "      HeadersVisibility$ Column=�66      GridLinesVisibility$ 
Horizontal=�6Q      AlternatingRowBackground
 ����� �� AlternationCount$ 2��5   4      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6-   
   Width$	
 100 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
PedidoId+6V     5      $	 Cliente��6-   $	
 200 6`    6>   �� *ClienteNombre+6`     5      $	 Id Productos��6-   $	
 100 6b    6C   �� *
Idproducto+6b     5      $	 Producto��6-   $	
 200 6b    6?   �� *NombreProducto+6b     5      $	 Cantidad��6-   $	
 100 6\    6?   �� *
cantidad+6\     5      $	 Precio��6-   $	
 100 6X    6=   �� *Precio+6X   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Acciones��61      CellTemplate 5      �� 5   "   .R�5   &   ��  �� Orientation$ 
Horizontal=�61   $��Center=�6J   .+�5   *   ��  ��Name$ 	updateBtn��61   -   5        $��Update��5   \   $��2q�6m   $��5q�6x   
����ح�
���   �6�   �� 5   *   $ 	deleteBtn��61   -   5        $��Delete��5   \   $��2q�6m   $��5q�6x   
�������
���   �6�   5   '   5   #   5       � 	Resources 5!      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell��%<  '        '  �     �� 5#      "  6    .�5$      ��  � ��
 �����6;   �� 5%       � ��
 �����6;   �� 5&       � ��$
 Bold"�6;   �� 5'       � ��$ Center=�6K   �� 5(       � ��$ 5q�68   5)      �� 5+      "  6    .�5,      ��  � ��$ 5q�68   5-      5.      5/      50      51      52      53      