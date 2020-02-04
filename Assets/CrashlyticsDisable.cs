using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashlyticsDisable : MonoBehaviour
{
    private void Awake()
    {
        Firebase.Crashlytics.Crashlytics.IsCrashlyticsCollectionEnabled = false;
    }
}
