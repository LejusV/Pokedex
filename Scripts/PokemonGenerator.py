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
	newpath = f'./Models/PokemonSpecies/{poke["types"][0].title()}' 
	if not os.path.exists(newpath):
		os.makedirs(newpath)
	with open(f"Models\\PokemonSpecies\\{poke['types'][0].title()}\\{pokeNameNoSpace}Species.cs", 'w', encoding="utf-8") as fSpecie:
	#with open(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
		# Load the template code
		outfSpecie = f"""

using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{{
	//{pokeName} Species to store common natural stats of all {pokeName}s
	#region {pokeName}Species
	public class {pokeNameNoSpace}Species : PokemonSpecies
	{{

		private static {pokeNameNoSpace}Species? _instance = null;

        public static {pokeNameNoSpace}Species Instance => _instance ?? (_instance = new {pokeNameNoSpace}Species());

		#region {pokeName}Species Constructor
		public {pokeNameNoSpace}Species() : base(
			{poke["id"]},
			"{pokeName}",
			{", ".join([f'{pokeType.title()}.Instance' for pokeType in poke["types"]]) },
			{poke["height"]/10},
			{poke["weight"]/10},
			new PokemonStats(
				{pokeStats["hp"]}, // HPs
				{pokeStats["attack"]}, {pokeStats["defense"]}, // Attack & Defense
				{pokeStats["special-attack"]}, {pokeStats["special-defense"]}, // Spacial Attack & Defense
				{pokeStats["speed"]} // Speed
			)			
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
}}

"""[2:-2]
		# ↑ Delete the first two and last two newlines, here for readability

		# Write the code to the file
		fSpecie.write(outfSpecie)

	newpath = f'./Models/PokemonInstances/{poke["types"][0].title()}' 
	if not os.path.exists(newpath):
		os.makedirs(newpath)
	with open(f"Models\\PokemonInstances\\{poke['types'][0].title()}\\{pokeNameNoSpace}.cs", 'w', encoding="utf-8") as fInstance:
	#with open(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
		# Load the template code
		outfInstance = f"""

using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{{
	//{pokeName} PokemonInstance Class
	#region {pokeName}
	public class {pokeNameNoSpace} : PokemonInstance
	{{
		#region {pokeName} Constructors
		/// <summary>
		/// {pokeName} Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public {pokeNameNoSpace}(string nickname, int level)
		: base(
				{pokeNameNoSpace}Species.Instance, // Pokemon Species
				nickname, level		
		)
		{{ }}

		/// <summary>
		/// {pokeName} Constructor only waiting for a Level
		/// </summary>
		public {pokeNameNoSpace}(int level)
		: this( "{pokeName}", level	)
		{{ }}

		/// <summary>
		/// {pokeName} Constructor waiting for no params
		/// </summary>
		/*
		public {pokeNameNoSpace}() : this( "{pokeName}", 1 )
		{{ }}
		*/
		#endregion
	}}
	#endregion
}}

"""[2:-2]
		# ↑ Delete the first two and last two newlines, here for readability

		# Write the code to the file
		fInstance.write(outfInstance)