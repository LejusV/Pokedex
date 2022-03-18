using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dewgong Species to store common natural stats of all Dewgongs
	#region SpeciesDewgong
	public class SpeciesDewgong : PokemonSpecies
	{
#nullable enable
		private static SpeciesDewgong? _instance = null;
#nullable restore
        public static SpeciesDewgong Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDewgong();
                }
                return _instance;
            }
        }

		#region SpeciesDewgong Constructor
		public SpeciesDewgong() : base(
			87,
			"Dewgong",
			1.7,
			120.0,
			90, // HPs
			70, 80, // Attack & Defense
			70, 95, // Special Attack & Defense
			70		
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
				"Pay-Day",
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Strength",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Thief",
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
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Sheer-Cold",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Echoed-Voice",
				"Frost-Breath",
				"Drill-Run",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Dewgong PokemonInstance Class
	#region Dewgong
	public class DewgongInstance : PokemonInstance
	{
		#region Dewgong Constructors
		/// <summary>
		/// Dewgong Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DewgongInstance(string nickname, int level)
		: base(
				SpeciesDewgong.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewgong Builder only waiting for a Level
		/// </summary>
		public DewgongInstance(int level)
		: base(
				SpeciesDewgong.Instance, // PokemonInstance Species
				"Dewgong", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewgong Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DewgongInstance() : base(
			SpeciesDewgong.Instance, // PokemonInstance Species
			Water.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}