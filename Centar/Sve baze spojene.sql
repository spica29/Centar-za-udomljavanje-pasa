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


-- -----------------------------------------------------
-- Table `Centar`.`Pas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Centar`.`Pas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_psa` INT NOT NULL,
  `zdravstveno_stanje` VARCHAR(20) NULL,
  `datum_cipiranja` DATE NULL,
  `datumm_rodjenja` DATE NULL,
  `status` VARCHAR(20) NULL,
  `sterilizovan` TINYINT(1) NOT NULL,
  `datum_sterilizacije` DATE NULL,
  `Klijent_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_psa_UNIQUE` (`id_psa` ASC),
  INDEX `fk_Pas_Klijent1_idx` (`Klijent_id` ASC),
  CONSTRAINT `fk_Pas_Klijent1`
    FOREIGN KEY (`Klijent_id`)
    REFERENCES `Centar`.`Klijent` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Centar`.`Radnik`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Centar`.`Radnik` (
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


-- -----------------------------------------------------
-- Table `Centar`.`Ugovor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Centar`.`Ugovor` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_ugovora` INT NOT NULL,
  `Radnik_id` INT NOT NULL,
  `Pas_id` INT NOT NULL,
  `Klijent_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_ugovora_UNIQUE` (`id_ugovora` ASC),
  INDEX `fk_Ugovor_Radnik1_idx` (`Radnik_id` ASC),
  INDEX `fk_Ugovor_Pas1_idx` (`Pas_id` ASC),
  INDEX `fk_Ugovor_Klijent1_idx` (`Klijent_id` ASC),
  CONSTRAINT `fk_Ugovor_Radnik1`
    FOREIGN KEY (`Radnik_id`)
    REFERENCES `Centar`.`Radnik` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ugovor_Pas1`
    FOREIGN KEY (`Pas_id`)
    REFERENCES `Centar`.`Pas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ugovor_Klijent1`
    FOREIGN KEY (`Klijent_id`)
    REFERENCES `Centar`.`Klijent` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
