using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaffoldManager : MonoBehaviour
{

    public GameObject scaffold;
    public int spawnZ = -2;
    public List<GameObject> scaffolds;
    public Vector2 LastGeneratedPos = new Vector2();
    public GameObject LastTouchObj;
    public GameObject PlayerObject;


    void Awake()
    {
        this.tag = "ScaffoldManager";

        //for (int i = 0; i < 10; i++)
        //{
        //    SpawnScaffold(new Vector2(-5f, -6f + i * 0.6f));
        //}

    }

    // Start is called before the first frame update
    void Start()
    {
        scaffolds = new List<GameObject>();
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (scaffolds.Count <= 0)
        {
            SpawnScaffold(
                new Vector2(
                    Random.Range(-13f, 3f),
                    -2.5f));
        }
    }

   public GameObject SpawnScaffold(Vector2 spawnPoint)
    {
        GameObject sc = Instantiate(scaffold, spawnPoint, Quaternion.identity);
        scaffolds.Add(sc);
        sc.transform.parent = this.transform;
        LastGeneratedPos = spawnPoint;
        return sc;
    }
}
