using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text[] buttonTxtDisplayList;



    private void Awake()
    {
        SetGameControllerReferenceOnButtons();
    }

    public void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonTxtDisplayList.Length; i++)
        {
            buttonTxtDisplayList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }

    public string GetPlayerSide()
    {
        return "?";
    }

    public void EndTurn()
    {
        Debug.Log("EndTurn is not implemented!");
    }
}
