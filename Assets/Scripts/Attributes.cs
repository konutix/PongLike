using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    [SerializeField] private int maxHp = 100;
    [SerializeField] private int hp = 0;
    [SerializeField] private int maxStamina = 50;
    [SerializeField] private int stamina = 0;
    [SerializeField] private int coins = 0;
    [SerializeField] private int exp = 0;

    public int HP => hp;
    public int Stamina => stamina;
    public int Coins => coins;
    public int Exp => exp;

    public void TakeDamage(int amount) => hp = Mathf.Max(hp - amount, 0);
    public void AddCoins(int amount) => coins += amount;
    public void AddExp(int amount) => exp += amount;

    private void Start()
    {
        hp = maxHp;
        stamina = maxStamina;
    }
}
