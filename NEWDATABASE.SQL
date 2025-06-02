-- /////////////////////////////////////////////
-- ////////  PRODUCTS TABLES  //////////////////
-- /////////////////////////////////////////////
-- 
CREATE TABLE Products (
    product_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    cost DECIMAL(10, 2) NOT NULL,
    sku VARCHAR(100),
    category_id INT,
    barcode text,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);

-- /////////////////////////////////////////////
-- ////////  Categories TABLES  //////////////////
-- /////////////////////////////////////////////
-- 
CREATE TABLE Categories (
    category_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);
ALTER TABLE categories ADD COLUMN ACTIVE BIT NOT NULL DEFAULT 1 AFTER NAME;
ALTER TABLE CATEGORIES ADD COLUMN DESCRIPTION TEXT NOT NULL DEFAULT '--- GENERAL ---' AFTER NAME;

CREATE TABLE Inventory (
    inventory_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT,
    quantity_in_stock INT NOT NULL,
    reorder_level INT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);
 
CREATE TABLE Customers (
    customer_id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    email VARCHAR(255),
    CEDULA VARCHAR(20) NOT NULL DEFAULT '626-NON',
    phone VARCHAR(15),
    DEL BIT(9) NOT NULL DEFAULT b'0',
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO Customers (customer_id, first_name, last_name, email, phone, created_at)
VALUES (0, 'Anonymous', '', '', '', NOW());

ALTER TABLE `customers` ADD COLUMN CEDULA VARCHAR(20) NOT NULL DEFAULT '626-NON' AFTER EMAIL
ALTER TABLE `customers` ADD COLUMN DEL BIT NOT NULL DEFAULT 1 AFTER PHONE
ALTER TABLE `customers` CHANGE `DEL` `DEL` BIT(9) NOT NULL DEFAULT b'0';
 

CREATE TABLE Anonymous_Sales (
    anonymous_sale_id INT PRIMARY KEY AUTO_INCREMENT,
    sale_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    total_amount DECIMAL(10, 2) NOT NULL,
    payment_method VARCHAR(50),
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);
 

CREATE TABLE Payments (
    payment_id INT PRIMARY KEY AUTO_INCREMENT,
    sale_id INT,
    amount DECIMAL(10, 2) NOT NULL,
    payment_method VARCHAR(50),
    payment_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (sale_id) REFERENCES Sales(sale_id)
);

CREATE TABLE Discounts (
    discount_id INT PRIMARY KEY AUTO_INCREMENT,
    description VARCHAR(255),
    discount_percentage DECIMAL(5, 2),
    start_date DATETIME,
    end_date DATETIME,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
); 

CREATE TABLE Suppliers (
    supplier_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    contact_info VARCHAR(255),
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Inventory_Adjustments (
    adjustment_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT,
    adjustment_type ENUM('increase', 'decrease'),
    quantity INT NOT NULL,
    reason VARCHAR(255),
    adjustment_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

CREATE TABLE Audit_Logs (
    log_id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT,
    action VARCHAR(255),
    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);
 

-- 1. Users Table

--/////////////////////////////////////////////////////////////////////
--/////////////////////   User table  /////////////////////////////////
--/////////////////////////////////////////////////////////////////////

CREATE TABLE `users` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UNAME` varchar(50) NOT NULL,
  `SRNAME` varchar(50) NOT NULL,
  `IDNUMBER` varchar(50) NOT NULL,
  `MOBILE` varchar(20) DEFAULT NULL,
  `REGDATE` datetime NOT NULL DEFAULT current_timestamp(),
  `NATIONALITY` varchar(10) NOT NULL DEFAULT 'NIC',
  `GENDER` varchar(10) NOT NULL,
  `LOCATION` varchar(100) DEFAULT 'PEARL LAGOON',
  `LOGIN` varchar(100) NOT NULL,
  `PASS` text NOT NULL,
  `FIRED` int(11) NOT NULL DEFAULT 0,
  `ROLE` varchar(50) NOT NULL DEFAULT 'CASHIER',
  `IsDeleted` bit(1) NOT NULL DEFAULT b'0' COMMENT 'Borado o no',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `IDNUMBER` (`IDNUMBER`),
  UNIQUE KEY `LOGIN` (`LOGIN`),
  UNIQUE KEY `IDNUMBER_2` (`IDNUMBER`),
  UNIQUE KEY `LOGIN_2` (`LOGIN`),
  UNIQUE KEY `IDNUMBER_3` (`IDNUMBER`),
  UNIQUE KEY `LOGIN_3` (`LOGIN`),
  UNIQUE KEY `UNAME` (`UNAME`,`SRNAME`,`IDNUMBER`,`MOBILE`,`REGDATE`,`NATIONALITY`,`LOGIN`,`GENDER`,`LOCATION`,`FIRED`,`ROLE`),
  UNIQUE KEY `UNAME_2` (`UNAME`,`SRNAME`,`IDNUMBER`,`MOBILE`,`REGDATE`,`NATIONALITY`,`LOGIN`,`GENDER`,`LOCATION`,`FIRED`,`ROLE`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci



--if updateting the old database
ALTER TABLE `users` ADD `IsDeleted` BIT NOT NULL default 0 COMMENT 'Borado o no' AFTER `ROLE`;

-- 2. Categories Table
CREATE TABLE Categories (
    Category_ID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description VARCHAR(255)
)
ALTER TABLE `marshell`.`categories` 
ADD COLUMN `Active` BIT(9) NOT NULL DEFAULT 1 AFTER `Description`;
ALTER TABLE `marshell`.`categories` 
ADD COLUMN  created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  AdD column  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP;

  -- if category has incoerect id name
ALTER TABLE `marshell`.`categories` 
CHANGE COLUMN `CategoryID` `Category_ID` INT(11) NOT NULL AUTO_INCREMENT ;
alter table categories change Active Active TINYINT NOT NULL DEFAULT 1;

-- 3. Products Table
CREATE TABLE products (
    product_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    price DECIMAL(10,2) NOT NULL,
    cost DECIMAL(10,2) NOT NULL,
    sku VARCHAR(100) UNIQUE NOT NULL,
    category_id INT NOT NULL,
    barcode VARCHAR(100),
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);


CREATE TABLE Sales (
    SaleId INT AUTO_INCREMENT PRIMARY KEY,           -- Auto-increment SaleId
    OrderNumber VARCHAR(50) NOT NULL,                -- Order number (unique identifier for the sale)
    SaleDate DATETIME NOT NULL,                      -- Date of the sale
    TotalAmount DECIMAL(18, 2) NOT NULL,             -- Total amount for the sale
    TaxAmount DECIMAL(18, 2) NOT NULL,               -- Total tax amount for the sale
    ShippingCost DECIMAL(18, 2) NOT NULL,            -- Shipping cost (if applicable)
    DiscountAmount DECIMAL(18, 2) NOT NULL,          -- Total discount applied
    CustomerId INT DEFAULT NULL,                     -- Customer who made the purchase (nullable)
    PaymentMethod VARCHAR(50) NOT NULL,              -- Payment method (e.g., Credit Card, PayPal)
    SaleStatus VARCHAR(50) NOT NULL,                 -- Status of the sale (e.g., Completed, Pending)
    CreatedAt DATETIME NOT NULL,                     -- Timestamp when the sale was created
    ShippingAddress VARCHAR(255) NOT NULL,           -- Shipping address for the order
    CustomerEmail VARCHAR(100) DEFAULT NULL,         -- Email of the customer (optional)
    CustomerPhone VARCHAR(50) DEFAULT NULL           -- Phone number of the customer (optional)
);

-- 6 to store cartitems that are sold
CREATE TABLE CartItems (
    CartItemId INT AUTO_INCREMENT PRIMARY KEY,      -- Auto-increment CartItemId
    ProductId INT NOT NULL,                          -- The product ID
    ProductName VARCHAR(255) NOT NULL,                -- The name of the product
    Price DECIMAL(18, 2) NOT NULL,                   -- Price of the product
    Quantity INT NOT NULL,                           -- Quantity of the product in the cart
    Discount DECIMAL(18, 2) DEFAULT 0,               -- Discount applied to the product (if any)
    TaxAmount DECIMAL(18, 2) DEFAULT 0,              -- Tax applied to the product
    SaleId INT NOT NULL,                             -- Foreign key to Sales table
    ProductImage VARCHAR(255) DEFAULT NULL,          -- URL or path to the product image (optional)
    ProductDescription TEXT DEFAULT NULL,            -- Product description (optional)
    FOREIGN KEY (SaleId) REFERENCES Sales(SaleId)   -- Foreign key linking CartItems to Sales
)
ALTER TABLE cartitems ADD Saledate DATE NOT NULL default Now() AFTER SaleId, ADD Ordernumber VARCHAR(20) NOT NULL AFTER Saledate;



-- 7. Cart Table (Optional for Online Store)
CREATE TABLE Cart (
    CartID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    DateAdded DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- 8. AuditLogs Table (Optional for Admin)
CREATE TABLE AuditLogs (
    LogID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    Action VARCHAR(255) NOT NULL,
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);



INSERT INTO Sales 
(OrderNumber, SaleDate, TotalAmount, TaxAmount, ShippingCost, DiscountAmount, CustomerId, PaymentMethod, SaleStatus, CreatedAt, ShippingAddress, CustomerEmail, CustomerPhone)
VALUES
('ORD202501200001', NOW(), 150.00, 15.00, 5.00, 10.00, 1, 'Credit Card', 'Completed', NOW(), '123 Main St, Anytown, USA', 'customer@example.com', '123-456-7890');

INSERT INTO CartItems
(ProductId, ProductName, Price, Quantity, Discount, TaxAmount, SaleId, ProductImage, ProductDescription)
VALUES
(1, 'Product 1', 50.00, 2, 5.00, 3.00, 1, 'product1.jpg', 'Description of Product 1'),
(2, 'Product 2', 30.00, 1, 0.00, 1.50, 1, 'product2.jpg', 'Description of Product 2'),
(3, 'Product 3', 40.00, 3, 10.00, 2.50, 1, 'product3.jpg', 'Description of Product 3');



SET @SaleId = LAST_INSERT_ID();


START TRANSACTION;

-- Insert Sale
INSERT INTO Sales 
(OrderNumber, SaleDate, TotalAmount, TaxAmount, ShippingCost, DiscountAmount, CustomerId, PaymentMethod, SaleStatus, CreatedAt, ShippingAddress, CustomerEmail, CustomerPhone)
VALUES
('ORD202501200001', NOW(), 150.00, 15.00, 5.00, 10.00, 1, 'Credit Card', 'Completed', NOW(), '123 Main St, Anytown, USA', 'customer@example.com', '123-456-7890');

SET @SaleId = LAST_INSERT_ID();

-- Insert CartItems
INSERT INTO CartItems
(ProductId, ProductName, Price, Quantity, Discount, TaxAmount, SaleId, ProductImage, ProductDescription)
VALUES
(1, 'Product 1', 50.00, 2, 5.00, 3.00, @SaleId, 'product1.jpg', 'Description of Product 1'),
(2, 'Product 2', 30.00, 1, 0.00, 1.50, @SaleId, 'product2.jpg', 'Description of Product 2'),
(3, 'Product 3', 40.00, 3, 10.00, 2.50, @SaleId, 'product3.jpg', 'Description of Product 3');

COMMIT;


INSERT INTO Returns 
(SaleId, CartItemId, ReturnDate, QuantityReturned, ReturnReason, RefundAmount, ReturnStatus, CreatedAt)
VALUES
(1, 2, NOW(), 1, 'Defective', 40.00, 'Pending', NOW());




CREATE USER 'marshell'@'%' IDENTIFIED VIA mysql_native_password USING '***';GRANT ALL PRIVILEGES ON *.* TO 'marshell'@'%' REQUIRE NONE WITH GRANT OPTION MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;GRANT ALL PRIVILEGES ON `marshell\_%`.* TO 'marshell'@'%';




-- Scripts to transfer data to new products tables
INSERT INTO products (
    name,
    description,
    price,
    cost,
    sku,
    category_id,
    barcode,
    created_at,
    updated_at
)
SELECT 
    Productname AS name,
    Productname AS description,
    productprice AS price,
    10.00 AS cost,                      -- You can change this default
    productcode AS sku,
    1 AS category_id,                   -- Assuming default category
    productcode AS barcode,
    NOW() AS created_at,
    NOW() AS updated_at
FROM product;
