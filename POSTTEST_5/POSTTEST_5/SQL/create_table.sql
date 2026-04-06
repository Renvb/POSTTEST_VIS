CREATE DATABASE IF NOT EXISTS db_kpop
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE db_kpop;

CREATE TABLE IF NOT EXISTS tbl_grup (
    id          INT             AUTO_INCREMENT PRIMARY KEY,
    nama_grup   VARCHAR(100)    NOT NULL,
    agensi      VARCHAR(100)    NOT NULL,
    genre       VARCHAR(50)     NOT NULL,
    negara      VARCHAR(100)    NOT NULL DEFAULT 'Korea Selatan',
    tahun_debut YEAR            NOT NULL,
    jml_member  TINYINT         NOT NULL,
    lagu_populer VARCHAR(150)   NOT NULL,
    created_at  DATETIME        DEFAULT CURRENT_TIMESTAMP,
    updated_at  DATETIME        DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

INSERT IGNORE INTO tbl_grup (nama_grup, agensi, genre, negara, tahun_debut, jml_member, lagu_populer) VALUES
('GFRIEND', 'KSW Entertainment', 'Pop', 'Korea Selatan', 2015, 6, 'MAGO'),
('VIVIZ', 'BPM', 'Pop', 'Korea Selatan', 2021, 3, 'MANIAC');