using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Boldore Species to store common natural stats of all Boldores
	#region BoldoreSpecies
	public class BoldoreSpecies : PokemonSpecies
	{
#nullable enable
		private static BoldoreSpecies? _instance = null;
#nullable restore
        public static BoldoreSpecies Instance => _instance ?? (_instance = new BoldoreSpecies());

		#region BoldoreSpecies Constructor
		public BoldoreSpecies() : base(
			525,
			"Boldore",
			Rock.Instance,
			0.9,
			102.0,
			new PokemonStats(
				70, // HPs
				105, 105, // Attack & Defense
				50, 40, // Spacial Attack & Defense
				20 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Strength",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Harden",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Gravity",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Flash-Cannon",
				"Stone-Edge",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}