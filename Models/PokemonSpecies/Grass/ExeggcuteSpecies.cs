using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Exeggcute Species to store common natural stats of all Exeggcutes
	#region ExeggcuteSpecies
	public class ExeggcuteSpecies : PokemonSpecies
	{
#nullable enable
		private static ExeggcuteSpecies? _instance = null;
#nullable restore
        public static ExeggcuteSpecies Instance => _instance ?? (_instance = new ExeggcuteSpecies());

		#region ExeggcuteSpecies Constructor
		public ExeggcuteSpecies() : base(
			102,
			"Exeggcute",
			Grass.Instance, Psychic.Instance,
			0.4,
			2.5,
			new PokemonStats(
				60, // HPs
				40, 80, // Attack & Defense
				60, 45, // Spacial Attack & Defense
				40 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
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
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Skill-Swap",
				"Secret-Power",
				"Extrasensory",
				"Bullet-Seed",
				"Block",
				"Gravity",
				"Natural-Gift",
				"Lucky-Chant",
				"Power-Swap",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Trick-Room",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Telekinesis",
				"Round",
				"Bestow",
				"Grassy-Terrain",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}