using System;
using UnityEngine;

public static class Debugger
{
    public static bool MustLog => Debug.isDebugBuild;

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
        if (MustLog)
        {
            Debug.LogException(e, context);
        }
    }

    public static void Assert(bool condition, object message = null, UnityEngine.Object context = null)
    {
        if (MustLog)
        {
            Debug.Assert(condition, message, context);
        }
    }

    public static void Break()
    {
        if (MustLog)
        {
            Debug.Break();
        }
    }
}
