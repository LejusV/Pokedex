using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Crustle Species to store common natural stats of all Crustles
	#region CrustleSpecies
	public class CrustleSpecies : PokemonSpecies
	{
#nullable enable
		private static CrustleSpecies? _instance = null;
#nullable restore
        public static CrustleSpecies Instance => _instance ?? (_instance = new CrustleSpecies());

		#region CrustleSpecies Constructor
		public CrustleSpecies() : base(
			558,
			"Crustle",
			Bug.Instance, Rock.Instance,
			1.4,
			200.0,
			new PokemonStats(
				70, // HPs
				105, 125, // Attack & Defense
				65, 75, // Spacial Attack & Defense
				45 // Speed
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
				"Hyper-Beam",
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
				"Flail",
				"Protect",
				"Feint-Attack",
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
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Rock-Polish",
				"Poison-Jab",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Wrecker",
				"Stone-Edge",
				"Stealth-Rock",
				"Bug-Bite",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Shell-Smash",
				"Struggle-Bug",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}