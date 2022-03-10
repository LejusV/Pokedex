using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Indeedee-Male Species to store common natural stats of all Indeedee-Males
	#region SpeciesIndeedee-Male
	public class SpeciesIndeedeeMale : PokemonSpecies
	{
#nullable enable
		private static SpeciesIndeedeeMale? _instance = null;
#nullable restore
        public static SpeciesIndeedeeMale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesIndeedeeMale();
                }
                return _instance;
            }
        }

		#region SpeciesIndeedee-Male Constructor
		public SpeciesIndeedeeMale() : base(
			"Indeedee-Male",
			0.9,
			28.0,
			60, // HPs
			65, 55, // Attack & Defense
			105, 95, // Special Attack & Defense
			95		
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

	//Indeedee-Male PokemonInstance Class
	#region Indeedee-Male
	public class IndeedeeMaleInstance : PokemonInstance
	{
		#region Indeedee-Male Constructors
		/// <summary>
		/// Indeedee-Male Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public IndeedeeMaleInstance(string nickname, int level)
		: base(
				876,
				SpeciesIndeedeeMale.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Indeedee-Male Builder only waiting for a Level
		/// </summary>
		public IndeedeeMaleInstance(int level)
		: base(
				876,
				SpeciesIndeedeeMale.Instance, // PokemonInstance Species
				"Indeedee-Male", level,
				Psychic.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Indeedee-Male Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public IndeedeeMale() : base(
			876,
			SpeciesIndeedeeMale.Instance, // PokemonInstance Species
			Psychic.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}