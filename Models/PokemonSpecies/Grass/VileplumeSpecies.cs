using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vileplume Species to store common natural stats of all Vileplumes
	#region VileplumeSpecies
	public class VileplumeSpecies : PokemonSpecies
	{
#nullable enable
		private static VileplumeSpecies? _instance = null;
#nullable restore
        public static VileplumeSpecies Instance => _instance ?? (_instance = new VileplumeSpecies());

		#region VileplumeSpecies Constructor
		public VileplumeSpecies() : base(
			45,
			"Vileplume",
			Grass.Instance, Poison.Instance,
			1.2,
			18.6,
			new PokemonStats(
				75, // HPs
				80, 85, // Attack & Defense
				110, 90, // Spacial Attack & Defense
				50 // Speed
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Petal-Dance",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Aromatherapy",
				"Bullet-Seed",
				"Natural-Gift",
				"Fling",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}