   M S B A M L   `   `   `  ����A  =Centar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CentarCentar  5   	       Add_psa_namespace.Add_Psa   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   &localclr-namespace:Centar     5   	   -   5          � Title$  Add_Psa��5   	   $��395.865��6   $��455.359��6*    � 
ResizeMode$ NoResize=�6W    � 	Resources 5         
Centar.Pas   data  ComboBoxInError �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value	 �� Self
 �� RelativeSource �� Path��%�   &	        &	        5   
   6   �� 5   
   " ��6(    5	      P� 5
       �@=�HasError . . �5      ��  �@�ToolTip 60   �� #
 Z	 $) #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � $��0,0,2,0q�6   .+�5   
   �� -   5         ��Name$ label_id_psa_add��5      $	��Id:��6*   $
��Left=�68   $��	41,46,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $" label_zdravstveno_stanje_add��5      $��Zdravstveno stanje:��66   $
��Left=�6T   $��	41,77,0,0q�6o   $	��Top=�6�   �� 5   
   -   5        $ label_datumCipiranja_add��5      $��Datum cipiranja:��62   $
��Left=�6M   $��
41,108,0,0q�6h   $	��Top=�6|   �� 5   
   -   5        $ label_datumRodjenja_add��5      $��Datum rodjenja:��61   $
��Left=�6K   $��
41,139,0,0q�6f   $	��Top=�6z   �� 5   
   -   5        $ label_stats_add��5      $��Status:��6)   $
��Left=�6;   $��
41,170,0,0q�6V   $	��Top=�6j   �� 5   
   -   5        $ label_sterilizovan_add��5      $��Sterilizovan:��60   $
��Left=�6H   $��
41,201,0,0q�6c   $	��Top=�6w   �� 5   
   -   5        $" label_datumSterilizacije_add��5      $��Datum sterilizacije:��66   $
��Left=�6U   $��
41,232,0,0q�6p   $	��Top=�6�   �� 5   
   -	   5         ��Name$ textBox_idPsa_add��5      $
��Left=�6-   $��23��6H    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��211��6�   $��
197,46,0,0q�6�   $��1��6�   �� 5   
   -
   5         ��Name$ ComboBox_zdrStanje_add��5      |�. #��[ 6D   $
��Left=�6�   $	��Top=�6�   $	��211��6�   $��
197,81,0,0q�6�   $��2��6   � Cursor 6m   ��  �� ElementName$
 Box1��$) #(Validation.Errors)[0].ErrorContent� �� Text 5      �� 5      $ zdravstvenoStanje�6    �� Source# [  63    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6o    �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5      5!      (  "System.Windows.Controls.DatePicker  5"   
   -   5          Name$! datePicker_datCipiranja_add��5"      $
��Left=�6:   $��197,110,0,0q�6U   $	��Top=�6j   $	��211��6�   $��3��6�     5#   
   -   5        $ datePicker_datRodj_add��5#      $
��Left=�65   $��197,141,0,0q�6P   $	��Top=�6e   $	��211��6}   $��4��6�     5$   
   -   5        $ datePicker_datSter_add��5$      $
��Left=�65   $��197,234,0,0q�6P   $	��Top=�6e   $	��211��6}   $��8��6�   �� 5%   
   -   5        $ comboBox_status_add��5%      |�. #��[ 6A   $
��Left=�6�   $��197,174,0,0q�6�   $	��Top=�6�   $	��211��6   $��5��6   6j   �� $
 Box1��$) #(Validation.Errors)[0].ErrorContent� 5&      �� 5'      $ status�6   # [  6(    . $ PropertyChanged=�6d    5(        5)      5+      5-      	� 5.   
   -   5         	�Name$ radioButton_da_add��5.      $��Da��62   $
��Left=�6?   $	��Top=�6Z   $��197,207,0,0q�6r   $��6��6�   	� 5/   
   -   5        $ radioButton_ne_add��5/      $��Ne��62   $
��Left=�6?   $	��Top=�6Z   $��323,207,0,0q�6r   $��7��6�   �� 50   
   -   5         ��Name$ buttton_dodaj_add��50      $��Dodaj��6,   $
��Left=�6<   $	��Top=�6W   $��75��6o   $��206,323,0,0q�6z   $��9��6�   �� 51   
   -   5        $ button_cancel_add��51      $��Cancel��6,   $
��Left=�6=   $	��Top=�6X   $��75��6p   $��333,323,0,0q�6{   $��10��6�   53      54      