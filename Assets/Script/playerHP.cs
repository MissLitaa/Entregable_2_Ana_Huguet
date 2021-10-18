using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHP : MonoBehaviour
{
    // Start is called before the first frame update

    //La variable indica si es Game Over.
    [SerializeField] private bool isGameOver;

    //La variable indica la vida del player.
    private int PlayerHP = 100;

    //La variable indica el daño recibido por el player.
    public int Damage = 30;


    void Start()
    {
        Debug.Log($"Player HP: {PlayerHP -= Damage}");
    }

    // Update is called once per frame
    void Update()
    {

        if (isGameOver == false)

        {
            if (PlayerHP <= 0)
            {
                Debug.Log("Te has quedado sin vida...GAME OVER");
            }

            else if (PlayerHP < 20)
            {
                Debug.Log("¡Tienes poca vida!");
            }

            else
            {
                Debug.Log($"Vas bien de vida; tienes  {PlayerHP} puntos de vida.");
            }
        }

        if (isGameOver == true)
        {
            Debug.Log("GAME OVER");
        }
    }
}
