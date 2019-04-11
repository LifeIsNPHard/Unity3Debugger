using UnityEngine;

public static class Debugger
{
    public static bool MustLog => Debug.isDebugBuild;

    public static void Log(string message, Object obj = null)
    {
        if (MustLog)
        {
            Debug.Log(message, obj);
        }
    }

    public static void LogWarning(string message, Object obj = null)
    {
        if (MustLog)
        {
            Debug.LogWarning(message, obj);
        }
    }

    public static void LogError(string message, Object obj = null)
    {
        if (MustLog)
        {
            Debug.LogError(message, obj);
        }
    }

    public static void LogException(System.Exception e, Object obj = null)
    {
        if (MustLog)
        {
            Debug.LogException(e, obj);
        }
    }
}
