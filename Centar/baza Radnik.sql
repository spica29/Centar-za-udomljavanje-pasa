SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Centar
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Centar` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Centar` ;

-- -----------------------------------------------------
-- Table `Centar`.`Radnik`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Radnik` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `jbm` VARCHAR(13) NOT NULL,
  `ime` VARCHAR(20) NULL,
  `prezime` VARCHAR(30) NULL,
  `adresa` VARCHAR(50) NULL,
  `opis_posla` VARCHAR(30) NULL,
  `datum_rodjenja` DATE NULL,
  `username` VARCHAR(20) NULL,
  `password` VARCHAR(15) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `jbm_UNIQUE` (`jbm` ASC),
  UNIQUE INDEX `password_UNIQUE` (`password` ASC))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;