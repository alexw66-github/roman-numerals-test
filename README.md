1.	Given a collection of integers – let’s say 200 000 integers, ALL ranging between 1 and 50 – what is the simplest / fastest way to get the corresponding list of Roman Numeral equivalent strings assuming we *already* have a ConvertIntToRoman(int i) function that returns a string.
EG: 
Input collection: 1,3,4,6,1,3,10...N
Output collection: I,III,IV,VI,I,III,X...N

> **Note**
> For this challenge I'll create a static class that converts a given number into a roman numeral. Given that performance is mentioned and we have a fixed range, it makes sense to preload the values into a dictionary (rather than convert them on the fly). As it's an in-memory operation that should make it as fast as possible.

2.	Assume while solving problem #1 we find out that it is actually computationally expensive (relatively speaking) to convert all integers to Roman, and after speaking to users our requirement gets refined to only providing the top 5 roman values by count of occurrence in the source list. Please can you show how you would revise your code from #1 to meet this new requirement.
EG: Input collection as per #1
Output collection: I,III,X,V,VII

> **Note**
> This can be achieved with Linq, by selecting the top `n` values then just passing it through to the same conversion method as before. The challenge specifies `5`, so I'll set that as the default, but also allow the count to be optionally specified as well.

3.	Bonus question – how would you provide a full summary of the collection from step #1 showing int value, roman equivalent & count.
EG: Input collection as per #1
Output collection: 
1 - I   - 21120
2 - II  - 8245
3 - III - 21201
4 - IV  - 11994
5 - V   - 20900
6 - VI  - 15012
.
50 - L -  10015

Rules for participation:
1.	No collaboration
2.	No Google / Bing / Stackoverflow / etc.
3.	Pseudo code is acceptable
