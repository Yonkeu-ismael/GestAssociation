-- phpMyAdmin SQL Dump
-- version 2.11.2.1
-- http://www.phpmyadmin.net
--
-- Serveur: localhost
-- Généré le : Mer 14 Février 2018 à 17:11
-- Version du serveur: 5.0.45
-- Version de PHP: 5.2.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- Base de données: `bd_tontine`
--

-- --------------------------------------------------------

--
-- Structure de la table `adherent`
--

CREATE TABLE `adherent` (
  `code_adherent` int(15) NOT NULL auto_increment,
  `nom` varchar(20) default NULL,
  `prenom` varchar(20) default NULL,
  `tel` varchar(20) default NULL,
  `adresse` varchar(20) default NULL,
  `sit_mat` varchar(20) default NULL,
  `pays` varchar(20) default NULL,
  `date_naiss` varchar(15) default NULL,
  `email` varchar(20) default NULL,
  `sexe` varchar(10) default NULL,
  `date_adh` varchar(15) default NULL,
  `numCNI` varchar(20) default NULL,
  `photo` blob,
  PRIMARY KEY  (`code_adherent`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=67 ;

--
-- Contenu de la table `adherent`
--

INSERT INTO `adherent` (`code_adherent`, `nom`, `prenom`, `tel`, `adresse`, `sit_mat`, `pays`, `date_naiss`, `email`, `sexe`, `date_adh`, `numCNI`, `photo`) VALUES
(44, 'YONKEU', 'ISMAEL', '670729671', 'Tonga', 'Célibataire', '    Dhekelia', '20/07/1997', 'ismaelyonkeu', 'Masculin', '24/08/2017', '2153650', ''),
(53, 'YONSE', 'Didi Bertrand', '675331245', 'Yaoundé', 'Marié(e)', '    Canada', '22/09/1989', 'didiyon', 'Masculin', '22/09/2017', '10452367', ''),
(57, 'YAMSI', 'Christian', '62101366', 'Yaoundé', 'Veuve', '    Chine', '23/09/1982', 'cyamsi', 'Feminin', '23/09/2017', '120003', ''),
(58, 'TANKOUA', 'Listone', '678132017', 'Tonga', 'Célibataire', '    Cameroun', '25/03/2000', 'tanlistone', 'Feminin', '23/09/2017', '000215', ''),
(59, 'NZOUNGUE', 'Cecile', '679285295', 'Tonga', 'Marié(e)', '    Cameroun', '23/09/1976', 'cecilenzoungue', 'Feminin', '23/09/2017', '0001245', ''),
(60, 'BIKA', 'Peniel', '67012569', 'Bahoc', 'Célibataire', '    Cameroun', '04/01/1999', 'peniel', 'Feminin', '09/10/2017', '00001214', ''),
(61, 'GAHANE', 'PAMELA', '6213524556', 'quartier 6', 'Célibataire', '    Cameroun', '24/11/2017', 'pamelagahane', 'Feminin', '26/11/2017', '0001245', ''),
(64, 'aaaa', 'aaa', '444554', 'qsdd', 'Célibataire', '    Cameroun', '06/02/2018', 'dddddd', 'Masculin', '06/02/2018', '54455474', ''),
(65, 'aaaa', 'aaaa', '514544', 'efsqfsa', 'Célibataire', '    Cameroun', '07/02/2018', 'dzsq', 'Masculin', '07/02/2018', '1545', ''),
(66, 'aaaa', 'aaaa', '545456', ',dbzaddq', 'Célibataire', '    Argentine', '22/02/2018', 'szqdx', 'Masculin', '14/02/2018', '524', '');

-- --------------------------------------------------------

--
-- Structure de la table `appartenir`
--

CREATE TABLE `appartenir` (
  `code_appartenir` int(15) NOT NULL auto_increment,
  `code_cycle` int(15) NOT NULL,
  `code_tontine` int(15) NOT NULL,
  `nbre_part` int(15) NOT NULL,
  `code_adherent` int(15) NOT NULL,
  `rang` int(11) default NULL,
  PRIMARY KEY  (`code_appartenir`),
  KEY `code_appartenir` (`code_appartenir`),
  KEY `code_cycle` (`code_cycle`),
  KEY `code_tontine` (`code_tontine`),
  KEY `code_adherent` (`code_adherent`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=55 ;

--
-- Contenu de la table `appartenir`
--

INSERT INTO `appartenir` (`code_appartenir`, `code_cycle`, `code_tontine`, `nbre_part`, `code_adherent`, `rang`) VALUES
(35, 16, 6, 2, 57, NULL),
(36, 16, 8, 3, 57, NULL),
(37, 15, 5, 1, 58, NULL),
(38, 15, 7, 2, 58, NULL),
(39, 16, 6, 2, 58, NULL),
(40, 16, 8, 1, 58, NULL),
(41, 15, 5, 1, 59, NULL),
(42, 15, 7, 3, 59, NULL),
(43, 16, 6, 3, 59, NULL),
(45, 15, 5, 2, 61, NULL),
(47, 16, 6, 1, 44, 9),
(48, 16, 8, 2, 44, 5),
(49, 16, 6, 3, 53, 4),
(50, 16, 8, 1, 53, 6),
(51, 16, 6, 2, 60, 5),
(52, 18, 6, 2, 64, 1),
(53, 16, 6, 2, 65, 5),
(54, 16, 5, 2, 66, 15);

-- --------------------------------------------------------

--
-- Structure de la table `compte`
--

CREATE TABLE `compte` (
  `id_compte` int(11) NOT NULL auto_increment,
  `libelle` varchar(30) default NULL,
  `description` varchar(50) default NULL,
  PRIMARY KEY  (`id_compte`),
  KEY `numero` (`libelle`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Contenu de la table `compte`
--

INSERT INTO `compte` (`id_compte`, `libelle`, `description`) VALUES
(2, 'Cotisation', 'Cotisation ordinaire'),
(3, 'Epargne', ''),
(4, 'Sanction', 'Pour absence'),
(5, 'dons', 'aaaaa');

-- --------------------------------------------------------

--
-- Structure de la table `cycle`
--

CREATE TABLE `cycle` (
  `code_cycle` int(50) NOT NULL auto_increment,
  `lib_cycle` varchar(50) default NULL,
  `date_debut` varchar(15) default NULL,
  `date_fin` varchar(15) default NULL,
  PRIMARY KEY  (`code_cycle`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=23 ;

--
-- Contenu de la table `cycle`
--

INSERT INTO `cycle` (`code_cycle`, `lib_cycle`, `date_debut`, `date_fin`) VALUES
(15, '6 mois', '10/12/2017', '12/11/2018'),
(16, '12 mois', '27/04/2018', '06/08/2017'),
(18, '1 an', '07/08/2017', '07/08/2017'),
(20, '7 mois', '06/02/2018', '06/08/2018'),
(21, '3 mois', '07/02/2018', '07/05/2018'),
(22, '5 mois', '07/02/2018', '07/07/2018');

-- --------------------------------------------------------

--
-- Structure de la table `groupe`
--

CREATE TABLE `groupe` (
  `code_groupe` int(15) NOT NULL auto_increment,
  `libelle` text,
  PRIMARY KEY  (`code_groupe`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `groupe`
--

INSERT INTO `groupe` (`code_groupe`, `libelle`) VALUES
(1, 'Secretaire'),
(2, 'president');

-- --------------------------------------------------------

--
-- Structure de la table `inscrire`
--

CREATE TABLE `inscrire` (
  `code_inscrire` int(15) NOT NULL auto_increment,
  `code_adherent` int(15) NOT NULL,
  `code_cycle` int(15) NOT NULL,
  PRIMARY KEY  (`code_inscrire`),
  KEY `code_adherent` (`code_adherent`),
  KEY `code_cycle` (`code_cycle`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Contenu de la table `inscrire`
--

INSERT INTO `inscrire` (`code_inscrire`, `code_adherent`, `code_cycle`) VALUES
(1, 44, 16),
(2, 53, 16),
(3, 57, 16),
(4, 58, 15),
(5, 59, 15),
(6, 44, 15),
(7, 58, 18),
(8, 57, 16),
(9, 44, 16),
(10, 58, 21),
(11, 61, 21),
(12, 61, 22),
(13, 44, 16);

-- --------------------------------------------------------

--
-- Structure de la table `objets`
--

CREATE TABLE `objets` (
  `code_objet` int(15) NOT NULL auto_increment,
  `libelle` text,
  `type_objet` varchar(30) default NULL,
  `valeur_origine` text,
  `date_acqui` varchar(15) default NULL,
  `etat` text,
  `prix_location` double default NULL,
  PRIMARY KEY  (`code_objet`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `objets`
--

INSERT INTO `objets` (`code_objet`, `libelle`, `type_objet`, `valeur_origine`, `date_acqui`, `etat`, `prix_location`) VALUES
(1, 'bache', 'matériel', '500000', '13/09/2017', 'bonne', 10000),
(2, 'chaises', 'matériel', '5000', '21/11/2017', 'bonne', 200);

-- --------------------------------------------------------

--
-- Structure de la table `operation`
--

CREATE TABLE `operation` (
  `code_operation` int(20) NOT NULL auto_increment,
  `code_adherent` int(11) default NULL,
  `id_compte` int(11) default NULL,
  `code_cycle` int(20) default NULL,
  `date_op` varchar(20) default NULL,
  `montant_payer` double default NULL,
  `date_effe_op` varchar(20) default NULL,
  PRIMARY KEY  (`code_operation`),
  KEY `code_cycle` (`code_cycle`),
  KEY `id_compte` (`id_compte`),
  KEY `code_adherent` (`code_adherent`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

--
-- Contenu de la table `operation`
--

INSERT INTO `operation` (`code_operation`, `code_adherent`, `id_compte`, `code_cycle`, `date_op`, `montant_payer`, `date_effe_op`) VALUES
(1, NULL, 2, 16, '14/02/2018', 15000, '23/02/2018'),
(2, NULL, 3, 16, '06/02/2018', 10000, '09/02/2018'),
(3, NULL, 2, 15, '06/02/2018', 12000, '16/02/2018'),
(5, 53, 3, 16, '03/02/2018', 30000, '05/02/2018'),
(7, 61, 3, 16, '06/02/2018', 25000, '07/02/2018'),
(8, 44, 2, 16, '06/02/2018', 1600, '06/02/2018'),
(11, 44, 3, 18, '07/02/2018', 1222, '08/02/2018'),
(12, 57, 2, 16, '07/02/2018', 5454, '07/02/2018'),
(13, 53, 2, 16, '07/02/2018', 5454, '07/02/2018'),
(14, 57, 2, 16, '07/02/2018', 1000, '07/02/2018'),
(15, 61, 4, 18, '07/02/2018', 1000, '15/02/2018'),
(16, 60, 2, 20, '07/02/2018', 154500, '07/02/2018'),
(17, 57, 2, 22, '07/02/2018', 1000, '07/02/2018');

-- --------------------------------------------------------

--
-- Structure de la table `planification`
--

CREATE TABLE `planification` (
  `code_pla` int(15) NOT NULL auto_increment,
  `code_adherent` int(15) default NULL,
  `code_cycle` int(15) default NULL,
  `date` varchar(30) default NULL,
  `montant` double default NULL,
  PRIMARY KEY  (`code_pla`),
  KEY `code_cycle` (`code_cycle`),
  KEY `code_adherent` (`code_adherent`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `planification`
--

INSERT INTO `planification` (`code_pla`, `code_adherent`, `code_cycle`, `date`, `montant`) VALUES
(1, 59, 16, 'lundi 30 octobr', 10000),
(2, 44, 16, 'mercredi 18 oct', 12000),
(3, 61, 16, '06/02/2018', 250000),
(4, 53, 16, '22/02/2018', 15000),
(5, 53, 20, '14/02/2018', 10000),
(6, 53, 18, '08/02/2018', 100000),
(7, 59, 16, '22/02/2018', 15000),
(8, 60, 18, '22/02/2018', 10000),
(9, 59, 21, '07/02/2018', 100000),
(10, 57, 22, '22/02/2018', 10000),
(11, 44, 16, '15/02/2018', 25000);

-- --------------------------------------------------------

--
-- Structure de la table `reunion`
--

CREATE TABLE `reunion` (
  `id_reunion` int(11) NOT NULL auto_increment,
  `lieu_reunion` text,
  `date_reunion` varchar(15) default NULL,
  `presence` varchar(15) default NULL,
  PRIMARY KEY  (`id_reunion`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Contenu de la table `reunion`
--

INSERT INTO `reunion` (`id_reunion`, `lieu_reunion`, `date_reunion`, `presence`) VALUES
(2, 'marché centralg', '31/08/2017', '1000'),
(4, 'mokolo', '10/08/2017', '2000'),
(5, 'messassi', '10/08/2017', '3000'),
(9, 'vetko', '20/09/2017', '1000'),
(10, 'Quartier 12', '17/03/2018', '1000');

-- --------------------------------------------------------

--
-- Structure de la table `tontine`
--

CREATE TABLE `tontine` (
  `code_tontine` int(15) NOT NULL auto_increment,
  `libelle` text NOT NULL,
  `montant` double NOT NULL,
  PRIMARY KEY  (`code_tontine`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Contenu de la table `tontine`
--

INSERT INTO `tontine` (`code_tontine`, `libelle`, `montant`) VALUES
(5, 'Femme sincères ', 20000),
(6, 'Emergence', 15000),
(7, 'Femme élite de Tonga', 10000),
(8, 'Jeunes ressortissants de Tonga ', 25000),
(11, 'istec', 1500),
(12, 'ASSO ISTEC', 1000);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id_utilisateur` int(15) NOT NULL auto_increment,
  `nom` varchar(30) default NULL,
  `prenom` varchar(30) default NULL,
  `compte` varchar(30) default NULL,
  `mot_de_passe` varchar(100) default NULL,
  PRIMARY KEY  (`id_utilisateur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id_utilisateur`, `nom`, `prenom`, `compte`, `mot_de_passe`) VALUES
(8, 'user1', 'user', 'user', '24c9e15e52afc47c225b757e7bee1f9d'),
(9, 'user2', 'user2', 'user2', '92877af70a45fd6a2ed7fe81e1236b78'),
(10, 'qqqq', 'ssss', 'aa', '25ed1bcb423b0b7200f485fc5ff71c8e');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `appartenir`
--
ALTER TABLE `appartenir`
  ADD CONSTRAINT `appartenir_ibfk_1` FOREIGN KEY (`code_cycle`) REFERENCES `cycle` (`code_cycle`),
  ADD CONSTRAINT `appartenir_ibfk_2` FOREIGN KEY (`code_tontine`) REFERENCES `tontine` (`code_tontine`),
  ADD CONSTRAINT `appartenir_ibfk_3` FOREIGN KEY (`code_adherent`) REFERENCES `adherent` (`code_adherent`);

--
-- Contraintes pour la table `inscrire`
--
ALTER TABLE `inscrire`
  ADD CONSTRAINT `inscrire_ibfk_1` FOREIGN KEY (`code_adherent`) REFERENCES `adherent` (`code_adherent`),
  ADD CONSTRAINT `inscrire_ibfk_2` FOREIGN KEY (`code_cycle`) REFERENCES `cycle` (`code_cycle`);

--
-- Contraintes pour la table `operation`
--
ALTER TABLE `operation`
  ADD CONSTRAINT `operation_ibfk_4` FOREIGN KEY (`code_adherent`) REFERENCES `adherent` (`code_adherent`),
  ADD CONSTRAINT `operation_ibfk_2` FOREIGN KEY (`code_cycle`) REFERENCES `cycle` (`code_cycle`),
  ADD CONSTRAINT `operation_ibfk_3` FOREIGN KEY (`id_compte`) REFERENCES `compte` (`id_compte`);

--
-- Contraintes pour la table `planification`
--
ALTER TABLE `planification`
  ADD CONSTRAINT `planification_ibfk_1` FOREIGN KEY (`code_cycle`) REFERENCES `cycle` (`code_cycle`),
  ADD CONSTRAINT `planification_ibfk_2` FOREIGN KEY (`code_adherent`) REFERENCES `adherent` (`code_adherent`);
