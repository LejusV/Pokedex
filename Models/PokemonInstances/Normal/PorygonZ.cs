using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Porygon-Z PokemonInstance Class
	#region Porygon-Z
	public class PorygonZ : PokemonInstance
	{
		#region Porygon-Z Constructors
		/// <summary>
		/// Porygon-Z Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PorygonZ(string nickname, int level)
		: base(
				PorygonZSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon-Z Constructor only waiting for a Level
		/// </summary>
		public PorygonZ(int level)
		: this( "Porygon-Z", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon-Z Constructor waiting for no params
		/// </summary>
		/*
		public PorygonZ() : this( "Porygon-Z", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}