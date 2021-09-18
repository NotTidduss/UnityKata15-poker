Unity Kata #15 - Poker

What is Poker?
 - A card game in which a group of players wager over the best hand.
 - Typically, each player bets according to the rank they believe their hand is worth.
	- the highest bet has to be matched (via 'call') by other players, or else they're out.
	- if all but one fold: the last player wins the 'pot' (no need to show cards)
	- else: showdown: rest of players show cards, highest 'hand' wins.
	
ToDo:
- acknowledge players in master
- setup chip management in master
- implement general (= not initial-blind-betting, just add the function) raise feature
	- implement fold feature
	- implement call feature
		- requires raise by AI
			- requires that AI can take turns
				- requires turn system
				- require state machine
					- require gameState enum
- implement forced-bet
- add cards to infrastructure (no textures)
- implement card dealing
- implement card shuffling
- implement hand evaluation
- implement showdown
- tie everything together
