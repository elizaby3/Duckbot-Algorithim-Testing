## Main Purpose
The purpose of this unity simulation is to simulate an algorithim of Duck Robots \(Duckbots\) finding each other based solely on what they see within their range of vision. This project is inspired by Coordinated Control of Multi-Robot Systems: A survey by Jorge Cortes and Magnus Egerstedt. 

Currently, the simulation deploys 20 duckbots and an average of 17 Duckbots find each other and group together every simulation. In order to do this, the duckbots rotate until they see a fellow duck enter the line of sight. Afterwards, the ducks go toward each other before stopping at a minimum distance. Then, DuckBots rotate around again to see if there are any other ducks nearby.

Please see github project code in the testing branch for current progress.

## Future Prospects/Goals
- fixing gravity as the colliders interacting with gravity sometimes cause ducks to fly or ducks to fall through the ground
- experiment with more or less ducks and see how the simulation is affected
- make different duckbots with different colors employing different strategies to see if one method is more preferable compared to the other 

[Link to Main Projects Page](https://elizaby3.github.io)
