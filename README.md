# MediaTekDocuments

Ce dépôt contient l'évolution de l'application de bureau MediaTekDocuments.
Le dépôt d'origine avec la présentation de l'application de base est disponible ici : [lien vers le dépôt d'origine]

## Fonctionnalités ajoutées

### Gestion des commandes de livres et DVD
- Recherche d'un livre ou DVD par numéro
- Affichage de la liste des commandes triée par date
- Ajout d'une nouvelle commande
- Modification de l'étape de suivi (en cours, relancée, livrée, réglée)
- Suppression d'une commande non livrée

### Gestion des commandes de revues
- Recherche d'une revue par numéro
- Affichage de la liste des abonnements
- Ajout d'un nouvel abonnement
- Suppression d'un abonnement

### Authentification
- Fenêtre de connexion au démarrage
- Gestion des droits selon le service de l'utilisateur

## Mode opératoire pour installer et utiliser l'application en local

### Prérequis
- Visual Studio 2022
- WampServer
- NetBeans

### Installation
1. Cloner ce dépôt
2. Ouvrir `MediaTekDocuments.sln` dans Visual Studio
3. Installer l'API REST : cloner le dépôt `rest_mediatekdocuments` dans `www` de WampServer
4. Créer la BDD `mediatek86` dans phpMyAdmin et importer `mediatek86.sql`
5. Lancer l'application depuis Visual Studio
6. Se connecter avec `admin` / `adminpwd`
