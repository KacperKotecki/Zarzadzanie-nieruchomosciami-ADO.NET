CREATE DATABASE Zarzadanie_Nieruchomosciami;
GO

USE Zarzadanie_Nieruchomosciami;
GO

CREATE TABLE Wlasciciele (
    IdWlasciciela INT IDENTITY(1,1) PRIMARY KEY,
    Imie NVARCHAR(50) NOT NULL,
    Nazwisko NVARCHAR(100) NOT NULL,
    Pesel CHAR(11) UNIQUE NOT NULL CHECK (LEN(Pesel) = 11 AND Pesel NOT LIKE '%[^0-9]%'),
    Telefon NVARCHAR(15) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL CHECK (Email LIKE '%@%.%'),
    NumerKontaBankowego CHAR(26) NOT NULL CHECK (LEN(NumerKontaBankowego) = 26 AND NumerKontaBankowego NOT LIKE '%[^0-9]%')
);

CREATE TABLE Najemcy (
    IdNajemcy INT IDENTITY(1,1) PRIMARY KEY,
    Imie NVARCHAR(50) NOT NULL,
    Nazwisko NVARCHAR(100) NOT NULL,
    Pesel CHAR(11) UNIQUE NOT NULL CHECK (LEN(Pesel) = 11 AND Pesel NOT LIKE '%[^0-9]%'),
    Telefon NVARCHAR(15) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL CHECK (Email LIKE '%@%.%')
);

CREATE TABLE Nieruchomosci (
    IdNieruchomosci INT IDENTITY(1,1) PRIMARY KEY,
    IdWlasciciela INT NOT NULL,
    Miasto NVARCHAR(100) NOT NULL,
    Ulica NVARCHAR(150) NOT NULL,
    LiczbaPokoi INT NOT NULL CHECK (LiczbaPokoi > 0),
    TypNieruchomosci NVARCHAR(50) NOT NULL CHECK (TypNieruchomosci IN ('Mieszkanie', 'Pokoj', 'Lokal uslugowy', 'Biuro')),
    CONSTRAINT FK_Nieruchomosci_Wlasciciele FOREIGN KEY (IdWlasciciela)
        REFERENCES Wlasciciele(IdWlasciciela) ON DELETE CASCADE
);

CREATE TABLE UmowyNajmu (
    IdUmowyNajmu INT IDENTITY(1,1) PRIMARY KEY,
    IdNieruchomosci INT NOT NULL,
    IdNajemcy INT NOT NULL,
    IdWlasciciela INT NOT NULL,
    DataRozpoczecia DATE NOT NULL,
    DataZakonczenia DATE NOT NULL,
    CONSTRAINT CK_DatyUmowy CHECK (DataZakonczenia >= DataRozpoczecia),
    CONSTRAINT FK_UmowyNajmu_Nieruchomosci FOREIGN KEY (IdNieruchomosci)
        REFERENCES Nieruchomosci(IdNieruchomosci) ON DELETE CASCADE,
    CONSTRAINT FK_UmowyNajmu_Najemcy FOREIGN KEY (IdNajemcy)
        REFERENCES Najemcy(IdNajemcy) ON DELETE CASCADE,
    CONSTRAINT FK_UmowyNajmu_Wlasciciele FOREIGN KEY (IdWlasciciela)
        REFERENCES Wlasciciele(IdWlasciciela) ON DELETE NO ACTION
);

CREATE TABLE Oplaty (
    IdOplaty      INT IDENTITY(1,1) PRIMARY KEY,
    IdUmowyNajmu  INT NOT NULL,
    Czynsz        DECIMAL(10,2) NOT NULL CHECK (Czynsz >= 0),
    StatusCzynszu NVARCHAR(20)  NOT NULL DEFAULT 'Oczekujaca'
                  CHECK (StatusCzynszu IN ('Oczekujaca', 'Zaplacona', 'Opozniona')),
    Woda          DECIMAL(10,2) NOT NULL DEFAULT 0 CHECK (Woda >= 0),
    StatusWody    NVARCHAR(20)  NOT NULL DEFAULT 'Oczekujaca'
                  CHECK (StatusWody IN ('Oczekujaca', 'Zaplacona', 'Opozniona')),
    Prad          DECIMAL(10,2) NOT NULL DEFAULT 0 CHECK (Prad >= 0),
    StatusPradu   NVARCHAR(20)  NOT NULL DEFAULT 'Oczekujaca'
                  CHECK (StatusPradu IN ('Oczekujaca', 'Zaplacona', 'Opozniona')),
    CONSTRAINT FK_Oplaty_UmowyNajmu FOREIGN KEY (IdUmowyNajmu)
        REFERENCES UmowyNajmu(IdUmowyNajmu) ON DELETE CASCADE
);