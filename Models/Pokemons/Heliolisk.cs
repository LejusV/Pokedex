using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Heliolisk Species to store common natural stats of all Heliolisks
	#region SpeciesHeliolisk
	public class SpeciesHeliolisk : PokemonSpecies
	{
#nullable enable
		private static SpeciesHeliolisk? _instance = null;
#nullable restore
        public static SpeciesHeliolisk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHeliolisk();
                }
                return _instance;
            }
        }

		#region SpeciesHeliolisk Constructor
		public SpeciesHeliolisk() : base(
			"Heliolisk",
			1.0,
			21.0,
			62, // HPs
			55, 52, // Attack & Defense
			109, 94, // Special Attack & Defense
			109		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Razor-Wind",
				"Cut",
				"Surf",
				"Hyper-Beam",
				"Low-Kick",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Facade",
				"Charge",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Signal-Beam",
				"Shock-Wave",
				"U-Turn",
				"Magnet-Rise",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Grass-Knot",
				"Charge-Beam",
				"Low-Sweep",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Dragon-Tail",
				"Electroweb",
				"Wild-Charge",
				"Parabolic-Charge",
				"Electrify",
				"Confide",
				"Eerie-Impulse",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Heliolisk PokemonInstance Class
	#region Heliolisk
	public class HelioliskInstance : PokemonInstance
	{
		#region Heliolisk Constructors
		/// <summary>
		/// Heliolisk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HelioliskInstance(string nickname, int level)
		: base(
				695,
				SpeciesHeliolisk.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heliolisk Builder only waiting for a Level
		/// </summary>
		public HelioliskInstance(int level)
		: base(
				695,
				SpeciesHeliolisk.Instance, // PokemonInstance Species
				"Heliolisk", level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heliolisk Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Heliolisk() : base(
			695,
			SpeciesHeliolisk.Instance, // PokemonInstance Species
			Electric.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}