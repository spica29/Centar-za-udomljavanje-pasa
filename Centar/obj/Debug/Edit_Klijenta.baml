   M S B A M L   `   `   `  ����A  =Centar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CentarCentar  5   	   +    %Edit_Klijenta_namespace.Edit_Klijenta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   &localclr-namespace:Centar     5   	   -   5          � Title$  Edit_Klijenta��5   	   $��312.865��6   $��437.359��60    � 
ResizeMode$ NoResize=�6]    � 	Resources 5         textBoxInError �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value	 �� Self
 �� RelativeSource   Centar.Radnik  data��%�   &	        &	 �     �� 5   
   " ��6'    5      P� 5	       �@=�HasError . . �5
      ��  �@�ToolTip 60   �� *%#(Validation.Errors)[0].ErrorContent+#
 Z	 5      5        5   
   6   5      .��5      � .+�5   
   �� -   5         ��Name$ label_ime_edit��5      $	��Top=�6(   $��30.575,50,0,0q�6@   $
��Left=�6W   $
��Ime:��6r   �� 5   
   -   5        $ label_prezime_edit��5      $	��Top=�6,    J� RenderTransformOrigin$ 
2.036,3.71&�6D   $��30.575,81,0,0q�6g   $
��Left=�6~   $��Prezime:��6�   �� 5   
   -   5        $ label_adresa_edit��5      $	��Top=�6+   $��30.575,112,0,0q�6C   $
��Left=�6[   $��Adresa:��6v   �� 5   
   -   5        $ label_jmb_edit��5      $	��Top=�6(   $ -0.958,-0.329&�6@   $��30.575,19,0,0q�6f   $
��Left=�6}   $
��JMB:��6�   �� 5   
   -   5         ��Name$ textBox_jmb_edit��5      $	��235��6,   $	��Top=�68    �� TextWrapping$
 Wrap=�6P   #��[  6d   $��
174,19,0,0q�6�   $��23��6�   $
��Left=�6�   |�. $��1��6!   � Cursor 6�   �� *%#(Validation.Errors)[0].ErrorContent+ �� ElementName$
 Box1��.��6.  .��5      ��  �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�63    �� Source# [ 6Y    �� Path$	 jmb�6x    �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5      5      �� 5   
   -   5        $ textBox_adresa_edit��5      $	��235��6/   $	��Top=�6;   $
 Wrap=�6S   #��[  6g   $��174,115,0,0q�6�   $��23��6�   $
��Left=�6�   |�. $��5��6%   6�   �� *%#(Validation.Errors)[0].ErrorContent+$
 Box1��.��62  .��5      ��  . $ PropertyChanged=�63   # [ 6Y   $ adresa�6x    5        5       5"      5#      �� 5$   
   -   5        $ textBox_ime_edit��5$      $	��235��6,   $	��Top=�68   $
 Wrap=�6P   #��[  6d   $��
174,50,0,0q�6�   $��23��6�   $
��Left=�6�   |�. $��2��6!   6�   �� *%#(Validation.Errors)[0].ErrorContent+$
 Box1��.��6.  .��5%      ��  . $ PropertyChanged=�63   # [ 6Y   $	 ime�6x    5&        5'      5)      5*      �� 5+   
   -	   5        $ textBox_prezime_edit��5+      $	��235��60   $	��Top=�6<   $
 Wrap=�6T   #��[  6h   $��
174,84,0,0q�6�   $��23��6�   $
��Left=�6�   |�. $��3��6%   6�   �� *%#(Validation.Errors)[0].ErrorContent+$
 Box1��.��62  .��5,      ��  . $ PropertyChanged=�63   # [ 6Y   $ prezime�6x    5-        5.      50      51      �� 52   
   -
   5        $ label_vlasnikPsa��52      $��Vlasnik psa:��6*   $
��Left=�6A   $��
31,143,0,0q�6\   $	��Top=�6p   �� 53   
   -   5         ��Name$ comboBox_vlasnikPsa��53      $
��Left=�60   $	��Top=�6K   $	��235��6c   $��174,147,0,0q�6o   $��6��6�   �� 54   
   -   5        $ label_datumPreuzimanja��54      $��Datum preuzimanja psa:��60   $
��Left=�6Q   $��
31,174,0,0q�6l   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  55   
   -   5          Name$! datePicker_datumPreuzimanja��55      $
��Left=�6:   $	��Top=�6U   $��174,175,0,0q�6m   $	��235��6�   $��7��6�   �� 56   
   -   5         ��Name$ button_edit��56      $
��Edit��6&   $
��Left=�65   $	��Top=�6P   $��75��6h   $��233,229,0,0q�6s   $��8��6�   �� 57   
   -   5        $ button_cancel��57      $��Cancel��6(   $
��Left=�69   $	��Top=�6T   $��75��6l   $��334,229,0,0q�6w   $��9��6�   59      5:      