using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Charmander PokemonInstance Class
	#region Charmander
	public class Charmander : PokemonInstance
	{
		#region Charmander Constructors
		/// <summary>
		/// Charmander Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Charmander(string nickname, int level)
		: base(
				CharmanderSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmander Constructor only waiting for a Level
		/// </summary>
		public Charmander(int level)
		: this( "Charmander", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmander Constructor waiting for no params
		/// </summary>
		/*
		public Charmander() : this( "Charmander", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}