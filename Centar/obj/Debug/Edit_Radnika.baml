   M S B A M L   `   `   `  ����A  =Centar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CentarCentar  5   	   +    %edit_i_dodavanje_radnika.Edit_Radnika   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   &localclr-namespace:Centar     5   	   -   5          � Title$
  edit��5   	   $��372.5��6   $	��481��6%    � 
ResizeMode$ NoResize=�6N    � 	Resources 5         Centar.Radnik   data  textBoxInError �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value	 �� Self
 �� RelativeSource �� Path��%�   &	        &	        5   
   6   �� 5   
   " ��6'    5	      P� 5
       �@=�HasError . . �5      ��  �@�ToolTip 60   �� #
 Z	 $) #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � -   5        $��0,0,2,-4q�5      .+�5   
   �� -   5         ��Name$ label_ime_edit��5      $
��Ime:��6(   $
��Left=�67   $	��Top=�6R   $��30.575,50,0,0q�6j   �� 5   
   -   5        $ label_prezime_edit��5      $��Prezime:��6,   $
��Left=�6?   $	��Top=�6Z    J� RenderTransformOrigin$ 
2.036,3.71&�6r   $��30.575,81,0,0q�6�   �� 5   
   -   5        $ label_adresa_edit��5      $��Adresa:��6+   $
��Left=�6=   $	��Top=�6X   $��30.575,112,0,0q�6p   �� 5   
   -   5        $ label_opisPosla_edit��5      $��Opis posla:��6.   $
��Left=�6D   $	��Top=�6_   $ 1.145,1.823&�6w   $��30.575,143,0,0q�6�   �� 5   
   -   5        $ label_datumRodjenja_edit��5      $��Datum rodjenja:��62   $
��Left=�6L   $	��Top=�6g   $��30.575,175,0,0q�6   �� 5   
   -   5        $ label_jmb_edit��5      $
��JMB:��6(   $
��Left=�67   $	��Top=�6R   $��30.575,19,0,0q�6j   $ -0.958,-0.329&�6�   �� 5   
   -	   5         ��Name$ textBox_jmb_edit��5      |�. #��[ 6=   $
��Left=�6�   $��23��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��235��6  $��213.575,23,0,0q�6  $��1��6*   � Cursor 6e   ��  �� ElementName$
 Box1��$) #(Validation.Errors)[0].ErrorContent�.��67  ��5      �� 5      $	 jmb�6    �� Source# [  6%    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6a    �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5      .��5      5      �� 5    
   -
   5        $ textBox_adresa_edit��5       |�. #��[ 6@   $
��Left=�6�   $��23��6�   $
 Wrap=�6�   $	��Top=�6�   $	��235��6	  $��213.575,116,0,0q�6  $��4��6.   6h   �� $
 Box1��$) #(Validation.Errors)[0].ErrorContent�.��6;  ��5!      �� 5"      $ adresa�6   # [  6(    . $ PropertyChanged=�6d    5#        5$      5&      .��5'      5(      �� 5)   
   -   5        $ textBox_ime_edit��5)      |�. #��[ 6=   $
��Left=�6�   $��23��6�   $
 Wrap=�6�   $	��Top=�6�   $	��235��6  $��213.575,54,0,0q�6  $��2��6*   6e   �� $
 Box1��$) #(Validation.Errors)[0].ErrorContent�.��67  ��5*      �� 5+      $	 ime�6   # [  6%    . $ PropertyChanged=�6a    5,        5-      5/      .��50      51      �� 52   
   -   5        $ textBox_prezime_edit��52      |�. #��[ 6A   $
��Left=�6�   $��23��6�   $
 Wrap=�6�   $	��Top=�6�   $	��235��6
  $��213.575,85,0,0q�6  $��3��6.   6i   �� $
 Box1��$) #(Validation.Errors)[0].ErrorContent�.��6;  ��53      �� 54      $ prezime�6   # [  6)    . $ PropertyChanged=�6e    55        56      58      .��59      5:      �� 5;   
   -   5        $ textBox_opisPosla_edit��5;      |�. #��[ 6C   $
��Left=�6�   $��23��6�   $
 Wrap=�6�   $	��Top=�6�   $	��235��6  $��213.575,146,0,0q�6  $��5��6a   6k   �� $
 Box1��$) #(Validation.Errors)[0].ErrorContent�6a  (  "System.Windows.Controls.DatePicker  5<   
   -   5          Name$# DatePicker_datumRodjenja_edit��5<      $
��Left=�6<   $	��Top=�6W   $��213.575,175,0,0q�6o   $	��235��6�   $��6��6�   �� 5=   
   -   5        $ label_username_edit��5=      $��	Username:��6-   $
��Left=�6A   $	��Top=�6\   $��30.575,206,0,0q�6t   �� 5>   
   -   5        $ label_password_edit��5>      $��	Password:��6-   $
��Left=�6A   $	��Top=�6\   $��30.575,237,0,0q�6t   G� 5?   
   -   5         G�Name$ 
pwBox_edit��5?      $
��Left=�6*   $��214,237,0,0q�6E   $	��Top=�6Z   $��26��6r   $	��235��6~   $��8��6�   �� 5@   
   -   5        $ textBox_username_edit��5@      $
��Left=�61   $��23��6L   $
 Wrap=�6X   $	��Top=�6l   $	��235��6�   $��213.575,206,0,0q�6�   $��7��6�   �� 5A   
   -   5         ��Name$ button_cancel_edit��5A      $��Cancel��6-   $
��Left=�6>   $	��Top=�6Y   $��75��6q   $��374,292,0,0q�6|   $��10��6�   �� 5B   
   -   5        $ button_edit��5B      $
��Edit��6&   $
��Left=�65   $	��Top=�6P   $��75��6h   $��268,292,0,0q�6s   $��9��6�   5D      5E      