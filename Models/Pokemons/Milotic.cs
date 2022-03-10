using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Milotic Species to store common natural stats of all Milotics
	#region SpeciesMilotic
	public class SpeciesMilotic : PokemonSpecies
	{
#nullable enable
		private static SpeciesMilotic? _instance = null;
#nullable restore
        public static SpeciesMilotic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMilotic();
                }
                return _instance;
            }
        }

		#region SpeciesMilotic Constructor
		public SpeciesMilotic() : base(
			"Milotic",
			6.2,
			162.0,
			95, // HPs
			60, 79, // Attack & Defense
			100, 125, // Special Attack & Defense
			81		
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
				"Bind",
				"Body-Slam",
				"Wrap",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Psych-Up",
				"Whirlpool",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Ring",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Giga-Impact",
				"Avalanche",
				"Iron-Head",
				"Captivate",
				"Coil",
				"Round",
				"Scald",
				"Bulldoze",
				"Dragon-Tail",
				"Disarming-Voice",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Milotic PokemonInstance Class
	#region Milotic
	public class MiloticInstance : PokemonInstance
	{
		#region Milotic Constructors
		/// <summary>
		/// Milotic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MiloticInstance(string nickname, int level)
		: base(
				350,
				SpeciesMilotic.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milotic Builder only waiting for a Level
		/// </summary>
		public MiloticInstance(int level)
		: base(
				350,
				SpeciesMilotic.Instance, // PokemonInstance Species
				"Milotic", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milotic Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Milotic() : base(
			350,
			SpeciesMilotic.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}