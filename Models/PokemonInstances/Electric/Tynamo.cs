using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tynamo PokemonInstance Class
	#region Tynamo
	public class Tynamo : PokemonInstance
	{
		#region Tynamo Constructors
		/// <summary>
		/// Tynamo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tynamo(string nickname, int level)
		: base(
				TynamoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tynamo Constructor only waiting for a Level
		/// </summary>
		public Tynamo(int level)
		: this( "Tynamo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tynamo Constructor waiting for no params
		/// </summary>
		/*
		public Tynamo() : this( "Tynamo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}