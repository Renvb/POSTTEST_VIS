CREATE DATABASE IF NOT EXISTS db_kpop
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE db_kpop;

CREATE TABLE IF NOT EXISTS tbl_agensi (
    id         INT          AUTO_INCREMENT PRIMARY KEY,
    nama       VARCHAR(100) NOT NULL UNIQUE,
    negara     VARCHAR(100) NOT NULL DEFAULT 'Korea Selatan',
    tahun_berdiri YEAR      NOT NULL,
    created_at DATETIME     DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME     DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS tbl_grup (
    id           INT          AUTO_INCREMENT PRIMARY KEY,
    nama_grup    VARCHAR(100) NOT NULL,
    agensi_id    INT          NOT NULL,
    genre        VARCHAR(50)  NOT NULL,
    negara       VARCHAR(100) NOT NULL DEFAULT 'Korea Selatan',
    tahun_debut  YEAR         NOT NULL,
    jml_member   TINYINT      NOT NULL,
    lagu_populer VARCHAR(150) NOT NULL,
    created_at   DATETIME     DEFAULT CURRENT_TIMESTAMP,
    updated_at   DATETIME     DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT fk_grup_agensi
        FOREIGN KEY (agensi_id)
        REFERENCES tbl_agensi(id)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

INSERT IGNORE INTO tbl_agensi (nama, negara, tahun_berdiri) VALUES
('YG Entertainment',       'Korea Selatan', 1996),
('HYBE Labels',            'Korea Selatan', 2005),
('JYP Entertainment',      'Korea Selatan', 1997),
('SM Entertainment',       'Korea Selatan', 1995),
('PLEDIS Entertainment',   'Korea Selatan', 2008),
('Starship Entertainment', 'Korea Selatan', 2008);

INSERT IGNORE INTO tbl_grup (nama_grup, agensi_id, genre, negara, tahun_debut, jml_member, lagu_populer) VALUES
('BLACKPINK',  (SELECT id FROM tbl_agensi WHERE nama = 'YG Entertainment'),       'Pop',     'Korea Selatan', 2016, 4,  'DDU-DU DDU-DU'),
('BTS',        (SELECT id FROM tbl_agensi WHERE nama = 'HYBE Labels'),             'Hip-Hop', 'Korea Selatan', 2013, 7,  'Dynamite'),
('TWICE',      (SELECT id FROM tbl_agensi WHERE nama = 'JYP Entertainment'),      'Pop',     'Korea Selatan', 2015, 9,  'FANCY'),
('EXO',        (SELECT id FROM tbl_agensi WHERE nama = 'SM Entertainment'),       'R&B',     'Korea Selatan', 2012, 9,  'Love Shot'),
('aespa',      (SELECT id FROM tbl_agensi WHERE nama = 'SM Entertainment'),       'Pop',     'Korea Selatan', 2020, 4,  'Next Level'),
('ITZY',       (SELECT id FROM tbl_agensi WHERE nama = 'JYP Entertainment'),      'Dance',   'Korea Selatan', 2019, 5,  'DALLA DALLA'),
('Stray Kids', (SELECT id FROM tbl_agensi WHERE nama = 'JYP Entertainment'),      'Hip-Hop', 'Korea Selatan', 2018, 8,  'Miroh'),
('SEVENTEEN',  (SELECT id FROM tbl_agensi WHERE nama = 'PLEDIS Entertainment'),   'Pop',     'Korea Selatan', 2015, 13, 'Left & Right'),
('NCT 127',    (SELECT id FROM tbl_agensi WHERE nama = 'SM Entertainment'),       'R&B',     'Korea Selatan', 2016, 10, 'Kick It'),
('IVE',        (SELECT id FROM tbl_agensi WHERE nama = 'Starship Entertainment'), 'Pop',     'Korea Selatan', 2021, 6,  'LOVE DIVE');