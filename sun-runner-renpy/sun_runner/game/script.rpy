# The script of the game goes in this file.

# Declare characters used by this game. The color argument colorizes the
# name of the character.

define bresina = Character("John Bresina")
define parker = Character("Eugene Parker")


# The game starts here.

label start:

    # Show a background. This uses a placeholder by default, but you can
    # add a file (named either "bg room.png" or "bg room.jpg") to the
    # images directory to show it.

    scene solntse_one
    with fade

    "The sun is a great star and the center of our sleepy system."

    "Space itself is a cold place, because space is a huge space filled with almost nothing, and is it possible to warm what is not there."

    "But the sun warms our planet and makes it possible for life to exist on it."

    scene suns_corona
    with dissolve

    "One of the main parts of the sun is the corona - the outermost part of its atmosphere." 

    "It is very hot, the temperature in this part of the sun can be over a million degrees, much more than the temperature on the surface of the sun known as the photosphere. "

    "Best of all, the sun's corona can be seen during a solar eclipse. But we still don't know much about the sun, which is why the Parker Solar Probe was developed."

    "But we still don't know much about the sun, which is why the Parker Solar Probe was developed."
    
    "A spacecraft that flies to the sun so that we can learn more about it."

    "And here is a team of scientists watching the flight of the Parker Solar Probe at their headquarters"

    scene nasa_office_bg
    with dissolve

    show normal_parker at right

    show normal_bresina at left
    with dissolve

    parker "I love the sun. The sun is hope."

    parker "I am going to visit the sun."

    bresina "I ate pizza for lunch!"

    # This shows a character sprite. A placeholder is used, but you can
    # replace it by adding a file named "eileen happy.png" to the images
    # directory.

    # This ends the game.

    return
