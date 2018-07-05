# TIEA212-GKO-Viikkotehtava4
Graafisten käyttöliittymien 4. viikkotehtävä

WPF-perusteet ja koostetut komponentit - Viikkotehtävä 4
Taso 1
Taso 3
Taso 5
Vinkkejä
Tee valitsemasi taso WPF-ohjelmana. Käytä apunasi itse tehtyjä WPF User Control -komponentteja.

Kaikki syötteiden virheentarkistukset on tehtävä ExceptionValidationRule-luokan avulla jollei toisin määrätä.

Messageboxin käyttäminen on kiellettyä.

Windows Forms -kontrolleja ja komponentteja ei saa käyttää.

Windows Presentation Foundation (WPF)
WPF-kontrollit ja layout
WPF Data validation ja Binding
Commanding
Model-View-ViewModel (MVVM)
Pääteohjaus 4
Taso 1
Kirjoita ohjelma, joka laskee kilometrinopeuden.
Toteuta laskenta omalla koostetulla Treeni-WPF-komponentilla, joka sisältää syöttökentät kilometrien sekä ajan syöttämiseksi, painikkeen nopeuden (km/h) laskemiseksi ja kentän nopeuden esittämiseksi.
Virheellinen syöte on osoitettava reunustamalla syöttökenttä punaisella värillä. Virheentarkistus on tehtävä ExceptionValidationRule-luokan avulla eli bindaamalla tarkistettava kenttä oikeanlaiseen muuttujaan. Älä rakenna omia virheentarkistusluokkia. Mahdollinen virheellisyys osoitetaan punaisella värillä vasta syöttökentästä poistumisen jälkeen.
Komponentti ei saa hyväksyä lukukenttiin muita lukuja kuin desimaalilukuja. Ohjelmasi on laskettava kilometrinopeus kahden desimaalin tarkkuudella.
Lisää ohjelmaan File-valikko jonka alta löytyvät valinnat: New ja Exit.
Toteuta File|New-valinnan toiminta ApplicationCommands.New-avulla siten, että New-valinta lisää lomakkeelle uuden treenilaskurin. Käytä Commanding Overview-dokumentissa esiteltyä tapaa.
Ohjelmassa on osoitettava, että osaa järkevästi käyttää Data Binding-ominaisuutta.
Taso 3
Laajenna taso 1 ohjelmaa seuraavalla tavalla.
Toteuta oma virheentarkistusluokka, joka kelpuuttaa desimaaliluvun halutulta väliltä. Kelpuutettava väli (min ja max) on annettava xamlissa. Ota tämä tarkistus käyttöön matkakentässä. Jos syöte on virheellinen niin kentän alapuolella näytetään virheilmoitus.
Toteuta oma virheentarkistusluokka, joka kelpuuttaa ajanjakson halutulta väliltä TimeSpan-luokan kelpuuttamassa muodossa. Kelpuutettava väli (min ja max) on annettava xamlissa. Ota tämä tarkistus käyttöön aikakentässä. Jos syöte on virheellinen niin kentän alapuolella näytetään virheilmoitus. Kelpuuta ajanjaksot jotka ovat vähintään 00:00:01 mutta enintään 23:59:59.
Toteuta PaceLabel-WPF-kontrolli, joka esittää vauhdin sille annetusta ajasta ja matkasta laskettuna. Peri PaceLabel Label-kontrollista. Aika ja matka annetaan kontrollille propertyjen kautta ja kontrolli laskee automaattisesti näiden perusteella vauhdin. Laskenta pitää tehdä aina kun päivitetään PaceLabelin propertyjen (matka, aika) arvoja.
Päivitä Treeni-WPF-kontrolli käyttämään edellä luomaasi PaceLabel-kontrollia ja virheentarkistusluokkia. Nopeus on nolla (0) jos lähtötiedoissa on virheitä. Laske-painikkeen on oltava disabloituna jos lähtötiedoissa on virheitä (Vinkki). Toteuta laske-painikkeen toiminta omalla RoutedCommandilla.
Kaikkien treenilaskurien täytyy olla koko ajan nähtävissä paitsi jos ne eivät mahdu kerralla lomakkeelle jolloin on käytettävä pystysuuntaista skrollbaria. Käytä treenilaskurien sijoittamiseen sopivaa layout-panelia.
Taso 5
Laajenna tason 3 ohjelmaa seuraavilla ominaisuuksilla:

Toteuta File|Exit-valinnan toiminta. Exit sulkee koko ohjelman mutta vain jos kaikkien treenien kaikkien syöttökenttien sisältö on virheetöntä. Esim. jos johonkin kenttään on syötettynä virheellinen aika niin Exit-valinta ei ole käytettävissä. Luo tätä varten oma RoutedCommand. Kts. Detecting WPF validation errors
Lisää PaceLabel-kontrolliin property, joka sisältää aina kilometrinopeuden. Sido (bind) tämä property Treenikontrollin taustaväriksi. Joudut kirjoittamaan tätä varten ValueConverterin, joka muuttaa kilometrinopeuden järkeväksi värikoodiksi. Esim. Jos nopeus on 0 niin väri on musta (RGB-koodi 0). Mitä kovempi nopeus niin sitä vaaleampi taustaväri. Yli 255 meneviä nopeuksia ei tarvitse käsitellä.
Kontrolli laskee automaattisesti nopeuden heti kun se on syöttötietojen puolesta mahdollista. Tämä on toteutettava käyttäen bindausta. Ota huomioon mahdolliset virhetilanteet. Taso 3:llä ollutta painiketta ei pidä enää olla. Älä käytä tapahtumia. Joudut käyttämään Dependency Propertyja.
Bindaa matka- ja aikakenttä suoraan PaceLabelin propertyihin
Vinkkejä
Using Custom Validation Rules in WPF
How to add a binding to a property on a ValidationRule
Vinkki
