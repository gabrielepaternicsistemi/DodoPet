SELECT CONCAT(td_anno,'~',td_tipork,'~', td_numord,'~',td_serie) xx_chiave FROM TESTORD
inner join anagra on an_conto = td_conto