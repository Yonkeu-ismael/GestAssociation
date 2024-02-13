DELIMITER $$
USE `bd_tontine`$$


DROP PROCEDURE IF EXISTS `procedure_operation`$$

CREATE DEFINER=`ismael`@`localhost`PROCEDURE `bd_tontine`.`procedure_operation`(code_operation INT,numcompte VARCHAR(20), codecycle INT, montant DOUBLE, dateop VARCHAR(20), typeop VARCHAR(20), sens VARCHAR(20))
   
 BEGIN
	

	INSERT INTO operation(code_operation,numero_compte,code_cycle,montant,date_op,type_op,sens)
	VALUES (NULL,numcompte,codecycle,montant,dateop,typeop,sens);
	
 END$$

DELIMITER ;