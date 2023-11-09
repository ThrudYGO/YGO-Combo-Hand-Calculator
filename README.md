# Yu-Gi-Oh! Hand Calculator
This small console program lets you calculate the odds of getting a specific hand.
I have worded the prompts generically, so you can still use it for non-Yu-Gi-Oh! related scenarios, maybe you want to give it to someone who doesn't even know Yu-Gi-Oh! who still needs it though, or something like that.

The first question is about the number of cards in your deck, just enter the number of cards in your Main Deck, or, for a generic scenario, just enter the number of possible outcomes for every single attempt/pull. For a Yu-Gi-Oh! deck, let's aim for 40 cards, so enter 40. 
In a generic scenario, imagine you have 20 rocks consisting of differently valued minerals, we have 5 valuable rocks, 10 average value rocks and 5 worthless rocks

The second question is about the number of cards you are drawing, enter that, or, for a generic case, just enter how many times you will attempt to get a success. In Yu-Gi-Oh!, we assume we go first for now, so just enter 5, since we draw 5 cards on turn 1. 
For the rocks, you get to pick 3 random rocks, so enter 3.

For the 3rd question, enter the number of different successes you want. In Yu-Gi-Oh! terms, if you want a hand of, let's say, at least 1 Purrely Memory and at least 1 of the Main Deck monsters, you would say you want 2 success categories, as you want to pull both 1 from a pool of all the memories and 1 from a pool of all the monsters. 
In the case of the rocks, let's say you want at least 1 valuable and 1 average value rock, that means you have 2 categories, as you want to ensure you get at least 1 from the pool of all the valuable rocks, while ALSO getting at least 1 from the pool of all the average value rocks. You want both of these to be among your 3 total rocks.
This ties into the next 2 questions:

Question 4 requires you to answer the number of possible successes in your first category, or pool if you will, so, in the sense of cards, you have 10 Purrely Memory cards, since Delicious is currently limited, so you enter 10. 
For the rock example, you have 5 valuable rocks, so you enter 5 here.

Question 5 should be answered with the number of successes you want from the category or pool, so if you want at least 1 Memory from the 10 possible Memories in your deck, you enter 1.
The same in the case of rocks, you have 5 valuable rocks, but you only want at least 1 of the valuable ones, so you enter 1 for this example.

Now you repeat question 4 and 5 for the remaining categories or pools. 
For the Purrely example, question 4 for category 2 would now be answered with 6, since there are 6 Purrely Main Deck monsters and question 5 would be answered with 1, since we only want at least 1. Let's just ignore that the Memories can just Special Summon the monsters, it's just an example.
For the rock example, question 4 for category 2 would be answered with 10, since there are 10 rocks of average value and question 5 would be 1, since we only want at least 1 rock of average value.

Here are the results for both examples:
Purrely:
![image](https://github.com/ThrudYGO/YGO-Combo-Hand-Calculator/assets/150344061/1d4377e8-7a4d-4c07-9669-7659c019a69f)

Rocks:
![image](https://github.com/ThrudYGO/YGO-Combo-Hand-Calculator/assets/150344061/80f239f4-3130-4bfe-959b-ec2f70673ef7)
