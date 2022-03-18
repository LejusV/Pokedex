using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Klang Species to store common natural stats of all Klangs
	#region SpeciesKlang
	public class SpeciesKlang : PokemonSpecies
	{
#nullable enable
		private static SpeciesKlang? _instance = null;
#nullable restore
        public static SpeciesKlang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKlang();
                }
                return _instance;
            }
        }

		#region SpeciesKlang Constructor
		public SpeciesKlang() : base(
			600,
			"Klang",
			0.6,
			51.0,
			60, // HPs
			80, 95, // Attack & Defense
			70, 85, // Special Attack & Defense
			50		
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

	//Klang PokemonInstance Class
	#region Klang
	public class KlangInstance : PokemonInstance
	{
		#region Klang Constructors
		/// <summary>
		/// Klang Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KlangInstance(string nickname, int level)
		: base(
				SpeciesKlang.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klang Builder only waiting for a Level
		/// </summary>
		public KlangInstance(int level)
		: base(
				SpeciesKlang.Instance, // PokemonInstance Species
				"Klang", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klang Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KlangInstance() : base(
			SpeciesKlang.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}