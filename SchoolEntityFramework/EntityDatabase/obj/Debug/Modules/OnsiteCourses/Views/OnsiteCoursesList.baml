   M S B A M L   `   `   `  ����  EntityDatabase3    -Modules.OnsiteCourses.Views.OnsiteCoursesList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � -   5        $��MainGrid��5      .+�5	   
   &   System.Windows.Controls.DataGrid  $
��Left=�6   $��0,30,0,0q�6.   $	��Top=�6@   $	��284��5
   9   $	��566��6F       AutoGenerateColumns  .     RowDetailsVisibilityMode$ VisibleWhenSelected=�5   /   ��5
      �� *OnsiteCourses+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        CourseColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Course��5   a      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ��  �� Path$ Course.Title�6q     5      -   5        LocationColumn��$ Location��5   _   $	 100 6q    6=   �� $ Location�6q     5      -   5        
DaysColumn��$
 Days��5   W   $	 100 6e    69   �� $
 Days�6e     5      -   5        
TimeColumn��$
 Time��5   W   $	 150 6e    69   �� $
 Time�6e   5      �� 5   
   $��Agregar��6   $
��Left=�6B   $��409,326,0,0q�6]   $	��Top=�6r   $��75��6�   ��6#   �� *
AddCommand+6�   �� 5   
   $��Eliminar��6   $
��Left=�6G   $��484,326,0,0q�6b   $	��Top=�6w   $��75��6�   ��6%   �� *DeleteCommand+6�   5      5      