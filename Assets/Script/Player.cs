using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public Scanner scanner;
    public Hand[] hands;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator anim;
    public int checkdata;

    public PlayerData[] datas;
    public PlayerData data;

    //player data
    public float atk;
    public float speed;
    public float critical;
    public float itemdrag;


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        scanner = GetComponent<Scanner>();
        hands = GetComponentsInChildren<Hand>(true);

        Check();
        State();
    }

    void Start()
    {
        
    }

    private void OnEnable()
    {
        anim.runtimeAnimatorController = data.anim;
    }

    void Check()
    {
        PlayerPrefs.GetInt("JobID", checkdata);

        switch(checkdata)
        {
            case 0:
                data = datas[0];
                break;
            case 1:
                data = datas[1];
                break;
            case 2:
                data = datas[2];
                break;
            case 3:
                data = datas[3];
                break;
            case 4:
                data = datas[4];
                break;
            case 5:
                data = datas[5];
                break;
            case 6:
                data = datas[6];
                break;
            case 7:
                data = datas[7];
                break;
        }
    }

    void Update()
    {
        if (!GameManager.instance.isLive)
            return;

        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.instance.Spskill();
        }
    }

    void FixedUpdate()
    {
        if (!GameManager.instance.isLive)
            return;

        Vector2 nextVector = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVector);
    }

    void LateUpdate()
    {
        if (!GameManager.instance.isLive)
            return;

        anim.SetFloat("Speed", inputVec.magnitude);

        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!GameManager.instance.isLive)
            return;

        GameManager.instance.health -= Time.deltaTime * 10;

        if (GameManager.instance.health < 0)
        {
            for (int index = 2; index < transform.childCount; index++)
            {
                transform.GetChild(index).gameObject.SetActive(false);
            }

            anim.SetTrigger("Dead");
            GameManager.instance.GameOver();
        }
    }

    void State()
    {
        speed = data.speed + data.shop_speed;
        atk = data.atk + data.shop_atk;
        critical = data.critical + data.shop_critical;
    }
}
