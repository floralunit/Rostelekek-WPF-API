   M S B A M L   `   `   `  ����M  IRostelekek-WPF-API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Rostelekek_WPF_API.WindowsRostelekek_WPF_API.Windows  5   	   /    )Rostelekek_WPF_API.Windows.EquipAddWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Rostelekek_WPF_API.Windows     5   	     � Title$R  LДобавление/  Редактирование оборудования��5      $	��300��68   $	��600��6E    � 
ResizeMode$ NoResize=�5	   
    � WindowStartupLocation$ CenterScreen=�5
   	   $��Segoe UI Historic)�5   	   $��16(�5   	   ���#fff2b2 � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5!   
   �� $��Название��6   �� 5"   
   $��Цена��6   $��1��6    �� 5#   
   $��Заметки��6   $��2��6#   �� 5%   
   -   5        $��TBName��5%      $��1��66   ��6    �� *Name+66   �� 5&   
   -   5        $��TBPrice��5&      $��1��68   $��1��6H   ��6!   �� *Price+6H   �� 5'   
   -   5        $��TBNotes��5'      $��1��68   $��2��6H   ��6!   �� *Notes+6H   �� 5)   
   $��Center=�6   	 �� Orientation$	 
Horizontal=�62   $��7��6K   $��2��6X   .+�5*      �� -   5        $��BCreate��5+      $y�	Collapsed=�5,      $��25��5-      $	��100��5.      $��10q�5/      
 �� 	IsDefault
 . .��50   =   Создать6F   �� 51      -   5        $��BEdit��52      $y�	Collapsed=�53      $��25��54      $	��100��55      $��10q�56      
 . .��57   ;   OK6?   �� 58      -   5        $��25��59      $	��100��5:      $��10q�5;       �� IsCancel . .��5<   6   Отмена6>   5=      5>      5?      