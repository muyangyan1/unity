using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitch : MonoBehaviour {
	public void GoToLevel (string level)
    {
        Application.LoadLevel(level);
	}
}
