using UnityEngine.UI;
using UnityEngine;
using 环境系统命名空间;
using static 环境系统命名空间.天气系统;
using static 环境系统命名空间.时间系统;
using System.Collections;

public class 温度与湿度逻辑 : MonoBehaviour
{
    //定义显示文本的组件
    Text 温度文本;
    Text 湿度文本;
    //在Start方法中获取显示文本的组件
    void Start()
    {
        //根据你的游戏对象和组件名称进行修改
        温度文本 = GameObject.Find("温度文本").GetComponent<Text>();
        湿度文本 = GameObject.Find("湿度文本").GetComponent<Text>();
    }

    //在Update方法中计算和显示温度和湿度
    void Update()
    {
        //根据你的游戏逻辑获取当前时间和季节
        //假设你已经定义了变量 时间 和 季节

        //根据时间和季节计算温度和湿度
        当前温度 = 计算温度(时间, 季节); //计算温度的方法，返回一个float值
        当前湿度 = 计算湿度(时间, 季节); //计算湿度的方法，返回一个float值

        //将温度和湿度的值转换为字符串，并显示在文本组件上
        温度文本.text = "温度: " + 温度.ToString("F1") + "℃"; //保留一位小数
        湿度文本.text = "湿度: " + 湿度.ToString("F0") + "%"; //保留整数
    }
    //计算温度的方法，输入参数为当前时间和季节，输出参数为当前温度
    float 计算温度(float 时间, int 季节)
    {
        float 温度; //温度变量

        //根据不同的季节设置不同的基准温度和波动范围
        switch (季节)
        {
            case 0: //春季
                温度 = 15f; //基准温度为15摄氏度
                温度 += 5f * Mathf.Sin(2f * Mathf.PI * 时间 / 24f); //根据正弦函数模拟一天中温度的波动，幅度为5摄氏
            case 1: //夏季
                温度 = 25f; //基准温度为25摄氏温度 += 10f * Mathf.Sin(2f * Mathf.PI * 时间 / 24f); //根据正弦函数模拟一天中温度的波动，幅度为10摄氏度
                break;
            case 2: //秋季
                温度 = 15f; //基准温度为15摄氏度
                温度 += 5f * Mathf.Sin(2f * Mathf.PI * 时间 / 24f); //根据正弦函数模拟一天中温度的波动，幅度为5摄氏度
                break;
            case 3: //冬季
                温度 = 5f; //基准温度为5摄氏度
                温度 += 5f * Mathf.Sin(2f * Mathf.PI * 时间 / 24f); //根据正弦函数模拟一天中温度的波动，幅度为5摄氏度
                break;
            default: //其他情况
                温度 = 0f; //默认温度为0摄氏度
                break;
        }

        return 温度; //返回温度值
    }
    //计算湿度的方法，输入参数为当前时间和季节，输出参数为当前湿度
    float 计算湿度(float 时间, int 季节)
    {
        float 湿度; //湿度变量

        //根据不同的季节设置不同的基准湿度和波动范围
        switch (季节)
        {
            case 0: //春季
                湿度 = 50f; //基准湿度为50%
                湿度 += 20f * Mathf.Cos(2f * Mathf.PI * 时间 / 24f); //根据余弦函数模拟一天中湿度的波动，幅度为20%
                break;
            case 1: //夏季
                湿度 = 70f; //基准湿度为70%
                湿度 += 20f * Mathf.Cos(2f * Mathf.PI * 时间 / 24f); //根据余弦函数模拟一天中湿度的波动，幅度为20%
                break;
            case 2: //秋季
                湿度 = 50f; //基准湿度为50%
                湿度 += 20f * Mathf.Cos(2f * Mathf.PI * 时间 / 24f); //根据余弦函数模拟一天中湿度的波动，幅度为20%
                break;
            case 3: //冬季
                湿度 = 30f; //基准湿度为30%
                湿度 += 20f * Mathf.Cos(2f * Mathf.PI * 时间 / 24f); //根据余弦函数模拟一天中湿度的波动，幅度为20%
                break;
            default: //其他情况
                湿度 = 0f; //默认湿度为0%
                break;
        }

        return 湿度; //返回湿度值
    }
}
