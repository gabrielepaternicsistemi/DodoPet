SELECT tm_datdoc, 
       mm_numdoc, 
       tm_numfat, 
       tm_datfat, 
       dd_nomdest, 
       mm_tipork, 
       IIF(mm_tipork = 'N', -1 * ROUND(SUM(mm_valore), 2), ROUND(SUM(mm_valore), 2)) xx_valore, 
       IIF(ar_codvuo = 1, 'WET', 'DRY') AS xx_controp, 
       IIF(mm_tipork = 'N', -1 * ROUND(SUM(mm_valore) * IIF(ar_codvuo = 2, @PDRY, @PWET) / 100, 2), ROUND(SUM(mm_valore) * IIF(ar_codvuo = 2, @PDRY, @PWET) / 100, 2)) xx_provv, 
       tm_riferim, 
       IIF(ar_codvuo = 1, 'JJDISTRIBUWET', 'JJDISTRIBU') AS xx_codart
FROM movmag
     INNER JOIN testmag ON tm_tipork = mm_tipork
                           AND tm_serie = mm_serie
                           AND tm_anno = mm_anno
                           AND tm_numdoc = mm_numdoc
     INNER JOIN anagra ON an_conto = TM_CONTO
     INNER JOIN destdiv ON dd_conto = an_conto
                           AND dd_coddest = tm_coddest
     INNER JOIN artico ON ar_codart = mm_codart
WHERE mm_tipork IN('B')
     AND tm_conto = @CONTO
     AND mm_codart <> 'D'
     AND MONTH(tm_datdoc) = @MESE
     AND tm_anno = @ANNO
     AND ar_codvuo IN(1, 2) AND tm_numfat <>0
GROUP BY mm_numdoc, 
         tm_numfat, 
         dd_nomdest, 
         --  mm_controp, 
         tm_riferim, 
         tm_datdoc, 
         mm_tipork, 
         ar_codvuo, 
         tm_datfat
ORDER BY mm_numdoc;