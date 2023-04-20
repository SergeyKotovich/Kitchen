using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField]
    private Toaster _toaster;

    [SerializeField] 
    private Transform _waffleRoot;

    [SerializeField]
    private GameObject _prefabWaffle;

    private void Awake()
    {
        _toaster.TimerIsUp += WaffleSpawn;
    }

    private void OnDestroy()
    {
        _toaster.TimerIsUp -= WaffleSpawn;
    }

    private void WaffleSpawn()
    {
        Instantiate(_prefabWaffle, _waffleRoot);
    }

    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
}