# The script of the game goes in this file.

# Declare characters used by this game. The color argument colorizes the
# name of the character.

image moon = Movie(play="main.webm", side_mask=True, size=(1920, 1080)) #, xpos=0, ypos=0, xanchor=0, yanchor=0)
image sun = Movie(play="sun.webm", side_mask=True, size=(1920, 1080)) #, xpos=0, ypos=0, xanchor=0, yanchor=0)

default glossary_dict = {
"Atmosphere":"    An atmosphere is a layer of gas or layers of gases that envelop a planet, and is held in place by the gravity of the planetary body.",
"Photosphere": "    The photosphere is a star's outer shell from which light is radiated.",
"Eclipse": "    An eclipse is an astronomical event that occurs when an astronomical object or spacecraft is temporarily obscured, by passing into the shadow of another body or by having another body pass between it and the viewer.",
"The Parker Solar Probe": "    The Parker Solar Probe is a NASA space probe launched in 2018 with the mission of making observations of the outer corona of the Sun.",
"Solar Wind": "    The solar wind is a stream of charged particles released from the upper atmosphere of the Sun, called the corona.", 
"Venus": "    Venus is the second planet from the Sun and is named after the Roman goddess of love and beauty. As the brightest natural object in Earth's night sky after the Moon, Venus can cast shadows and can be visible to the naked eye in broad daylight."
}

init python:

    def glossary_handler(target):
        renpy.show_screen("glossary", target)
        renpy.restart_interaction()

    config.hyperlink_handlers["glossary"] = glossary_handler

# The game starts here.

label start:
    show sun
    with fade

    "{a=glossary:Solar Wind}Solar wind{/a} and problems for mechanisms. The solar wind emits a large number of radioactive particles into space, which can affect various technical devices."
    "For protection against radiation, space vehicles are covered with words of metals that do not allow radiation into the interior, as well as about thermal protection."
    "In the Parker Solar Probe, there is additional protection from the solar wind, because its main goal is to get as close to the sun as possible. "
    "For this, a solar shield was installed on this probe, which is always on the side of the sun, for greater protection."
    
    hide sun
    show moon
    with fade

    "Another problem for the Parker Solar Probe could be its helper Venus."
    "With the help of the magnetic field of {a=glossary:Venus}Venus{/a}, the probe corrects its direction of travel."
    "But you must always monitor the movement of the probe and Venus so that the probe does not enter the magnetic field too deeply."
    "This could lead to its collision with the surface of the planet."
    "Sometimes the light is reflected from solar dust and \"blinds\" the location sensors that are aimed at the stars and the satellite loses its orientation for a short time." 
    "But due to the fact that the satellite flies along a given trajectory and has sensitivity sensors that allow determining the position of the sun, this does not pose a serious danger."
    "Checking the data..."
    "At the moment, no overheating, strong overestimation of the radiation background in the middle, or collisions with cosmic bodies have been observed."

    hide moon
    return
