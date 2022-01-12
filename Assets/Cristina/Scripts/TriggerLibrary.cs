using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using System;

public class TriggerLibrary : MonoBehaviour
{
    public InputDevice targetDevice;

    public GameObject library;

    private void Start()
    {
        var leftHandedControllers = new List<UnityEngine.XR.InputDevice>();
        var desiredCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand | UnityEngine.XR.InputDeviceCharacteristics.Left | UnityEngine.XR.InputDeviceCharacteristics.Controller;
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desiredCharacteristics, leftHandedControllers);

        foreach (var device in leftHandedControllers)
        {
            Debug.Log(string.Format("Device name '{0}' has characteristics '{1}'", device.name, device.characteristics.ToString()));
        }

        if (leftHandedControllers.Count > 0)
        {
            targetDevice = leftHandedControllers[0];
        }
    }
    private void FixedUpdate()
    {
        LibraryTriggered();
    }

    private void LibraryTriggered()
    {
        if (targetDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool triggerValue) && triggerValue)// "I" pressed
        {
            library.SetActive(true);

        }
        else
        {
            library.SetActive(false);
        }
    }
}
