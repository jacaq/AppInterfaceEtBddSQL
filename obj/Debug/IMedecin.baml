   M S B A M L   `   `   `  ����F  Btp01_cSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:tp01_cSharptp01_cSharp  5   	       tp01_cSharp.IMedecin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:tp01_cSharp     5   	   -   5          � Title$  Medecin��5   	   $��482.239��6   $��812.09��6*    � WindowStartupLocation$ CenterScreen=�69   .��5	      � $��0,4,-0.4,-4.2q�6   .+�5
   
   �� -   5         ��Name$ lb_titre_preposee��5
      $��Bienvenue médecin��6+   $
��Left=�6G   $��	11,10,0,0q�6b   $	��Top=�6u   $��18(�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGrid_listePatient��5      $
��Left=�62   $	��224��6M   $��	30,60,0,0q�6Z   $	��Top=�6m   $	��755��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�      AutoGenerateColumns .  ��6�   �� z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.166Q�6&   T� 5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 NAS��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *NAS+  5      $ Prénom��6%   	 65   �� *Prenom+  5      $	 Nom��6%   	 62   �� *Nom+  5      $ Adresse��6%   	 66   �� *Adresse_civique+  5      $	 App��6%   	 62   �� *App+  5      $ Ville��6%   	 64   �� *Ville+  5      $ Province��6%   	 67   �� *
Province+  5      $ Code postal��6%   	 6:   �� *Code_postal+  5      $	 Tel��6%   	 62   �� *	Telephone+  5      $ 
Date nais.��6%   	 69   �� *Date_naissance+  5       $ Id ass.��6%   	 66   �� *IDAssurance+5%      �� 5'   
   -   5        $ lb_titre_liste_patient��5'      $��Liste patients��60   $
��Left=�6I   $��
319,38,0,0q�6d   $	��Top=�6x   $��14(�6�   $
��Bold"�6�   �� 5(   
   -   5        
 ��Name$
 btn_Acceuil��5(      $��Retour acceuil��6&   $
��Left=�6?   $��401,355,0,0q�6Z   $	��Top=�6o   $	��303��6�   $��21��6�   �� 5)   
   -   5        $
 btn_donnerConger��5)      $��Donner congé��6+   $
��Left=�6B   $��
91,352,0,0q�6]   $	��Top=�6q   $	��268��6�   $��24��6�   6�   5+      5,      