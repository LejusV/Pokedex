using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Jolteon Species to store common natural stats of all Jolteons
	#region SpeciesJolteon
	public class SpeciesJolteon : PokemonSpecies
	{
#nullable enable
		private static SpeciesJolteon? _instance = null;
#nullable restore
        public static SpeciesJolteon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesJolteon();
                }
                return _instance;
            }
        }

		#region SpeciesJolteon Constructor
		public SpeciesJolteon() : base(
			"Jolteon",
			0.8,
			24.5,
			65, // HPs
			65, 60, // Attack & Defense
			110, 95, // Special Attack & Defense
			130		
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
				"Double-Kick",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Pin-Missile",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
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
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Last-Resort",
				"Magnet-Rise",
				"Giga-Impact",
				"Thunder-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Volt-Switch",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Jolteon PokemonInstance Class
	#region Jolteon
	public class JolteonInstance : PokemonInstance
	{
		#region Jolteon Constructors
		/// <summary>
		/// Jolteon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JolteonInstance(string nickname, int level)
		: base(
				135,
				SpeciesJolteon.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jolteon Builder only waiting for a Level
		/// </summary>
		public JolteonInstance(int level)
		: base(
				135,
				SpeciesJolteon.Instance, // PokemonInstance Species
				"Jolteon", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jolteon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Jolteon() : base(
			135,
			SpeciesJolteon.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}