   M S B A M L   `   `   `  ����E  AWpfAppShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAppShop
WpfAppShop  5   	       WpfAppShop.GlavnoeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAppShop     5   	     � Title$  GlavnoeWindow��5   	   $	��350��6   $��693.2��6,   .��5	      � ���	#FF80D2FF.+�5   
   �� -   5         ��Name$ family_label��5      $��Фамилия��5      $��558,123,0,0q�5      $	��Top=�5      
���   �$��24��5       $
��Left=�6,   $	��100��6G   �� 5   
   -   5        $ 
name_label��5      $��Имя��5      $��558,152,0,0q�5      $	��Top=�5      
���   �$��24��5       $
��Left=�6,   $	��100��6G   �� 5   
   -   5         ��Name$ exit_button��5      $��
Выйти��5      $��558,194,0,0q�5      $	��Top=�5      $
��Left=�5   '   $��90��6B   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridbuy��5         AutoGenerateColumns .     CanUserAddRows .  $��10,80,139,46.8q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Запись��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *ID_buy+6S     5!      $ 
Товар��6%    65   �� *
ID_tovar+6T     5"      $ Количество��6%    6:   �� *Amount+6W     5#      $ Сотрудник��6%    69   �� *	ID_worker+6Y     5$      $ Цена��6%    64   �� *Price+6P     5%      $ Дата покупки��6%    6<   �� *Date+6W   4  .System.Windows.Controls.DataGridTemplateColumn  5&      	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 6)   
   CellTemplate
 5'      �� 5(      .R�5)      �� -   5        $ ��Редактировать��5)   <   
 � Tag 6%   �� *ID_buy+6p   5*      5,      5.      �� 5/   
   -   5         ��Name$ ImageProfile��5/      $
��Left=�6&   $	��100��6A   $��
558,10,0,0q�6N   $	��Top=�6b   $	��100��6z   �� 50   
   -   5        $ 	ImageLogo��50      $
��Left=�6#   $��50��6>   $��	10,10,0,0q�6J   $	��Top=�6]   $��50��6u   �� 51   
   -   5        $ deleteButton��51      $��Удалить��6'   {�.  $
��Left=�6g   $��333,287,0,0q�6�   $	��Top=�6�   $��75��6�   �� 52   
   -	   5        $ 	addButton��52   $   $��Добавить��6   $
��Left=�6O   $��199,287,0,0q�6j   $	��Top=�6   $��75��6�   �� 53   
   -
   5        $ diagramma_button��53      $��Диаграмма��6J   $
��Left=�6^   $��
10,287,0,0q�6y   $	��Top=�6�   $��75��6�   �� 54   
   -   5         ��Name$ 	SearchBox��54      $
��Left=�6%   $��23��6@   $��
229,25,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   6�   �� 55   
   -   5         ��Name$ filterCategory��55      $
��Left=�6,   $��	80,26,0,0q�6G   $	��Top=�6Z   $	��120��6r   6~   �� 56   
   -   5         ��Name$ sortBox��56      $0��*Сортировка по убыванию��6$   $
��Left=�6E   $��
370,30,0,0q�6`   $	��Top=�6t   6�   57      58      