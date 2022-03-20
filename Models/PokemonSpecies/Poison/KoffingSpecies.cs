using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Koffing Species to store common natural stats of all Koffings
	#region KoffingSpecies
	public class KoffingSpecies : PokemonSpecies
	{
#nullable enable
		private static KoffingSpecies? _instance = null;
#nullable restore
        public static KoffingSpecies Instance => _instance ?? (_instance = new KoffingSpecies());

		#region KoffingSpecies Constructor
		public KoffingSpecies() : base(
			109,
			"Koffing",
			Poison.Instance,
			0.6,
			1.0,
			new PokemonStats(
				40, // HPs
				65, 95, // Attack & Defense
				60, 45, // Spacial Attack & Defense
				35 // Speed
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
				"Psybeam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
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
				"Psywave",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Grudge",
				"Secret-Power",
				"Shock-Wave",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Toxic-Spikes",
				"Dark-Pulse",
				"Captivate",
				"Venoshock",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Belch",
				"Confide",
				"Venom-Drench",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}