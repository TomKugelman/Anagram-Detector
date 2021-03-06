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


## Improvements
If I was going to continue developing this application, I would find a way to link it to a word-bank to allow for a separate function that FINDS an anagram for a given word. It is possible I will revisit this app in the future. However, as it stands I am happy with the state of it as-is.
