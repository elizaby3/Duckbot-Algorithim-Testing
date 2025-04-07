using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckBotSpawning : MonoBehaviour
{

    //constants
    public const int maxDucks = 20;
    public int xMin = -25;
    public int xMax = 15;
    public int zMin = -20;
    public int zMax = 15;

    public GameObject DuckBot;
    public int xPos;
    public int zPos;
    public int DuckCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDucks());
    }

    private IEnumerator SpawnDucks () {
        while (DuckCount < maxDucks) {
            xPos = Random.Range(xMin, xMax);
            zPos = Random.Range(zMin, zMax);
            Instantiate(DuckBot, new Vector3 (xPos, 0, zPos), Quaternion.Euler(-90,0,0));
            yield return new WaitForSeconds(1);
            DuckCount +=1;
        }
    }
}
