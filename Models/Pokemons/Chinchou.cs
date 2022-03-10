using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chinchou Species to store common natural stats of all Chinchous
	#region SpeciesChinchou
	public class SpeciesChinchou : PokemonSpecies
	{
#nullable enable
		private static SpeciesChinchou? _instance = null;
#nullable restore
        public static SpeciesChinchou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChinchou();
                }
                return _instance;
            }
        }

		#region SpeciesChinchou Constructor
		public SpeciesChinchou() : base(
			"Chinchou",
			0.5,
			12.0,
			75, // HPs
			38, 38, // Attack & Defense
			56, 56, // Special Attack & Defense
			67		
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
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Waterfall",
				"Amnesia",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Charge",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Sucker-Punch",
				"Aqua-Ring",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Soak",
				"Round",
				"Scald",
				"Volt-Switch",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Chinchou PokemonInstance Class
	#region Chinchou
	public class ChinchouInstance : PokemonInstance
	{
		#region Chinchou Constructors
		/// <summary>
		/// Chinchou Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChinchouInstance(string nickname, int level)
		: base(
				170,
				SpeciesChinchou.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chinchou Builder only waiting for a Level
		/// </summary>
		public ChinchouInstance(int level)
		: base(
				170,
				SpeciesChinchou.Instance, // PokemonInstance Species
				"Chinchou", level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chinchou Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Chinchou() : base(
			170,
			SpeciesChinchou.Instance, // PokemonInstance Species
			Water.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}