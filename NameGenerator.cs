using System;

public class NameGenerator
{
    private VowelManager vowelManager;
    private ConsonantManager consonantManager;

    public NameGenerator()
    {
        vowelManager = new VowelManager();
        consonantManager = new ConsonantManager();
    }

    public string GenerateName()
    {
        Random random = new Random();
        int nameLength = random.Next(5, 11); // Name length between 5 and 10 characters

        System.Text.StringBuilder name = new System.Text.StringBuilder();

        // First letter is a consonant
        name.Append(char.ToUpper(consonantManager.GetRandomElement()));

        // Alternate between vowels and consonants
        for (int i = 1; i < nameLength; i++)
        {
            if (i % 2 == 0)
            {
                name.Append(vowelManager.GetRandomElement());
            }
            else
            {
                name.Append(consonantManager.GetRandomElement());
            }
        }

        return name.ToString();
    }
}
