# Anagram Detector
> Author: Thomas Kugelman

> Date Created: February, 2020

> Date Revised: June, 2020

> Language C# Console Application

## Description
A console application that takes two strings as inputs from the user and returns whether they are anagrams or not

## Functions
- Input Validation: No special characters or numbers accepted, will prompt an "Invalid Input!" response when unaccepted characters are used
- Anagram Checker: Initially compares word lengths, if they are equal the function attempts to find matches for each letter and removes them from each string. If zero letters are left in both strings we have found an anagram. If either string has any letters left when the other is completely empty they are not anagrams

## Output
Either the two user entered words are anagrams or they are not
- Success output: "Success! __wordOne__ and __wordTwo__ are anagrams!"
- Failure output: "__wordOne__ and __wordTwo__ are not anagrams."

## Notes
This was originally an assignment for a Data Structures and Algorithms class. I decided to add an ESCAPE option when the [escape] key is pressed because using key inputs was new to me at the time and I found this to be an easy assignment.

## Improvements
If I was going to continue developing this application I would find a way to link it to a word-bank to allow for a separate function that FINDS an anagram for a given word. This is clearly outside the scope of this project and I would prefer to move on to more interesting projects, but it is possible I will revisit this app in the future. However, as it stands I am happy with the state of it as-is.
