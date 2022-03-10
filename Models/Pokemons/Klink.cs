using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Klink Species to store common natural stats of all Klinks
	#region SpeciesKlink
	public class SpeciesKlink : PokemonSpecies
	{
#nullable enable
		private static SpeciesKlink? _instance = null;
#nullable restore
        public static SpeciesKlink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKlink();
                }
                return _instance;
            }
        }

		#region SpeciesKlink Constructor
		public SpeciesKlink() : base(
			"Klink",
			0.3,
			21.0,
			40, // HPs
			55, 70, // Attack & Defense
			45, 60, // Special Attack & Defense
			30		
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
				"Vice-Grip",
				"Bind",
				"Hyper-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Screech",
				"Double-Team",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Charge",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Metal-Sound",
				"Signal-Beam",
				"Iron-Defense",
				"Shock-Wave",
				"Gravity",
				"Magnet-Rise",
				"Rock-Polish",
				"Mirror-Shot",
				"Flash-Cannon",
				"Discharge",
				"Charge-Beam",
				"Autotomize",
				"Round",
				"Shift-Gear",
				"Volt-Switch",
				"Wild-Charge",
				"Gear-Grind",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Klink PokemonInstance Class
	#region Klink
	public class KlinkInstance : PokemonInstance
	{
		#region Klink Constructors
		/// <summary>
		/// Klink Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KlinkInstance(string nickname, int level)
		: base(
				599,
				SpeciesKlink.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klink Builder only waiting for a Level
		/// </summary>
		public KlinkInstance(int level)
		: base(
				599,
				SpeciesKlink.Instance, // PokemonInstance Species
				"Klink", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klink Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Klink() : base(
			599,
			SpeciesKlink.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}