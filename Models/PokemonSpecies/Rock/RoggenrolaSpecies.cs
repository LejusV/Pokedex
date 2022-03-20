using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Roggenrola Species to store common natural stats of all Roggenrolas
	#region RoggenrolaSpecies
	public class RoggenrolaSpecies : PokemonSpecies
	{
#nullable enable
		private static RoggenrolaSpecies? _instance = null;
#nullable restore
        public static RoggenrolaSpecies Instance => _instance ?? (_instance = new RoggenrolaSpecies());

		#region RoggenrolaSpecies Constructor
		public RoggenrolaSpecies() : base(
			524,
			"Roggenrola",
			Rock.Instance,
			0.4,
			18.0,
			new PokemonStats(
				55, // HPs
				75, 85, // Attack & Defense
				25, 25, // Spacial Attack & Defense
				15 // Speed
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
				"Take-Down",
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
				"Curse",
				"Protect",
				"Mud-Slap",
				"Lock-On",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
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
				"Earth-Power",
				"Flash-Cannon",
				"Stone-Edge",
				"Stealth-Rock",
				"Wide-Guard",
				"Autotomize",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}