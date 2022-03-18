using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sinistea Species to store common natural stats of all Sinisteas
	#region SpeciesSinistea
	public class SpeciesSinistea : PokemonSpecies
	{
#nullable enable
		private static SpeciesSinistea? _instance = null;
#nullable restore
        public static SpeciesSinistea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSinistea();
                }
                return _instance;
            }
        }

		#region SpeciesSinistea Constructor
		public SpeciesSinistea() : base(
			854,
			"Sinistea",
			0.1,
			0.2,
			40, // HPs
			45, 45, // Attack & Defense
			74, 54, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Sinistea PokemonInstance Class
	#region Sinistea
	public class SinisteaInstance : PokemonInstance
	{
		#region Sinistea Constructors
		/// <summary>
		/// Sinistea Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SinisteaInstance(string nickname, int level)
		: base(
				SpeciesSinistea.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sinistea Builder only waiting for a Level
		/// </summary>
		public SinisteaInstance(int level)
		: base(
				SpeciesSinistea.Instance, // PokemonInstance Species
				"Sinistea", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sinistea Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SinisteaInstance() : base(
			SpeciesSinistea.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}