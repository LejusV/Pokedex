using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Regidrago Species to store common natural stats of all Regidragos
	#region SpeciesRegidrago
	public class SpeciesRegidrago : PokemonSpecies
	{
#nullable enable
		private static SpeciesRegidrago? _instance = null;
#nullable restore
        public static SpeciesRegidrago Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRegidrago();
                }
                return _instance;
            }
        }

		#region SpeciesRegidrago Constructor
		public SpeciesRegidrago() : base(
			"Regidrago",
			2.1,
			200.0,
			200, // HPs
			100, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Regidrago PokemonInstance Class
	#region Regidrago
	public class RegidragoInstance : PokemonInstance
	{
		#region Regidrago Constructors
		/// <summary>
		/// Regidrago Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RegidragoInstance(string nickname, int level)
		: base(
				895,
				SpeciesRegidrago.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regidrago Builder only waiting for a Level
		/// </summary>
		public RegidragoInstance(int level)
		: base(
				895,
				SpeciesRegidrago.Instance, // PokemonInstance Species
				"Regidrago", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regidrago Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Regidrago() : base(
			895,
			SpeciesRegidrago.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}