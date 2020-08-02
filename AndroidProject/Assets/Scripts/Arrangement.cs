using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrangement : MonoBehaviour {

	public Text mainText;

	public PlayerController player;

	public GameObject[] btnsArray;

	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;
	public GameObject button5;
	public GameObject button6;

	public EventUnit defautEvent;
	public EventUnit beginning;
	public EventUnit currentEvent = null;
	public EventUnit previousEvent = null;

	//items
	public Item _plecak;
	public Item _gitara;
	public Item _portfel;
	public Item _telefon;
	public Item _prezerwatywy;
	public Item _karty;
	public Item _zegarek;
	public Item _latarka;
	public Item _encyklopedia;
	public Item _kroniki_polskie;
	public Item _slownik_polsko_niemiecki;
	public Item _swiadectwo_gimbazjum;
	public Item _pognity_banan;
	public Item _sledzie;
	public Item _jogurt;
	public Item _surowe_mieso;
	public Item _coca_cola;
	public Item _zapalniczka;
	public Item _wykalaczki;
	public Item _otwieracz_do_konserw;
	public Item _sloik_z_ogorkami;
	public Item _saperka;
	public Item _konserwy;
	public Item _wegiel;
	public Item _zegarek_sasiada;
	public Item _telefon_sasiada; 

	//place event
	public EventUnit pokoj;
	public EventUnit kuchnia;
	public EventUnit szafka;
	public EventUnit regal;
	public EventUnit lodowka;
	public EventUnit szafka_kuchenna;
	public EventUnit piwnica;
	public EventUnit korytarz;
	public EventUnit ulica;
	public EventUnit przed_domem_sasiadow;
	public EventUnit okno_dom_sasiadow;
	public EventUnit dom_sasiadow;
	public EventUnit sasiad_trup;
	public EventUnit podworko_sasiadow;

	//announcements
	public EventUnit okno;
	public EventUnit dzwonek_do_drzwi_sąsiadów;

	//item events
	public EventUnit plecak;
	public EventUnit gitara;
	public EventUnit portfel;
	public EventUnit telefon;
	public EventUnit prezerwatywy;
	public EventUnit karty;
	public EventUnit zegarek;
	public EventUnit latarka;
	public EventUnit encyklopedia;
	public EventUnit kroniki_polskie;
	public EventUnit slownik_polsko_niemiecki;
	public EventUnit swiadectwo_gimbazjum;
	public EventUnit pognity_banan;
	public EventUnit sledzie;
	public EventUnit jogurt;
	public EventUnit surowe_mieso;
	public EventUnit coca_cola;
	public EventUnit zapalniczka;
	public EventUnit wykalaczki;
	public EventUnit otwieracz_do_konserw;
	public EventUnit sloik_z_ogorkami;
	public EventUnit saperka;
	public EventUnit konserwy;
	public EventUnit wegiel;
	public EventUnit zegarek_sasiada;
	public EventUnit telefon_sasiada;

	//public EventUnit[] itemEvs;



	// Use this for initialization
	void Start () {

		btnsArray = new GameObject[] { button1, button2, button3, button4, button5, button6 };
		/*
		itemEvs = new EventUnit[] 
		{
			plecak,
			gitara,
			portfel,
			telefon,
			prezerwatywy,
			karty,
			zegarek,
			latarka,
			encyklopedia,
			kroniki_polskie,
			slownik_polsko_niemiecki,
			swiadectwo_gimbazjum,
			pognity_banan,
			sledzie,
			jogurt,
			surowe_mieso,
			coca_cola,
			zapalniczka,
			wykalaczki,
			otwieracz_do_konserw,
			sloik_z_ogorkami,
			saperka,
			konserwy,
			wegiel,
			zegarek_sasiada,
			telefon_sasiada
		};
		*/

		Initialization ();

		BeginEvent (beginning);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ActivateButtons
	(
		int nr, 
		string bb1txt = "", 
		string bb2txt = "", 
		string bb3txt = "", 
		string bb4txt = "", 
		string bb5txt = "", 
		string bb6txt = "",
		EventUnit e1 = null,
		EventUnit e2 = null,
		EventUnit e3 = null,
		EventUnit e4 = null,
		EventUnit e5 = null,
		EventUnit e6 = null
	)
	{

		foreach (GameObject btn in btnsArray) 
		{
			//clear functions assignments
			btn.GetComponent<Button>().onClick.RemoveAllListeners();
			btn.transform.GetChild (0).GetComponent<Text> ().text = "";
			btn.SetActive (false);
		}
			

		switch (nr) 
		{
		case 0:
			break;
		case 1:
			button5.SetActive (true);
			button5.transform.GetChild (0).GetComponent<Text> ().text = bb1txt;
			button5.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e1);});
			break;
		case 2:
			button4.SetActive (true);
			button6.SetActive (true);

			button4.transform.GetChild (0).GetComponent<Text> ().text = bb1txt;
			button6.transform.GetChild (0).GetComponent<Text> ().text = bb2txt;

			button4.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e1);});
			button6.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e2);});
			break;
		case 3:
			button4.SetActive (true);
			button4.transform.GetChild (0).GetComponent<Text> ().text = bb1txt;
			button4.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e1);});

			button5.SetActive (true);
			button5.transform.GetChild (0).GetComponent<Text> ().text = bb2txt;
			button5.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e2);});

			button6.SetActive (true);
			button6.transform.GetChild (0).GetComponent<Text> ().text = bb3txt;
			button6.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e3);});
			break;
		case 4:
			button2.SetActive (true);
			button2.transform.GetChild (0).GetComponent<Text> ().text = bb1txt;
			button2.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e1);});

			button4.SetActive (true);
			button4.transform.GetChild (0).GetComponent<Text> ().text = bb2txt;
			button4.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e2);});

			button5.SetActive (true);
			button5.transform.GetChild (0).GetComponent<Text> ().text = bb3txt;
			button5.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e3);});

			button6.SetActive (true);
			button6.transform.GetChild (0).GetComponent<Text> ().text = bb4txt;
			button6.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e4);});
			break;
		case 5:
			button1.SetActive (true);
			button1.transform.GetChild (0).GetComponent<Text> ().text = bb1txt;
			button1.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e1);});

			button3.SetActive (true);
			button3.transform.GetChild (0).GetComponent<Text> ().text = bb2txt;
			button3.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e2);});

			button4.SetActive (true);
			button4.transform.GetChild (0).GetComponent<Text> ().text = bb3txt;
			button4.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e3);});

			button5.SetActive (true);
			button5.transform.GetChild (0).GetComponent<Text> ().text = bb4txt;
			button5.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e4);});

			button6.SetActive (true);
			button6.transform.GetChild (0).GetComponent<Text> ().text = bb5txt;
			button6.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e5);});
			break;
		case 6:
			
			foreach (GameObject btn in btnsArray) 
			{
				btn.SetActive (true);
			}

			button1.transform.GetChild (0).GetComponent<Text> ().text = bb1txt;
			button2.transform.GetChild (0).GetComponent<Text> ().text = bb2txt;
			button3.transform.GetChild (0).GetComponent<Text> ().text = bb3txt;
			button4.transform.GetChild (0).GetComponent<Text> ().text = bb4txt;
			button5.transform.GetChild (0).GetComponent<Text> ().text = bb5txt;
			button6.transform.GetChild (0).GetComponent<Text> ().text = bb6txt;

			button1.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e1);});
			button2.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e2);});
			button3.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e3);});
			button4.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e4);});
			button5.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e5);});
			button6.GetComponent<Button> ().onClick.AddListener (delegate{BeginEvent(e6);});

			break;
		}
	}

	public void BeginEvent(EventUnit evnt)
	{

		previousEvent = currentEvent;
		currentEvent = evnt;

		//InitItemEvents (itemEvs);
		if ((evnt.evType == evntType.item)||(evnt.evType == evntType.announcement))
		{
			evnt.ev1 = previousEvent;
		}

		ActivateButtons 
		(
			evnt.buttonsQuantity, 
			evnt.text1, 
			evnt.text2, 
			evnt.text3, 
			evnt.text4, 
			evnt.text5, 
			evnt.text6, 
			evnt.ev1, 
			evnt.ev2, 
			evnt.ev3, 
			evnt.ev4,
			evnt.ev5, 
			evnt.ev6
		);

		if (evnt.evType == evntType.announcement) 
		{
			//evnt.ev1 = previousEvent;
		}

		if (evnt.evType == evntType.item) 
		{
			//evnt.ev1 = previousEvent;
			if (evnt.pickedUp) 
			{
				//Display a message that you have already picked up this item
				Debug.Log("You have already picked up this item!");
				evnt.textToDisplay = "Już podniosłeś ten przedmiot!";
			}
			if (!evnt.pickedUp) 
			{
				evnt.pickedUp = true;
				player.AddItem (evnt.carriedItem);
				Debug.Log ("You picked up: " + evnt.carriedItem.name);
			}
		}

		if (evnt.duration > 0) 
		{
			player.PassTime (evnt.duration);
		}

		mainText.text = evnt.textToDisplay;

		if (evnt == null) 
		{
			Debug.Log ("There is no event assigned!");
		}
	}


	public EventUnit AnnouncementBoot(string toDisplay, string onButton = "Powrót", float dur = 0.1f)
	{
		EventUnit a = new EventUnit ();
		a.evType = evntType.announcement;
		a.buttonsQuantity = 1;
		a.textToDisplay = toDisplay;
		a.text1 = onButton;
		a.ev1 = previousEvent;
		a.duration = dur;


		return a;
	}

	public EventUnit BootItemEvent(EventUnit u, Item _item)
	{
		u = new EventUnit ();
		u.evType = evntType.item;
		u.buttonsQuantity = 1;
		u.text1 = "OK";
		u.ev1 = previousEvent;
		u.carriedItem = _item;

		return u;
	}

	public EventUnit SimpleBootItem(EventUnit _u, Item _it, string _name, string odmiana = "", bool kieszen = true, float waga = 0)
	{
		if (odmiana == "") 
		{
			odmiana = _name;
		}

		_it = new Item ();
		_it.name = _name;
		_it.pocket = kieszen;
		_it.weight = waga;
		_u = BootItemEvent (_u, _it);
		if (kieszen) 
		{
			if (_u == null) {
				Debug.Log ("Cos sie zepsulo i nie bylo mnie slychac");
			}
			_u.textToDisplay = "Wkładasz " + odmiana + " do kieszeni";
		} 
		else 
		{
			_u.textToDisplay = "Wkładasz " + odmiana + " do plecaka";
		}

		return _u;
	}

	public void Initialization()
	{
		defautEvent = new EventUnit ();
		defautEvent.buttonsQuantity = 2;
		defautEvent.textToDisplay = "PLACEHOLDER TEXT, WORK IN PROGRESS";
		defautEvent.text1 = "Placeholder 1";
		defautEvent.text2 = "Placeholder 2";


		coca_cola = SimpleBootItem (coca_cola, _coca_cola, "coca-cola", "coca-colę", false);
		telefon_sasiada = SimpleBootItem (telefon_sasiada, _telefon_sasiada, "telefon sasiada");
		zegarek_sasiada = SimpleBootItem (zegarek_sasiada, _zegarek_sasiada, "zegarek sasiada");
		wegiel = SimpleBootItem (wegiel, _wegiel, "wegiel", "", false);
		konserwy = SimpleBootItem (konserwy, _konserwy, "konserwy", "", false);
		saperka = SimpleBootItem (saperka, _saperka, "saperka", "saperkę", false);
		sloik_z_ogorkami = SimpleBootItem (sloik_z_ogorkami, _sloik_z_ogorkami, "sloik z ogorkami", "", false);
		otwieracz_do_konserw = SimpleBootItem (otwieracz_do_konserw, _otwieracz_do_konserw, "otwieracz do konserw");
		wykalaczki = SimpleBootItem (wykalaczki, _wykalaczki, "wykalaczki");
		zapalniczka = SimpleBootItem (zapalniczka, _zapalniczka, "zapalniczka");
		surowe_mieso = SimpleBootItem (surowe_mieso, _surowe_mieso, "surowe mieso", "", false);
		jogurt = SimpleBootItem (jogurt, _jogurt, "jogurt");
		sledzie = SimpleBootItem (sledzie, _sledzie, "sledzie", "", false);
		pognity_banan = SimpleBootItem (pognity_banan, _pognity_banan, "pognity banan");
		swiadectwo_gimbazjum = SimpleBootItem (swiadectwo_gimbazjum, _swiadectwo_gimbazjum, "swiadectwo gimbazjum", "", false);
		slownik_polsko_niemiecki = SimpleBootItem (slownik_polsko_niemiecki, _slownik_polsko_niemiecki, "slownik polsko niemiecki", "", false);
		kroniki_polskie = SimpleBootItem (kroniki_polskie, _kroniki_polskie, "kroniki polskie", "", false);
		encyklopedia = SimpleBootItem (encyklopedia, _encyklopedia, "encyklopedia", "encyklopedię", false);
		latarka = SimpleBootItem (latarka, _latarka, "latarka", "latarkę");
		zegarek = SimpleBootItem (zegarek, _zegarek, "zegarek");
		karty = SimpleBootItem (karty, _karty, "karty");
		prezerwatywy = SimpleBootItem (prezerwatywy, _prezerwatywy, "prezerwatywy");
		telefon = SimpleBootItem (telefon, _telefon, "telefon");
		portfel = SimpleBootItem (portfel, _portfel, "portfel");
		gitara = SimpleBootItem (gitara, _gitara, "gitara", "gitarę", false);

		okno = AnnouncementBoot ("Nie widzisz żywej duszy. Prawie wszystkie domy w okolicy są zniszczone. Dom sąsiadów ma zerwany dach. O dziwo psia buda jest nienaruszona.");
		dzwonek_do_drzwi_sąsiadów = AnnouncementBoot ("Nikt nie otwiera.");

		_plecak = new Item ();
		_plecak.name = "plecak";
		_plecak.weight = 2000f;
		_plecak.pocket = false;
		_plecak.container = true;
		plecak = BootItemEvent (plecak, _plecak);
		plecak.textToDisplay = "Bierzesz swoj plecak do ręki.";

		podworko_sasiadow = new EventUnit ();
		podworko_sasiadow.buttonsQuantity = 1;
		podworko_sasiadow.textToDisplay = "Znajdujesz się na podwórku sąsiadów.";
		podworko_sasiadow.text1 = "Wróć na ulicę";
		podworko_sasiadow.ev1 = ulica;
		podworko_sasiadow.duration = 0.1f;

		sasiad_trup = new EventUnit ();
		sasiad_trup.buttonsQuantity = 2;
		sasiad_trup.textToDisplay = "Sprawdzasz kieszenie. Znajdujesz telefon.";
		sasiad_trup.text1 = "Bierzesz go ze sobą";
		sasiad_trup.text2 = "Wracasz do pomieszczenia";
		sasiad_trup.ev1 = telefon_sasiada;	
		sasiad_trup.ev2 = dom_sasiadow;
		sasiad_trup.duration = 0.1f;

		dom_sasiadow = new EventUnit ();
		dom_sasiadow.buttonsQuantity = 3;
		dom_sasiadow.textToDisplay = "Znajdujesz się w domu sąsiadów. Na podłodze widzisz zwłoki.";
		dom_sasiadow.text1 = "Sprawdź kieszenie trupa póki masz okazję";
		dom_sasiadow.text2 = "Na ręce nieboszczyka widzisz zegarek. Zdejmij mu go i zabierz ze sobą";
		dom_sasiadow.text3 = "Zostaw sąsiada w spokoju okazując mu szacunek i przejdź na podwórko";	
		dom_sasiadow.ev1 = sasiad_trup;
		dom_sasiadow.ev2 = zegarek_sasiada;
		dom_sasiadow.ev3 = podworko_sasiadow;
		dom_sasiadow.duration = 0.1f;

		sasiad_trup.ev2 = dom_sasiadow;

		okno_dom_sasiadow = new EventUnit ();
		okno_dom_sasiadow.buttonsQuantity = 2;
		okno_dom_sasiadow.textToDisplay = "Okno jest uchylone. Można je otworzyć od zewnątrz i bez wyrządzania szkód wejść do pomieszczenia.";
		okno_dom_sasiadow.text1 = "Olej to i wróć na ulicę";
		okno_dom_sasiadow.text2 = "Skorzystaj z okazji aby sprawdzić co się dzieje";
		okno_dom_sasiadow.ev1 = ulica;	
		okno_dom_sasiadow.ev2 = dom_sasiadow;
		okno_dom_sasiadow.duration = 0.1f;

		przed_domem_sasiadow = new EventUnit ();
		przed_domem_sasiadow.buttonsQuantity = 3;
		przed_domem_sasiadow.textToDisplay = "Znajdujesz się przed domem sąsiadów.";
		przed_domem_sasiadow.text1 = "Wróć na ulicę";
		przed_domem_sasiadow.text2 = "Zadzwoń";
		przed_domem_sasiadow.text3 = "Podejdź do uchylonego okna";	
		przed_domem_sasiadow.ev1 = ulica;
		przed_domem_sasiadow.ev2 = dzwonek_do_drzwi_sąsiadów;
		przed_domem_sasiadow.ev3 = okno_dom_sasiadow;
		przed_domem_sasiadow.duration = 0.1f;

		ulica = new EventUnit ();
		ulica.buttonsQuantity = 3;
		ulica.textToDisplay = "Znajdujesz się na opustoszałej ulicy.";
		ulica.text1 = "Wróć do domu";
		ulica.text2 = "Wróć do piwnicy";
		ulica.text3 = "Idź do sąsiadów";
		ulica.ev1 = korytarz;
		ulica.ev2 = piwnica;
		ulica.ev3 = przed_domem_sasiadow;
		ulica.duration = 0.1f;

		przed_domem_sasiadow.ev1 = ulica;
		okno_dom_sasiadow.ev1 = ulica;
		podworko_sasiadow.ev1 = ulica;

		piwnica = new EventUnit ();
		piwnica.buttonsQuantity = 6;
		piwnica.textToDisplay = "Znajdujesz się w piwnicy. Jest tu pełno gratów. Niektóre z nich mogą okazać się przydatne.";
		piwnica.text1 = "Słoik z ogórkami";
		piwnica.text2 = "Saperka";
		piwnica.text3 = "Konserwy";
		piwnica.text4 = "Węgiel";
		piwnica.text5 = "Wyjdź z domu";
		piwnica.text6 = "Wróć na korytarz";
		piwnica.ev1 = sloik_z_ogorkami;
		piwnica.ev2 = saperka;
		piwnica.ev3 = konserwy;
		piwnica.ev4 = wegiel;
		piwnica.ev5 = ulica;
		piwnica.ev6 = korytarz;
		piwnica.duration = 0.1f;

		ulica.ev2 = piwnica;

		szafka_kuchenna = new EventUnit ();
		szafka_kuchenna.buttonsQuantity = 4;
		szafka_kuchenna.textToDisplay = "Stoisz przed otwartą szafką kuchenną.";
		szafka_kuchenna.text1 = "Zapalniczka";
		szafka_kuchenna.text2 = "Wykałaczki";
		szafka_kuchenna.text3 = "Otwieracz do konserw";
		szafka_kuchenna.text4 = "Wróć do kuchni";
		szafka_kuchenna.ev1 = zapalniczka;
		szafka_kuchenna.ev2 = wykalaczki;
		szafka_kuchenna.ev3 = otwieracz_do_konserw;
		szafka_kuchenna.ev4 = kuchnia;
		szafka_kuchenna.duration = 0.1f;

		lodowka = new EventUnit ();
		lodowka.buttonsQuantity = 5;
		lodowka.textToDisplay = "Stoisz przed otwartą lodówką.";
		lodowka.text1 = "Jogurt";
		lodowka.text2 = "Surowe mięso";
		lodowka.text3 = "Coca-cola";
		lodowka.text4 = "Śledzie";
		lodowka.text5 = "Wróć do kuchni";
		lodowka.ev1 = jogurt;
		lodowka.ev2 = surowe_mieso;
		lodowka.ev3 = coca_cola;
		lodowka.ev4 = sledzie;
		lodowka.ev5 = kuchnia;
		lodowka.duration = 0.1f;

		kuchnia = new EventUnit ();
		kuchnia.buttonsQuantity = 4;
		kuchnia.textToDisplay = "Znajdujesz się w kuchni.";
		kuchnia.text1 = "Przejdź na korytarz";
		kuchnia.text2 = "Weź z blatu pognity banan";
		kuchnia.text3 = "Podejdź do lodówki";
		kuchnia.text4 = "Otwórz szafkę kuchenną";
		kuchnia.ev1 = korytarz;
		kuchnia.ev2 = pognity_banan;
		kuchnia.ev3 = lodowka;
		kuchnia.ev4 = szafka_kuchenna;
		kuchnia.duration = 0.1f;

		lodowka.ev5 = kuchnia;
		szafka_kuchenna.ev4 = kuchnia;

		korytarz = new EventUnit ();
		korytarz.buttonsQuantity = 5;
		korytarz.textToDisplay = "(...)";
		korytarz.text1 = "Zajrzyj przez okno";
		korytarz.text2 = "Rozejrzyj się po pokoju";
		korytarz.text3 = "Idź do piwnicy";
		korytarz.text4 = "Wyjdź z domu";
		korytarz.text5 = "Idź do kuchni";
		korytarz.ev1 = okno;
		korytarz.ev2 = pokoj;
		korytarz.ev3 = piwnica;
		korytarz.ev4 = ulica;
		korytarz.ev5 = kuchnia;
		korytarz.duration = 0.1f;

		kuchnia.ev1 = korytarz;
		piwnica.ev6 = korytarz;
		ulica.ev1 = korytarz;

		regal = new EventUnit ();
		regal.buttonsQuantity = 5;
		regal.textToDisplay = "Otwierasz swoją szafkę.";
		regal.text1 = "Kroniki Polskie";
		regal.text2 = "Słownik Polsko-Niemiecki";
		regal.text3 = "Teczka ze świadectwem ukończenia gimnazjum";
		regal.text4 = "Encyklopedia";
		regal.text5 = "Wróć do łóżka";
		regal.ev1 = kroniki_polskie;
		regal.ev2 = slownik_polsko_niemiecki;
		regal.ev3 = swiadectwo_gimbazjum;
		regal.ev4 = encyklopedia;
		regal.ev5 = pokoj;
		regal.duration = 0.1f;

		szafka = new EventUnit ();
		szafka.buttonsQuantity = 6;
		szafka.textToDisplay = "Otwierasz swoją szafkę.";
		szafka.text1 = "Telefon";
		szafka.text2 = "Prezerwatywy";
		szafka.text3 = "Karty";
		szafka.text4 = "Zegarek";
		szafka.text5 = "Latarka";
		szafka.text6 = "Wróć do łóżka";
		szafka.ev1 = telefon;
		szafka.ev2 = prezerwatywy;
		szafka.ev3 = karty;
		szafka.ev4 = zegarek;
		szafka.ev5 = latarka;
		szafka.ev6 = pokoj;
		szafka.duration = 0.1f;

		pokoj = new EventUnit ();
		pokoj.buttonsQuantity = 6;
		pokoj.textToDisplay = "Rozgladasz sie po pokoju. Nie widzisz niczego nadzwyczajnego.";
		pokoj.text1 = "Plecak";
		pokoj.text2 = "Gitara";
		pokoj.text3 = "Portfel";
		pokoj.text4 = "Podejdź do szafki";
		pokoj.text5 = "Podejdź do regału z książkami";
		pokoj.text6 = "Przejdź na korytarz";
		pokoj.ev1 = plecak;
		pokoj.ev2 = gitara;
		pokoj.ev3 = portfel;
		pokoj.ev4 = szafka;
		pokoj.ev5 = regal;
		pokoj.ev6 = korytarz;
		pokoj.duration = 0.1f;

		szafka.ev6 = pokoj;
		regal.ev5 = pokoj;
		korytarz.ev2 = pokoj;


		beginning = new EventUnit ();
		beginning.buttonsQuantity = 3;
		beginning.textToDisplay = "Budzisz się w swoim pokoju....";
		beginning.text1 = "Rozejrzyj się po pokoju";
		beginning.text2 = "Zajrzyj przez okno";
		beginning.text3 = "Idź do kuchni";
		beginning.ev1 = pokoj;
		beginning.ev2 = okno;
		beginning.ev3 = kuchnia;


	}


}
