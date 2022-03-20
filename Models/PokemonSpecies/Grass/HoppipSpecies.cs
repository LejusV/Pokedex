using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hoppip Species to store common natural stats of all Hoppips
	#region HoppipSpecies
	public class HoppipSpecies : PokemonSpecies
	{
#nullable enable
		private static HoppipSpecies? _instance = null;
#nullable restore
        public static HoppipSpecies Instance => _instance ?? (_instance = new HoppipSpecies());

		#region HoppipSpecies Constructor
		public HoppipSpecies() : base(
			187,
			"Hoppip",
			Grass.Instance, Flying.Instance,
			0.4,
			0.5,
			new PokemonStats(
				35, // HPs
				35, 40, // Attack & Defense
				35, 55, // Spacial Attack & Defense
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
				"Pay-Day",
				"Swords-Dance",
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Confusion",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Amnesia",
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
				"Encore",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Memento",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Aromatherapy",
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
				"Cotton-Guard",
				"Grassy-Terrain",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Strength-Sap"
			};
		}
		#endregion
	}
	#endregion
}