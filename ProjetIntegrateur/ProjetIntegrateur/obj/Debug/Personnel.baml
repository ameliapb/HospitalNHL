   M S B A M L   `   `   `  ����L  HProjetIntegrateur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjetIntegrateurProjetIntegrateur  5   	   !    ProjetIntegrateur.Personnel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjetIntegrateur     5   	   -   5          � Title$  Administration��5   	   $��403.75��6    $��852.5��60    � WindowStartupLocation$ CenterScreen=�6U   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��395* �6   �� 5      .+�5   
   �� -   5        $��btnModif��5      $��Modifier un médecin��6!   $
��Left=�6@   $��
17,131,0,0q�6[   $	��Top=�6o   $	��186��6�   $��41��6�   �� 5   
   -   5        $��btnSupp��5      $��Supprimer un médecin��6    $
��Left=�6@   $��
17,189,0,0q�6[   $	��Top=�6o   $	��186��6�   $��41��6�   �� 5   
   -   5        $��
btnQuitter��5      $��Quitter��6#   $
��Left=�66   $��
17,245,0,0q�6Q   $	��Top=�6e   $	��186��6}   $��41��6�   �� 5   
   -   5         ��Name$ 	groupBox2��5      $��Liste Des Médecins��6&   $
��Left=�6B   $	��255��6]   $��
227,73,0,0q�6j   $	��Top=�6~   $	��598��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dgMedecin��5      $
��Left=�6%   $	��190��6@   $��244,112,0,0q�6M   $	��Top=�6b   $	��552��6z   6�   �� 5   
   -   5         ��Name$ btnConsulation��5      $��Tableau de Consultation��6)   
�������$
��Left=�6c   $��
523,10,0,0q�6~   $	��Top=�6�   $	��299��6�   $��	Bodoni MT)�6�   $��22(�6�   $��45��6�    J� RenderTransformOrigin$ 0.5,0.5&�6  z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.096Q�6&   T� 5      5      5      �� 5   
   -   5        $ btnAjout��5      $��Ajouter un médecin��6#   $
��Left=�6A   $��	17,76,0,0q�6\   $	��Top=�6o   $	��186��6�   $��40��6�   �� 5   
   -	   5         ��Name$ gridSplitter��5      $
��Left=�6-   $��209,-2,0,-17q�6H   $��5��6^   $	��392��6h   $	��Top=�6u   5       5!      