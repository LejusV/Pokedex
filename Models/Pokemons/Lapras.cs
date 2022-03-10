using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lapras Species to store common natural stats of all Laprass
	#region SpeciesLapras
	public class SpeciesLapras : PokemonSpecies
	{
#nullable enable
		private static SpeciesLapras? _instance = null;
#nullable restore
        public static SpeciesLapras Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLapras();
                }
                return _instance;
            }
        }

		#region SpeciesLapras Constructor
		public SpeciesLapras() : base(
			"Lapras",
			2.5,
			220.0,
			130, // HPs
			85, 80, // Attack & Defense
			85, 95, // Special Attack & Defense
			60		
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
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Sing",
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
				"Solar-Beam",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder",
				"Fissure",
				"Toxic",
				"Psychic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Dream-Eater",
				"Psywave",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Foresight",
				"Perish-Song",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Tickle",
				"Signal-Beam",
				"Sheer-Cold",
				"Block",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Zen-Headbutt",
				"Iron-Head",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Drill-Run",
				"Freeze-Dry",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Lapras PokemonInstance Class
	#region Lapras
	public class LaprasInstance : PokemonInstance
	{
		#region Lapras Constructors
		/// <summary>
		/// Lapras Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LaprasInstance(string nickname, int level)
		: base(
				131,
				SpeciesLapras.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lapras Builder only waiting for a Level
		/// </summary>
		public LaprasInstance(int level)
		: base(
				131,
				SpeciesLapras.Instance, // PokemonInstance Species
				"Lapras", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lapras Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Lapras() : base(
			131,
			SpeciesLapras.Instance, // PokemonInstance Species
			Water.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}