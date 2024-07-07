using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public CurrencyManager currencyManager;
    public Costumer costumer;
    public GameObject spawnPoint;
    public GameObject endpoint;
    public GameObject vehiclePrefab;
    private GameObject spawnedVehicle;
    public bool isVehicleSpawned = false;
    [SerializeField]
    private float speed = 5f;

    private int index;
    public string vehicleName;
    public string vehicleType;
    public int IsBought = 0;
    public float VehiclePrice;
    public float VehicleProduceSpeed;
    public float VehicleProduceAmount;
    public float vehicleUpgradeCost;
    private bool isDone = false;

    void Awake()
    {
        // Ensure all required components and objects are properly assigned
        if (costumer == null) costumer = GetComponent<Costumer>();
        if (currencyManager == null) Debug.LogError("CurrencyManager is not assigned.");
        if (spawnPoint == null) Debug.LogError("Spawn Point is not assigned.");
        if (endpoint == null) Debug.LogError("Endpoint is not assigned.");
        if (vehiclePrefab == null) Debug.LogError("Vehicle Prefab is not assigned.");
    }

    void Update()
    {

        HandleSpawningAndMovement();
        Pay();
    }

    private void SpawnVehicle()
    {
        if (vehiclePrefab != null && spawnPoint != null)
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
        index = Random.Range(0, 4);
        if (!isVehicleSpawned && IsBought == 1)
        {
            SpawnVehicle();
            isVehicleSpawned = true;
        }

        if (spawnedVehicle != null)
        {
            MoveVehicle(endpoint.transform.position);
            if (Vector3.Distance(spawnedVehicle.transform.position, endpoint.transform.position) < 0.1f)
            {
                Destroy(spawnedVehicle);
                isVehicleSpawned = false;
                isDone = false;  // Reset isDone when vehicle reaches endpoint
                if (costumer != null)
                {
                    costumer.DespawnCustomer(index);  // Call to despawn the customer
                }
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
            
            if (costumer != null) costumer.SpawnCustomer(index);  // Reintroduced with null check
            if (currencyManager != null) currencyManager.currentMoney += VehicleProduceAmount * VehicleProduceSpeed * costumer.customerData[index].Multiplier;
            isDone = true;
        }
    }
}
