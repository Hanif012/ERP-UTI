using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public CurrencyManager currencyManager;
    // public CustomerData customerData;

    public GameObject spawnPoint;
    public GameObject endpoint;
    public GameObject vehiclePrefab;
    private GameObject spawnedVehicle;
    public bool isVehicleSpawned = false;
    private int vehicleIndex = 0;
    [SerializeField]
    private float speed = 5f;

    public string vehicleName;
    public string vehicleType;
    public int IsBought = 0;
    public float VehiclePrice;
    public float VehicleProduceSpeed;
    public float VehicleProduceAmount;
    public float vehicleUpgradeCost;
    private bool isDone = false;

    void Update()
    {
        HandleSpawningAndMovement();
        Pay();
    }

    private void SpawnVehicle()
    {
        if (vehiclePrefab != null)
        {
            if (spawnedVehicle != null)
            {
                Destroy(spawnedVehicle);
            }
            spawnedVehicle = Instantiate(vehiclePrefab, spawnPoint.transform.position, Quaternion.identity);
        }
    }

    private void HandleSpawningAndMovement()
    {
        if (!isVehicleSpawned)
        {
            if (IsBought == 1)
            {
                SpawnVehicle();
                isVehicleSpawned = true;
            }
            vehicleIndex++;
        }

        // Handle vehicle movement
        if (spawnedVehicle != null)
        {
            MoveVehicle(endpoint.transform.position);

            if (Vector3.Distance(spawnedVehicle.transform.position, endpoint.transform.position) < 0.1f)
            {
                Destroy(spawnedVehicle);
                isVehicleSpawned = false;
                Debug.Log("Vehicle has reached the endpoint");
            }
        }
    }

    private void MoveVehicle(Vector3 targetPosition)
    {
        if (spawnedVehicle != null)
        {
            spawnedVehicle.transform.position = Vector3.MoveTowards(
                spawnedVehicle.transform.position,
                targetPosition,
                speed * Time.deltaTime
            );
        }
    }

    private void Pay()
    {
        if (IsBought == 1 && !isDone)
        {
            currencyManager.currentMoney += VehicleProduceAmount * VehicleProduceSpeed;
            isDone = false;
        }
        if (isVehicleSpawned)
        {
            isDone = true;
        }
    }
}
