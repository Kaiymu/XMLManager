using UnityEngine;
using System.Collections;
using System.IO;
using System.Xml;

///<summary>
/// Main class to read / save XML files (PC / IOS / Android)
///</summary>
public abstract class XMLLoadRead : MonoBehaviour {

	[Header("Path to the XML from asset/")]
	public string path = "/StreamingAssets/XML";

	[Header("XML name")]
	public string fileName = "/XMLExemple.xml";
	
	protected virtual void Awake() {
		LoadXML();
	}

	///<summary>
	/// Charge le XML et renvoie le XML sous forme d'objet.
	///</summary>
	protected virtual XMLManager LoadXML() {
		// Va chercher dans le dossier Unity "path", le fichier "filename", et le met dans XMLLoad
		XMLManager XMLLoad;
		// PC
		if(Application.platform == RuntimePlatform.WindowsEditor || 
		Application.platform == RuntimePlatform.WindowsPlayer || 
		Application.platform == RuntimePlatform.WindowsWebPlayer)
		{
			XMLLoad = XMLManager.LoadPC(Application.dataPath + path + fileName);
			// Si le fichier est bien chargée, met un message 
			if(XMLLoad != null) {
				Debug.Log("Sucessfully retrieved : " + XMLLoad + " from :" + path + "folder");
				return XMLLoad;
			}
			else {
				return CreateXMLFile(path);
			}
		}
		return null;
	}

	///<summary>
	/// Save the XML files with the new parameter put in it.
	///</summary>
	protected virtual void SaveXML(XMLManager XMLToSave) {	
		if(XMLToSave != null) {
			XMLToSave.Save(Application.dataPath + path + fileName);
			Debug.Log("Saved XML at : "+ path +" with name " +fileName);
		}
	}

	private XMLManager CreateXMLFile(string path)
	{
		XMLManager XMLLoad;
		Debug.LogWarning("XML created in " + path + "folder");
		XMLLoad = new XMLManager();
		XMLLoad.Save(Application.dataPath + path + fileName);
		return XMLLoad;
	}
}
