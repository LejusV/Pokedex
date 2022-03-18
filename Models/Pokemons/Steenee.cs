using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Steenee Species to store common natural stats of all Steenees
	#region SpeciesSteenee
	public class SpeciesSteenee : PokemonSpecies
	{
#nullable enable
		private static SpeciesSteenee? _instance = null;
#nullable restore
        public static SpeciesSteenee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSteenee();
                }
                return _instance;
            }
        }

		#region SpeciesSteenee Constructor
		public SpeciesSteenee() : base(
			762,
			"Steenee",
			0.7,
			8.2,
			52, // HPs
			40, 48, // Attack & Defense
			40, 48, // Special Attack & Defense
			62		
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
				"Double-Slap",
				"Stomp",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Splash",
				"Rest",
				"Substitute",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Teeter-Dance",
				"Aromatherapy",
				"Magical-Leaf",
				"Payback",
				"Fling",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Play-Nice",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Steenee PokemonInstance Class
	#region Steenee
	public class SteeneeInstance : PokemonInstance
	{
		#region Steenee Constructors
		/// <summary>
		/// Steenee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SteeneeInstance(string nickname, int level)
		: base(
				SpeciesSteenee.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steenee Builder only waiting for a Level
		/// </summary>
		public SteeneeInstance(int level)
		: base(
				SpeciesSteenee.Instance, // PokemonInstance Species
				"Steenee", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steenee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SteeneeInstance() : base(
			SpeciesSteenee.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}