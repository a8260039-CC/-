using System;
using UnityEngine;

namespace 环境系统命名空间
{
    public class 时间系统
    {
        public enum 季节 { 春季 = 3, 夏季 = 6, 秋季 = 9, 冬季 = 12 }
        public static string 历 = "历";
        public static int 年 = 1;
        public static int 月 = 1;
        public static int 日 = 1;
        public static int 时 = 8;
        public static int 分 = 0;
        public static int 日出;
        public static int 日落;
        public static float 游戏分钟数 = 0f;
        public static double 当前温度; // 添加一个变量来表示当前温度
        public static double 当前湿度; // 添加一个变量来表示当前湿度
        public static int 上次天气变化时间;
        public enum 时间段
        {
            清晨 = 6,
            上午 = 8,
            中午 = 12,
            下午 = 14,
            傍晚 = 18,
            夜晚 = 20,
            深夜 = 24
        }
    }

    public class 天气系统
    {
        // 定义一个枚举类型来表示不同的天气类型
        public enum 天气类型
        {
            晴天, 
            多云, 
            雨天, 
            雪天, 
            雾天,
            夜空,
            龙卷风, 
            闪电 
        }
        public static 天气类型 当前天气 = 天气类型.晴天;
        //定义温度和湿度的变量
        public static float 温度;
        public static float 湿度; 

    }
}
                        






