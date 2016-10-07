using UnityEngine;
using System.Collections;

public class EggsManager : MonoBehaviour
{

    [SerializeField]
    private GameObject[] eggs;
    public int distanceBetweenEggs;
    private float minX;
    private float maxX;
    private int controllX = 0;
    private int eggCounter = -1;
    private float startY = 6;

    void Awake()
    {
        Shuffle(eggs);
        SetMinAndMaxX();
        SpawnEgg();
    }

    void Start()
    {
    }

    void Update()
    {
        print(eggCounter + "---" + eggs[eggCounter].transform.position.y);
        print(startY - distanceBetweenEggs);
        if (eggs[eggCounter].transform.position.y < startY - distanceBetweenEggs) SpawnEgg();
    }

    private void SpawnEgg()
    {

        Vector2 temp = new Vector2(0, startY);

        if (controllX == 0)
        {
            temp.x = Random.Range(0, maxX);
            controllX = 1;
        }
        else if (controllX == 1)
        {
            temp.x = Random.Range(0, minX);
            controllX = 2;
        }
        else if (controllX == 2)
        {
            temp.x = Random.Range(1.0f, maxX);
            controllX = 3;
        }
        else if (controllX == 3)
        {

            temp.x = Random.Range(-1.0f, minX);
            controllX = 0;
        }

        print(eggCounter + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

        if (eggCounter == eggs.Length - 1)
        {
            eggCounter = 0;
            Shuffle(eggs);
        }
        else eggCounter++;
        eggs[eggCounter].transform.position = new Vector2(temp.x, startY);
        eggs[eggCounter].SetActive(true);
    }

    void SetMinAndMaxX()
    {
        minX = - GameInfo.screenBounds.x + 0.5f;
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

}
