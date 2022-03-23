# Imports
from asyncio.windows_events import NULL
import json
import os

# Load the json file
data = {}
with open("Data\\moves.json", encoding="utf-8") as f:
	data = json.load(f)

# For each move in the list
for move in data.values():
#for move in [data[name] for name in nameList]:
	# Find the name to use in file names
	moveName: str = move["name"].title()
	moveNameNoSpace: str = ''.join([c for c in moveName if c not in (' ', '-')])
	moveType: str = move["type"].title()

	# If the file alreay exist, don't touch it
	# I do want to touch it !
	#if (os.path.isfile(f"Models\\Moves\\{moveType}\\Move{moveNameNoSpace}.cs")): continue

	# Create the PokemonMove class, by opening a file
	#with open(f"D:\\PokedexMovesTest\\{moveType}\\Move{moveNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
	newpath = f'./Models/Moves/{moveType}' 
	if not os.path.exists(newpath):
		os.makedirs(newpath)
	with open(f"Models\\Moves\\{moveType}\\Move{moveNameNoSpace}.cs", 'w+', encoding="utf-8") as fBase:
		# Load the template code
		outfile = f"""

using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{{
	//{move["description"].replace('$effect_chance', str(move["effect_chance"]))}
	public class Move{moveNameNoSpace} : Move
	{{

		private static Move{moveNameNoSpace}? _instance = null;

        public static Move{moveNameNoSpace} Instance => _instance ?? (_instance = new Move{moveNameNoSpace}());

		public Move{moveNameNoSpace}() : base(
			"{moveName}",
			{moveType}.Instance, // Move Type
			MoveCategory.{move["damage_class"].title()}, // Move Category
			{move["pp"]}, {move["power"] or "null"},// PP & Pow
			{move["accuracy"] or "null"}, {move["priority"]} // Acc & Priority
		) {{}}
	}}
}}

"""[2:-2]
		# ↑ Delete the first two and last two newlines, here for readability

		# Write the code to the file
		fBase.write(outfile)
	newpath = f'./Models/MoveInstances/{moveType}' 
	if not os.path.exists(newpath):
		os.makedirs(newpath)
	with open(f"Models\\MoveInstances\\{moveType}\\I{moveNameNoSpace}.cs", 'w+', encoding="utf-8") as fInstance:
		# Load the template code
		outfile = f"""

using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{{
	// The specific Move Instance Class
	public class I{moveNameNoSpace} : MoveInstance
	{{
		public I{moveNameNoSpace}( PokemonInstance owner) : base( owner, Move{moveNameNoSpace}.Instance ) {{}}

		public I{moveNameNoSpace}( PokemonInstance owner, int pp) : base( owner, Move{moveNameNoSpace}.Instance, pp ) {{}}
	}}
}}

"""[2:-2]
		# ↑ Delete the first two and last two newlines, here for readability

		# Write the code to the file
		fInstance.write(outfile)