# FalconFlight
Technical Test for Falmouth.

# Controls
The build uses the following as the default keys, use the Unity splash screen to change these to your preference:

W: Pitch Down
A: Roll Left
S: Pitch Up
D: Roll right
Right Ctrl: Speed Down
Right Shift: Speed Up
Space: Switch Camera View

# Progress Notes
few extra notes: The dragon circles like a vulture, before divebombing you. It won't fly amongst the buildings, so if you keep low and out of the open areas, you won't be caught. The coin placement and the narrowness between the buildings is intentional, focussing on making the gameplay all about skill and weighing up your odds.

The Dragon AI proved to be the more difficult side of the entire Test, an hour was spent scratching my head over how to implement it, before realising that going for an AI design involving multiple raycasts could be simplified by adding an invisible trigger to each building, which causes the dragon to stop, then climb back up in the air, giving the player about 2-3 seconds before the dragon will begin circling and hunting them down.

I have realised that the AI requirement was for the dragon to relentlessly chase the player, and for the game to be more 'fly through cityscape themed course' and not flying through a city, but these elements were altered to fit into the tight time limit. I'd rather send something in a late pre-alpha than a proof of concept.

# Time Take: 10 hours
I ended up going over the time limit by an hour due to a combination of being a little bit rusty with my coding, and making the mistake of not chacking what I was unplugging when boiling up a kettle.
