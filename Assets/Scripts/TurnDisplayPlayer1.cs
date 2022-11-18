using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TurnDisplayPlayer1 : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private TMP_Text player1turn;

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            
            TurnDisplay();
        }
    }
    private IEnumerator TurnDisplay()
    {
        TextMeshProUGUI player1turn = GetComponent<TextMeshProUGUI>();
        player1turn.enabled = true;
        yield return new WaitForSeconds(5);
        player1turn.enabled = false;
    }
}
