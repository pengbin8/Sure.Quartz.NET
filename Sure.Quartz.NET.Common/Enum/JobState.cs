﻿namespace Sure.Quartz.NET.Common
{
    /// <summary>
    /// 任务状态
    /// <param name="BLOCKED">BLOCKED:阻塞</param>
    /// <param name="COMPLETE">COMPLETE:完成</param>
    /// <param name="ERROR">ERROR:错误</param>
    /// <param name="NONE">NONE:不存在</param>
    /// <param name="NORMAL">NORMAL:正常</param>
    /// <param name="PAUSED">PAUSED:暂停</param>
    /// <param name="DELETE">DELETE:删除</param>
    /// </summary>
    public enum JobState
    {
        BLOCKED = 4,  //阻塞
        COMPLETE = 2, // 完成
        ERROR = 3,    //错误
        NONE = -1,    //不存在
        NORMAL = 0,   //正常
        PAUSED = 1,    //暂停
        DELETE = 5 //删除
    }
}