   M S B A M L   `   `   `  ����G  CWpfTilaukset, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfTilauksetWpfTilaukset  5   	       WpfTilaukset.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfTilaukset     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Center=�6   $	��130��61   
���   �$	��Top=�6M   $	��780��6e   $��0,10,0,0q�6q   �� 5   
   -   5         ��Name$ 
lblAsiakas��5      $��Asiakas��6$   $
��Left=�66   $��
187,10,0,0q�6Q   $	��Top=�6e   $	��140��6}   �� 5   
   -   5         ��Name$ 	cbAsiakas��5      $
��Left=�6&   $��
143,37,0,0q�6A   $	��Top=�6U   $	��162��6m   $��33��6y   6�   �� 5   
   -   5        $ lblToimitusosoite��5      $��Toimitusosoite��6+   $
��Left=�6D   $��
372,11,0,0q�6_   $	��Top=�6s   $	��132��6�   �� 5   
   -   5         ��Name$ txtToimitusOsoite��5      $
��Left=�6-   $��
372,37,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��173��6�   $��33��6�   �� 5   
   -   5        $ lblPostinumero��5      $��Postinumero��6(   $
��Left=�6>   $��
550,11,0,0q�6Y   $	��Top=�6m   $��82��6�   �� 5   
   -   5        $ txtPostinumero��5      $
��Left=�6*   $��
550,37,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $��82��6�   $��33��6�   �� 5   
   -   5        $ lblTilauspvm��5      $��	TilausPvm��6&   $
��Left=�6:   $��	20,74,0,0q�6U   $	��Top=�6h   $	��118��6�   �� 5   
   -   5        $ lblToimitusPvm��5      $��ToimitusPvm��6(   $
��Left=�6>   $��
173,75,0,0q�6Y   $	��Top=�6m   $��88��6�   �� 5   
   -	   5         ��Name$ btnLuoTilaus��5      $��
Luo Tilaus��6'   $
��Left=�6<   $��550,105,0,0q�6W   $	��Top=�6l   $��24��6�   $��82��6�   6�   �� 5   
   -
   5        $ lblTilausnro��5      $��Tilausnumero��6&   $
��Left=�6=   $��	20,10,0,0q�6X   $	��Top=�6k   $	��151��6�   �� 5   
   -   5        $ txtTilausNumero��5      $
��Left=�6+   $��	20,36,0,0q�6F   $
 Wrap=�6Y   $	��Top=�6m   $	��118��6�   $��33��6�   �� 5   
   -   5        $ txtAsiakasNumero��5      $
��Left=�6,   $��
310,37,0,0q�6G   $
 Wrap=�6[   $	��Top=�6o   $��57��6�   $��33��6�    J� RenderTransformOrigin$ 0.719,0.553&�6�   �� 5   
   -   5        $ txtToimitusAika��5      $
��Left=�6+   $��349,105,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $��75��6�   $��24��6�   �� 5   
   -   5        $ lblToimitusAika��5      $��Toimitusaika��6)   $
��Left=�6@   $��
349,74,0,0q�6[   $	��Top=�6o   $��75��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpTilausPvm��5      $
��Left=�6*   $��
20,105,0,0q�6E   $	��Top=�6Y      FirstDayOfWeek$ Monday=�6q     5   
   -   5        $ dpToimitusPvm��5      $
��Left=�6,   $��181,105,0,0q�6G   $	��Top=�6\   $ Monday=�6t   �� 5   
   $��Center=�6   $	��214��61   $��	0,145,0,0q�6>   
���   �$	��Top=�6`   $	��780��6x   �� 5   
   -   5        $ cbTuote��5      $
��Left=�6$   $��
20,174,0,0q�6?   $	��Top=�6S   $	��189��6k   $��31��6w   $ 0.531,-1.095&�6�   6�   �� 5   
   -   5        $ lblTuote��5      $��Valitse tuote listalta��6"   $
��Left=�6C   $��
20,145,0,0q�6^   $	��Top=�6r   $	��132��6�   $��24��6�   �� 5   
   -   5        $ txtTuoteNumero��5      $
��Left=�6*   $��214,177,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $��78��6�   $��31��6�   �� 5   
   -   5        $ lblTuotenumero��5      $��Tuotenumero��6(   $
��Left=�6>   $��202,151,0,0q�6Y   $	��Top=�6n   $��90��6�   �� 5    
   -   5        $ btnLisaaRivi��5       $��Lisää rivi��6'   $
��Left=�6<   $��642,177,0,0q�6W   $	��Top=�6l   $��86��6�   $��31��6�   6�   �� 5!   
   -   5        $ 	txtAHinta��5!      $
��Left=�6%   $��364,177,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��60��6�   $��31��6�   �� 5"   
   -   5        $ txtMaara��5"      $
��Left=�6$   $��298,177,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $��61��6�   $��31��6�   �� 5#   
   -   5        $ lblMaara��5#      $��Määrä��6"   $
��Left=�62   $��298,151,0,0q�6M   $	��Top=�6b   $��58��6z   �� 5$   
   -   5        $ 	lblAhinta��5$      $��A-Hinta��6#   $
��Left=�65   $��364,151,0,0q�6P   $	��Top=�6e   $��60��6}   $ 0.917,0.502&�6�   &   System.Windows.Controls.DataGrid  5%   
   -   5        	  Name$	 dgTilausRivit��5%      $��10,217,10,75q�6U   �� 5&   
   -   5        $ txtRivienSumma��5&      $
��Left=�6*   $��438,105,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $��95��6�   $��24��6�   �� 5'   
   -   5        $ lblRivienSumma��5'      $��Tilauksen arvo��6(   $
��Left=�6A   $��
438,82,0,0q�6\   $	��Top=�6p   $��95��6�   �� 5(   
   -   5        $ btnPostitoimipaikat��5(      $��Postitoimipaikat��6.   $
��Left=�6I   $��
10,364,0,0q�6d   $	��Top=�6x   $	��104��6�   $��43��6�   6�   �� 5)   
   -   5        $ btnSulje��5)      $��Sulje��6#   $
��Left=�63   $��686,364,0,0q�6N   $	��Top=�6c   $	��104��6{   $��43��6�   6�   �� 5*   
   -   5        $ btnTuotteet��5*      $��Tuotteet��6&   $
��Left=�69   $��120,364,0,0q�6T   $	��Top=�6i   $	��104��6�   $��43��6�   6�   5+      5,      