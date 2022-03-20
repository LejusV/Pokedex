using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zapdos PokemonInstance Class
	#region Zapdos
	public class Zapdos : PokemonInstance
	{
		#region Zapdos Constructors
		/// <summary>
		/// Zapdos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zapdos(string nickname, int level)
		: base(
				ZapdosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zapdos Constructor only waiting for a Level
		/// </summary>
		public Zapdos(int level)
		: this( "Zapdos", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zapdos Constructor waiting for no params
		/// </summary>
		/*
		public Zapdos() : this( "Zapdos", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}