using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Staryu Species to store common natural stats of all Staryus
	#region SpeciesStaryu
	public class SpeciesStaryu : PokemonSpecies
	{
#nullable enable
		private static SpeciesStaryu? _instance = null;
#nullable restore
        public static SpeciesStaryu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStaryu();
                }
                return _instance;
            }
        }

		#region SpeciesStaryu Constructor
		public SpeciesStaryu() : base(
			"Staryu",
			0.8,
			34.5,
			30, // HPs
			45, 55, // Attack & Defense
			70, 55, // Special Attack & Defense
			85		
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
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
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
				"Minimize",
				"Confuse-Ray",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
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
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Dive",
				"Camouflage",
				"Cosmic-Power",
				"Signal-Beam",
				"Water-Pulse",
				"Gravity",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Power-Gem",
				"Flash-Cannon",
				"Round",
				"Scald",
				"Reflect-Type",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Staryu PokemonInstance Class
	#region Staryu
	public class StaryuInstance : PokemonInstance
	{
		#region Staryu Constructors
		/// <summary>
		/// Staryu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StaryuInstance(string nickname, int level)
		: base(
				120,
				SpeciesStaryu.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staryu Builder only waiting for a Level
		/// </summary>
		public StaryuInstance(int level)
		: base(
				120,
				SpeciesStaryu.Instance, // PokemonInstance Species
				"Staryu", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staryu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Staryu() : base(
			120,
			SpeciesStaryu.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}