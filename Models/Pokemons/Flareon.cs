using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Flareon Species to store common natural stats of all Flareons
	#region SpeciesFlareon
	public class SpeciesFlareon : PokemonSpecies
	{
#nullable enable
		private static SpeciesFlareon? _instance = null;
#nullable restore
        public static SpeciesFlareon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFlareon();
                }
                return _instance;
            }
        }

		#region SpeciesFlareon Constructor
		public SpeciesFlareon() : base(
			136,
			"Flareon",
			0.9,
			25.0,
			65, // HPs
			130, 60, // Attack & Defense
			95, 110, // Special Attack & Defense
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Smog",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Covet",
				"Natural-Gift",
				"Last-Resort",
				"Flare-Blitz",
				"Giga-Impact",
				"Fire-Fang",
				"Lava-Plume",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Flareon PokemonInstance Class
	#region Flareon
	public class FlareonInstance : PokemonInstance
	{
		#region Flareon Constructors
		/// <summary>
		/// Flareon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FlareonInstance(string nickname, int level)
		: base(
				SpeciesFlareon.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flareon Builder only waiting for a Level
		/// </summary>
		public FlareonInstance(int level)
		: base(
				SpeciesFlareon.Instance, // PokemonInstance Species
				"Flareon", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flareon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FlareonInstance() : base(
			SpeciesFlareon.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}