   M S B A M L   `   `   `  ����G  CWpfTilaukset, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfTilauksetWpfTilaukset  5   	   '    !WpfTilaukset.formPostitoimiPaikat   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfTilaukset     5   	     � Title$  formPostitoimiPaikat��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgPostitoimiPaikat��5   /      AutoGenerateColumns .  $
��Left=�6K   $	��414��6f   $��10,0,0,0q�6s   $��Center=�6�   $	��390��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Postinumero��6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Postinumero�6J     5      $ Postitoimipaikka��6O      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6i    6%   �� $ Postitoimipaikka�6i   5      �� 5   
   -   5         ��Name$ lblPostinro��5      $��Postinro��6%   $
��Left=�68   $��
416,12,0,0q�6S   $	��Top=�6g   $	��155��6   �� 5   
   -   5        	 ��Name$	 txtPostiNumero��5      $
��Left=�6*   $��
416,43,0,0q�6E   
 �� TextWrapping$

 Wrap=�6Y   $	��Top=�6m   $	��155��6�   $��23��6�   �� 5   
   -   5        $ lblPostitoimipaikka��5      $��Postitoimipaikka��6-   $
��Left=�6H   $��
416,71,0,0q�6c   $	��Top=�6w   $	��155��6�   �� 5   
   -   5        $	 txtPostitoimipaikka��5      $
��Left=�6/   $��416,102,0,0q�6J   $

 Wrap=�6_   $	��Top=�6s   $	��155��6�   $��22��6�   �� 5   
   -   5         ��Name$ btnLisaa��5      $��Lisää��6#   $
��Left=�63   $��416,129,0,0q�6N   $	��Top=�6c   $��78��6{   6�   �� 5   
   -   5        $	 txtPoistaPostitoimipaikka��5      $
��Left=�65   $��416,288,0,0q�6P   $

 Wrap=�6e   $	��Top=�6y   $	��155��6�   �� 5   
   -   5        $ 	btnDelete��5      $��Poista��6$   $
��Left=�65   $��416,311,0,0q�6P   $	��Top=�6e   $��78��6}   6�   �� 5   
   -	   5        $ btnTallenna��5      $��Tallenna��6&   $
��Left=�69   $��416,390,0,0q�6T   $	��Top=�6i   $��78��6�   $��34��6�   6�   �� 5   
   -
   5        $ btnSulje��5      $��Sulje��6#   $
��Left=�63   $��499,390,0,0q�6N   $	��Top=�6c   $��78��6{   $��34��6�   6�   �� 5   
   -   5        $	 txtPoistaPostinumero��5      $
��Left=�60   $��416,230,0,0q�6K   $

 Wrap=�6`   $	��Top=�6t   $	��155��6�   �� 5   
   -   5        $ lblPoistaPostinumero��5      $��Postinumero��6.   $
��Left=�6D   $��416,199,0,0q�6_   $	��Top=�6t   $	��155��6�    � Cursor$  ��6�   �� 5   
   -   5        $ lblPoistaPostitoimipaikka��5      $��Postitoimipaikka��63   $
��Left=�6N   $��416,257,0,0q�6i   $	��Top=�6~   $	��155��6�   5      5      