## CzechJet - gramatická oprava textu

### Xeditor

Finální aplikací je jednoduchý editor vytvořený za pomoci frameworku Windows Forms.

Jeho zdrojový kód lze najít na [tomto odkazu](https://github.com/czechjet2021/Xeditor). 

Jeho funkce zahrnují:

- otevírání a ukládání `.txt` a `.rtf` souborů
- změnu písma a barvy pozadí textu
- algoritmickou kontrolu gramatických chyb (překlepy)
- vyhledání klíčových frází z textu (pouze pro angličtinu)
- tisk

### Umělá inteligence

Cílem tohoto projektu byla funkční umělá inteligence, která by byla schopná hledání nejen gramatických překlepů, ale i syntaktických a stylistických chyb.

V průběhu hledání řešení jsme prozkoumali různé studie a veřejné repozitáře týkající se NLP (natural language processing) a GEC (grammatical error correction). 

Pro implementaci řešení jsme nakonec zvolili práci Jakuba Náplavy a Milana straky s názvem  `Grammatical Error Correction in Low-Resource Scenarios` (pdf [zde](http://ufal.mff.cuni.cz/biblio/attachments/2019-naplava-p7438659577534366726.pdf)).

Naše poupravená verze kódu je taktéž dostupná na githubu na [tomto odkaze](https://github.com/czechjet2021/ml-gec). Bohužel ani po několika úpravách jsme nebyli schopni tento kód zprovoznit. Kontaktovali jsme autora práce, zatím bez odpovědi.

Tudíž výsledný produkt bohužel neobsahuje tuto funkci.
