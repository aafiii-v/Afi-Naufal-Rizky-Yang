CREATE DATABASE hotel_system;
USE hotel_system;

CREATE TABLE admin (
    username 	VARCHAR(50),
    passwordd 	VARCHAR(50)
);

INSERT INTO admin VALUES
('admin1', 'qwe123'),
('admin2', 'poi098');

CREATE TABLE kamar (
    no_kamar 		CHAR(5) PRIMARY KEY,
    tipe_kamar 		VARCHAR(100) NOT NULL,
    status_kamar 	ENUM('tersedia', 'dipesan') NOT NULL
);

INSERT INTO kamar VALUES
('101', 'Deluxe', 	'tersedia'),
('102', 'Deluxe', 	'tersedia'),
('103', 'Deluxe', 	'tersedia'),
('104', 'Standard', 	'tersedia'),
('105', 'Standard', 	'tersedia'),
('106', 'Standard', 	'tersedia'),
('107', 'Suite', 	'tersedia'),
('108', 'Suite', 	'tersedia'),
('109', 'Suite', 	'tersedia');

CREATE TABLE pemesanan (
    kode_pemesanan 	CHAR(10) PRIMARY KEY,
    no_kamar 		CHAR(5),
    waktu_masuk 	DATETIME NOT NULL,
    waktu_keluar 	DATETIME NOT NULL,
    CONSTRAINT fk_kamar FOREIGN KEY (no_kamar) REFERENCES kamar (no_kamar)
);

CREATE TABLE tamu (
    kode_tamu 	CHAR(10) PRIMARY KEY,
    no_kamar 	CHAR(5),
    nama_tamu 	VARCHAR(100) NOT NULL,
    no_hp 	VARCHAR(15) NOT NULL,
    kode_pemesanan CHAR(10),
    CONSTRAINT fk_tamu_kamar FOREIGN KEY (no_kamar) REFERENCES kamar (no_kamar),
    CONSTRAINT fk_tamu_pemesanan FOREIGN KEY (kode_pemesanan) REFERENCES pemesanan (kode_pemesanan) ON DELETE CASCADE
);

DELIMITER $$
CREATE TRIGGER trg_generate_kode_tamu
BEFORE INSERT ON tamu
FOR EACH ROW
BEGIN
    DECLARE last_kode CHAR(10);
    DECLARE new_kode CHAR(10);

    SELECT kode_tamu INTO last_kode 
    FROM tamu 
    ORDER BY kode_tamu DESC 
    LIMIT 1;

    IF last_kode IS NULL THEN
        SET new_kode = 'T001';
    ELSE
        SET new_kode = CONCAT('T', LPAD(SUBSTRING(last_kode, 2) + 1, 3, '0'));
    END IF;

    SET NEW.kode_tamu = new_kode;
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER trg_generate_kode_pemesanan
BEFORE INSERT ON pemesanan
FOR EACH ROW
BEGIN
    DECLARE last_kode CHAR(10);
    DECLARE new_kode CHAR(10);

    SELECT kode_pemesanan INTO last_kode 
    FROM pemesanan 
    ORDER BY kode_pemesanan DESC 
    LIMIT 1;

    IF last_kode IS NULL THEN
        SET new_kode = 'P001';
    ELSE
        SET new_kode = CONCAT('P', LPAD(SUBSTRING(last_kode, 2) + 1, 3, '0'));
    END IF;

    SET NEW.kode_pemesanan = new_kode;
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER trg_update_status_kamar
AFTER INSERT ON pemesanan
FOR EACH ROW
BEGIN
    UPDATE kamar
    SET status_kamar = 'dipesan'
    WHERE no_kamar = NEW.no_kamar;
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER trg_reset_status_kamar
AFTER DELETE ON pemesanan
FOR EACH ROW
BEGIN
    UPDATE kamar
    SET status_kamar = 'tersedia'
    WHERE no_kamar = OLD.no_kamar;
END$$
DELIMITER ;

INSERT INTO pemesanan (no_kamar, waktu_masuk, waktu_keluar) VALUES
('101', '2024-12-01 14:00:00', '2024-12-05 12:00:00'),
('102', '2024-12-03 15:00:00', '2024-12-07 11:00:00'),
('103', '2024-12-04 16:00:00', '2024-12-08 10:00:00');

INSERT INTO tamu (nama_tamu, no_hp, no_kamar, kode_pemesanan) VALUES
('John Doe', '081234567890', '101', 'P001'),
('Jane Smith', '082345678901', '102', 'P002'),
('Robert Brown', '083456789012', '103', 'P003');

