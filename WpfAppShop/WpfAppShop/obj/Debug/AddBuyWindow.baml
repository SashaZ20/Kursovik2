   M S B A M L   `   `   `  ����E  AWpfAppShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAppShop
WpfAppShop  5   	       WpfAppShop.AddBuyWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAppShop     5   	     � Title$  AddBuyWindow��5   	   $	��330��6   $	��310��6+   .��5	      � ���	#FF80D2FF.+�5
   
   �� -   5         ��Name$ workerLabel��5
      $��Сотрудник��6%   $
��Left=�69   $��
34,137,0,0q�6T   $	��Top=�6h   �� 5   
   -   5         ��Name$ workerComboBox��5       �� DisplayMemberPath$
 info��6N   $
��Left=�6g   $��126,138,0,0q�6�   $	��Top=�6�   $	��130��6�    �� SelectedItem 6+   �� *	ID_worker+6�   �� 5   
   -   5        $ add_zag_label��5      $)��#Добавление покупки��6'   $
��Left=�6D   $��	62,20,0,0q�6_   $	��Top=�6r   $��18(�6�   �� 5   
   -   5        $ 	dateLabel��5      $��Дата��6#   $
��Left=�62   $��
34,171,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ 
priceLabel��5      $��Цена��6$   $
��Left=�63   $��
34,209,0,0q�6N   $	��Top=�6b    J� RenderTransformOrigin$ 0.053,0.154&�6z   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ addDatePicker��5      $
��Left=�6,   $��126,172,0,0q�6G   $	��Top=�6\   $	��130��6t   �� 5   
   -   5         ��Name$ addPricetextBox��5      $
��Left=�6+   $��23��6F   $��126,210,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��130��6�   �� 5   
   -   5        	 ��Name$	 	addButton��5      $��Добавить��6$   $
��Left=�67   $��106,255,0,0q�6R   $	��Top=�6g   $��75��6   $��20��6�   �� 5   
   -	   5        $ tovarComboBox��5      $
 info��6L   $
��Left=�6e   $��
126,64,0,0q�6�   $	��Top=�6�   $	��130��6�    6*   �� *
ID_tovar+6�   �� 5   
   -
   5        $ addAmounttextBox��5      $
��Left=�6,   $��23��6G   $��126,100,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��130��6�   �� 5   
   $��
Товар��6   $
��Left=�6    $��	34,63,0,0q�6;   $	��Top=�6N   �� 5   
   $��Количество��6   $
��Left=�6%   $��
34,100,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        
 ��Name$
 	ImageLogo��5      $
��Left=�6#   $��50��6>   $��	10,10,0,0q�6J   $	��Top=�6]   $��50��6u   5      5      