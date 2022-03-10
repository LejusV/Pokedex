using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Starmie Species to store common natural stats of all Starmies
	#region SpeciesStarmie
	public class SpeciesStarmie : PokemonSpecies
	{
#nullable enable
		private static SpeciesStarmie? _instance = null;
#nullable restore
        public static SpeciesStarmie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStarmie();
                }
                return _instance;
            }
        }

		#region SpeciesStarmie Constructor
		public SpeciesStarmie() : base(
			"Starmie",
			1.1,
			80.0,
			60, // HPs
			75, 85, // Attack & Defense
			100, 85, // Special Attack & Defense
			115		
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Recover",
				"Harden",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Rapid-Spin",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Psych-Up",
				"Whirlpool",
				"Hail",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Water-Pulse",
				"Gravity",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Giga-Impact",
				"Avalanche",
				"Flash-Cannon",
				"Trick-Room",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Scald",
				"Confide",
				"Dazzling-Gleam",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion

	//Starmie PokemonInstance Class
	#region Starmie
	public class StarmieInstance : PokemonInstance
	{
		#region Starmie Constructors
		/// <summary>
		/// Starmie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StarmieInstance(string nickname, int level)
		: base(
				121,
				SpeciesStarmie.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starmie Builder only waiting for a Level
		/// </summary>
		public StarmieInstance(int level)
		: base(
				121,
				SpeciesStarmie.Instance, // PokemonInstance Species
				"Starmie", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starmie Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Starmie() : base(
			121,
			SpeciesStarmie.Instance, // PokemonInstance Species
			Water.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}