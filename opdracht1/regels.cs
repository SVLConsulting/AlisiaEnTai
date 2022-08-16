// using System namespace
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  

namespace Wedding {

  class Rules {

    /*                                                                                                                                                                                                                                                                                                     
                            ..,........,,**,,*****,,,.                                                                                      
                        .**********,,,*******/***////////////.                                                                                
                    *///***///***,******/////////*/////////(((*                                                                             
                .*////*/////////*///*////////////(/////////((((((.                                                                          
                ,/**//////////////////////////////((((((/((//(###((((*                                                                        
            ,//*////////////////////////////(////((((((((((/(######((.                                                                      
            ,///////////////////////////(////(///((((((((/(//(((######/                                                                      
            /////////////////////////////(//((/((((((((((((//((((#(###%(                                                                     
            ////////////////////////////(/////(/((/(///////////(((((#####(                                                                    
        ,//((((///////////////(//////////(((//(//////////(((((((##(#####.                                                                   
        .(((((((//(((/(((#(((((((((/*////(((((/*///////(%%####((###(######.                                                                  
        ((#((//**,..  .,,,*/(((((/////////////*//////((###/*,..  .,,**/((#%%                                                                  
        ,//*,..     ..,......  ./((((((#(*,**/////(##(  .....,*/*.    .*//##                                                                  
        ,***,.     .,,..  ..    ./(((###*,*/(((###,   .... .,*(/,    ,/((//.                                                                 
        .*/*,,..     .,,.....     *****,****/**/(/*    .... ..//,    .,*/(((,                                                                 
        *///*,,,.      ....      *///******////((((.     ......     .,/(((##*                                                                 
        .,......,,,,....     ...*////***/(//(#(/((##(/*.      . ..,,*//(/,.,,/(                                                                
    .((/(////,...*****,**///////(/(//(((((##(######((///(//**////,...,((####                                                                
    ,//**,...*/*.. ******//////((#((/(((/(####%%%%##(((((((////...////....,,*                                                               
    /(**/////..,//*..,*/*////(/((#(((((((/(#%%%%%%%%(((((/////,..*//*../###%%%/                                                              
    **((*,.,//,..*/*  ,/*////(/#(((((((((((%%%%%%%%##(((///**,..//*...(#(,*(**(                                                              
    //,**(/..//,../*, .**////((((((((((#(((#%%#%%%%%#((///**,..**/...((..#%%#%(                                                              
    ,*/(,,((..//..*/,.,**///(((((((((((#(((%%%%%%%%%(#(/////,..///..((/,/%%#*%*                                                              
    ,,/(//,..//..,/..,******////((((((#(((%%%%#%%#(/////////..///../((,,/(*#                                                                
        **,**/*..**,.,***,,,.,,,(((((/(#(((%%%%#####,.,**/////..///..*(###*.                                                                 
            *,,..*//**  ..,////(((((((#(((#%%%%%%%(////(/*,*/(//,.,/*,.                                                                     
                /(((/((*  ..... ../((#((((#%%%%****(*,,,,,.*(/##%#                                                                          
                    ,/(((((*. ..........,(((((/...........,.(##%%%%#.                                                                          
                    ,/(((((/*./,.....................,*,/(%%%%##%%#                                                                            
                    /((((//*.///////////*****///((###,./(%%%%%##/                                                                             
                    /((((/* /((((((((#(//////(((((##* /((%%%%%(                                                                              
                    ./(((/* /((((((###////*////(((#%( /((%%%#                                                                                
                    /((/** /((((((%%%(/***//((((#%%( /((###                                                                                 
                        *//**./(((/(#%##(/***//(((#%%%( **(#/                                                                                  
                        .../(((//(#%#(/***//(/((%%%# .,,     .....*                                                                         
                            .,//((((((###(***////(#%%&# ...........,*.                                                                         
                        ...*//////(##((**////((###(. ...........,,                                                                          
                        ,...........,,...    .,*//.   ............*                                                                           
                        ............,..........        ..........,*                                                                           
                        ,............. ......    ... ............,,                                                                           
                        ........... .. .,/((((///***    ...........                                                                           
                        .....,,.....,,***((#((((///                                                                                           
                        ...,..,....,,,**(((((((#(.                                                                                            
                        ...  ...,,,,,*(((((//*,                                                                                              
                            .,,,,,,*#(/((**,.                                                                                               
                                ..,,,,*(/((**,*                                                                                                
                                ...,,***(/*,,                                                                                                  
                                ..,,**((*,                                                                                                   
    */

    static void Main(string[] args) {
        string input;
        
        Console.WriteLine("I want to play a game!");
        Console.WriteLine("There is only one cipher combination to open the safe");
        Console.WriteLine("Decipher the rules to know how to play");
        Console.WriteLine("Trying randomly will only slow you down...");

        Console.WriteLine("Whenever you are ready, press 'Y' to start ");
        input = Console.ReadLine();

        if(input = "Y" || input = "y")
        {
            safe.printer();
        }

        else
        {
            Console.WriteLine("I see you have chosen death!");
            exit();
        } 
    }
  }

    class safe {

        public static void printer()
        {
            Console.WriteLine("Welcome to the game...");

            string amountText = Decipher(,n);
            string attemptsText = Decipher(,l);
            string delayOneText = Decipher(,m);
            string delayTwoText = Decipher(,k);

            string amount = decodeString(int a, int b, string c);
            string attempts = decodeString(int a, int b, string c);
            string delayOne = decodeString(int a, int b, string c);
            string delayTwo = decodeString(int a, int b, string c);

            Console.WriteLine(amountText, amount);
            Console.WriteLine(attemptsText, attempts);
            Console.WriteLine(delayOneText, delayOne);
            Console.WriteLine(delayTwoText, delayTwo);

        }

        public static string decodeString(int f, int g, string q)
        {
            string substring = q.substring(f,g);
            return substring;
        }

        public static char cipher(char ch, int key) {  
            if (!char.IsLetter(ch)) {  

                return ch;  
            }  

            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch + key) - d) % 26) + d);  
        }  

        public static string Encipher(string input, int key) {  
            string output = string.Empty;  

            foreach(char ch in input)
            output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key) {  
            return Encipher(input, 26 - key);  
        }

        public static string (int key, string data)
        {
            Console.Write("Enter your Key");  
            int key = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("\n");  

            Console.WriteLine("Decrypted Data:");  

            string t = Decipher(cipherText, key);  
            Console.WriteLine(t);  
            Console.Write("\n");  
            
            //Console.ReadKey();

            return t;
        }
    }    
}