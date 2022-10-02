# The script of the game goes in this file.

# Declare characters used by this game. The color argument colorizes the
# name of the character.


# The game starts here.

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


label start:
    show sun

    "At some point, as the Parker Solar Probe descended just below 15 solar radii from the Sun's surface, it passed through a feature in the corona called a pseudostreamer."
    "Pseudostreamers are massive structures that rise above the surface of the Sun and are visible from Earth during solar eclipses."
    "These were the final proof that the spacecraft had passed Alfvén's critical surface and entered the solar atmosphere."
    "The first passage through the corona, which lasted only a few hours, is one of many planned for the mission."
    "Parker will continue to spiral closer to the Sun, eventually reaching 8.86 solar radii from the surface." 
    "Upcoming flights, with the next one in January 2022, will likely take the Parker Solar Probe through the corona again."
    "New results finally confirm that one point of origin of rotations is located near the surface of the Sun."
    "When Parker approached the Sun on his sixth flyby, at a distance of less than 25 solar radii." 
    "The data showed that the reverse revolutions occur in patches and contain a higher percentage of helium known to come from the photosphere than other elements." 
    "The origin of the revolutions was further narrowed down when scientists found areas aligned with magnetic funnels."
    "Scientists believe that magnetic funnels are not only the birthplace of reverse revolutions but may also be the birthplace of one of the components of the solar wind." 
    "There are two kinds of solar wind - fast and slow - and funnels can be where some of the particles in the fast solar wind come from."
    "Understanding where and how fast solar wind components originate, and whether they are rotational related, could help scientists answer a long-standing solar mystery: how the corona heats up to millions of degrees."
    "While the new results show where revolutions occur, scientists cannot yet confirm how they form."
    "Now that researchers know what to look for, Parker's closer passages may provide even more clues about revolutions and other solar phenomena." 
    "Future data will allow scientists to look into a region that is critical for superheating the corona and accelerating the solar wind to supersonic speeds." 
    "Such corona measurements will be critical to understanding and predicting extreme space weather events that can disrupt telecommunications and damage satellites around the Earth."

    hide sun
    return
