CREATE DATABASE tip_calculator_db
GO
USE tip_calculator_db
GO
CREATE TABLE tip_calculator_history (
	bill_id INT IDENTITY(1,1) PRIMARY KEY,
	bill DECIMAL (18,2) NOT NULL,
	tip_persentage DECIMAL (18,2) NOT NULL,
	total_tip DECIMAL (18,2) NOT NULL,
	total_bill DECIMAL (18,2) NOT NULL,
	total_person INT NOT NULL,
	tip_per_person DECIMAL (18,2) NOT NULL,
	bill_time DATETIME NOT NULL
)