using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace CS133PROJECT2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<myClass> myObjectList = new List<myClass>();

            myClass myObject1 = new myClass();
            myObject1.user = "User Name";
            myObject1.views = "Total Views";
            myObject1.likes = "Likes";
            myObject1.list = "A list of Comments";

            myObjectList.Add(myObject1);
            

            List<myClass> newList =
            myObjectList.Where(myClass => myClass.views == "User Name").ToList();

            foreach(var item in newList)
            {
                Console.WriteLine("My list" + item.user
                                  + "My views" + item.views + "My likes" + item.likes + "My list" + item.list);
            }


        }
    }
}

public class myClass
{
    public string user { get; set; }
    public string views { get; set; }
    public string likes { get; set; }
    public string list { get; set; }
}