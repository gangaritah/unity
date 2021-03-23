using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NvigateJugar : MonoBehaviour
{
    public Button buttonJugar;

	void Start () {
		Button btn = buttonJugar.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClickButtonJugar);
	}

	void TaskOnClickButtonJugar(){
		SceneManager.LoadScene("MenuNiveles");
	}
}
