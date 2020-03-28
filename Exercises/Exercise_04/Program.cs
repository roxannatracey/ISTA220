#region using directives

using Exercise_04;
using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Exercise_04
{
    public class Farm
    {
        public Farm(string name, string breed, string sound, string limbs, string coat, string product)

        {
            Console.WriteLine($"My name is {name} and I am a {breed}");
            Console.WriteLine($"I go {sound}");
            Console.WriteLine($"I have {limbs} legs and {coat} ");
            Console.WriteLine($"Sometimes I help make {product}" + "\r\n");

        }
    }
}
class program
{
    static void Main() // main method 
    {
        Farm Animal1 = new Farm("Solaris", "Owl", "hoot", "2", "feathers", "barn pets");
        Farm Animal2 = new Farm("Snowwhite", "Owl", "hoot", "2", "feathers", "dreamcatchers");
        Farm Animal3 = new Farm("Corry", "Owl", "hoot", "2", "feathers", "barn pets");
        Farm Animal4 = new Farm("CoCo", "Owl", "hoot", "2", "feathers", "dreamcatchers");
        // declare new animal

        Farm Animal5 = new Farm("Atlas", "Pig", "oink", "4", "skin", "Porkchops");
        Farm Animal6 = new Farm("Porky", "Pig", "oink", "4", "skin", "bacon");
        Farm Animal7 = new Farm("MS.Piggy", "Pig", "oink", "4", "skin", "pork chops");
        Farm Animal8 = new Farm("Wilbur", "Pig", "oink", "4", "skin", "bacon");

        // declare new animal 
        Farm Animal9 = new Farm("Ophelia", "goose", "honk", "2", "feathers", "blankets");
        Farm Animal10 = new Farm("Grace", "goose", "honk", "2", "feathers", "comforters");
        Farm Animal11 = new Farm("Shannon", "goose", "honk", "2", "feathers", "jackets");
        Farm Animal12 = new Farm("Kyle", "goose", "honk", "2", "feathers", "comforters");

        //declare new animal 
        Farm Animal13 = new Farm("Venus", "Horse", "neigh", "4", "hair", "jackets");
        Farm Animal14 = new Farm("Rose", "Horse", "neigh", "4", "hair", "leather");
        Farm Animal15= new Farm("Shannon", "Horse", "neigh", "4", "hair", "belts");
        Farm Animal16 = new Farm("Cody", "Horse", "neigh", "4", "hair", "leather");

        // declare new animal 
        Farm Animal17 = new Farm("Saturn", "calf", "moo", "4", "short hair", "veal");
        Farm Animal18 = new Farm("Ethan", "calf", "moo", "4", "short hair", "veal");
        Farm Animal19 = new Farm("Autumn", "calf", "moo", "4", "short hair", "veal");
        Farm Animal20 = new Farm("Rebecca", "calf", "moo", "4", "short hair", "veal");


    }

}

