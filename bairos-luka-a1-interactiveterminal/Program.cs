//All text has been formatted to fit the default window size that appears when I run the program on this computer, which is 120 characters across.
//There are many \n (next lines) present in the text for that purpose. It drives me crazy when words get cut off, so I had to do this for myself.

using System;

//Variables

bool alienSaved = false; //Whether or not the alien was saved
int alienRequirement = 30; //How many aliens the player has to count to progress
bool honest = false; //Whether or not the player confessed to their crime


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
        Console.WriteLine("You reach for your knife, but the way the attacker is holding you makes it difficult to use. You manage to stab your\n" +
                          "attacker, and it screams as it lets go of you. You turn around to see what appears to be a short green alien, like a\n" +
                          "stereotypical martian. It whimpers curled up on the floor in pain.\n");
        Console.WriteLine("Now what?");
        Console.WriteLine("1) I don't care about this alien, it tried to kill me!"); //Wrong choice, will lead to bad ending
        Console.WriteLine("2) I'll use my medical supplies to help the alien."); //Correct choice
        string help = Console.ReadLine();

        //Choice - The player ignores the crying alien they stabbed
        if (help == "1")
        {
            Console.WriteLine("The alien abruptly gets up and runs out of the room. You follow him, and he opens a secret doorway to the basement!\n");
            //Final Area begins, bad route
            Console.WriteLine("For some reason, the entire basement is literally a forest. Aside from the pitch black \"sky\", the basement is lush with\n" +
                              "dirt, grass, large trees, and other foliage. You lost track of the alien, but dozens of tiny aliens start running out of\n" +
                              "the bushes. For some reason, you feel compelled to count them.\n");
            Console.WriteLine("How many aliens do you count?");
            string alienCountString = Console.ReadLine(); //The player enters whatever number they want. If it's above the requirement, they continue.
            int alienCount = int.Parse(alienCountString); //If it's below the requirement, they fail. "Dozens" in the dialogue above is a hint.

            if (alienCount < alienRequirement)
            {
                Console.WriteLine($"You count exactly {alienCount} tiny aliens, all running the same direction. You try to follow them, but they're\n" +
                                  "too fast, and you lose track of them. You have no idea where you came from, you're lost in the dark forest forever!\n");
                Console.WriteLine("GAME OVER!");
            }
            else if (alienCount >= alienRequirement)
            {
                //King alien speaks to you, bad ending happens
                Console.WriteLine($"You count exactly {alienCount} tiny aliens, all running the same direction. They run really fast, but there are so\n" +
                    "many of them, it is not hard to keep up.\n");
                Console.WriteLine("You find all the tiny aliens, and the normal-sized alien from before, standing in a clearing of what looks like\n" +
                              "sunlight. In front of them is a humongous alien, wearing a purple robe and a small golden crown.\n" +
                              "\"I am King Martian!\" the large alien booms. \"I have knowledge of all languages across the galaxy, even your\n" +
                              "simplistic Earthling ones! My son, Prince Martian told me you stabbed him! I will have you banished from this place!\"");
                Console.WriteLine("King Martian does not sound happy. He does a weird motion with his hands, and then in the blink of an eye, you are\n" +
                              "standing outside the mansion property, next to the mailbox, but the entire mansion has vanished. All that remains is\n" +
                              "the mailbox and a flat patch of dirt where the mansion used to be. Looks like we'll never know what the aliens were\n" +
                              "doing in there.\n");
                Console.WriteLine("YOU WON? BAD ENDING ACHIEVED.");
            }
        }

        //Choice - The player heals the alien they stabbed with bandages
        else if (help == "2")
        {
            alienSaved = true;
            Console.WriteLine("Feeling remorseful, you pull out your first aid supplies and bandage up the little alien. The alien bows before you, as\n" +
                              "if thankful for your help (even though you stabbed him). He then leads you to a secret passage where you can enter\n" +
                              "the basement!\n");
            //Final Area begins, good route
            Console.WriteLine("For some reason, the entire basement is literally a forest. Aside from the pitch black \"sky\", the basement is lush with\n" +
                              "dirt, grass, large trees, and other foliage. You lost track of the alien, but dozens of tiny aliens start running out of\n" +
                              "the bushes. For some reason, you feel compelled to count them.\n");
            Console.WriteLine("How many aliens do you count?");
            string alienCountString = Console.ReadLine(); //The player enters whatever number they want. If it's above the requirement, they continue.
            int alienCount = int.Parse(alienCountString); //If it's below the requirement, they fail. "Dozens" in the dialogue above is a hint.

            if (alienCount < alienRequirement)
            {
                Console.WriteLine($"You count exactly {alienCount} tiny aliens, all running the same direction. You try to follow them, but they're\n" +
                                  "too fast, and you lose track of them. You have no idea where you came from, you're lost in the dark forest forever!\n");
                Console.WriteLine("GAME OVER!");
            }
            else if (alienCount >= alienRequirement)
            {
                //King alien speaks to you, good ending happens
                Console.WriteLine($"You count exactly {alienCount} tiny aliens, all running the same direction. They run really fast, but there are so\n" +
                    "many of them, it is not hard to keep up.\n");
                Console.WriteLine("You find all the tiny aliens, and the normal-sized alien from before, standing in a clearing of what looks like\n" +
                              "sunlight. In front of them is a humongous alien, wearing a purple robe and a small golden crown.\n" +
                              "\"I am King Martian!\" the large alien booms. \"I have knowledge of all languages across the galaxy, even your\n" +
                              "simplistic Earthling ones! My son, Prince Martian told me you saved his life! As a token of our gratitude, I shall\n" +
                              "grant you knowledge of all the secrets of the galaxy. What is your name?\"\n");
                Console.WriteLine("All the secrets of the galaxy sounds like a lot of knowledge to handle. What will you do?");
                Console.WriteLine("1) Tell him you stabbed his son."); //Choice makes you "honest". Nothing other than a bonus at the end
                Console.WriteLine("2) Accept alien knowledge."); //Choice makes you "dishonest"
                string honestString = Console.ReadLine();

                //"Dishonest" scenario
                if (honestString == "2")
                {
                    Console.WriteLine($"You say, \"I'm {playerName}. I would be happy to know the secrets of the galaxy.\"\n" +
                                      $"\"Good to meet you, {playerName}! Now, recieve my vast knowledge!\" the king responds.");
                    Console.WriteLine("With the snap of his fingers, you instantly gain knowledge of all the galaxy's secrets. It surprisingly did not\n" +
                                      "make your head explode. The aliens say their farewells, and you return to base with newfound information that\n" +
                                      "will help humanity thrive for trillions of years!\n");
                    Console.WriteLine("YOU WON! GOOD ENDING ACHIEVED.");
                    if (honest == false)
                        Console.WriteLine("But you were not honest.");
                    else if (honest == true)
                        Console.WriteLine($"You were honest! Good job {playerName}!");
                }

                //"Honest" scenario
                else if (honestString == "1")
                {
                    honest = true;
                    Console.WriteLine($"In an attempt to stop the king, you tell him that you stabbed his son." +
                                      $"\"Yeah, I know, but you saved him after anyway. I'm obligated to give you this knowledge as the king.\"");
                    Console.WriteLine("Apparently, according to these aliens, stabbing someone doesn't matter if you helped them afterwards.\n" +
                                      "With the snap of his fingers, you instantly gain knowledge of all the galaxy's secrets. It surprisingly did not\n" +
                                      "make your head explode. The aliens say their farewells, and you return to base with newfound information that\n" +
                                      "will help humanity thrive for trillions of years!\n");
                    Console.WriteLine("YOU WON! GOOD ENDING ACHIEVED.");
                    if (honest == false)
                        Console.WriteLine("But you were not honest.");
                    else if (honest == true)
                        Console.WriteLine($"You were honest! Good job! {playerName}!");
                }
            }
        }

    }
}
