   M S B A M L   `   `   `  ����  EntityDatabase/    )Modules.Departments.Views.DepartmentsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � -   5        $��MainGrid��5      .+�5	   
   &   System.Windows.Controls.DataGrid  $
��Left=�6   $��0,30,0,0q�6.   $	��Top=�6@   $	��284��5
   7   $	��566��6D       AutoGenerateColumns  .     RowDetailsVisibilityMode$ VisibleWhenSelected=�5   /   ��5
      �� *Departments+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        DepartmentIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5   g      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ DepartmentID�6s     5      -   5        
NameColumn��$
 Name��5   W   $	 100 6e    69   �� $
 Name�6e     5      -   5        BudgetColumn��$ Budget��5   [   $	 100 6k    6;   �� $ Budget�6k   5      �� 5   
   $��Agregar��6   $
��Left=�6#   $��409,326,0,0q�6>   $	��Top=�6S   $��75��6k   �� 5   
   $��Eliminar��6   $
��Left=�6$   $��484,326,0,0q�6?   $	��Top=�6T   $��75��6l   5      5      