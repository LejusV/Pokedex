using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dwebble Species to store common natural stats of all Dwebbles
	#region DwebbleSpecies
	public class DwebbleSpecies : PokemonSpecies
	{
#nullable enable
		private static DwebbleSpecies? _instance = null;
#nullable restore
        public static DwebbleSpecies Instance => _instance ?? (_instance = new DwebbleSpecies());

		#region DwebbleSpecies Constructor
		public DwebbleSpecies() : base(
			557,
			"Dwebble",
			Bug.Instance, Rock.Instance,
			0.3,
			14.5,
			new PokemonStats(
				50, // HPs
				65, 85, // Attack & Defense
				35, 35, // Spacial Attack & Defense
				55 // Speed
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
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Spikes",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Rock-Polish",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Shadow-Claw",
				"Rock-Wrecker",
				"Stone-Edge",
				"Stealth-Rock",
				"Bug-Bite",
				"Hone-Claws",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Shell-Smash",
				"Struggle-Bug",
				"Bulldoze",
				"Rototiller",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}