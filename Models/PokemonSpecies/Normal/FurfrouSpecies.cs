using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Furfrou Species to store common natural stats of all Furfrous
	#region FurfrouSpecies
	public class FurfrouSpecies : PokemonSpecies
	{
#nullable enable
		private static FurfrouSpecies? _instance = null;
#nullable restore
        public static FurfrouSpecies Instance => _instance ?? (_instance = new FurfrouSpecies());

		#region FurfrouSpecies Constructor
		public FurfrouSpecies() : base(
			676,
			"Furfrou",
			Normal.Instance,
			1.2,
			28.0,
			new PokemonStats(
				75, // HPs
				80, 60, // Attack & Defense
				65, 90, // Spacial Attack & Defense
				102 // Speed
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
				"Tail-Whip",
				"Bite",
				"Growl",
				"Roar",
				"Surf",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"U-Turn",
				"Last-Resort",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Cotton-Guard",
				"Snarl",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}