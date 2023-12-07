using System;
using System.Collections.Generic;

public abstract class NamePart
{
    protected List<char> elements;

    public char GetRandomElement()
    {
        Random random = new Random();
        int index = random.Next(elements.Count);
        return elements[index];
    }
}
