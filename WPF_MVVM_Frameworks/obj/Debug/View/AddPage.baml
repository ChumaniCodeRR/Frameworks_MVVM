   M S B A M L   `   `   `  ����N  JWPF_MVVM_Frameworks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPF_MVVM_Frameworks.ViewWPF_MVVM_Frameworks.View  5      &     WPF_MVVM_Frameworks.View.AddPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:WPF_MVVM_Frameworks.View     5        N� 
Background
  ����� N� WindowHeight$	 370Q�5	       N� WindowWidth$	 600Q�6-    N� Title$ Add Student��5
      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��50px �6   �� 5      $��* �6   .+�5   
   � 
�����_�$��0��6&   .+�5      �� $��Center=�6   $��Center=�61   $
��20px(�6L   
�������.��6o   Add6t   �� 5      -   5        $��100px��5   -   $��Right=�6;   
��� � �
�������.��6}   Add Student6�   5      � 5   
   $��1��6   $
��30pxq�6    5      �� 5      �� 5      .+�5      �  5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5%      �� $��0��6   $��0��6*    �� Orientation$ 
Horizontal=�6:   $��Center=�6S   .+�5&      �� .��6   First name :6*   �� 5'      -   5         ��Name$ 
sFirstName��5'      $��150px��62   $��Center=�6@   5(      �� 5)      $��1��6   $��0��6*   $ 
Horizontal=�6:   $��Center=�6S   .+�5*      �� .��6   
Last name:6(   �� 5+      -   5        $ 	sLastName��5+      $��150px��61   $��Center=�6?   5,      �� 5-      $��2��6   $��0��6*   $ 
Horizontal=�6:   $��Center=�6S   .+�5.      �� .��6   
Address:6&   �� 5/      -   5        $ Address1��5/      $��150px��60   $��Center=�6>   50      �� 51      $��3��6   $��0��6*   $ 
Horizontal=�6:   $��Center=�6S   .+�52      �� .��6   City:6#   �� 53      -   5        $
 City��53      $��150px��6,   $��Center=�6:   54      �� 55      $��4��6   $��0��6*   $ 
Horizontal=�6:   $��Center=�6S   .+�56      �� .��6   
Country:6&   �� 57      -   5        $ Country��57      $��150px��6/   $��Center=�6=   58      59      �� 5:      $��1��6   .+�5;      �� .��6   List of Courses:6*   �� 5<      -   5         ��Name$ CoursesListBox��5<      	 �� DisplayMemberPath$	 cName��62   
 �� SelectionMode$
 Multiple=�6L   $��Visible=�6e   $	��200��6�   6�   5=      5>      5?      5@      