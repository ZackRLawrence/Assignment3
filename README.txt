Please open the project in editor and enter the coconut island scene. There will be one torch enabled in the scene, 
from that torch you can edit the exposed variables of a color gradient that controls the color of the fire as well as
its glow and float that will control how important sound is to the size of the vire and the intensity of the glow.

Part B - 1:
Explosions. I can think of a few ways I might an example of this effect might work.

If you want a hyperrealistic explosion, I imagine you're unevenly expanding a mesh(maybe with a noise function), and basing the color of each vertice
on the mesh on how far out it is. For example, the inner most points of the outer mesh would be a bright yellow, which transitions
to orange to red to dark gray(for smoke) depending how far away from the center each point it. Also control emissiveness based on how close to the epicenter
the vertice is. In unity, I would make my own spherical mesh and proceed to expand out each vertex differing values based on a continuous noise function. 
Using a shader, calculate the color and emissiveness based on current noise value on the vertex.

Example of the effect: https://www.youtube.com/watch?v=FwIe0AVJAeQ

Another common video game explosion involves a couple growing perfect spheres that are transparent with explosion textures.
These aften expand out then fade away, and are accompanied by some sort of ember particle effect. How I would do this one
is the couple of spheres as stated, each with an "explosion" texture, ideally something that looks like a wall of fire, the inner
inner most one will be slightly tranparent and colored yellow, the middle one will be a little more transparent and orange,
the outer most one will be a red and the most transparent. Each sphere will be spinning and have emmissiveness applied through
a shader based on how small it is. The spheres will fade away as they get bigger. As far the ember particle effect, a bright 
glowing orange spark that follows a spiral spine up at the end of the explosion would work very well.

More complicated verson of the effect I'm suggesting
https://lh5.googleusercontent.com/3ZlG2KXu6UOwUstUj82iRstGdHakPRkBXzg0X9u-t28A77j-KVV9bjxMXDFe8cS5uUc8nrqp9yfWkQW0ezbngwGUfnXh8Ngn6ARlLQjk3x9itlfIlJuewE6ydxkj8HDvGHP4LDzFRis

Part B - 2:

The people I plan to have in my group are Damen Birtola, John Khaw, Luke Mason, David Kirkpatrick and Josh Husting.