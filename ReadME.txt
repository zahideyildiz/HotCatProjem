# HotCat Project

-Code first yöntemi ile Ntier Katmanlý Mimari kullanýlarak yazýlacak. 
-Baþlangýçta 3 katmandan meydana gelecek.

    -Model: Model katmaný dal katmanýnda varlýklarý temsil eden Entity'leri barýndýran katmandýr.
       -Base: Interface'ten almýþ olduðu özellikleri bünyesine dahil eder.
       -Entities: Veritabanýnda olmasýný istediðimiz tablolarý temsil eder.
          - AppUser
          - AppUserRole
          - Category
          - Product
          - Supplier


       -Enums: tablolarda kullanýlacak sabitleri temsil eder.
       -Interfaces: Bütün classlara öncülük edecek özellikleri barýndýrýr.

    - DAL (Data Access Layer): Veritabanýna ulaþým katmanýný temsil eder. 
    Veritabaný ile ilgili nesnelerimiz, tasarým desenleri, Entity gibi varlýklar bu katman içerisinde kullanýlmalýdýr.
       -Context: Veritabaný nesnesini temsil eder.

    - BLL (Business Logic Layer): Ýþ mantýðý katmaný olarak kullanýlacaktýr. 
    Kullanýcýnýn talep ettiði iþlemler ilk olarak bu katman tarafýndan karþýlanacak. Repository ve Service bu katman içerisinde oluþturulacak.

    - UI (User Interface): Sunum katmanýný temsil eder. MVC projesi bu katman içerisinde oluþturulacak. 
       - MVC projesi bu katman içerisinde oluþturulacak.
       - Console App
       - WebApi