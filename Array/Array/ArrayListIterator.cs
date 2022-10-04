﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayListIterator
{

    private ArrayLList arrayList;
    private int currentItem;

    public ArrayListIterator(ArrayLList arrayList)
    {
        this.arrayList = arrayList;
    }


    public bool hasNext()
    {
        return currentItem < arrayList.getSize();
    }

    public String next()
    {
        String data = arrayList.getAt(currentItem);
        currentItem++;
        return data;
    }
}
