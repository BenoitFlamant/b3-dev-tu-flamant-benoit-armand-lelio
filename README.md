# b3-dev-tu-flamant-benoit-armand-lelio

Documentation Projet TU


Environnement de travail

Nous avons choisi le langage C# pour réaliser le projet, car nous avions l’habitude de travailler avec ce langage, sur le logiciel Visual Studio qui facilite les modifications Git et car il permet d’utiliser xUnit pour réaliser les tests Unitaires.

Déroulé des ‘commits’ sur GitHub

Nous avons choisi de découper le projet en deux parties, la première, gérée par Benoît est celle en BDD pour les fonctions arithmétiques avec comme ‘commit’ les fonctions puis les tests.
La deuxième partie, gérée par Lelio concerne le TDD sur les fonctions scientifiques de la calculatrice avec comme ‘commit’ les tests unitaires puis les fonctions basées sur ces tests.

Enfin, une fois les tests réussis et les méthodes de calcul fonctionnelles, nous avons ‘commit’ la version finale du programme principal, permettant l’utilisation de ces fonctions.

Utilisation de l’application

Une fois le fichier Program.cs exécuté, la console fournit une liste de choix de méthode de calcul, on entre le numéro correspondant à la méthode voulue et le programme demande ensuite d’entrée 1 ou 2 nombre en fonction de ce que l’on a choisi précédemment. Enfin, le programme nous retourne le résultat attendu.

Pour l’exécution des tests il faudra passer par Visual Studio (à moins que d’autre IDE implémentent aussi xUnit)
Ensuite il faudra afficher la fenêtre d’explorateur de tests (Affichage > Explorateur de tests, sur Visual Studio) et il suffit de lancer l’exécution du programme de tests pour voir le retour dans la fenêtre mentionnée plus avant.
Il est ensuite possible d’exécuter ces tests séparément en cliquant sur l’icône ronde sous l’argument “Facts” de chaque type de test.
