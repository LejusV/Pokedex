using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dubwool Species to store common natural stats of all Dubwools
	#region SpeciesDubwool
	public class SpeciesDubwool : PokemonSpecies
	{
#nullable enable
		private static SpeciesDubwool? _instance = null;
#nullable restore
        public static SpeciesDubwool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDubwool();
                }
                return _instance;
            }
        }

		#region SpeciesDubwool Constructor
		public SpeciesDubwool() : base(
			832,
			"Dubwool",
			1.3,
			43.0,
			72, // HPs
			80, 100, // Attack & Defense
			60, 90, // Special Attack & Defense
			88		
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
				
			};
		}
		#endregion
	}
	#endregion

	//Dubwool PokemonInstance Class
	#region Dubwool
	public class DubwoolInstance : PokemonInstance
	{
		#region Dubwool Constructors
		/// <summary>
		/// Dubwool Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DubwoolInstance(string nickname, int level)
		: base(
				SpeciesDubwool.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dubwool Builder only waiting for a Level
		/// </summary>
		public DubwoolInstance(int level)
		: base(
				SpeciesDubwool.Instance, // PokemonInstance Species
				"Dubwool", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dubwool Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DubwoolInstance() : base(
			SpeciesDubwool.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}