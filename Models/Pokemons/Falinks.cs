using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Falinks Species to store common natural stats of all Falinkss
	#region SpeciesFalinks
	public class SpeciesFalinks : PokemonSpecies
	{
#nullable enable
		private static SpeciesFalinks? _instance = null;
#nullable restore
        public static SpeciesFalinks Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFalinks();
                }
                return _instance;
            }
        }

		#region SpeciesFalinks Constructor
		public SpeciesFalinks() : base(
			"Falinks",
			3.0,
			62.0,
			65, // HPs
			100, 100, // Attack & Defense
			70, 60, // Special Attack & Defense
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

	//Falinks PokemonInstance Class
	#region Falinks
	public class FalinksInstance : PokemonInstance
	{
		#region Falinks Constructors
		/// <summary>
		/// Falinks Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FalinksInstance(string nickname, int level)
		: base(
				870,
				SpeciesFalinks.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Falinks Builder only waiting for a Level
		/// </summary>
		public FalinksInstance(int level)
		: base(
				870,
				SpeciesFalinks.Instance, // PokemonInstance Species
				"Falinks", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Falinks Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Falinks() : base(
			870,
			SpeciesFalinks.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}