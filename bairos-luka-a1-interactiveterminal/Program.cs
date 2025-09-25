//All text has been formatted to fit the default window size that appears when I run the program on this computer, which is 120 characters across.
//There are many \n (next lines) present in the text for that purpose. It drives me crazy when words get cut off, so I had to do this for myself.

//Variables
using System;

bool alienEscaped = false;
bool alienSaved = false;




//Opening Dialogue
Console.WriteLine("You are a special agent. Last week a mysterious mansion property anomalously appeared out of nowhere, and you have been\n" +
                  "sent to investigate. The only thing to identify it by is the lone mailbox at the property's entrance, labelled\n" +
                  "\"Sutherland\". Electronic devices all seem to explode when brought into the mansion's proximity, so you have been\n" +
                  "equipped with a pistol, a combat knife, some first aid supplies, and a notebook to write your findings in.\n");
Console.WriteLine("What is your name, agent?");
string playerName = Console.ReadLine(); //Input player's name


//Player enters the mansion, narrator describes surroundings
Console.WriteLine($"{playerName} enters the mansion, only to find most of the pathways inconveniently blocked off by large piles of scrap\n" +
                  "metal. It looks like there are only two ways to go, a door labelled \"DO NOT ENTER\" in bright red writing, and an\n" +
                  "inconspicuous door with no label.\n");
Console.WriteLine("After recording your surroundings in your notebook, you decide where to go.");
Console.WriteLine("1) The door labelled \"DO NOT ENTER\"."); //Choice leads to game over
Console.WriteLine("2) The inconspicuous door."); //Choice is correct path
string location = Console.ReadLine();

//Respective paths
//Choice - The player falls into the void eternally
if (location == "1")
{
    Console.WriteLine("You enter the door labelled \"DO NOT ENTER\", but as soon as you step foot through it, you fall into a hole!\n" +
                      "Unfortunately, it seems like you are falling forever, and only darkness surrounds you.\n");
    Console.WriteLine("GAME OVER!");
}

//Choice - The player is attacked from behind
else if (location == "2")
    {
    Console.WriteLine("You enter the inconspicuous door. Inside, you find a fancy dining room, but all the furniture is upside-down, as if\n" +
                      "glued to the ceiling. The chandelier is attached to the floor too, how peculiar. You begin writing this down in your\n" +
                      "notebook,when suddenly something grabs you from behind! Its grip is strong, if you cannot escape, this might be the end!\n");
    Console.WriteLine("Quick, do something!");
    Console.WriteLine("1) I'll use my gun!"); //Choice leads to game over
    Console.WriteLine("2) I'll use my knife!"); //Choice progresses game
    string attack = Console.ReadLine();

    //Choice - The player tries to use their pistol, but is unsuccessful
    if (attack == "1")
    {
        Console.WriteLine("You reach for your pistol, but the way the attacker is holding you makes it difficult to use. You try to fire at it, but\n" +
                          "you cannot manage to turn the safety off! The gun startles your adversary and it breaks your spine in half!\n" +
                          "You might need some painkillers for that...\n");
        Console.WriteLine("GAME OVER!");
    }

    //Choice - The player tries to use their knife, and stabs an alien
    else if (attack == "2")
    {
        alienEscaped = true;
        Console.WriteLine("You reach for your knife, but the way the attacker is holding you makes it difficult to use. You manage to stab your\n" +
                          "attacker, and it screams as it lets go of you. You turn around to see what appears to be a short green alien, like a\n" +
                          "stereotypical martian. It whimpers curled up on the floor in pain.\n");
        Console.WriteLine("Now what?");
        Console.WriteLine("1) I don't care about this alien, it tried to kill me!"); //Wrong choice, will lead to game over
        Console.WriteLine("2) I'll use my medical supplies to help the alien."); //Correct choice
        string help = Console.ReadLine();

        //Choice - The player ignores the crying alien they stabbed
        if (help == "1")
        {
            Console.WriteLine("The alien abruptly gets up and runs out of the room. You follow him, and he opens a secret doorway to the basement!\n");
        }

        //Choice - The player heals the alien they stabbed with bandages
        else if (help == "2")
        {
            alienSaved = true;
            Console.WriteLine("Feeling remorseful, you pull out your first aid supplies and bandage up the little alien. The alien bows before you, as\n" +
                              "if thankful for your help (even though you stabbed him). He then leads you to a secret passage where you can enter\n" +
                              "the basement!\n");
        }

    }

    }
