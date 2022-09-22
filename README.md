1.	Given a collection of integers – let’s say 200 000 integers, ALL ranging between 1 and 50 – what is the simplest / fastest way to get the corresponding list of Roman Numeral equivalent strings assuming we *already* have a ConvertIntToRoman(int i) function that returns a string.
EG: 
Input collection: 1,3,4,6,1,3,10...N
Output collection: I,III,IV,VI,I,III,X...N

2.	Assume while solving problem #1 we find out that it is actually computationally expensive (relatively speaking) to convert all integers to Roman, and after speaking to users our requirement gets refined to only providing the top 5 roman values by count of occurrence in the source list. Please can you show how you would revise your code from #1 to meet this new requirement.
EG: Input collection as per #1
Output collection: I,III,X,V,VII

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
