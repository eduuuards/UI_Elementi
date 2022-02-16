using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Uzglabas tekstu kurs panemts no input lauka
	public string teksts;
	//Lauks no kura es to tekstu panemsu
	public GameObject ievadesLauks;
	//teksta objekts kur attelot mainiga Teksta saturu
	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text>().text = "Sveiks " + teksts.ToUpper () + "!";
	}
}
