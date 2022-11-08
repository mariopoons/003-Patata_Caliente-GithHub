using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    public int randomNumber;
    public int clickCounter;

    private void Start()
    {
        randomNumber = Random.Range(1, 11);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter(); 
        }
        if (Input.GetMouseButtonDown(1))
        {
            takeOneToCounter();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (haveIWon())
                Debug.Log("¡Ereh elmejóh!");
        }
    }

    private void AddOneToCounter()
    {
        clickCounter++;
        transform.localScale += Vector3.one;
    }
    private void takeOneToCounter()
    {
        clickCounter--;
        transform.localScale -= Vector3.one;
    }
    private bool haveIWon()
    {
            if(clickCounter<randomNumber)
            {
            Debug.Log($"Te has quedadocorto. Has hecho {clickCounter} clicks pero el número aleatorio era {randomNumber}.");
            return false;
            }
                else if(clickCounter==randomNumber)
            {
            Debug.Log("¡Has acertado!");
            return true;
            }
        Debug.Log("¡Te has pasado de largo!, vuelvelo a intentar pedazo de animal.");
        Destroy(gameObject);
        return false;
    }
}
