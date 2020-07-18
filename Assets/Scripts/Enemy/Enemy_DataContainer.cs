using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_DataContainer : MonoBehaviour
{
    public float amountOfBullets;

    public float periodOfShooting;
    public float pauseBetweenShooting;

    public float bulletSpeed;
    public GameObject bullet;
    public Transform bulletPackage;

    public bool isGameOn;
    
    public Transform player;
}
