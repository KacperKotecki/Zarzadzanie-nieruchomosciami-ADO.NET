Projekt : Zarzadzanie Nieruchomościami ADO.NET

Autorzy projektu: Weronika Kusideł, Kacper Kotecki  
Informatyka Ekonomiczna I stopień 2 rok
Wydział Ekonomiczno-Socjologiczny UŁ	
21.04.2026r.


Platforma: .NET Framework 4.7.2 (Windows Forms)
Architektura dostępu do danych: ADO.NET z wykorzystaniem warstwy bezpołączeniowej 
Baza Danych: MS SQL Server

Inicjalizacja bazy danych:
1. Otwieramy program MS SQL Server Management Studio
2. Wykonajemy 2 skrypty skrypt "tworzenie_bazy.sql", 'dodawanie_danych.sql' znajdują się one w folderze z projektem 


Konfiguracja połaczenia w pliku Form1.cs

Aplikacja ma jeden centralny ConnectionString 

public static string connectionString = @"Server=DELL\SQLEXPRESS;Database=Zarzadanie_Nieruchomosciami;Integrated Security=True;TrustServerCertificate=True;";


Uruchomienie aplikacji:

Po skompilowaniu i uruchomieniu aplikacji, dane są automatycznie pobierane do lokalnego obiektu DataSet w pamięci podręcznej. Nawigacja i operacje CRUD (Dodaj, Edytuj, Usuń) odbywają się za pomocą dedykowanych przycisków w każdym module, a zapis zmian następuje asynchronicznie w stosunku do interfejsu (zmiany zatwierdzane są w obiekcie DataSet, a następnie wysyłane do bazy danych).