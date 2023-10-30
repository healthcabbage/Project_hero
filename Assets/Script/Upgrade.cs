using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrade : MonoBehaviour
{
    public PlayerData[] datas;
    public PlayerData data;
    public TotalData totaldata;
    public ShopManager shop;

    int datanum;
    public int hpupcount;
    public int atkcount;
    public int spdcount;
    public int crtcount;
    public int spskillcount;
    public int expcount;
    public int shopcount;
    public int coincount;
    public int itemdragcount;
    public int rerolecount;

    public int checknum = 0;

    public TMP_Text[] upgrade_text;
    public TMP_Text upgrade_say;

    public GameObject upgrade_text_obj;
    public GameObject hideupgradebutton;

    public void select_data(int num)
    {
        switch(num)
        {
            case 0:
                data = datas[0];
                datanum = num;
                break;
            case 1:
                data = datas[1];
                datanum = num;
                break;
            case 2:
                data = datas[2];
                datanum = num;
                break;
            case 3:
                data = datas[3];
                datanum = num;
                break;
            case 4:
                data = datas[4];
                datanum = num;
                break;
            case 5:
                data = datas[5];
                datanum = num;
                break;
            case 6:
                data = datas[6];
                datanum = num;
                break;
            case 7:
                data = datas[7];
                datanum = num;
                break;
        }
    }

    public void OnEnable()
    {
        StateUpdate();
        Upgradetext();
    }

    void StateUpdate()
    {
        hpupcount = totaldata.hp_up[datanum];
        atkcount = totaldata.atk_up[datanum];
        spdcount = totaldata.speed_up[datanum];
        crtcount = totaldata.critical_up[datanum];
        spskillcount = totaldata.spskill_up[datanum];
        expcount = totaldata.exp_up[datanum];
        shopcount = totaldata.shopmaking_up[datanum];
        coincount = totaldata.coin_up[datanum];
        itemdragcount = totaldata.itemdrage_up[datanum];
        rerolecount = totaldata.leveluprerole_up[datanum];
    }

    public void Upgradetext()
    {
        upgrade_text[datanum].text = "Lv." + hpupcount;
        upgrade_text[datanum].text = "Lv." + atkcount;
        upgrade_text[datanum].text = "Lv." + spdcount;
        upgrade_text[datanum].text = "Lv." + crtcount;
        upgrade_text[datanum].text = "Lv." + spskillcount;
        upgrade_text[datanum].text = "Lv." + expcount;
        upgrade_text[datanum].text = "Lv." + shopcount;
        upgrade_text[datanum].text = "Lv." + coincount;
        upgrade_text[datanum].text = "Lv." + itemdragcount;
        upgrade_text[datanum].text = "Lv." + rerolecount;
    }

    public void UpgradeDialog(int num)
    {
        switch(num)
        {
            case 0:
                upgrade_say.text = "캐릭터의 HP 5 증가합니다.";
                break;
            case 1:
                upgrade_say.text = "캐릭터의 공격력이 4% 증가합니다.";
                break;
            case 2:
                upgrade_say.text = "캐릭터의 이동속도가 6% 증가합니다.";
                break;
            case 3:
                upgrade_say.text = "캐릭터의 크리티컬 확률 2% 증가합니다.";
                break;
            case 4:
                upgrade_say.text = "캐릭터의 궁극기 쿨타임이 4% 감소합니다.";
                break;
            case 5:
                upgrade_say.text = "캐릭터의 경험치 획득량이 4% 증가합니다.";
                break;
            case 6:
                upgrade_say.text = "떠돌이 상인 등장확률이 5% 증가합니다.";
                break;
            case 7:
                upgrade_say.text = "캐릭터의 코인 획득량이 20% 증가합니다.";
                break;
            case 8:
                upgrade_say.text = "캐릭터의 아이템 획득 범위가 10% 증가합니다.";
                break;
            case 9:
                upgrade_say.text = "레벨업시 옵션 다시 뽑기 기회를 한개 추가합니다.";
                break;
        }
    }

    public void Upgrade_rotation()
    {
        switch(checknum)
        {
            case 1:
                if (hpupcount < 10)
                    hpUp();
                break;
            case 2:
                if (atkcount < 10)
                    atkUp();
                break;
            case 3:
                if (spdcount < 10)
                    speedUp();
                break;
            case 4:
                if (crtcount < 6)
                    CtrUp();
                break;
            case 5:
                if (spskillcount < 6)
                    Spskillcooldown();
                break;
            case 6:
                if (expcount < 6)
                    ExpUp();
                break;
            case 7:
                if (shopcount < 10)
                    ShopmkUp();
                break;
            case 8:
                if (coincount < 10)
                    CoinUp();
                break;
            case 9:
                if (itemdragcount < 10)
                    ItemUp();
                break;
            case 10:
                if (rerolecount < 6)
                    rerole();
                break;
        }
    }

    public void check(int num)
    {
        switch(num)
        {
            case 0:
                checknum = 1;
                break;
            case 1:
                checknum = 2;
                break;
            case 2:
                checknum = 3;
                break;
            case 3:
                checknum = 4;
                break;
            case 4:
                checknum = 5;
                break;
            case 5:
                checknum = 6;
                break;
            case 6:
                checknum = 7;
                break;
            case 7:
                checknum = 8;
                break;
            case 8:
                checknum = 9;
                break;
        }
    }

    void hpUp()
    {
        if (totaldata.total_Coin >= totaldata.hp_coin[totaldata.hp_up[datanum]])
        {
            shop.say(6);
            switch (hpupcount)
            {
                case 0:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 1:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 2:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 3:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 4:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 5:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 6:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 7:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 8:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
                case 9:
                    totaldata.hp_up[datanum] = ++totaldata.hp_up[datanum];
                    data.shop_hp = data.shop_hp + 5;
                    break;
            }
        }
        else
        {
            shop.say(7);
        }
    }

    void atkUp()
    {
        if (totaldata.total_Coin >= totaldata.atk_coin[totaldata.atk_up[datanum]])
        {
            shop.say(6);
            switch (totaldata.atk_up[datanum])
            {
                case 0:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk; 
                    break;
                case 1:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
                case 2:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
                case 3:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
                case 4:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
                case 5:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
                case 6:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
                case 7:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
                case 8:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
                case 9:
                    totaldata.atk_up[datanum] = ++totaldata.atk_up[datanum];
                    data.shop_atk = 4 + data.shop_atk;
                    break;
            }
        }
        else
        {
            shop.say(7);
        }
    }

    void speedUp()
    {
        if (totaldata.total_Coin >= totaldata.speed_coin[totaldata.speed_up[datanum]])
        {
            shop.say(6);
            switch(totaldata.speed_up[datanum])
            {
                case 0:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 1:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 2:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 3:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 4:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 5:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 6:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 7:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 8:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
                case 9:
                    totaldata.speed_up[datanum] = ++totaldata.speed_up[datanum];
                    data.shop_speed = 6 + data.shop_speed;
                    break;
            }
        }
        else
        {
            shop.say(7);
        }
    }

    void CtrUp()
    {
        if (totaldata.total_Coin >= totaldata.critical_coin[totaldata.critical_coin[datanum]])
        {
            shop.say(6);
            switch(totaldata.critical_up[datanum])
            {
                case 0:
                    totaldata.critical_up[datanum] = ++totaldata.critical_up[datanum];
                    data.shop_critical = data.shop_critical + 2;
                    break;
                case 1:
                    totaldata.critical_up[datanum] = ++totaldata.critical_up[datanum];
                    data.shop_critical = data.shop_critical + 2;
                    break;
                case 2:
                    totaldata.critical_up[datanum] = ++totaldata.critical_up[datanum];
                    data.shop_critical = data.shop_critical + 2;
                    break;
                case 3:
                    totaldata.critical_up[datanum] = ++totaldata.critical_up[datanum];
                    data.shop_critical = data.shop_critical + 2;
                    break;
                case 4:
                    totaldata.critical_up[datanum] = ++totaldata.critical_up[datanum];
                    data.shop_critical = data.shop_critical + 2;
                    break;
            }
        }
        else
        {
            shop.say(7);
        }
    }

    void Spskillcooldown()
    {
        if (totaldata.total_Coin >= totaldata.spskill_coin[totaldata.spskill_up[datanum]])
        {
            switch (totaldata.spskill_up[datanum])
            {
                case 0:
                    totaldata.spskill_up[datanum] = ++totaldata.spskill_up[datanum];
                    data.specialcooltime = data.specialcooltime - 4;
                    break;
                case 1:
                    totaldata.spskill_up[datanum] = ++totaldata.spskill_up[datanum];
                    data.specialcooltime = data.specialcooltime - 4;
                    break;
                case 2:
                    totaldata.spskill_up[datanum] = ++totaldata.spskill_up[datanum];
                    data.specialcooltime = data.specialcooltime - 4;
                    break;
                case 3:
                    totaldata.spskill_up[datanum] = ++totaldata.spskill_up[datanum];
                    data.specialcooltime = data.specialcooltime - 4;
                    break;
                case 4:
                    totaldata.spskill_up[datanum] = ++totaldata.spskill_up[datanum];
                    data.specialcooltime = data.specialcooltime - 4;
                    break;
            }
        }
        else
            shop.say(7);
    }

    void ExpUp()
    {
        if (totaldata.total_Coin >= totaldata.exp_coin[totaldata.exp_up[datanum]])
        {
            shop.say(6);
            switch(totaldata.exp_up[datanum])
            {
                case 0:
                    totaldata.exp_up[datanum] = ++totaldata.exp_up[datanum];
                    data.expplus = data.expplus + 4;
                    break;
                case 1:
                    totaldata.exp_up[datanum] = ++totaldata.exp_up[datanum];
                    data.expplus = data.expplus + 4;
                    break;
                case 2:
                    totaldata.exp_up[datanum] = ++totaldata.exp_up[datanum];
                    data.expplus = data.expplus + 4;
                    break;
                case 3:
                    totaldata.exp_up[datanum] = ++totaldata.exp_up[datanum];
                    data.expplus = data.expplus + 4;
                    break;
                case 4:
                    totaldata.exp_up[datanum] = ++totaldata.exp_up[datanum];
                    data.expplus = data.expplus + 4;
                    break;
            }
        }
        else
            shop.say(7);
    }

    void ShopmkUp()
    {
        if (totaldata.total_Coin >= totaldata.shop_coin[totaldata.shopmaking_up[datanum]])
        {
            shop.say(6);
            switch(totaldata.shopmaking_up[datanum])
            {
                case 0:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 1:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 2:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 3:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 4:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 5:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 6:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 7:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 8:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
                case 9:
                    totaldata.shopmaking_up[datanum] = ++totaldata.shopmaking_up[datanum];
                    data.shopmaking = data.shopmaking + 5;
                    break;
            }
        }
        else
            shop.say(7);
    }

    void CoinUp()
    {
        if (totaldata.total_Coin >= totaldata.coin_coin[totaldata.coin_up[datanum]])
        {
            shop.say(6);
            switch (totaldata.coin_up[datanum])
            {
                case 0:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 1:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 2:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 3:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 4:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 5:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 6:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 7:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 8:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
                case 9:
                    totaldata.coin_up[datanum] = ++totaldata.coin_up[datanum];
                    data.coinplus = data.coinplus + 20;
                    break;
            }
        }
        else
            shop.say(7);
    }

    void ItemUp()
    {
        if (totaldata.total_Coin >= totaldata.item_coin[totaldata.itemdrage_up[datanum]])
        {
            shop.say(6);
            switch(totaldata.itemdrage_up[datanum])
            {
                case 0:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 1:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 2:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 3:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 4:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 5:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 6:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 7:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 8:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
                case 9:
                    totaldata.itemdrage_up[datanum] = ++totaldata.itemdrage_up[datanum];
                    data.itemdragrage = data.itemdragrage + 10;
                    break;
            }
        }
        else
            shop.say(7);
    }

    void rerole()
    {
        if (totaldata.total_Coin >= totaldata.leveluprerole_coin[totaldata.leveluprerole_up[datanum]])
        {
            shop.say(6);
            switch(totaldata.leveluprerole_up[datanum])
            {
                case 0:
                    totaldata.leveluprerole_up[datanum] = ++totaldata.leveluprerole_up[datanum];
                    data.rerole = data.rerole + 1;
                    break;
                case 1:
                    totaldata.leveluprerole_up[datanum] = ++totaldata.leveluprerole_up[datanum];
                    data.rerole = data.rerole + 1;
                    break;
                case 2:
                    totaldata.leveluprerole_up[datanum] = ++totaldata.leveluprerole_up[datanum];
                    data.rerole = data.rerole + 1;
                    break;
                case 3:
                    totaldata.leveluprerole_up[datanum] = ++totaldata.leveluprerole_up[datanum];
                    data.rerole = data.rerole + 1;
                    break;
                case 4:
                    totaldata.leveluprerole_up[datanum] = ++totaldata.leveluprerole_up[datanum];
                    data.rerole = data.rerole + 1;
                    break;
            }
        }
        else
            shop.say(7);
    }

    public void hide(int num)
    {
        switch(num)
        {
            case 0:
                if (totaldata.hp_up[datanum] > 9)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 1:
                if (totaldata.atk_up[datanum] > 9)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 2:
                if (totaldata.speed_up[datanum] > 9)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 3:
                if (totaldata.critical_up[datanum] > 5)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 4:
                if (totaldata.spskill_up[datanum] > 5)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 5:
                if (totaldata.exp_up[datanum] > 5)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 6:
                if (totaldata.shopmaking_up[datanum] > 10)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 7:
                if (totaldata.coin_up[datanum] > 10)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 8:
                if (totaldata.itemdrage_up[datanum] > 10)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
            case 9:
                if (totaldata.leveluprerole_up[datanum] > 5)
                    hideupgradebutton.SetActive(false);
                else
                    hideupgradebutton.SetActive(true);
                break;
        }
    }
}
