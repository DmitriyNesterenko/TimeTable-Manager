   M S B A M L   `   `   `  ���� L  HTimetable Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Timetable_ManagerTimetable_Manager  "    Timetable_Manager.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Timetable_Manager     -     � Title$  
Time Table��$��436.988��$��309.453�� � Icon$� �C:\Users\Dmitriy\Documents\Visual Studio 2015\Projects\Timetable Manager\Timetable Manager\Resources\Graphicloads-Flat-Finance-Time.ico�� � WindowStyle$ 
ToolWindow=�
���   � � 
ResizeMode$ NoResize=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFD1E8B0��$ 1Q� J� OpacityMask �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q�.��� $	��421��$	��Top=�	 � ColumnDefinitions	 .+��� -   
 ��Name$
 ListItem��$
��Left=�$	��267��$��
18,109,0,0q�$	��Top=�$	��256��
������� �� View �� .P��� $��Id�� �� Width$ 25�� �� DisplayMemberBinding �� *Id+�� $
��Item��$	 115�� �� *Name+�� $��	Time rest��$	 110�� �� *
TimeRest+�� -    ��Name$ lbl_date��$��Today: ��$��	18,83,0,0q�$	��175��$
��Left=�$	��Top=�
��������� -    ��Name$ txtBox_Item��$
��Left=�$��23��$��	17,55,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��177��.������ $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FF0A168B��$ 0.456Q�.���� -    ��Name$ btn_AddLesson��$��
Add lesson��$
��Left=�$��
199,55,0,0q�$	��Top=�$��75��$��23��
����������� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FFE60000��$ 0.585Q�o� -    o�Name$
 menu��$
��Left=�$��20��$	��Top=�$	��301��.@�m� $
��File��.@�m� -    m�Name$ menuBtn_ChangeDate��$��Change date��m� -   $ menuBtn_Export��$��	Export...��m� -	   $ menuBtn_Exit��$
��Exit��m� $
��Help��.@�m� -
   $ menuBtn_About��$��About���� -   $ lbl_helpAddItem��$��Enter lesson:��$
��Left=�$��	17,29,0,0q�$	��Top=�$	��176��
������� J� RenderTransformOrigin$ 0.5,0.5&�