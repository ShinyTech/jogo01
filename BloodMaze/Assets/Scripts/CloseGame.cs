using UnityEngine;
using System.Collections;

public class CloseGame : MonoBehaviour {

	public void FinalizaoJogo()
	{

		print ("Encerrando o jogo");
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#elif UNITY_WEBPLAYER
		Application.OpenURL(webplayerQuitURL);
		#else
		Application.Quit();
		#endif
	}
}
