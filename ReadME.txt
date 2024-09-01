# HotCat Project

-Code first y�ntemi ile Ntier Katmanl� Mimari kullan�larak yaz�lacak. 
-Ba�lang��ta 3 katmandan meydana gelecek.

    -Model: Model katman� dal katman�nda varl�klar� temsil eden Entity'leri bar�nd�ran katmand�r.
       -Base: Interface'ten alm�� oldu�u �zellikleri b�nyesine dahil eder.
       -Entities: Veritaban�nda olmas�n� istedi�imiz tablolar� temsil eder.
          - AppUser
          - AppUserRole
          - Category
          - Product
          - Supplier


       -Enums: tablolarda kullan�lacak sabitleri temsil eder.
       -Interfaces: B�t�n classlara �nc�l�k edecek �zellikleri bar�nd�r�r.

    - DAL (Data Access Layer): Veritaban�na ula��m katman�n� temsil eder. 
    Veritaban� ile ilgili nesnelerimiz, tasar�m desenleri, Entity gibi varl�klar bu katman i�erisinde kullan�lmal�d�r.
       -Context: Veritaban� nesnesini temsil eder.

    - BLL (Business Logic Layer): �� mant��� katman� olarak kullan�lacakt�r. 
    Kullan�c�n�n talep etti�i i�lemler ilk olarak bu katman taraf�ndan kar��lanacak. Repository ve Service bu katman i�erisinde olu�turulacak.

    - UI (User Interface): Sunum katman�n� temsil eder. MVC projesi bu katman i�erisinde olu�turulacak. 
       - MVC projesi bu katman i�erisinde olu�turulacak.
       - Console App
       - WebApi