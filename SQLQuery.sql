--Select
--ANSII and case insensitive
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

select * from Products where categoryId=1 or CategoryID=3

select * from Products where categoryId=1 and UnitPrice>=10


select * from Products where categoryId=1 order by UnitPrice desc --default ascending


select count(*) Adet from Products where CategoryID=2

select categoryId,count(*) from Products where unitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories 
on Products.CategoryID = Categories.CategoryID--if gibi
where Products.UnitPrice>10

--DTO: Data Transformation Object

Select * from Products p inner join [Order Details] od--Products'ta olup Order Details'te olmayanları da getir
on p.ProductID = od.ProductID 
inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null--"sana özel" muhabbeti