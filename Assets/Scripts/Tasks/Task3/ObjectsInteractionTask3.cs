using System;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private Lamp [] _lamps;
    private void Start()
    {
        _lamps = FindObjectsOfType<Lamp>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var component in _lamps)
            {
                component.Interact();
            }
        }
        
    }
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
}