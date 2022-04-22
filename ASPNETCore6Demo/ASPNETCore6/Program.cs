//using System;

//namespace ASPNETCore6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

//在ConsoleApp下可將 using namespace class 省略，在combine的過程中編譯器自動補上using namespace class


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, "+args[0]+"!");


/*
 <Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
      //目標框架
    <ImplicitUsings>enable</ImplicitUsings>
      //隱含的Using 在Microsoft.NET.Sdk下
      //******補充global using的用法
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
 */