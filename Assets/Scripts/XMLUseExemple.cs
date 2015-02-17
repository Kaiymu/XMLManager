using UnityEngine;
using System.Collections;
using System.IO;
using System.Xml;

///<summary>
/// Impletation of the XMLLoadRead.cs.
///</summary>
public class XMLUseExemple : XMLLoadRead {
	
	private XMLManager PCxml;
	
	protected override void Awake(){
		base.Awake();
	}
	
	protected override XMLManager LoadXML() {
		PCxml = base.LoadXML();
		SaveXML(PCxml);
		return null;
	}

	// Change la valeur dans le XML de la première variable de score, dans chiffre 5.
	// Pour le moment les valeurs XML sont définis déns XML manager à la main, ce qui n'est pas une bonne chose
	// Le XML se présente sous un tableau, pour me le modifié il faut que la propriété définie dans XMLManager ai le meme nom 
	// Que le XML lui meme. 
	protected override void SaveXML(XMLManager XMLToSave) {	
		XMLToSave.score[0] = 5;
		base.SaveXML(XMLToSave);
	}
}