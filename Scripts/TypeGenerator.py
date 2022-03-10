# Imports
import json
import os

# Load the json file
data = {}
with open("Data\\pokemon.json", encoding="utf-8") as F:
	data = json.load(F)

# Give every poke that should be generated
#nameList = ["squirtle", "bulbasaur", "charmander"]
#nameList.extend(["fire-punch", "ice-punch", "thunder-punch", "shadow-punch"])

# For each poke in the list
for poke in data.values():

	# Find the name to use in file names
	x = 0
	pokeName: str = poke["name"].title()
	pokeNameNoSpace: str = ''.join([c for c in pokeName if c not in (' ', '-')])
	pokeStats = poke["stats"]

	# If the file alreay exist, don't touch it
	#if (os.path.isfile(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs")): continue

	# Create the PokemonMove class, by opening a file
	with open(f"Models\\Pokemons\\{pokeNameNoSpace}.cs", 'w', encoding="utf-8") as f:
	#with open(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
		# Load the template code
		outfile = f"""

using Pokedex.Models.Types;

namespace Pokedex.Models.Types
{{
    publlic class Electric : PokeType
    {{
#nullable enable
        private static Electric? _instance = null;
#nullable disable
        public static Electric Instance
        {{
            get
            {{
                if (_instance == null)
                {{
                    _instance = new Electric();
                }}
                return _instance;
            }}
        }}
        private Electric() : base("Electric", "Yellow")
        {{
        }}
    }}
}}

"""[2:-2]
		# ↑ Delete the first two and last two newlines, here for readability

		# Write the code to the file
		f.write(outfile)