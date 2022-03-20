using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Froakie Species to store common natural stats of all Froakies
	#region FroakieSpecies
	public class FroakieSpecies : PokemonSpecies
	{
#nullable enable
		private static FroakieSpecies? _instance = null;
#nullable restore
        public static FroakieSpecies Instance => _instance ?? (_instance = new FroakieSpecies());

		#region FroakieSpecies Constructor
		public FroakieSpecies() : base(
			656,
			"Froakie",
			Water.Instance,
			0.3,
			7.0,
			new PokemonStats(
				41, // HPs
				56, 40, // Attack & Defense
				62, 44, // Spacial Attack & Defense
				71 // Speed
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
				"Cut",
				"Growl",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
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
				"Mind-Reader",
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
				"Camouflage",
				"Mud-Sport",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"U-Turn",
				"Fling",
				"Toxic-Spikes",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Bestow",
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