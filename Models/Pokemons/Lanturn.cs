using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lanturn Species to store common natural stats of all Lanturns
	#region SpeciesLanturn
	public class SpeciesLanturn : PokemonSpecies
	{
#nullable enable
		private static SpeciesLanturn? _instance = null;
#nullable restore
        public static SpeciesLanturn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLanturn();
                }
                return _instance;
            }
        }

		#region SpeciesLanturn Constructor
		public SpeciesLanturn() : base(
			171,
			"Lanturn",
			1.2,
			22.5,
			125, // HPs
			58, 58, // Attack & Defense
			76, 76, // Special Attack & Defense
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
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Waterfall",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
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
				"Aqua-Tail",
				"Giga-Impact",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Scald",
				"Volt-Switch",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Eerie-Impulse",
				"Dazzling-Gleam",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion

	//Lanturn PokemonInstance Class
	#region Lanturn
	public class LanturnInstance : PokemonInstance
	{
		#region Lanturn Constructors
		/// <summary>
		/// Lanturn Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LanturnInstance(string nickname, int level)
		: base(
				SpeciesLanturn.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lanturn Builder only waiting for a Level
		/// </summary>
		public LanturnInstance(int level)
		: base(
				SpeciesLanturn.Instance, // PokemonInstance Species
				"Lanturn", level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lanturn Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LanturnInstance() : base(
			SpeciesLanturn.Instance, // PokemonInstance Species
			Water.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}