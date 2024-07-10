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
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mp = Input.mousePosition;
            mp.z = spawnZ + 10; //Ç»ÇÒÇ≈Ç©-10Ç≥ÇÍÇÈÇ©ÇÁï‚ê≥
            Vector3 mouse_point = Camera.main.ScreenToWorldPoint(mp);

            SpawnScaffold(new Vector2(mouse_point.x, mouse_point.y)); 
        }


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
