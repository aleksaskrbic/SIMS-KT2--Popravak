   M S B A M L   `   `   `  ����C  ?Projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProjekatProjekat  5   	       Projekat.Appointments   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Projekat     5   	     � Title$  Appointments��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��27* �6   �� 5      $	��13* �6   .+�5   
   �� -   5        $��lvUsers��5   *   $��10,10,193,163q�6   $��2��69    �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 50��61    �� DisplayMemberBinding 6<   �� *Id+�� 5      $��
Start Time��6%   $	 100��69    6E   �� *	TimeStart+�� 5      $��Duration��6%   $ 70��67    6B   �� *
Duration+�� 5      $��Is over?��6%   $ 70��67    6B   �� *
Finished+�� 5      $��End time��6%   $	 100��67    6C   �� *	EndTime+�� 5      $��	Room name��6%   $	 100��68    6D   �� *Room+�� 5      $��Patient name��6%   $	 100��6;    6G   �� *	Patient+�� 5      $��Doctor name��6%   $	 100��6:    6F   �� *Doctor+ �� CellTemplate 5      �� 5      .R�5   "   �� $��	Underline{�6B   
����  � � Cursor$
 Hand��6p   ��6,   �� *Mail+6p   5      5      5       5"      �� 5#   
   -   5        $��TextBox1��5#   N   $��298,354,140,35q�6    J� RenderTransformOrigin$ 0.529,0.932&�6*   .��6^   Novi text box6m   �� 5$   
   -   5        $��TextBox2��5$   *   $��129,354,309,35q�6   .��6:   	Novi text6E   �� 5%   
   -   5        $��TextBox3��5%   )   $��369,291,69,97q�6   .��69   
Novi box6E   �� 5&   
   -   5        $��TextBox4��5&   *   $��201,291,237,97q�6   .��6:   
text box6D   �� 5'   
   -   5        $��TextBox5��5'   )   $��49,291,389,96q�6   .��69   No box6B   �� 5(   
   -   5        $��102,85,43,281q�5(      $��1��6@   .��6P   
Schedule5*      �� 5+   
   -   5        $��102,185,52,181q�5+      $��1��6D   .��6T   Cancel5-      �� 5.   
   -	   5        $��1��5.      $��102,291,48,75q�6!   .��6S   
Reschedule50      51      52      