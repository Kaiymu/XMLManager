- Ouvrir la sc�ne "ExempleXMLScene"
- Allez dans le dossier StreamingAssets/XML/
- Lancer la sc�ne. 
- Le fichier "XMLExemple" se cr�er. (Il faut parfois r�duire Unity et le remettre en avant pour que le fichier s'affiche,
il n'y a pas de raffraichissement automatique)

Le fichier peut-�tre manipul� dans "XMLUseExemple"

Tout les scripts sont contenus dans /scripts
XMLUeExemple �tends de XMLLoadRead

XMLUseExemple permet l'impl�mentation des m�thode permettant de "load" (Charger, et lire un fichier XML)
Et de save (Modifi� et sauvegarder le fichier en questiton).

Ce script doit �tre pr�sent sur la sc�ne de jeu (Drag'n'drop sur un objet pr�sent dedans, sinon les m�thods ne sont pas 
lues). Dans ma sc�ne il est d�j� pr�sent sur la cam�ra, pas besoin de le mettre 2 fois.

Le chemin ainsi que le nom du fichier peuvent �tre changer si besoin dans les param�tres du script en public (Sur ma sc�ne,
il faut cliquer sur la cam�ra et regarde le script)

Path = Chemin ou le fichier vas-�tre cherch�, s'il n'est pas trouv� il sera cr�er � cet endroit.
File name = Nom du fichier � cherch� dans le path, s'il n'est pas trouv�, cr�er le fichier avec ce nom.


