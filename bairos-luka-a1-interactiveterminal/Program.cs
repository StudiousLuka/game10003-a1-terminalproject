//All text has been formatted to fit the default window size that appears when I run the program on this computer, which is 120 characters across.
//There are many \n (next lines) present in the text for that purpose. It drives me crazy when words get cut off, so I had to do this for myself.

//Variables
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
                  "metal. It looks like there are only three ways to go, a door labelled \"DO NOT ENTER\" in bright red writing, an\n" +
                  "inconspicuous door with no label, or up the long stairs in front of you, where it appears to be extremely dark.\n");
Console.WriteLine("After recording your surroundings in your notebook, you decide where to go.");
Console.WriteLine("1) Door labelled \"DO NOT ENTER\""); //Choice leads to game over
Console.WriteLine("2) Inconspicuous door"); //Choice is correct path
Console.WriteLine("3) Upstairs"); //Choice above should be done first
string location = Console.ReadLine();

//Respective paths
//Choice 1 - The player falls into the void eternally
if (location == "1")
    {
    Console.WriteLine("You enter the door labelled \"DO NOT ENTER\", but as soon as you step foot through it, you fall into a hole!\n" +
                      "Unfortunately, it seems like you are falling forever, and only darkness surrounds you.\n");
    Console.WriteLine("GAME OVER!");
    }

//Choice 2 - The player is attacked from behind
else if (location == "2")
    {
    Console.WriteLine("You enter the inconspicuous door. Inside, you find a fancy dining room, but all the furniture is upside-down, as if\n" +
                      "glued to the ceiling. The chandelier is attached to the floor too, how peculiar. You begin writing this down in your\n" +
                      "notebook,when suddenly something grabs you from behind! Its grip is strong, if you cannot escape, this might be the end!\n");
    Console.WriteLine("Quick, do something!");
    Console.WriteLine("1) I'll use my gun!"); //Choice leads to game over
    Console.WriteLine("2) I'll use my knife!"); //Choice progresses game
    string attack = Console.ReadLine();

    if (attack == "1")
    {
        Console.WriteLine("You reach for your pistol, but the way the attacker is holding you makes it difficult to use. You try to fire at it, but\n" +
                          "you cannot manage to turn the safety off! The gun startles your adversary and it breaks your spine in half!\n" +
                          "You might need some painkillers for that...\n");
        Console.WriteLine("GAME OVER!");
    }

    }