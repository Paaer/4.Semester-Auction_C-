   M S B A M L   `   `   `  ����H  DWpfAuctionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfAuctionAppWpfAuctionApp  5   	       WpfAuctionApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfAuctionApp     5   	   -   5          � Title$  
MainWindow��5   	   $��376.959��6   $��475.093��6-    � 	Resources 5	      +   %WpfAuctionApp.CodeFirstAuctionDataSet   codeFirstAuctionDataSet  buyersViewSource �� Source �� Source��%V   &	        &	      7     5
   
   6(   �� 5   
    68   �� *Buyer+8   5      .��5      �  � DataContext# [ 6   $��0,0,2,0q�6;   $	��418��6L   $	��Top=�6Y   .+�5   
   �� -   5        $��Create new Auction��5      $
��Left=�6.   $��
10,258,0,0q�6I   $	��Top=�6]   $	��169��6u   $��63��6�   $
��Bold"�6�   $��16(�6�    J� RenderTransformOrigin$ 0.652,-0.183&�6�   � 5   
   $
��Left=�6   $	��197��6*   $��	10,10,0,0q�67   $	��Top=�6J   $	��323��6b   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ SellerDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . 	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   
   
IsReadOnly
 . $
��Left=�6�   $	��237��6�   $	��Top=�6�   $	��432��6  $��0,0,-109,-40q�6  ��6k   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        iDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5   X      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6d      CanUserReorder .     CanUserSort .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
SellerId+6�     5      -   5        metalTypeColumn��$ 
Metal Type��5   `   $
 Auto 6t    .   .   6B   �� *	MetalType+6�     5      -   5        priceColumn��$ Amount��5   Y   $
 Auto 6i    .   .   6>   �� *Amount+6�     5      -   5        HighestBidder��$ Highest bid��5   b      
IsReadOnly . $
 Auto 6�    .   .   6@   �� *HighestBidder+6�     5      -   5        TimeLimitColumn��$ 
Time Limit��5   `    . $	 100 6�    .   .   6B   �� *	TimeLimit+6�     5      -	   5        TImeLeftColumn��$ 	Time Left��5   ^   $	 120 6q    .   .  6A   �� *
TimeLeft+6�   5      5      5      5      