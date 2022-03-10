using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Arrokuda Species to store common natural stats of all Arrokudas
	#region SpeciesArrokuda
	public class SpeciesArrokuda : PokemonSpecies
	{
#nullable enable
		private static SpeciesArrokuda? _instance = null;
#nullable restore
        public static SpeciesArrokuda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArrokuda();
                }
                return _instance;
            }
        }

		#region SpeciesArrokuda Constructor
		public SpeciesArrokuda() : base(
			"Arrokuda",
			0.5,
			1.0,
			41, // HPs
			63, 40, // Attack & Defense
			40, 30, // Special Attack & Defense
			66		
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

	//Arrokuda PokemonInstance Class
	#region Arrokuda
	public class ArrokudaInstance : PokemonInstance
	{
		#region Arrokuda Constructors
		/// <summary>
		/// Arrokuda Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArrokudaInstance(string nickname, int level)
		: base(
				846,
				SpeciesArrokuda.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arrokuda Builder only waiting for a Level
		/// </summary>
		public ArrokudaInstance(int level)
		: base(
				846,
				SpeciesArrokuda.Instance, // PokemonInstance Species
				"Arrokuda", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arrokuda Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Arrokuda() : base(
			846,
			SpeciesArrokuda.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}