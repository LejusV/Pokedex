# Imports
import json
import os

# Load the json file
data = {}
with open("Data\\moves.json", encoding="utf-8") as f:
	data = json.load(f)

# Give every move that should be generated
nameList = ["scratch", "tackle", "ember"]
#nameList.extend(["fire-punch", "ice-punch", "thunder-punch", "shadow-punch"])

# For each move in the list
for move in data.values():
#for move in [data[name] for name in nameList]:
	# Find the name to use in file names
	moveName: str = move["name"].title()
	moveNameNoSpace: str = ''.join([c for c in moveName if c not in (' ', '-')])
	moveType: str = move["type"].title()

	# If the file alreay exist, don't touch it
	#if (os.path.isfile(f"Models\\Moves\\{moveType}\\Move{moveNameNoSpace}.cs")): continue

	# Create the PokemonMove class, by opening a file
	#with open(f"D:\\PokedexMovesTest\\{moveType}\\Move{moveNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
	with open(f"Models\\Moves\\{moveType}\\Move{moveNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
		# Load the template code
		outfile = f"""

using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{{
	//{move["description"].replace('$effect_chance', str(move["effect_chance"]))}
	public class Move{moveNameNoSpace} : Move
	{{
		public Move{moveNameNoSpace}() : base(
			"{moveName}",
			{moveType}.Instance, // Move Type
			MoveCategory.{move["damage_class"].title()}, // Move Category
			{move["pp"]}, {move["power"] or "null"},// PP & Pow
			{move["accuracy"]/100 or "null"}, {move["priority"]} // Acc & Priority
		) {{}}
	}}
}}

"""[2:-2]
		# ↑ Delete the first two and last two newlines, here for readability

		# Write the code to the file
		f.write(outfile)
