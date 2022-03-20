using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Trubbish Species to store common natural stats of all Trubbishs
	#region TrubbishSpecies
	public class TrubbishSpecies : PokemonSpecies
	{
#nullable enable
		private static TrubbishSpecies? _instance = null;
#nullable restore
        public static TrubbishSpecies Instance => _instance ?? (_instance = new TrubbishSpecies());

		#region TrubbishSpecies Constructor
		public TrubbishSpecies() : base(
			568,
			"Trubbish",
			Poison.Instance,
			0.6,
			31.0,
			new PokemonStats(
				50, // HPs
				50, 62, // Attack & Defense
				40, 62, // Spacial Attack & Defense
				65 // Speed
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
				"Double-Slap",
				"Sand-Attack",
				"Take-Down",
				"Toxic",
				"Double-Team",
				"Haze",
				"Self-Destruct",
				"Sludge",
				"Amnesia",
				"Poison-Gas",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Spikes",
				"Giga-Drain",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Stockpile",
				"Swallow",
				"Facade",
				"Recycle",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Blast",
				"Payback",
				"Toxic-Spikes",
				"Dark-Pulse",
				"Seed-Bomb",
				"Drain-Punch",
				"Gunk-Shot",
				"Venoshock",
				"Autotomize",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Clear-Smog",
				"Belch",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}