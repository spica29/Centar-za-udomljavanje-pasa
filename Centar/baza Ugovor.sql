SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Centar
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Centar` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Centar` ;

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
