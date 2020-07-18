using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Требование компонента типа Player_DataContainer для корректной игры
[RequireComponent(typeof(Player_DataContainer))]
public class Player_Mechanics : MonoBehaviour
{
    private Player_DataContainer playerData;
    [SerializeField] private Transform centerOfRotation;    

    private void Awake()
    {
        playerData = GetComponent<Player_DataContainer>();

        transform.position = new Vector2(0, centerOfRotation.position.y - playerData.distanceToCenter);
    }

    private void FixedUpdate()
    {
        Vector3 direction;

        if (Input.GetMouseButtonDown(0)) playerData.isClockwiseDirectioned = !playerData.isClockwiseDirectioned;

        if (playerData.isClockwiseDirectioned) direction = Vector3.forward;
        else direction = Vector3.back;

        transform.RotateAround(centerOfRotation.position, direction, playerData.speed);
    }
}
