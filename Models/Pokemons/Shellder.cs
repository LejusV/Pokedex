using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shellder Species to store common natural stats of all Shellders
	#region SpeciesShellder
	public class SpeciesShellder : PokemonSpecies
	{
#nullable enable
		private static SpeciesShellder? _instance = null;
#nullable restore
        public static SpeciesShellder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShellder();
                }
                return _instance;
            }
        }

		#region SpeciesShellder Constructor
		public SpeciesShellder() : base(
			90,
			"Shellder",
			0.3,
			4.0,
			30, // HPs
			65, 100, // Attack & Defense
			45, 25, // Special Attack & Defense
			40		
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
				"Twineedle",
				"Leer",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Toxic",
				"Rage",
				"Teleport",
				"Mimic",
				"Screech",
				"Double-Team",
				"Withdraw",
				"Barrier",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Clamp",
				"Swift",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Icicle-Spear",
				"Iron-Defense",
				"Mud-Shot",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Aqua-Ring",
				"Avalanche",
				"Ice-Shard",
				"Captivate",
				"Round",
				"Shell-Smash",
				"Razor-Shell",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Shellder PokemonInstance Class
	#region Shellder
	public class ShellderInstance : PokemonInstance
	{
		#region Shellder Constructors
		/// <summary>
		/// Shellder Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShellderInstance(string nickname, int level)
		: base(
				SpeciesShellder.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellder Builder only waiting for a Level
		/// </summary>
		public ShellderInstance(int level)
		: base(
				SpeciesShellder.Instance, // PokemonInstance Species
				"Shellder", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellder Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ShellderInstance() : base(
			SpeciesShellder.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}