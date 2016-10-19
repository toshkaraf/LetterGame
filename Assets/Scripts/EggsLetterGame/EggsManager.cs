using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;
using System;

public class EggsManager : MonoBehaviour
{

    [SerializeField]
    private GameObject[] eggs;
    public int distanceBetweenEggs;
    private float minX;
    private float maxX;
    private int controllX = 0;
    private int eggCounter = -1;
    private float startY = 7f;

    void Awake()
    {
        SetEggsActifeFalse();
        Shuffle(eggs);
        SetMinAndMaxX();
        SpawnEgg();
    }

    void Start()
    {
    }

    void Update()
    {
        if (eggs[eggCounter].transform.position.y < startY - distanceBetweenEggs) SpawnEgg();
    }

    private void SpawnEgg()
    {

        Vector2 temp = new Vector2(0, startY);

        if (controllX == 0)
        {
            temp.x = UnityEngine.Random.Range(0, maxX);
            controllX = 1;
        }
        else if (controllX == 1)
        {
            temp.x = UnityEngine.Random.Range(0, minX);
            controllX = 2;
        }
        else if (controllX == 2)
        {
            temp.x = UnityEngine.Random.Range(1.0f, maxX);
            controllX = 3;
        }
        else if (controllX == 3)
        {

            temp.x = UnityEngine.Random.Range(-1.0f, minX);
            controllX = 0;
        }

        if (eggCounter == eggs.Length - 1)
        {
            eggCounter = 0;
            Shuffle(eggs);
        }
        else eggCounter++;
        eggs[eggCounter].SetActive(true);
        eggs[eggCounter].transform.position = new Vector2(temp.x, startY);

    }

    void SetMinAndMaxX()
    {
        minX = -GameInfo.screenBounds.x + 0.5f;
        maxX = GameInfo.screenBounds.x - 0.5f;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        print("YAY!");
        if (target.tag == "Egg")
        {
            target.gameObject.SetActive(false);
        }
    }

    void Shuffle(GameObject[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            GameObject temp = array[i];
            int random = UnityEngine.Random.Range(i, array.Length);
            array[i] = array[random];
            array[random] = temp;
        }
    }

    private void SetEggsActifeFalse()
    {
        foreach (GameObject egg in eggs)
            egg.SetActive(false);
    }

}
