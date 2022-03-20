using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Exeggutor Species to store common natural stats of all Exeggutors
	#region ExeggutorSpecies
	public class ExeggutorSpecies : PokemonSpecies
	{
#nullable enable
		private static ExeggutorSpecies? _instance = null;
#nullable restore
        public static ExeggutorSpecies Instance => _instance ?? (_instance = new ExeggutorSpecies());

		#region ExeggutorSpecies Constructor
		public ExeggutorSpecies() : base(
			103,
			"Exeggutor",
			Grass.Instance, Psychic.Instance,
			2.0,
			120.0,
			new PokemonStats(
				95, // HPs
				95, 85, // Attack & Defense
				125, 75, // Spacial Attack & Defense
				55 // Speed
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
				"Stomp",
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Mega-Drain",
				"Solar-Beam",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Egg-Bomb",
				"Dream-Eater",
				"Barrage",
				"Flash",
				"Psywave",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Facade",
				"Nature-Power",
				"Skill-Swap",
				"Secret-Power",
				"Bullet-Seed",
				"Block",
				"Gravity",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Wood-Hammer",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}