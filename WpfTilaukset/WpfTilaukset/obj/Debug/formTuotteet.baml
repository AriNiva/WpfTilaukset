   M S B A M L   `   `   `  ����G  CWpfTilaukset, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfTilauksetWpfTilaukset  5   	       WpfTilaukset.formTuotteet   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfTilaukset     5   	     � Title$  formTuotteet��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ btnSulje��5
      $��Sulje��6#   $
��Left=�63   $��405,299,0,0q�6N   $	��Top=�6c   $��95��6{   $��24��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgTuotteet��5         AutoGenerateColumns .  $
��Left=�6C   $	��414��6^   $��10,0,0,0q�6k   $��Center=�6}   $	��390��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ TuoteID��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ TuoteID�6F     5      $
 Nimi��6C    6%   �� $
 Nimi�6C     5      $ A-Hinta��6b      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6s    6%   �� $ Ahinta�	 �� StringFormat$	 {0:##.#####}��6s     5      $
 Kuva��6Z    6%   �� $
 Kuva�$	 {0:F1}��6Z   5      �� 5   
   -   5        
 ��Name$
 	lblAHinta��5      $��A-Hinta��6#   $
��Left=�65   $��405,149,0,0q�6P   $	��Top=�6e   $��95��6}   �� 5   
   -   5        $
 lblNimi��5      $
��Nimi��6!   $
��Left=�60   $��
405,95,0,0q�6K   $	��Top=�6_   $��95��6w   �� 5   
   -   5         ��Name$ txtNimi��5      $
��Left=�6#   $��405,126,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��185��6   �� 5   
   -   5        $ 	txtAHinta��5      $
��Left=�6%   $��405,175,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��96��6�   �� 5   
   -   5        $ btnLisaa��5      $��Lisää��6#   $
��Left=�63   $��405,248,0,0q�6N   $	��Top=�6c   $��95��6{   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Poista��6$   $
��Left=�65   $��405,223,0,0q�6P   $	��Top=�6e   $��95��6}   6�   �� 5   
   -	   5        $ btnTallenna��5      $��Tallenna��6&   $
��Left=�69   $��406,273,0,0q�6T   $	��Top=�6i   $��21��6�   $��95��6�   6�   �� 5   
   -
   5        $
 lblOhje��5      $?��9Valitse Lisää painike ja lisää uusi tuote ja Tallenna��6!   $
��Left=�6a   $��
405,10,0,0q�6|   $	��Top=�6�   $	��276��6�   �� 5   
   -   5        $
 
lblTuoteID��5      $��TuoteID��6$   $
��Left=�66   $��
406,41,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ 
txtTuoteID��5      $
��Left=�6&   $��
405,72,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5   
   -   5        $ 
btnMuokkaa��5      $��Muokkaa��6%   $
��Left=�67   $��406,198,0,0q�6R   $	��Top=�6g   $��94��6   6�   5      5       