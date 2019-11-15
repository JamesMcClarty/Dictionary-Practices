using System;
using System.Collections.Generic;

namespace dictionarypractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Dumb", "How James often feels when he's relearning something.");
            wordsAndDefinitions.Add("Tired", "How James often feels when he's working in both NSS AND Orange Crate.");
            wordsAndDefinitions.Add("Thankful", "How James often feels when he's lucky to even be in NSS.");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine($"{wordsAndDefinitions["Awesome"]} and {wordsAndDefinitions["Tired"]}");

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            //_________________________________________________________________

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#");

            // Add Dictionary to your `dictionaryOfWords` list

            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list

            Dictionary<string, string> screwedWord = new Dictionary<string, string>()
            { { "word", "screwed" }, { "definition", "slang word for messing up something royally" }, { "part of speech", "verb" }, { "example sentence", "I'm screw if I don't learn this." }
            };

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> meaning in word)
                {
                    Console.WriteLine($"{meaning.Key}: {meaning.Value}");
                }
            }

            //__________________________________________________________________

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                Console.WriteLine($"{idiom.Key}: {string.Join(" ", idiom.Value)}");
            }

            //Family Dictionary--------------------------------------------------------------------

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>()
            { { "name", "Megan" }, { "age", "30" }
            });

             myFamily.Add("mother", new Dictionary<string, string>()
            { { "name", "Libbie" }, { "age", "56" }
            });

             myFamily.Add("father", new Dictionary<string, string>()
            { { "name", "Jim" }, { "age", "68" }
            });

             myFamily.Add("cat", new Dictionary<string, string>()
            { { "name", "Tallulah" }, { "age", "2" }
            });

            foreach(KeyValuePair<string, Dictionary<string, string>> member in myFamily){
               Console.WriteLine($"{member.Value["name"]} is my {member.Key} and her age is {member.Value["age"]}");
            }
        }
    }
}