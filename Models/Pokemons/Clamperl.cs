using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Clamperl Species to store common natural stats of all Clamperls
	#region SpeciesClamperl
	public class SpeciesClamperl : PokemonSpecies
	{
#nullable enable
		private static SpeciesClamperl? _instance = null;
#nullable restore
        public static SpeciesClamperl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesClamperl();
                }
                return _instance;
            }
        }

		#region SpeciesClamperl Constructor
		public SpeciesClamperl() : base(
			"Clamperl",
			0.4,
			52.5,
			35, // HPs
			64, 85, // Attack & Defense
			74, 55, // Special Attack & Defense
			32		
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
				"Body-Slam",
				"Double-Edge",
				"Supersonic",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Barrier",
				"Waterfall",
				"Clamp",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Muddy-Water",
				"Iron-Defense",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
				"Captivate",
				"Round",
				"Scald",
				"Shell-Smash",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Clamperl PokemonInstance Class
	#region Clamperl
	public class ClamperlInstance : PokemonInstance
	{
		#region Clamperl Constructors
		/// <summary>
		/// Clamperl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ClamperlInstance(string nickname, int level)
		: base(
				366,
				SpeciesClamperl.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clamperl Builder only waiting for a Level
		/// </summary>
		public ClamperlInstance(int level)
		: base(
				366,
				SpeciesClamperl.Instance, // PokemonInstance Species
				"Clamperl", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clamperl Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Clamperl() : base(
			366,
			SpeciesClamperl.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}