   M S B A M L   `   `   `  ����C  ?Projekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProjekatProjekat  5   	       Projekat.ViewPatients   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Projekat     5   	     � Title$  ViewPatients��5   	   $	��450��6   $	��800��6+   .��5
      � .+�5   
   �� -   5        $��lvDataBinding��5      $��0,10,-0.4,-10q�6(    J� RenderTransformOrigin$ 
0.463,0.55&�6?   ��5      �� 5      .R�5      � .+�5      �� $�� ID: ��6%   �� 5      $
��Bold"�6=   $��	Underline{�6P   
����  � � Cursor$
 Hand��6~   ��6$   �� *	user.Id+6~   �� 5      $��, ��6$   �� 5      $�� First name: ��6$   $
��Bold"�69   �� 5      ��6$   �� *user.FirstName+�� 5      $�� Last name: ��6$   $
��Bold"�68   �� 5      ��6$   �� *user.LastName+�� 5      $�� JMBG: ��6$   $
��Bold"�63   �� 5      ��6$   �� *	user.Jmbg+�� 5      $�� Phone Number: ��6$   $
��Bold"�6;   �� 5      ��6$   �� *user.PhoneNumber+�� 5      $�� Username: ��6$   $
��Bold"�67   �� 5      ��6$   �� *user.Username+�� 5      $�� Password: ��6$   $
��Bold"�67   �� 5      ��6$   �� *user.Password+5      5       5"      �� 5$   
   -   5        $��Delete Patient��5$      $
��Left=�6*   $��200,320,0,0q�6E   $	��Top=�6Z   $	��100��6r   6~   �� 5%   
   -   5        $��Update Patient ��5%      $
��Left=�6+   $��430,320,0,0q�6F   $	��Top=�6[   $	��100��6s   6   5(      5)      