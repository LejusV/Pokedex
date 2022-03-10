using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Smeargle Species to store common natural stats of all Smeargles
	#region SpeciesSmeargle
	public class SpeciesSmeargle : PokemonSpecies
	{
#nullable enable
		private static SpeciesSmeargle? _instance = null;
#nullable restore
        public static SpeciesSmeargle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSmeargle();
                }
                return _instance;
            }
        }

		#region SpeciesSmeargle Constructor
		public SpeciesSmeargle() : base(
			"Smeargle",
			1.2,
			58.0,
			55, // HPs
			20, 35, // Attack & Defense
			20, 45, // Special Attack & Defense
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
				"Sketch"
			};
		}
		#endregion
	}
	#endregion

	//Smeargle PokemonInstance Class
	#region Smeargle
	public class SmeargleInstance : PokemonInstance
	{
		#region Smeargle Constructors
		/// <summary>
		/// Smeargle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SmeargleInstance(string nickname, int level)
		: base(
				235,
				SpeciesSmeargle.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smeargle Builder only waiting for a Level
		/// </summary>
		public SmeargleInstance(int level)
		: base(
				235,
				SpeciesSmeargle.Instance, // PokemonInstance Species
				"Smeargle", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smeargle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Smeargle() : base(
			235,
			SpeciesSmeargle.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}