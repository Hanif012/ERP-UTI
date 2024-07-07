using UnityEngine;

[CreateAssetMenu(menuName = "ERP-UTI/CustomerData")]
public class CustomerData : ScriptableObject
{
    public string customerName;
    public string description;
    public float Multiplier = 1;
    public Sprite portrait;
}
