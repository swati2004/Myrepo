   M S B A M L   `   `   `  ����U  Qemployee_management_system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:employee_management_system.Viewemployee_management_system.View  5   	   [2clr-namespace:employee_management_system.ViewModel$employee_management_system.ViewModel  5   	   /    )employee_management_system.View.LoginView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:employee_management_system.View     5   	   @v2clr-namespace:employee_management_system.ViewModel     5   	     � Title$  	LoginView��5   	   $	��450��6   $	��800��6(    � 	Resources 5      @   :employee_management_system.ViewModel.LoginViewModelCommand   v1��%   &	          5   
   6/   5      .��5      � $��0,0,-0.4,-2q�6   .+�5   
   �� $��login to your account��6   $��230,174,0,0q�62   $��18(�6G   $
��Bold"�6U   .��5      �� -   5         ��Name$ 
Login_Copy��5      $��Login��6)   $
��Left=�69   $	��Top=�6T   $	��104��6l    J� RenderTransformOrigin$ 5.46,15.069&�6x   $��340,375,0,-195q�6�   ���	#FF18191D$��34��6�   
�������6�   5      �� 5   
   -   5         ��Name$ Username��5      $��Username��6"   $
��Left=�65   $��Bottom=�6P   $��271,0,0,154q�6k   $	��114��6�   $��18(�6�   $
��Bold"�6�   $ 1,1.064&�6�   �� 5   
   -   5        $ password��5      $��Password��6"   $
��Left=�65   $	��Top=�6P   $��271,302,0,0q�6h   $��18(�6}   $
��Bold"�6�   $ 0.134,0.591&�6�   �� 5   
   -   5         ��Name$ txt_username��5      $
��Left=�6�   $��34��6�    �� TextWrapping$
 Wrap=�6�   $��Bottom=�6�   $	��202��6  $ 3.094,6.531&�6  $��477,0,0,154q�6A  ��6(   �� *login.Username+ �� Source# [   �� ValidatesOnDataErrors . 	 �� UpdateSourceTrigger$	 PropertyChanged=�6A  �� 5   
   
���  ��$
��Bold"�6!   $��477,271,25,120q�63   ��6K   �� 
 �� ElementName$
 txt_username�� �� Path$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5   
   -   5        $ txt_pass��5      $
��Left=�6�   $��34��6�   $
 Wrap=�6�   $	��Top=�6�   $	��202��6
  $��477,302,0,0q�6  ��6$   �� *login.Password+# [   . $	 PropertyChanged=�6  �� 5   
   
���  ��$
��Bold"�6!   $��477,341,66,52q�6�   ��64   �� $
 txt_pass��$2 ,(Validation.Errors).CurrentItem.ErrorContent�6�   �� 5   
   $
��Left=�6   $	��169��6+   $	��Top=�68   $	��792��6P   $��employee.jpg��6\   $��UniformToFill=�6r   �� 5   
   $
��Left=�6   $	��172��6+   $	��Top=�68   $	��193��6P   $��
32,211,0,0q�6\   $��
images.png��6p   $��UniformToFill=�6�   $ 0.294,0.486&�6�   �� 5   
   -   5        $ Login��5      $��Select��6    $��15(�6t   $��Login��6�   $
��Left=�6�   $	��Top=�6�   $	��104��6�   $ 5.46,15.069&�6�   $��416,375,0,0q�6�   ���	#FF18191D$��34��6!  
���������6:   �� *	mycommand+# [  6-  �� 5   
   -   5        $
 Exit��5      $��Exitbtn��6   $��15(�6t   $
��Exit��6�   $
��Left=�6�   $	��Top=�6�   $	��104��6�   $ 5.46,15.069&�6�   $��575,375,0,0q�6�   ���	#FF18191D$��34��6   
���������6:   �� *	mycommand+# [  6,  5      5       