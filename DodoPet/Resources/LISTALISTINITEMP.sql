SELECT ISNULL(ar_codart, '') ar_codart, 
       xx_codart, 
       xx_prezzo, 
       ar_descr, 
       ISNULL(
(
    SELECT lc_prezzo
    FROM listini
    WHERE lc_listino = 91 and lc_codart = ar_codart
          AND lc_datscad > GETDATE() and lc_unmis = (select ar_unmis from artico where ar_codart = lc_codart)
), 0) xx_prezzoattuale
FROM hhLISTINODODOPET
     LEFT JOIN artico ON ar_codart = xx_codart;