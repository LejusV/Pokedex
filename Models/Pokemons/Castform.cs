using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Castform Species to store common natural stats of all Castforms
	#region SpeciesCastform
	public class SpeciesCastform : PokemonSpecies
	{
#nullable enable
		private static SpeciesCastform? _instance = null;
#nullable restore
        public static SpeciesCastform Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCastform();
                }
                return _instance;
            }
        }

		#region SpeciesCastform Constructor
		public SpeciesCastform() : base(
			"Castform",
			0.3,
			0.8,
			70, // HPs
			70, 70, // Attack & Defense
			70, 70, // Special Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Disable",
				"Ember",
				"Flamethrower",
				"Water-Gun",
				"Hydro-Pump",
				"Ice-Beam",
				"Blizzard",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Hail",
				"Facade",
				"Secret-Power",
				"Weather-Ball",
				"Cosmic-Power",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Tailwind",
				"Lucky-Chant",
				"Guard-Swap",
				"Last-Resort",
				"Energy-Ball",
				"Avalanche",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Clear-Smog",
				"Scald",
				"Hex",
				"Incinerate",
				"Reflect-Type",
				"Retaliate",
				"Work-Up",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Castform PokemonInstance Class
	#region Castform
	public class CastformInstance : PokemonInstance
	{
		#region Castform Constructors
		/// <summary>
		/// Castform Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CastformInstance(string nickname, int level)
		: base(
				351,
				SpeciesCastform.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Castform Builder only waiting for a Level
		/// </summary>
		public CastformInstance(int level)
		: base(
				351,
				SpeciesCastform.Instance, // PokemonInstance Species
				"Castform", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Castform Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Castform() : base(
			351,
			SpeciesCastform.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}