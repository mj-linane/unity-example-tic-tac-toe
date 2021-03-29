// For Instructions:
// https://learn.unity.com/tutorial/creating-a-tic-tac-toe-game-using-only-ui-components#5c7f8528edbc2a002053b4c1

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour {

    public Button button;
    public Text buttonText;

    private GameController gameController;

    public void SetGameControllerReference (GameController controller) {
        gameController = controller;
    }

    public void SetSpace () {
        buttonText.text = gameController.GetPlayerSide ();
        button.interactable = false;
        gameController.EndTurn ();
    }
}