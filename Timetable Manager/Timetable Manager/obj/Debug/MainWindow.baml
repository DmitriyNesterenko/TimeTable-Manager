   M S B A M L   `   `   `  ����L  HTimetable Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Timetable_ManagerTimetable_Manager  5   	   "    Timetable_Manager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Timetable_Manager     5   	   -   5          � Title$  Time Table: Build 0004��5   	   $��436.988��6(   $��309.453��69    � Icon$� �C:\Users\Dmitriy\Documents\Visual Studio 2015\Projects\Timetable Manager\Timetable Manager\Resources\Graphicloads-Flat-Finance-Time.ico��6`    � WindowStyle$ 
ToolWindow=�6�   
���   � � 
ResizeMode$ NoResize=�6  ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FFD1E8B0��6   $ 1Q�6-   5       J� OpacityMask 5      �� 5   
   $ 0.5,1&�6   $ 0.5,0&�6/   .��5      � $ Black��6   $ 0Q�6)   � 5      $ White��6   $ 1Q�6)   5      .��5      � $	��421��6   $	��Top=�6   	 � ColumnDefinitions	 5   
   .+�5   
   �� -   5        
 ��Name$
 ListItem��5      $
��Left=�6%   $	��267��6@   $��
18,109,0,0q�6M   $	��Top=�6a   $	��256��6y   
������� �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$ 25��61    �� DisplayMemberBinding 6<   �� *Id+�� 5      $
��Item��6%   $	 115��64    6@   �� *Name+�� 5      $��	Time rest��6%   $	 110��68    6D   �� *
TimeRest+5      5       �� 5!   
   -   5         ��Name$ lbl_date��5!      $��Today: ��6"   $��	18,83,0,0q�64   $	��175��6G   $
��Left=�6S   $	��Top=�6n   
�������6�   �� 5"   
   -   5         ��Name$ txtBox_Item��5"      $
��Left=�6'   $��23��6B   $��	17,55,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��177��6�   .��6�   ��5#      �� 5$      $ 0.5,1&�6&   $ 0.5,0&�67   .��5%      � $ Black��6#   $ 0Q�61   � 5&      $ 	#FF0A168B��6#   $ 0.456Q�65   5'      .��5(   #   5)      �� 5*   
   -   5         ��Name$ btn_AddLesson��5*      $��
Add lesson��6(   $
��Left=�6=   $��
199,55,0,0q�6X   $	��Top=�6l   $��75��6�   $��23��6�   
���������5+      �� 5,      $ 0.5,1&�6&   $ 0.5,0&�67   .��5-      � $ Black��6#   $ 0Q�61   � 5.      $ 	#FFE60000��6#   $ 0.585Q�65   5/      51      o� 52   
   -   5         o�Name$
 menu��52      $
��Left=�6   $��20��68   $	��Top=�6D   $	��301��6\   .@�53      m� $
��File��6   .@�54      m� -   5         m�Name$ menuBtn_ChangeDate��54      $��Change date��67   6L   m� 55      -   5        $ menuBtn_Export��55      $��	Export...��63   6F   m� 56      -	   5        $ menuBtn_Exit��56      $
��Exit��61   6?   57      m� 58      $
��Help��6   .@�59      m� -
   5        $ menuBtn_About��59      $��About��62   6A   5:      5;      �� 5<   
   -   5        $ lbl_helpAddItem��5<      $��Enter lesson:��6)   $
��Left=�6A   $��	17,29,0,0q�6\   $	��Top=�6o   $	��176��6�   
������� J� RenderTransformOrigin$ 0.5,0.5&�6�   5=      5>      