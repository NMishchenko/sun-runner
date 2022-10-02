# The script of the game goes in this file.

# Declare characters used by this game. The color argument colorizes the
# name of the character.

default glossary_dict = {
"Atmosphere":"    An atmosphere is a layer of gas or layers of gases that envelop a planet, and is held in place by the gravity of the planetary body.",
"Photosphere": "    The photosphere is a star's outer shell from which light is radiated.",
"Eclipse": "    An eclipse is an astronomical event that occurs when an astronomical object or spacecraft is temporarily obscured, by passing into the shadow of another body or by having another body pass between it and the viewer.",
"The Parker Solar Probe": "    The Parker Solar Probe is a NASA space probe launched in 2018 with the mission of making observations of the outer corona of the Sun.",
"Solar Wind": "    The solar wind is a stream of charged particles released from the upper atmosphere of the Sun, called the corona.", 
"Venus": "    Venus is the second planet from the Sun and is named after the Roman goddess of love and beauty. As the brightest natural object in Earth's night sky after the Moon, Venus can cast shadows and can be visible to the naked eye in broad daylight."
}

define bresina = Character("John Bresina")
define parker = Character("Eugene Parker")

init python:

    def glossary_handler(target):
        renpy.show_screen("glossary", target)
        renpy.restart_interaction()

    config.hyperlink_handlers["glossary"] = glossary_handler

# The game starts here.

label start:

    # Show a background. This uses a placeholder by default, but you can
    # add a file (named either "bg room.png" or "bg room.jpg") to the
    # images directory to show it.

    scene solntse_one
    with fade

    "The Sun is a huge star and the center of our solar system."

    "Space itself is a cold place, because space is a huge area filled with almost nothing, and it's impossible to warm what is not there, isn't it?"

    "But the sun warms our planet and makes it possible for life to exist on it."

    scene suns_corona
    with dissolve

    "One of the main parts of the sun is the corona - the outermost part of its {a=glossary:Atmosphere}atmosphere{/a}." 

    "It is very hot, the temperature in this part of the sun can be over a million degrees, much more than the temperature on the surface of the sun known as the {a=glossary:Photosphere}photosphere{/a}."

    "Best of all, the sun's corona can be seen during a solar {a=glossary:Eclipse}eclipse{/a}."

    "But we still don't know much about the sun, which is why the {a=glossary:The Parker Solar Probe}The Parker Solar Probe{/a}  was developed."
    
    "A spacecraft that flies to the sun so that we can learn more about it."

    #"And here is a team of scientists watching the flight of the Parker Solar Probe at their headquarters."

    "{a=glossary:Solar Wind}Solar wind{/a} and problems for mechanisms. The solar wind emits a large number of radioactive particles into space, which can affect various technical devices."

    "For protection against radiation, space vehicles are covered with words of metals that do not allow radiation into the interior, as well as about thermal protection."

    "In the Parker Solar Probe, there is additional protection from the solar wind, because its main goal is to get as close to the sun as possible. "

    "For this, a solar shield was installed on this probe, which is always on the side of the sun, for greater protection."

    "Another problem for the Parker Solar Probe could be its helper Venus."

    "With the help of the magnetic field of {a=glossary:Venus}Venus{/a}, the probe corrects its direction of travel."

    "But you must always monitor the movement of the probe and Venus so that the probe does not enter the magnetic field too deeply."

    "This could lead to its collision with the surface of the planet."

    "Checking the data..."

    "At the moment, no overheating, strong overestimation of the radiation background in the middle, or collisions with cosmic bodies have been observed."

    return
