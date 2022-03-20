using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gothitelle PokemonInstance Class
	#region Gothitelle
	public class Gothitelle : PokemonInstance
	{
		#region Gothitelle Constructors
		/// <summary>
		/// Gothitelle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gothitelle(string nickname, int level)
		: base(
				GothitelleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothitelle Constructor only waiting for a Level
		/// </summary>
		public Gothitelle(int level)
		: this( "Gothitelle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothitelle Constructor waiting for no params
		/// </summary>
		/*
		public Gothitelle() : this( "Gothitelle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}