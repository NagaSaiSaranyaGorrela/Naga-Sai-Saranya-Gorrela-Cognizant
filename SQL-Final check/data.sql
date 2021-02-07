create database truYum
use truYum

--create user table
create table users(us_id int primary key,
us_name varchar(60))

--create cart table
create table cart(ct_id int primary key,
ct_us_id int foreign key references users(us_id),
ct_pr_id int foreign key references menu_item(me_id))



--1.View Menu Item List Admin
--a.Add data into menu_item table.

create table menu_item (
me_id int primary key,
me_name varchar(100),
me_price  float,
me_active varchar(3),
me_date_of_launch date,
me_category varchar(45),
me_free_delivery varchar(3)
)

insert into menu_item values
(1,'Sandwich','99.00','yes','2017-03-15','Main Course','yes'),
(2,'Burger', '129.00','yes','2017-12-23','Main Course','No'),
(3,'Pizza','149.00','yes','2017-08-21','Main Course','No'),
(4,'French Fries','57.00','No','2017-07-02','Starters','yes'),
(5,'Chocolate Brownie','32.00','yes','2022-11-02','Dessert','yes')

--1.b Frame SQL query to get all menu items
select * from menu_item

--2.To get all menu items which after launch date and is active
select * from menu_item where me_active='yes' and me_date_of_launch is not null

--3.a. To get a menu items based on menu item id
select * from menu_item where me_id=(select me_id from menu_item where me_name='Sandwich')

--3.b.Update SQL menu_items table to update all the column values based on menu item id
update menu_item set me_name='Ice cream',me_price='95.00',me_active='yes',me_date_of_launch='2021-02-03',me_category='Dessert',me_free_delivery='No' where me_id=(select me_id where me_name='Burger')

--4.a.Frame insert scripts for adding data into user and cart tables.In user table create two users. Once user will not have any entries in cart, while the other will have at least 3 items in the cart.
insert into users values(1,'saranya'),(2,'sai')
insert into cart values (1,2,4),(2,2,3),(3,2,1)

select * from users
select * from cart

--5.a Frame SQL query to get all menu items in a particular user’s cart

SELECT distinct(users.us_name),sum(menu_item.me_price) 
FROM ((menu_item INNER JOIN cart ON cart.ct_pr_id= menu_item.me_id)
JOIN users ON users.us_id=cart.ct_us_id) group by us_name

--5.b Frame SQL query to get the total price of all menu items in a particular user’s cart
select sum(me_price) as 'Total Price' from menu_item where me_id IN (select ct_pr_id from cart where ct_us_id IN (select us_id from users where us_name='sai'))

--6 a.Frame SQL query to remove a menu items from Cart based on User Id and Menu Item Id
delete from cart where ct_us_id IN (select us_id from users where us_name='sai') and ct_pr_id IN (select me_id from menu_item where me_name='Pizza') 

select * from cart