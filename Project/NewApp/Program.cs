﻿using System.Collections;

using NewApp.Models;
ArrayList psList = new ArrayList();
for(int i = 0; i < 2 ; i++)
{
    

    Person ps = new Person();
    ps.Nhap();
    psList.Add(ps);
}
foreach(Person p in psList)    {
    System.Console.WriteLine(p.FullName + " - " + p.Address);}