using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Porygon PokemonInstance Class
	#region Porygon
	public class Porygon : PokemonInstance
	{
		#region Porygon Constructors
		/// <summary>
		/// Porygon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Porygon(string nickname, int level)
		: base(
				PorygonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon Constructor only waiting for a Level
		/// </summary>
		public Porygon(int level)
		: this( "Porygon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon Constructor waiting for no params
		/// </summary>
		/*
		public Porygon() : this( "Porygon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}