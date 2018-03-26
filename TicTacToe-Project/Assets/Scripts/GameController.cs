using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text[] buttonTxtDisplayList;

    private string playerSide;



    private void Awake()
    {
        SetGameControllerReferenceOnButtons();

        playerSide = "X";
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
        return playerSide;
    }

    public void EndTurn()
    {
        //Debug.Log("EndTurn is not implemented!"); This seems very useful

        // HORIZONTALS
        if (buttonTxtDisplayList[0].text == playerSide && buttonTxtDisplayList[1].text == playerSide && buttonTxtDisplayList[2].text == playerSide)
            GameOver();
        else if (buttonTxtDisplayList[3].text == playerSide && buttonTxtDisplayList[4].text == playerSide && buttonTxtDisplayList[5].text == playerSide)
            GameOver();
        else if (buttonTxtDisplayList[6].text == playerSide && buttonTxtDisplayList[7].text == playerSide && buttonTxtDisplayList[8].text == playerSide)
            GameOver();
        // VERTICALS
        else if (buttonTxtDisplayList[0].text == playerSide && buttonTxtDisplayList[3].text == playerSide && buttonTxtDisplayList[6].text == playerSide)
            GameOver();
        else if (buttonTxtDisplayList[1].text == playerSide && buttonTxtDisplayList[4].text == playerSide && buttonTxtDisplayList[7].text == playerSide)
            GameOver();
        else if (buttonTxtDisplayList[2].text == playerSide && buttonTxtDisplayList[5].text == playerSide && buttonTxtDisplayList[8].text == playerSide)
            GameOver();
        // DIAGONALS
        else if (buttonTxtDisplayList[0].text == playerSide && buttonTxtDisplayList[4].text == playerSide && buttonTxtDisplayList[8].text == playerSide)
            GameOver();
        else if (buttonTxtDisplayList[2].text == playerSide && buttonTxtDisplayList[4].text == playerSide && buttonTxtDisplayList[6].text == playerSide)
            GameOver();
        else
            ChangeSides();





    }


    void GameOver()
    {
        for (int i = 0; i < buttonTxtDisplayList.Length; i++)
        {
            buttonTxtDisplayList[i].GetComponentInParent<Button>().interactable = false;
        }
    }


    void ChangeSides()
    {
        playerSide = (playerSide == "X") ? "O" : "X";
    }
}
