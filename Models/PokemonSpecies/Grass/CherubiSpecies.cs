using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cherubi Species to store common natural stats of all Cherubis
	#region CherubiSpecies
	public class CherubiSpecies : PokemonSpecies
	{
#nullable enable
		private static CherubiSpecies? _instance = null;
#nullable restore
        public static CherubiSpecies Instance => _instance ?? (_instance = new CherubiSpecies());

		#region CherubiSpecies Constructor
		public CherubiSpecies() : base(
			420,
			"Cherubi",
			Grass.Instance,
			0.4,
			3.3,
			new PokemonStats(
				45, // HPs
				35, 45, // Attack & Defense
				62, 53, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Tackle",
				"Take-Down",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Morning-Sun",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Secret-Power",
				"Weather-Ball",
				"Aromatherapy",
				"Grass-Whistle",
				"Tickle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Healing-Wish",
				"Natural-Gift",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Heal-Pulse",
				"Petal-Blizzard",
				"Flower-Shield",
				"Grassy-Terrain",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}