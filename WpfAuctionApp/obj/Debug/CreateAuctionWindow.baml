   M S B A M L   `   `   `  ����H  DWpfAuctionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfAuctionAppWpfAuctionApp  5   	   '    !WpfAuctionApp.CreateAuctionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfAuctionApp     5   	     � Title$  CreateAuctionWindow��5   	   $��364.991��6%   $��286.049��66   .��5	      � $��0,0,2,0q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ TypeComboBox��5       �� SelectedValuePath$ Content��6)   $
��Left=�6E   $��
120,94,0,0q�6`   $	��Top=�6t   $	��130��6�   $
��Bold"�6�   $��22��6�   .@�5      �� $��	Palladium��6   61   �� 5      $
��Gold��6   6,   �� 5      $��Silver��6   6.   �� 5      $��Platinum��6   60   5      �� 5   
   $��Amount��6   $
��Left=�6!   $��30��6<   $��
15,138,0,0q�6H   $	��Top=�6\   $��96��6t   $
��Bold"�6   $��16(�6�   �� 5   
   -   5         ��Name$ amountTxtBox��5      $
��Left=�6(   $��23��6C   $��120,142,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $��Type amount in kg��6x   $	��Top=�6�   $	��130��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ TimeLimitDatepicker��5      $
��Left=�62   $	��Top=�6M   $��120,195,0,0q�6e   $
��Bold"�6z   $��14(�6�   $��29��6�   $	��130��6�   �� 5   
   $��
Time limit��6   $
��Left=�6%   $��
15,195,0,0q�6@   $	��Top=�6T   $
��Bold"�6l   $��16(�6~   $��31��6�   $��86��6�   �� 5   
   -   5        $��Create Auction��5      $
��Left=�6*   $��129,274,0,0q�6E   $	��Top=�6Z   $	��121��6r   $��35��6~   ���	#FF29AA0C6�   �� 5   
   -   5        $��Cancel��5      $
��Left=�6"   $��
10,274,0,0q�6=   $	��Top=�6Q   $	��100��6i   $��35��6u   ���	#FFF903036�   �� 5   
   $��
Metal Type��6   $
��Left=�6%   $	��Top=�6@   $��	15,88,0,0q�6X   $��42��6k   $��96��6w   $
��Bold"�6�   $��16(�6�   �� 5   
   $
��Left=�6   $��	51,36,0,0q�6/   $
��Wrap=�6B   $��Create a new auction��6V   $	��Top=�6r   $
��Bold"�6�   $��16(�6�   $��21��6�   $	��158��6�   ��6�   Z� 6�   5      5      