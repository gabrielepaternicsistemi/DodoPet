SELECT concat(tm_numdoc, '~', tm_serie, '~', tm_anno, '~', tm_tipork) xx_chiaveglobale,  
       mm_codart, 
       mm_descr, 
       mm_quant, 
       mm_prezzo, 
       mm_valore, 
       mm_scont1, 
       mm_scont2
FROM movmag m
     INNER JOIN testmag ON tm_serie = m.mm_serie
                           AND tm_anno = m.mm_anno
                           AND tm_tipork = m.mm_tipork
                           AND tm_numdoc = m.mm_numdoc
     INNER JOIN anagra ON an_conto = tm_conto
WHERE mm_tipork = 'C'
