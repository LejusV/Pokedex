using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magearna Species to store common natural stats of all Magearnas
	#region SpeciesMagearna
	public class SpeciesMagearna : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagearna? _instance = null;
#nullable restore
        public static SpeciesMagearna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagearna();
                }
                return _instance;
            }
        }

		#region SpeciesMagearna Constructor
		public SpeciesMagearna() : base(
			"Magearna",
			1.0,
			80.5,
			80, // HPs
			95, 115, // Attack & Defense
			130, 115, // Special Attack & Defense
			65		
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
				"Sonic-Boom",
				"Ice-Beam",
				"Psybeam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Explosion",
				"Substitute",
				"Mind-Reader",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Shadow-Ball",
				"Helping-Hand",
				"Brick-Break",
				"Iron-Defense",
				"Calm-Mind",
				"Gyro-Ball",
				"Embargo",
				"Trump-Card",
				"Lucky-Chant",
				"Heart-Swap",
				"Aura-Sphere",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
				"Grass-Knot",
				"Charge-Beam",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Shift-Gear",
				"Volt-Switch",
				"Crafty-Shield",
				"Confide",
				"Dazzling-Gleam",
				"Gear-Up",
				"Fleur-Cannon"
			};
		}
		#endregion
	}
	#endregion

	//Magearna PokemonInstance Class
	#region Magearna
	public class MagearnaInstance : PokemonInstance
	{
		#region Magearna Constructors
		/// <summary>
		/// Magearna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagearnaInstance(string nickname, int level)
		: base(
				801,
				SpeciesMagearna.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magearna Builder only waiting for a Level
		/// </summary>
		public MagearnaInstance(int level)
		: base(
				801,
				SpeciesMagearna.Instance, // PokemonInstance Species
				"Magearna", level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magearna Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Magearna() : base(
			801,
			SpeciesMagearna.Instance, // PokemonInstance Species
			Steel.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}