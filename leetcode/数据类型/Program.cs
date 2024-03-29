﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型
{
    class Program
    {

        struct IP //声明结构  
        {
            public byte b1, b2, b3, b4;
        }

        static void Main(string[] args)
        {
            // 枚举类型的元素使用的类型只能是long，int，short，byte
            //可以强制定义其他类型，如:
            //enum monthnames : byte 来进行强制性的类型转化。

            //结构类型——值类型，值类型都是struct
        }
    }
    //2.1 类类型 类 类型定义了一种数据结构，这个数据结构中包含了数据成员(如常量，字段和事件等)，函数成员(如方法，属性，索引，操作，构造函数和析构函数等)和嵌套 类型。支持继承。

    //2.2 对象类型 对象类型是其他所有类型最终的基础类型。在C#中每一种类型都直接或者间接的源于object这个类类型。

    //2.3 字符串类型 字符串类型是直接从object中继承而来的密封类。String类型的值可以写成字符串文字的形式。

    //2.4 接口类型 一个接口声明一个只有抽象成员的引用类型，接口仅仅存在方法标志，但没有执行代码。
    //当定义一个类时，如果类从接口派生，可以派生自多重接口;
    //    但是如果类从类派生，就只能从一个类派生。

    //2.5 delegate 类型 
    //2.6 array ，有相同的类型，数组元素可以是任何类型，包括数组嵌套数组，List<T>。有多个下标的数组称为多维数组。

    //int[，，] a; //int型的三维数组
    //int[][] a; //int型的数组的数组
    //int[][][] a; //int型的数组的数组的数组
}



//数据类型的学习
//Sbyte:代表有符号的8位整数，数值范围从-128 ～ 127

//　　Byte:代表无符号的8位整数，数值范围从0～255

//　　Short:代表有符号的16位整数，范围从-32768 ～ 32767

//　　ushort:代表有符号的16位整数，范围从0 到 65,535

//　　Int:代表有符号的32位整数，范围从-2147483648 ～ 2147483648

//　　uint:代表无符号的32位整数，范围从0 ～ 4294967295

//　　Long:代表有符号的64位整数，范围从-9223372036854775808 ～ 9223372036854775808

//　　Ulong:代表无符号的64位整数，范围从0 ～ 18446744073709551615。

//    char:代表无符号的16位整数，数值范围从0～65535。 Char类型的可能值对应于统一字符编码标准(Unicode)的字符集。
//char类型的常量必须被写为字符形式，如果用整数形式，则必须带有类型转换前缀。
//没有其他类型到char类型的隐式转换。即使是对于sbyte，byte和ushort这样能完全使用char类型代表其值的类型， sbyte，byte和ushort到char的隐式转换也不存在。

//C#里面的char和string是两个特殊的值类型。
//比如(char)10赋值形式有三种: char chsomechar = "A"; char chsomechar = "\x0065"; 十六进制 char chsomechar = "\u0065 ;

//枚举类型的元素
