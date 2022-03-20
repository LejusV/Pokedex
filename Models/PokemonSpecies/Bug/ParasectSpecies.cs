using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Parasect Species to store common natural stats of all Parasects
	#region ParasectSpecies
	public class ParasectSpecies : PokemonSpecies
	{
#nullable enable
		private static ParasectSpecies? _instance = null;
#nullable restore
        public static ParasectSpecies Instance => _instance ?? (_instance = new ParasectSpecies());

		#region ParasectSpecies Constructor
		public ParasectSpecies() : base(
			47,
			"Parasect",
			Bug.Instance, Grass.Instance,
			1.0,
			29.5,
			new PokemonStats(
				60, // HPs
				95, 80, // Attack & Defense
				60, 80, // Spacial Attack & Defense
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Counter",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"String-Shot",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Skull-Bash",
				"Leech-Life",
				"Spore",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Aromatherapy",
				"Bullet-Seed",
				"Aerial-Ace",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Cross-Poison",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Rage-Powder",
				"After-You",
				"Round",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}