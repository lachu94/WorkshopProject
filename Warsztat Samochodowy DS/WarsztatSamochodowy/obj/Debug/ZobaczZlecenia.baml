   M S B A M L   `   `   `  ����N  JWarsztatSamochodowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WarsztatSamochodowyWarsztatSamochodowy  5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   	   (    "WarsztatSamochodowy.ZobaczZlecenia   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WarsztatSamochodowy     5   	   Rforms@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	     � Title$  Lista Zleceń��5	       � WindowState$ 	Maximized=�6    � WindowStyle$
 None=�66   $	��809��6I   #��� ��6V   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgOrders��5      $��86,10,88,187q�6&   $
��Auto��6=      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *
id_Klienta+  5      $
 Imie��6%    .  6E   �� *Imie+  5      $ Nazwisko��6%    .  6I   �� *	Telefon+  5      $ Telefon��6%    .  6H   �� *
Nazwisko+  5      $ Model��6%    .  6F   �� *Model+  5      $ Marka��6%    .  6F   �� *Marka+4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        cbStatus��$ Status��5      	   SelectedValueBinding	 5      �� *Status+
 �� Mode$
 TwoWay=�   DisplayMemberPath 5      �� *Status+   EditingElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      -   5        5      5"        5$       .  -   5        	cbWorkers��$ 	Pracownik��5(      	 5)      �� *NazwiskoPracownika+$
 TwoWay=� 5*      �� *NazwiskoPracownika+ 5+      �� 5,      " ��6    .�5-      -   5        5/      53        55      $ Kontakt��6%    .  6H   �� *
nrTelefonu+  56      $ Usterka��6%    .  6H   �� *Opis_Usterek+  57      $ Podsumowanie��6%    .  6M   �� *Podsumowanie+  58      $
 Cena��6%    .  6E   �� *Cena+5<      �� 5=   
   -   5         ��Name$ btnBack��5=      $��Center=�69   $��Bottom=�6W   $��230                 ��6r   $��61                 ��5>       J� RenderTransformOrigin$ 0.5,0.5&�5?      $��
530,0,0,29q�63   ��5@      �� 5A       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5B      �  � Color$ 	#FFF3F3F3��6#    � Offset$ 0Q�65   � 5C      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5D      $ 	#FFDDDDDD��6#   $ 0.683Q�65   � 5E      $ 	#FF060002��6#   $ 1Q�65   5F      .��5H      ��  �� Orientation$ 
Horizontal=�6   .+�5I      �� $��Obrazy/logout.png��6   $��50��63   $��Right=�6>   $ 0.5,0.5&�6Z   $��60��6z   �� 5J      $��    Wyjście��6   $	��175��6.   $��Right=�6:   $��24(�6V   $��Tahoma)�6d   $��Center=�6x   $
��Bold"�6�   5K      5L      �� 5M   
   -   5        $ 
btnParagon��5M      $��Center=�6&   $��Bottom=�6D   $	��230��6_   $��61                 ��6k   $ 
-0.16,0.45&�5N   ,   $��267,0,263,29q�6O   ��5O      �� 5P      $	 0,1&�6&   $	 0,0&�65   .��5Q      � $ 	#FFF3F3F3��6#   $ 0Q�65   � 5R      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5S      $ 	#FFDDDDDD��6#   $ 0.683Q�65   � 5T      $ 	#FF060002��6#   $ 1Q�65   5U      .��5W      �� $ 
Horizontal=�6   .+�5X      �� $��Obrazy/paragon.png��6   $��50��64   $��Right=�6?   $ 0.5,0.5&�6[   $��60��6{   �� 5Y      $��
   Paragon��6   $	��175��6-   $��Right=�69   $��24(�6U   $��Tahoma)�6c   $��Center=�6w   $
��Bold"�6�   5Z      5[      �� 5\   
   -   5        $ btnOk��5\      $��61��6    $��Center=�6,   $��Bottom=�6I   $��230                 ��6d   $��
0,0,530,29q�5]   '   ��5^      �� 5_      $	 0,1&�6&   $	 0,0&�65   .��5`      � $ 	#FFF3F3F3��6#   $ 0Q�65   � 5a      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5b      $ 	#FFDDDDDD��6#   $ 0.683Q�65   � 5c      $ 	#FF060002��6#   $ 1Q�65   5d      .��5f      �� $ 
Horizontal=�6   .+�5g      �� $��Obrazy/ok.png��6   $��50��6/   $��Right=�6:   $ 0.5,0.5&�6V   $��60��6v   �� 5h      $��   Zatwierdź��6   $	��175��6/   $��Right=�6;   $��24(�6W   $��Tahoma)�6e   $��Center=�6y   $
��Bold"�6�   5i      5j      5l      5m      