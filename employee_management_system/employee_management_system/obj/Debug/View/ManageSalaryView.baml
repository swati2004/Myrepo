   M S B A M L   `   `   `  ����U  Qemployee_management_system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:employee_management_system.Viewemployee_management_system.View  5   	   [2clr-namespace:employee_management_system.ViewModel$employee_management_system.ViewModel  5   
   S.clr-namespace:employee_management_system.Model employee_management_system.Model  5   
   6    0employee_management_system.View.ManageSalaryView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:employee_management_system.View     5   	   Ams2clr-namespace:employee_management_system.ViewModel     5   
   <m.clr-namespace:employee_management_system.Model     5   
     � Title$  ManageSalaryView��5   	   $��567.299��6"   $	��800��63    � 	Resources 5      @   :employee_management_system.ViewModel.ManagesalaryViewModel 	  mskey8   2employee_management_system.Model.ManageSalaryModel  ab��%:   &	        &	        5   
   63     5   
   6+   5      .��5      � $��0,0,-18.4,-1.4q�6   
��� ��� J� RenderTransformOrigin$ 
0.48,0.573&�67   .+�5   
   �� $��Select Employee��6   $
��Bold"�6*   $
��Left=�6<   $	��Top=�6W   $��
226,50,0,0q�6o   $��16(�6�   $��32��6�   $	��140��6�   �� 5   
   -   5        $��combo1��5      $
��Left=�6P   $	��Top=�6k   $	��202��6�   $��
387,50,0,0q�6�   $��32��6�    �� Text 6!   �� *Id+ �� Source# [ 6�   �� 5   
   $��Description��6   $��16(�6&   $
��Left=�64   $	��Top=�6O   $��394,182,0,0q�6g   $��44��6|   $	��125��6�   $��Yu Gothic UI Semibold)�6�   �� 5   
   $��Date of Payment��6   $��16(�6*   $
��Left=�68   $	��Top=�6S   $��394,114,0,0q�6k   $��41��6�   $	��137��6�   $��Yu Gothic UI Semibold)�6�   �� 5   
   $��Total Amount��6   $��16(�6'   $
��Left=�65   $	��Top=�6P   $��
92,182,0,0q�6h   $��41��6|   $	��119��6�   $��Yu Gothic UI Semibold)�6�   �� 5   
   $��Enter Month��6   $��16(�6&   $
��Left=�64   $	��Top=�6O   $��
92,118,0,0q�6g   $��37��6{   $	��104��6�   $��Yu Gothic UI Semibold)�6�   $ 0.135,0.492&�6�   �� 5   
   -   5         ��Name$ txt_desc��5      $
��Left=�6g   $��23��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��118��6�   $��578,182,0,0q�6�   ��6$   �� *manage.Description+# [  6�   �� 5   
   $�� ��6   $
��Left=�6   $	��Top=�66   $��578,218,0,0q�6N   $ 0.552,-0.031&�6c   $	��143��6�   �� 5   
   -   5        $ 	txt_month��5      $
��Left=�6a   $��23��6|   $
 Wrap=�6�   $	��Top=�6�   $	��117��6�   $��232,123,0,0q�6�   ��6%   �� *manage.Month+# [  6�   �� 5   
   $�� ��6   $
��Left=�6   $	��Top=�66   $��232,151,0,0q�6N   $	��149��6c   �� 5    
   -   5        $ 
txt_amount��5       $
��Left=�6c   $��23��6~   $
 Wrap=�6�   $	��Top=�6�   $	��117��6�   $��232,182,0,0q�6�   ��6&   �� *manage.Amount+# [  6�   �� 5!   
   $�� ��6   $
��Left=�6   $	��Top=�66   $��232,218,0,0q�6N   $	��149��6c   (  "System.Windows.Controls.DatePicker  5#   
   -   5          Name$ 
dt_payment��5#      $
��Left=�6k   $	��Top=�6�   $��578,122,0,0q�6�   $��29��6�   $	��143��6�      Text 6)   �� *manage.PaymentDate+# [  6�   �� 5$   
   $�� ��6   $
��Left=�6   $	��Top=�66   $��578,151,0,0q�6N   $	��143��6c   �� 5&   
   -   5        $
��Find��5&      $
��Left=�6    $	��Top=�6;   $	��109��6S   $��566,249,0,0q�6_   $��29��6t   $��16(�6�   $��Segoe UI Semibold)�6�   6�   �� 5'   
   $��Delete��6   $��Delete��6]   $
��Left=�6w   $	��Top=�6�   $	��109��6�   $��410,247,0,0q�6�   $��31��6�   $��16(�6�   $��Segoe UI Semibold)�6�   ��6"   �� *
command4+# [  6�   �� 5(   
   $��Update��6   $��Update��6]   $
��Left=�6w   $	��Top=�6�   $	��109��6�   $��257,247,0,0q�6�   $��31��6�   $��16(�6�   $��Segoe UI Semibold)�6�   $ 0.165,0.516&�6  ��6"   �� *
command4+# [  6  &   System.Windows.Controls.DataGrid  5*   
   -   5        	  Name$	 grid1��5*      $
��Left=�6"   
   AlternatingRowBackground

 ��ح�$	��218��6c   $	��Top=�6p   $	��741��6�   $��
32,294,0,0q�6�   �� 5+   
   $
��save��6   $
��save��6\   $��Bottom=�6t   $��102,0,601,262q�6�   $��31��6�   $��18(�6�   $��Segoe UI Semibold)�6�   ��6    �� *
command4+# [  6�   5-      5.      