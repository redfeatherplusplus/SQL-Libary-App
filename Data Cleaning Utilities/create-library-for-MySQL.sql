-- From the MySQL prompt,execute this file,e.g.
-- SYNTAX:
--     mysql> SOURCE <filename>
-- EXAMPLE:
--     mysql> SOURCE C:\Users\Cheng\Documents\Visual Studio 2013\Projects\SQL Library Project\Data Cleaning Utilities\create-library-for-MySQL.sql



DROP SCHEMA IF EXISTS Library;
CREATE SCHEMA Library;
USE Library;

DROP TABLE IF EXISTS BOOK;
CREATE TABLE BOOK (
  Isbn VARCHAR(13) NOT NULL,
  Title VARCHAR(255) NOT NULL,
  Cover VARCHAR(255),
  Publisher VARCHAR(255),
  Pages INT,
  CONSTRAINT pk_Book PRIMARY KEY (Isbn)
);

DROP TABLE IF EXISTS AUTHORS;
CREATE TABLE AUTHORS (
  Author_id INT(11) NOT NULL AUTO_INCREMENT,
  Name VARCHAR(255) NOT NULL,
  CONSTRAINT pk_Authors PRIMARY KEY (Author_id),
  CONSTRAINT uk_Authors_Name UNIQUE (Name)
);

DROP TABLE IF EXISTS BOOK_AUTHORS;
CREATE TABLE BOOK_AUTHORS (
  Author_id INT NOT NULL,
  Isbn VARCHAR(13) NOT NULL,
  CONSTRAINT pk_Book_Authors PRIMARY KEY (Author_id, Isbn),
  CONSTRAINT fk_Book_Authors_Author_id FOREIGN KEY (Author_id) REFERENCES AUTHORS(Author_id),
  CONSTRAINT fk_Book_Authors_Isbn FOREIGN KEY (Isbn) REFERENCES BOOK(Isbn)
);

DROP TABLE IF EXISTS BORROWER;
CREATE TABLE BORROWER (
  Card_id INT NOT NULL AUTO_INCREMENT,
  Ssn VARCHAR(11) NOT NULL,
  Fname VARCHAR(255) NOT NULL,
  Lname VARCHAR(255) NOT NULL,
  Email VARCHAR(255),
  Address VARCHAR(255) NOT NULL,
  City VARCHAR(255),
  State VARCHAR(2),
  Phone VARCHAR(14),
  CONSTRAINT pk_Borrower PRIMARY KEY (Card_id),
  CONSTRAINT uk_Borrower_Ssn UNIQUE (Ssn)
);

DROP TABLE IF EXISTS BOOK_LOANS;
CREATE TABLE BOOK_LOANS (
  Loan_id int NOT NULL AUTO_INCREMENT,
  Isbn VARCHAR(13) NOT NULL,
  Card_id int NOT NULL,
  Date_out DATE,
  Due_date DATE,
  Date_in DATE,
  CONSTRAINT pk_Book_Loans PRIMARY KEY (Loan_id),
  CONSTRAINT fk_Book_Loans_Isbn FOREIGN KEY (Isbn) REFERENCES BOOK(Isbn),
  CONSTRAINT fk_Book_Loans_Card_id FOREIGN KEY (Card_id) REFERENCES BORROWER(Card_id)
);

DROP TABLE IF EXISTS FINES; 
CREATE TABLE FINES ( 
  Loan_id int NOT NULL, 
  Fine_amt DECIMAL, 
  Paid BOOLEAN, 
  CONSTRAINT pk_Fines PRIMARY KEY (Loan_id),
  CONSTRAINT fk_Fines_Loan_id FOREIGN KEY (Loan_id) REFERENCES BOOK_LOANS(Loan_id)
);


-- Insert Statements
-- CSV Files must be in the secure_file directory, which
-- can be found using: SHOW VARIABLES LIKE "secure_file_priv"
SET foreign_key_checks = 0;

LOAD DATA INFILE 'C:/ProgramData/MySQL/MySQL Server 5.7/Uploads/book.csv'
INTO TABLE BOOK
FIELDS TERMINATED BY '\t'
IGNORE 1 LINES (Isbn, Title, Cover, Publisher, Pages);


LOAD DATA INFILE 'C:/ProgramData/MySQL/MySQL Server 5.7/Uploads/authors.csv'
INTO TABLE AUTHORS
FIELDS TERMINATED BY '\t'
IGNORE 1 LINES (Author_id, Name);


LOAD DATA INFILE 'C:/ProgramData/MySQL/MySQL Server 5.7/Uploads/book_authors.csv'
INTO TABLE BOOK_AUTHORS
FIELDS TERMINATED BY '\t'
IGNORE 1 LINES (Author_id, Isbn);


LOAD DATA INFILE 'C:/ProgramData/MySQL/MySQL Server 5.7/Uploads/borrowers.csv'
INTO TABLE BORROWER
FIELDS TERMINATED BY ','
IGNORE 1 LINES (Card_id, Ssn,Fname, Lname, Email, Address, City, State, Phone);

SET foreign_key_checks = 1;


-- Adding state constraints and triggers after loading data into system

-- Database
DELIMITER //
CREATE TRIGGER default_Book_Loans_Date_out BEFORE INSERT ON BOOK_LOANS FOR EACH ROW
BEGIN
  IF ISNULL(NEW.Date_out) THEN
    SET NEW.Date_out = CURRENT_DATE;
  END IF;
END //
DELIMITER ;

DELIMITER //
CREATE TRIGGER default_Book_Loans_Due_date BEFORE INSERT ON BOOK_LOANS FOR EACH ROW
BEGIN
  IF ISNULL(NEW.Due_date) THEN
    SET NEW.Due_date = DATE_ADD(CURRENT_DATE, INTERVAL 14 DAY);
  END IF;
END //
DELIMITER ;

-- Book checkout
DELIMITER //
CREATE TRIGGER book_checkout_available BEFORE INSERT ON BOOK_LOANS FOR EACH ROW
BEGIN
  IF (
    (
	  SELECT COUNT(*) 
	  FROM BOOK_LOANS BL
	  WHERE BL.Isbn = NEW.Isbn AND ISNULL(Date_in)
    ) 
	> 0 
  ) 
  THEN
    SIGNAL SQLSTATE '45001' SET MESSAGE_TEXT = 'Book not available.';
  END IF;
END //
DELIMITER ;

DELIMITER //
CREATE TRIGGER book_checkout_limit BEFORE INSERT ON BOOK_LOANS FOR EACH ROW
BEGIN
  IF (
    (
	  SELECT COUNT(*) 
	  FROM BOOK_LOANS BL
	  WHERE BL.Card_id = NEW.Card_id AND ISNULL(Date_in)
    ) 
	>= 3 
  ) 
  THEN
    SIGNAL SQLSTATE '45002' SET MESSAGE_TEXT = 'Book checkout limit reached.';
  END IF;
END //
DELIMITER ;

DELIMITER //
CREATE TRIGGER book_checkout_fines BEFORE INSERT ON BOOK_LOANS FOR EACH ROW
BEGIN
  IF (
    (
	  SELECT COUNT(*) 
	  FROM BOOK_LOANS BL, FINES FN
	  WHERE BL.Card_id = NEW.Card_id AND BL.Loan_id = FN.Loan_id AND FN.PAID = FALSE
    ) 
	> 0 
  ) 
  THEN
    SIGNAL SQLSTATE '45003' SET MESSAGE_TEXT = 'Cannot checkout book due to account fines.';
  END IF;
END //
DELIMITER ;

DELIMITER //
CREATE TRIGGER book_checkout_overdue BEFORE INSERT ON BOOK_LOANS FOR EACH ROW
BEGIN
  IF (
    (
	  SELECT COUNT(*) 
	  FROM BOOK_LOANS BL
	  WHERE BL.Card_id = NEW.Card_id AND BL.Due_date < CURRENT_DATE AND ISNULL(BL.Date_in)
    ) 
	> 0 
  ) 
  THEN
    SIGNAL SQLSTATE '45004' SET MESSAGE_TEXT = 'Cannot checkout book due to overdue book.';
  END IF;
END //
DELIMITER ;

-- Book check in 
DELIMITER //
CREATE TRIGGER book_check_in_fines AFTER UPDATE ON BOOK_LOANS FOR EACH ROW
BEGIN
  IF (NEW.Due_date < NEW.Date_in) THEN
    INSERT INTO FINES (Loan_id, Fine_amt, Paid)
	VALUES (NEW.Loan_id, DATEDIFF(NEW.Date_in, NEW.Due_date) * 0.25, FALSE);
  END IF;
END //
DELIMITER ;


-- Select Statements for all the tables
-- SELECT * FROM BOOK;
-- SELECT * FROM AUTHORS;
-- SELECT * FROM BOOK_AUTHORS;
-- SELECT * FROM BORROWER;
-- SELECT * FROM BOOK_LOANS;
-- SELECT * FROM FINES;
