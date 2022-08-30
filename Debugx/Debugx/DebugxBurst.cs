﻿#define DEBUG_X

using System.Diagnostics;
using Unity.Burst;

/// <summary>
/// 用于Burst多线程代码中的Debug工具类
/// </summary>
public class DebugxBurst
{
    //在DOTS的Burst中的限制问题：
    //一些受到限制的代码，一些功能不支持，在编译时会直接报红。
    //在DOTS的Burst多线程中，不能使用任何引用类型，string只能直接传递，使用String.Format时不能传入string类型。
    //UnityEngine.Debug.unityLogger()不能使用。只能直接使用UnityEngine.Debug.Log等方法，这类方法应该是由引擎开封这做过特殊处理，从而能够直接传参object类型。
    //使用外部的值时，值必须是只读的
    //in ref out 都不支持
    //所以使用[BurstDiscard]特性用于在多线程时直接排除此方法，添加此宏能够使一些被限制的代码在编译时不报错，但必须在Entities.ForEach().WithoutBurst().Run()才能工作;,因为所有[BurstDiscard]特性的方法在多线程中都不工作。

    //使用LogInBurst()方法可以直接在Burst多线程中打印（但不支持任何成员配置信息），效果和UnityEngine.Debug.Log()是一样的，这种方法应该坐过处理，所以直接传参object也不会报错



    /// <summary>
    /// 普通打印Log
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void LogNom(object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.LogNom(message, showTime, showNetTag);
    }

    /// <summary>
    /// 普通打印LogWarning
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void LogNomWarning(object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.LogNomWarning(message, showTime, showNetTag);
    }

    /// <summary>
    /// 普通打印LogError
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void LogNomError(object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.LogNomError(message, showTime, showNetTag);
    }

    /// <summary>
    /// 高级打印Log
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void LogMst(object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.LogMst(message, showTime, showNetTag);
    }

    /// <summary>
    /// 高级打印LogWarning
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void LogMstWarning(object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.LogMstWarning(message, showTime, showNetTag);
    }

    /// <summary>
    /// 高级打印LogError
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void LogMstError(object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.LogMstError(message, showTime, showNetTag);
    }

    /// <summary>
    /// 成员打印Log
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="key">DebugxMemberInfo中配置的key</param>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void Log(int key, object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.Log(key, message, showTime, showNetTag);
    }

    /// <summary>
    /// 成员打印LogWarning
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="key">DebugxMemberInfo中配置的key</param>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void LogWarning(int key, object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.LogWarning(key, message, showTime, showNetTag);
    }

    /// <summary>
    /// 成员打印LogError
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// </summary>
    /// <param name="key">DebugxMemberInfo中配置的key</param>
    /// <param name="message">打印内容</param>
    /// <param name="showTime">显示时间</param>
    /// <param name="showNetTag">显示网络标记，Server或者Client。此功能依赖项目，需要项目通过SetServerCheck方法来设置</param>
    [Conditional("DEBUG_X"), BurstDiscard]
    public static void LogError(int key, object message, bool showTime = false, bool showNetTag = true)
    {
        Debugx.LogError(key, message, showTime, showNetTag);
    }

    /// <summary>
    /// 在Burst多线程中打印Log
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// 不支持调试成员配置信息功能。没有运行时开关，因为Burst多线程内使用的bool值必须是只读的。
    /// </summary>
    /// <param name="message">打印内容</param>
    [Conditional("DEBUG_X")]
    public static void LogInBurst(string message)
    {
        UnityEngine.Debug.Log(message);
    }

    /// <summary>
    /// 在Burst多线程中打印LogWarning
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// 不支持调试成员配置信息功能。没有运行时开关，因为Burst多线程内使用的bool值必须是只读的。
    /// </summary>
    /// <param name="message">打印内容</param>
    [Conditional("DEBUG_X")]
    public static void LogInBurstWarning(string message)
    {
        UnityEngine.Debug.LogWarning(message);
    }

    /// <summary>
    /// 在Burst多线程中打印LogInBurstError
    /// 必须在Entities.ForEach().WithoutBurst().Run()时才能工作
    /// 不支持调试成员配置信息功能。没有运行时开关，因为Burst多线程内使用的bool值必须是只读的。
    /// </summary>
    /// <param name="message">打印内容</param>
    [Conditional("DEBUG_X")]
    public static void LogInBurstError(string message)
    {
        UnityEngine.Debug.LogError(message);
    }
}