   M S B A M L   `   `   `  ����M  IRostelekek-WPF-API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Rostelekek_WPF_API.PagesRostelekek_WPF_API.Pages  5      (    "Rostelekek_WPF_API.Pages.EquipPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Rostelekek_WPF_API.Pages     5      -   5          N� Title$H  BУправление сотрудниками Ростелекек��5	      $	��400��5
   	   $	��600��5   	    N� 
Background
 ���� .��5      �  � ColumnDefinitions 5   
   �� 5      $��74 �6#   60   �� 5      6%   .+�5   
   �� $��1��6   .+�5      �� -   5        $��label��5      $��0,10,0,0q�6!   $��18(�63   $
��Bold"�6A   $��Center=�6S   $��3��6p   $��0��6�   .��6�   Оборудование6�   �� 5      -   5        $��BCreate��5      $��10q�5      
������ 
������ ���#033f63$
��auto��5      $
��Left=�5      .��5   ,   64Добавить новое оборудование6I   �� 5      -   5        $��	equipList��5      $	��200��5       
�������$��	10,5,10,5q�5"      ��5#      �� ��5%      �� 5&       �� 
TargetType" ��6   .�5'      ��  �� Property � �� �� Value$ Stretch=�6G   �� 5(       � ��$ Stretch=�6E   �� 5)       � ��$ 0,0,1,1q�6<   6N   �� 5*       � �� �#28666e6J   5+       �� View 5-      �� 5.       �� AllowsColumnReorder .  P�5/      �� 50      $��
Номер��6-      
idTemplate �� CellTemplate# [  6<   6i   �� 51      $��Название��6-     nameTemplate# [ 6?   6n   �� 52      $��Цена��6-     priceTemplate# [ 6;   6k   �� 53      $��Заметки��6-     notesTemplate# [ 6>   6n   55      58      �� 59      -   5        $��BEdit��5@   %   $
��Left=�59      $��5,5,5,0q�5:      $��	10,0,10,0q�5;      
������ 
������ ���#28666e$
��auto��5?      $ ��Редактировать��5B   %   6?   �� 5C      -   5        $��BDelete��5J   )   $
��Left=�5C      $��5,0,5,0q�5D      $��	10,5,10,0q�5E      
������ ���#28666e$
��auto��5H      
������ $��Удалить��5L   )   6=   �� 5M      $��/Assets/rostelekek.png��6   $��64��64   $��Right=�6?   $��7,0,0,0q�5N   (   5O      5P      5Q      