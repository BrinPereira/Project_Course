   M S B A M L   `   `   `  ����J  FAssignment4_New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Assignment4_New.ViewAssignment4_New.View  5   	   #    Assignment4_New.View.Editview   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   .local"clr-namespace:Assignment4_New.View  5   	     � Title$  Editview��5	   	   $	��400��6   $	��550��6'   .��5      �  � DataContext 6   �� *Main+   Locator �� Source# [  .+�5   
   �� $��UPDATE��6   $
��Left=�6"   $��
46,294,0,0q�6=   $	��Top=�6Q   $��75��6i   $��43��6t   ��5      �� *SelectedMemberUpdateCommand+�� 5   
   $��DELETE��6   $
��Left=�6"   $	��Top=�6=   $��75��6U   $��226,294,0,0q�6`   $��43��6u   ��5      �� *SelectedMemberDeleteCommand+�� 5   
   $��CANCEL��6   $
��Left=�6"   $	��Top=�6=   $��75��6U   $��406,294,0,0q�6`   $��43��6u   ��5      �� *cancelCommand+�� 5   
   $��
First Name��6   $
��Left=�6%   $��	34,56,0,0q�6@   $	��Top=�6S   $	��126��6k   $��20(�6w   $��Bookman old style)�5      �� 5   
   $��Second Name��6   $
��Left=�6&   $��
34,128,0,0q�6A   $	��Top=�6U   $	��149��6m   $��20(�6y   $��Bookman old style)�5      �� 5   
   $��Email��6   $
��Left=�6    $��
34,202,0,0q�6;   $	��Top=�6O   $	��138��6g   $��20(�6s   $��Bookman old style)�5      �� 5    
   $
��Left=�6   $��42��6-    �� TextWrapping$
 Wrap=�69   $	��Top=�6M   $	��311��6e   $��
201,56,0,0q�6q   ��5!      �� *SelectedMember.FirstName+�� 5#   
   $
��Left=�6   $��42��6-   $
 Wrap=�69   $	��Top=�6M   $	��311��6e   $��201,128,0,0q�6q   ��5$      �� *SelectedMember.LastName+�� 5&   
   $
��Left=�6   $��42��6-   $
 Wrap=�69   $	��Top=�6M   $	��311��6e   $��201,193,0,0q�6q   ��5'      �� *SelectedMember.Email+5)      5*      