# Imports
import json
import os

# Load the json file
# Database containing all pokemon to generate them
data = {}
with open("Data\\pokemon.json", encoding="utf-8") as F:
	data = json.load(F)

# For each poke in the list
for poke in data.values():

	# Find the name to use in file names
	pokeName: str = poke["name"].title()
	pokeNameNoSpace: str = ''.join([c for c in pokeName if c not in (' ', '-')])
	pokeStats = poke["stats"]

	# Create the PokemonMove class, by opening a file
	with open(f"Models\\Pokemons\\{pokeNameNoSpace}.cs", 'w', encoding="utf-8") as f:
	#with open(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
		# Load the template code
		outfile = f"""

using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{{
	//{pokeName} Specie to store common natural stats of all {pokeName}s
	#region Specie{pokeName}
	public class Specie{pokeNameNoSpace} : PokemonSpecie
	{{
#nullable enable
		private static Specie{pokeNameNoSpace}? _instance = null;
#nullable restore
        public static Specie{pokeNameNoSpace} Instance
        {{
            get
            {{
                if (_instance == null)
                {{
                    _instance = new Specie{pokeNameNoSpace}();
                }}
                return _instance;
            }}
        }}

		#region Specie{pokeName} Builder
		public Specie{pokeNameNoSpace}() : base(
			"{pokeName}",
			{pokeStats["hp"]}, // HPs
			{pokeStats["attack"]}, {pokeStats["defense"]}, // Attack & Defense
			{pokeStats["special-attack"]}, {pokeStats["special-defense"]}, // Special Attack & Defense
			{pokeStats["speed"]}		
		)
		{{
			this._height = {poke["height"]};
			this._weight = {poke["weight"]};
		}}
		#endregion
	}}
	#endregion

	//{pokeName} Pokemon Class
	#region {pokeName}
	public class {pokeNameNoSpace} : Pokemon
	{{
		#region {pokeName} Builders
		/// <summary>
		/// {pokeName} Builder waiting for a Nickname & a Level
		/// </summary>
		public {pokeNameNoSpace}(string nickname, int level)
		: base(
				{poke["id"]},
				Specie{pokeNameNoSpace}.Instance, // Pokemon Specie
				nickname, level,
				{", ".join([f'{pokeType.title()}.Instance' for pokeType in poke["types"]]) }			
		)
		{{
			CalculateStats();
			ResetCurrentStats();
		}}

		/// <summary>
		/// {pokeName} Builder only waiting for a Level
		/// </summary>
		public {pokeNameNoSpace}(int level)
		: base(
				{poke["id"]},
				Specie{pokeNameNoSpace}.Instance, // Pokemon Specie
				"{pokeName}", level,
				{", ".join([f'{pokeType.title()}.Instance' for pokeType in poke["types"]]) }			
		)
		{{
			CalculateStats();
			ResetCurrentStats();
		}}

		/// <summary>
		/// {pokeName} Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public {pokeNameNoSpace}() : base(
			{poke["id"]},
			Specie{pokeNameNoSpace}.Instance, // Pokemon Specie
			{", ".join([f'{pokeType.title()}.Instance' for pokeType in poke["types"]]) }			
		) {{}}
		*/
		#endregion
	}}
	#endregion
}}

"""[2:-2]
		# ↑ Delete the first two and last two newlines, here for readability

		# Write the code to the file
		f.write(outfile)