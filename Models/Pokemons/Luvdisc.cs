using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Luvdisc Species to store common natural stats of all Luvdiscs
	#region SpeciesLuvdisc
	public class SpeciesLuvdisc : PokemonSpecies
	{
#nullable enable
		private static SpeciesLuvdisc? _instance = null;
#nullable restore
        public static SpeciesLuvdisc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLuvdisc();
                }
                return _instance;
            }
        }

		#region SpeciesLuvdisc Constructor
		public SpeciesLuvdisc() : base(
			370,
			"Luvdisc",
			0.6,
			8.7,
			43, // HPs
			30, 55, // Attack & Defense
			40, 65, // Special Attack & Defense
			97		
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
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Lucky-Chant",
				"Aqua-Ring",
				"Captivate",
				"Aqua-Jet",
				"Soak",
				"Entrainment",
				"Round",
				"Scald",
				"Heal-Pulse",
				"Heart-Stamp",
				"Draining-Kiss",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Luvdisc PokemonInstance Class
	#region Luvdisc
	public class LuvdiscInstance : PokemonInstance
	{
		#region Luvdisc Constructors
		/// <summary>
		/// Luvdisc Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LuvdiscInstance(string nickname, int level)
		: base(
				SpeciesLuvdisc.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luvdisc Builder only waiting for a Level
		/// </summary>
		public LuvdiscInstance(int level)
		: base(
				SpeciesLuvdisc.Instance, // PokemonInstance Species
				"Luvdisc", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luvdisc Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LuvdiscInstance() : base(
			SpeciesLuvdisc.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}