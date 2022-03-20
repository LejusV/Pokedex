using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tepig Species to store common natural stats of all Tepigs
	#region TepigSpecies
	public class TepigSpecies : PokemonSpecies
	{
#nullable enable
		private static TepigSpecies? _instance = null;
#nullable restore
        public static TepigSpecies Instance => _instance ?? (_instance = new TepigSpecies());

		#region TepigSpecies Constructor
		public TepigSpecies() : base(
			498,
			"Tepig",
			Fire.Instance,
			0.5,
			9.9,
			new PokemonStats(
				65, // HPs
				63, 45, // Attack & Defense
				45, 45, // Spacial Attack & Defense
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Tail-Whip",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Covet",
				"Gyro-Ball",
				"Assurance",
				"Sucker-Punch",
				"Flare-Blitz",
				"Zen-Headbutt",
				"Grass-Knot",
				"Head-Smash",
				"Heavy-Slam",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Fire-Pledge",
				"Work-Up",
				"Wild-Charge",
				"Heat-Crash",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion
}