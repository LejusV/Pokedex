using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Weezing Species to store common natural stats of all Weezings
	#region WeezingSpecies
	public class WeezingSpecies : PokemonSpecies
	{
#nullable enable
		private static WeezingSpecies? _instance = null;
#nullable restore
        public static WeezingSpecies Instance => _instance ?? (_instance = new WeezingSpecies());

		#region WeezingSpecies Constructor
		public WeezingSpecies() : base(
			110,
			"Weezing",
			Poison.Instance,
			1.2,
			9.5,
			new PokemonStats(
				65, // HPs
				90, 120, // Attack & Defense
				85, 70, // Spacial Attack & Defense
				60 // Speed
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
				"Flamethrower",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Haze",
				"Bide",
				"Self-Destruct",
				"Smog",
				"Sludge",
				"Fire-Blast",
				"Poison-Gas",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Zap-Cannon",
				"Destiny-Bond",
				"Endure",
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
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Shock-Wave",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Dark-Pulse",
				"Giga-Impact",
				"Captivate",
				"Double-Hit",
				"Venoshock",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Belch",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}