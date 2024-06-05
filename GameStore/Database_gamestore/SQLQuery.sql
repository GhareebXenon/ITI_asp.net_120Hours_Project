create table Customer(
	Customer_ID int primary key identity (1,1),
	Customer_FName varchar(100) not null,
	Customer_LName varchar(100) not null,
	Customer_Phone char(11) not null unique,
	Customer_Address varchar(100),
);

create table Product(
	Product_code int primary key identity (1,1),
	Product_name varchar(50) not null unique,
	Product_price decimal (10,2) not null,
	Publisher_ID int foreign key references Publisher (Publisher_ID)
	on delete cascade
	on update cascade,
	Category varchar(50) not null
);

create table Publisher(
	Publisher_ID int primary key identity (1,1),
	Publisher_Name varchar(30) not null unique,
	Publisher_Email varchar(30) not null unique,


);
create table Customer_Order(
	order_id Integer PRIMARY KEY identity (1,1),
	date_order date,
	product Integer,
	product_count Integer,
	customer Integer,
	order_status varchar(50) not null,
	Foreign key (customer) references Customer(customer_ID)
	ON DELETE CASCADE 
	ON UPDATE CASCADE,

	foreign key (product)
	references Product(Product_code)
	ON DELETE CASCADE 
	ON UPDATE CASCADE,
	

);