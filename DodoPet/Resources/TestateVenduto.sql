SELECT concat(tm_numdoc, '~', tm_serie, '~', tm_anno, '~', tm_tipork) xx_chiaveglobale, 
       tm_datdoc, 
       tm_numdoc, 
       tm_anno, 
       tm_conto, 
       an_descr1, 
	   tm_totdoc
FROM testmag t
     INNER JOIN anagra ON an_conto = tm_conto
     LEFT JOIN destdiv ON tm_coddest = dd_coddest
                          AND tm_conto = dd_conto
WHERE   t.tm_datdoc >= convert(date,@DATAINIZIO) AND  t.tm_datdoc <convert(date,@DATAFINE) AND tm_tipork ='C'
