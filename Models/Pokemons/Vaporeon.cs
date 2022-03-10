using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vaporeon Species to store common natural stats of all Vaporeons
	#region SpeciesVaporeon
	public class SpeciesVaporeon : PokemonSpecies
	{
#nullable enable
		private static SpeciesVaporeon? _instance = null;
#nullable restore
        public static SpeciesVaporeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVaporeon();
                }
                return _instance;
            }
        }

		#region SpeciesVaporeon Constructor
		public SpeciesVaporeon() : base(
			"Vaporeon",
			1.0,
			29.0,
			130, // HPs
			65, 60, // Attack & Defense
			110, 95, // Special Attack & Defense
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
				"Bite",
				"Roar",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Haze",
				"Reflect",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
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
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Signal-Beam",
				"Muddy-Water",
				"Covet",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Last-Resort",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Vaporeon PokemonInstance Class
	#region Vaporeon
	public class VaporeonInstance : PokemonInstance
	{
		#region Vaporeon Constructors
		/// <summary>
		/// Vaporeon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VaporeonInstance(string nickname, int level)
		: base(
				134,
				SpeciesVaporeon.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vaporeon Builder only waiting for a Level
		/// </summary>
		public VaporeonInstance(int level)
		: base(
				134,
				SpeciesVaporeon.Instance, // PokemonInstance Species
				"Vaporeon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vaporeon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Vaporeon() : base(
			134,
			SpeciesVaporeon.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}