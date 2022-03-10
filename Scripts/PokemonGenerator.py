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
	move: str
	newline: str = ',\n\t\t\t\t'

	# Create the PokemonMove class, by opening a file
	with open(f"Models\\Pokemons\\{pokeNameNoSpace}.cs", 'w', encoding="utf-8") as f:
	#with open(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
		# Load the template code
		outfile = f"""

using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{{
	//{pokeName} Species to store common natural stats of all {pokeName}s
	#region Species{pokeName}
	public class Species{pokeNameNoSpace} : PokemonSpecies
	{{
#nullable enable
		private static Species{pokeNameNoSpace}? _instance = null;
#nullable restore
        public static Species{pokeNameNoSpace} Instance
        {{
            get
            {{
                if (_instance == null)
                {{
                    _instance = new Species{pokeNameNoSpace}();
                }}
                return _instance;
            }}
        }}

		#region Species{pokeName} Constructor
		public Species{pokeNameNoSpace}() : base(
			"{pokeName}",
			{poke["height"]/10},
			{poke["weight"]/10},
			{pokeStats["hp"]}, // HPs
			{pokeStats["attack"]}, {pokeStats["defense"]}, // Attack & Defense
			{pokeStats["special-attack"]}, {pokeStats["special-defense"]}, // Special Attack & Defense
			{pokeStats["speed"]}		
		)
		{{
			InitMovesList();
		}}
		#endregion

		#region Methods
		private void InitMovesList()
		{{
			_moveList = new List<string>()
			{{
				{f'{newline}'.join([f'"{move.title()}"' for move in poke["moves"]])}
			}};
		}}
		#endregion
	}}
	#endregion

	//{pokeName} PokemonInstance Class
	#region {pokeName}
	public class {pokeNameNoSpace}Instance : PokemonInstance
	{{
		#region {pokeName} Constructors
		/// <summary>
		/// {pokeName} Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public {pokeNameNoSpace}Instance(string nickname, int level)
		: base(
				{poke["id"]},
				Species{pokeNameNoSpace}.Instance, // Pokemon Species
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
		public {pokeNameNoSpace}Instance(int level)
		: base(
				{poke["id"]},
				Species{pokeNameNoSpace}.Instance, // PokemonInstance Species
				"{pokeName}", level,
				{", ".join([f'{pokeType.title()}.Instance' for pokeType in poke["types"]]) }			
		)
		{{
			CalculateStats();
			ResetCurrentStats();
		}}

		/// <summary>
		/// {pokeName} Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public {pokeNameNoSpace}() : base(
			{poke["id"]},
			Species{pokeNameNoSpace}.Instance, // PokemonInstance Species
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