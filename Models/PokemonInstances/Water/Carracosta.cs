using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Carracosta PokemonInstance Class
	#region Carracosta
	public class Carracosta : PokemonInstance
	{
		#region Carracosta Constructors
		/// <summary>
		/// Carracosta Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Carracosta(string nickname, int level)
		: base(
				CarracostaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carracosta Constructor only waiting for a Level
		/// </summary>
		public Carracosta(int level)
		: this( "Carracosta", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carracosta Constructor waiting for no params
		/// </summary>
		/*
		public Carracosta() : this( "Carracosta", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}