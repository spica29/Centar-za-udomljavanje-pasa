SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Centar
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Centar` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Centar` ;

-- -----------------------------------------------------
-- Table `Centar`.`Klijent`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Centar`.`Klijent` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `jmb` VARCHAR(13) NOT NULL,
  `ime` VARCHAR(20) NULL,
  `prezime` VARCHAR(30) NULL,
  `adresa` VARCHAR(50) NULL,
  `datum_preuzimanja_psa` DATE NULL,
  `Pas_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `jmb_UNIQUE` (`jmb` ASC),
  INDEX `fk_Klijent_Pas_idx` (`Pas_id` ASC),
  CONSTRAINT `fk_Klijent_Pas`
    FOREIGN KEY (`Pas_id`)
    REFERENCES `Centar`.`Pas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
