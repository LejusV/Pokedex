using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tropius Species to store common natural stats of all Tropiuss
	#region TropiusSpecies
	public class TropiusSpecies : PokemonSpecies
	{
#nullable enable
		private static TropiusSpecies? _instance = null;
#nullable restore
        public static TropiusSpecies Instance => _instance ?? (_instance = new TropiusSpecies());

		#region TropiusSpecies Constructor
		public TropiusSpecies() : base(
			357,
			"Tropius",
			Grass.Instance, Flying.Instance,
			2.0,
			100.0,
			new PokemonStats(
				99, // HPs
				68, 83, // Attack & Defense
				72, 87, // Spacial Attack & Defense
				51 // Speed
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Gust",
				"Whirlwind",
				"Fly",
				"Slam",
				"Stomp",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Bullet-Seed",
				"Aerial-Ace",
				"Magical-Leaf",
				"Leaf-Blade",
				"Dragon-Dance",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Worry-Seed",
				"Seed-Bomb",
				"Air-Slash",
				"Dragon-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Round",
				"Bestow",
				"Bulldoze",
				"Leaf-Tornado",
				"Confide",
				"Dragon-Hammer",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}