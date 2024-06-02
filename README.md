# Windows Form ile Film Listeleme ve Ekleme Uygulaması

Bu proje, Windows Form ortamında ilişkisel bir veritabanı(MariaDB) kullanarak CRUD işlemi nasıl yapıldığı göstermek için hazırlanmıştır.

## Kurulum

1. Projeyi klonlayın: https://github.com/hnkbilisim/Windows-Form-Firmler.git
2. Veritabanını yükleyin: `filmler_Db.sql`
3. Widows Form ile Projeyi Başlatın


## SQL Kurulum

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
```

## Mysql.Data.Dll
- Mysql Referans dosyasını indirin: https://github.com/hnkbilisim/Windows-Form-Firmler/blob/main/MySql.Data.dll
- Referanslara tıklayın.
- Add Referansa tıklayın.

## Görseller
![Form 1](https://github.com/hnkbilisim/Windows-Form-Firmler/blob/main/gorsel/Ekran%20görüntüsü%202024-06-02%20024616.png)

## Video
[![Örnek Video](https://github.com/hnkbilisim/Windows-Form-Firmler/blob/main/hqdefault.jpg)](https://www.youtube.com/watch?v=MOKRMYgPeZ4)


# --------------------------------------------------

# Birinci Düzey Başlık
## İkinci Düzey Başlık
### Üçüncü Düzey Başlık

**Kalın Metin**
*İtalik Metin*

Sırasız Liste:
- Öğe 1
- Öğe 2
- Öğe 3

Sıralı Liste:
1. Birinci Öğe
2. İkinci Öğe
3. Üçüncü Öğe


[GitHub](https://github.com)

![Açıklama](resim_url)

```python
print("Merhaba, Dünya!")
```

---

> Bu bir alıntıdır.

Çizgi: Çizgi eklemek için "---" veya "***" kullanabilirsiniz.

Kod Blokları: Kod blokları oluşturmak için üç ters tırnak veya 4 boşluk kullanabilirsiniz.


    <?php
    echo "Merhaba Dünya";
    ?>


## HTML ile KODLAMA

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>


Hi, I'm Mona. You might recognize me as GitHub's mascot.

| Rank | Languages |
|-----:|-----------|
|     1| JavaScript|
|     2| Python    |
|     3| SQL       |


<details>
<summary>My top languages</summary>

| Rank | Languages |
|-----:|-----------|
|     1| JavaScript|
|     2| Python    |
|     3| SQL       |

</details>



[I'm an inline-style link](https://www.google.com)

[I'm an inline-style link with title](https://www.google.com "Google's Homepage")

[I'm a reference-style link][Arbitrary case-insensitive reference text]

[I'm a relative reference to a repository file](../blob/master/LICENSE)

[You can use numbers for reference-style link definitions][1]

Or leave it empty and use the [link text itself].

URLs and URLs in angle brackets will automatically get turned into links. 
http://www.example.com or <http://www.example.com> and sometimes 
example.com (but not on Github, for example).

Some text to show that the reference links can follow later.

[arbitrary case-insensitive reference text]: https://www.mozilla.org
[1]: http://slashdot.org
[link text itself]: http://www.reddit.com

<h1>Burası da H1 başlık</h1>
