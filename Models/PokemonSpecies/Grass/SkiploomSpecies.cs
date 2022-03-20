using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Skiploom Species to store common natural stats of all Skiplooms
	#region SkiploomSpecies
	public class SkiploomSpecies : PokemonSpecies
	{
#nullable enable
		private static SkiploomSpecies? _instance = null;
#nullable restore
        public static SkiploomSpecies Instance => _instance ?? (_instance = new SkiploomSpecies());

		#region SkiploomSpecies Constructor
		public SkiploomSpecies() : base(
			188,
			"Skiploom",
			Grass.Instance, Flying.Instance,
			0.6,
			1.0,
			new PokemonStats(
				55, // HPs
				45, 50, // Attack & Defense
				45, 65, // Spacial Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Tail-Whip",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Flash",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Cotton-Spore",
				"Protect",
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
				"Sunny-Day",
				"Psych-Up",
				"Memento",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Silver-Wind",
				"Bullet-Seed",
				"Aerial-Ace",
				"Bounce",
				"Natural-Gift",
				"U-Turn",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Rage-Powder",
				"Round",
				"Acrobatics",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}