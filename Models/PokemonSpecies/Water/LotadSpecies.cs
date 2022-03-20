using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lotad Species to store common natural stats of all Lotads
	#region LotadSpecies
	public class LotadSpecies : PokemonSpecies
	{
#nullable enable
		private static LotadSpecies? _instance = null;
#nullable restore
        public static LotadSpecies Instance => _instance ?? (_instance = new LotadSpecies());

		#region LotadSpecies Constructor
		public LotadSpecies() : base(
			270,
			"Lotad",
			Water.Instance, Grass.Instance,
			0.5,
			2.6,
			new PokemonStats(
				40, // HPs
				30, 30, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				30 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Mist",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Counter",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Teeter-Dance",
				"Astonish",
				"Tickle",
				"Bullet-Seed",
				"Water-Pulse",
				"Natural-Gift",
				"Seed-Bomb",
				"Energy-Ball",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}