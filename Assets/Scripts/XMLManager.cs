using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.IO.Compression;
using UnityEngine;

[XmlRoot("XMLManager")]
public class XMLManager{

	public int[] score = new int[3];

	public void Save(string path)
	{
		var serializer = new XmlSerializer(typeof(XMLManager));
		using (var stream  = new StreamWriter(File.Open(path, FileMode.Create), System.Text.Encoding.UTF8)) {
			serializer.Serialize(stream, this);
			stream.Close();
		}
	}
	
	public static XMLManager LoadPC(string path)
	{
		if(Application.platform == RuntimePlatform.WindowsEditor || 
		Application.platform == RuntimePlatform.WindowsPlayer || 
		Application.platform == RuntimePlatform.WindowsWebPlayer)
		{
			if (!File.Exists(path))
				return null;
			
			var serializer = new XmlSerializer(typeof(XMLManager));
			using(var stream = new StreamReader(File.Open(path, FileMode.Open), System.Text.Encoding.UTF8))
			{
				try{
					return serializer.Deserialize(stream) as XMLManager;
				}
				catch (System.Exception){
					return null;
				}
			}
		}
		else 
			Debug.LogWarning("Not the right platform targeted for the XML");

		return null;
	}
	
	public static string LoadMobileXMLFile(string path)
	{
		string dbPath = "";
		string realPath = "";

		if (Application.platform == RuntimePlatform.Android)
			dbPath = LoadAndroidFile(path, realPath);

		if(Application.platform == RuntimePlatform.IPhonePlayer)
			dbPath = LoadIosFile(path);
		
		return dbPath;
	}

	private static string LoadAndroidFile(string path, string realPath)
	{
		string oriPath = System.IO.Path.Combine(Application.streamingAssetsPath, path);

		// Android only use WWW to read file
		WWW reader = new WWW(oriPath);
		while ( ! reader.isDone) {}
		
		realPath = Application.persistentDataPath + "/db";
		System.IO.File.WriteAllBytes(realPath, reader.bytes);

		return realPath;
	}

	private static string LoadIosFile(string path) {
		return System.IO.Path.Combine(Application.streamingAssetsPath, path);
	}

}