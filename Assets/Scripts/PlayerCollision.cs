using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageLabel;
    private int score = 0;
    public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.CompareTag("NomNoms"))
        {
            Debug.Log("NomNom hit");
            score++;
            messageLabel.text = " " +score;
        }
    }
}
