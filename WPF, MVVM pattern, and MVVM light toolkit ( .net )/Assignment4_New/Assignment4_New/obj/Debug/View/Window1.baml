   M S B A M L   `   `   `  ����J  FAssignment4_New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Assignment4_New.ViewAssignment4_New.View  5   	   "    Assignment4_New.View.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   .local"clr-namespace:Assignment4_New.View  5   	   -   5          �Name$
  wnd1��5	   	    � Title$ Window1��5
   	   .��5      �  � DataContext 6   �� *Main+   Locator �� Source# [  .+�5   
   �� $��Members��6   $
��Left=�6"   $��	53,76,0,0q�6=   $	��Top=�6P   $��20(�6h    J� RenderTransformOrigin$ 5.262,-1.553&�5      $	��170��65   $��40��6A   $��	ExtraBold"�6M   $��Bookman old style)�6d   �� 5   
   $	��ADD��6   $
��Left=�6    $��430,116,0,0q�6;   $	��Top=�6P   $	��100��6h   $��20(�6t   ��5      �� *ShowCommand+�� 5   
   $
��EXIT��6   $
��Left=�6!   $��430,234,0,0q�6<   $	��Top=�6Q   $	��100��6i   $��20(�6u   ��5      �� *CloseCommand+ �� Mode$ OneWay=���6?   ��  �� ElementName$
 wnd1���� 5   
   -   5         ��Name$ membersListBox��5       �� DisplayMemberPath$ GetDisplayText��5      $
��Left=�65   $	��316��6P   $��	28,30,0,0q�6]   $	��Top=�6p   $	��383��5      $��15(�6   $��Bookman old style)�6,   ��5   *   �� *MembersList+	 �� SelectedItem	 6N   �� *SelectedMember+.  (System.Windows.Interactivity.Interaction
   Triggers
 5      /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ MouseDoubleClick��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *SelectedMemberChangedCommand+   CommandParameter 5      �� $ membersListBox�� �� Path$ SelectedItem�5!      5#      5$      5%      