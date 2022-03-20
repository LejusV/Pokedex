using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gigalith Species to store common natural stats of all Gigaliths
	#region GigalithSpecies
	public class GigalithSpecies : PokemonSpecies
	{
#nullable enable
		private static GigalithSpecies? _instance = null;
#nullable restore
        public static GigalithSpecies Instance => _instance ?? (_instance = new GigalithSpecies());

		#region GigalithSpecies Constructor
		public GigalithSpecies() : base(
			526,
			"Gigalith",
			Rock.Instance,
			1.7,
			260.0,
			new PokemonStats(
				85, // HPs
				135, 130, // Attack & Defense
				60, 80, // Spacial Attack & Defense
				25 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
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
				"Superpower",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Gravity",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Iron-Head",
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