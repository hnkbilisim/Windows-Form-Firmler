# Windows Form ile Film Listeleme ve Ekleme Uygulaması

Bu proje, Windows Form ortamında ilişkisel bir veritabanı(MariaDB) kullanarak CRUD işlemi nasıl yapıldığı göstermek için hazırlanmıştır.

## Kurulum

1. Projeyi klonlayın: https://github.com/hnkbilisim/Windows-Form-Firmler.git
2. Veritabanını yükleyin: `filmler_Db.sql`
3. Widows Form ile Projeyi Başlatın


## Kullanım

```sql

-- film_arsiv_1 için veritabanı yapısı dökülüyor
CREATE DATABASE IF NOT EXISTS `film_arsiv_1` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `film_arsiv_1`;

-- tablo yapısı dökülüyor film_arsiv_1.elestiriler
CREATE TABLE IF NOT EXISTS `elestiriler` (
  `elestiri_id` int NOT NULL AUTO_INCREMENT,
  `film_id` int DEFAULT NULL,
  `elestiri_metin` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
  `puan` decimal(3,1) DEFAULT NULL,
  `elestiri_tarihi` date DEFAULT NULL,
  `elestirmen` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`elestiri_id`),
  KEY `elestiriler_ibfk_1` (`film_id`),
  CONSTRAINT `elestiriler_ibfk_1` FOREIGN KEY (`film_id`) REFERENCES `filmler` (`film_id`)
) ENGINE=InnoDB AUTO_INCREMENT=408 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- tablo yapısı dökülüyor film_arsiv_1.filmler
CREATE TABLE IF NOT EXISTS `filmler` (
  `film_id` int NOT NULL AUTO_INCREMENT,
  `film_ad` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `yonetmen` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `yil` int DEFAULT NULL,
  `tur_id` int DEFAULT NULL,
  `sure` int DEFAULT NULL,
  `poster` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `imdb_puan` float DEFAULT NULL,
  `film_odul` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`film_id`),
  KEY `fk_filmler_turler` (`tur_id`),
  CONSTRAINT `fk_filmler_turler` FOREIGN KEY (`tur_id`) REFERENCES `turler` (`tur_id`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- tablo yapısı dökülüyor film_arsiv_1.turler
CREATE TABLE IF NOT EXISTS `turler` (
  `tur_id` int NOT NULL AUTO_INCREMENT,
  `tur_ad` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`tur_id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


