# Gilded Rose Refactoring Kata

Hi and welcome to team Gilded Rose. As you know, we are a small inn with a 
prime location in a prominent city ran by a friendly innkeeper named 
Allison. We also buy and sell only the finest goods. Unfortunately, our 
goods are constantly degrading in price as they approach their expiration 
date. Your task is to create the system V2 so that we can begin selling different category of items.
 
First an introduction to our system Version 1.0:

* All items have an Expiration value which denotes the number of days we have to sell the item
* All items have a Price value which denotes how valuable the item is
* At the end of each day our system lowers by 1 both values for every item 

Pretty simple, right? Well this is where it gets interesting (Version 2.0): 

* Once the expiration date has passed (value is less than zero), Price degrades twice as fast.
* The Price of an item is never negative.
* "Aged Brie" actually increases in Price the older it gets (the price never degrades).
* The Price of an item is never more than 50.
* "Sulfuras", being a legendary item, never has to be sold or decreases in Price. 
* "Backstage passes", like aged brie, increases in Price as it's Expiration date value approaches;
  * Price increases by 2 when there are 10 days or less 
  * Price increases by 3 when there are 5 days or less 
  * Price drops to 0 after the concert (expiration is less than zero)
* "Conjured" items degrade in Price twice as fast as normal items
* Just for clarification, an item can never have its Price increase above 50, 
however "Sulfuras" is a legendary item and as such its Price is 80 and it never alters.

Feel free to make any changes (Refactoring) to the UpdatePrice method and add any 
new code as long as everything still works correctly (Test business rules using TDD). 
However, do not alter the Item class.
