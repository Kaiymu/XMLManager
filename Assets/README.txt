- Ouvrir la scène "ExempleXMLScene"
- Allez dans le dossier StreamingAssets/XML/
- Lancer la scène. 
- Le fichier "XMLExemple" se créer. (Il faut parfois réduire Unity et le remettre en avant pour que le fichier s'affiche,
il n'y a pas de raffraichissement automatique)

Le fichier peut-être manipulé dans "XMLUseExemple"

Tout les scripts sont contenus dans /scripts
XMLUeExemple étends de XMLLoadRead

XMLUseExemple permet l'implémentation des méthode permettant de "load" (Charger, et lire un fichier XML)
Et de save (Modifié et sauvegarder le fichier en questiton).

Ce script doit être présent sur la scène de jeu (Drag'n'drop sur un objet présent dedans, sinon les méthods ne sont pas 
lues). Dans ma scène il est déjà présent sur la caméra, pas besoin de le mettre 2 fois.

Le chemin ainsi que le nom du fichier peuvent être changer si besoin dans les paramètres du script en public (Sur ma scène,
il faut cliquer sur la caméra et regarde le script)

Path = Chemin ou le fichier vas-être cherché, s'il n'est pas trouvé il sera créer à cet endroit.
File name = Nom du fichier à cherché dans le path, s'il n'est pas trouvé, créer le fichier avec ce nom.


