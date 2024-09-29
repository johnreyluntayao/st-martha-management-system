-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2022 at 08:08 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `stmartha_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `add_ons_price`
--

CREATE TABLE `add_ons_price` (
  `Add_Ons_ID` int(11) NOT NULL,
  `Tarpaulin` varchar(15) DEFAULT NULL,
  `Flower_Arrangement` varchar(15) DEFAULT NULL,
  `Picture_Frame` varchar(15) DEFAULT NULL,
  `Tribute` int(11) DEFAULT NULL,
  `Free_Balloons` varchar(15) DEFAULT NULL,
  `Roses` varchar(15) DEFAULT NULL,
  `Garden_Viewing` int(11) DEFAULT NULL,
  `Coffee_Bar` int(11) DEFAULT NULL,
  `Karwahe` int(11) DEFAULT NULL,
  `Total_Amount` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `add_ons_price`
--

INSERT INTO `add_ons_price` (`Add_Ons_ID`, `Tarpaulin`, `Flower_Arrangement`, `Picture_Frame`, `Tribute`, `Free_Balloons`, `Roses`, `Garden_Viewing`, `Coffee_Bar`, `Karwahe`, `Total_Amount`) VALUES
(1, '0', '0', '0', 555, '0', '0', 555, 55550, 55557, 112),
(2, '0', '0', '0', 232313123, '0', '0', 0, 0, 0, 232);

-- --------------------------------------------------------

--
-- Table structure for table `add_packages`
--

CREATE TABLE `add_packages` (
  `Add_Package_ID` int(11) NOT NULL,
  `Package_Name` varchar(30) DEFAULT NULL,
  `Package_Inclusions` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Admin_ID` int(10) NOT NULL,
  `Username` varchar(30) DEFAULT NULL,
  `Password` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Admin_ID`, `Username`, `Password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `contract`
--

CREATE TABLE `contract` (
  `Contract_ID` int(10) NOT NULL,
  `Admin_ID` int(10) DEFAULT NULL,
  `Client_ID` int(10) DEFAULT NULL,
  `Deceased_ID` int(10) DEFAULT NULL,
  `Add_Package_ID` int(10) DEFAULT NULL,
  `Contractor_ID` int(11) DEFAULT NULL,
  `Total_Amount` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `contractor`
--

CREATE TABLE `contractor` (
  `Contractor_ID` int(15) NOT NULL,
  `Contractor_Name` varchar(30) DEFAULT NULL,
  `Authorized_Signature` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `contract_client`
--

CREATE TABLE `contract_client` (
  `Client_ID` int(10) NOT NULL,
  `Client_Name` varchar(30) DEFAULT NULL,
  `Relationship_to_the_Deceased` varchar(30) DEFAULT NULL,
  `Age` int(7) DEFAULT NULL,
  `Contact_Number` varchar(15) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `Contractee_Signature` longblob DEFAULT NULL,
  `Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `contract_payment`
--

CREATE TABLE `contract_payment` (
  `Payment_ID` int(10) NOT NULL,
  `Services_ID` int(10) DEFAULT NULL,
  `Add_Package_ID` int(10) DEFAULT NULL,
  `Add_Ons_ID` int(10) DEFAULT NULL,
  `Contract_ID` int(10) DEFAULT NULL,
  `Client_ID` int(10) DEFAULT NULL,
  `Client_Name` varchar(30) DEFAULT NULL,
  `Deposit` int(20) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Balance` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `deceased_information`
--

CREATE TABLE `deceased_information` (
  `Deceased_ID` int(10) NOT NULL,
  `Client_ID` int(11) DEFAULT NULL,
  `Name_of_Deceased` varchar(30) DEFAULT NULL,
  `Date_of_Death` date DEFAULT NULL,
  `Age` int(10) DEFAULT NULL,
  `Birthdate` date DEFAULT NULL,
  `Complete_Address` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `month`
--

CREATE TABLE `month` (
  `Month_ID` int(15) NOT NULL,
  `Months` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `month`
--

INSERT INTO `month` (`Month_ID`, `Months`) VALUES
(1, 'January'),
(2, 'Febuary'),
(3, 'March'),
(4, 'April'),
(5, 'May'),
(6, 'June'),
(7, 'July'),
(8, 'August'),
(9, 'September'),
(10, 'October'),
(11, 'November'),
(12, 'December');

-- --------------------------------------------------------

--
-- Table structure for table `packages`
--

CREATE TABLE `packages` (
  `Package_ID` int(10) NOT NULL,
  `Package_Name` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `packages`
--

INSERT INTO `packages` (`Package_ID`, `Package_Name`) VALUES
(1, 'Ordinary Casket'),
(2, 'Round Top Casket'),
(3, 'Ordinary Special'),
(4, 'Ordinary Special Metal'),
(5, 'OMB Half Glass Metal'),
(6, 'OMB Full Glass Metal'),
(7, 'Ordinary Metal'),
(8, 'Full Cap'),
(9, 'Junior Flexy Metal'),
(10, 'Senior Flexy Metal'),
(11, 'Jango Metal'),
(12, 'Imported Metal Casket');

-- --------------------------------------------------------

--
-- Table structure for table `plan`
--

CREATE TABLE `plan` (
  `Plan_ID` int(10) NOT NULL,
  `Client_ID` int(10) DEFAULT NULL,
  `Plan_Name` varchar(30) DEFAULT NULL,
  `Installment_Payment` int(10) DEFAULT NULL,
  `Gross_Price` int(10) DEFAULT NULL,
  `Term` varchar(30) DEFAULT NULL,
  `Mode` varchar(30) DEFAULT NULL,
  `Due_Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `plan_client`
--

CREATE TABLE `plan_client` (
  `Client_ID` int(10) NOT NULL,
  `Client_Name` varchar(30) DEFAULT NULL,
  `Age` int(5) DEFAULT NULL,
  `Gender` enum('Male','Female') NOT NULL,
  `Address` text DEFAULT NULL,
  `Name_of_trustee` varchar(30) DEFAULT NULL,
  `Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `plan_payment`
--

CREATE TABLE `plan_payment` (
  `Plan_Payment_ID` int(10) NOT NULL,
  `Client_ID` int(10) DEFAULT NULL,
  `Plan_ID` int(10) DEFAULT NULL,
  `Month_ID` int(15) DEFAULT NULL,
  `Client_Name` varchar(30) DEFAULT NULL,
  `Month` varchar(15) NOT NULL,
  `Date` date DEFAULT NULL,
  `I_N` int(11) NOT NULL,
  `OR_No` int(10) DEFAULT NULL,
  `Amount` int(15) DEFAULT NULL,
  `Balance` int(10) DEFAULT NULL,
  `New_Balance` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `Services_ID` int(10) NOT NULL,
  `Embalming` int(11) DEFAULT NULL,
  `Internment` int(11) DEFAULT NULL,
  `Wake_Viewing` int(11) DEFAULT NULL,
  `Free_Chapel` varchar(30) DEFAULT NULL,
  `Total_Amount` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `add_ons_price`
--
ALTER TABLE `add_ons_price`
  ADD PRIMARY KEY (`Add_Ons_ID`);

--
-- Indexes for table `add_packages`
--
ALTER TABLE `add_packages`
  ADD PRIMARY KEY (`Add_Package_ID`);

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`Admin_ID`);

--
-- Indexes for table `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`Contract_ID`),
  ADD KEY `Admin_ID` (`Admin_ID`),
  ADD KEY `Client_ID` (`Client_ID`),
  ADD KEY `Deceased_ID` (`Deceased_ID`),
  ADD KEY `Add_Package_ID` (`Add_Package_ID`),
  ADD KEY `Contractor_ID` (`Contractor_ID`);

--
-- Indexes for table `contractor`
--
ALTER TABLE `contractor`
  ADD PRIMARY KEY (`Contractor_ID`);

--
-- Indexes for table `contract_client`
--
ALTER TABLE `contract_client`
  ADD PRIMARY KEY (`Client_ID`);

--
-- Indexes for table `contract_payment`
--
ALTER TABLE `contract_payment`
  ADD PRIMARY KEY (`Payment_ID`),
  ADD KEY `Services_ID` (`Services_ID`),
  ADD KEY `Add_Packages_ID` (`Add_Package_ID`),
  ADD KEY `Add_Ons_ID` (`Add_Ons_ID`),
  ADD KEY `Contract_ID` (`Contract_ID`),
  ADD KEY `Client_ID` (`Client_ID`);

--
-- Indexes for table `deceased_information`
--
ALTER TABLE `deceased_information`
  ADD PRIMARY KEY (`Deceased_ID`),
  ADD KEY `Client_ID` (`Client_ID`);

--
-- Indexes for table `month`
--
ALTER TABLE `month`
  ADD PRIMARY KEY (`Month_ID`);

--
-- Indexes for table `packages`
--
ALTER TABLE `packages`
  ADD PRIMARY KEY (`Package_ID`);

--
-- Indexes for table `plan`
--
ALTER TABLE `plan`
  ADD PRIMARY KEY (`Plan_ID`),
  ADD KEY `Plan_fk0` (`Client_ID`);

--
-- Indexes for table `plan_client`
--
ALTER TABLE `plan_client`
  ADD PRIMARY KEY (`Client_ID`);

--
-- Indexes for table `plan_payment`
--
ALTER TABLE `plan_payment`
  ADD PRIMARY KEY (`Plan_Payment_ID`),
  ADD KEY `Plan Payment_fk0` (`Client_ID`),
  ADD KEY `Plan Payment_fk1` (`Plan_ID`),
  ADD KEY `Month_ID` (`Month_ID`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`Services_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `add_ons_price`
--
ALTER TABLE `add_ons_price`
  MODIFY `Add_Ons_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `add_packages`
--
ALTER TABLE `add_packages`
  MODIFY `Add_Package_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `Admin_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `contract`
--
ALTER TABLE `contract`
  MODIFY `Contract_ID` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `contractor`
--
ALTER TABLE `contractor`
  MODIFY `Contractor_ID` int(15) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `contract_client`
--
ALTER TABLE `contract_client`
  MODIFY `Client_ID` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `contract_payment`
--
ALTER TABLE `contract_payment`
  MODIFY `Payment_ID` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `deceased_information`
--
ALTER TABLE `deceased_information`
  MODIFY `Deceased_ID` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `month`
--
ALTER TABLE `month`
  MODIFY `Month_ID` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `packages`
--
ALTER TABLE `packages`
  MODIFY `Package_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `plan`
--
ALTER TABLE `plan`
  MODIFY `Plan_ID` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `plan_client`
--
ALTER TABLE `plan_client`
  MODIFY `Client_ID` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `plan_payment`
--
ALTER TABLE `plan_payment`
  MODIFY `Plan_Payment_ID` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `Services_ID` int(10) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `contract_ibfk_1` FOREIGN KEY (`Admin_ID`) REFERENCES `admin` (`Admin_ID`),
  ADD CONSTRAINT `contract_ibfk_2` FOREIGN KEY (`Client_ID`) REFERENCES `contract_client` (`Client_ID`),
  ADD CONSTRAINT `contract_ibfk_3` FOREIGN KEY (`Deceased_ID`) REFERENCES `deceased_information` (`Deceased_ID`),
  ADD CONSTRAINT `contract_ibfk_4` FOREIGN KEY (`Add_Package_ID`) REFERENCES `add_packages` (`Add_Package_ID`),
  ADD CONSTRAINT `contract_ibfk_7` FOREIGN KEY (`Contractor_ID`) REFERENCES `contractor` (`Contractor_ID`);

--
-- Constraints for table `contract_payment`
--
ALTER TABLE `contract_payment`
  ADD CONSTRAINT `contract_payment_ibfk_1` FOREIGN KEY (`Services_ID`) REFERENCES `services` (`Services_ID`),
  ADD CONSTRAINT `contract_payment_ibfk_2` FOREIGN KEY (`Add_Package_ID`) REFERENCES `packages` (`Package_ID`),
  ADD CONSTRAINT `contract_payment_ibfk_3` FOREIGN KEY (`Add_Ons_ID`) REFERENCES `add_ons_price` (`Add_Ons_ID`),
  ADD CONSTRAINT `contract_payment_ibfk_4` FOREIGN KEY (`Contract_ID`) REFERENCES `contract` (`Contract_ID`),
  ADD CONSTRAINT `contract_payment_ibfk_5` FOREIGN KEY (`Client_ID`) REFERENCES `contract_client` (`Client_ID`);

--
-- Constraints for table `deceased_information`
--
ALTER TABLE `deceased_information`
  ADD CONSTRAINT `deceased_information_ibfk_1` FOREIGN KEY (`Client_ID`) REFERENCES `contract_client` (`Client_ID`);

--
-- Constraints for table `plan`
--
ALTER TABLE `plan`
  ADD CONSTRAINT `Plan_fk0` FOREIGN KEY (`Client_ID`) REFERENCES `plan_client` (`Client_ID`);

--
-- Constraints for table `plan_payment`
--
ALTER TABLE `plan_payment`
  ADD CONSTRAINT `Plan Payment_fk0` FOREIGN KEY (`Client_ID`) REFERENCES `plan_client` (`Client_ID`),
  ADD CONSTRAINT `Plan Payment_fk1` FOREIGN KEY (`Plan_ID`) REFERENCES `plan` (`Plan_ID`),
  ADD CONSTRAINT `plan_payment_ibfk_1` FOREIGN KEY (`Month_ID`) REFERENCES `month` (`Month_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
