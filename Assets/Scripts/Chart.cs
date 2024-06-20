using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Demo
{
    [DisallowMultipleComponent]
    public class OfficeChart : MonoBehaviour
    {
        public GameObject CurrencyManager;
        public int maxCache = 100;
        LineChart chart;
        Title m_Titles;
        System.DateTime now;
        float value;
        float m_LastTime;

        void Awake()
        {
            // Title.text = "Lorem Ipsum";
            chart = gameObject.GetComponent<LineChart>();
            chart.SetMaxCache(maxCache);
            // m_Titles.text  = "Lorem Ipsum";
            AddData();
        }

        void Update()
        {
            if (Time.time - m_LastTime >= 1f)
            {
                for (int i = 0; i < 5; i++)
                    FetchData();
                m_LastTime = Time.time;
            }
        }

        void AddData()
        {
            chart.ClearData();
            value = CurrencyManager.GetComponent<CurrencyManager>().totalMoney;
            now = new System.DateTime(1997, 9, 3);
            for (int i = 0; i < maxCache; i++)
            {
                FetchData();
            }
        }

        void FetchData()
        {
            now = now.AddDays(1);
            value = CurrencyManager.GetComponent<CurrencyManager>().totalMoney;
            chart.AddData(0, now, value);
        }
    }
}