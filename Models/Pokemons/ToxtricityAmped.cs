using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Toxtricity-Amped Species to store common natural stats of all Toxtricity-Ampeds
	#region SpeciesToxtricity-Amped
	public class SpeciesToxtricityAmped : PokemonSpecies
	{
#nullable enable
		private static SpeciesToxtricityAmped? _instance = null;
#nullable restore
        public static SpeciesToxtricityAmped Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesToxtricityAmped();
                }
                return _instance;
            }
        }

		#region SpeciesToxtricity-Amped Constructor
		public SpeciesToxtricityAmped() : base(
			849,
			"Toxtricity-Amped",
			1.6,
			40.0,
			75, // HPs
			98, 70, // Attack & Defense
			114, 70, // Special Attack & Defense
			75		
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

	//Toxtricity-Amped PokemonInstance Class
	#region Toxtricity-Amped
	public class ToxtricityAmpedInstance : PokemonInstance
	{
		#region Toxtricity-Amped Constructors
		/// <summary>
		/// Toxtricity-Amped Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ToxtricityAmpedInstance(string nickname, int level)
		: base(
				SpeciesToxtricityAmped.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxtricity-Amped Builder only waiting for a Level
		/// </summary>
		public ToxtricityAmpedInstance(int level)
		: base(
				SpeciesToxtricityAmped.Instance, // PokemonInstance Species
				"Toxtricity-Amped", level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxtricity-Amped Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ToxtricityAmpedInstance() : base(
			SpeciesToxtricityAmped.Instance, // PokemonInstance Species
			Electric.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}