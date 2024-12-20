﻿namespace Multi2;
using System;
using System.Collections;

public class Multi2
{
// C# program to illustrate how to
// implement multiple class inheritance
// using interfaces



    // Interface 1
    public interface GFG1 {
        void languages();
    }
     
    // Parent class 1
    public class Geeks1 : GFG1 {
     
        // Providing the implementation
        // of languages() method
        public void languages()
        {
     
            // Creating ArrayList
            ArrayList My_list = new ArrayList();
     
            // Adding elements in the
            // My_list ArrayList
            My_list.Add("C");
            My_list.Add("C++");
            My_list.Add("C#");
            My_list.Add("Java");
     
            Console.WriteLine("Languages provided by GeeksforGeeks:");
            foreach(var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
     
    // Interface 2
    interface GFG2 {
        void courses();
    }
     
    // Parent class 2
    class Geeks2 : GFG2 {
     
        // Providing the implementation
        // of courses() method
        public void courses()
        {
     
            // Creating ArrayList
            ArrayList My_list = new ArrayList();
     
            // Adding elements in the
            // My_list ArrayList
            My_list.Add("System Design");
            My_list.Add("Fork Python");
            My_list.Add("Geeks Classes DSA");
            My_list.Add("Fork Java");
     
            Console.WriteLine("\nCourses provided by GeeksforGeeks:");
            foreach(var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
     
    // Child class
    class GeeksforGeeks : GFG1, GFG2 {
     
        // Creating objects of Geeks1 and Geeks2 class
        Geeks1 obj1 = new Geeks1();
        Geeks2 obj2 = new Geeks2();
     
        public void languages()
        {
            obj1.languages();
        }
     
        public void courses()
        {
            obj2.courses();
        }
    }
     
    // Driver Class
    public class GFG {
     
        // Main method
        public static void Main_Multi2()
        {
     
            // Creating object of GeeksforGeeks class
            GeeksforGeeks obj = new GeeksforGeeks();
            obj.languages();
            obj.courses();
            
        }
    }    
}