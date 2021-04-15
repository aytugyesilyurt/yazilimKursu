-- select 
-- ANSII
-- * hepsini seçer yada oraya istenilen sütunlar eklenebilir. ayrıca yanına boşluk bırakarak alyan eklenebilir ( tabloda city yerine sehir yazsın gibi )
select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

select * from Customers where City = 'Berlin'

--case insensitive
-- where filtre yapmak için kullanılır
-- or veya demek ikisi de olabilir -- and ve demek ikisi de olmak zorunda
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>10

--asc (ascending-artan/ default)  --desc  (descending)
-- order by sıralamak için kullanılır sonuna asc yada desc eklenir ( asc default eklemeye gerek yok )
select * from Products where categoryId=1 order by UnitPrice desc

-- count sayma işlemini yapar ayrıca sonuna where gelebilir ( alyan da takılabilir )
select count(*) ÜrünAdedi from Products where CategoryID=2

--products tablosundaki category idleri category idye göre sırala
select categoryId from Products group by CategoryID

--products tablosundaki category ıdleri sırala ve sayısını göster demek
select categoryId KategoriAdı,count(*) ÜrünAdedi from Products group by CategoryID

-- ikili sıralama da mümkündür -- unit priceye göre sırala sonra category ıd ye göre sırala ( KategoriÜrünAdı[1-2-3-4], ÜrünFiyatı, ÜrünAdedi )
select categoryId KategoriÜrünAdı,UnitPrice ÜrünFiyatı,count(*) ÜrünAdedi from Products group by UnitPrice,categoryId

-- ikili sıralammada sonraki değere göre sıralanır -- category ıd ye göre sırala sonra unit priceye ye göre sırala ( KategoriÜrünAdı, ÜrünFiyatı[2.50-4.50-6.00-7.00], ÜrünAdedi )
select categoryId KategoriÜrünAdı,UnitPrice ÜrünFiyatı,count(*) ÜrünAdedi from Products group by categoryId,UnitPrice

-- having groupby daki count operatörüne koşul vermemizi sağlar
-- önce where çalışır
-- Products tablosundaki : UnitPricesi 20 den büyük, CategoryId'ye göre grupla, sayısı 10'dan küçük olanları göster
select categoryId KategoriAdı, count(*) Sayısı from Products where UnitPrice>20 group by CategoryID having count(*)<5

-- diğer işlemde where where UnitPrice>20 yazdığımız için veri sayımız azaldı aynı değerler geldi alttaki işlemde ise direk 10 dan küçükleri gösterdiği için daha az sayımız oldu
select categoryId KategoriAdı, count(*) Sayısı from Products group by CategoryID having count(*)<10

-- product tablosu ve categories tablolarını, products tablosundaki categoryıd ve categories tablosundaki categoryidleri eşleştirerek hepsini ekrana göster demek
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

-- products ce categories tablosunu categoires idlerini eşleştirerek, products tablosundaki productsıd-productname-unitprice ve categories tablosundaki categoiresnameyi getir.
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID
-- DTO - Data Transformation object

-- Ara not: [Order Details] yazmamızın amacı arada boşluk olduğu için SQL bunu komut olarak algılamasın tablo olarak algılasın diye
-- Ara not2: tablolara alyan verdiğimizde direk alyan.tablokolonu olarak çağırabiliriz (Products p --> p.UnitPrice gibi )

-- Products talosunda olan order details tablosunda olmayan verileri products tablosundaki productid ve order details tablosundaki productidleri eşleştirerek getir
select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

-- customers tablosundaki ve orders tablosundaki verileri customerid ye göre eşitle fakat customers tablosunda mutlaka olsun orders da customomerid si boşda olabilir
-- yani sipariş vermemiş müşteriler de olabilir demek
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID 

-- Sipariş vermemiş mülşterileri gösterir ( is null --> nulları çağırmak için kullanılır )
-- nulları getirmek için her zaman primary key e göre uygulama yapılır
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null

-- 2 den fazla tabloyu birleştirmek istenirse devamına inner join tablo belirtilir ve on ile tekrar datalar eşleştirilir
select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID


-- 6. HAFTA ÖDEV 2
Select p.ProductName As [Ürun Adı], sum(od.UnitPrice*od.Quantity) As [Kazanılan Toplam Miktar]
from Products p
inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on od.OrderID = o.OrderID
Group by p.ProductName
Order by 2 desc
