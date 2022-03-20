using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Venusaur Species to store common natural stats of all Venusaurs
	#region VenusaurSpecies
	public class VenusaurSpecies : PokemonSpecies
	{
#nullable enable
		private static VenusaurSpecies? _instance = null;
#nullable restore
        public static VenusaurSpecies Instance => _instance ?? (_instance = new VenusaurSpecies());

		#region VenusaurSpecies Constructor
		public VenusaurSpecies() : base(
			3,
			"Venusaur",
			Grass.Instance, Poison.Instance,
			2.0,
			100.0,
			new PokemonStats(
				80, // HPs
				82, 83, // Attack & Defense
				100, 100, // Spacial Attack & Defense
				80 // Speed
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
				"Bind",
				"Vine-Whip",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Sleep-Powder",
				"Petal-Dance",
				"String-Shot",
				"Earthquake",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Outrage",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Bullet-Seed",
				"Block",
				"Frenzy-Plant",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Rock-Climb",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Bulldoze",
				"Work-Up",
				"Petal-Blizzard",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}