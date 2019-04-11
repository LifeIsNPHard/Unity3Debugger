using System;
using UnityEngine;

public static class Debugger
{
    public static bool MustLog => Debug.isDebugBuild;
    
    public static Log(string message, Object obj = null)
    {
        if (MustLog)
        {
            Debug.Log(message, obj);
        }
    }
    
    public static LogWarning(string message, Object obj = null)
    {
        if (MustLog)
        {
            Debug.LogWarning(message, obj);
        }
    }
    
    public static LogError(string message, Object obj = null)
    {
        if (MustLog)
        {
            Debug.LogError(message, obj);
        }
    }
    
    public static LogException(Exception e, Object obj = null)
    {
        if (MustLog)
        {
            Debug.LogException(e, obj);
        }
    }
}
