using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("# Game Control")]
    public bool isLive;
    public float gameTime;
    public float maxGameTime = 2 * 10f;
    [Header("# Game Data")]
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = { 3, 5, 10, 100, 150, 210, 280, 360, 450, 600 };
    [Header("# Player Info")]
    public float health;
    public float maxhealth;
    public float Sp = 0;
    public float maxSep;
    public float Expplus;
    public float shopmaking;
    public float coinplus;
    public float Rerole;

    [Header("# Game Object")]
    public PoolManager pool;
    public Player player;
    public LevelUp uiLevelUp;
    public GameObject gameover;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        health = player.data.hp;
        health = maxhealth;

        Ch_State();

        //юс╫ц
        uiLevelUp.Select(0);

        Resume();
    }

    void Update()
    {
        if (!isLive)
            return;

        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }

        if (Sp < maxSep)
        {
            Sp += Time.deltaTime;
        }
    }

    public void GetExp()
    {
        exp++;

        if (exp == nextExp[Mathf.Min(level, nextExp.Length-1)])
        {
            level++;
            exp = 0;
            uiLevelUp.Show();
        }
    }

    public void Stop()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        isLive = true;
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        StartCoroutine(GameOverRoutine());
    }

    IEnumerator GameOverRoutine()
    {
        isLive = false;
        yield return new WaitForSeconds(0.5f);

        gameover.SetActive(true);
        Stop();
    }

    void Ch_State()
    {
        health = player.data.hp + player.data.shop_hp;
        maxhealth = health;
        maxSep = player.data.specialcooltime;
        coinplus = player.data.coinplus;
        Expplus = player.data.expplus;
        shopmaking = player.data.shopmaking;
        Rerole = player.data.rerole;
    }

    public void Spskill()
    {
        if (Sp > maxSep)
        {
            Sp = 0;
        }
    }
}
