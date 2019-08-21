using System;
using UnityEngine;

public static class Debugger
{
    public static bool MustLog => PlayerPrefs.GetInt("MustLog", Debug.isDebugBuild ? 1 : 0) == 1;

    public static void SetLogState(bool mustLog){
        PlayerPrefs.SetInt("MustLog", mustLog ? 1 : 0);
    }

    public static void Log(object message, UnityEngine.Object context = null)
    {
        if (MustLog)
        {
            Debug.Log(message, context);
        }
    }

    public static void LogWarning(object message, UnityEngine.Object context = null)
    {
        if (MustLog)
        {
            Debug.LogWarning(message, context);
        }
    }

    public static void LogError(object message, UnityEngine.Object context = null)
    {
        if (MustLog)
        {
            Debug.LogError(message, context);
        }
    }

    public static void LogException(Exception e, UnityEngine.Object context = null)
    {
        Debug.LogException(e, context);
    }

    public static void Assert(bool condition, object message = null, UnityEngine.Object context = null)
    {
        Debug.Assert(condition, message, context);
    }

    public static void Break()
    {
        Debug.Break();
    }
}
