using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_DataContainer : MonoBehaviour
{
    [Header("All Attacks\' Settings")]
    public float periodOfShooting;
    public float pauseBetweenShooting;
    public float attackPrepareTime;

    [Header("\"FourSideShot\" Attack Settings")]
    public float amountOfBullets_FourSideShot;

    [Header("\"Shoot in Player\" Attack Settings")]
    public float amountOfBullets_SIP;

    [Header("Bullet Settings")]
    public float bulletLifeTime;
    public float bulletSpeed;
    public GameObject bullet;
    public Transform bulletPackage;
    public float timeToDestroy;

    [Header("Game Settings")]
    public bool isGameOn;    
    public Transform player;
}
