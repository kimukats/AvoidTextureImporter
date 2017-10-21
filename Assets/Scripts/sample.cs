using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sample : MonoBehaviour {
	[SerializeField] UnityEngine.UI.RawImage m_rawImage;

	// Use this for initialization
	void Start () {
		var fpath = System.IO.Path.Combine(Application.	streamingAssetsPath,"sample.bin");
		if(System.IO.File.Exists(fpath) == true){
			var bufs = System.IO.File.ReadAllBytes(fpath);
			var texture = new Texture2D(512,512,TextureFormat.ARGB32,false);
			if(texture){
				texture.LoadImage(bufs);
				texture.Apply();
				m_rawImage.texture = texture;
			}
		}
	}	
}
