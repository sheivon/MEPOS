DELIMITER $$

CREATE PROCEDURE SaveOrUpdateProduct(
    IN p_name VARCHAR(255),
    IN p_description TEXT,
    IN p_price DECIMAL(10, 2),
    IN p_cost DECIMAL(10, 2),
    IN p_sku VARCHAR(100),
    IN p_category_id INT,
    IN p_barcode TEXT,
    OUT p_id INT
)
BEGIN
    DECLARE existing_id INT;

    -- Check if the product already exists by unique field(s) (e.g., SKU or Barcode)
    SELECT product_id INTO existing_id 
    FROM Products 
    WHERE sku = p_sku OR barcode = p_barcode
    LIMIT 1;

    -- If the product exists, update it
    IF existing_id IS NOT NULL THEN
        UPDATE Products
        SET 
            name = p_name,
            description = p_description,
            price = p_price,
            cost = p_cost,
            category_id = p_category_id,
            barcode = p_barcode,
            updated_at = CURRENT_TIMESTAMP
        WHERE product_id = existing_id;

        -- Return the updated product_id
        SET p_id = existing_id;

    -- If the product does not exist, insert a new row
    ELSE
        INSERT INTO Products (
            name, description, price, cost, sku, category_id, barcode, created_at, updated_at
        ) VALUES (
            p_name, p_description, p_price, p_cost, p_sku, p_category_id, p_barcode, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
        );

        -- Return the newly inserted product_id
        SET p_id = LAST_INSERT_ID();
    END IF;
END$$

DELIMITER ;

-- Declare a variable to hold the returned product_id
SET @product_id = NULL;

-- Call the procedure
CALL SaveOrUpdateProduct(
    'Laptop', 
    'High performance laptop', 
    1500.00, 
    1200.00, 
    'SKU12345', 
    1, 
    'BARCODE98765', 
    @product_id
);

-- View the returned product_id
SELECT @product_id;

DELIMITER $$

CREATE PROCEDURE SaveOrUpdateProduct(
    IN p_name VARCHAR(255),
    IN p_description TEXT,
    IN p_price DECIMAL(10, 2),
    IN p_cost DECIMAL(10, 2),
    IN p_sku VARCHAR(100),
    IN p_category_id INT,
    IN p_barcode TEXT,
    OUT p_id INT
)
BEGIN
    DECLARE existing_id INT;

    SELECT product_id INTO existing_id 
    FROM Products 
    WHERE sku = p_sku OR barcode = p_barcode
    LIMIT 1;

    IF existing_id IS NOT NULL THEN
        UPDATE Products
        SET 
            name = p_name,
            description = p_description,
            price = p_price,
            cost = p_cost,
            category_id = p_category_id,
            barcode = p_barcode,
            updated_at = CURRENT_TIMESTAMP
        WHERE product_id = existing_id;

        SET p_id = existing_id;
    ELSE
        INSERT INTO Products (
            name, description, price, cost, sku, category_id, barcode, created_at, updated_at
        ) VALUES (
            p_name, p_description, p_price, p_cost, p_sku, p_category_id, p_barcode, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
        );

        SET p_id = LAST_INSERT_ID();
    END IF;
END$$

DELIMITER ;




DELIMITER $$

CREATE PROCEDURE SaveOrUpdateCategory(
    IN p_name VARCHAR(255),
    IN p_active BIT,
    OUT p_id INT
)
BEGIN
    DECLARE existing_id INT;

    SELECT category_id INTO existing_id 
    FROM Categories 
    WHERE name = p_name
    LIMIT 1;

    IF existing_id IS NOT NULL THEN
        UPDATE Categories
        SET 
            name = p_name,
            active = p_active,
            updated_at = CURRENT_TIMESTAMP
        WHERE category_id = existing_id;

        SET p_id = existing_id;
    ELSE
        INSERT INTO Categories (name, active, created_at, updated_at)
        VALUES (p_name, p_active, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);

        SET p_id = LAST_INSERT_ID();
    END IF;
END$$

DELIMITER ;


DELIMITER $$

CREATE PROCEDURE SaveOrUpdateCustomer(
    IN p_first_name VARCHAR(100),
    IN p_last_name VARCHAR(100),
    IN p_email VARCHAR(255),
    IN p_phone VARCHAR(15),
    IN p_cedula VARCHAR(20),
    IN p_del BIT,
    OUT p_id INT
)
BEGIN
    DECLARE existing_id INT;

    SELECT customer_id INTO existing_id 
    FROM Customers 
    WHERE email = p_email
    LIMIT 1;

    IF existing_id IS NOT NULL THEN
        UPDATE Customers
        SET 
            first_name = p_first_name,
            last_name = p_last_name,
            phone = p_phone,
            cedula = p_cedula,
            del = p_del,
            updated_at = CURRENT_TIMESTAMP
        WHERE customer_id = existing_id;

        SET p_id = existing_id;
    ELSE
        INSERT INTO Customers (
            first_name, last_name, email, phone, cedula, del, created_at
        ) VALUES (
            p_first_name, p_last_name, p_email, p_phone, p_cedula, p_del, CURRENT_TIMESTAMP
        );

        SET p_id = LAST_INSERT_ID();
    END IF;
END$$

DELIMITER ;



DELIMITER $$

CREATE PROCEDURE SaveOrUpdateSale(
    IN p_sale_date DATETIME,
    IN p_total_amount DECIMAL(10, 2),
    IN p_customer_id INT,
    IN p_payment_method VARCHAR(50),
    OUT p_id INT
)
BEGIN
    DECLARE existing_id INT;

    SELECT sale_id INTO existing_id 
    FROM Sales 
    WHERE sale_date = p_sale_date AND customer_id = p_customer_id
    LIMIT 1;

    IF existing_id IS NOT NULL THEN
        UPDATE Sales
        SET 
            total_amount = p_total_amount,
            payment_method = p_payment_method,
            updated_at = CURRENT_TIMESTAMP
        WHERE sale_id = existing_id;

        SET p_id = existing_id;
    ELSE
        INSERT INTO Sales (
            sale_date, total_amount, customer_id, payment_method, created_at
        ) VALUES (
            p_sale_date, p_total_amount, p_customer_id, p_payment_method, CURRENT_TIMESTAMP
        );

        SET p_id = LAST_INSERT_ID();
    END IF;
END$$

DELIMITER ;


DELIMITER $$

CREATE PROCEDURE SaveOrUpdateInventory(
    IN p_product_id INT,
    IN p_quantity_in_stock INT,
    IN p_reorder_level INT,
    OUT p_id INT
)
BEGIN
    DECLARE existing_id INT;

    SELECT inventory_id INTO existing_id 
    FROM Inventory 
    WHERE product_id = p_product_id
    LIMIT 1;

    IF existing_id IS NOT NULL THEN
        UPDATE Inventory
        SET 
            quantity_in_stock = p_quantity_in_stock,
            reorder_level = p_reorder_level,
            updated_at = CURRENT_TIMESTAMP
        WHERE inventory_id = existing_id;

        SET p_id = existing_id;
    ELSE
        INSERT INTO Inventory (
            product_id, quantity_in_stock, reorder_level, created_at, updated_at
        ) VALUES (
            p_product_id, p_quantity_in_stock, p_reorder_level, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP
        );

        SET p_id = LAST_INSERT_ID();
    END IF;
END$$

DELIMITER ;
