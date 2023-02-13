# Attack calculator kata
The goal of the Kata is to refactor a legacy code which is a little bit messy. In order to properly do the refactor, you will have to create unit tests, of course :wink:. Also, you'll probably need to practice with a technique called extract and override.

The kata topic is inspired in Dungeons and Dragons role game. In that game, whenever a character tries to hurt another one, there's a dice roll and some calculations which take into account the attack and defense skills of the characters involved. As you can imagine, this is just an excuse to toy around with the code, so don't expect 100% fidelity between the game and the code.

## Setup

### C#
You should download this repo and open *csharp/Game/Game.sln*  with your favorite c# editor (for example, you can use Visual Studio Community which is free in most cases).

Once you have opened the solution, you should be able to compile it and then run the tests in Game.tests project. One test should pass and the other should fail.

Once you are here you are ready to go.

### Kotlin
You should download this repo and open *kotlin/* with your favorite Kotlin editor (for example, you can use IntelliJ IDEA Community Edition by JetBrains which is free to use).

Once you have opened the project, you should be able to compile it and then run the tests. One test should pass and the other should fail.

Once you are here you are ready to go.

#### Kotest
The test framework used is [Kotest](https://kotest.io/)

If you are using IntelliJ there is [a plugin available](https://github.com/kotest/kotest-intellij-plugin) at the jetbrains plugin [marketplace](https://plugins.jetbrains.com/plugin/14080-kotest). This plugin provides run icons for each test, a tool window for test navigation, duplicated test highlighting, assertion intentions, and more.

On the other hand you can run the `test` Gradle task from you terminal: 
```shell
./gradlew test
```

## More info
In “Working Effectively with Legacy Code” Michael C. Feathers talks about “Extract and Override”. Also Roy Osherove talks about it in the book “Art of Unit Testing“.

## Feedback
Any constructive comments and/or feedback will be highly appreciated.
Enjoy!