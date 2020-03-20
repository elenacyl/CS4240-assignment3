using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonClick : MonoBehaviour
{

	public static string chosenButton;
    // Start is called before the first frame update
    void Start()
    {
        chosenButton = "";
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void selectButton()
    {
		chosenButton = EventSystem.current.currentSelectedGameObject.name;
    }
}
