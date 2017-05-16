<?php include("includes/db.php"); ?>
<?php session_start(); ?>
<!-- Header -->
<?php include("includes/header.php"); ?>
<?php
-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Erstellungszeit: 03. Jun 2016 um 20:24
-- Server Version: 5.5.34
-- PHP-Version: 5.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `YSQL6`
--
--
-- Datenbank: `addressbook`
--
--
-- Datenbank: `bestelldatenbank`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel`
--

CREATE TABLE IF NOT EXISTS `artikel` (
  `anr` int(11) NOT NULL AUTO_INCREMENT,
  `gnr` int(11) NOT NULL,
  `name` varchar(30) DEFAULT NULL,
  `preis` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`anr`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Daten für Tabelle `artikel`
--

INSERT INTO `artikel` (`anr`, `gnr`, `name`, `preis`) VALUES
(1, 2, 'Stehlampe', '19.90'),
(3, 2, 'Klemmlampe', '9.90'),
(4, 2, 'Gl', '1.65'),
(5, 2, 'Gl', '1.50'),
(6, 2, 'Gl', '1.85'),
(7, 2, 'Gl', '2.11');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellungen`
--

CREATE TABLE IF NOT EXISTS `bestellungen` (
  `bnr` int(11) NOT NULL AUTO_INCREMENT,
  `knr` int(11) NOT NULL,
  `bdat` date DEFAULT NULL,
  `versand` decimal(6,2) DEFAULT NULL,
  `mwstsatz` float DEFAULT NULL,
  PRIMARY KEY (`bnr`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Daten für Tabelle `bestellungen`
--

INSERT INTO `bestellungen` (`bnr`, `knr`, `bdat`, `versand`, `mwstsatz`) VALUES
(1, 1, '2014-01-05', '12.00', 0.2),
(2, 2, '2014-01-07', '20.00', 0.2),
(3, 3, '2014-01-08', '10.00', 0.2),
(4, 1, '2014-01-11', '10.00', 0.2),
(5, 4, '2014-01-13', '22.00', 0.2),
(6, 5, '2014-01-14', '12.00', 0.2),
(7, 2, '2014-01-15', '10.00', 0.2),
(8, 6, '2014-01-21', '20.00', 0.2);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `gruppen`
--

CREATE TABLE IF NOT EXISTS `gruppen` (
  `gnr` int(11) NOT NULL AUTO_INCREMENT,
  `gruppe` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`gnr`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Daten für Tabelle `gruppen`
--

INSERT INTO `gruppen` (`gnr`, `gruppe`) VALUES
(1, 'Farben'),
(2, 'Beleuchtung'),
(3, 'Werkzeug'),
(4, 'Werkstoff'),
(5, 'Holz');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunden`
--

CREATE TABLE IF NOT EXISTS `kunden` (
  `knr` int(11) NOT NULL AUTO_INCREMENT,
  `firma` varchar(20) NOT NULL,
  `firma2` varchar(20) DEFAULT NULL,
  `strasse` varchar(20) DEFAULT NULL,
  `plz` varchar(8) DEFAULT NULL,
  `ort` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`knr`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Daten für Tabelle `kunden`
--

INSERT INTO `kunden` (`knr`, `firma`, `firma2`, `strasse`, `plz`, `ort`) VALUES
(1, 'Behrens', 'Haushaltsbedarf', 'Elbstrasse 22', '21234', 'Hamburg'),
(2, 'Martens', 'Werkzeuge', 'Hafenstr. 45', '31232', 'Hamburg'),
(3, 'Schmidt', '', 'Blumenstr. 1', '20123', 'Hamburg'),
(4, 'Schmied', 'Haushaltsbedarf', 'Rathausmarkt 4', '22312', 'Hamburg'),
(5, 'Schmitt', 'Elektroger', 'Mittelweg 99', '90123', 'Hamburg'),
(6, 'Jahnke', 'Electroartikel', 'Buchenstr. 3', '11123', 'Hamburg');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `positionen`
--

CREATE TABLE IF NOT EXISTS `positionen` (
  `bnr` int(11) NOT NULL,
  `anr` int(11) NOT NULL,
  `anzahl` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `positionen`
--

INSERT INTO `positionen` (`bnr`, `anr`, `anzahl`) VALUES
(1, 1, 5),
(1, 3, 6),
(1, 4, 15),
(1, 9, 1),
(2, 1, 5),
(2, 5, 1),
(3, 1, 10),
(3, 6, 3),
(4, 13, 2),
(4, 11, 5),
(5, 18, 4),
(5, 10, 2),
(5, 8, 1),
(6, 7, 5),
(6, 17, 15),
(7, 5, 3),
(7, 20, 1),
(7, 16, 8),
(7, 4, 10),
(7, 14, 5),
(8, 2, 3),
(8, 12, 6),
(8, 9, 2),
(8, 10, 1),
(8, 1, 1),
(8, 19, 5),
(8, 13, 10),
(8, 18, 2);
--
-- Datenbank: `cdcol`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `cds`
--

CREATE TABLE IF NOT EXISTS `cds` (
  `titel` varchar(200) COLLATE latin1_general_ci DEFAULT NULL,
  `interpret` varchar(200) COLLATE latin1_general_ci DEFAULT NULL,
  `jahr` int(11) DEFAULT NULL,
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci AUTO_INCREMENT=7 ;

--
-- Daten für Tabelle `cds`
--

INSERT INTO `cds` (`titel`, `interpret`, `jahr`, `id`) VALUES
('Beauty', 'Ryuichi Sakamoto', 1990, 1),
('Goodbye Country (Hello Nightclub)', 'Groove Armada', 2001, 4),
('Glee', 'Bran Van 3000', 1997, 5);
--
-- Datenbank: `cms`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `categories`
--

CREATE TABLE IF NOT EXISTS `categories` (
  `cat_id` int(3) NOT NULL AUTO_INCREMENT,
  `cat_title` varchar(255) NOT NULL,
  PRIMARY KEY (`cat_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Daten für Tabelle `categories`
--

INSERT INTO `categories` (`cat_id`, `cat_title`) VALUES
(1, 'Bootstrap'),
(9, 'Java'),
(10, 'Perl'),
(11, 'I Love PHP'),
(12, 'RubyOnRails'),
(13, 'Test');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `comments`
--

CREATE TABLE IF NOT EXISTS `comments` (
  `comment_id` int(4) NOT NULL AUTO_INCREMENT,
  `comment_post_id` int(3) NOT NULL,
  `comment_date` date NOT NULL,
  `comment_author` varchar(255) NOT NULL,
  `comment_email` varchar(255) NOT NULL,
  `comment_content` text NOT NULL,
  `comment_status` varchar(255) NOT NULL,
  PRIMARY KEY (`comment_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=24 ;

--
-- Daten für Tabelle `comments`
--

INSERT INTO `comments` (`comment_id`, `comment_post_id`, `comment_date`, `comment_author`, `comment_email`, `comment_content`, `comment_status`) VALUES
(1, 1, '2016-03-03', 'the_author', 'author@test.net', 'Damit Ihr indess erkennt, woher dieser ganze Irrthum gekommen ist, und weshalb man die Lust anklagt und den Schmerz lobet, so will ich Euch Alles eröffnen und auseinander setzen, was jener Begründer der Wahrheit und gleichsam Baumeister des glücklichen Lebens selbst darüber gesagt hat. Niemand, sagt er, verschmähe, oder hasse, oder fliehe die Lust als solche, sondern weil grosse Schmerzen ihr folgen, wenn man nicht mit Vernunft ihr nachzugehen verstehe. Ebenso werde der Schmerz als solche', 'controlled'),
(20, 5, '2016-03-07', 'Somebody', 'somebody@som.com', 'At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.', 'controlled'),
(22, 3, '2016-03-07', 'testi', 'testi@test.ts', 'pjnpjac pÃ¶ljadsc Ã¶asdjkcnpounasdv Ã¶jasndco asdcvpopo,o,.o,pÃ¶o,pÃ¶imaioÃ¶malsdn', 'controlled'),
(23, 1, '2016-03-16', 'WackiWacki', 'doe@mail.com', 'fdvfdvfdvdfbgndhnfsvafdvdr ganze Irrthum gekomme', 'uncontrolled');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `posts`
--

CREATE TABLE IF NOT EXISTS `posts` (
  `post_id` int(3) NOT NULL AUTO_INCREMENT,
  `post_category_id` int(3) NOT NULL,
  `post_title` varchar(255) NOT NULL,
  `post_author` varchar(255) NOT NULL,
  `post_user` varchar(255) NOT NULL,
  `post_date` date NOT NULL,
  `post_image` text NOT NULL,
  `post_content` text NOT NULL,
  `post_tags` varchar(255) NOT NULL,
  `post_comment_counts` int(11) NOT NULL,
  `post_status` varchar(255) NOT NULL DEFAULT 'draft',
  `post_view_counts` int(11) NOT NULL,
  PRIMARY KEY (`post_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Daten für Tabelle `posts`
--

INSERT INTO `posts` (`post_id`, `post_category_id`, `post_title`, `post_author`, `post_user`, `post_date`, `post_image`, `post_content`, `post_tags`, `post_comment_counts`, `post_status`, `post_view_counts`) VALUES
(1, 1, 'First Post for PHP', 'Felix the Cat', '', '2016-03-17', '', 'Wow that is really really awesome. Hier kï¿½nnte auch noch viel viel mehr text stehen.\r\nakajfsndlkfjcalsdkv#aï¿½dsfï¿½asldk asdhflsdkfnd\r\nsdjafksdf ï¿½asjdkfnl asdf sdakfajasdk \r\ndafsjdaf adsï¿½ds fadsasd ad ad asaadfea sadkf  \r\nsdfkajsdfï¿½akdsjnfdkfjaï¿½skdjfnï¿½kdsjfnï¿½askd ï¿½dsjnf ï¿½kjdafn ajd dsakfj dsï¿½kfj asekje kaej feak aeï¿½kaej fadsfa.', '', 0, 'published', 0),
(3, 11, 'I Love PHP', 'No', '', '2016-03-03', 'images (20).jpg', 'aasdefrgresgtsg fgfdsg sgfdg shth hjzjt aasdefrgresgtsg fgfdsg sgfdg shth hjzjt aasdefrgresgtsg fgfdsg sgfdg shth hjzjt', '', 2, 'published', 2),
(4, 11, 'PHP', 'PHP Lover', '', '2016-03-03', 'Download (4).jpg', 'advabvhnbevsgbs', '', 0, 'published', 0),
(5, 12, 'Test', 'New', '', '2016-03-03', 'Download (7).jpg', 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et', 'New, test', 0, 'draft', 0);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(4) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `user_password` varchar(255) NOT NULL,
  `user_firstname` varchar(255) NOT NULL,
  `user_lastname` varchar(255) NOT NULL,
  `user_email` varchar(255) NOT NULL,
  `user_image` text NOT NULL,
  `user_role` varchar(255) NOT NULL,
  `randSalt` varchar(255) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Daten für Tabelle `users`
--

INSERT INTO `users` (`user_id`, `username`, `user_password`, `user_firstname`, `user_lastname`, `user_email`, `user_image`, `user_role`, `randSalt`) VALUES
(2, 'WackiWacki', '123456', 'Fritz', 'Dorian', 'doe@mail.com', 'Download (12).jpg', 'subscriber', ''),
(3, 'Flitz', 'hallo', 'Fritz', 'Litz', 'fritz@litz.de', '', 'admin', ''),
(4, 'Bloomy', 'password', 'Cindy', 'Bloom', 'cindy@bloom.com', 'Download (8).jpg', 'admin', ''),
(5, 'Felix', 'felix', 'Felix', 'Felix', 'felix@felix.net', 'Download (4).jpg', 'admin', ''),
(6, 'Flix', '', 'Felix', 'felix', 'felix@felix.net', '', 'subscriber', '');
--
-- Datenbank: `dummydb`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel`
--

CREATE TABLE IF NOT EXISTS `artikel` (
  `artnr` int(11) NOT NULL AUTO_INCREMENT,
  `artgrp` int(11) DEFAULT NULL,
  `bezeichnug` varchar(100) NOT NULL,
  `einzelpreis` decimal(8,0) unsigned DEFAULT NULL,
  `gewicht` float unsigned DEFAULT NULL,
  `bestand` int(11) NOT NULL,
  `toxisch` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`artnr`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Daten für Tabelle `artikel`
--

INSERT INTO `artikel` (`artnr`, `artgrp`, `bezeichnug`, `einzelpreis`, `gewicht`, `bestand`, `toxisch`) VALUES
(1, 1, 'Dieselreiniger', '24', 1.5, 4, 1),
(2, 4, 'Verdünnte Salzsäure zum Backen', '4', 0.25, 15, 1);
--
-- Datenbank: `galler_db`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `photos`
--

CREATE TABLE IF NOT EXISTS `photos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `filename` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  `size` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Daten für Tabelle `photos`
--

INSERT INTO `photos` (`id`, `title`, `description`, `filename`, `type`, `size`) VALUES
(5, 'Car2', '', 'images-44.jpg', 'jpg', 287);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Daten für Tabelle `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `first_name`, `last_name`) VALUES
(1, 'Cat', '123456', 'Felix', 'Eisenmenger'),
(3, 'Flix', '123456789', 'Gestiefelter', 'Kater'),
(4, 'other', '911', 'Odin', 'Another'),
(7, 'someOne', '123456', 'onesome', 'notroot');
--
-- Datenbank: `kursverwaltung`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `buchung`
--

CREATE TABLE IF NOT EXISTS `buchung` (
  `bnummer` int(11) NOT NULL AUTO_INCREMENT,
  `termnr` int(10) unsigned NOT NULL,
  `tnummer` int(10) unsigned NOT NULL,
  PRIMARY KEY (`bnummer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `dozenten`
--

CREATE TABLE IF NOT EXISTS `dozenten` (
  `doznr` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(40) NOT NULL,
  `vname` varchar(40) DEFAULT NULL,
  `plz` varchar(5) DEFAULT NULL,
  `ort` varchar(40) DEFAULT NULL,
  `strasse` varchar(40) DEFAULT NULL,
  `hausnr` varchar(5) DEFAULT NULL,
  `telefon1` varchar(15) DEFAULT NULL,
  `telefon2` varchar(15) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`doznr`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=13 ;

--
-- Daten für Tabelle `dozenten`
--

INSERT INTO `dozenten` (`doznr`, `name`, `vname`, `plz`, `ort`, `strasse`, `hausnr`, `telefon1`, `telefon2`, `email`) VALUES
(1, 'Bertram', 'Frank', '72072', 'Tübingen', 'Schillerstrasse', '56', NULL, NULL, 'bertram@frank.com'),
(3, 'Bruns', 'Claudia', '20144', 'Hamburg', 'Lange Gasse', '2', '231485566', NULL, 'bruns@gnx.de'),
(4, 'Weber', 'Hubertus', '50124', 'Köln', 'Schillerstraße', '14', '1795544661', NULL, 'hweber@tonline.com'),
(5, 'Kalender', 'Sabine', '28355', 'Bremen', 'Gotheweg', '3', '1659955881', NULL, 'info@kalender.eu'),
(6, 'Rückert', 'Jörg', '70501', 'Stuttgart', 'Gustav-Mahler-Straße', '152', '71124578', NULL, 'jrueckert@wub.de'),
(7, 'Machowski', 'Michaela', '50667', 'Köln', 'Neumarkt', '10', '1732254789', NULL, 'michaela@machowski.de'),
(8, 'Schmidt', 'Christian', '44141', 'Dortmund', 'Wambeler Hellweg', '99', '231123456', NULL, 'kontakt@chr-schmidt.de'),
(9, 'Achenbach', 'Johannes', '20144', 'Hamburg', 'Lange Straße', '23', '40987554', NULL, 'j.achenbach@online.com'),
(10, 'Fischer', 'Bernd', '70501', 'Stuttgart', 'Bahnhofstraße', '67', '1721144556', NULL, 'bernd@fischer-learn.de'),
(11, 'Schuster', 'Elke', '20253', 'Hamburg', 'Grüner Weg', '19', '40118866', NULL, 'elkeschuster@gmy.com'),
(12, 'Schneider', 'Thomas', '50667', 'Köln', 'Rheingasse', '141', '221649731', NULL, 'tomschneider@gnx.de');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kurs`
--

CREATE TABLE IF NOT EXISTS `kurs` (
  `kursnr` int(11) NOT NULL AUTO_INCREMENT,
  `ressort` varchar(20) DEFAULT NULL,
  `titel` varchar(40) NOT NULL,
  `beschreibung` varchar(255) DEFAULT NULL,
  `preis` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`kursnr`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Daten für Tabelle `kurs`
--

INSERT INTO `kurs` (`kursnr`, `ressort`, `titel`, `beschreibung`, `preis`) VALUES
(1, 'EDV', 'Einführung in MySQL', 'Einführung in die Programmierung', '326.50');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `teilnehmer`
--

CREATE TABLE IF NOT EXISTS `teilnehmer` (
  `tnummer` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(40) NOT NULL,
  `vname` varchar(40) DEFAULT NULL,
  `plz` varchar(5) DEFAULT NULL,
  `ort` varchar(40) DEFAULT NULL,
  `strasse` varchar(40) DEFAULT NULL,
  `hausnr` varchar(5) DEFAULT NULL,
  `telefon1` varchar(15) DEFAULT NULL,
  `telefon2` varchar(15) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`tnummer`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Daten für Tabelle `teilnehmer`
--

INSERT INTO `teilnehmer` (`tnummer`, `name`, `vname`, `plz`, `ort`, `strasse`, `hausnr`, `telefon1`, `telefon2`, `email`) VALUES
(1, 'Meier', 'Franz', '12345', 'Münster', 'Lange Gasse', '5b', NULL, NULL, 'franz@meier.de'),
(2, 'Meier', 'Josef', '44141', 'Dortmund', 'Hansemannstraße ', '47', '0231445566', NULL, 'meier@abc.de'),
(3, 'Rüschmann', 'Reiner', '50124', 'Köln', 'Am Dom', '14', '01625544661', NULL, NULL),
(4, 'Bender', 'Claudia', '28355', 'Bremen', 'Weserstraße', '3', '01759955881', NULL, 'c.bender@tonline.com'),
(5, 'Seidel', 'Martina', '70501', 'Stuttgart', 'Gustav-Mahler-Straße', '152', '070124578', NULL, 'info@seidel.de'),
(6, 'Müller', 'Frank', '50667', 'Köln', 'Heumarkt', '10', '01732254789', NULL, 'fmueller@gmy.de'),
(7, 'Schmidt', 'Olaf', '20537', 'Hamburg', 'Abendrothsweg', '99', '040123456', NULL, 'derolaf@wub.de'),
(8, 'Köster', 'Christine', '20144', 'Hamburg', 'Lange Straße', '23', '040987654', NULL, NULL),
(9, 'Borowski', 'Thomas', '28456', 'Bremen', 'Kurze Straße', '1', '01651144556', NULL, 'tombo@hitmail.com'),
(10, 'Schulze', 'Klaus', '44357', 'Dortmund', 'Mengeder Straße', '648', '0231998866', NULL, 'k.schulze@tonline.com'),
(11, 'Schneider', 'Stefanie', '50667', 'Köln', 'Rheingasse', '2', '0221649731', NULL, 'steffi72@wub.de');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `termine`
--

CREATE TABLE IF NOT EXISTS `termine` (
  `termnr` int(11) NOT NULL AUTO_INCREMENT,
  `kursnr` int(11) DEFAULT NULL,
  `doznr` int(11) DEFAULT NULL,
  `begin` date DEFAULT NULL,
  `ende` date DEFAULT NULL,
  `dauer` varchar(20) DEFAULT NULL,
  `minimal` int(11) DEFAULT NULL,
  `maximal` int(11) DEFAULT NULL,
  `vort` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`termnr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;
--
-- Datenbank: `msgr`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `posts`
--

CREATE TABLE IF NOT EXISTS `posts` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `user` varchar(15) NOT NULL,
  `message` text NOT NULL,
  `time` time NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Daten für Tabelle `posts`
--

INSERT INTO `posts` (`id`, `user`, `message`, `time`) VALUES
(1, 'Felix', 'Hello World', '10:42:16'),
(2, 'Cindy', 'Hello guys', '22:43:29');
--
-- Datenbank: `phpmyadmin`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_bookmark`
--

CREATE TABLE IF NOT EXISTS `pma_bookmark` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `dbase` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `user` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `label` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `query` text COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Bookmarks' AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_column_info`
--

CREATE TABLE IF NOT EXISTS `pma_column_info` (
  `id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `column_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `comment` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `mimetype` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  PRIMARY KEY (`id`),
  UNIQUE KEY `db_name` (`db_name`,`table_name`,`column_name`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Column information for phpMyAdmin' AUTO_INCREMENT=88 ;

--
-- Daten für Tabelle `pma_column_info`
--

INSERT INTO `pma_column_info` (`id`, `db_name`, `table_name`, `column_name`, `comment`, `mimetype`, `transformation`, `transformation_options`) VALUES
(1, 'kursverwaltung', 'buchung', 'bnummer', '', '', '_', ''),
(2, 'kursverwaltung', 'buchung', 'termnr', '', '', '_', ''),
(3, 'kursverwaltung', 'buchung', 'tnummer', '', '', '_', ''),
(14, 'test', 'news', 'message', '', '', '_', ''),
(12, 'test', 'news', 'id', '', '', '_', ''),
(13, 'test', 'news', 'user', '', '', '_', ''),
(21, 'msgr', 'posts', 'message', '', '', '_', ''),
(19, 'msgr', 'posts', 'id', '', '', '_', ''),
(20, 'msgr', 'posts', 'user', '', '', '_', ''),
(22, 'msgr', 'posts', 'time', '', '', '_', ''),
(23, 'cms', 'categories', 'cat_id', '', '', '_', ''),
(24, 'cms', 'categories', 'cat_title', '', '', '_', ''),
(25, 'cms', 'posts', 'post_id', '', '', '_', ''),
(26, 'cms', 'posts', 'post_category_id', '', '', '_', ''),
(27, 'cms', 'posts', 'post_title', '', '', '_', ''),
(28, 'cms', 'posts', 'post_auto', '', '', '_', ''),
(29, 'cms', 'posts', 'post_date', '', '', '_', ''),
(30, 'cms', 'posts', 'post_image', '', '', '_', ''),
(31, 'cms', 'posts', 'post_content', '', '', '_', ''),
(32, 'cms', 'posts', 'post_tags', '', '', '_', ''),
(33, 'cms', 'posts', 'post_comment_counts', '', '', '_', ''),
(34, 'cms', 'posts', 'post_status', '', '', '_', ''),
(35, 'cms', 'posts', 'post_author', '', '', '_', ''),
(36, 'cms', 'posts', 'post_user', '', '', '_', ''),
(37, 'cms', 'posts', 'post_view_counts', '', '', '_', ''),
(38, 'cms', 'comments', 'comment_id', '', '', '_', ''),
(39, 'cms', 'comments', 'comment_post_id', '', '', '_', ''),
(40, 'cms', 'comments', 'comment_date', '', '', '_', ''),
(41, 'cms', 'comments', 'comment_author', '', '', '_', ''),
(42, 'cms', 'comments', 'comment_email', '', '', '_', ''),
(43, 'cms', 'comments', 'comment_content', '', '', '_', ''),
(44, 'cms', 'comments', 'comment_status', '', '', '_', ''),
(45, 'cms', 'users', 'user_id', '', '', '_', ''),
(46, 'cms', 'users', 'username', '', '', '_', ''),
(47, 'cms', 'users', 'user_password', '', '', '_', ''),
(48, 'cms', 'users', 'user_firstname', '', '', '_', ''),
(49, 'cms', 'users', 'user_lastname', '', '', '_', ''),
(50, 'cms', 'users', 'user_email', '', '', '_', ''),
(51, 'cms', 'users', 'userimage', '', '', '_', ''),
(52, 'cms', 'users', 'user_role', '', '', '_', ''),
(53, 'cms', 'users', 'randSalt', '', '', '_', ''),
(54, 'cms', 'users', 'user_image', '', '', '_', ''),
(87, 'galler_db', 'photos', 'id', '', '', '_', ''),
(86, 'galler_db', 'photos', 'size', '', '', '_', ''),
(85, 'galler_db', 'photos', 'type', '', '', '_', ''),
(84, 'galler_db', 'photos', 'filename', '', '', '_', ''),
(83, 'galler_db', 'photos', 'description', '', '', '_', ''),
(82, 'galler_db', 'photos', 'title', '', '', '_', ''),
(81, 'galler_db', 'photos', 'photo_id', '', '', '_', ''),
(80, 'galler_db', 'users', 'last_name', '', '', '_', ''),
(79, 'galler_db', 'users', 'first_name', '', '', '_', ''),
(78, 'galler_db', 'users', 'password', '', '', '_', ''),
(77, 'galler_db', 'users', 'username', '', '', '_', ''),
(76, 'galler_db', 'users', 'id', '', '', '_', '');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_designer_coords`
--

CREATE TABLE IF NOT EXISTS `pma_designer_coords` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `x` int(11) DEFAULT NULL,
  `y` int(11) DEFAULT NULL,
  `v` tinyint(4) DEFAULT NULL,
  `h` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`db_name`,`table_name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table coordinates for Designer';

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_history`
--

CREATE TABLE IF NOT EXISTS `pma_history` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `sqlquery` text COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`),
  KEY `username` (`username`,`db`,`table`,`timevalue`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='SQL history for phpMyAdmin' AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_pdf_pages`
--

CREATE TABLE IF NOT EXISTS `pma_pdf_pages` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `page_nr` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `page_descr` varchar(50) CHARACTER SET utf8 NOT NULL DEFAULT '',
  PRIMARY KEY (`page_nr`),
  KEY `db_name` (`db_name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='PDF relation pages for phpMyAdmin' AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_recent`
--

CREATE TABLE IF NOT EXISTS `pma_recent` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Recently accessed tables';

--
-- Daten für Tabelle `pma_recent`
--

INSERT INTO `pma_recent` (`username`, `tables`) VALUES
('root', '[{"db":"galler_db","table":"photos"},{"db":"galler_db","table":"users"},{"db":"webauth","table":"user_pwd"},{"db":"test","table":"news"},{"db":"msgr","table":"posts"},{"db":"cdcol","table":"cds"},{"db":"taskmanager","table":"task_managers"},{"db":"cms","table":"posts"},{"db":"cms","table":"users"},{"db":"cms","table":"categories"}]');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_relation`
--

CREATE TABLE IF NOT EXISTS `pma_relation` (
  `master_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  PRIMARY KEY (`master_db`,`master_table`,`master_field`),
  KEY `foreign_field` (`foreign_db`,`foreign_table`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Relation table';

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_table_coords`
--

CREATE TABLE IF NOT EXISTS `pma_table_coords` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `pdf_page_number` int(11) NOT NULL DEFAULT '0',
  `x` float unsigned NOT NULL DEFAULT '0',
  `y` float unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`db_name`,`table_name`,`pdf_page_number`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table coordinates for phpMyAdmin PDF output';

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_table_info`
--

CREATE TABLE IF NOT EXISTS `pma_table_info` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `display_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  PRIMARY KEY (`db_name`,`table_name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_table_uiprefs`
--

CREATE TABLE IF NOT EXISTS `pma_table_uiprefs` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `prefs` text COLLATE utf8_bin NOT NULL,
  `last_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`username`,`db_name`,`table_name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Tables'' UI preferences';

--
-- Daten für Tabelle `pma_table_uiprefs`
--

INSERT INTO `pma_table_uiprefs` (`username`, `db_name`, `table_name`, `prefs`, `last_update`) VALUES
('root', 'bestelldatenbank', 'artikel', '{"sorted_col":"`artikel`.`anr` ASC"}', '2015-12-31 12:18:09'),
('root', 'cms', 'comments', '{"sorted_col":"`comments`.`comment_id` ASC"}', '2016-03-07 21:01:39');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_tracking`
--

CREATE TABLE IF NOT EXISTS `pma_tracking` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `version` int(10) unsigned NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL,
  `schema_snapshot` text COLLATE utf8_bin NOT NULL,
  `schema_sql` text COLLATE utf8_bin,
  `data_sql` longtext COLLATE utf8_bin,
  `tracking` set('UPDATE','REPLACE','INSERT','DELETE','TRUNCATE','CREATE DATABASE','ALTER DATABASE','DROP DATABASE','CREATE TABLE','ALTER TABLE','RENAME TABLE','DROP TABLE','CREATE INDEX','DROP INDEX','CREATE VIEW','ALTER VIEW','DROP VIEW') COLLATE utf8_bin DEFAULT NULL,
  `tracking_active` int(1) unsigned NOT NULL DEFAULT '1',
  PRIMARY KEY (`db_name`,`table_name`,`version`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=COMPACT COMMENT='Database changes tracking for phpMyAdmin';

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pma_userconfig`
--

CREATE TABLE IF NOT EXISTS `pma_userconfig` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `config_data` text COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User preferences storage for phpMyAdmin';

--
-- Daten für Tabelle `pma_userconfig`
--

INSERT INTO `pma_userconfig` (`username`, `timevalue`, `config_data`) VALUES
('root', '2015-11-18 17:46:37', '{"lang":"de"}');
--
-- Datenbank: `taskmanager`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `migrations`
--

CREATE TABLE IF NOT EXISTS `migrations` (
  `migration` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Daten für Tabelle `migrations`
--

INSERT INTO `migrations` (`migration`, `batch`) VALUES
('2014_10_12_000000_create_users_table', 1),
('2014_10_12_100000_create_password_resets_table', 1),
('2016_03_21_191905_create_task_managers_table', 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `password_resets`
--

CREATE TABLE IF NOT EXISTS `password_resets` (
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `token` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  KEY `password_resets_email_index` (`email`),
  KEY `password_resets_token_index` (`token`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `task_managers`
--

CREATE TABLE IF NOT EXISTS `task_managers` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `url` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_1` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_2` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_3` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_4` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_5` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_6` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_7` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_8` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_9` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `auftrags_name_10` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `wdh` int(11) NOT NULL,
  `date` date NOT NULL,
  `speicher_ort` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=49 ;

--
-- Daten für Tabelle `task_managers`
--

INSERT INTO `task_managers` (`id`, `created_at`, `updated_at`, `url`, `auftrags_name_1`, `auftrags_name_2`, `auftrags_name_3`, `auftrags_name_4`, `auftrags_name_5`, `auftrags_name_6`, `auftrags_name_7`, `auftrags_name_8`, `auftrags_name_9`, `auftrags_name_10`, `wdh`, `date`, `speicher_ort`) VALUES
(1, '2016-03-24 06:43:24', '2016-03-27 09:31:01', 'http://speedtest.netcologne.de/', 'test_10mb.bin', '', '', '', '', '', '', '', '', '', 1, '2016-03-31', 'User/Downloads'),
(3, '2016-03-26 12:34:43', '2016-03-27 09:31:01', 'http://speedtest.netcologne.de/', 'test_10mb.bin', '', '', '', '', '', '', '', '', '', 1, '2016-03-31', 'User/Downloads'),
(4, '2016-03-27 05:46:28', '2016-03-27 09:31:01', 'http://speedtest.netcologne.de/', 'test_10mb.bin', '', '', '', '', '', '', '', '', '', 1, '2016-03-31', 'User/Downloads'),
(5, '2016-03-27 08:31:52', '2016-03-27 09:31:01', 'http://speedtest.netcologne.de/', 'test_10mb.bin', 'test_10k.bin', 'test_1mb.bin', '', '', '', '', '', '', '', 1, '2016-03-31', 'User/Downloads'),
(23, '2016-03-27 09:33:07', '2016-03-27 09:33:07', 'http://speedtest.netcologne.de/', 'test_10mb.bin', '', '', '', '', '', '', '', '', '', 2, '2016-03-31', 'User/Downloads'),
(24, '2016-03-27 09:34:08', '2016-03-27 09:34:08', 'http://speedtest.netcologne.de/', 'test_500k.bin', 'test_500k.bin', '', '', '', '', '', '', '', '', 2, '2016-03-30', 'User/Downloads'),
(45, '2016-03-27 16:46:19', '2016-03-27 16:46:19', 'http://speedtest.netcologne.de/', 'test_10mb.bin', '', '', '', '', '', '', '', '', '', 1, '2016-03-31', 'User/Downloads'),
(47, '2016-03-27 17:01:15', '2016-03-27 17:01:15', 'http://speedtest.netcologne.de/', 'test_1mb.bin', '', '', '', '', '', '', '', '', '', 1, '2016-04-21', 'User/Downloads'),
(48, '2016-03-27 17:05:44', '2016-03-27 17:05:44', 'http://speedtest.netcologne.de/', 'test_10mb.bin', 'test_1mb.bin', '', '', '', '', '', '', '', '', 3, '2016-04-28', 'User/Downloads');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `remember_token` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `users_email_unique` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;
--
-- Datenbank: `test`
--

DELIMITER $$
--
-- Prozeduren
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `test_multi_sets`()
    DETERMINISTIC
begin
        select user() as first_col;
        select user() as first_col, now() as second_col;
        select user() as first_col, now() as second_col, now() as third_col;
        end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `news`
--

CREATE TABLE IF NOT EXISTS `news` (
  `id` int(12) NOT NULL AUTO_INCREMENT,
  `user` varchar(15) NOT NULL,
  `message` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Daten für Tabelle `news`
--

INSERT INTO `news` (`id`, `user`, `message`) VALUES
(1, 'Let''s go', 'gshvg'),
(3, 'Test', 'thdbvpanÃ¶jnadfvbacf'),
(4, 'Test2', 'aÃ¶dfljnÃ¶afnlÃ¶ fdgjachuih'),
(5, 'Felix', 'Test test test tes'),
(7, 'Frank', 'Hallo Welt'),
(8, 'Noname', 'pssst'),
(9, 'noname', 'hey du'),
(10, 'Edwin', 'bliblablup');
--
-- Datenbank: `webauth`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `user_pwd`
--

CREATE TABLE IF NOT EXISTS `user_pwd` (
  `name` char(30) COLLATE latin1_general_ci NOT NULL DEFAULT '',
  `pass` char(32) COLLATE latin1_general_ci NOT NULL DEFAULT '',
  PRIMARY KEY (`name`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Daten für Tabelle `user_pwd`
--

INSERT INTO `user_pwd` (`name`, `pass`) VALUES
('xampp', 'wampp');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

?>

<!-- Navigation -->
<?php include("includes/nav.php"); ?>

    <!-- Page Content -->
    <div class="container">

        <div class="row">

            <!-- Blog Entries Column -->
            <div class="col-md-8">
            <?php
              
                $query = "SELECT * FROM posts";
                
                 $select_all_posts_query = mysqli_query($mysqli, $query);
                        
                    //zugriff auf die einzelnen Zeilen ohne while schleife würde man
                    //immer das letzte element auswählen
                    while($row = mysqli_fetch_assoc($select_all_posts_query)){
                        //um nur eine spezielle spalte auszuwählen gut ist wenn man die Variable
                        //die man erstellt genauso benennt wie die spalte
                        $post_id = $row['post_id'];
                        $post_title = $row['post_title'];
                        $post_author = $row['post_author'];
                        $post_date = $row['post_date'];
                        $post_image = $row['post_image'];
                        $post_content = substr($row['post_content'],0,50);
                        
                //php hier unterbrechen aber darauf achten das der while-loop noch nicht //geschlossen wird. Das passiert weiter unten    
                        ?>
               

                <!-- First Blog Post -->
                <h2>
                    <a href="post.php?p_id=<?php echo $post_id; ?>"><?php echo $post_title; ?></a>
                </h2>
                <p class="lead">
                    by <a href="index.php"><?php echo $post_author; ?></a>
                </p>
                <p><span class="glyphicon glyphicon-time"></span> Posted <?php echo $post_date; ?></p>
                <hr>
                <img class="img-responsive" src="images/<?php echo $post_image; ?>" alt="">
                <hr>
                <p><?php echo $post_content; ?></p>
                <a class="btn btn-primary" href="post.php?p_id=<?php echo $post_id; ?>">Read More <span class="glyphicon glyphicon-chevron-right"></span></a>
                
                
                <?php
                //hier wird jetzt der while-loop geschlossen
                    }
                ?>


            </div>

            <!-- Blog Sidebar Widgets Column -->
           <?php include("includes/sidebarFehler.php"); ?>

        </div>
        <!-- /.row -->

        <hr>

<?php include("includes/footer.php"); ?>