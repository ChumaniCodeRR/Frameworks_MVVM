   M S B A M L   `   `   `  ����N  JWPF_MVVM_Frameworks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPF_MVVM_Frameworks.ViewWPF_MVVM_Frameworks.View  5      '    !WPF_MVVM_Frameworks.View.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:WPF_MVVM_Frameworks.View     5        N� Title$  MainPage��5	       N� 
Background
 ����� N� WindowWidth$	 800Q�60    N� WindowHeight$	 400Q�6B   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��50px �6   �� 5      $��* �6   .+�5   
   � 
�����_�$��0��6&   $��50��63   $	��Top=�6?   .+�5      �� $��Center=�6   $��Center=�61   $
��20px(�6L   
�������.��6o   
Students6y   �� 5      -   5        $
��50px��5   0   $��Right=�6=   
���  ��
�������.��6}   Delete6�   �� 5      -   5        $
��50px��5   -   $��Right=�6:   
��� � �
�������$��	0,0,102,0q�6|   .��6�   Add6�   �� 5      -   5        $
��50px��5   0   $��Right=�6=   
��� ���
�������$��0,0,51,0q�6�   .��6�   Modify6�   5      � 5   
   $��
30 0 30 30q�6   $��2��6#    5      �� 5      $��* �6#   �� 5      $	��200 �6#    5      �� 5       $
��10px �6    �� 5!      $
��20px �6    60   �� 5"      $
��10px �6    �� 5#      6"   .+�5%      � $��1��6    5&      �� 5'      �� 5(      �� 5)      .+�5,      �� -   5         ��Name$ ListBoxSort��5,   K   $��0��6`   $
��Left=�6p   $��20��6�   $	��Top=�6�   .@�5-      �� .��6#   First Name - Ascending6;   �� 5.      .��6#   First Name - Descending6<   �� 5/      .��6#   Last Name - Ascending6:   �� 50      .��6#   Last Name - Descending6;   51      �� 52      -   5        $��1��52      .��6I   Sort with Courses6\   �� 53      -   5        $��2��53   4   $��Right=�6D   .��6`   Reload6h   54      &   System.Windows.Controls.DataGrid  55      -   5          Name$ StudentsDataGrid��55   $   $��3��6      AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
sFirstName+  58      $ 	Last name��6)    6<   �� *	sLastName+   RowDetailsTemplate 5:      �� 5;      .R�5<      �� $��0q�6!   
������� �� Padding$ 10q�6M   ._�5=      ��  �� Orientation$ Vertical=�6)   .+�5>   "   �� $ 
Horizontal=�6-   .+�5?   &   �� $��15(�60   $��Address details��6>   $��Center=�6U   $
��Bold"�6p   5@   #   �� 5A   "   $ 
Horizontal=�6-   .+�5B   &   �� $��12(�60   $��	Address: ��6>   $��Center=�6O   �� 5C   &   $��16(�60   
���p�$��Center=�6z   ��6X   �� *Address.Address1+6z   5D   #   �� 5E   "   $ 
Horizontal=�6-   .+�5F   &   �� $��12(�60   $��City: ��6>   $��Center=�6L   �� 5G   &   $��16(�60   
���p�$��Center=�6v   ��6X   �� *Address.City+6v   5H   #   �� 5I   "   $ 
Horizontal=�6-   .+�5J   &   �� $��12(�60   $��	Country: ��6>   $��Center=�6O   �� 5K   &   $��16(�60   
���p�$��Center=�6y   ��6X   �� *Address.Country+6y   5L   #   �� 5M   "   $ 
Horizontal=�6-   .+�5N   &   �� $��12(�60   $��	Courses: ��6>   $��Center=�6O   �� 5O   &   $
��auto��6O   ��6/   �� *	Courses+��5P   *   �� 5Q   .   .R�5R   2   �� $ 
Horizontal=�6=   6X   5S   /   ��5U   *   �� 5V   .   .R�5W   2   �� ��6<   �� *cName+6U   5X   /   5Z   '   5[   #   5\      5]      5^      5`      �� 5b      $��1��6   $��3��6)   .+�5c      �� .��6   List of Courses6)   �� 5d      -   5         ��Name$ CoursesListBox��5d       �� DisplayMemberPath$ cName��62    �� SelectionMode$ Multiple=�6L   $��Visible=�6e   $	��150��6�   6�   �� 5e      -	   5        .��5e   =   Sort6C   5f      5g      5h      5i      