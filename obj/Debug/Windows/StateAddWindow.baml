   M S B A M L   `   `   `  ����M  IRostelekek-WPF-API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Rostelekek_WPF_API.WindowsRostelekek_WPF_API.Windows  5   	   /    )Rostelekek_WPF_API.Windows.StateAddWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Rostelekek_WPF_API.Windows     5   	   -   5          � Title$+  %Изменение состояния��5      $	��400��6#   $	��600��60    � 
ResizeMode$ NoResize=�5	   
    � WindowStartupLocation$ CenterScreen=�5
   	   $��Segoe UI Historic)�5   	   $��16(�5   	   
������� � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5       $
��auto �6   �� 5!      .+�5#   
   �� $��Номер заказа: ��6   $��0��6*   �� 5$   
   $%��Дата завершения: ��6   $��1��6-   �� 5%   
   $��Состояние: ��6   $��2��6'   �� 5'   
   -   5        $��TBOrder��5'      $��1��6=   	 �� 
IsReadOnly	 . ��6!   �� *
id_order+6M   �� 5(   
   -   5        $��TBDate��5(      $��1��6:   $��1��6J   ��6    �� *
end_date+6J   �� 5)   
   -   5        $��TBState��5)      $��1��68   $��2��6H   ��6!   �� *state+6H   �� 5+   
   $��Center=�6   
 �� Orientation$
 
Horizontal=�62   $��6��6K   $��2��6X   .+�5,      �� -   5        $��BCreate��5-      $��25��5.      $	��100��5/      $��10q�50       �� 	IsDefault . .��51   =   Ок6A   �� 52      -   5        $��25��53      $	��100��54      $��10q�55       �� IsCancel . .��56   6   Отмена6>   57      58      59      