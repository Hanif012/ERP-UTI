using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Costumer : MonoBehaviour
{
    public CustomerData[] customerData;          // Array of customer data
    public CurrencyManager currencyManager;      // Reference to the CurrencyManager
    public GameObject[] CostumerPrefab;          // Array of customer prefabs
    public float spawnInterval = 5f;             // Time interval between spawns

    public int customerIndex = 0;               // Current index of the customer to spawn/despawn

    private void Start()
    {
        StartCoroutine(SpawnCustomerRoutine());
    }

    // Coroutine to spawn customers at regular intervals
    private IEnumerator SpawnCustomerRoutine()
    {
        while (true)
        {
            SpawnCustomer(customerIndex); // Spawn customer
            yield return new WaitForSeconds(spawnInterval);
            DespawnCustomer(customerIndex); // Despawn customer

            // Increment and wrap the index to cycle through customers
            customerIndex = (customerIndex + 1) % CostumerPrefab.Length;
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Method to spawn a customer
    public void SpawnCustomer(int index)
    {
        if (customerData.Length == 0 || CostumerPrefab.Length == 0)
        {
            Debug.LogWarning("Customer data or prefabs are not set up correctly.");
            return;
        }

        if (index >= 0 && index < CostumerPrefab.Length && CostumerPrefab[index] != null)
        {
            CostumerPrefab[index].SetActive(true);
            Debug.Log("Spawned customer: " + customerData[index].customerName);
        }
        else
        {
            Debug.LogWarning("Prefab for selected customer is missing or index is out of range.");
        }
    }

    // Method to despawn a customer
    public void DespawnCustomer(int index)
    {
        if (index >= 0 && index < CostumerPrefab.Length && CostumerPrefab[index] != null)
        {
            CostumerPrefab[index].SetActive(false);
            Debug.Log("Despawned customer: " + customerData[index].customerName);
        }
        else
        {
            Debug.LogWarning("Prefab for selected customer is missing or index is out of range.");
        }
    }
}
