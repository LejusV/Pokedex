using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ivysaur Species to store common natural stats of all Ivysaurs
	#region IvysaurSpecies
	public class IvysaurSpecies : PokemonSpecies
	{
#nullable enable
		private static IvysaurSpecies? _instance = null;
#nullable restore
        public static IvysaurSpecies Instance => _instance ?? (_instance = new IvysaurSpecies());

		#region IvysaurSpecies Constructor
		public IvysaurSpecies() : base(
			2,
			"Ivysaur",
			Grass.Instance, Poison.Instance,
			1.0,
			13.0,
			new PokemonStats(
				60, // HPs
				62, 63, // Attack & Defense
				80, 80, // Spacial Attack & Defense
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
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Sleep-Powder",
				"String-Shot",
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
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}