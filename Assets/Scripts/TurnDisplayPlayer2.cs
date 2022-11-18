using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnDisplayPlayer2 : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private TMP_Text player2turn;

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            
            TurnDisplay();
        }
    }
    private IEnumerator TurnDisplay()
    {
        TextMeshProUGUI player2turn = GetComponent<TextMeshProUGUI>();
        player2turn.enabled = true;
        yield return new WaitForSeconds(5);
        player2turn.enabled = false;
        
    }
}
