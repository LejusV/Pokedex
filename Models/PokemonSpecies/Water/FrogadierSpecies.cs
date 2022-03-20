using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Frogadier Species to store common natural stats of all Frogadiers
	#region FrogadierSpecies
	public class FrogadierSpecies : PokemonSpecies
	{
#nullable enable
		private static FrogadierSpecies? _instance = null;
#nullable restore
        public static FrogadierSpecies Instance => _instance ?? (_instance = new FrogadierSpecies());

		#region FrogadierSpecies Constructor
		public FrogadierSpecies() : base(
			657,
			"Frogadier",
			Water.Instance,
			0.6,
			10.9,
			new PokemonStats(
				54, // HPs
				63, 52, // Attack & Defense
				83, 56, // Spacial Attack & Defense
				97 // Speed
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
				"Pound",
				"Ice-Punch",
				"Cut",
				"Growl",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Smokescreen",
				"Lick",
				"Waterfall",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Role-Play",
				"Snatch",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bounce",
				"Water-Pulse",
				"U-Turn",
				"Fling",
				"Dark-Pulse",
				"Gunk-Shot",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}