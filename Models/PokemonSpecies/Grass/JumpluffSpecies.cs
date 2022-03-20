using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Jumpluff Species to store common natural stats of all Jumpluffs
	#region JumpluffSpecies
	public class JumpluffSpecies : PokemonSpecies
	{
#nullable enable
		private static JumpluffSpecies? _instance = null;
#nullable restore
        public static JumpluffSpecies Instance => _instance ?? (_instance = new JumpluffSpecies());

		#region JumpluffSpecies Constructor
		public JumpluffSpecies() : base(
			189,
			"Jumpluff",
			Grass.Instance, Flying.Instance,
			0.8,
			3.0,
			new PokemonStats(
				75, // HPs
				55, 70, // Attack & Defense
				55, 95, // Spacial Attack & Defense
				110 // Speed
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
				"Hyper-Beam",
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
				"Giga-Impact",
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