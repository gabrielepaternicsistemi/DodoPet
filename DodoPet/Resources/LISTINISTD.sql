
SELECT ar_codart, 
       ar_gruppo, 
       tb_desgmer, 
       ar_claprov, 
       tb_descpar, 
	   ar_descr,
(
    SELECT TOP 1 lc_prezzo
    FROM listini
    WHERE lc_conto = 0
          AND lc_datscad > GETDATE()
          AND lc_codart = ar_codart
          AND lc_listino = 91
          AND lc_unmis <> ' '
) xx_list1, 
(
    SELECT lc_prezzo
    FROM listini
    WHERE lc_conto = 0
          AND lc_datscad > GETDATE()
          AND lc_codart = ar_codart
          AND lc_listino = 2
          AND lc_unmis <> ''
) xx_list2, 
(
    SELECT lc_prezzo
    FROM listini
    WHERE lc_conto = 0
          AND lc_datscad > GETDATE()
          AND lc_codart = ar_codart
          AND lc_listino = 3
          AND lc_unmis <> ''
) xx_list3, 
(
    SELECT lc_prezzo
    FROM listini
    WHERE lc_conto = 0
          AND lc_datscad > GETDATE()
          AND lc_codart = ar_codart
          AND lc_listino = 4
          AND lc_unmis <> ''
) xx_list4, 
(
    SELECT lc_prezzo
    FROM listini
    WHERE lc_conto = 0
          AND lc_datscad > GETDATE()
          AND lc_codart = ar_codart
          AND lc_listino = 10
          AND lc_unmis <> ''
) xx_list10, 
(
    SELECT lc_prezzo
    FROM listini
    WHERE lc_conto = 0
          AND lc_datscad > GETDATE()
          AND lc_codart = ar_codart
          AND lc_listino = 99
          AND lc_unmis <> ''
) xx_list99, 
(
    SELECT apx_ultcos
    FROM artprox
    WHERE apx_codart = ar_codart
) xx_upa, 
(
    SELECT so_scont1
    FROM sconti
    WHERE so_conto = 0
          AND so_datscad > GETDATE()
          AND so_codart = ar_codart
          AND so_unmis <> ''
) xx_sc1, 
(
    SELECT so_scont1
    FROM sconti
    WHERE so_conto = 0
          AND so_datscad > GETDATE()
          AND so_codart = ar_codart
) xx_sc2
FROM artico
     LEFT JOIN tabgmer ON tb_codgmer = ar_gruppo
     LEFT JOIN tabcpar ON tb_codcpar = ar_claprov
WHERE ar_codart IN
(
    SELECT lc_codart
    FROM listini
    WHERE lc_conto = 0
);