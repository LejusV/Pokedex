using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Paras Species to store common natural stats of all Parass
	#region ParasSpecies
	public class ParasSpecies : PokemonSpecies
	{
#nullable enable
		private static ParasSpecies? _instance = null;
#nullable restore
        public static ParasSpecies Instance => _instance ?? (_instance = new ParasSpecies());

		#region ParasSpecies Constructor
		public ParasSpecies() : base(
			46,
			"Paras",
			Bug.Instance, Grass.Instance,
			0.3,
			5.4,
			new PokemonStats(
				35, // HPs
				70, 55, // Attack & Defense
				45, 55, // Spacial Attack & Defense
				25 // Speed
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
				"Psybeam",
				"Counter",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"String-Shot",
				"Dig",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
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
				"Flail",
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
				"Pursuit",
				"Sweet-Scent",
				"Metal-Claw",
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
				"Cross-Poison",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Hone-Claws",
				"Wide-Guard",
				"Venoshock",
				"Rage-Powder",
				"After-You",
				"Round",
				"Struggle-Bug",
				"Rototiller",
				"Fell-Stinger",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}