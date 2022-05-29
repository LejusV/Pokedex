# Imports
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
	eol: str = ',\n\t\t\t\t'
	moveCategory: str = move["category"].title()
	moveCategoryNoSpace: str = ''.join([c for c in moveCategory if c not in (' ', '-', '+')])
	moveName: str = move["name"].title()
	moveNameNoSpace: str = ''.join([c for c in moveName if c not in (' ', '-')])
	moveTarget: str = move["target"].title()
	moveTargetNoSpace: str = ''.join([c for c in moveTarget if c not in (' ', '-')])
	moveType: str = move["type"].title()
	moveAilment: str = move['ailment']['type'].title()
	moveAilmentNoSpace: str = ''.join([c for c in moveAilment if c not in (' ', '-', '+')])
	

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

using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{{	
	public class Move{moveNameNoSpace} : Move
	{{

		private static Move{moveNameNoSpace}? _instance = null;

        public static Move{moveNameNoSpace} Instance => _instance ?? (_instance = new Move{moveNameNoSpace}());

		public Move{moveNameNoSpace}() : base(
			{move["accuracy"] or "null"}, // Accuracy
			{f"new MoveAilment(Enums.Ailment.{moveAilmentNoSpace}, {move['ailment']['chance']})" if move['ailment']['type'] != 'none' else 'null'}, // Ailment
			DamageCategory.{move["damage_class"].title()}, // Damage category
			"{move["description"].replace('$effect_chance', str(move["effect_chance"]))}", // Description
			{move["healing"]}, // Healing
			MoveCategory.{moveCategoryNoSpace}, // Move Category
			"{moveName}", // Name
			{move["power"] or "null"}, {move["pp"]}, // Pow and PP
			{move["priority"]}, //Priority
			new Dictionary<BattleStat, int>()
			{{
				{f'{eol}'.join([f'{{Enums.BattleStat.{"ATK" if moveChange["stat"] == "attack" else "DEF" if moveChange["stat"] == "defense" else "SP_ATK" if moveChange["stat"] == "special-attack" else "SP_DEF" if moveChange["stat"] == "special-defense" else "SPEED" if moveChange["stat"] == "speed" else "ACCURACY" if moveChange["stat"] == "accuracy" else "EVASION" if moveChange["stat"] == "evasion" else "null"}, {moveChange["change"]}}}' for moveChange in move["stat_changes"]])}
			}},
			{f"MoveTarget.{moveTargetNoSpace}"}, // Target(s)
			{moveType}.Instance // Type (Element)
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