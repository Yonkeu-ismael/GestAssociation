DELIMITER $$
USE `bd_tontine`$$
DROP PROCEDURE IF EXISTS `creation_numero_compte`$$
CREATE DEFINER=`ismael`@`localhost` PROCEDURE `creation_numero_compte`( nom VARCHAR(100), prenom VARCHAR(100),sexe VARCHAR(20), datenaiss VARCHAR(20), dateadhe VARCHAR(20), telephone TEXT, adremail VARCHAR(25), pays VARCHAR(20), numcni VARCHAR(20),sitmat VARCHAR(20),adresse VARCHAR(20))
    
BEGIN
             
        DECLARE numerocompte VARCHAR(20); 
	DECLARE codetype VARCHAR(20);
	
	SELECT CONCAT(SUBSTR(SYSDATE(),3,2),'A',LPAD((SELECT COUNT(*)+1 FROM adherent),6,'0')) FROM DUAL;
	SELECT numero INTO codetype FROM type_compte WHERE classe='4';
	INSERT INTO compte VALUES (numero_compte,codetype,numerocompte,'retrait','encaissement','virement');
	INSERT INTO adherent (nom,prenom,numero_compte,tel,adresse,sit_mat,pays,date_naiss,email,sexe,date_adh,numCNI)
	VALUES (codeadherent,nom,prenom,numerocompte,telephone,adresse,sitmat,pays,datenaiss,adremail,sexe,dateadhe,numcni);
	COMMIT;

END$$

DELIMITER ;