using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magikarp Species to store common natural stats of all Magikarps
	#region SpeciesMagikarp
	public class SpeciesMagikarp : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagikarp? _instance = null;
#nullable restore
        public static SpeciesMagikarp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagikarp();
                }
                return _instance;
            }
        }

		#region SpeciesMagikarp Constructor
		public SpeciesMagikarp() : base(
			129,
			"Magikarp",
			0.9,
			10.0,
			20, // HPs
			10, 55, // Attack & Defense
			15, 20, // Special Attack & Defense
			80		
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
				"Splash",
				"Flail",
				"Bounce"
			};
		}
		#endregion
	}
	#endregion

	//Magikarp PokemonInstance Class
	#region Magikarp
	public class MagikarpInstance : PokemonInstance
	{
		#region Magikarp Constructors
		/// <summary>
		/// Magikarp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagikarpInstance(string nickname, int level)
		: base(
				SpeciesMagikarp.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magikarp Builder only waiting for a Level
		/// </summary>
		public MagikarpInstance(int level)
		: base(
				SpeciesMagikarp.Instance, // PokemonInstance Species
				"Magikarp", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magikarp Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MagikarpInstance() : base(
			SpeciesMagikarp.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}