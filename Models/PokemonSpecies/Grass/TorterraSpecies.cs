using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Torterra Species to store common natural stats of all Torterras
	#region TorterraSpecies
	public class TorterraSpecies : PokemonSpecies
	{
#nullable enable
		private static TorterraSpecies? _instance = null;
#nullable restore
        public static TorterraSpecies Instance => _instance ?? (_instance = new TorterraSpecies());

		#region TorterraSpecies Constructor
		public TorterraSpecies() : base(
			389,
			"Torterra",
			Grass.Instance, Ground.Instance,
			2.2,
			310.0,
			new PokemonStats(
				95, // HPs
				109, 105, // Attack & Defense
				75, 85, // Spacial Attack & Defense
				56 // Speed
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
				"Headbutt",
				"Tackle",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Razor-Leaf",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Secret-Power",
				"Rock-Tomb",
				"Bullet-Seed",
				"Block",
				"Frenzy-Plant",
				"Natural-Gift",
				"Worry-Seed",
				"Rock-Polish",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Leaf-Storm",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Wood-Hammer",
				"Round",
				"Grass-Pledge",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}