   M S B A M L   `   `   `  ����L  HTimetable Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Timetable_ManagerTimetable_Manager  5   	   #    Timetable_Manager.LessonSetUp   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Timetable_Manager     5   	     � Title$  	TimeSetUp��5   	   $��298.687��6   $��461.495��6,    � 
ResizeMode$ NoResize=�6<   .��5	      � .+�5
   
   �� -   5         ��Name$ 
btn_Accept��5
      $��Accept��6%   $
��Left=�66   $��129,214,0,0q�6Q   $	��Top=�6f   $��61��6~   $��39��6�   6�   �� 5   
   -   5        $ 
btn_Cancel��5      $��Cancel��6%   $
��Left=�66   $��129,176,0,0q�6Q   $	��Top=�6f   $��61��6~   $��38��6�   6�   �� 5   
   -   5         ��Name$ 
txt_Number��5      $
��Left=�6&   $��34��6A   $��
31,200,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $��45��6u   $	��Top=�6   $��34��6�   $��21.333(�6�   {�.  6�   �� 5   
   -   5        $ btn_GreatNumber��5      $��^��6*   $
��Left=�66   $��
10,176,0,0q�6Q   $	��Top=�6e   $��75��6}   $��24��6�   $��21.333(�6�   6�   �� 5   
   -   5        $ btn_LessNumber��5      $��V��6)   $
��Left=�65   $��
10,234,0,0q�6P   $	��Top=�6d   $��75��6|   6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ calendarDate��5      $
��Left=�6)   $��10,3,0,0q�6D   $	��Top=�6V   $	��180��6n   $	��168��6z   6�   �� 5   
   -   5         ��Name$ lbl_InfoTime��5      $��Minutes��6&   $
��Left=�68   $��
65,203,0,0q�6S   $	��Top=�6g   �� 5   
   -   5        $ txtBox_lessonComment��5      $
��Left=�60   $	��257��6K   $��	195,3,0,0q�6X   $
 Wrap=�6k   $��Comments for lesson��6   $	��Top=�6�   $	��250��6�   $ �� HorizontalScrollBarVisibility$
 Auto=�6�   " �� VerticalScrollBarVisibility$ Visible=�6�   ��. 6	  5      5      