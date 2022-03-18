using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Klinklang Species to store common natural stats of all Klinklangs
	#region SpeciesKlinklang
	public class SpeciesKlinklang : PokemonSpecies
	{
#nullable enable
		private static SpeciesKlinklang? _instance = null;
#nullable restore
        public static SpeciesKlinklang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKlinklang();
                }
                return _instance;
            }
        }

		#region SpeciesKlinklang Constructor
		public SpeciesKlinklang() : base(
			601,
			"Klinklang",
			0.6,
			81.0,
			60, // HPs
			100, 115, // Attack & Defense
			70, 85, // Special Attack & Defense
			90		
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
				"Thunder",
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
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Trick-Room",
				"Discharge",
				"Charge-Beam",
				"Autotomize",
				"Round",
				"Shift-Gear",
				"Volt-Switch",
				"Wild-Charge",
				"Gear-Grind",
				"Confide",
				"Magnetic-Flux",
				"Gear-Up"
			};
		}
		#endregion
	}
	#endregion

	//Klinklang PokemonInstance Class
	#region Klinklang
	public class KlinklangInstance : PokemonInstance
	{
		#region Klinklang Constructors
		/// <summary>
		/// Klinklang Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KlinklangInstance(string nickname, int level)
		: base(
				SpeciesKlinklang.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klinklang Builder only waiting for a Level
		/// </summary>
		public KlinklangInstance(int level)
		: base(
				SpeciesKlinklang.Instance, // PokemonInstance Species
				"Klinklang", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klinklang Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KlinklangInstance() : base(
			SpeciesKlinklang.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}