   M S B A M L   `   `   `  ����J  FAssignment4_New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Assignment4_New.ViewAssignment4_New.View  5   	   "    Assignment4_New.View.AddView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Assignment4_New.View     5   	   -   5          �Name$
  wnd2��5   	    � Title$ AddView��5	   	   $	��400��6   $	��550��6&   .��5      �  � DataContext 6   �� *Main+   Locator �� Source# [  .+�5   
   �� $��
First Name��6   $
��Left=�6%   $��	47,62,0,0q�6@   $	��Top=�6S   $��20(�6k   $��	ExtraBold"�6y   �� 5   
   -   5         ��Name$ txtfirst��5      $
��Left=�6$   $��40��6?   $��
179,71,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��335��5      $��12(�6   $��Bookman old style)�6,   ��6K   �� *SelectedMember.FirstName+�� 5   
   $��	Last Name��6   $
��Left=�6$   $��
47,148,0,0q�6?   $	��Top=�6S   $��20(�6k   $��	ExtraBold"�6y   �� 5   
   -   5        $ 	txtsecond��5      $
��Left=�6%   $��40��6@   $��179,145,0,0q�6L   $
 Wrap=�6a   $	��Top=�5      $	��335��6*   $��12(�66   $��Bookman old style)�6D   ��6c   �� *SelectedMember.LastName+�� 5   
   $��Email��6   $
��Left=�6    $��
47,233,0,0q�6;   $	��Top=�6O   $��20(�6g   $��	ExtraBold"�6u   �� 5   
   -   5        $ txtemail��5      $
��Left=�6$   $��40��6?   $��179,233,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��335��5      $��12(�6   $��Bookman old style)�6,   ��6K   �� *SelectedMember.Email+�� 5   
   $
��Save��6   $
��Left=�6    $��101,310,0,0q�6;   $	��Top=�6P   $��90��6h   $��40��6s   $��20(�5      $��	ExtraBold"�6   ��66   �� *SaveCommand+�� 5   
   $��Cancel��6   $
��Left=�6"   $��403,310,0,0q�6=   $	��Top=�6R   $��90��6j   $��40��6u   $��20(�6�   $��	ExtraBold"�5       ��6(   �� *cancelCommand+ �� Mode$ OneWay=���6W   ��  �� ElementName$
 wnd2��5"      5#      