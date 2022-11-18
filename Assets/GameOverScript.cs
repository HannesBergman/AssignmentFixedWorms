using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private Vector2 _positionToMoveTo;

    [SerializeField] private TextMeshProUGUI _winnerText;
    
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    private float player1Health;
    private float player2Health;
    private bool _isOver;

    private void Start()
    {
        _isOver = false;
    }

    private void Update()
    {
        player1Health = player1.GetComponent<ActivePlayerHealth>().currentHealth;
        player2Health = player2.GetComponent<ActivePlayerHealth>().currentHealth;
        
        if(player1Health <= 0)
        {
            StartCoroutine(GameOverTextPosition(_positionToMoveTo, 0.2f));
            if(_isOver)
                GameOver();
        }
        if(player2Health <= 0)
        {
            StartCoroutine(GameOverTextPosition(_positionToMoveTo, 0.2f));
            if(_isOver)    
                GameOver();
        }
    }
    public void GameOver()
    {
        

        if (player1Health < player2Health)
        {
            _winnerText.text = "PLAYER 2 WINS!";
        }
        else if (player1Health > player2Health)
        {
            _winnerText.text = "PLAYER 1 WINS!";
        }
        else
        {
            _winnerText.text = "DRAW!";
        }

        Cursor.visible = true;
        Time.timeScale = 0;
    }
    public IEnumerator GameOverTextPosition(Vector2 targetPosition, float duration)
    {
        float time = 0;
        Vector2 startPosition = _rectTransform.anchoredPosition;
        while (time < duration)
        {
            _rectTransform.anchoredPosition = Vector2.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        _rectTransform.anchoredPosition = targetPosition;
        _isOver = true;
    }
}
