   M S B A M L   `   `   `  ����A  =Centar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CentarCentar  5   	   !    Edit_psa_namespace.Edit_Psa   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   &localclr-namespace:Centar     5   	   -   5          � Title$  Edit_Psa��5   	   $��373.134��6   $��432.835��6+    � 
ResizeMode$ NoResize=�6X    � 	Resources 5         ComboBoxInError �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value	 �� Self
 �� RelativeSource   
Centar.Pas  data��%�   &	        &	 �     �� 5   
   " ��6(    5      P� 5	       �@=�HasError . . �5
      ��  �@�ToolTip 60   �� *%#(Validation.Errors)[0].ErrorContent+#
 Z	 5      5        5   
   6   5      .��5      � -   5        $��0,0,2,6q�5      .+�5   
   �� -   5         ��Name$ label_id_psa_add��5      $	��Top=�6*   $��	41,46,0,0q�6B   $
��Left=�6U   $	��Id:��6p   �� 5   
   -   5        $" label_zdravstveno_stanje_add��5      $	��Top=�66   $��	41,77,0,0q�6N   $
��Left=�6a   $��Zdravstveno stanje:��6|   �� 5   
   -   5        $ label_datumCipiranja_add��5      $	��Top=�62   $��
41,108,0,0q�6J   $
��Left=�6^   $��Datum cipiranja:��6y   �� 5   
   -   5        $ label_datumRodjenja_add��5      $	��Top=�61   $��
41,139,0,0q�6I   $
��Left=�6]   $��Datum rodjenja:��6x   �� 5   
   -   5        $ label_stats_add��5      $	��Top=�6)   $��
41,170,0,0q�6A   $
��Left=�6U   $��Status:��6p   �� 5   
   -   5        $ label_sterilizovan_add��5      $	��Top=�60   $��
41,201,0,0q�6H   $
��Left=�6\   $��Sterilizovan:��6w   �� 5   
   -	   5        $" label_datumSterilizacije_add��5      $	��Top=�66   $��
41,232,0,0q�6N   $
��Left=�6b   $��Datum sterilizacije:��6}   �� 5   
   -
   5         ��Name$ textBox_idPsa_add��5      $	��211��6-   $	��Top=�69    �� TextWrapping$
 Wrap=�6Q   $��
197,46,0,0q�6e   $��23��6y   $
��Left=�6�   $��1��6�   �� 5   
   -   5         ��Name$ ComboBox_zdrStanje_add��5      |�. #��[  6D   $
��Left=�6�   $	��Top=�6�   $	��211��6�   $��
197,81,0,0q�6�   $��2��6   � Cursor 6m   ��  �� ElementName$
 Box1�� �� Path$) #(Validation.Errors)[0].ErrorContent� �� Text 5      �� 5      $ zdravstvenoStanje�6    �� Source# [ 63    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6o    �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5       5"      (  "System.Windows.Controls.DatePicker  6   -   5          Name$! datePicker_datCipiranja_add��5"       $	��211��6E   $	��Top=�6Q   $��197,110,0,0q�6i   $
��Left=�6~   $��3��6�     5#   
   -   5        $ datePicker_datRodj_add��5#      $	��211��65   $	��Top=�6A   $��197,141,0,0q�6Y   $
��Left=�6n   $��4��6�     5$   
   -   5        $ datePicker_datSter_add��5$      $	��211��65   $	��Top=�6A   $��197,234,0,0q�6Y   $
��Left=�6n   $��8��6�   �� 5%   
   -   5        $ comboBox_status_add��5%      $	��211��60   $	��Top=�6<   #��[  6T   $��197,174,0,0q�6}   $
��Left=�6�   |�. $��5��6   6�   �� *%#(Validation.Errors)[0].ErrorContent+$
 Box1�� 5&      �� 5'       . $ PropertyChanged=�67   # [ 6]   $ status�6|    5(        5)      5+      5-      	� 5.   
   -   5         	�Name$ radioButton_da_add��5.      $	��Top=�62   $��197,207,0,0q�6J   $
��Left=�6_   $��Da��6z   $��6��6�   	� 5/   
   -   5        $ radioButton_ne_add��5/      $	��Top=�62   $��323,207,0,0q�6J   $
��Left=�6_   $��Ne��6z   $��7��6�   �� 50   
   -   5         ��Name$ 
buttonEdit��50      $
��Edit��6%   $
��Left=�64   $	��Top=�6O   $��75��6g   $��221,294,0,0q�6r   $��9��6�   �� 51   
   -   5        $ buttonCancel��51      $��Cancel��6'   $
��Left=�68   $	��Top=�6S   $��75��6k   $��333,294,0,0q�6v   $��10��6�   �� 52   
   -   5        $ buttonKamera��52      $��Kamera��6'   $
��Left=�68   $��
27,294,0,0q�6S   $	��Top=�6g   $��75��6   6�   54      55      