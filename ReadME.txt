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
          --Repositories
              --Abstracts
                  --Base Abstracts
                      -IRepository: Bu interface b�t�n i�lemlere �nc�l�k edecek metotlar�n kurallar�n� bar�nd�rmaktad�r. (CRUD) Interface d��ar�dan bir T al�r.
          --Concretes
			--BaseConcrete
				--BaseRepository: IRepository'den miras alara eylemleri (metotlar�) somut hale d�n��t�ren class.. D�a�r�dan bir T al�r

	Yukar�daki tan�mlamalarda bulunan T tipleri Ayr� bir servis olu�turulacak. Bu kurallar� b�nyesine al�r. Bu kurallara g�re spesifik eylemleri ger�ekle�tirir. �rne�in CategoryService'de ger�ekle�tirildi�i gibi. (Bknz. CategoryService)

    - UI (User Interface): Sunum katman�n� temsil eder. MVC projesi bu katman i�erisinde olu�turulacak. 
       - MVC projesi bu katman i�erisinde olu�turulacak.
       - Console App
       - WebApi

    -HotCatCommon: Ortak katman. G�rsel ekleme, ip adresi alma gibi i�lemler bar�nd�racak. �lerleyen etaplarda projenin daha esnek olabilmesi i�in her bir katmanda ortak olarak kullan�lacak i�lemler/yap�lar bu katmanda yer almaktad�rlar. 
       --ImageHelper: ��erisinde bulunan static metot vas�tas�yla d��ar�dan iletilen dosyan�n bir g�rsel olup olmad���n� kontrol edilmesinnin ard�ndan bu g�rselin projeye dahil edilmesini ger�ekle�tirir.

#SMTP Ayarlar�
Email: hotcatcafe@hotmail.com
Pass: Cafeprojesi.123