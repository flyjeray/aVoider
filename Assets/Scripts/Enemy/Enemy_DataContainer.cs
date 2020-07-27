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
    public Transform player;

    private float clockwisedFrames;
    private float unclockwisedFrames;

    public void RecordFrames(bool clockwised, float frames)
    {
        if (clockwised) clockwisedFrames = frames;
        else unclockwisedFrames = frames;
    }

    public bool DecideIsClockwiseDirectioned()
    {       
        if (clockwisedFrames < unclockwisedFrames)
        {
            Debug.Log("Should go Clockwise");

            clockwisedFrames = 0;
            unclockwisedFrames = 0;

            return true;
        }            
            
        else
        {
            Debug.Log("Should go unclockwised");

            clockwisedFrames = 0;
            unclockwisedFrames = 0;

            return false;
        }              
    }
}
