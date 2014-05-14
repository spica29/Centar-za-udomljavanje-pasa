SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Centar
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Centar` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Centar` ;

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


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

