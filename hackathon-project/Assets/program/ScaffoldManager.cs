using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaffoldManager : MonoBehaviour
{

    public GameObject scaffold;
    public int spawnZ = -2;
    public List<GameObject> scaffolds;

    // Start is called before the first frame update
    void Start()
    {
        scaffolds = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mp = Input.mousePosition;
            mp.z = spawnZ + 10; //Ç»ÇÒÇ≈Ç©-10Ç≥ÇÍÇÈÇ©ÇÁï‚ê≥
            Vector3 mouse_point = Camera.main.ScreenToWorldPoint(mp);

            GameObject sc = Instantiate(scaffold, mouse_point, Quaternion.identity);
            scaffolds.Add(sc);
        }
    }
}
