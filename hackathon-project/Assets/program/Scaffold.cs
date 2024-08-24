using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Scaffold : MonoBehaviour
{

    public bool canChangeSize = false;
    public bool canDestroy = false;
    public float speed = 1.0f;
    public float changeSpeed = 1.0f;
    public int move_width = 1;
    public Vector3 size = new Vector3(1f, 0.5f, 1f);
   
    [SerializeField] private Vector3 pos;

    [SerializeField] private GameObject Manager;
    [SerializeField] private ScaffoldManager sca_mng;
    [SerializeField] private List<GameObject> sca_list;
    [SerializeField] private int ID;



    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        transform.localScale = size;
        Manager = GameObject.FindWithTag("ScaffoldManager");
        sca_mng = Manager.GetComponent<ScaffoldManager>();
        ID = this.gameObject.GetInstanceID();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        sca_list = sca_mng.scaffolds;

        Debug.Log((Random.Range(-1, 1)));


        //������
        transform.position = new Vector3(pos.x + Mathf.PingPong(Time.time * speed, move_width), pos.y, pos.z);
        if (canChangeSize) //�T�C�Y�ύX���Ă����́H
        {
            Vector3 new_size = size;
            new_size.x = size.x * Mathf.PingPong(Time.time * changeSpeed, 1.5f);
            transform.localScale = new_size;
        }
        else//���߂ł���
        {
            transform.localScale = size;
        }

        //���C���J�����ɉf��Ȃ����j��\�t���O���t�^����Ă���Ȃ���ł�����
        if (!GetComponent<Renderer>().isVisible && canDestroy)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && sca_list[sca_list.Count -1 ].GetInstanceID() == this.gameObject.GetInstanceID())
        {
            float level = 1.5f; //�v����
            float length = level * Random.Range(1, 5) * 0.5f; //level * 0.5 ~ 2
            float x, y;
            float xrnd = Random.Range(-4f, 4f);
            float yrnd = Random.Range(4f, 5f);

            bool plusX = (Random.Range(-1, 1) == -1) ? false : true;

            //x = transform.position.x + xrnd * (plusX ? 1 : -1);
            y = transform.position.y + yrnd;

            //Debug.Log(transform.position.x + "+" + xrnd + "=" + x);
            //Debug.Log(transform.position.y + "+" + yrnd + "=" + y);

            Scaffold new_scaffold = sca_mng.SpawnScaffold(new Vector2(xrnd, y)).GetComponent<Scaffold>();
            new_scaffold.size = new Vector3(length, 0.5f, 1f);
        }
    }
}
