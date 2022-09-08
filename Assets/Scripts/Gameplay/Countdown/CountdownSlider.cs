using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownSlider : MonoBehaviour
{
    public Slider CountdownBar;
    private float _time;
    [SerializeField] private float _maxTime = 30f;

    void Start()
    {
        _time = _maxTime;
        CountdownBar = GetComponent<Slider>();
        CountdownBar.maxValue = _maxTime;
        CountdownBar.value = _time;
    }
    void Update()
    {
        _time -= Time.deltaTime;
        CountdownBar.value = _time;
    }
}
