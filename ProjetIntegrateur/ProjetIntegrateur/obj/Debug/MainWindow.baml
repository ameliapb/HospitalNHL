   M S B A M L   `   `   `  ����L  HProjetIntegrateur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjetIntegrateurProjetIntegrateur  5   	   "    ProjetIntegrateur.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjetIntegrateur     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  Accueil��5   	    � Title$ Accueil��5	   	   $��459.743��6   $��981.802��6*    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�5   	   .��5      � -   5         �Name$
 nomU��5      $��	0,0,0,-64q�6   ��5   
   �� 5       �� ImageSource$ images/hopitalNLH.jpg��6    � RowDefinitions 5   
   �� 5      �� 5      $��0* �6    � ColumnDefinitions 5   
   �� 5      $
��455* �6   �� 5      $
��394* �6   .+�5   
   �� -   5        	 ��Name$
	 font��5      $��Identification��6!   $
��Left=�69   $	��298��6T   $��288,107,0,0q�6a   $	��Top=�6v   $	��435��6�   $��	Bodoni MT)�6�   $��24(�6�   $��2��6�   
 J� Opacity$

 0.88Q�6�   #��� ��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   $��Utilisateur��6   $
��Left=�6&   $��333,197,0,0q�6A   $	��Top=�6V   $	��153��6n   $��	Bodoni MT)�6z   $��16(�6�   $��31��6�   �� 5   
   $��Mot de Passe��6   $
��Left=�6'   $��310,264,0,0q�6B   $	��Top=�6W   $	��153��6o   $��	Bodoni MT)�6{   $��16(�6�   $��31��6�   �� 5    
   -   5         ��Name$ 
btnValider��5       $��Valider��6%   $
��Left=�67   $��394,341,0,0q�6R   $	��Top=�6g   $	��106��6   $��	Bodoni MT)�6�   $��16(�6�   $��30��6�    J� RenderTransformOrigin$ 0.512,0.768&�6�   �� 5!   
   -   5        $ 
btnQuitter��5!      $��Quitter��6%   $
��Left=�67   $��
22,341,0,0q�6R   $	��Top=�6f   $	��142��6~   $��	Bodoni MT)�6�   $��16(�6�   $��30��6�   $��1��6�   �� 5"   
   -   5         ��Name$ txtUser��5"      $
��Left=�6$   $��490,197,0,0q�6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Choississez votre identifiant��6U   $	��Top=�6�   $	��173��6�   $��31��6�   $��2��6�   .@�5#      �� $��Admin��6   �� 5$      $��Medecin��6   �� 5%      $��	Préposé��6   5&      G� 5'   
   -   5         G�Name$ 
txtmotPass��5'      $
��Left=�6*   $��492,258,0,0q�6E   $	��Top=�6Z   $	��169��6r   $��31��6~   $��2��6�   5)      5*      